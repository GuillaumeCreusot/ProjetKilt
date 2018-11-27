namespace App
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
            this.listBoxCourses = new System.Windows.Forms.ListBox();
            this.dataGridViewCoureurs = new System.Windows.Forms.DataGridView();
            this.buttonImport = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonIdentification = new System.Windows.Forms.Button();
            this.panelInfos = new System.Windows.Forms.Panel();
            this.labelLicence = new System.Windows.Forms.Label();
            this.labelMail = new System.Windows.Forms.Label();
            this.labelSexe = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelAllure = new System.Windows.Forms.Label();
            this.labelVitesse = new System.Windows.Forms.Label();
            this.labelClassement = new System.Windows.Forms.Label();
            this.labelDossard = new System.Windows.Forms.Label();
            this.labelPrénom = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelInfosCoureur = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.comboBoxFilters = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoureurs)).BeginInit();
            this.panelInfos.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxCourses
            // 
            this.listBoxCourses.FormattingEnabled = true;
            this.listBoxCourses.Location = new System.Drawing.Point(13, 13);
            this.listBoxCourses.Name = "listBoxCourses";
            this.listBoxCourses.Size = new System.Drawing.Size(144, 602);
            this.listBoxCourses.TabIndex = 0;
            // 
            // dataGridViewCoureurs
            // 
            this.dataGridViewCoureurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCoureurs.Location = new System.Drawing.Point(181, 139);
            this.dataGridViewCoureurs.Name = "dataGridViewCoureurs";
            this.dataGridViewCoureurs.Size = new System.Drawing.Size(554, 331);
            this.dataGridViewCoureurs.TabIndex = 1;
            // 
            // buttonImport
            // 
            this.buttonImport.Location = new System.Drawing.Point(181, 541);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(133, 23);
            this.buttonImport.TabIndex = 2;
            this.buttonImport.Text = "Importer Coureurs";
            this.buttonImport.UseVisualStyleBackColor = true;
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(602, 541);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(133, 23);
            this.buttonExport.TabIndex = 3;
            this.buttonExport.Text = "Exporter Coureurs";
            this.buttonExport.UseVisualStyleBackColor = true;
            // 
            // buttonIdentification
            // 
            this.buttonIdentification.Location = new System.Drawing.Point(1074, 13);
            this.buttonIdentification.Name = "buttonIdentification";
            this.buttonIdentification.Size = new System.Drawing.Size(133, 23);
            this.buttonIdentification.TabIndex = 4;
            this.buttonIdentification.Text = "S\'identifier";
            this.buttonIdentification.UseVisualStyleBackColor = true;
            // 
            // panelInfos
            // 
            this.panelInfos.Controls.Add(this.labelLicence);
            this.panelInfos.Controls.Add(this.labelMail);
            this.panelInfos.Controls.Add(this.labelSexe);
            this.panelInfos.Controls.Add(this.labelAge);
            this.panelInfos.Controls.Add(this.labelAllure);
            this.panelInfos.Controls.Add(this.labelVitesse);
            this.panelInfos.Controls.Add(this.labelClassement);
            this.panelInfos.Controls.Add(this.labelDossard);
            this.panelInfos.Controls.Add(this.labelPrénom);
            this.panelInfos.Controls.Add(this.labelNom);
            this.panelInfos.Controls.Add(this.labelInfosCoureur);
            this.panelInfos.Location = new System.Drawing.Point(741, 139);
            this.panelInfos.Name = "panelInfos";
            this.panelInfos.Size = new System.Drawing.Size(466, 331);
            this.panelInfos.TabIndex = 5;
            // 
            // labelLicence
            // 
            this.labelLicence.AutoSize = true;
            this.labelLicence.Location = new System.Drawing.Point(241, 161);
            this.labelLicence.Name = "labelLicence";
            this.labelLicence.Size = new System.Drawing.Size(51, 13);
            this.labelLicence.TabIndex = 10;
            this.labelLicence.Text = "Licence :";
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(17, 161);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(32, 13);
            this.labelMail.TabIndex = 9;
            this.labelMail.Text = "Mail :";
            // 
            // labelSexe
            // 
            this.labelSexe.AutoSize = true;
            this.labelSexe.Location = new System.Drawing.Point(359, 60);
            this.labelSexe.Name = "labelSexe";
            this.labelSexe.Size = new System.Drawing.Size(37, 13);
            this.labelSexe.TabIndex = 8;
            this.labelSexe.Text = "Sexe :";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(14, 111);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(32, 13);
            this.labelAge.TabIndex = 7;
            this.labelAge.Text = "Age :";
            // 
            // labelAllure
            // 
            this.labelAllure.AutoSize = true;
            this.labelAllure.Location = new System.Drawing.Point(166, 288);
            this.labelAllure.Name = "labelAllure";
            this.labelAllure.Size = new System.Drawing.Size(64, 13);
            this.labelAllure.TabIndex = 6;
            this.labelAllure.Text = "Allure moy : ";
            // 
            // labelVitesse
            // 
            this.labelVitesse.AutoSize = true;
            this.labelVitesse.Location = new System.Drawing.Point(14, 288);
            this.labelVitesse.Name = "labelVitesse";
            this.labelVitesse.Size = new System.Drawing.Size(72, 13);
            this.labelVitesse.TabIndex = 5;
            this.labelVitesse.Text = "Vitesse moy : ";
            // 
            // labelClassement
            // 
            this.labelClassement.AutoSize = true;
            this.labelClassement.Location = new System.Drawing.Point(14, 243);
            this.labelClassement.Name = "labelClassement";
            this.labelClassement.Size = new System.Drawing.Size(67, 13);
            this.labelClassement.TabIndex = 4;
            this.labelClassement.Text = "Classement :";
            // 
            // labelDossard
            // 
            this.labelDossard.AutoSize = true;
            this.labelDossard.Location = new System.Drawing.Point(166, 243);
            this.labelDossard.Name = "labelDossard";
            this.labelDossard.Size = new System.Drawing.Size(52, 13);
            this.labelDossard.TabIndex = 3;
            this.labelDossard.Text = "Dossard :";
            // 
            // labelPrénom
            // 
            this.labelPrénom.AutoSize = true;
            this.labelPrénom.Location = new System.Drawing.Point(166, 60);
            this.labelPrénom.Name = "labelPrénom";
            this.labelPrénom.Size = new System.Drawing.Size(49, 13);
            this.labelPrénom.TabIndex = 2;
            this.labelPrénom.Text = "Prénom :";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(14, 60);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(35, 13);
            this.labelNom.TabIndex = 1;
            this.labelNom.Text = "Nom :";
            // 
            // labelInfosCoureur
            // 
            this.labelInfosCoureur.AutoSize = true;
            this.labelInfosCoureur.Location = new System.Drawing.Point(209, 10);
            this.labelInfosCoureur.Name = "labelInfosCoureur";
            this.labelInfosCoureur.Size = new System.Drawing.Size(64, 13);
            this.labelInfosCoureur.TabIndex = 0;
            this.labelInfosCoureur.Text = "Informations";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(181, 113);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(112, 20);
            this.textBoxSearch.TabIndex = 6;
            this.textBoxSearch.Text = "Rechercher...";
            this.textBoxSearch.Click += new System.EventHandler(this.textBoxSearch_FocusChanged);
            this.textBoxSearch.Leave += new System.EventHandler(this.textBoxSearch_FocusChanged);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(741, 541);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(466, 23);
            this.progressBar.TabIndex = 7;
            // 
            // comboBoxFilters
            // 
            this.comboBoxFilters.FormattingEnabled = true;
            this.comboBoxFilters.Location = new System.Drawing.Point(614, 113);
            this.comboBoxFilters.Name = "comboBoxFilters";
            this.comboBoxFilters.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFilters.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 623);
            this.Controls.Add(this.comboBoxFilters);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.panelInfos);
            this.Controls.Add(this.buttonIdentification);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.buttonImport);
            this.Controls.Add(this.dataGridViewCoureurs);
            this.Controls.Add(this.listBoxCourses);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoureurs)).EndInit();
            this.panelInfos.ResumeLayout(false);
            this.panelInfos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCourses;
        private System.Windows.Forms.DataGridView dataGridViewCoureurs;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Button buttonIdentification;
        private System.Windows.Forms.Panel panelInfos;
        private System.Windows.Forms.Label labelInfosCoureur;
        private System.Windows.Forms.Label labelAllure;
        private System.Windows.Forms.Label labelVitesse;
        private System.Windows.Forms.Label labelClassement;
        private System.Windows.Forms.Label labelDossard;
        private System.Windows.Forms.Label labelPrénom;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelLicence;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Label labelSexe;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ComboBox comboBoxFilters;
    }
}

