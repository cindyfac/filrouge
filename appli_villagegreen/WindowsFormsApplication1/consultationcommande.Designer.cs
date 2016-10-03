namespace WindowsFormsApplication1
{
    partial class Form_consultationcommande
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_consultationcommande));
            this.cb_numcom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_commande = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_refclient = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_etatcom = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_chercher = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_commande)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_numcom
            // 
            this.cb_numcom.FormattingEnabled = true;
            this.cb_numcom.Location = new System.Drawing.Point(19, 103);
            this.cb_numcom.Name = "cb_numcom";
            this.cb_numcom.Size = new System.Drawing.Size(121, 21);
            this.cb_numcom.TabIndex = 108;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 107;
            this.label2.Text = "Numéro de commande";
            // 
            // dgv_commande
            // 
            this.dgv_commande.AllowUserToAddRows = false;
            this.dgv_commande.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_commande.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_commande.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_commande.BackgroundColor = System.Drawing.Color.White;
            this.dgv_commande.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_commande.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_commande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_commande.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_commande.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_commande.Location = new System.Drawing.Point(105, 266);
            this.dgv_commande.Name = "dgv_commande";
            this.dgv_commande.ReadOnly = true;
            this.dgv_commande.Size = new System.Drawing.Size(591, 240);
            this.dgv_commande.TabIndex = 106;
            this.dgv_commande.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_commande_CellContentDoubleClick);
            this.dgv_commande.Sorted += new System.EventHandler(this.dgv_commande_Sorted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 105;
            this.label1.Text = "Référence client";
            // 
            // cb_refclient
            // 
            this.cb_refclient.FormattingEnabled = true;
            this.cb_refclient.Location = new System.Drawing.Point(19, 50);
            this.cb_refclient.Name = "cb_refclient";
            this.cb_refclient.Size = new System.Drawing.Size(121, 21);
            this.cb_refclient.TabIndex = 104;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(124, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(219, 20);
            this.label8.TabIndex = 109;
            this.label8.Text = "Consultation des commandes";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cb_etatcom);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_chercher);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb_refclient);
            this.groupBox1.Controls.Add(this.cb_numcom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(396, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 195);
            this.groupBox1.TabIndex = 110;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recherche";
            // 
            // cb_etatcom
            // 
            this.cb_etatcom.FormattingEnabled = true;
            this.cb_etatcom.Items.AddRange(new object[] {
            "en cours de livraison",
            "en attente",
            "en cours de préparation"});
            this.cb_etatcom.Location = new System.Drawing.Point(20, 163);
            this.cb_etatcom.Name = "cb_etatcom";
            this.cb_etatcom.Size = new System.Drawing.Size(121, 21);
            this.cb_etatcom.TabIndex = 114;
            this.cb_etatcom.SelectedIndexChanged += new System.EventHandler(this.cb_etatcom_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 115;
            this.label4.Text = "Etat commande";
            // 
            // btn_chercher
            // 
            this.btn_chercher.Location = new System.Drawing.Point(246, 154);
            this.btn_chercher.Name = "btn_chercher";
            this.btn_chercher.Size = new System.Drawing.Size(75, 23);
            this.btn_chercher.TabIndex = 111;
            this.btn_chercher.Text = "Chercher";
            this.btn_chercher.UseVisualStyleBackColor = true;
            this.btn_chercher.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.ForestGreen;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(642, 544);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 35);
            this.button2.TabIndex = 110;
            this.button2.Text = "Retour";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(483, 544);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 35);
            this.button1.TabIndex = 109;
            this.button1.Text = "Imprimer";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form_consultationcommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgv_commande);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_consultationcommande";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "consultationcommande";
            this.Load += new System.EventHandler(this.Form_consultationcommande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_commande)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_numcom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_commande;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_refclient;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_chercher;
        private System.Windows.Forms.ComboBox cb_etatcom;
        private System.Windows.Forms.Label label4;
    }
}