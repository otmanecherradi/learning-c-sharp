using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    public partial class Inscription : Form
    {
        List<Stagiaire> sgs = new List<Stagiaire>();

        public Inscription()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Stagiaire s = new Stagiaire(LastNameTxtBx.Text, FirstNameTxtBx.Text, GetSelectedGender(), OptionCbBx.Text, AgeNumUpDown.Value.ToString());
            StudentsDataGridView.Rows.Add(s.ToList());
            sgs.Add(s);

            ResetInscriptionForm();
        }

        private string GetSelectedGender()
        {
            string choice = "";
            foreach (RadioButton c in GenderGrpBx.Controls)
                if (c.Checked)
                    choice = c.Text;
            return choice;
        }

        private void ResetInscriptionForm()
        {
            LastNameTxtBx.Clear();
            FirstNameTxtBx.Clear();
            OptionCbBx.SelectedIndex = -1;
            AgeNumUpDown.Value = 0;
            foreach (RadioButton c in GenderGrpBx.Controls)
                c.Checked = false;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Voulez-vous supprimer cette ligne ?", "Confirmation", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    int i = StudentsDataGridView.CurrentRow.Index;
                    StudentsDataGridView.Rows.RemoveAt(i);
                }
                else
                    MessageBox.Show("Supression annulé");
            }
            catch (Exception)
            {
                MessageBox.Show("Le tableau est vide");
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            bool b = false;
            foreach (DataGridViewRow r in StudentsDataGridView.Rows)
            {
                if ((string)r.Cells[0].Value == LastNameTxtBx.Text)
                {
                    b = true;

                    FirstNameTxtBx.Text = r.Cells[1].Value.ToString();
                    OptionCbBx.Text = r.Cells[3].Value.ToString();
                    AgeNumUpDown.Value = int.Parse(r.Cells[4].Value.ToString());
                    foreach (RadioButton c in GenderGrpBx.Controls)
                        if (r.Cells[2].Value.ToString() == c.Text)
                            c.Checked = true;
                }
            }

            if (!b)
            {
                MessageBox.Show("Record Not Found");
            }
        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            StudentsDataGridView.Rows.Clear();

            if (OptionCbBx.Text == "")
            {
                foreach (Stagiaire s in sgs)
                    StudentsDataGridView.Rows.Add(s.ToList());
            }
            else
            {
                foreach (Stagiaire s in sgs)
                    if (s.Option == OptionCbBx.Text)
                        StudentsDataGridView.Rows.Add(s.ToList());
            }
        }
    }
}
