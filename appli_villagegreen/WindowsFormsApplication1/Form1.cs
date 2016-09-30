using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_client maform = new Form_client();
            maform.MdiParent = this;
            maform.Show();            
        }

        private void créerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            //Fermer les fenêtres enfants ouvertes
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }

            Form_ajoutcommande maform = new Form_ajoutcommande();
            maform.MdiParent = this;
            maform.Show();
            //DisposeAllButThis(maform);

        }

        private void consulterToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Form_consultationcommande maform = new Form_consultationcommande();
            maform.MdiParent = this;
            maform.Show();
            
            

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void catalogueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultationcatalogue maform = new consultationcatalogue();
            maform.MdiParent = this;
            maform.Show();
        }

        private void listeProduitsCommandésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
            consultationarticlecommande maform = new consultationarticlecommande();
            maform.MdiParent = this;
            maform.Show();
        }

        private void consultationCAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
            Form_consultationCA maform = new Form_consultationCA();
            maform.MdiParent = this;
            maform.Show();
        }

        private void articleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
