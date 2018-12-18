namespace App
{
    partial class Connexion
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
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxMDP = new System.Windows.Forms.TextBox();
            this.labelConnexion = new System.Windows.Forms.Label();
            this.labelErreur = new System.Windows.Forms.Label();
            this.buttonConnexion = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.labelMDP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(83, 195);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(242, 20);
            this.textBoxID.TabIndex = 0;
            // 
            // textBoxMDP
            // 
            this.textBoxMDP.Location = new System.Drawing.Point(83, 233);
            this.textBoxMDP.Name = "textBoxMDP";
            this.textBoxMDP.Size = new System.Drawing.Size(242, 20);
            this.textBoxMDP.TabIndex = 1;
            this.textBoxMDP.UseSystemPasswordChar = true;
            this.textBoxMDP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMDP_KeyPress);
            // 
            // labelConnexion
            // 
            this.labelConnexion.AutoSize = true;
            this.labelConnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConnexion.Location = new System.Drawing.Point(128, 97);
            this.labelConnexion.Name = "labelConnexion";
            this.labelConnexion.Size = new System.Drawing.Size(152, 31);
            this.labelConnexion.TabIndex = 2;
            this.labelConnexion.Text = "Connexion";
            // 
            // labelErreur
            // 
            this.labelErreur.AutoSize = true;
            this.labelErreur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErreur.ForeColor = System.Drawing.Color.Red;
            this.labelErreur.Location = new System.Drawing.Point(113, 354);
            this.labelErreur.Name = "labelErreur";
            this.labelErreur.Size = new System.Drawing.Size(183, 13);
            this.labelErreur.TabIndex = 3;
            this.labelErreur.Text = "Wallah t\'as cru pouvoir me test";
            this.labelErreur.Visible = false;
            // 
            // buttonConnexion
            // 
            this.buttonConnexion.Location = new System.Drawing.Point(130, 281);
            this.buttonConnexion.Name = "buttonConnexion";
            this.buttonConnexion.Size = new System.Drawing.Size(149, 23);
            this.buttonConnexion.TabIndex = 4;
            this.buttonConnexion.Text = "Se connecter";
            this.buttonConnexion.UseVisualStyleBackColor = true;
            this.buttonConnexion.Click += new System.EventHandler(this.buttonConnexion_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(13, 198);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(59, 13);
            this.labelID.TabIndex = 5;
            this.labelID.Text = "Utilisateur: ";
            // 
            // labelMDP
            // 
            this.labelMDP.AutoSize = true;
            this.labelMDP.Location = new System.Drawing.Point(13, 236);
            this.labelMDP.Name = "labelMDP";
            this.labelMDP.Size = new System.Drawing.Size(35, 13);
            this.labelMDP.TabIndex = 6;
            this.labelMDP.Text = "MdP: ";
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 520);
            this.Controls.Add(this.labelMDP);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.buttonConnexion);
            this.Controls.Add(this.labelErreur);
            this.Controls.Add(this.labelConnexion);
            this.Controls.Add(this.textBoxMDP);
            this.Controls.Add(this.textBoxID);
            this.Name = "Connexion";
            this.Text = "Connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxMDP;
        private System.Windows.Forms.Label labelConnexion;
        private System.Windows.Forms.Label labelErreur;
        private System.Windows.Forms.Button buttonConnexion;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelMDP;
    }
}