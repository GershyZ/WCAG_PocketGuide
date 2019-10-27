using System;
using System.Collections.Generic;
using System.Text;

namespace WCAG_PocketGuide.Models
{
    public class Guideline : Grouping
    {
        public Guideline(string id, string name = "", string description = "") : base(id, name, description)
        {

        }

        public Criteria[] Criterion
        {
            get
            {
                Criteria[] arr = new Criteria[Content_Size];
                for (int i = Content_Start; i < Content_Start + Content_Size; i++)
                {
                    arr[i - Content_Start] = App.WCAG_Structure.Criterion[i];
                }
                return arr;
            }

        }
    }
}
