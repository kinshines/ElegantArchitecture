using Elegant.Core.Dtos;
using NAutowired.Core.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elegant.Infrastructure.Services
{
    [Service]
    public class DemoService
    {
        public List<TreeNodeDto> AjaxTreeData(string parent)
        {
            var rand = new Random();
            var list = new List<TreeNodeDto>();
            var childCount = rand.Next(1,4);
            for (int i= 0;i < childCount; i++)
            {
                var folder = rand.Next(3) > 0;
                var tick = DateTime.Now.Ticks;
                var node = new TreeNodeDto()
                {
                    Id = "Node_" + tick,
                    Text = "Node_" + tick,
                    Icon = "fa icon-lg icon-state-warning " + (folder ? "fa-folder" : "fa-file"),
                    Children = folder
                };
                list.Add(node);
            }
            return list;
        }
        
        public List<TypeaheadDto> AjaxHeadData(string query)
        {
            var rand = new Random();
            var list = new List<TypeaheadDto>();
            for(int i = 0; i < 6; i++)
            {
                var sub = rand.Next(10, 100);
                var dto = new TypeaheadDto()
                {
                    Desc = "some description goes here...",
                    Img = "http://lorempixel.com/50/50/?" + DateTime.Now.Ticks,
                    Tokens = new List<string> { query, query + sub },
                    Value = query + " - " + sub
                };
                list.Add(dto);
            }
            return list;
        }
    }
}
