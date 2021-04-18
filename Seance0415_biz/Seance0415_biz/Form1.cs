using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seance0415_biz
{
    public partial class Form1 : Form
    {

        DonnerManagement donnerManagement;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BloodGrpCbBx.Items.AddRange(new string[] { "A", "B", "O", "AB" });
            Reset();

            donnerManagement = new DonnerManagement();
        }

        void Reset()
        {
            CINTxBx.Clear();
            LastNameTxBx.Clear();
            FirstNameTxBx.Clear();
            BloodGrpCbBx.Text = "";
            RHPlusRdBtn.Checked = false;
            RHMinusRdBtn.Checked = false;
        }

        private void RefreshDataGrid()
        {
            DonnersDataGrid.DataSource = null;
            DonnersDataGrid.DataSource = donnerManagement.Donners;
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                BloodType bloodGrp = (BloodType)Enum.Parse(typeof(BloodType), BloodGrpCbBx.Text);

                RH rhesus = RHPlusRdBtn.Checked ? RH.Minus : RH.Plus;

                Donner d = new Donner(CINTxBx.Text, LastNameTxBx.Text, FirstNameTxBx.Text, bloodGrp, rhesus);

                donnerManagement.Add(d);

                RefreshDataGrid();

                MessageBox.Show("Ajout avec succe");
                Reset();
            }
            catch (Exception ep)
            {
                MessageBox.Show(ep.Message);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Sure ?", "Sure ?", MessageBoxButtons.OKCancel);
                if (r.Equals(DialogResult.OK))
                {
                    donnerManagement.Remove(CINTxBx.Text);
                    RefreshDataGrid();

                    MessageBox.Show("Supression avec succe");
                }
                Reset();
            }
            catch (Exception ep)
            {
                MessageBox.Show(ep.Message);
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                donnerManagement.SaveToXML();
                MessageBox.Show("Sauvegarde avec succe");
            }
            catch (Exception ep)
            {
                MessageBox.Show(ep.Message);
            }
        }
    }
}
