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
    public partial class Salutation : Form
    {
        public Salutation()
        {
            InitializeComponent();
        }

        private void SalutationBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World", "Hello");
        }

        private void ShowAdditionBtn_Click(object sender, EventArgs e)
        {
            new Addition().Show();
        }

        private void AuthenticationBtn_Click(object sender, EventArgs e)
        {
            new Authentication().Show();
        }
    }
}
