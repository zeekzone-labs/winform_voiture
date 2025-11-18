namespace VoituresCRUD
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox textBox1; // Pour saisir la libelle/marque
        private System.Windows.Forms.DataGridView dataGridView1; // Pour l'affichage
        
        // les buttons
        private System.Windows.Forms.Button buttonAdd; // ajouter marque
        private System.Windows.Forms.Button buttonDelete; // supprimer
        private System.Windows.Forms.Button buttonShow; // afficher

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonShow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAjouterVoiture = new System.Windows.Forms.Button();
            this.btnSupprimerVoiture = new System.Windows.Forms.Button();
            this.vMarqueCBox = new System.Windows.Forms.ComboBox();
            this.vMatriculeTBox = new System.Windows.Forms.TextBox();
            this.vModeleTBox = new System.Windows.Forms.TextBox();
            this.vPrixTBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAfficherVoitures = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.voitureDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voitureDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 20);
            this.textBox1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(472, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(308, 132);
            this.dataGridView1.TabIndex = 3;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAdd.Location = new System.Drawing.Point(69, 50);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(90, 30);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Ajouter";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Red;
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDelete.Location = new System.Drawing.Point(165, 50);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(90, 30);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Supprimer";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonShow
            // 
            this.buttonShow.BackColor = System.Drawing.Color.Gold;
            this.buttonShow.Location = new System.Drawing.Point(376, 69);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(90, 30);
            this.buttonShow.TabIndex = 0;
            this.buttonShow.Text = "Afficher";
            this.buttonShow.UseVisualStyleBackColor = false;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Marque";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(555, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Liste des marques";
            // 
            // btnAjouterVoiture
            // 
            this.btnAjouterVoiture.BackColor = System.Drawing.Color.LightGreen;
            this.btnAjouterVoiture.Location = new System.Drawing.Point(46, 347);
            this.btnAjouterVoiture.Name = "btnAjouterVoiture";
            this.btnAjouterVoiture.Size = new System.Drawing.Size(113, 23);
            this.btnAjouterVoiture.TabIndex = 7;
            this.btnAjouterVoiture.Text = "Ajouter Voiture";
            this.btnAjouterVoiture.UseVisualStyleBackColor = false;
            this.btnAjouterVoiture.Click += new System.EventHandler(this.btnAjouterVoiture_Click);
            // 
            // btnSupprimerVoiture
            // 
            this.btnSupprimerVoiture.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSupprimerVoiture.Location = new System.Drawing.Point(165, 347);
            this.btnSupprimerVoiture.Name = "btnSupprimerVoiture";
            this.btnSupprimerVoiture.Size = new System.Drawing.Size(113, 23);
            this.btnSupprimerVoiture.TabIndex = 8;
            this.btnSupprimerVoiture.Text = "Supprimer Voiture";
            this.btnSupprimerVoiture.UseVisualStyleBackColor = false;
            this.btnSupprimerVoiture.Click += new System.EventHandler(this.btnSupprimerVoiture_Click);
            // 
            // vMarqueCBox
            // 
            this.vMarqueCBox.FormattingEnabled = true;
            this.vMarqueCBox.Location = new System.Drawing.Point(90, 213);
            this.vMarqueCBox.Name = "vMarqueCBox";
            this.vMarqueCBox.Size = new System.Drawing.Size(121, 21);
            this.vMarqueCBox.TabIndex = 9;
            // 
            // vMatriculeTBox
            // 
            this.vMatriculeTBox.Location = new System.Drawing.Point(90, 246);
            this.vMatriculeTBox.Name = "vMatriculeTBox";
            this.vMatriculeTBox.Size = new System.Drawing.Size(100, 20);
            this.vMatriculeTBox.TabIndex = 10;
            // 
            // vModeleTBox
            // 
            this.vModeleTBox.Location = new System.Drawing.Point(90, 278);
            this.vModeleTBox.Name = "vModeleTBox";
            this.vModeleTBox.Size = new System.Drawing.Size(100, 20);
            this.vModeleTBox.TabIndex = 11;
            // 
            // vPrixTBox
            // 
            this.vPrixTBox.Location = new System.Drawing.Point(90, 304);
            this.vPrixTBox.Name = "vPrixTBox";
            this.vPrixTBox.Size = new System.Drawing.Size(100, 20);
            this.vPrixTBox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "V.Marque";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Matricule";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Modele";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Prix";
            // 
            // btnAfficherVoitures
            // 
            this.btnAfficherVoitures.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAfficherVoitures.Location = new System.Drawing.Point(254, 262);
            this.btnAfficherVoitures.Name = "btnAfficherVoitures";
            this.btnAfficherVoitures.Size = new System.Drawing.Size(90, 47);
            this.btnAfficherVoitures.TabIndex = 17;
            this.btnAfficherVoitures.Text = "Afficher les voitures";
            this.btnAfficherVoitures.UseVisualStyleBackColor = false;
            this.btnAfficherVoitures.Click += new System.EventHandler(this.btnAfficherVoitures_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "* Ajout d\'une voiture";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(555, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Liste des voitures";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "* Ajout d\'une marque";
            // 
            // voitureDataGridView
            // 
            this.voitureDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.voitureDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.voitureDataGridView.Location = new System.Drawing.Point(350, 213);
            this.voitureDataGridView.Name = "voitureDataGridView";
            this.voitureDataGridView.Size = new System.Drawing.Size(430, 230);
            this.voitureDataGridView.TabIndex = 21;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(792, 613);
            this.Controls.Add(this.voitureDataGridView);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAfficherVoitures);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vPrixTBox);
            this.Controls.Add(this.vModeleTBox);
            this.Controls.Add(this.vMatriculeTBox);
            this.Controls.Add(this.vMarqueCBox);
            this.Controls.Add(this.btnSupprimerVoiture);
            this.Controls.Add(this.btnAjouterVoiture);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Gestion des Marques";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voitureDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAjouterVoiture;
        private System.Windows.Forms.Button btnSupprimerVoiture;
        private System.Windows.Forms.ComboBox vMarqueCBox;
        private System.Windows.Forms.TextBox vMatriculeTBox;
        private System.Windows.Forms.TextBox vModeleTBox;
        private System.Windows.Forms.TextBox vPrixTBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAfficherVoitures;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView voitureDataGridView;
    }
}
