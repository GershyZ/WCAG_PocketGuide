using System;
using System.Collections.Generic;
using System.Text;

namespace WCAG_PocketGuide.Models
{
    public abstract class PocketGuideItem
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public string Heading { get { return Id + ": " + Name; } }
        public string Description { get; set; }
        public PocketGuideItem(string id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }
    }
}
