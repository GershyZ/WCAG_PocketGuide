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

        public List<Criteria> Criterion
        {
            get
            {
                List<Criteria> criterion = new List<Criteria>();
                for (int i = Content_Start; i < Content_Start + Content_Size; i++)
                {
                    criterion.Add(App.WCAG_Structure.Criterion[i]);
                }
                return criterion;
            }

        }
    }
}
