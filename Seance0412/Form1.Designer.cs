
namespace Seance0412
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
            this.CINTxBx = new System.Windows.Forms.TextBox();
            this.CityCbBx = new System.Windows.Forms.ComboBox();
            this.StFmCRdBtn = new System.Windows.Forms.RadioButton();
            this.NewBtn = new System.Windows.Forms.Button();
            this.LastNameTxBx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FirstNameTxBx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AgeTxBx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.StFmMRdBtn = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.NavLastBtn = new System.Windows.Forms.Button();
            this.NavAfBtn = new System.Windows.Forms.Button();
            this.NavBfBtn = new System.Windows.Forms.Button();
            this.NavFirstBtn = new System.Windows.Forms.Button();
            this.PersonsDataGrid = new System.Windows.Forms.DataGridView();
            this.CIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SituationFamiliale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PersonsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // CINTxBx
            // 
            this.CINTxBx.Location = new System.Drawing.Point(282, 59);
            this.CINTxBx.Name = "CINTxBx";
            this.CINTxBx.Size = new System.Drawing.Size(216, 20);
            this.CINTxBx.TabIndex = 1;
            // 
            // CityCbBx
            // 
            this.CityCbBx.FormattingEnabled = true;
            this.CityCbBx.Items.AddRange(new object[] {
            "Tanger",
            "Tetouan",
            "Casa"});
            this.CityCbBx.Location = new System.Drawing.Point(282, 186);
            this.CityCbBx.Name = "CityCbBx";
            this.CityCbBx.Size = new System.Drawing.Size(216, 21);
            this.CityCbBx.TabIndex = 2;
            // 
            // StFmCRdBtn
            // 
            this.StFmCRdBtn.AutoSize = true;
            this.StFmCRdBtn.Location = new System.Drawing.Point(317, 163);
            this.StFmCRdBtn.Name = "StFmCRdBtn";
            this.StFmCRdBtn.Size = new System.Drawing.Size(74, 17);
            this.StFmCRdBtn.TabIndex = 3;
            this.StFmCRdBtn.TabStop = true;
            this.StFmCRdBtn.Text = "Celibataire";
            this.StFmCRdBtn.UseVisualStyleBackColor = true;
            // 
            // NewBtn
            // 
            this.NewBtn.Location = new System.Drawing.Point(180, 250);
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(75, 23);
            this.NewBtn.TabIndex = 4;
            this.NewBtn.Text = "Nouveau";
            this.NewBtn.UseVisualStyleBackColor = true;
            this.NewBtn.Click += new System.EventHandler(this.NewBtn_Click);
            // 
            // LastNameTxBx
            // 
            this.LastNameTxBx.Location = new System.Drawing.Point(282, 85);
            this.LastNameTxBx.Name = "LastNameTxBx";
            this.LastNameTxBx.Size = new System.Drawing.Size(216, 20);
            this.LastNameTxBx.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prenom";
            // 
            // FirstNameTxBx
            // 
            this.FirstNameTxBx.Location = new System.Drawing.Point(282, 111);
            this.FirstNameTxBx.Name = "FirstNameTxBx";
            this.FirstNameTxBx.Size = new System.Drawing.Size(216, 20);
            this.FirstNameTxBx.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Age";
            // 
            // AgeTxBx
            // 
            this.AgeTxBx.Location = new System.Drawing.Point(282, 137);
            this.AgeTxBx.Name = "AgeTxBx";
            this.AgeTxBx.Size = new System.Drawing.Size(216, 20);
            this.AgeTxBx.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "CIN";
            // 
            // StFmMRdBtn
            // 
            this.StFmMRdBtn.AutoSize = true;
            this.StFmMRdBtn.Location = new System.Drawing.Point(423, 163);
            this.StFmMRdBtn.Name = "StFmMRdBtn";
            this.StFmMRdBtn.Size = new System.Drawing.Size(51, 17);
            this.StFmMRdBtn.TabIndex = 11;
            this.StFmMRdBtn.TabStop = true;
            this.StFmMRdBtn.Text = "Marie";
            this.StFmMRdBtn.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Situation Familiale";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ville";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(261, 250);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 14;
            this.AddBtn.Text = "Enregister";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(342, 250);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateBtn.TabIndex = 15;
            this.UpdateBtn.Text = "Modifier";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(423, 250);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 16;
            this.DeleteBtn.Text = "Suprimer";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // NavLastBtn
            // 
            this.NavLastBtn.Location = new System.Drawing.Point(423, 279);
            this.NavLastBtn.Name = "NavLastBtn";
            this.NavLastBtn.Size = new System.Drawing.Size(75, 23);
            this.NavLastBtn.TabIndex = 20;
            this.NavLastBtn.Text = "Dernier";
            this.NavLastBtn.UseVisualStyleBackColor = true;
            // 
            // NavAfBtn
            // 
            this.NavAfBtn.Location = new System.Drawing.Point(342, 279);
            this.NavAfBtn.Name = "NavAfBtn";
            this.NavAfBtn.Size = new System.Drawing.Size(75, 23);
            this.NavAfBtn.TabIndex = 19;
            this.NavAfBtn.Text = "Suivant";
            this.NavAfBtn.UseVisualStyleBackColor = true;
            // 
            // NavBfBtn
            // 
            this.NavBfBtn.Location = new System.Drawing.Point(261, 279);
            this.NavBfBtn.Name = "NavBfBtn";
            this.NavBfBtn.Size = new System.Drawing.Size(75, 23);
            this.NavBfBtn.TabIndex = 18;
            this.NavBfBtn.Text = "Precedant";
            this.NavBfBtn.UseVisualStyleBackColor = true;
            this.NavBfBtn.Click += new System.EventHandler(this.NavBfBtn_Click);
            // 
            // NavFirstBtn
            // 
            this.NavFirstBtn.Location = new System.Drawing.Point(180, 279);
            this.NavFirstBtn.Name = "NavFirstBtn";
            this.NavFirstBtn.Size = new System.Drawing.Size(75, 23);
            this.NavFirstBtn.TabIndex = 17;
            this.NavFirstBtn.Text = "Premier";
            this.NavFirstBtn.UseVisualStyleBackColor = true;
            this.NavFirstBtn.Click += new System.EventHandler(this.NavFirstBtn_Click);
            // 
            // PersonsDataGrid
            // 
            this.PersonsDataGrid.AllowUserToAddRows = false;
            this.PersonsDataGrid.AllowUserToDeleteRows = false;
            this.PersonsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIN,
            this.LastName,
            this.FirstName,
            this.Age,
            this.SituationFamiliale,
            this.City});
            this.PersonsDataGrid.Location = new System.Drawing.Point(12, 326);
            this.PersonsDataGrid.Name = "PersonsDataGrid";
            this.PersonsDataGrid.ReadOnly = true;
            this.PersonsDataGrid.Size = new System.Drawing.Size(648, 150);
            this.PersonsDataGrid.TabIndex = 21;
            // 
            // CIN
            // 
            this.CIN.HeaderText = "CIN";
            this.CIN.Name = "CIN";
            this.CIN.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Nom";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "Prenom";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            // 
            // SituationFamiliale
            // 
            this.SituationFamiliale.HeaderText = "Situation Familiale";
            this.SituationFamiliale.Name = "SituationFamiliale";
            this.SituationFamiliale.ReadOnly = true;
            // 
            // City
            // 
            this.City.HeaderText = "Ville";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 495);
            this.Controls.Add(this.PersonsDataGrid);
            this.Controls.Add(this.NavLastBtn);
            this.Controls.Add(this.NavAfBtn);
            this.Controls.Add(this.NavBfBtn);
            this.Controls.Add(this.NavFirstBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.StFmMRdBtn);
            this.Controls.Add(this.AgeTxBx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FirstNameTxBx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LastNameTxBx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NewBtn);
            this.Controls.Add(this.StFmCRdBtn);
            this.Controls.Add(this.CityCbBx);
            this.Controls.Add(this.CINTxBx);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PersonsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CINTxBx;
        private System.Windows.Forms.ComboBox CityCbBx;
        private System.Windows.Forms.RadioButton StFmCRdBtn;
        private System.Windows.Forms.Button NewBtn;
        private System.Windows.Forms.TextBox LastNameTxBx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FirstNameTxBx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AgeTxBx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton StFmMRdBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button NavLastBtn;
        private System.Windows.Forms.Button NavAfBtn;
        private System.Windows.Forms.Button NavBfBtn;
        private System.Windows.Forms.Button NavFirstBtn;
        private System.Windows.Forms.DataGridView PersonsDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn SituationFamiliale;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
    }
}

