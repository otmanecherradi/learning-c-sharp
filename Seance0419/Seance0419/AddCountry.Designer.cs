
namespace Seance0419
{
    partial class AddCountry
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CountryNameTxBx = new System.Windows.Forms.TextBox();
            this.CountryCapitalTxBx = new System.Windows.Forms.TextBox();
            this.CountryLanguageTxBx = new System.Windows.Forms.TextBox();
            this.openFile = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flag";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Capital";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Laguage";
            // 
            // CountryNameTxBx
            // 
            this.CountryNameTxBx.Location = new System.Drawing.Point(259, 125);
            this.CountryNameTxBx.Name = "CountryNameTxBx";
            this.CountryNameTxBx.Size = new System.Drawing.Size(258, 20);
            this.CountryNameTxBx.TabIndex = 4;
            // 
            // CountryCapitalTxBx
            // 
            this.CountryCapitalTxBx.Location = new System.Drawing.Point(259, 168);
            this.CountryCapitalTxBx.Name = "CountryCapitalTxBx";
            this.CountryCapitalTxBx.Size = new System.Drawing.Size(258, 20);
            this.CountryCapitalTxBx.TabIndex = 5;
            // 
            // CountryLanguageTxBx
            // 
            this.CountryLanguageTxBx.Location = new System.Drawing.Point(259, 210);
            this.CountryLanguageTxBx.Name = "CountryLanguageTxBx";
            this.CountryLanguageTxBx.Size = new System.Drawing.Size(258, 20);
            this.CountryLanguageTxBx.TabIndex = 6;
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(259, 65);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(258, 34);
            this.openFile.TabIndex = 7;
            this.openFile.Text = "Get Flag";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(173, 322);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 8;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(442, 322);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 9;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // AddCountry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.CountryLanguageTxBx);
            this.Controls.Add(this.CountryCapitalTxBx);
            this.Controls.Add(this.CountryNameTxBx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddCountry";
            this.Text = "AddCountry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CountryNameTxBx;
        private System.Windows.Forms.TextBox CountryCapitalTxBx;
        private System.Windows.Forms.TextBox CountryLanguageTxBx;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}