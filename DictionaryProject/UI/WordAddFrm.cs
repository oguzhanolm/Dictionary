using DictionaryProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DictionaryProject
{
    public partial class WordAddFrm : Form
    {
        public WordAddFrm()
        {
            InitializeComponent();
            cbbType.SelectedIndex = 0;
        }

        private void btnAddWord_Click(object sender, EventArgs e)
        {
            if (txtEnglish.Text.Trim() != string.Empty && txtTurkish.Text.Trim() != string.Empty && txtSample.Text != string.Empty)
                AddNewWord();
            else
                MessageBox.Show("Lütfen alanları eksiksiz giriniz");
        }

        private void AddNewWord()
        {
            Word newWord = DictionaryCRUD.GetAllWords().Where(q => q.english.Contains(txtEnglish.Text.Trim()) || q.turkish.Contains(txtTurkish.Text.Trim())).FirstOrDefault();

            if (newWord != null)
            {
                MessageBox.Show("Girdiğimiz kelime zaten kayıtlı!!!");
                return;
            }

            var word = new Word
         {
             english = txtEnglish.Text.Trim(),
             turkish = txtTurkish.Text.Trim(),
             type = cbbType.SelectedItem.ToString(),
             sample = txtSample.Text.Trim()
         };

            List<Word> wordList = DictionaryCRUD.GetAllWords();

            word.id = wordList.Count + 1;
            wordList.Add(word);

            var result = DictionaryCRUD.WriteRecords(wordList);
            if (result)
                MessageBox.Show("Kelime işleminiz başarılı!!!");
        }

        private void WordAddFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
