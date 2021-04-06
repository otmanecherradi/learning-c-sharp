
namespace Seance0406
{
    partial class Salutation
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
            this.SalutationBtn = new System.Windows.Forms.Button();
            this.ShowAdditionBtn = new System.Windows.Forms.Button();
            this.AuthenticationBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SalutationBtn
            // 
            this.SalutationBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalutationBtn.Location = new System.Drawing.Point(150, 39);
            this.SalutationBtn.Margin = new System.Windows.Forms.Padding(6);
            this.SalutationBtn.Name = "SalutationBtn";
            this.SalutationBtn.Size = new System.Drawing.Size(306, 57);
            this.SalutationBtn.TabIndex = 0;
            this.SalutationBtn.Text = "Salutation";
            this.SalutationBtn.UseVisualStyleBackColor = true;
            this.SalutationBtn.Click += new System.EventHandler(this.SalutationBtn_Click);
            // 
            // ShowAdditionBtn
            // 
            this.ShowAdditionBtn.Location = new System.Drawing.Point(150, 117);
            this.ShowAdditionBtn.Name = "ShowAdditionBtn";
            this.ShowAdditionBtn.Size = new System.Drawing.Size(306, 56);
            this.ShowAdditionBtn.TabIndex = 1;
            this.ShowAdditionBtn.Text = "Show Addition";
            this.ShowAdditionBtn.UseVisualStyleBackColor = true;
            this.ShowAdditionBtn.Click += new System.EventHandler(this.ShowAdditionBtn_Click);
            // 
            // AuthenticationBtn
            // 
            this.AuthenticationBtn.Location = new System.Drawing.Point(150, 202);
            this.AuthenticationBtn.Name = "AuthenticationBtn";
            this.AuthenticationBtn.Size = new System.Drawing.Size(306, 56);
            this.AuthenticationBtn.TabIndex = 2;
            this.AuthenticationBtn.Text = "Authentication";
            this.AuthenticationBtn.UseVisualStyleBackColor = true;
            this.AuthenticationBtn.Click += new System.EventHandler(this.AuthenticationBtn_Click);
            // 
            // Salutation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 303);
            this.Controls.Add(this.AuthenticationBtn);
            this.Controls.Add(this.ShowAdditionBtn);
            this.Controls.Add(this.SalutationBtn);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Salutation";
            this.Text = "Salutation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SalutationBtn;
        private System.Windows.Forms.Button ShowAdditionBtn;
        private System.Windows.Forms.Button AuthenticationBtn;
    }
}