using System.Collections.Generic;
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

            _criterion.Add(new Criteria("1.1.1", "Non-text Content"));
            _criterion.Add(new Criteria("1.2.1", "Audio-only and Video-only (Prerecorded)"));
            _criterion.Add(new Criteria("1.2.2", "Captions (Prerecorded)"));
            _criterion.Add(new Criteria("1.2.3", "Audio Description or Media Alternative (Prerecorded)"));
            _criterion.Add(new Criteria("1.2.4", "Captions (Live)"));
            _criterion.Add(new Criteria("1.2.5", "Audio Description (Prerecorded)"));
            _criterion.Add(new Criteria("1.2.6", "Sign Language (Prerecorded)"));
            _criterion.Add(new Criteria("1.2.7", "Extended Audio Description (Prerecorded)"));
            _criterion.Add(new Criteria("1.2.8", "Media Alternative (Prerecorded)"));
            _criterion.Add(new Criteria("1.2.9", "Audio-only (Live)"));
            _criterion.Add(new Criteria("1.3.1", "Info and Relationships"));
            _criterion.Add(new Criteria("1.3.2", "Meaningful Sequence"));
            _criterion.Add(new Criteria("1.3.3", "Sensory Characteristics"));
            _criterion.Add(new Criteria("1.3.4", "Orientation"));
            _criterion.Add(new Criteria("1.3.5", "Identify Input Purpose"));
            _criterion.Add(new Criteria("1.3.6", "Identify Purpose"));
            _criterion.Add(new Criteria("1.4.1", "Use of Color"));
            _criterion.Add(new Criteria("1.4.2", "Audio Control"));
            _criterion.Add(new Criteria("1.4.3", "Contrast (Minimum)"));
            _criterion.Add(new Criteria("1.4.4", "Resize text"));
            _criterion.Add(new Criteria("1.4.5", "Images of Text"));
            _criterion.Add(new Criteria("1.4.6", "Contrast (Enhanced)"));
            _criterion.Add(new Criteria("1.4.7", "Low or No Background Audio"));
            _criterion.Add(new Criteria("1.4.8", "Visual Presentation"));
            _criterion.Add(new Criteria("1.4.9", "Images of Text (No Exception)"));
            _criterion.Add(new Criteria("1.4.10", "Reflow"));
            _criterion.Add(new Criteria("1.4.11", "Non-text Contrast"));
            _criterion.Add(new Criteria("1.4.12", "Text Spacing"));
            _criterion.Add(new Criteria("1.4.13", "Content on Hover or Focus"));
            _criterion.Add(new Criteria("2.1.1", "Keyboard"));
            _criterion.Add(new Criteria("2.1.2", "No Keyboard Trap"));
            _criterion.Add(new Criteria("2.1.3", "Keyboard (No Exception)"));
            _criterion.Add(new Criteria("2.1.4", "Character Key Shortcuts"));
            _criterion.Add(new Criteria("2.2.1", "Timing Adjustable"));
            _criterion.Add(new Criteria("2.2.2", "Pause, Stop, Hide"));
            _criterion.Add(new Criteria("2.2.3", "No Timing"));
            _criterion.Add(new Criteria("2.2.4", "Interruptions"));
            _criterion.Add(new Criteria("2.2.5", "Re-authenticating"));
            _criterion.Add(new Criteria("2.2.6", "Timeouts"));
            _criterion.Add(new Criteria("2.3.1", "Three Flashes or Below Threshold"));
            _criterion.Add(new Criteria("2.3.2", "Three Flashes"));
            _criterion.Add(new Criteria("2.3.3", "Animation from Interactions"));
            _criterion.Add(new Criteria("2.4.1", "Bypass Blocks"));
            _criterion.Add(new Criteria("2.4.2", "Page Titled"));
            _criterion.Add(new Criteria("2.4.3", "Focus Order"));
            _criterion.Add(new Criteria("2.4.4", "Link Purpose (In Context)"));
            _criterion.Add(new Criteria("2.4.5", "Multiple Ways"));
            _criterion.Add(new Criteria("2.4.6", "Headings and Labels"));
            _criterion.Add(new Criteria("2.4.7", "Focus Visible"));
            _criterion.Add(new Criteria("2.4.8", "Location"));
            _criterion.Add(new Criteria("2.4.9", "Link Purpose (Link Only)"));
            _criterion.Add(new Criteria("2.4.10", "Section Headings"));
            _criterion.Add(new Criteria("2.5.1", "Pointer Gestures"));
            _criterion.Add(new Criteria("2.5.2", "Pointer Cancellation"));
            _criterion.Add(new Criteria("2.5.3", "Label in Name"));
            _criterion.Add(new Criteria("2.5.4", "Motion Actuation"));
            _criterion.Add(new Criteria("2.5.5", "Target Size"));
            _criterion.Add(new Criteria("2.5.6", "Concurrent Input Mechanisms"));
            _criterion.Add(new Criteria("3.1.1", "Language of Page"));
            _criterion.Add(new Criteria("3.1.2", "Language of Parts"));
            _criterion.Add(new Criteria("3.1.3", "Unusual Words"));
            _criterion.Add(new Criteria("3.1.4", "Abbreviations"));
            _criterion.Add(new Criteria("3.1.5", "Reading Level"));
            _criterion.Add(new Criteria("3.1.6", "Pronunciation"));
            _criterion.Add(new Criteria("3.2.1", "On Focus"));
            _criterion.Add(new Criteria("3.2.2", "On Input"));
            _criterion.Add(new Criteria("3.2.3", "Consistent Navigation"));
            _criterion.Add(new Criteria("3.2.4", "Consistent Identification"));
            _criterion.Add(new Criteria("3.2.5", "Change on Request"));
            _criterion.Add(new Criteria("3.3.1", "Error Identification"));
            _criterion.Add(new Criteria("3.3.2", "Labels or Instructions"));
            _criterion.Add(new Criteria("3.3.3", "Error Suggestion"));
            _criterion.Add(new Criteria("3.3.4", "Error Prevention (Legal, Financial, Data)"));
            _criterion.Add(new Criteria("3.3.5", "Help"));
            _criterion.Add(new Criteria("3.3.6", "Error Prevention (All)"));
            _criterion.Add(new Criteria("4.1.1", "Parsing"));
            _criterion.Add(new Criteria("4.1.2","Name, Role, Value"));
            _criterion.Add(new Criteria("4.1.3", "Status Messages"));


        }
    }
}
