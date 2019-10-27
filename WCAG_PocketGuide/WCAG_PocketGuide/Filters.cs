using System.Collections.Generic;
namespace WCAG_PocketGuide
{
    public static class Filters
    {
        public enum ElementType
        {
            BUTTON,
            CHECK_BOX,
            COMBO_BOX,
            DIALOG,
            EDIT_BOX,
            FRAME,
            HEADINGS,
            GRAPHIC,
            GRAPHIC_LINK,
            LINK,
            RADIO_BUTTON,
            TABLE,
            TEXT,
            WHOLE_PAGE
        }

        public static List<ElementType> Text_Elements = new List<ElementType>() { ElementType.HEADINGS, ElementType.TEXT };

        public static List<ElementType> NonText = new List<ElementType>() {
            ElementType.BUTTON,
            ElementType.CHECK_BOX,
            ElementType.COMBO_BOX,
            ElementType.DIALOG,
            ElementType.EDIT_BOX,
            ElementType.FRAME,
            ElementType.GRAPHIC,
            ElementType.GRAPHIC_LINK,
            ElementType.LINK,
            ElementType.RADIO_BUTTON,
            ElementType.TABLE,
            ElementType.WHOLE_PAGE
        };
        public static List<ElementType> Control_Elements = new List<ElementType>() {
            ElementType.BUTTON,
            ElementType.CHECK_BOX,
            ElementType.COMBO_BOX,
            ElementType.EDIT_BOX,
            ElementType.GRAPHIC_LINK,
            ElementType.LINK,
            ElementType.RADIO_BUTTON,            
        };

        public enum AudienceType
        {
            VISUAL,
            AUDIO,
            MOBILE,
            MENTAL
        }

        public enum WCAGLevel
        {
            A,
            AA,
            AAA,
            NONE
        }
    }
}