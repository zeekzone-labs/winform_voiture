namespace Inscription
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtMassar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDateNais = new System.Windows.Forms.DateTimePicker();
            this.cmbEquipe = new System.Windows.Forms.ComboBox();
            this.CmdGenerer = new System.Windows.Forms.Button();
            this.CmdEnregistrer = new System.Windows.Forms.Button();
            this.DGVListe = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion d\'insription";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prénom";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(164, 58);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(134, 20);
            this.txtCode.TabIndex = 4;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(164, 130);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(134, 20);
            this.txtPrenom.TabIndex = 5;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(164, 93);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(134, 20);
            this.txtNom.TabIndex = 6;
            // 
            // txtMassar
            // 
            this.txtMassar.Location = new System.Drawing.Point(543, 94);
            this.txtMassar.Name = "txtMassar";
            this.txtMassar.Size = new System.Drawing.Size(134, 20);
            this.txtMassar.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(429, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Date nais";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(429, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Massar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(429, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Equipe";
            // 
            // dtpDateNais
            // 
            this.dtpDateNais.Location = new System.Drawing.Point(543, 59);
            this.dtpDateNais.Name = "dtpDateNais";
            this.dtpDateNais.Size = new System.Drawing.Size(200, 20);
            this.dtpDateNais.TabIndex = 11;
            // 
            // cmbEquipe
            // 
            this.cmbEquipe.FormattingEnabled = true;
            this.cmbEquipe.Location = new System.Drawing.Point(543, 128);
            this.cmbEquipe.Name = "cmbEquipe";
            this.cmbEquipe.Size = new System.Drawing.Size(121, 21);
            this.cmbEquipe.TabIndex = 12;
            // 
            // CmdGenerer
            // 
            this.CmdGenerer.BackColor = System.Drawing.Color.Salmon;
            this.CmdGenerer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdGenerer.ForeColor = System.Drawing.Color.White;
            this.CmdGenerer.Location = new System.Drawing.Point(304, 58);
            this.CmdGenerer.Name = "CmdGenerer";
            this.CmdGenerer.Size = new System.Drawing.Size(75, 23);
            this.CmdGenerer.TabIndex = 13;
            this.CmdGenerer.Text = "Générer";
            this.CmdGenerer.UseVisualStyleBackColor = false;
            this.CmdGenerer.Click += new System.EventHandler(this.CmdGenerer_Click);
            // 
            // CmdEnregistrer
            // 
            this.CmdEnregistrer.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.CmdEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdEnregistrer.ForeColor = System.Drawing.Color.White;
            this.CmdEnregistrer.Location = new System.Drawing.Point(340, 167);
            this.CmdEnregistrer.Name = "CmdEnregistrer";
            this.CmdEnregistrer.Size = new System.Drawing.Size(98, 35);
            this.CmdEnregistrer.TabIndex = 14;
            this.CmdEnregistrer.Text = "Enregistrer";
            this.CmdEnregistrer.UseVisualStyleBackColor = false;
            this.CmdEnregistrer.Click += new System.EventHandler(this.CmdEnregistrer_Click);
            // 
            // DGVListe
            // 
            this.DGVListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListe.Location = new System.Drawing.Point(63, 259);
            this.DGVListe.Name = "DGVListe";
            this.DGVListe.Size = new System.Drawing.Size(680, 150);
            this.DGVListe.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(325, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Liste des étudiant";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DGVListe);
            this.Controls.Add(this.CmdEnregistrer);
            this.Controls.Add(this.CmdGenerer);
            this.Controls.Add(this.cmbEquipe);
            this.Controls.Add(this.dtpDateNais);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMassar);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";

            // Evenement Load de la Form
            this.Load += new System.EventHandler(this.Form1_Load);

            ((System.ComponentModel.ISupportInitialize)(this.DGVListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtMassar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpDateNais;
        private System.Windows.Forms.ComboBox cmbEquipe;
        private System.Windows.Forms.Button CmdGenerer;
        private System.Windows.Forms.Button CmdEnregistrer;
        private System.Windows.Forms.DataGridView DGVListe;
        private System.Windows.Forms.Label label8;
    }
}

