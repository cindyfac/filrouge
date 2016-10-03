namespace WindowsFormsApplication1
{
    partial class Form_client
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_client));
            this.lb_client = new System.Windows.Forms.ListBox();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.tb_adresse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_mail = new System.Windows.Forms.TextBox();
            this.rb_particulier = new System.Windows.Forms.RadioButton();
            this.rb_professionnel = new System.Windows.Forms.RadioButton();
            this.tb_ville = new System.Windows.Forms.TextBox();
            this.tb_codepostal = new System.Windows.Forms.TextBox();
            this.tb_telephone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_commande = new System.Windows.Forms.Label();
            this.lb_commande = new System.Windows.Forms.ListBox();
            this.lbl_commandes = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.tb_coefficient = new System.Windows.Forms.TextBox();
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.gpbx_coordonnees = new System.Windows.Forms.GroupBox();
            this.cb_commercial = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_valider = new System.Windows.Forms.Button();
            this.tb_reference = new System.Windows.Forms.TextBox();
            this.lbl_reference = new System.Windows.Forms.Label();
            this.tb_prenom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_siret = new System.Windows.Forms.TextBox();
            this.lbl_siret = new System.Windows.Forms.Label();
            this.cb_recherchenom = new System.Windows.Forms.ComboBox();
            this.cb_recherchenumero = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gpbx_coordonnees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_client
            // 
            this.lb_client.FormattingEnabled = true;
            this.lb_client.Items.AddRange(new object[] {
            "en double cliquant sur les noms on arrive sur l\'historique de commande des client" +
                "s"});
            this.lb_client.Location = new System.Drawing.Point(24, 297);
            this.lb_client.Name = "lb_client";
            this.lb_client.Size = new System.Drawing.Size(269, 251);
            this.lb_client.TabIndex = 0;
            this.lb_client.SelectedIndexChanged += new System.EventHandler(this.lb_client_SelectedIndexChanged);
            // 
            // btn_modifier
            // 
            this.btn_modifier.Location = new System.Drawing.Point(361, 371);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(88, 19);
            this.btn_modifier.TabIndex = 1;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.UseVisualStyleBackColor = true;
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Location = new System.Drawing.Point(361, 415);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(88, 19);
            this.btn_supprimer.TabIndex = 2;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(361, 327);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(88, 19);
            this.btn_ajouter.TabIndex = 3;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // tb_adresse
            // 
            this.tb_adresse.Location = new System.Drawing.Point(20, 203);
            this.tb_adresse.Name = "tb_adresse";
            this.tb_adresse.Size = new System.Drawing.Size(254, 20);
            this.tb_adresse.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Prénom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Adresse";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ville";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Code postal";
            // 
            // tb_mail
            // 
            this.tb_mail.Location = new System.Drawing.Point(20, 295);
            this.tb_mail.Name = "tb_mail";
            this.tb_mail.Size = new System.Drawing.Size(254, 20);
            this.tb_mail.TabIndex = 8;
            this.tb_mail.Validating += new System.ComponentModel.CancelEventHandler(this.tb_mail_Validating);
            // 
            // rb_particulier
            // 
            this.rb_particulier.AutoSize = true;
            this.rb_particulier.BackColor = System.Drawing.Color.Transparent;
            this.rb_particulier.Location = new System.Drawing.Point(50, 33);
            this.rb_particulier.Name = "rb_particulier";
            this.rb_particulier.Size = new System.Drawing.Size(71, 17);
            this.rb_particulier.TabIndex = 19;
            this.rb_particulier.TabStop = true;
            this.rb_particulier.Text = "Particulier";
            this.rb_particulier.UseVisualStyleBackColor = false;
            this.rb_particulier.CheckedChanged += new System.EventHandler(this.rb_particulier_CheckedChanged);
            // 
            // rb_professionnel
            // 
            this.rb_professionnel.AutoSize = true;
            this.rb_professionnel.BackColor = System.Drawing.Color.Transparent;
            this.rb_professionnel.Location = new System.Drawing.Point(158, 33);
            this.rb_professionnel.Name = "rb_professionnel";
            this.rb_professionnel.Size = new System.Drawing.Size(88, 17);
            this.rb_professionnel.TabIndex = 18;
            this.rb_professionnel.TabStop = true;
            this.rb_professionnel.Text = "Professionnel";
            this.rb_professionnel.UseVisualStyleBackColor = false;
            // 
            // tb_ville
            // 
            this.tb_ville.Location = new System.Drawing.Point(137, 247);
            this.tb_ville.Name = "tb_ville";
            this.tb_ville.Size = new System.Drawing.Size(137, 20);
            this.tb_ville.TabIndex = 7;
            this.tb_ville.Validating += new System.ComponentModel.CancelEventHandler(this.tb_ville_Validating);
            // 
            // tb_codepostal
            // 
            this.tb_codepostal.Location = new System.Drawing.Point(20, 247);
            this.tb_codepostal.Name = "tb_codepostal";
            this.tb_codepostal.Size = new System.Drawing.Size(93, 20);
            this.tb_codepostal.TabIndex = 6;
            this.tb_codepostal.Validating += new System.ComponentModel.CancelEventHandler(this.tb_codepostal_Validating);
            // 
            // tb_telephone
            // 
            this.tb_telephone.Location = new System.Drawing.Point(20, 338);
            this.tb_telephone.Name = "tb_telephone";
            this.tb_telephone.Size = new System.Drawing.Size(254, 20);
            this.tb_telephone.TabIndex = 9;
            this.tb_telephone.Validating += new System.ComponentModel.CancelEventHandler(this.tb_telephone_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Mail";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 322);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Téléphone";
            // 
            // lbl_commande
            // 
            this.lbl_commande.AutoSize = true;
            this.lbl_commande.Location = new System.Drawing.Point(178, 65);
            this.lbl_commande.Name = "lbl_commande";
            this.lbl_commande.Size = new System.Drawing.Size(0, 13);
            this.lbl_commande.TabIndex = 27;
            // 
            // lb_commande
            // 
            this.lb_commande.FormattingEnabled = true;
            this.lb_commande.Items.AddRange(new object[] {
            "en double cliquant sur les noms on arrive sur l\'historique de commande des client" +
                "s"});
            this.lb_commande.Location = new System.Drawing.Point(20, 436);
            this.lb_commande.Name = "lb_commande";
            this.lb_commande.Size = new System.Drawing.Size(254, 82);
            this.lb_commande.TabIndex = 28;
            // 
            // lbl_commandes
            // 
            this.lbl_commandes.AutoSize = true;
            this.lbl_commandes.Location = new System.Drawing.Point(17, 419);
            this.lbl_commandes.Name = "lbl_commandes";
            this.lbl_commandes.Size = new System.Drawing.Size(65, 13);
            this.lbl_commandes.TabIndex = 29;
            this.lbl_commandes.Text = "Commandes";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(23, 371);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "coefficient";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(124, 51);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 20);
            this.label16.TabIndex = 32;
            this.label16.Text = "Client";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.ForestGreen;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Location = new System.Drawing.Point(343, 536);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(135, 35);
            this.button5.TabIndex = 33;
            this.button5.Text = "Retour";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // tb_coefficient
            // 
            this.tb_coefficient.Location = new System.Drawing.Point(23, 386);
            this.tb_coefficient.Name = "tb_coefficient";
            this.tb_coefficient.Size = new System.Drawing.Size(118, 20);
            this.tb_coefficient.TabIndex = 10;
            // 
            // tb_nom
            // 
            this.tb_nom.Location = new System.Drawing.Point(20, 129);
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.Size = new System.Drawing.Size(254, 20);
            this.tb_nom.TabIndex = 3;
            this.tb_nom.Validating += new System.ComponentModel.CancelEventHandler(this.tb_nom_Validating);
            // 
            // gpbx_coordonnees
            // 
            this.gpbx_coordonnees.BackColor = System.Drawing.Color.Transparent;
            this.gpbx_coordonnees.Controls.Add(this.cb_commercial);
            this.gpbx_coordonnees.Controls.Add(this.label7);
            this.gpbx_coordonnees.Controls.Add(this.btn_valider);
            this.gpbx_coordonnees.Controls.Add(this.tb_reference);
            this.gpbx_coordonnees.Controls.Add(this.lbl_reference);
            this.gpbx_coordonnees.Controls.Add(this.tb_prenom);
            this.gpbx_coordonnees.Controls.Add(this.label6);
            this.gpbx_coordonnees.Controls.Add(this.rb_particulier);
            this.gpbx_coordonnees.Controls.Add(this.tb_coefficient);
            this.gpbx_coordonnees.Controls.Add(this.tb_siret);
            this.gpbx_coordonnees.Controls.Add(this.rb_professionnel);
            this.gpbx_coordonnees.Controls.Add(this.lbl_siret);
            this.gpbx_coordonnees.Controls.Add(this.label14);
            this.gpbx_coordonnees.Controls.Add(this.tb_nom);
            this.gpbx_coordonnees.Controls.Add(this.lbl_commandes);
            this.gpbx_coordonnees.Controls.Add(this.lb_commande);
            this.gpbx_coordonnees.Controls.Add(this.label9);
            this.gpbx_coordonnees.Controls.Add(this.tb_telephone);
            this.gpbx_coordonnees.Controls.Add(this.label8);
            this.gpbx_coordonnees.Controls.Add(this.tb_codepostal);
            this.gpbx_coordonnees.Controls.Add(this.tb_ville);
            this.gpbx_coordonnees.Controls.Add(this.tb_mail);
            this.gpbx_coordonnees.Controls.Add(this.label5);
            this.gpbx_coordonnees.Controls.Add(this.label4);
            this.gpbx_coordonnees.Controls.Add(this.label3);
            this.gpbx_coordonnees.Controls.Add(this.label2);
            this.gpbx_coordonnees.Controls.Add(this.label1);
            this.gpbx_coordonnees.Controls.Add(this.tb_adresse);
            this.gpbx_coordonnees.Enabled = false;
            this.gpbx_coordonnees.Location = new System.Drawing.Point(506, 2);
            this.gpbx_coordonnees.Name = "gpbx_coordonnees";
            this.gpbx_coordonnees.Size = new System.Drawing.Size(296, 596);
            this.gpbx_coordonnees.TabIndex = 37;
            this.gpbx_coordonnees.TabStop = false;
            this.gpbx_coordonnees.Text = "Fiche client";
            // 
            // cb_commercial
            // 
            this.cb_commercial.FormattingEnabled = true;
            this.cb_commercial.Location = new System.Drawing.Point(153, 386);
            this.cb_commercial.Name = "cb_commercial";
            this.cb_commercial.Size = new System.Drawing.Size(121, 21);
            this.cb_commercial.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(150, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "commercial";
            // 
            // btn_valider
            // 
            this.btn_valider.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_valider.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_valider.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_valider.Location = new System.Drawing.Point(85, 534);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(135, 35);
            this.btn_valider.TabIndex = 12;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = false;
            this.btn_valider.Visible = false;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // tb_reference
            // 
            this.tb_reference.Location = new System.Drawing.Point(122, 88);
            this.tb_reference.Name = "tb_reference";
            this.tb_reference.Size = new System.Drawing.Size(152, 20);
            this.tb_reference.TabIndex = 2;
            // 
            // lbl_reference
            // 
            this.lbl_reference.AutoSize = true;
            this.lbl_reference.Location = new System.Drawing.Point(43, 91);
            this.lbl_reference.Name = "lbl_reference";
            this.lbl_reference.Size = new System.Drawing.Size(57, 13);
            this.lbl_reference.TabIndex = 40;
            this.lbl_reference.Text = "Référence";
            // 
            // tb_prenom
            // 
            this.tb_prenom.Location = new System.Drawing.Point(20, 167);
            this.tb_prenom.Name = "tb_prenom";
            this.tb_prenom.Size = new System.Drawing.Size(254, 20);
            this.tb_prenom.TabIndex = 4;
            this.tb_prenom.Validating += new System.ComponentModel.CancelEventHandler(this.tb_prenom_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Prénom";
            // 
            // tb_siret
            // 
            this.tb_siret.Location = new System.Drawing.Point(122, 62);
            this.tb_siret.Name = "tb_siret";
            this.tb_siret.Size = new System.Drawing.Size(152, 20);
            this.tb_siret.TabIndex = 1;
            this.tb_siret.Validating += new System.ComponentModel.CancelEventHandler(this.tb_siret_Validating);
            // 
            // lbl_siret
            // 
            this.lbl_siret.AutoSize = true;
            this.lbl_siret.Location = new System.Drawing.Point(43, 65);
            this.lbl_siret.Name = "lbl_siret";
            this.lbl_siret.Size = new System.Drawing.Size(68, 13);
            this.lbl_siret.TabIndex = 36;
            this.lbl_siret.Text = "Numéro Siret";
            // 
            // cb_recherchenom
            // 
            this.cb_recherchenom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.cb_recherchenom.FormattingEnabled = true;
            this.cb_recherchenom.Location = new System.Drawing.Point(24, 225);
            this.cb_recherchenom.Name = "cb_recherchenom";
            this.cb_recherchenom.Size = new System.Drawing.Size(269, 21);
            this.cb_recherchenom.TabIndex = 38;
            this.cb_recherchenom.SelectedIndexChanged += new System.EventHandler(this.cb_recherchenom_SelectedIndexChanged);
            this.cb_recherchenom.SelectedValueChanged += new System.EventHandler(this.cb_recherchenom_SelectedValueChanged);
            // 
            // cb_recherchenumero
            // 
            this.cb_recherchenumero.FormattingEnabled = true;
            this.cb_recherchenumero.Location = new System.Drawing.Point(24, 271);
            this.cb_recherchenumero.Name = "cb_recherchenumero";
            this.cb_recherchenumero.Size = new System.Drawing.Size(269, 21);
            this.cb_recherchenumero.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "Rechercher par nom";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 255);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 13);
            this.label11.TabIndex = 45;
            this.label11.Text = "Rechercher par référence";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form_client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cb_recherchenumero);
            this.Controls.Add(this.cb_recherchenom);
            this.Controls.Add(this.gpbx_coordonnees);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lbl_commande);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.btn_modifier);
            this.Controls.Add(this.lb_client);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "client";
            this.Load += new System.EventHandler(this.Form_client_Load);
            this.gpbx_coordonnees.ResumeLayout(false);
            this.gpbx_coordonnees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_client;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.TextBox tb_adresse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_mail;
        private System.Windows.Forms.RadioButton rb_particulier;
        private System.Windows.Forms.RadioButton rb_professionnel;
        private System.Windows.Forms.TextBox tb_ville;
        private System.Windows.Forms.TextBox tb_codepostal;
        private System.Windows.Forms.TextBox tb_telephone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_commande;
        private System.Windows.Forms.ListBox lb_commande;
        private System.Windows.Forms.Label lbl_commandes;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox tb_coefficient;
        private System.Windows.Forms.TextBox tb_nom;
        private System.Windows.Forms.GroupBox gpbx_coordonnees;
        private System.Windows.Forms.TextBox tb_siret;
        private System.Windows.Forms.Label lbl_siret;
        private System.Windows.Forms.TextBox tb_prenom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_reference;
        private System.Windows.Forms.Label lbl_reference;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_commercial;
        private System.Windows.Forms.ComboBox cb_recherchenom;
        private System.Windows.Forms.ComboBox cb_recherchenumero;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.ErrorProvider errorProvider1;
    }
}