using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using System.Configuration;

namespace WindowsFormsApplication1
{
   
    public partial class Form_consultationcommande : Form
    {
        commandeDAO commandeDao;
        

        public Form_consultationcommande()
        {
            InitializeComponent();
            string connexionDbConfig = ConfigurationManager.AppSettings["connexionDb"];
            commandeDao = new commandeDAO(connexionDbConfig);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form_consultationcommande_Load(object sender, EventArgs e)
        {
            commandeDao = new commandeDAO("server=.;database=VillageGreen; integrated security=true");

            cb_refclient.DataSource = commandeDao.ListCommandeClient();
            cb_refclient.DisplayMember = "Client_id";
            cb_refclient.ValueMember = "Client_id";//valeur réelle dans la listBox

            cb_numcom.DataSource = commandeDao.ListRefCommande();
            cb_numcom.DisplayMember = "Commande_id";
            cb_numcom.ValueMember = "Commande_id";//valeur réelle dans la listBox
            
            dgv_commande.DataSource = commandeDao.ListCommande();
            dgv_commande.Columns[2].Visible = false;
            dgv_commande.Columns[3].Visible = false;
            dgv_commande.Columns[5].Visible = false;
            dgv_commande.Columns[7].Visible = false;
            dgv_commande.Columns[8].Visible = false;
            dgv_commande.Columns[9].Visible = false;
            dgv_commande.Columns[10].Visible = false;
            dgv_commande.Columns[12].Visible = false;
            dgv_commande.Columns[0].HeaderText = "ref";
            dgv_commande.Columns[0].Width = 50;
            dgv_commande.Columns[1].Width = 150;
            dgv_commande.Columns[11].DisplayIndex = 1;
            dgv_commande.Columns[6].DefaultCellStyle.Format= "c";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_commande_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }
    }
}
