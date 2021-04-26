using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seance0426
{
    public partial class Form1 : Form
    {

        private Autocar Autocar1 = new Autocar(50);
        private Autocar Autocar2 = new Autocar(50);

        public Form1()
        {
            InitializeComponent();

            Autocar1.Add(new Personne("K12333", "Kamal", "Yahya", 1, 100, 20));
            Autocar1.Add(new Personne("K12323", "Ali", "Ahmed", 2, 80, 0));

            Autocar2.Add(new Personne("K12133", "Said", "Salma", 1, 80, 40));
            Autocar2.Add(new Personne("K12443", "Chaimaa", "Amine", 2, 80, 40));
        }

        private void ValidateBtn_Click(object sender, EventArgs e)
        {
            Personne p = new Personne()
            {
                NumeroPlace = int.Parse(PlaceTxBx.Text),
            };

            try
            {
                
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
           
        }

        private void autocar1Btn_Click(object sender, EventArgs e)
        {
            dataGrid.DataSource = null;
            dataGrid.DataSource = Autocar1.Personnes;
        }

        private void autocar2Btn_Click(object sender, EventArgs e)
        {
            dataGrid.DataSource = null;
            dataGrid.DataSource = Autocar1.Personnes;
        }
    }
}
