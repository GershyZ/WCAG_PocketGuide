using System.Collections.Generic;

namespace WCAG_PocketGuide.Models
{
    public class Principle : Grouping
    {
        public Principle(string id, string name = "", string description = "") : base(id, name, description)
        {

        }
        public Guideline[] Guidelines
        {
            get
            {
                Guideline[] arr = new Guideline[Content_Size];
                for (int i = Content_Start; i < Content_Start + Content_Size; i++)
                {
                    arr[i - Content_Start] = App.WCAG_Structure.Guidelines[i];
                }
                return arr;
            }
        }
    }
}