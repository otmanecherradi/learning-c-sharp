using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seance0412
{
    public partial class Form1 : Form
    {

        GestionPerson gps = new GestionPerson();

        int currentIdx = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Reset();

        }

        private void Reset()
        {
            CINTxBx.Clear();
            LastNameTxBx.Clear();
            FirstNameTxBx.Clear();
            AgeTxBx.Clear();
            StFmCRdBtn.Checked = false;
            StFmMRdBtn.Checked = false;
            CityCbBx.SelectedIndex = -1;
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string sf = "";
                if (StFmCRdBtn.Checked) sf = StFmCRdBtn.Text;
                if (StFmMRdBtn.Checked) sf = StFmMRdBtn.Text;

                Person p = new Person(CINTxBx.Text, LastNameTxBx.Text, FirstNameTxBx.Text, int.Parse(AgeTxBx.Text), sf, CityCbBx.Text);
                gps.Add(p);

                PersonsDataGrid.DataSource = gps.Ps;

                Reset();

                MessageBox.Show("Person Added Successfully", "Info");
            }
            catch (Exception)
            {
                MessageBox.Show("Person NOT Added", "Error");
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                gps.Update(CINTxBx.Text, int.Parse(AgeTxBx.Text));

                Reset();
                MessageBox.Show("Person Updated Successfully", "Info");
            }
            catch (Exception)
            {
                MessageBox.Show("Person NOT Updated", "Error");
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                gps.Delete(CINTxBx.Text);

                Reset();
                MessageBox.Show("Person Deleted Successfully", "Info");
            }
            catch (Exception)
            {
                MessageBox.Show("Person NOT Deleted", "Error");
            }
        }

        private void PopulateInputs(Person p)
        {
            Reset();

            CINTxBx.Text = p.CIN;
            LastNameTxBx.Text = p.LastName;
            FirstNameTxBx.Text = p.FirstName;
            AgeTxBx.Text = p.Age.ToString();

            if (StFmCRdBtn.Text == p.SituationFamiliale) StFmCRdBtn.Checked = true;
            if (StFmMRdBtn.Text == p.SituationFamiliale) StFmMRdBtn.Checked = true;

            CityCbBx.Text = p.City;
        }

        private void NavFirstBtn_Click(object sender, EventArgs e)
        {
            PopulateInputs(gps.Ps[0]);
        }

        private void NavBfBtn_Click(object sender, EventArgs e)
        {
            //currentIdx
        }
    }
}
