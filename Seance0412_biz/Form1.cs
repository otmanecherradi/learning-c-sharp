using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seance0412_biz
{
    public partial class Form1 : Form
    {
        GestionPerson gps;

        int idx;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gps = new GestionPerson();
            idx = 0;
        }

        private void Reset()
        {
            CINTxBx.Clear();
            LastNameTxBx.Clear();
            FirstNameTxBx.Clear();
            AgeTxBx.Clear();

            foreach (RadioButton r in FamStGrp.Controls)
                r.Checked = false;

            CityCbBx.SelectedIndex = -1;
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string familySituation = "";
                foreach (RadioButton r in FamStGrp.Controls)
                    if (r.Checked) familySituation = r.Text;

                Person p = new Person(CINTxBx.Text, LastNameTxBx.Text, FirstNameTxBx.Text, int.Parse(AgeTxBx.Text), familySituation, CityCbBx.Text);

                gps.Add(p);

                MessageBox.Show("Person added Successfully", "Info");
                
                Reset();

                idx = gps.PS.Count - 1;
            }
            catch (Exception)
            {
                MessageBox.Show("Person NOT added", "Error");
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                gps.Update(CINTxBx.Text, int.Parse(AgeTxBx.Text));

                MessageBox.Show("Person updated Successfully", "Info");
                
                Reset();
            }
            catch (Exception)
            {
                MessageBox.Show("Person NOT updated", "Error");
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                gps.Delete(CINTxBx.Text);

                MessageBox.Show("Person deleted Successfully", "Info");

                Reset();
            }
            catch (Exception)
            {
                MessageBox.Show("Person NOT updated", "Error");
            }
        }

        private void PopulateForm(Person p)
        {
            CINTxBx.Text = p.CIN;
            LastNameTxBx.Text = p.LastName;
            FirstNameTxBx.Text = p.FirstName;
            AgeTxBx.Text = p.Age.ToString();

            foreach (RadioButton r in FamStGrp.Controls)
                r.Checked = r.Text == p.FamilySituation;

            CityCbBx.Text = p.City;
        }

        private void NavFirstBtn_Click(object sender, EventArgs e)
        {
            if (gps.PS.Count > 0)
                PopulateForm(gps.PS[0]);
            else
                MessageBox.Show("No Person had been found", "Error");
        }

        private void NavLastBtn_Click(object sender, EventArgs e)
        {
            if (gps.PS.Count > 0)
                PopulateForm(gps.PS[gps.PS.Count - 1]);
            else
                MessageBox.Show("No Person had been found", "Error");
        }

        private void NavPrevBtn_Click(object sender, EventArgs e)
        {
            if(idx > 0)
            {
                idx -= 1;
                PopulateForm(gps.PS[idx]);
            }
        }

        private void NavNextBtn_Click(object sender, EventArgs e)
        {
            if (idx < gps.PS.Count - 1)
            {
                idx += 1;
                PopulateForm(gps.PS[idx]);
            }
        }
    }
}
