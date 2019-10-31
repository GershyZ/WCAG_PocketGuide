using System.Collections.Generic;
using WCAG_PocketGuide;
namespace WCAG_PocketGuide.Models
{
    public class Criteria :PocketGuideItem
    {
        public Criteria(string id, string name = "", string description = "", Filters.WCAGLevel level = Filters.WCAGLevel.NONE, string version = "")
        {
            Id = id;
            Name = name;
            Description = description;
            Level = level;
            Version = version;
            Elements = new List<Filters.ElementType>();
            Audiences = new List<Filters.AudienceType>();
            Examples = new List<string>();
        }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Filters.ElementType> Elements { get; }
        public List<Filters.AudienceType> Audiences { get; }
        public Filters.WCAGLevel Level { get; set; }
        public List<string> Examples { get; set; }
        public string Version { get; set; }
        public string Heading { get { return Id + ":" + Name; } }
    }
}