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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void RootBtn_Click(object sender, EventArgs e)
        {
            ElementsTreeView.Nodes.Add(ElementTxBx.Text);
            postAddition();
        }

        private void postAddition()
        {
            ElementTxBx.Clear();
            ElementTxBx.Focus();
        }

        private void ChildBtn_Click(object sender, EventArgs e)
        {
            if (ElementsTreeView.SelectedNode != null)
            {
                ElementsTreeView.SelectedNode.Nodes.Add(ElementTxBx.Text);
                postAddition();
            }
            else
            {
                MessageBox.Show("Select a Root First");
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (ElementsTreeView.SelectedNode != null)
            {
                ElementsTreeView.Nodes.Remove(ElementsTreeView.SelectedNode);
            }
        }
    }
}
