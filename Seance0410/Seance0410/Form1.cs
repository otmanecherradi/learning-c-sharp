using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seance0410
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void enregistrerBtn_Click(object sender, EventArgs e)
        {
            double prix = double.Parse(prixTextBox.Text) * int.Parse(quantiteTextBox.Text);

            dataGridView.Rows.Add(
                codeArticleTextBox.Text,
                designiationTextBox.Text,
                prixTextBox.Text,
                quantiteTextBox.Text,
                prix.ToString()
            );

            foreach (Control c in Controls)
                if (c.GetType() == typeof(TextBox))
                    c.ResetText();
        }
    }
}
