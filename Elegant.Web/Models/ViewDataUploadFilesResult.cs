using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.StaticFiles;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Elegant.Web.Models
{
    public class ViewDataUploadFilesResult
    {
        public string Name { get; set; }
        public long Size { get; set; }
        public string Type { get; set; }
        public string Url { get; set; }
        public string DeleteUrl { get; set; }
        public string ThumbnailUrl { get; set; }
        public string DeleteType { get; set; }
    }

    public class JsonFiles
    {
        public ViewDataUploadFilesResult[] Files { get; private set; }
        public string TempFolder { get; set; }
        public JsonFiles(List<ViewDataUploadFilesResult> filesList)
        {
            Files = filesList.ToArray();
        }
    }

    public class FilesHelper
    {
        readonly string deleteURL = null;
        readonly string deleteType = null;
        readonly string storageRoot = null;
        readonly string urlBase = null;
        public FilesHelper(string deleteURL, string deleteType, string storageRoot, string urlBase)
        {
            this.deleteURL = deleteURL;
            this.deleteType = deleteType;
            this.storageRoot = storageRoot;
            this.urlBase = urlBase;
        }

        public string DeleteFile(string file)
        {
            string fullPath = Path.Combine(storageRoot, file);
            string partThumb1 = Path.Combine(storageRoot, "thumbs");
            string partThumb2 = Path.Combine(partThumb1, Path.GetFileNameWithoutExtension(file) + "x80.jpg");

            System.Diagnostics.Debug.WriteLine(partThumb2);
            System.Diagnostics.Debug.WriteLine(File.Exists(partThumb2));
            if (File.Exists(fullPath))
            {
                //delete thumb 
                if (File.Exists(partThumb2))
                {
                    File.Delete(partThumb2);
                }
                File.Delete(fullPath);
                string succesMessage = "Ok";
                return succesMessage;
            }
            string failMessage = "Error Delete";
            return failMessage;
        }
        public JsonFiles GetFileList()
        {
            var r = new List<ViewDataUploadFilesResult>();
            string fullPath = Path.Combine(storageRoot);
            if (Directory.Exists(fullPath))
            {
                DirectoryInfo dir = new DirectoryInfo(fullPath);
                foreach (FileInfo file in dir.GetFiles())
                {
                    string contentType;
                    new FileExtensionContentTypeProvider().TryGetContentType(file.Name, out contentType);
                    if (contentType == null)
                    {
                        contentType = "application/octet-stream";
                    }
                    r.Add(UploadResult(file.Name, file.Length, contentType));
                }

            }
            JsonFiles files = new JsonFiles(r);

            return files;
        }

        public void UploadAndShowResults(HttpRequest httpRequest, List<ViewDataUploadFilesResult> resultList)
        {
            string fullPath = Path.Combine(storageRoot);
            Directory.CreateDirectory(fullPath);
            // Create new folder for thumbs
            Directory.CreateDirectory(fullPath + "/thumbs/");

            UploadWholeFile(httpRequest, resultList);
        }


        private void UploadWholeFile(HttpRequest request, List<ViewDataUploadFilesResult> statuses)
        {
            for (int i = 0; i < request.Form.Files.Count; i++)
            {
                var file = request.Form.Files[i];
                string pathOnServer = Path.Combine(storageRoot);
                var fullPath = Path.Combine(pathOnServer, Path.GetFileName(file.FileName));
                using (var stream = File.Create(fullPath))
                {
                    file.CopyTo(stream);
                }

                //Create thumb
                string[] imageArray = file.FileName.Split('.');
                if (imageArray.Length != 0)
                {
                    string extansion = imageArray[imageArray.Length - 1].ToLower();
                    if (extansion != "jpg" && extansion != "png" && extansion != "jpeg") //Do not create thumb if file is not an image
                    {

                    }
                    else
                    {
                        var ThumbfullPath = Path.Combine(pathOnServer, "thumbs");
                        //string fileThumb = file.FileName + ".80x80.jpg";
                        string fileThumb = Path.GetFileNameWithoutExtension(file.FileName) + "x80.jpg";
                        var ThumbfullPath2 = Path.Combine(ThumbfullPath, fileThumb);
                        using var image = Image.FromFile(fullPath);
                        using var thumb = image.GetThumbnailImage(80, 80, null, System.IntPtr.Zero);
                        thumb.Save(ThumbfullPath2, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                }
                statuses.Add(UploadResult(file.FileName, file.Length, file.ContentType));
            }
        }

        public ViewDataUploadFilesResult UploadResult(string fileName, long fileSize, string contentType)
        {
            var result = new ViewDataUploadFilesResult()
            {
                Name = fileName,
                Size = fileSize,
                Type = contentType,
                Url = urlBase + fileName,
                DeleteUrl = deleteURL + fileName,
                ThumbnailUrl = CheckThumb(contentType, fileName),
                DeleteType = deleteType,
            };
            return result;
        }

        public string CheckThumb(string type, string FileName)
        {
            var splited = type.Split('/');
            if (splited.Length == 2)
            {
                string extansion = splited[1].ToLower();
                if (extansion.Equals("jpeg") || extansion.Equals("jpg") || extansion.Equals("png") || extansion.Equals("gif"))
                {
                    string thumbnailUrl = urlBase + "thumbs/" + Path.GetFileNameWithoutExtension(FileName) + "x80.jpg";
                    return thumbnailUrl;
                }
                else
                {
                    if (extansion.Equals("octet-stream")) //Fix for exe files
                    {
                        return "/Content/Free-file-icons/48px/exe.png";

                    }
                    if (extansion.Contains("zip")) //Fix for exe files
                    {
                        return "/Content/Free-file-icons/48px/zip.png";
                    }
                    string thumbnailUrl = "/Content/Free-file-icons/48px/" + extansion + ".png";
                    return thumbnailUrl;
                }
            }
            else
            {
                return urlBase + "/thumbs/" + Path.GetFileNameWithoutExtension(FileName) + "x80.jpg";
            }

        }
    }
}
