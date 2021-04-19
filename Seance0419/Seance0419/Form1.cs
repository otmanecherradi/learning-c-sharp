using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seance0419
{
    public partial class Form1 : Form
    {

        public List<ImageObject> ImageObjects = new List<ImageObject>();

        public Form1()
        {
            InitializeComponent();

            ImageObject o = new ImageObject(Image.FromFile(@"C:\Users\osman\source\learning-c-sharp\Seance0419\Seance0419\Resources\thaddaeus-lim-RBthQZJd_vU-unsplash.jpg"), "Unsplash", "thaddaeus-lim");

            Picture.Image = o.Picture;
            FromLabel.Text = o.From;
            AuthorLabel.Text = o.Author;
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void bToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }
    }
}
