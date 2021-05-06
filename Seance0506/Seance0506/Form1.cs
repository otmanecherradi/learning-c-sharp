using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seance0506
{
    public partial class Form1 : Form
    {

        LFiliere lf;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lf = new LFiliere();

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Filiere f = new Filiere(CodeTxBx.Text, LibelleTxBx.Text);
            lf.Filieres.Add(f);

            FiliereTreeView.Nodes.Add(f.Libelle);
            FiliereCbBx.Items.Add(f.Code);

            CodeTxBx.Clear();
            LibelleTxBx.Clear();
        }

        private void SaveEtudiantBtn_Click(object sender, EventArgs e)
        {
            Stagiaire s = new Stagiaire(CNETxBx.Text, NomTxBx.Text, PrenomTxBx.Text);

            int idx = FiliereCbBx.SelectedIndex;

            FiliereTreeView.Nodes[idx].Nodes.Add(s.Nom);
            lf.Filieres[idx].Stagiaires.Add(s);

            CNETxBx.Clear();
            NomTxBx.Clear();
            PrenomTxBx.Clear();

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            int idx = FiliereTreeView.SelectedNode.Index;

            if(FiliereTreeView.SelectedNode.Parent == null)
            {
                lf.Filieres.RemoveAt(idx);
            }
            else
            {
                int idxFiliere = FiliereTreeView.SelectedNode.Parent.Index;
                lf.Filieres[idxFiliere].Stagiaires.RemoveAt(idx);
            }

            FiliereTreeView.Nodes.Remove(FiliereTreeView.SelectedNode);
        }
    }
}
