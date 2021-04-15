using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seance0415
{
    public partial class Form1 : Form
    {

        //List<Stagiaire> lstgs = new List<Stagiaire>();

        ListStagiaire lstgs = new ListStagiaire();

        public Form1()
        {
            InitializeComponent();
        }

        // the class to be public so that the prog can see it, even within the same namespace
        //public Stagiaire SearchStagiaire(int n)
        //{
        //    foreach (Stagiaire s in lstgs)
        //        if (s.Num.Equals(n))
        //            return s;
        //    return null;
        //}

        public void Reset()
        {
            NumTxBx.Clear();
            NomTxBx.Clear();
            PrenomTxBx.Clear();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Stagiaire s = new Stagiaire(int.Parse(NumTxBx.Text), NomTxBx.Text, PrenomTxBx.Text);

            //lstgs.Add(s);
            //Reset();

            //MessageBox.Show("Ajout avec succes");

            bool v = lstgs.Add(s);
            if (v)
                MessageBox.Show("Ajout avec succes");
            else
                MessageBox.Show("Deja existant");

            Reset();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            //Stagiaire s = SearchStagiaire(int.Parse(NumTxBx.Text));

            //if (s != null)
            //{
            //    NomTxBx.Text = s.Nom;
            //    PrenomTxBx.Text = s.Prenom;
            //}
            //else
            //{
            //    Reset();
            //    MessageBox.Show("No existant");
            //}

            Stagiaire s = lstgs.Search(int.Parse(NumTxBx.Text));

            if (s != null)
            {
                NomTxBx.Text = s.Nom;
                PrenomTxBx.Text = s.Prenom;
            }
            else
            {
                Reset();
                MessageBox.Show("No existant");
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            //Stagiaire s = SearchStagiaire(int.Parse(NumTxBx.Text));

            //if (s != null)
            //{
            //    s.Nom = NomTxBx.Text;
            //    s.Prenom = PrenomTxBx.Text;
            //    MessageBox.Show("Modifier avec succes");
            //}
            //else               
            //    MessageBox.Show("No existant");

            bool v = lstgs.Update(int.Parse(NumTxBx.Text), NomTxBx.Text, PrenomTxBx.Text);

            if (v)
                MessageBox.Show("Modifier avec succes");
            else
            {
                Reset();
                MessageBox.Show("No existant");
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            //Stagiaire s = SearchStagiaire(int.Parse(NumTxBx.Text));

            //if (s != null)
            //{
            //    lstgs.Remove(s);
            //    MessageBox.Show("Suppression avec succes");
            //}
            //else
            //{
            //    Reset();
            //    MessageBox.Show("No existant");
            //}


            bool v = lstgs.Delete(int.Parse(NumTxBx.Text));

            if (v)
                MessageBox.Show("Suppression avec succes");
            else
            {
                Reset();
                MessageBox.Show("No existant");
            }
        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            //    OldStgDataGrid.Rows.Clear();

            //    foreach (Stagiaire s in lstgs)
            //        OldStgDataGrid.Rows.Add(s.Num, s.Nom, s.Prenom);

            //    // DATASOURCE FOR LIFE !!! HAHAHAH

            //    NewStgDataGrid.DataSource = null;
            //    NewStgDataGrid.DataSource = lstgs;

            OldStgDataGrid.Rows.Clear();

            foreach (Stagiaire s in lstgs.lstgs)
                OldStgDataGrid.Rows.Add(s.Num, s.Nom, s.Prenom);

            NewStgDataGrid.DataSource = null;
            NewStgDataGrid.DataSource = lstgs.lstgs;
        }
    }
}
