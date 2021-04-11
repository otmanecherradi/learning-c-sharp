
namespace TP1
{
    partial class Inscription
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
            this.LastNameTxtBx = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.FirstNameTxtBx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GenderGrpBx = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.OptionCbBx = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AgeNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.StudentsDataGridView = new System.Windows.Forms.DataGridView();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.option = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShowBtn = new System.Windows.Forms.Button();
            this.GenderGrpBx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AgeNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // LastNameTxtBx
            // 
            this.LastNameTxtBx.Location = new System.Drawing.Point(205, 101);
            this.LastNameTxtBx.Name = "LastNameTxtBx";
            this.LastNameTxtBx.Size = new System.Drawing.Size(431, 20);
            this.LastNameTxtBx.TabIndex = 1;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(115, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Femme";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(307, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Inscription";
            // 
            // FirstNameTxtBx
            // 
            this.FirstNameTxtBx.Location = new System.Drawing.Point(205, 127);
            this.FirstNameTxtBx.Name = "FirstNameTxtBx";
            this.FirstNameTxtBx.Size = new System.Drawing.Size(431, 20);
            this.FirstNameTxtBx.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prenom";
            // 
            // GenderGrpBx
            // 
            this.GenderGrpBx.Controls.Add(this.radioButton2);
            this.GenderGrpBx.Controls.Add(this.radioButton1);
            this.GenderGrpBx.Location = new System.Drawing.Point(121, 152);
            this.GenderGrpBx.Name = "GenderGrpBx";
            this.GenderGrpBx.Size = new System.Drawing.Size(422, 49);
            this.GenderGrpBx.TabIndex = 6;
            this.GenderGrpBx.TabStop = false;
            this.GenderGrpBx.Text = "Sexe";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(206, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(61, 17);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Homme";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // OptionCbBx
            // 
            this.OptionCbBx.FormattingEnabled = true;
            this.OptionCbBx.Items.AddRange(new object[] {
            "TDI",
            "TRI",
            "INFO",
            "TMSIR"});
            this.OptionCbBx.Location = new System.Drawing.Point(205, 207);
            this.OptionCbBx.Name = "OptionCbBx";
            this.OptionCbBx.Size = new System.Drawing.Size(110, 21);
            this.OptionCbBx.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Option";
            // 
            // AgeNumUpDown
            // 
            this.AgeNumUpDown.Location = new System.Drawing.Point(205, 234);
            this.AgeNumUpDown.Name = "AgeNumUpDown";
            this.AgeNumUpDown.Size = new System.Drawing.Size(110, 20);
            this.AgeNumUpDown.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Age";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(349, 231);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 11;
            this.AddBtn.Text = "Ajouter";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(430, 231);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 12;
            this.DeleteBtn.Text = "Supprimer";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(511, 231);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 13;
            this.SearchBtn.Text = "Rechercher";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // StudentsDataGridView
            // 
            this.StudentsDataGridView.AllowUserToAddRows = false;
            this.StudentsDataGridView.AllowUserToDeleteRows = false;
            this.StudentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lastName,
            this.firstName,
            this.gender,
            this.option,
            this.age});
            this.StudentsDataGridView.Location = new System.Drawing.Point(121, 282);
            this.StudentsDataGridView.Name = "StudentsDataGridView";
            this.StudentsDataGridView.ReadOnly = true;
            this.StudentsDataGridView.Size = new System.Drawing.Size(546, 150);
            this.StudentsDataGridView.TabIndex = 14;
            // 
            // lastName
            // 
            this.lastName.HeaderText = "Nom";
            this.lastName.Name = "lastName";
            this.lastName.ReadOnly = true;
            // 
            // firstName
            // 
            this.firstName.HeaderText = "Prenom";
            this.firstName.Name = "firstName";
            this.firstName.ReadOnly = true;
            // 
            // gender
            // 
            this.gender.HeaderText = "Sexe";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // option
            // 
            this.option.HeaderText = "Option";
            this.option.Name = "option";
            this.option.ReadOnly = true;
            // 
            // age
            // 
            this.age.HeaderText = "Age";
            this.age.Name = "age";
            this.age.ReadOnly = true;
            // 
            // ShowBtn
            // 
            this.ShowBtn.Location = new System.Drawing.Point(592, 231);
            this.ShowBtn.Name = "ShowBtn";
            this.ShowBtn.Size = new System.Drawing.Size(75, 23);
            this.ShowBtn.TabIndex = 15;
            this.ShowBtn.Text = "Afficher";
            this.ShowBtn.UseVisualStyleBackColor = true;
            this.ShowBtn.Click += new System.EventHandler(this.ShowBtn_Click);
            // 
            // Inscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ShowBtn);
            this.Controls.Add(this.StudentsDataGridView);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AgeNumUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OptionCbBx);
            this.Controls.Add(this.GenderGrpBx);
            this.Controls.Add(this.FirstNameTxtBx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LastNameTxtBx);
            this.Controls.Add(this.label1);
            this.Name = "Inscription";
            this.Text = "Inscription";
            this.GenderGrpBx.ResumeLayout(false);
            this.GenderGrpBx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AgeNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LastNameTxtBx;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FirstNameTxtBx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox GenderGrpBx;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ComboBox OptionCbBx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown AgeNumUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.DataGridView StudentsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn option;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.Button ShowBtn;
    }
}

