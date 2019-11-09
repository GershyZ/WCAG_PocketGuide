using System.Collections.Generic;
using WCAG_PocketGuide;
using WCAG_PocketGuide.Models;

namespace WCAG_PocketGuide
{
    public class WCAG
    {
        Principle[] _principles;
        List<Guideline> _guidelines;
        List<Criteria> _criterion;

        public Principle[] Principles
        {
            get
            {
                return _principles;
            }
        }
        public List<Guideline> Guidelines
        {
            get
            {
                return _guidelines;
            }
        }
        public List<Criteria> Criterion
        {
            get { return _criterion; }
        }
        public WCAG()
        {
            int currparent = 0;            

            _principles = new Principle[] { new Principle("1", "Perceivable"), new Principle("2", "Operable"), new Principle("3", "Understandable"), new Principle("4", "Robust") };

            _populateGuidelines();

            for (int currguide = 0; currguide < _guidelines.Count & currparent < _principles.Length; currguide++)
            {
                if (!_guidelines[currguide].Id.StartsWith(_principles[currparent].Id))
                {
                    currparent++;
                    _principles[currparent].Content_Start = currguide;
                }
                _principles[currparent].Content_Size++;
            }
            _populateCriterion();
            currparent = 0;
        
            for(int currcrit = 0; currcrit<_criterion.Count & currparent < _guidelines.Count; currcrit++)
            {
                if (!_criterion[currcrit].Id.StartsWith(_guidelines[currparent].Id))
                {                  
                    currparent++;
                    _guidelines[currparent].Content_Start = currcrit;
                }
                _guidelines[currparent].Content_Size++;
            }            
        }
        private void _populateGuidelines()
        {
            _guidelines = new List<Guideline>();
            _guidelines.Add(new Guideline("1.1", "Text Alternatives"));
            _guidelines.Add(new Guideline("1.2", "Time - based Media"));
            _guidelines.Add(new Guideline("1.3", "Adaptable"));
            _guidelines.Add(new Guideline("1.4", "Distinguishable"));
            _guidelines.Add(new Guideline("2.1", "Keyboard Accessible"));
            _guidelines.Add(new Guideline("2.2", "Enough Time"));
            _guidelines.Add(new Guideline("2.3", "Seizures and Physical Reactions"));
            _guidelines.Add(new Guideline("2.4", "Navigable"));
            _guidelines.Add(new Guideline("2.5", "Input Modalities"));
            _guidelines.Add(new Guideline("3.1", "Readable"));
            _guidelines.Add(new Guideline("3.2", "Predictable"));
            _guidelines.Add(new Guideline("3.3", "Input Assistance"));
            _guidelines.Add(new Guideline("4.1", "Compatible"));

        }
        private void _populateCriterion()
        {
            _criterion = new List<Criteria>();

            _criterion.Add(new Criteria("1.1.1", "Non-text Content","",Filters.WCAGLevel.A,"2.0"));
            _criterion.Add(new Criteria("1.2.1", "Audio-only and Video-only (Prerecorded)","",Filters.WCAGLevel.A,"2.0"));
            _criterion.Add(new Criteria("1.2.2", "Captions (Prerecorded)","",Filters.WCAGLevel.A,"2.0"));
            _criterion.Add(new Criteria("1.2.3", "Audio Description or Media Alternative (Prerecorded)","",Filters.WCAGLevel.A,"2.0"));
            _criterion.Add(new Criteria("1.2.4", "Captions (Live)","",Filters.WCAGLevel.AA,"2.0"));
            _criterion.Add(new Criteria("1.2.5", "Audio Description (Prerecorded)","",Filters.WCAGLevel.AA,"2.0"));
            _criterion.Add(new Criteria("1.2.6", "Sign Language (Prerecorded)","",Filters.WCAGLevel.AAA,"2.0"));
            _criterion.Add(new Criteria("1.2.7", "Extended Audio Description (Prerecorded)","",Filters.WCAGLevel.AAA,"2.0"));
            _criterion.Add(new Criteria("1.2.8", "Media Alternative (Prerecorded)","",Filters.WCAGLevel.AAA,"2.0"));
            _criterion.Add(new Criteria("1.2.9", "Audio-only (Live)","",Filters.WCAGLevel.AAA,"2.0"));
            _criterion.Add(new Criteria("1.3.1", "Info and Relationships","",Filters.WCAGLevel.A,"2.0"));
            _criterion.Add(new Criteria("1.3.2", "Meaningful Sequence","",Filters.WCAGLevel.A,"2.0"));
            _criterion.Add(new Criteria("1.3.3", "Sensory Characteristics","",Filters.WCAGLevel.A,"2.0"));
            _criterion.Add(new Criteria("1.3.4", "Orientation","",Filters.WCAGLevel.AA,"2.1"));
            _criterion.Add(new Criteria("1.3.5", "Identify Input Purpose","",Filters.WCAGLevel.AA,"2.1"));
            _criterion.Add(new Criteria("1.3.6", "Identify Purpose","",Filters.WCAGLevel.AAA,"2.1"));
            _criterion.Add(new Criteria("1.4.1", "Use of Color","",Filters.WCAGLevel.A,"2.0"));
            _criterion.Add(new Criteria("1.4.2", "Audio Control","",Filters.WCAGLevel.A,"2.0"));
            _criterion.Add(new Criteria("1.4.3", "Contrast (Minimum)","",Filters.WCAGLevel.AA,"2.0"));
            _criterion.Add(new Criteria("1.4.4", "Resize text","",Filters.WCAGLevel.AA,"2.0"));
            _criterion.Add(new Criteria("1.4.5", "Images of Text","",Filters.WCAGLevel.AA,"2.0"));
            _criterion.Add(new Criteria("1.4.6", "Contrast (Enhanced)","",Filters.WCAGLevel.AAA,"2.0"));
            _criterion.Add(new Criteria("1.4.7", "Low or No Background Audio","",Filters.WCAGLevel.AAA,"2.0"));
            _criterion.Add(new Criteria("1.4.8", "Visual Presentation","",Filters.WCAGLevel.AAA,"2.0"));
            _criterion.Add(new Criteria("1.4.9", "Images of Text (No Exception)","",Filters.WCAGLevel.AAA,"2.0"));
            _criterion.Add(new Criteria("1.4.10", "Reflow","",Filters.WCAGLevel.AA,"2.1"));
            _criterion.Add(new Criteria("1.4.11", "Non-text Contrast","",Filters.WCAGLevel.AA, "2.1"));
            _criterion.Add(new Criteria("1.4.12", "Text Spacing","",Filters.WCAGLevel.AA, "2.1"));
            _criterion.Add(new Criteria("1.4.13", "Content on Hover or Focus","",Filters.WCAGLevel.AA,"2.1"));
            _criterion.Add(new Criteria("2.1.1", "Keyboard","",Filters.WCAGLevel.A,"2.0"));
            _criterion.Add(new Criteria("2.1.2", "No Keyboard Trap","",Filters.WCAGLevel.A,"2.0"));
            _criterion.Add(new Criteria("2.1.3", "Keyboard (No Exception)","",Filters.WCAGLevel.AAA,"2.0"));
            _criterion.Add(new Criteria("2.1.4", "Character Key Shortcuts","",Filters.WCAGLevel.A, "2.1"));
            _criterion.Add(new Criteria("2.2.1", "Timing Adjustable","",Filters.WCAGLevel.A,"2.0"));
            _criterion.Add(new Criteria("2.2.2", "Pause, Stop, Hide","",Filters.WCAGLevel.A,"2.0"));
            _criterion.Add(new Criteria("2.2.3", "No Timing","",Filters.WCAGLevel.AAA,"2.0"));
            _criterion.Add(new Criteria("2.2.4", "Interruptions","",Filters.WCAGLevel.AAA,"2.0"));
            _criterion.Add(new Criteria("2.2.5", "Re-authenticating","",Filters.WCAGLevel.AAA,"2.0"));
            _criterion.Add(new Criteria("2.2.6", "Timeouts","",Filters.WCAGLevel.AAA, "2.1"));
            _criterion.Add(new Criteria("2.3.1", "Three Flashes or Below Threshold","",Filters.WCAGLevel.A,"2.0"));
            _criterion.Add(new Criteria("2.3.2", "Three Flashes","",Filters.WCAGLevel.AAA,"2.0"));
            _criterion.Add(new Criteria("2.3.3", "Animation from Interactions","",Filters.WCAGLevel.AAA, "2.1"));
            _criterion.Add(new Criteria("2.4.1", "Bypass Blocks","",Filters.WCAGLevel.A,"2.0"));
            _criterion.Add(new Criteria("2.4.2", "Page Titled","",Filters.WCAGLevel.A,"2.0"));
            _criterion.Add(new Criteria("2.4.3", "Focus Order","",Filters.WCAGLevel.A,"2.0"));
            _criterion.Add(new Criteria("2.4.4", "Link Purpose (In Context)","",Filters.WCAGLevel.A,"2.0"));
            _criterion.Add(new Criteria("2.4.5", "Multiple Ways","",Filters.WCAGLevel.AA,"2.0"));
            _criterion.Add(new Criteria("2.4.6", "Headings and Labels","",Filters.WCAGLevel.AA,"2.0"));
            _criterion.Add(new Criteria("2.4.7", "Focus Visible","",Filters.WCAGLevel.AA,"2.0"));
            _criterion.Add(new Criteria("2.4.8", "Location","",Filters.WCAGLevel.AAA,"2.0"));
            _criterion.Add(new Criteria("2.4.9", "Link Purpose (Link Only)","",Filters.WCAGLevel.AAA,"2.0"));
            _criterion.Add(new Criteria("2.4.10", "Section Headings","",Filters.WCAGLevel.AAA,"2.0"));
            _criterion.Add(new Criteria("2.5.1", "Pointer Gestures","",Filters.WCAGLevel.A, "2.1"));
            _criterion.Add(new Criteria("2.5.2", "Pointer Cancellation","",Filters.WCAGLevel.A, "2.1"));
            _criterion.Add(new Criteria("2.5.3", "Label in Name","",Filters.WCAGLevel.A, "2.1"));
            _criterion.Add(new Criteria("2.5.4", "Motion Actuation","",Filters.WCAGLevel.A, "2.1"));
            _criterion.Add(new Criteria("2.5.5", "Target Size","",Filters.WCAGLevel.AAA, "2.1"));
            _criterion.Add(new Criteria("2.5.6", "Concurrent Input Mechanisms","",Filters.WCAGLevel.AAA, "2.1"));
            _criterion.Add(new Criteria("3.1.1", "Language of Page","",Filters.WCAGLevel.A,"2.0"));
            _criterion.Add(new Criteria("3.1.2", "Language of Parts","",Filters.WCAGLevel.AA,"2.0"));
            _criterion.Add(new Criteria("3.1.3", "Unusual Words","",Filters.WCAGLevel.AAA,"2.0"));
            _criterion.Add(new Criteria("3.1.4", "Abbreviations","",Filters.WCAGLevel.AAA,"2.0"));
            _criterion.Add(new Criteria("3.1.5", "Reading Level","",Filters.WCAGLevel.AAA,"2.0"));
            _criterion.Add(new Criteria("3.1.6", "Pronunciation","",Filters.WCAGLevel.AAA,"2.0"));
            _criterion.Add(new Criteria("3.2.1", "On Focus","",Filters.WCAGLevel.A,"2.0"));
            _criterion.Add(new Criteria("3.2.2", "On Input","",Filters.WCAGLevel.A,"2.0"));
            _criterion.Add(new Criteria("3.2.3", "Consistent Navigation","",Filters.WCAGLevel.AA,"2.0"));
            _criterion.Add(new Criteria("3.2.4", "Consistent Identification","",Filters.WCAGLevel.AA,"2.0"));
            _criterion.Add(new Criteria("3.2.5", "Change on Request","",Filters.WCAGLevel.AAA,"2.0"));
            _criterion.Add(new Criteria("3.3.1", "Error Identification","",Filters.WCAGLevel.A,"2.0"));
            _criterion.Add(new Criteria("3.3.2", "Labels or Instructions","",Filters.WCAGLevel.A,"2.0"));
            _criterion.Add(new Criteria("3.3.3", "Error Suggestion","",Filters.WCAGLevel.AA,"2.0"));
            _criterion.Add(new Criteria("3.3.4", "Error Prevention (Legal, Financial, Data)","",Filters.WCAGLevel.AAA,"2.0"));
            _criterion.Add(new Criteria("3.3.5", "Help","",Filters.WCAGLevel.AAA,"2.0"));
            _criterion.Add(new Criteria("3.3.6", "Error Prevention (All)","",Filters.WCAGLevel.AAA,"2.0"));
            _criterion.Add(new Criteria("4.1.1", "Parsing","",Filters.WCAGLevel.A,"2.0"));
            _criterion.Add(new Criteria("4.1.2","Name, Role, Value","",Filters.WCAGLevel.A,"2.0"));
            _criterion.Add(new Criteria("4.1.3", "Status Messages","",Filters.WCAGLevel.A, "2.1"));


        }
    }
}