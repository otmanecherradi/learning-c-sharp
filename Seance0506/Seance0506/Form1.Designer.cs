
namespace Seance0506
{
    partial class Form1
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
            this.StagiaireTbPg = new System.Windows.Forms.TabPage();
            this.FiliereTbPg = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.FiliereTreeView = new System.Windows.Forms.TreeView();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CodeTxBx = new System.Windows.Forms.TextBox();
            this.LibelleTxBx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SaveEtudiantBtn = new System.Windows.Forms.Button();
            this.CNETxBx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NomTxBx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PrenomTxBx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FiliereCbBx = new System.Windows.Forms.ComboBox();
            this.StagiaireTbPg.SuspendLayout();
            this.FiliereTbPg.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StagiaireTbPg
            // 
            this.StagiaireTbPg.Controls.Add(this.FiliereCbBx);
            this.StagiaireTbPg.Controls.Add(this.label6);
            this.StagiaireTbPg.Controls.Add(this.PrenomTxBx);
            this.StagiaireTbPg.Controls.Add(this.label5);
            this.StagiaireTbPg.Controls.Add(this.NomTxBx);
            this.StagiaireTbPg.Controls.Add(this.label4);
            this.StagiaireTbPg.Controls.Add(this.SaveEtudiantBtn);
            this.StagiaireTbPg.Controls.Add(this.CNETxBx);
            this.StagiaireTbPg.Controls.Add(this.label3);
            this.StagiaireTbPg.Location = new System.Drawing.Point(4, 22);
            this.StagiaireTbPg.Name = "StagiaireTbPg";
            this.StagiaireTbPg.Padding = new System.Windows.Forms.Padding(3);
            this.StagiaireTbPg.Size = new System.Drawing.Size(478, 400);
            this.StagiaireTbPg.TabIndex = 1;
            this.StagiaireTbPg.Text = "Stagiaires";
            this.StagiaireTbPg.UseVisualStyleBackColor = true;
            // 
            // FiliereTbPg
            // 
            this.FiliereTbPg.Controls.Add(this.SaveBtn);
            this.FiliereTbPg.Controls.Add(this.LibelleTxBx);
            this.FiliereTbPg.Controls.Add(this.label2);
            this.FiliereTbPg.Controls.Add(this.CodeTxBx);
            this.FiliereTbPg.Controls.Add(this.label1);
            this.FiliereTbPg.Location = new System.Drawing.Point(4, 22);
            this.FiliereTbPg.Name = "FiliereTbPg";
            this.FiliereTbPg.Padding = new System.Windows.Forms.Padding(3);
            this.FiliereTbPg.Size = new System.Drawing.Size(478, 400);
            this.FiliereTbPg.TabIndex = 0;
            this.FiliereTbPg.Text = "Filiere";
            this.FiliereTbPg.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.FiliereTbPg);
            this.tabControl1.Controls.Add(this.StagiaireTbPg);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(486, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // FiliereTreeView
            // 
            this.FiliereTreeView.Location = new System.Drawing.Point(529, 34);
            this.FiliereTreeView.Name = "FiliereTreeView";
            this.FiliereTreeView.Size = new System.Drawing.Size(259, 326);
            this.FiliereTreeView.TabIndex = 1;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(193, 222);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 2;
            this.SaveBtn.Text = "Ajouter";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            // 
            // CodeTxBx
            // 
            this.CodeTxBx.Location = new System.Drawing.Point(142, 70);
            this.CodeTxBx.Name = "CodeTxBx";
            this.CodeTxBx.Size = new System.Drawing.Size(270, 20);
            this.CodeTxBx.TabIndex = 1;
            // 
            // LibelleTxBx
            // 
            this.LibelleTxBx.Location = new System.Drawing.Point(142, 96);
            this.LibelleTxBx.Name = "LibelleTxBx";
            this.LibelleTxBx.Size = new System.Drawing.Size(270, 20);
            this.LibelleTxBx.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Libelle";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(618, 391);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 4;
            this.DeleteBtn.Text = "Supprimer";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // SaveEtudiantBtn
            // 
            this.SaveEtudiantBtn.Location = new System.Drawing.Point(187, 227);
            this.SaveEtudiantBtn.Name = "SaveEtudiantBtn";
            this.SaveEtudiantBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveEtudiantBtn.TabIndex = 5;
            this.SaveEtudiantBtn.Text = "Ajouter";
            this.SaveEtudiantBtn.UseVisualStyleBackColor = true;
            this.SaveEtudiantBtn.Click += new System.EventHandler(this.SaveEtudiantBtn_Click);
            // 
            // CNETxBx
            // 
            this.CNETxBx.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.CNETxBx.Location = new System.Drawing.Point(136, 75);
            this.CNETxBx.Name = "CNETxBx";
            this.CNETxBx.Size = new System.Drawing.Size(270, 20);
            this.CNETxBx.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "CNE";
            // 
            // NomTxBx
            // 
            this.NomTxBx.Location = new System.Drawing.Point(136, 101);
            this.NomTxBx.Name = "NomTxBx";
            this.NomTxBx.Size = new System.Drawing.Size(270, 20);
            this.NomTxBx.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nom";
            // 
            // PrenomTxBx
            // 
            this.PrenomTxBx.Location = new System.Drawing.Point(136, 127);
            this.PrenomTxBx.Name = "PrenomTxBx";
            this.PrenomTxBx.Size = new System.Drawing.Size(270, 20);
            this.PrenomTxBx.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Prenom";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Filliere";
            // 
            // FiliereCbBx
            // 
            this.FiliereCbBx.FormattingEnabled = true;
            this.FiliereCbBx.Location = new System.Drawing.Point(136, 154);
            this.FiliereCbBx.Name = "FiliereCbBx";
            this.FiliereCbBx.Size = new System.Drawing.Size(270, 21);
            this.FiliereCbBx.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.FiliereTreeView);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.StagiaireTbPg.ResumeLayout(false);
            this.StagiaireTbPg.PerformLayout();
            this.FiliereTbPg.ResumeLayout(false);
            this.FiliereTbPg.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage StagiaireTbPg;
        private System.Windows.Forms.TabPage FiliereTbPg;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TreeView FiliereTreeView;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TextBox CodeTxBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LibelleTxBx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.TextBox PrenomTxBx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NomTxBx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SaveEtudiantBtn;
        private System.Windows.Forms.TextBox CNETxBx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox FiliereCbBx;
        private System.Windows.Forms.Label label6;
    }
}

