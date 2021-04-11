
namespace Seance0410
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
            this.enregistrerBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.codeArticleTextBox = new System.Windows.Forms.TextBox();
            this.quantiteTextBox = new System.Windows.Forms.TextBox();
            this.prixTextBox = new System.Windows.Forms.TextBox();
            this.designiationTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.codeArticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designiation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // enregistrerBtn
            // 
            this.enregistrerBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enregistrerBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.enregistrerBtn.Location = new System.Drawing.Point(633, 97);
            this.enregistrerBtn.Name = "enregistrerBtn";
            this.enregistrerBtn.Size = new System.Drawing.Size(75, 23);
            this.enregistrerBtn.TabIndex = 0;
            this.enregistrerBtn.Text = "Enregister";
            this.enregistrerBtn.UseVisualStyleBackColor = true;
            this.enregistrerBtn.Click += new System.EventHandler(this.enregistrerBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Code Article";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Designiation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(149, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Prix";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(149, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quantité";
            // 
            // codeArticleTextBox
            // 
            this.codeArticleTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeArticleTextBox.Location = new System.Drawing.Point(266, 50);
            this.codeArticleTextBox.Name = "codeArticleTextBox";
            this.codeArticleTextBox.Size = new System.Drawing.Size(234, 23);
            this.codeArticleTextBox.TabIndex = 5;
            // 
            // quantiteTextBox
            // 
            this.quantiteTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantiteTextBox.Location = new System.Drawing.Point(266, 128);
            this.quantiteTextBox.Name = "quantiteTextBox";
            this.quantiteTextBox.Size = new System.Drawing.Size(234, 23);
            this.quantiteTextBox.TabIndex = 6;
            // 
            // prixTextBox
            // 
            this.prixTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prixTextBox.Location = new System.Drawing.Point(266, 102);
            this.prixTextBox.Name = "prixTextBox";
            this.prixTextBox.Size = new System.Drawing.Size(234, 23);
            this.prixTextBox.TabIndex = 7;
            // 
            // designiationTextBox
            // 
            this.designiationTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.designiationTextBox.Location = new System.Drawing.Point(266, 76);
            this.designiationTextBox.Name = "designiationTextBox";
            this.designiationTextBox.Size = new System.Drawing.Size(234, 23);
            this.designiationTextBox.TabIndex = 8;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeArticle,
            this.designiation,
            this.prix,
            this.quantite,
            this.montant});
            this.dataGridView.Location = new System.Drawing.Point(105, 210);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(603, 190);
            this.dataGridView.TabIndex = 9;
            // 
            // codeArticle
            // 
            this.codeArticle.HeaderText = "Code Article";
            this.codeArticle.Name = "codeArticle";
            this.codeArticle.ReadOnly = true;
            // 
            // designiation
            // 
            this.designiation.HeaderText = "Designiation";
            this.designiation.Name = "designiation";
            this.designiation.ReadOnly = true;
            // 
            // prix
            // 
            this.prix.HeaderText = "Prix";
            this.prix.Name = "prix";
            this.prix.ReadOnly = true;
            // 
            // quantite
            // 
            this.quantite.HeaderText = "Quantité";
            this.quantite.Name = "quantite";
            this.quantite.ReadOnly = true;
            // 
            // montant
            // 
            this.montant.HeaderText = "Montant";
            this.montant.Name = "montant";
            this.montant.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.designiationTextBox);
            this.Controls.Add(this.prixTextBox);
            this.Controls.Add(this.quantiteTextBox);
            this.Controls.Add(this.codeArticleTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enregistrerBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enregistrerBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox codeArticleTextBox;
        private System.Windows.Forms.TextBox quantiteTextBox;
        private System.Windows.Forms.TextBox prixTextBox;
        private System.Windows.Forms.TextBox designiationTextBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeArticle;
        private System.Windows.Forms.DataGridViewTextBoxColumn designiation;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn montant;
    }
}

