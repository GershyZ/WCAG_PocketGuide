using System;
using System.Collections.Generic;
using System.Text;

namespace WCAG_PocketGuide.Models
{
    interface PocketGuideItem
    {
        string Id { get; set; }
        string Name { get; set; }
        string Heading { get; }
        string Description { get; set; }
    }
}
