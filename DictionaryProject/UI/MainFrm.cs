using System;
using System.Windows.Forms;

namespace DictionaryProject
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void btnNewWord_Click(object sender, EventArgs e)
        {
            WordAddFrm frm = new WordAddFrm();
            frm.ShowDialog();
        }

        private void btnDictionary_Click(object sender, EventArgs e)
        {
            Dictionary frm = new Dictionary();
            frm.ShowDialog();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            QuizFrm frm = new QuizFrm();
            frm.ShowDialog();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
