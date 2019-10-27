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
        public List<Guideline> Guidelines {
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
            _guidelines = new List<Guideline>();
            _criterion = new List<Criteria>();
            _principles = new Principle[] { new Principle("1", "Perceivable"), new Principle("2", "Operable"), new Principle("3", "Understandable"), new Principle("4", "Robust") };
            _guidelines.Add(new Guideline("1.1", "Text Alternatives"));
            _guidelines.Add(new Guideline("1.2","Time - based Media"));
            _guidelines.Add(new Guideline("1.3", "Adaptable"));
            _guidelines.Add(new Guideline("1.4","Distinguishable"));
            _principles[0].Content_Start = 0;
            _principles[0].Content_Size = _guidelines.Count;
            _guidelines.Add(new Guideline("2.1", "Keyboard Accessible"));
            _guidelines.Add(new Guideline("2.2", "Enough Time"));
            _guidelines.Add(new Guideline("2.3", "Seizures and Physical Reactions"));
            _guidelines.Add(new Guideline("2.4", "Navigable"));
            _guidelines.Add(new Guideline("2.5","Input Modalities"));
            _principles[1].Content_Start = _principles[0].Content_Start +_principles[0].Content_Size;
            _principles[1].Content_Size = _guidelines.Count - _principles[1].Content_Start;
            _guidelines.Add(new Guideline("3.1", "Readable"));
            _guidelines.Add(new Guideline("3.2", "Predictable"));
            _guidelines.Add(new Guideline("3.3", "Input Assistance"));
            _principles[2].Content_Start = _principles[1].Content_Start + _principles[1].Content_Start;
            _principles[2].Content_Size = _guidelines.Count - _principles[2].Content_Start;
            _guidelines.Add(new Guideline("4.1", "Compatible"));
            _principles[3].Content_Start = _principles[2].Content_Start + _principles[2].Content_Size;
            _principles[3].Content_Size = 1;
            _criterion = new List<Criteria>();
        }
    }
}
