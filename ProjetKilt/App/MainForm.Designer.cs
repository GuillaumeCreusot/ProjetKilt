namespace App
{
    partial class MainForm
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
            this.listBoxCourses = new System.Windows.Forms.ListBox();
            this.dataGridViewCoureurs = new System.Windows.Forms.DataGridView();
            this.Classement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prénom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dossard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VitesseMoyenne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllureMoyenne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LicenceFFA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonImportParti = new System.Windows.Forms.Button();
            this.buttonImportResultats = new System.Windows.Forms.Button();
            this.buttonIdentification = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.comboBoxFilters = new System.Windows.Forms.ComboBox();
            this.labelConnexion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoureurs)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxCourses
            // 
            this.listBoxCourses.FormattingEnabled = true;
            this.listBoxCourses.Location = new System.Drawing.Point(13, 13);
            this.listBoxCourses.Name = "listBoxCourses";
            this.listBoxCourses.Size = new System.Drawing.Size(144, 602);
            this.listBoxCourses.TabIndex = 0;
            this.listBoxCourses.SelectedIndexChanged += new System.EventHandler(this.listBoxCourses_SelectedIndexChanged);
            // 
            // dataGridViewCoureurs
            // 
            this.dataGridViewCoureurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCoureurs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Classement,
            this.Nom,
            this.Prénom,
            this.Dossard,
            this.VitesseMoyenne,
            this.AllureMoyenne,
            this.Age,
            this.Sexe,
            this.Mail,
            this.LicenceFFA});
            this.dataGridViewCoureurs.Location = new System.Drawing.Point(163, 139);
            this.dataGridViewCoureurs.Name = "dataGridViewCoureurs";
            this.dataGridViewCoureurs.ReadOnly = true;
            this.dataGridViewCoureurs.Size = new System.Drawing.Size(1044, 331);
            this.dataGridViewCoureurs.TabIndex = 1;
            // 
            // Classement
            // 
            this.Classement.HeaderText = "Classement";
            this.Classement.Name = "Classement";
            this.Classement.ReadOnly = true;
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // Prénom
            // 
            this.Prénom.HeaderText = "Prénom";
            this.Prénom.Name = "Prénom";
            this.Prénom.ReadOnly = true;
            // 
            // Dossard
            // 
            this.Dossard.HeaderText = "Dossard";
            this.Dossard.Name = "Dossard";
            this.Dossard.ReadOnly = true;
            // 
            // VitesseMoyenne
            // 
            this.VitesseMoyenne.HeaderText = "Vitesse Moyenne";
            this.VitesseMoyenne.Name = "VitesseMoyenne";
            this.VitesseMoyenne.ReadOnly = true;
            // 
            // AllureMoyenne
            // 
            this.AllureMoyenne.HeaderText = "Allure Moyenne";
            this.AllureMoyenne.Name = "AllureMoyenne";
            this.AllureMoyenne.ReadOnly = true;
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            // 
            // Sexe
            // 
            this.Sexe.HeaderText = "Sexe";
            this.Sexe.Name = "Sexe";
            this.Sexe.ReadOnly = true;
            // 
            // Mail
            // 
            this.Mail.HeaderText = "Mail";
            this.Mail.Name = "Mail";
            this.Mail.ReadOnly = true;
            // 
            // LicenceFFA
            // 
            this.LicenceFFA.HeaderText = "LicenceFFA";
            this.LicenceFFA.Name = "LicenceFFA";
            this.LicenceFFA.ReadOnly = true;
            // 
            // buttonImportParti
            // 
            this.buttonImportParti.Location = new System.Drawing.Point(163, 541);
            this.buttonImportParti.Name = "buttonImportParti";
            this.buttonImportParti.Size = new System.Drawing.Size(133, 23);
            this.buttonImportParti.TabIndex = 2;
            this.buttonImportParti.Text = "Importer Participants";
            this.buttonImportParti.UseVisualStyleBackColor = true;
            this.buttonImportParti.Click += new System.EventHandler(this.buttonImportParti_Click);
            // 
            // buttonImportResultats
            // 
            this.buttonImportResultats.Location = new System.Drawing.Point(404, 541);
            this.buttonImportResultats.Name = "buttonImportResultats";
            this.buttonImportResultats.Size = new System.Drawing.Size(133, 23);
            this.buttonImportResultats.TabIndex = 3;
            this.buttonImportResultats.Text = "Importer Résultats";
            this.buttonImportResultats.UseVisualStyleBackColor = true;
            this.buttonImportResultats.Click += new System.EventHandler(this.buttonImportResultats_Click);
            // 
            // buttonIdentification
            // 
            this.buttonIdentification.Location = new System.Drawing.Point(1074, 13);
            this.buttonIdentification.Name = "buttonIdentification";
            this.buttonIdentification.Size = new System.Drawing.Size(133, 23);
            this.buttonIdentification.TabIndex = 4;
            this.buttonIdentification.Text = "S\'identifier";
            this.buttonIdentification.UseVisualStyleBackColor = true;
            this.buttonIdentification.Click += new System.EventHandler(this.buttonIdentification_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(163, 113);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(112, 20);
            this.textBoxSearch.TabIndex = 6;
            this.textBoxSearch.Text = "Rechercher...";
            this.textBoxSearch.Click += new System.EventHandler(this.textBoxSearch_Click);
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            this.textBoxSearch.Leave += new System.EventHandler(this.textBoxSearch_FocusChanged);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(585, 541);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(622, 23);
            this.progressBar.TabIndex = 7;
            // 
            // comboBoxFilters
            // 
            this.comboBoxFilters.FormattingEnabled = true;
            this.comboBoxFilters.Location = new System.Drawing.Point(1086, 113);
            this.comboBoxFilters.Name = "comboBoxFilters";
            this.comboBoxFilters.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFilters.TabIndex = 9;
            this.comboBoxFilters.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilters_SelectedIndexChanged);
            this.comboBoxFilters.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxFilters_KeyPress);
            // 
            // labelConnexion
            // 
            this.labelConnexion.AutoSize = true;
            this.labelConnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConnexion.Location = new System.Drawing.Point(163, 13);
            this.labelConnexion.Name = "labelConnexion";
            this.labelConnexion.Size = new System.Drawing.Size(0, 24);
            this.labelConnexion.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 623);
            this.Controls.Add(this.labelConnexion);
            this.Controls.Add(this.comboBoxFilters);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonIdentification);
            this.Controls.Add(this.buttonImportResultats);
            this.Controls.Add(this.buttonImportParti);
            this.Controls.Add(this.dataGridViewCoureurs);
            this.Controls.Add(this.listBoxCourses);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoureurs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCourses;
        private System.Windows.Forms.DataGridView dataGridViewCoureurs;
        private System.Windows.Forms.Button buttonImportParti;
        private System.Windows.Forms.Button buttonImportResultats;
        private System.Windows.Forms.Button buttonIdentification;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ComboBox comboBoxFilters;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classement;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prénom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dossard;
        private System.Windows.Forms.DataGridViewTextBoxColumn VitesseMoyenne;
        private System.Windows.Forms.DataGridViewTextBoxColumn AllureMoyenne;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn LicenceFFA;
        private System.Windows.Forms.Label labelConnexion;
    }
}

