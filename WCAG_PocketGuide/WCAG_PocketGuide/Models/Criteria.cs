using Newtonsoft.Json;
using System.Collections.Generic;
using WCAG_PocketGuide;
using WCAG_PocketGuide.Helpers;

namespace WCAG_PocketGuide.Models
{
    public class Criteria : PocketGuideItem
    {
        public Criteria(string id, string name = "", string description = "", Filters.WCAGLevel level = Filters.WCAGLevel.NONE, string version = ""):base(id,name,description)
        {
            Level = level;
            Version = version;
            Elements = new List<Filters.ElementType>();
            Audiences = new List<Filters.AudienceType>();
            Examples = new List<string>();
        }

        public void addExample(string example)
        {
            this.Examples.Add(example);

            var list = JsonConvert.DeserializeObject<List<Criteria>>(Settings.CriteriaSetting);
            foreach(Criteria c in list){
                if(this.Id.Equals(c.Id))
                {
                    c.Examples.Add(example);
                }
            }
            var json = JsonConvert.SerializeObject(list);
            //Save
            Settings.CriteriaSetting = json;
        }
        public List<Filters.ElementType> Elements { get; }
        public List<Filters.AudienceType> Audiences { get; }
        public Filters.WCAGLevel Level { get; set; }
        public List<string> Examples { get; set; }
        public string Version { get; set; }
        
    }
}