namespace DictionaryProject.Model
{
    public class Word
    {
        public int id { get; set; } = 0;
        public string turkish { get; set; } 
        public string english { get; set; }
        public string type { get; set; }
        public string sample { get; set; }
        public Word() { }
    }
}
