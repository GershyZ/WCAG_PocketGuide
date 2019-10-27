using System.Collections.Generic;
using WCAG_PocketGuide;
namespace WCAG_PocketGuide.Models
{
    public class Criteria : Grouping
    {
        public Criteria(string id, string name = "", string description="",Filters.WCAGLevel level = Filters.WCAGLevel.NONE, string version="") : base(id, name, description)
        {
            Level = level;
            Version = version;
            Elements = new List<Filters.ElementType>();
            Audiences = new List<Filters.AudienceType>();
        }

        public List<Filters.ElementType> Elements { get; }
        public List<Filters.AudienceType> Audiences { get; }
        public Filters.WCAGLevel Level {get; set; }
        public string Version { get; set; }                             
    }
}