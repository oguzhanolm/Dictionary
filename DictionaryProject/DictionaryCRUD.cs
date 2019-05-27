using CsvHelper;
using DictionaryProject.Model;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DictionaryProject
{
    public class DictionaryCRUD
    {
        public static List<Word> GetAllWords()
        {
            using (var sr = new StreamReader(Path.GetDirectoryName(Application.ExecutablePath) + "\\file.csv"))
            {
                var reader = new CsvReader(sr);
                
                return reader.GetRecords<Word>().ToList();
            }
        }

        public static bool WriteRecords(List<Word> wordList)
        {
            using (var writer = new StreamWriter(Path.GetDirectoryName(Application.ExecutablePath) + "\\file.csv", false, Encoding.UTF8))
            {
                using (var csv = new CsvWriter(writer))
                    csv.WriteRecords(wordList);
            }

            return true;
        }
    }
}
