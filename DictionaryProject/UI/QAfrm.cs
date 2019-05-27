using DictionaryProject.Model;
using System;
using System.Windows.Forms;

namespace DictionaryProject.UI
{
    public partial class QAfrm : Form
    {
        public QAfrm()
        {
            InitializeComponent();
        }

        private void QAfrm_Load(object sender, EventArgs e)
        {
            this.quizUc1.FillQuiz();
        }

        private void QAfrm_FormClosing(object sender, FormClosingEventArgs e)
        {
           // QuizData.quizList.RemoveAll(q => q.totalCount > 2);
        }

        private void quizUc1_Load(object sender, EventArgs e)
        {

        }
    }
}
