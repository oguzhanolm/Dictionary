namespace DictionaryProject.UI
{
    partial class QAfrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.quizUc1 = new DictionaryProject.UC.QuizUc();
            this.SuspendLayout();
            // 
            // quizUc1
            // 
            this.quizUc1.Location = new System.Drawing.Point(12, 12);
            this.quizUc1.Name = "quizUc1";
            this.quizUc1.Size = new System.Drawing.Size(306, 198);
            this.quizUc1.TabIndex = 0;
            this.quizUc1.Load += new System.EventHandler(this.quizUc1_Load);
            // 
            // QAfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 224);
            this.Controls.Add(this.quizUc1);
            this.Name = "QAfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QAfmr";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QAfrm_FormClosing);
            this.Load += new System.EventHandler(this.QAfrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UC.QuizUc quizUc1;
    }
}