namespace WindowsFormsApplication1
{
    partial class Form_validationcommande
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_validationcommande));
            this.label8 = new System.Windows.Forms.Label();
            this.btn_valider = new System.Windows.Forms.Button();
            this.btn_imprimer = new System.Windows.Forms.Button();
            this.btn_retour = new System.Windows.Forms.Button();
            this.gb_livraison = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tb_telephone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_mail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_codepostal = new System.Windows.Forms.TextBox();
            this.tb_ville = new System.Windows.Forms.TextBox();
            this.tb_adresse = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_prenom = new System.Windows.Forms.TextBox();
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.gb_facturation = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_telephone2 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_mail2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_codepostal2 = new System.Windows.Forms.TextBox();
            this.tb_ville2 = new System.Windows.Forms.TextBox();
            this.tb_adresse2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tb_prenom2 = new System.Windows.Forms.TextBox();
            this.tb_nom2 = new System.Windows.Forms.TextBox();
            this.gp_paiement = new System.Windows.Forms.GroupBox();
            this.gb_livraison.SuspendLayout();
            this.gb_facturation.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(124, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "Validation de la commande";
            // 
            // btn_valider
            // 
            this.btn_valider.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_valider.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_valider.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_valider.Location = new System.Drawing.Point(326, 545);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(135, 35);
            this.btn_valider.TabIndex = 32;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = false;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // btn_imprimer
            // 
            this.btn_imprimer.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_imprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_imprimer.Location = new System.Drawing.Point(485, 545);
            this.btn_imprimer.Name = "btn_imprimer";
            this.btn_imprimer.Size = new System.Drawing.Size(135, 35);
            this.btn_imprimer.TabIndex = 33;
            this.btn_imprimer.Text = "Imprimer";
            this.btn_imprimer.UseVisualStyleBackColor = false;
            // 
            // btn_retour
            // 
            this.btn_retour.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_retour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_retour.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_retour.Location = new System.Drawing.Point(644, 545);
            this.btn_retour.Name = "btn_retour";
            this.btn_retour.Size = new System.Drawing.Size(135, 35);
            this.btn_retour.TabIndex = 34;
            this.btn_retour.Text = "Retour";
            this.btn_retour.UseVisualStyleBackColor = false;
            this.btn_retour.Click += new System.EventHandler(this.btn_retour_Click);
            // 
            // gb_livraison
            // 
            this.gb_livraison.BackColor = System.Drawing.Color.Transparent;
            this.gb_livraison.Controls.Add(this.label1);
            this.gb_livraison.Controls.Add(this.textBox1);
            this.gb_livraison.Controls.Add(this.tb_telephone);
            this.gb_livraison.Controls.Add(this.label9);
            this.gb_livraison.Controls.Add(this.tb_mail);
            this.gb_livraison.Controls.Add(this.label4);
            this.gb_livraison.Controls.Add(this.tb_codepostal);
            this.gb_livraison.Controls.Add(this.tb_ville);
            this.gb_livraison.Controls.Add(this.tb_adresse);
            this.gb_livraison.Controls.Add(this.label5);
            this.gb_livraison.Controls.Add(this.label6);
            this.gb_livraison.Controls.Add(this.label7);
            this.gb_livraison.Controls.Add(this.label10);
            this.gb_livraison.Controls.Add(this.label11);
            this.gb_livraison.Controls.Add(this.tb_prenom);
            this.gb_livraison.Controls.Add(this.tb_nom);
            this.gb_livraison.Location = new System.Drawing.Point(64, 185);
            this.gb_livraison.Name = "gb_livraison";
            this.gb_livraison.Size = new System.Drawing.Size(312, 328);
            this.gb_livraison.TabIndex = 35;
            this.gb_livraison.TabStop = false;
            this.gb_livraison.Text = "Adresse de livraison";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Nom de l\'adresse";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 20);
            this.textBox1.TabIndex = 44;
            // 
            // tb_telephone
            // 
            this.tb_telephone.Location = new System.Drawing.Point(27, 300);
            this.tb_telephone.Name = "tb_telephone";
            this.tb_telephone.Size = new System.Drawing.Size(254, 20);
            this.tb_telephone.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Téléphone";
            // 
            // tb_mail
            // 
            this.tb_mail.Location = new System.Drawing.Point(27, 251);
            this.tb_mail.Name = "tb_mail";
            this.tb_mail.Size = new System.Drawing.Size(254, 20);
            this.tb_mail.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Mail";
            // 
            // tb_codepostal
            // 
            this.tb_codepostal.Location = new System.Drawing.Point(27, 206);
            this.tb_codepostal.Name = "tb_codepostal";
            this.tb_codepostal.Size = new System.Drawing.Size(93, 20);
            this.tb_codepostal.TabIndex = 39;
            // 
            // tb_ville
            // 
            this.tb_ville.Location = new System.Drawing.Point(144, 205);
            this.tb_ville.Name = "tb_ville";
            this.tb_ville.Size = new System.Drawing.Size(137, 20);
            this.tb_ville.TabIndex = 38;
            // 
            // tb_adresse
            // 
            this.tb_adresse.Location = new System.Drawing.Point(27, 162);
            this.tb_adresse.Name = "tb_adresse";
            this.tb_adresse.Size = new System.Drawing.Size(254, 20);
            this.tb_adresse.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Code postal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(144, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Ville";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Adresse";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Prénom";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Nom";
            // 
            // tb_prenom
            // 
            this.tb_prenom.Location = new System.Drawing.Point(27, 119);
            this.tb_prenom.Name = "tb_prenom";
            this.tb_prenom.Size = new System.Drawing.Size(254, 20);
            this.tb_prenom.TabIndex = 31;
            // 
            // tb_nom
            // 
            this.tb_nom.Location = new System.Drawing.Point(27, 76);
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.Size = new System.Drawing.Size(254, 20);
            this.tb_nom.TabIndex = 30;
            // 
            // gb_facturation
            // 
            this.gb_facturation.BackColor = System.Drawing.Color.Transparent;
            this.gb_facturation.Controls.Add(this.label2);
            this.gb_facturation.Controls.Add(this.tb_telephone2);
            this.gb_facturation.Controls.Add(this.textBox2);
            this.gb_facturation.Controls.Add(this.label3);
            this.gb_facturation.Controls.Add(this.tb_mail2);
            this.gb_facturation.Controls.Add(this.label12);
            this.gb_facturation.Controls.Add(this.tb_codepostal2);
            this.gb_facturation.Controls.Add(this.tb_ville2);
            this.gb_facturation.Controls.Add(this.tb_adresse2);
            this.gb_facturation.Controls.Add(this.label13);
            this.gb_facturation.Controls.Add(this.label14);
            this.gb_facturation.Controls.Add(this.label15);
            this.gb_facturation.Controls.Add(this.label16);
            this.gb_facturation.Controls.Add(this.label17);
            this.gb_facturation.Controls.Add(this.tb_prenom2);
            this.gb_facturation.Controls.Add(this.tb_nom2);
            this.gb_facturation.Location = new System.Drawing.Point(430, 185);
            this.gb_facturation.Name = "gb_facturation";
            this.gb_facturation.Size = new System.Drawing.Size(312, 328);
            this.gb_facturation.TabIndex = 44;
            this.gb_facturation.TabStop = false;
            this.gb_facturation.Text = "Adresse de facturation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Nom de l\'adresse";
            // 
            // tb_telephone2
            // 
            this.tb_telephone2.Location = new System.Drawing.Point(27, 301);
            this.tb_telephone2.Name = "tb_telephone2";
            this.tb_telephone2.Size = new System.Drawing.Size(254, 20);
            this.tb_telephone2.TabIndex = 43;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(106, 31);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(175, 20);
            this.textBox2.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Téléphone";
            // 
            // tb_mail2
            // 
            this.tb_mail2.Location = new System.Drawing.Point(27, 252);
            this.tb_mail2.Name = "tb_mail2";
            this.tb_mail2.Size = new System.Drawing.Size(254, 20);
            this.tb_mail2.TabIndex = 41;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 238);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 40;
            this.label12.Text = "Mail";
            // 
            // tb_codepostal2
            // 
            this.tb_codepostal2.Location = new System.Drawing.Point(27, 207);
            this.tb_codepostal2.Name = "tb_codepostal2";
            this.tb_codepostal2.Size = new System.Drawing.Size(93, 20);
            this.tb_codepostal2.TabIndex = 39;
            // 
            // tb_ville2
            // 
            this.tb_ville2.Location = new System.Drawing.Point(144, 206);
            this.tb_ville2.Name = "tb_ville2";
            this.tb_ville2.Size = new System.Drawing.Size(137, 20);
            this.tb_ville2.TabIndex = 38;
            // 
            // tb_adresse2
            // 
            this.tb_adresse2.Location = new System.Drawing.Point(27, 163);
            this.tb_adresse2.Name = "tb_adresse2";
            this.tb_adresse2.Size = new System.Drawing.Size(254, 20);
            this.tb_adresse2.TabIndex = 37;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 193);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 36;
            this.label13.Text = "Code postal";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(144, 190);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 13);
            this.label14.TabIndex = 35;
            this.label14.Text = "Ville";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(27, 147);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 13);
            this.label15.TabIndex = 34;
            this.label15.Text = "Adresse";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(27, 104);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 13);
            this.label16.TabIndex = 33;
            this.label16.Text = "Prénom";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(27, 61);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 13);
            this.label17.TabIndex = 32;
            this.label17.Text = "Nom";
            // 
            // tb_prenom2
            // 
            this.tb_prenom2.Location = new System.Drawing.Point(27, 120);
            this.tb_prenom2.Name = "tb_prenom2";
            this.tb_prenom2.Size = new System.Drawing.Size(254, 20);
            this.tb_prenom2.TabIndex = 31;
            this.tb_prenom2.TextChanged += new System.EventHandler(this.textBox13_TextChanged);
            // 
            // tb_nom2
            // 
            this.tb_nom2.Location = new System.Drawing.Point(27, 77);
            this.tb_nom2.Name = "tb_nom2";
            this.tb_nom2.Size = new System.Drawing.Size(254, 20);
            this.tb_nom2.TabIndex = 30;
            // 
            // gp_paiement
            // 
            this.gp_paiement.BackColor = System.Drawing.Color.Transparent;
            this.gp_paiement.Location = new System.Drawing.Point(430, 37);
            this.gp_paiement.Name = "gp_paiement";
            this.gp_paiement.Size = new System.Drawing.Size(312, 129);
            this.gp_paiement.TabIndex = 45;
            this.gp_paiement.TabStop = false;
            this.gp_paiement.Text = "Mode de paiement";
            // 
            // Form_validationcommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.gp_paiement);
            this.Controls.Add(this.gb_facturation);
            this.Controls.Add(this.gb_livraison);
            this.Controls.Add(this.btn_retour);
            this.Controls.Add(this.btn_imprimer);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_validationcommande";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "validationcommande";
            this.gb_livraison.ResumeLayout(false);
            this.gb_livraison.PerformLayout();
            this.gb_facturation.ResumeLayout(false);
            this.gb_facturation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.Button btn_imprimer;
        private System.Windows.Forms.Button btn_retour;
        private System.Windows.Forms.GroupBox gb_livraison;
        private System.Windows.Forms.TextBox tb_telephone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_mail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_codepostal;
        private System.Windows.Forms.TextBox tb_ville;
        private System.Windows.Forms.TextBox tb_adresse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_prenom;
        private System.Windows.Forms.TextBox tb_nom;
        private System.Windows.Forms.GroupBox gb_facturation;
        private System.Windows.Forms.TextBox tb_telephone2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_mail2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_codepostal2;
        private System.Windows.Forms.TextBox tb_ville2;
        private System.Windows.Forms.TextBox tb_adresse2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tb_prenom2;
        private System.Windows.Forms.TextBox tb_nom2;
        private System.Windows.Forms.GroupBox gp_paiement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
    }
}