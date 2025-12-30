namespace ValidationDescommandes
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
            this.cbClient = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnCmd = new System.Windows.Forms.Button();
            this.BtnValider = new System.Windows.Forms.Button();
            this.txtNumCmd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DGVCmd = new System.Windows.Forms.DataGridView();
            this.BtnArticlesCmd = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DGVArticlesCmd = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCmd)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVArticlesCmd)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client";
            // 
            // cbClient
            // 
            this.cbClient.FormattingEnabled = true;
            this.cbClient.Location = new System.Drawing.Point(42, 25);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(121, 21);
            this.cbClient.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbClient);
            this.panel1.Location = new System.Drawing.Point(29, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 181);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnCmd);
            this.panel2.Controls.Add(this.BtnValider);
            this.panel2.Controls.Add(this.txtNumCmd);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.DGVCmd);
            this.panel2.Location = new System.Drawing.Point(207, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(613, 181);
            this.panel2.TabIndex = 3;
            // 
            // BtnCmd
            // 
            this.BtnCmd.BackColor = System.Drawing.Color.Turquoise;
            this.BtnCmd.Location = new System.Drawing.Point(269, 36);
            this.BtnCmd.Name = "BtnCmd";
            this.BtnCmd.Size = new System.Drawing.Size(75, 23);
            this.BtnCmd.TabIndex = 4;
            this.BtnCmd.Text = "CMDs";
            this.BtnCmd.UseVisualStyleBackColor = false;
            this.BtnCmd.Click += new System.EventHandler(this.BtnCmd_Click);
            // 
            // BtnValider
            // 
            this.BtnValider.BackColor = System.Drawing.Color.Lime;
            this.BtnValider.Location = new System.Drawing.Point(299, 1);
            this.BtnValider.Name = "BtnValider";
            this.BtnValider.Size = new System.Drawing.Size(75, 23);
            this.BtnValider.TabIndex = 3;
            this.BtnValider.Text = "Valider";
            this.BtnValider.UseVisualStyleBackColor = false;
            this.BtnValider.Click += new System.EventHandler(this.BtnValider_Click);
            // 
            // txtNumCmd
            // 
            this.txtNumCmd.Location = new System.Drawing.Point(193, 3);
            this.txtNumCmd.Name = "txtNumCmd";
            this.txtNumCmd.Size = new System.Drawing.Size(100, 20);
            this.txtNumCmd.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Num. Cmd";
            // 
            // DGVCmd
            // 
            this.DGVCmd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCmd.Location = new System.Drawing.Point(23, 65);
            this.DGVCmd.Name = "DGVCmd";
            this.DGVCmd.Size = new System.Drawing.Size(561, 113);
            this.DGVCmd.TabIndex = 0;
            // 
            // BtnArticlesCmd
            // 
            this.BtnArticlesCmd.BackColor = System.Drawing.Color.Orange;
            this.BtnArticlesCmd.Location = new System.Drawing.Point(324, 32);
            this.BtnArticlesCmd.Name = "BtnArticlesCmd";
            this.BtnArticlesCmd.Size = new System.Drawing.Size(75, 23);
            this.BtnArticlesCmd.TabIndex = 4;
            this.BtnArticlesCmd.Text = "Articles";
            this.BtnArticlesCmd.UseVisualStyleBackColor = false;
            this.BtnArticlesCmd.Click += new System.EventHandler(this.BtnArticlesCmd_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BtnArticlesCmd);
            this.panel3.Controls.Add(this.DGVArticlesCmd);
            this.panel3.Location = new System.Drawing.Point(29, 209);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(741, 234);
            this.panel3.TabIndex = 4;
            // 
            // DGVArticlesCmd
            // 
            this.DGVArticlesCmd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVArticlesCmd.Location = new System.Drawing.Point(103, 61);
            this.DGVArticlesCmd.Name = "DGVArticlesCmd";
            this.DGVArticlesCmd.Size = new System.Drawing.Size(510, 150);
            this.DGVArticlesCmd.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCmd)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVArticlesCmd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbClient;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGVCmd;
        private System.Windows.Forms.TextBox txtNumCmd;
        private System.Windows.Forms.Button BtnValider;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView DGVArticlesCmd;
        private System.Windows.Forms.Button BtnArticlesCmd;
        private System.Windows.Forms.Button BtnCmd;
    }
}

