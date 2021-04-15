
namespace Seance0415
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumTxBx = new System.Windows.Forms.TextBox();
            this.NomTxBx = new System.Windows.Forms.TextBox();
            this.PrenomTxBx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ShowBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.OldStgDataGrid = new System.Windows.Forms.DataGridView();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewStgDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.OldStgDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewStgDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = " Num";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom";
            // 
            // NumTxBx
            // 
            this.NumTxBx.Location = new System.Drawing.Point(300, 22);
            this.NumTxBx.Name = "NumTxBx";
            this.NumTxBx.Size = new System.Drawing.Size(100, 20);
            this.NumTxBx.TabIndex = 4;
            // 
            // NomTxBx
            // 
            this.NomTxBx.Location = new System.Drawing.Point(300, 57);
            this.NomTxBx.Name = "NomTxBx";
            this.NomTxBx.Size = new System.Drawing.Size(100, 20);
            this.NomTxBx.TabIndex = 5;
            // 
            // PrenomTxBx
            // 
            this.PrenomTxBx.Location = new System.Drawing.Point(300, 94);
            this.PrenomTxBx.Name = "PrenomTxBx";
            this.PrenomTxBx.Size = new System.Drawing.Size(100, 20);
            this.PrenomTxBx.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Prenom";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(135, 120);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 8;
            this.AddBtn.Text = "Ajouter";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(265, 120);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateBtn.TabIndex = 9;
            this.UpdateBtn.Text = "Modifier";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(404, 120);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 10;
            this.DeleteBtn.Text = "Supprimer";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ShowBtn
            // 
            this.ShowBtn.Location = new System.Drawing.Point(539, 120);
            this.ShowBtn.Name = "ShowBtn";
            this.ShowBtn.Size = new System.Drawing.Size(75, 23);
            this.ShowBtn.TabIndex = 11;
            this.ShowBtn.Text = "Afficher";
            this.ShowBtn.UseVisualStyleBackColor = true;
            this.ShowBtn.Click += new System.EventHandler(this.ShowBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(520, 57);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 12;
            this.SearchBtn.Text = "Rechercher";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // OldStgDataGrid
            // 
            this.OldStgDataGrid.AllowUserToAddRows = false;
            this.OldStgDataGrid.AllowUserToDeleteRows = false;
            this.OldStgDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OldStgDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.Nom,
            this.Prenom});
            this.OldStgDataGrid.Location = new System.Drawing.Point(12, 149);
            this.OldStgDataGrid.Name = "OldStgDataGrid";
            this.OldStgDataGrid.ReadOnly = true;
            this.OldStgDataGrid.Size = new System.Drawing.Size(776, 139);
            this.OldStgDataGrid.TabIndex = 13;
            // 
            // Num
            // 
            this.Num.HeaderText = "Num";
            this.Num.Name = "Num";
            this.Num.ReadOnly = true;
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // Prenom
            // 
            this.Prenom.HeaderText = "Prenom";
            this.Prenom.Name = "Prenom";
            this.Prenom.ReadOnly = true;
            // 
            // NewStgDataGrid
            // 
            this.NewStgDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NewStgDataGrid.Location = new System.Drawing.Point(12, 294);
            this.NewStgDataGrid.Name = "NewStgDataGrid";
            this.NewStgDataGrid.Size = new System.Drawing.Size(776, 150);
            this.NewStgDataGrid.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NewStgDataGrid);
            this.Controls.Add(this.OldStgDataGrid);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.ShowBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PrenomTxBx);
            this.Controls.Add(this.NomTxBx);
            this.Controls.Add(this.NumTxBx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.OldStgDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewStgDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NumTxBx;
        private System.Windows.Forms.TextBox NomTxBx;
        private System.Windows.Forms.TextBox PrenomTxBx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button ShowBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.DataGridView OldStgDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridView NewStgDataGrid;
    }
}

