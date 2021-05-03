
namespace Seance0503
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("TDI101");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("TDI102");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("TDI103");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Development", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("TRI101");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("TRI102");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Reseau", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Infographie");
            this.panel1 = new System.Windows.Forms.Panel();
            this.BranchesTreeView = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ParentLbl = new System.Windows.Forms.Label();
            this.NbrChildenLbl = new System.Windows.Forms.Label();
            this.TextLbl = new System.Windows.Forms.Label();
            this.IndexLbl = new System.Windows.Forms.Label();
            this.NbrRootLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BranchesTreeView);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 426);
            this.panel1.TabIndex = 0;
            // 
            // BranchesTreeView
            // 
            this.BranchesTreeView.Location = new System.Drawing.Point(0, 0);
            this.BranchesTreeView.Name = "BranchesTreeView";
            treeNode1.Name = "Node1";
            treeNode1.Text = "TDI101";
            treeNode2.Name = "Node2";
            treeNode2.Text = "TDI102";
            treeNode3.Name = "Node9";
            treeNode3.Text = "TDI103";
            treeNode4.Name = "Node0";
            treeNode4.Text = "Development";
            treeNode5.Name = "Node4";
            treeNode5.Text = "TRI101";
            treeNode6.Name = "Node6";
            treeNode6.Text = "TRI102";
            treeNode7.Name = "Node3";
            treeNode7.Text = "Reseau";
            treeNode8.Name = "Node7";
            treeNode8.Text = "Infographie";
            this.BranchesTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode7,
            treeNode8});
            this.BranchesTreeView.Size = new System.Drawing.Size(148, 426);
            this.BranchesTreeView.TabIndex = 0;
            this.BranchesTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.BranchesTreeView_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de racine";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Indice";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Text";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre d\'enfants";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(273, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Parent";
            // 
            // ParentLbl
            // 
            this.ParentLbl.AutoSize = true;
            this.ParentLbl.Location = new System.Drawing.Point(427, 237);
            this.ParentLbl.Name = "ParentLbl";
            this.ParentLbl.Size = new System.Drawing.Size(15, 13);
            this.ParentLbl.TabIndex = 10;
            this.ParentLbl.Text = "**";
            // 
            // NbrChildenLbl
            // 
            this.NbrChildenLbl.AutoSize = true;
            this.NbrChildenLbl.Location = new System.Drawing.Point(427, 186);
            this.NbrChildenLbl.Name = "NbrChildenLbl";
            this.NbrChildenLbl.Size = new System.Drawing.Size(15, 13);
            this.NbrChildenLbl.TabIndex = 9;
            this.NbrChildenLbl.Text = "**";
            // 
            // TextLbl
            // 
            this.TextLbl.AutoSize = true;
            this.TextLbl.Location = new System.Drawing.Point(427, 135);
            this.TextLbl.Name = "TextLbl";
            this.TextLbl.Size = new System.Drawing.Size(15, 13);
            this.TextLbl.TabIndex = 8;
            this.TextLbl.Text = "**";
            // 
            // IndexLbl
            // 
            this.IndexLbl.AutoSize = true;
            this.IndexLbl.Location = new System.Drawing.Point(427, 84);
            this.IndexLbl.Name = "IndexLbl";
            this.IndexLbl.Size = new System.Drawing.Size(15, 13);
            this.IndexLbl.TabIndex = 7;
            this.IndexLbl.Text = "**";
            // 
            // NbrRootLbl
            // 
            this.NbrRootLbl.AutoSize = true;
            this.NbrRootLbl.Location = new System.Drawing.Point(427, 33);
            this.NbrRootLbl.Name = "NbrRootLbl";
            this.NbrRootLbl.Size = new System.Drawing.Size(15, 13);
            this.NbrRootLbl.TabIndex = 6;
            this.NbrRootLbl.Text = "**";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ParentLbl);
            this.Controls.Add(this.NbrChildenLbl);
            this.Controls.Add(this.TextLbl);
            this.Controls.Add(this.IndexLbl);
            this.Controls.Add(this.NbrRootLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView BranchesTreeView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ParentLbl;
        private System.Windows.Forms.Label NbrChildenLbl;
        private System.Windows.Forms.Label TextLbl;
        private System.Windows.Forms.Label IndexLbl;
        private System.Windows.Forms.Label NbrRootLbl;
    }
}

