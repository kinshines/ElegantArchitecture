using System;
using System.Collections.Generic;
using System.Text;

namespace Elegant.Core.Dtos
{
    public class ColorDto
    {
        public ColorDto(string colorEng,string number)
        {
            ColorEng = colorEng;
            ColorNumber = "#" + number;
        }
        public string ColorEng { get; set; }
        public string ColorNumber { get; set; }
        public string ModalId
        {
            get
            {
                return "demo_modal_" + ColorEng;
            }
        }
        public string ModalIdAnchor
        {
            get
            {
                return "#" + ModalId;
            }
        }
        public string FontColor
        {
            get
            {
                return "font-" + ColorEng;
            }
        }
        public string BackgroundColor
        {
            get
            {
                return "bg-" + ColorEng;
            }
        }
        public string BorderColor
        {
            get
            {
                return "border-" + ColorEng;
            }
        }
        public string FontBackgroundColor
        {
            get
            {
                return "bg-font-" + ColorEng;
            }
        }
        public string Tab1Id
        {
            get
            {
                return ColorEng + "_tab_1_content";
            }
        }
        public string Tab1IdAnchor
        {
            get
            {
                return "#"+ Tab1Id;
            }
        }
        public string Tab2Id
        {
            get
            {
                return ColorEng + "_tab_2_content";
            }
        }
        public string Tab2IdAnchor
        {
            get
            {
                return "#" + Tab2Id;
            }
        }
        public string Tab3Id
        {
            get
            {
                return ColorEng + "_tab_3_content";
            }
        }
        public string Tab3IdAnchor
        {
            get
            {
                return "#" + Tab3Id;
            }
        }
        public string Tab4Id
        {
            get
            {
                return ColorEng + "_tab_4_content";
            }
        }
        public string Tab4IdAnchor
        {
            get
            {
                return "#" + Tab4Id;
            }
        }
    }
}
