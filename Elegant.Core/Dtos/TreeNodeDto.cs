using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elegant.Core.Dtos
{
    public class TreeNodeDto
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string Icon { get; set; }
        public bool Children { get; set; }
        public string Type { get; set; }
    }
}
