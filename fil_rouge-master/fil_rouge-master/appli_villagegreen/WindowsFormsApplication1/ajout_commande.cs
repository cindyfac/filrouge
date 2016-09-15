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
    public partial class Form_ajoutcommande : Form
    {
        public Form_ajoutcommande()
        {
            InitializeComponent();
        }


        private void button8_Click(object sender, EventArgs e)
        {           
            Form_validationcommande maform = new Form_validationcommande();
            maform.MdiParent = this.MdiParent;
            maform.Show();
        }

        private void btn_retour_Click(object sender, EventArgs e)
        {
           Close();
        }
    }
}
