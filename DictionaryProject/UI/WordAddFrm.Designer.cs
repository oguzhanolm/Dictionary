using System;

namespace DictionaryProject
{
    partial class WordAddFrm
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
            this.btnAddWord = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBoxInfo = new System.Windows.Forms.GroupBox();
            this.txtSample = new System.Windows.Forms.TextBox();
            this.lblSample = new System.Windows.Forms.Label();
            this.txtTurkish = new System.Windows.Forms.TextBox();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.cbbType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpBoxInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddWord
            // 
            this.btnAddWord.Location = new System.Drawing.Point(397, 316);
            this.btnAddWord.Name = "btnAddWord";
            this.btnAddWord.Size = new System.Drawing.Size(87, 27);
            this.btnAddWord.TabIndex = 0;
            this.btnAddWord.Text = "Kaydet";
            this.btnAddWord.UseVisualStyleBackColor = true;
            this.btnAddWord.Click += new System.EventHandler(this.btnAddWord_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "İngilizce*";
            // 
            // grpBoxInfo
            // 
            this.grpBoxInfo.Controls.Add(this.txtSample);
            this.grpBoxInfo.Controls.Add(this.lblSample);
            this.grpBoxInfo.Controls.Add(this.txtTurkish);
            this.grpBoxInfo.Controls.Add(this.txtEnglish);
            this.grpBoxInfo.Controls.Add(this.cbbType);
            this.grpBoxInfo.Controls.Add(this.label3);
            this.grpBoxInfo.Controls.Add(this.label2);
            this.grpBoxInfo.Controls.Add(this.label1);
            this.grpBoxInfo.Location = new System.Drawing.Point(25, 12);
            this.grpBoxInfo.Name = "grpBoxInfo";
            this.grpBoxInfo.Size = new System.Drawing.Size(459, 298);
            this.grpBoxInfo.TabIndex = 2;
            this.grpBoxInfo.TabStop = false;
            this.grpBoxInfo.Text = "Yeni Kelime";
            // 
            // txtSample
            // 
            this.txtSample.Location = new System.Drawing.Point(108, 161);
            this.txtSample.Multiline = true;
            this.txtSample.Name = "txtSample";
            this.txtSample.Size = new System.Drawing.Size(345, 116);
            this.txtSample.TabIndex = 8;
            // 
            // lblSample
            // 
            this.lblSample.AutoSize = true;
            this.lblSample.Location = new System.Drawing.Point(33, 161);
            this.lblSample.Name = "lblSample";
            this.lblSample.Size = new System.Drawing.Size(44, 15);
            this.lblSample.TabIndex = 7;
            this.lblSample.Text = "Örnek*";
            // 
            // txtTurkish
            // 
            this.txtTurkish.Location = new System.Drawing.Point(108, 81);
            this.txtTurkish.Name = "txtTurkish";
            this.txtTurkish.Size = new System.Drawing.Size(345, 23);
            this.txtTurkish.TabIndex = 6;
            // 
            // txtEnglish
            // 
            this.txtEnglish.Location = new System.Drawing.Point(108, 46);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(345, 23);
            this.txtEnglish.TabIndex = 5;
            // 
            // cbbType
            // 
            this.cbbType.AllowDrop = true;
            this.cbbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Items.AddRange(new object[] {
            "İsim",
            "Fiil",
            "Edat",
            "Sıfat"});
            this.cbbType.Location = new System.Drawing.Point(108, 116);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(345, 23);
            this.cbbType.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Türü";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Türkçe*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(30, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Not: * olan alanlar zorunlu alanlardır";
            // 
            // WordAddFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 371);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grpBoxInfo);
            this.Controls.Add(this.btnAddWord);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WordAddFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kelime Ekle";
            this.Load += new System.EventHandler(this.WordAddFrm_Load);
            this.grpBoxInfo.ResumeLayout(false);
            this.grpBoxInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      

        #endregion

        private System.Windows.Forms.Button btnAddWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpBoxInfo;
        private System.Windows.Forms.TextBox txtTurkish;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.ComboBox cbbType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSample;
        private System.Windows.Forms.Label lblSample;
        private System.Windows.Forms.Label label4;
    }
}