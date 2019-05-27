using System.Collections.Generic;

namespace DictionaryProject.Model
{
    public class Quiz
    {
        public Word word{ get; set; }
        public List<string> answers { get; set; }
        public int totalCount { get; set; } 
        public int selectedIndexItem { get; set; }
        public Quiz()
        {
            this.answers = new List<string>();
        }
    }
}
