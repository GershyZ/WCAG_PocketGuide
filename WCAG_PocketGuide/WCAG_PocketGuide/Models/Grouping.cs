using System.Collections.Generic;
using System.Text;

namespace WCAG_PocketGuide.Models
{
    public class Grouping:PocketGuideItem
    {
        public int Content_Start { get; set; }
        public int Content_Size { get; set; }
        public Grouping(string id, string name="",string description = ""):base(id,name,description)
        {
            Content_Size = 0;
            Content_Start = 0;
        }
    }
}    