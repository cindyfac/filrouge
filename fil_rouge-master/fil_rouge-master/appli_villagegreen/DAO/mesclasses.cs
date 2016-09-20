using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DAO
{
    public class mesclasses
    {
        public bool monbooleen = false;
        public void VerifString(string ChaineCaractere, ErrorProvider erreur, TextBox txt_box)
        {
            Regex regex = new Regex("^[a-zA-Z]+$");
            if (regex.IsMatch(ChaineCaractere))
            {
                monbooleen = true;
                erreur.SetError(txt_box, "");//ne s'affiche pas
            }
            else
            {
                monbooleen = false;
                erreur.SetError(txt_box, "Format incorrect");
            }
        }
        public void VerifInt(string ChaineCaractere, int taille, TextBox txt_box, ErrorProvider erreur)
        {
            if(ChaineCaractere.Length == taille)
            {
                Regex regex = new Regex("^[0-9]{" + taille + "}");
                if (regex.IsMatch(ChaineCaractere))
                {
                    monbooleen = true;
                    erreur.SetError(txt_box, "");//ne s'affiche pas
                }
                else
                {
                    monbooleen = false;
                    erreur.SetError(txt_box, "Format incorrect");
                }
            }
            else
            {
                monbooleen = false;
                erreur.SetError(txt_box, "Format incorrect");
            }
           
        }
        public void VerifMail(string ChaineCaractere, ErrorProvider erreur, TextBox txt_box)
        {
            Regex regex = new Regex("^[a-z-A-Z_]{2,50}@[a-zA-Z_]+[.][a-zA-Z]{2,3}$");
            if (regex.IsMatch(ChaineCaractere))
            {
                monbooleen = true;
                erreur.SetError(txt_box, "");//ne s'affiche pas
            }
            else
            {
                monbooleen = false;
                erreur.SetError(txt_box, "Format incorrect");
            }

        }
    }
}
