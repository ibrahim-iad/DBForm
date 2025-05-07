namespace DBForm
{
    partial class Form6
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
            this.txtLongueur = new System.Windows.Forms.TextBox();
            this.txtLargeur = new System.Windows.Forms.TextBox();
            this.txtPerimetre = new System.Windows.Forms.TextBox();
            this.txtSurface = new System.Windows.Forms.TextBox();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Longueur:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Largeur:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Perimetre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Surface:";
            // 
            // txtLongueur
            // 
            this.txtLongueur.Location = new System.Drawing.Point(89, 28);
            this.txtLongueur.Name = "txtLongueur";
            this.txtLongueur.Size = new System.Drawing.Size(100, 20);
            this.txtLongueur.TabIndex = 4;
            // 
            // txtLargeur
            // 
            this.txtLargeur.Location = new System.Drawing.Point(89, 67);
            this.txtLargeur.Name = "txtLargeur";
            this.txtLargeur.Size = new System.Drawing.Size(100, 20);
            this.txtLargeur.TabIndex = 5;
            // 
            // txtPerimetre
            // 
            this.txtPerimetre.Location = new System.Drawing.Point(89, 120);
            this.txtPerimetre.Name = "txtPerimetre";
            this.txtPerimetre.Size = new System.Drawing.Size(100, 20);
            this.txtPerimetre.TabIndex = 6;
            // 
            // txtSurface
            // 
            this.txtSurface.Location = new System.Drawing.Point(89, 163);
            this.txtSurface.Name = "txtSurface";
            this.txtSurface.Size = new System.Drawing.Size(100, 20);
            this.txtSurface.TabIndex = 7;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(89, 209);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(100, 23);
            this.btnEnregistrer.TabIndex = 8;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 272);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.txtSurface);
            this.Controls.Add(this.txtPerimetre);
            this.Controls.Add(this.txtLargeur);
            this.Controls.Add(this.txtLongueur);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLongueur;
        private System.Windows.Forms.TextBox txtLargeur;
        private System.Windows.Forms.TextBox txtPerimetre;
        private System.Windows.Forms.TextBox txtSurface;
        private System.Windows.Forms.Button btnEnregistrer;
    }
}