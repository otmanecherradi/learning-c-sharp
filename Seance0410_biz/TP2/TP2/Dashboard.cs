using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void QuitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            if (DisplayRichTxBx.Text != "")
                DisplayRichTxBx.Text += "\n===============================\n\n";

            DisplayRichTxBx.Text += "Bonjour ::> ";
            DisplayRichTxBx.Text += string.Join(" ", FirstNameTxBx.Text, LastNameTxBx.Text);
            DisplayRichTxBx.Text += "\n";

            DisplayRichTxBx.Text += $"Date de naissance ::> {BirthdayDatePicker.Value.ToString("d")}";
            DisplayRichTxBx.Text += "\n";

            string g = "";
            foreach (RadioButton r in GenderGrpBx.Controls)
            {
                if (r.Checked)
                    g = r.Text;
            }
            DisplayRichTxBx.Text += $"Sexe ::> {g}";
            DisplayRichTxBx.Text += "\n";

            string b = "";
            foreach (RadioButton r in BranchesGrpBx.Controls)
            {
                if (r.Checked)
                    b = r.Text;
            }
            DisplayRichTxBx.Text += $"Branche ::> {b}";
            DisplayRichTxBx.Text += "\n";

            string h = "";
            foreach (CheckBox cb in HobbiesGrpBx.Controls)
            {
                if (cb.Checked)
                    h += $"{cb.Text}; ";
            }
            DisplayRichTxBx.Text += $"Loisirs ::> {h}";
            DisplayRichTxBx.Text += "\n";

            DisplayRichTxBx.Text += $"Diplomes ::> ({DegreeCheckListBx.CheckedIndices.Count})";
            string d = "";
            for (int i = 0; i < DegreeCheckListBx.Items.Count; i += 1)
                if (DegreeCheckListBx.GetItemChecked(i))
                {
                    d += $"{DegreeCheckListBx.Items[i]}; ";
                }

            DisplayRichTxBx.Text += $"{d}";
            DisplayRichTxBx.Text += "\n";
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DisplayRichTxBx.Clear();
            FirstNameTxBx.Clear();
            LastNameTxBx.Clear();

            BirthdayDatePicker.Value = DateTime.Now;

            foreach (RadioButton r in GenderGrpBx.Controls)
                r.Checked = false;

            foreach (RadioButton r in BranchesGrpBx.Controls)
                r.Checked = false;

            foreach (CheckBox cb in HobbiesGrpBx.Controls)
                cb.Checked = false;

            foreach(int i in DegreeCheckListBx.CheckedIndices)
                DegreeCheckListBx.SetItemCheckState(i, CheckState.Unchecked);
        }
    }
}
