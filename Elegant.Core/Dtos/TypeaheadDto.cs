using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elegant.Core.Dtos
{
    public class TypeaheadDto
    {
        public string Desc { get; set; }
        public string Img { get; set; }
        public List<string> Tokens { get; set; }
        public string Value { get; set; }
    }
}
