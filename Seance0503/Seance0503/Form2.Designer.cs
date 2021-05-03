
namespace Seance0503
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ElementTxBx = new System.Windows.Forms.TextBox();
            this.RootBtn = new System.Windows.Forms.Button();
            this.ChildBtn = new System.Windows.Forms.Button();
            this.ElementsTreeView = new System.Windows.Forms.TreeView();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ChildBtn);
            this.panel1.Controls.Add(this.RootBtn);
            this.panel1.Controls.Add(this.ElementTxBx);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 426);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DeleteBtn);
            this.panel2.Controls.Add(this.ElementsTreeView);
            this.panel2.Location = new System.Drawing.Point(417, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(371, 426);
            this.panel2.TabIndex = 1;
            // 
            // ElementTxBx
            // 
            this.ElementTxBx.Location = new System.Drawing.Point(49, 61);
            this.ElementTxBx.Name = "ElementTxBx";
            this.ElementTxBx.Size = new System.Drawing.Size(223, 20);
            this.ElementTxBx.TabIndex = 0;
            // 
            // RootBtn
            // 
            this.RootBtn.Location = new System.Drawing.Point(49, 213);
            this.RootBtn.Name = "RootBtn";
            this.RootBtn.Size = new System.Drawing.Size(75, 23);
            this.RootBtn.TabIndex = 1;
            this.RootBtn.Text = "Root";
            this.RootBtn.UseVisualStyleBackColor = true;
            this.RootBtn.Click += new System.EventHandler(this.RootBtn_Click);
            // 
            // ChildBtn
            // 
            this.ChildBtn.Location = new System.Drawing.Point(197, 213);
            this.ChildBtn.Name = "ChildBtn";
            this.ChildBtn.Size = new System.Drawing.Size(75, 23);
            this.ChildBtn.TabIndex = 2;
            this.ChildBtn.Text = "Child";
            this.ChildBtn.UseVisualStyleBackColor = true;
            this.ChildBtn.Click += new System.EventHandler(this.ChildBtn_Click);
            // 
            // ElementsTreeView
            // 
            this.ElementsTreeView.Location = new System.Drawing.Point(3, 3);
            this.ElementsTreeView.Name = "ElementsTreeView";
            this.ElementsTreeView.Size = new System.Drawing.Size(226, 420);
            this.ElementsTreeView.TabIndex = 0;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(266, 176);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 1;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ChildBtn;
        private System.Windows.Forms.Button RootBtn;
        private System.Windows.Forms.TextBox ElementTxBx;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.TreeView ElementsTreeView;
    }
}