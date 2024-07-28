namespace GUI
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Z1 = new System.Windows.Forms.Label();
            this.Z2 = new System.Windows.Forms.Label();
            this.Z3 = new System.Windows.Forms.Label();
            this.Z4 = new System.Windows.Forms.Label();
            this.LblO = new System.Windows.Forms.Label();
            this.Activate = new System.Windows.Forms.Button();
            this.Deact = new System.Windows.Forms.Button();
            this.rest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Z1
            // 
            this.Z1.AutoSize = true;
            this.Z1.BackColor = System.Drawing.Color.Green;
            this.Z1.Location = new System.Drawing.Point(83, 47);
            this.Z1.Name = "Z1";
            this.Z1.Size = new System.Drawing.Size(55, 20);
            this.Z1.TabIndex = 0;
            this.Z1.Text = "Zone1";
            // 
            // Z2
            // 
            this.Z2.AutoSize = true;
            this.Z2.BackColor = System.Drawing.Color.Green;
            this.Z2.Location = new System.Drawing.Point(172, 47);
            this.Z2.Name = "Z2";
            this.Z2.Size = new System.Drawing.Size(55, 20);
            this.Z2.TabIndex = 1;
            this.Z2.Text = "Zone2";
            // 
            // Z3
            // 
            this.Z3.AutoSize = true;
            this.Z3.BackColor = System.Drawing.Color.Green;
            this.Z3.Location = new System.Drawing.Point(83, 107);
            this.Z3.Name = "Z3";
            this.Z3.Size = new System.Drawing.Size(55, 20);
            this.Z3.TabIndex = 2;
            this.Z3.Text = "Zone3";
            // 
            // Z4
            // 
            this.Z4.AutoSize = true;
            this.Z4.BackColor = System.Drawing.Color.Green;
            this.Z4.Location = new System.Drawing.Point(172, 107);
            this.Z4.Name = "Z4";
            this.Z4.Size = new System.Drawing.Size(55, 20);
            this.Z4.TabIndex = 3;
            this.Z4.Text = "Zone4";
            // 
            // LblO
            // 
            this.LblO.AutoSize = true;
            this.LblO.BackColor = System.Drawing.Color.Gainsboro;
            this.LblO.Location = new System.Drawing.Point(134, 154);
            this.LblO.Name = "LblO";
            this.LblO.Size = new System.Drawing.Size(68, 20);
            this.LblO.TabIndex = 4;
            this.LblO.Text = "ON/OFF";
            this.LblO.Click += new System.EventHandler(this.LblO_Click);
            // 
            // Activate
            // 
            this.Activate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Activate.Location = new System.Drawing.Point(326, 47);
            this.Activate.Name = "Activate";
            this.Activate.Size = new System.Drawing.Size(95, 36);
            this.Activate.TabIndex = 5;
            this.Activate.Text = "Activate";
            this.Activate.UseVisualStyleBackColor = false;
            this.Activate.Click += new System.EventHandler(this.Activate_Click);
            // 
            // Deact
            // 
            this.Deact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Deact.Location = new System.Drawing.Point(326, 107);
            this.Deact.Name = "Deact";
            this.Deact.Size = new System.Drawing.Size(95, 30);
            this.Deact.TabIndex = 6;
            this.Deact.Text = "Deactivate";
            this.Deact.UseVisualStyleBackColor = false;
            this.Deact.Click += new System.EventHandler(this.Deact_Click);
            // 
            // rest
            // 
            this.rest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rest.Location = new System.Drawing.Point(336, 154);
            this.rest.Name = "rest";
            this.rest.Size = new System.Drawing.Size(75, 34);
            this.rest.TabIndex = 7;
            this.rest.Text = "Reset";
            this.rest.UseVisualStyleBackColor = false;
            this.rest.Click += new System.EventHandler(this.rest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rest);
            this.Controls.Add(this.Deact);
            this.Controls.Add(this.Activate);
            this.Controls.Add(this.LblO);
            this.Controls.Add(this.Z4);
            this.Controls.Add(this.Z3);
            this.Controls.Add(this.Z2);
            this.Controls.Add(this.Z1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Z1;
        private System.Windows.Forms.Label Z2;
        private System.Windows.Forms.Label Z3;
        private System.Windows.Forms.Label Z4;
        private System.Windows.Forms.Label LblO;
        private System.Windows.Forms.Button Activate;
        private System.Windows.Forms.Button Deact;
        private System.Windows.Forms.Button rest;
    }
}

