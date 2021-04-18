
namespace Seance0415_biz
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CINTxBx = new System.Windows.Forms.TextBox();
            this.LastNameTxBx = new System.Windows.Forms.TextBox();
            this.FirstNameTxBx = new System.Windows.Forms.TextBox();
            this.BloodGrpCbBx = new System.Windows.Forms.ComboBox();
            this.RHPlusRdBtn = new System.Windows.Forms.RadioButton();
            this.RHMinusRdBtn = new System.Windows.Forms.RadioButton();
            this.NewBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.DonnersDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DonnersDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CIN Donneur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prenom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Group Sanguin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Rhesus";
            // 
            // CINTxBx
            // 
            this.CINTxBx.Location = new System.Drawing.Point(201, 54);
            this.CINTxBx.Name = "CINTxBx";
            this.CINTxBx.Size = new System.Drawing.Size(216, 20);
            this.CINTxBx.TabIndex = 5;
            // 
            // LastNameTxBx
            // 
            this.LastNameTxBx.Location = new System.Drawing.Point(201, 80);
            this.LastNameTxBx.Name = "LastNameTxBx";
            this.LastNameTxBx.Size = new System.Drawing.Size(216, 20);
            this.LastNameTxBx.TabIndex = 6;
            // 
            // FirstNameTxBx
            // 
            this.FirstNameTxBx.Location = new System.Drawing.Point(201, 106);
            this.FirstNameTxBx.Name = "FirstNameTxBx";
            this.FirstNameTxBx.Size = new System.Drawing.Size(216, 20);
            this.FirstNameTxBx.TabIndex = 7;
            // 
            // BloodGrpCbBx
            // 
            this.BloodGrpCbBx.FormattingEnabled = true;
            this.BloodGrpCbBx.Location = new System.Drawing.Point(201, 132);
            this.BloodGrpCbBx.Name = "BloodGrpCbBx";
            this.BloodGrpCbBx.Size = new System.Drawing.Size(216, 21);
            this.BloodGrpCbBx.TabIndex = 8;
            // 
            // RHPlusRdBtn
            // 
            this.RHPlusRdBtn.AutoSize = true;
            this.RHPlusRdBtn.Location = new System.Drawing.Point(251, 159);
            this.RHPlusRdBtn.Name = "RHPlusRdBtn";
            this.RHPlusRdBtn.Size = new System.Drawing.Size(31, 17);
            this.RHPlusRdBtn.TabIndex = 9;
            this.RHPlusRdBtn.TabStop = true;
            this.RHPlusRdBtn.Text = "+";
            this.RHPlusRdBtn.UseVisualStyleBackColor = true;
            // 
            // RHMinusRdBtn
            // 
            this.RHMinusRdBtn.AutoSize = true;
            this.RHMinusRdBtn.Location = new System.Drawing.Point(348, 159);
            this.RHMinusRdBtn.Name = "RHMinusRdBtn";
            this.RHMinusRdBtn.Size = new System.Drawing.Size(28, 17);
            this.RHMinusRdBtn.TabIndex = 10;
            this.RHMinusRdBtn.TabStop = true;
            this.RHMinusRdBtn.Text = "-";
            this.RHMinusRdBtn.UseVisualStyleBackColor = true;
            // 
            // NewBtn
            // 
            this.NewBtn.Location = new System.Drawing.Point(596, 54);
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(75, 23);
            this.NewBtn.TabIndex = 11;
            this.NewBtn.Text = "Nouveau";
            this.NewBtn.UseVisualStyleBackColor = true;
            this.NewBtn.Click += new System.EventHandler(this.NewBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(596, 83);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 12;
            this.AddBtn.Text = "Ajouter";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(596, 112);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 13;
            this.DeleteBtn.Text = "Supprimer";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(596, 141);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 14;
            this.SaveBtn.Text = "Sauvegarder";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // DonnersDataGrid
            // 
            this.DonnersDataGrid.AllowUserToAddRows = false;
            this.DonnersDataGrid.AllowUserToDeleteRows = false;
            this.DonnersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DonnersDataGrid.Location = new System.Drawing.Point(12, 221);
            this.DonnersDataGrid.Name = "DonnersDataGrid";
            this.DonnersDataGrid.ReadOnly = true;
            this.DonnersDataGrid.Size = new System.Drawing.Size(776, 217);
            this.DonnersDataGrid.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DonnersDataGrid);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.NewBtn);
            this.Controls.Add(this.RHMinusRdBtn);
            this.Controls.Add(this.RHPlusRdBtn);
            this.Controls.Add(this.BloodGrpCbBx);
            this.Controls.Add(this.FirstNameTxBx);
            this.Controls.Add(this.LastNameTxBx);
            this.Controls.Add(this.CINTxBx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "List des Donneurs";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DonnersDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CINTxBx;
        private System.Windows.Forms.TextBox LastNameTxBx;
        private System.Windows.Forms.TextBox FirstNameTxBx;
        private System.Windows.Forms.ComboBox BloodGrpCbBx;
        private System.Windows.Forms.RadioButton RHPlusRdBtn;
        private System.Windows.Forms.RadioButton RHMinusRdBtn;
        private System.Windows.Forms.Button NewBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.DataGridView DonnersDataGrid;
    }
}

