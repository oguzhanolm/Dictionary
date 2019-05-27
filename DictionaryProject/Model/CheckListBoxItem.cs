namespace DictionaryProject.Model
{
    public class CheckListBoxItem
    {
        public object Tag;
        public string Text;
        public int Index { get; set; }
        public override string ToString() { return Text; }
    }
}
