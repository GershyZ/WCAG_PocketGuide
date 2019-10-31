using System.Collections.Generic;
using System.Text;

namespace WCAG_PocketGuide.Models
{
    public class Grouping:PocketGuideItem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Heading { get
            {
                return Id + ": " + Name;
            } 
        }
        public string Description { get; set; }
        public int Content_Start { get; set; }
        public int Content_Size { get; set; }
        public Grouping(string id, string name="",string description = "")
        {
            Id = id;            
            Name = name;
            Description = description;
        }
    }
}    