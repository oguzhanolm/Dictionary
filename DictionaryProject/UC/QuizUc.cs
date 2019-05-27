using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DictionaryProject.Model;
using System.IO;
using CsvHelper;

namespace DictionaryProject.UC
{
    public partial class QuizUc : UserControl
    {
        private Random a = new Random();
        List<Word> _wordList = new List<Word>();

        int currentQuestionNumber = 0;
        int _totalCount = 0;
        public Label LblQuestion
        {
            get { return lblQuestion; }
            set { lblQuestion = value; }
        }

        public CheckedListBox CheckBoxA
        {
            get { return this.checkedListBox1; }
            set { checkedListBox1 = value; }
        }

        public QuizUc()
        {
            InitializeComponent();
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                _wordList = DictionaryCRUD.GetAllWords();
                _totalCount = QuizData.quizList.Count;
            }
        }

        public void FillQuiz()
        {
            checkedListBox1.Items.Clear();
            var quiz = QuizData.quizList[currentQuestionNumber];

            quiz.answers = new List<string>();
            lblQuestion.Text = "" + quiz.word.english + " kelimesinin anlamı nedir?";

            List<int> randomList = new List<int>();
            int MyNumber = 0;
            //Set  answers randomly
            int i = 0;
            while (i <= 3)
            {
                MyNumber = a.Next(0, 4);
                if (!randomList.Contains(MyNumber))
                { randomList.Add(MyNumber); i++; }
            }
            quiz.answers.Add(quiz.word.turkish);

            List<int> randomAnswerList = new List<int>();
            //Get answers from db randomly
            int z = 0;

            while (z <= 2)
            {
                int number = a.Next(1, _wordList.Count);
                if (!randomAnswerList.Contains(number) && number != quiz.word.id)
                {
                    randomAnswerList.Add(number);
                    quiz.answers.Add(_wordList[number].turkish);
                    z++;
                }
            }

            for (var y = 0; y < quiz.answers.Count; y++)
                this.checkedListBox1.Items.Add(quiz.answers[randomList[y]]);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.SelectedItem.ToString() == QuizData.quizList[currentQuestionNumber].word.turkish)
                QuizData.quizList[currentQuestionNumber].totalCount += 1;
            else
                QuizData.quizList[currentQuestionNumber].totalCount = 0;

            if (QuizData.quizList.Count > currentQuestionNumber + 1)
            {
                currentQuestionNumber++;
                FillQuiz();
            }
            else
            {
                MessageBox.Show("Test Sonu");
                ((Form)this.TopLevelControl).Close();
            }

        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count >= 1 && e.CurrentValue != CheckState.Checked)
            {
                e.NewValue = e.CurrentValue;
                MessageBox.Show("Sadece bir tane öğe seçebilirsiniz");
            }
        }

        private void QuizUc_Load(object sender, EventArgs e)
        {

        }
    }
}
