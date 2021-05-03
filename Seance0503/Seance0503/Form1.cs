using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seance0503
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NbrRootLbl.Text = BranchesTreeView.Nodes.Count.ToString();
        }

        private void BranchesTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            NbrChildenLbl.Text = BranchesTreeView.SelectedNode.Nodes.Count.ToString();
            IndexLbl.Text = BranchesTreeView.SelectedNode.Index.ToString();
            TextLbl.Text = BranchesTreeView.SelectedNode.Text;

            if (BranchesTreeView.SelectedNode.Parent != null)
            {
                ParentLbl.Text = BranchesTreeView.SelectedNode.Parent.Text;
            }

        }
    }
}
