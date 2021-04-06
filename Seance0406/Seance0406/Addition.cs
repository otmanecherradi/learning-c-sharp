using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seance0406
{
    public partial class Addition : Form
    {
        public Addition()
        {
            InitializeComponent();
        }

        private void Addition_Load(object sender, EventArgs e)
        {
            Console.WriteLine("zeffefzfefze");
        }

        private void Addition_Closed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdditionBtn_Click(object sender, EventArgs e)
        {
            int textBoxA = int.Parse(TextBoxA.Text);
            int textBoxB = int.Parse(TextBoxB.Text);

            TextBoxSomme.Text = $"{textBoxA + textBoxB}";
        }

        private void TextBoxA_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int.Parse(TextBoxA.Text);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                TextBoxA.Clear();
            }
        }

        private void TextBoxB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int.Parse(TextBoxB.Text);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                TextBoxB.Clear();
            }
        }
    }
}
