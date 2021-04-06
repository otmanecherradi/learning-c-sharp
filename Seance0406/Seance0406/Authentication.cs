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
    public partial class Authentication : Form
    {
        public Authentication()
        {
            InitializeComponent();
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MotDePasseTextBox.UseSystemPasswordChar = !ShowPasswordCheckBox.Checked;

            if (ShowPasswordCheckBox.Checked)
                ShowPasswordCheckBox.Text = "Masquer Mot de Passe";
            else
                ShowPasswordCheckBox.Text = "Afficher Mot de Passe";
        }
    }
}
