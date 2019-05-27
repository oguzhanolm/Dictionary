using CsvHelper;
using DictionaryProject.Model;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DictionaryProject
{
    public partial class Dictionary : Form
    {
        public Dictionary()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtSample.Visible = false;
            lblResult.Text = "";
            lblType.Text = "";

            try
            {
                SearchWord();
            }
            catch
            {
                MessageBox.Show("İşlem sırasında bir hata meydana geldi");
            }
        }
        private void SearchWord()
        {
            
            Word result = DictionaryCRUD.GetAllWords().Where(q => q.english.Contains(txtWord.Text) ||
                                                               q.turkish.Contains(txtWord.Text)).FirstOrDefault();

            if (result != null)
            {
                txtSample.Visible = true;

                string text = result.english == txtWord.Text ? result.turkish : result.english;
                lblResult.Text = "Aradığınız kelime: " + text;
                lblType.Text = "Türü: " + result.type;
                txtSample.Text = result.sample;
            }
            else
                MessageBox.Show("Herhangi bir kayıt bulunamadı!!!");
        }

        private void Dictionary_Load(object sender, EventArgs e)
        {

        }
    }
}
