using DictionaryProject.Model;
using DictionaryProject.UI;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DictionaryProject
{
    public partial class QuizFrm : Form
    {
        public QuizFrm()
        {
            InitializeComponent();
        }

        private void QuizFrm_Load(object sender, EventArgs e)
        {
            FillWords();
        }

        private void FillWords()
        {
            var wordList = DictionaryCRUD.GetAllWords();

            if (wordList.Any())
            {
                int index = 0;
                foreach (var word in wordList)
                {
                    checkedListBox1.Items.Add(new CheckListBoxItem()
                    {
                        Tag = word,
                        Text = word.english,
                        Index = index
                    });
                    index++;
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            System.Collections.Generic.List<CheckListBoxItem> items = checkedListBox1.CheckedItems.Cast<CheckListBoxItem>().ToList();
            if (items.Any())
            {
                foreach (var item in items)
                    AddDataToTempTest(item);
            }
            showForm();
        }

        private void showForm()
        {
            if (QuizData.quizList.Count > 0)
            {
                QAfrm frm = new QAfrm();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen kelime seçiniz");
            }
        }

        private void AddDataToTempTest(CheckListBoxItem item)
        {
            var quiz = new Quiz { word = item.Tag as Word, selectedIndexItem = item.Index };
            var row = QuizData.quizList.Where(q => q.word.id == quiz.word.id).FirstOrDefault();

            if (row == null)
                QuizData.quizList.Add(quiz);
            else if (row.totalCount > 2)
            {
                QuizData.quizList.Remove(row);
                RemoveCheckedItems(row.selectedIndexItem);
            }
        }

        private void RemoveCheckedItems(int index)
        {
            checkedListBox1.SetItemChecked(index, false);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //RemoveCheckedItems();
        }
    }
}
