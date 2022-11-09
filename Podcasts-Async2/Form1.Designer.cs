
namespace Podcasts_Async2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtBoxURL = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.cbFrequency = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listViewPodcasts = new System.Windows.Forms.ListView();
            this.clmnEpisode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnFrequency = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listBoxEpisodes = new System.Windows.Forms.ListBox();
            this.lblEpisode = new System.Windows.Forms.Label();
            this.txtBoxCat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRemoveCat = new System.Windows.Forms.Button();
            this.btnSaveCat = new System.Windows.Forms.Button();
            this.btnCreateCat = new System.Windows.Forms.Button();
            this.listBoxCat = new System.Windows.Forms.ListBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.webBrowserEpisodes = new System.Windows.Forms.WebBrowser();
            this.btnSortBy = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxURL
            // 
            this.txtBoxURL.Location = new System.Drawing.Point(10, 33);
            this.txtBoxURL.Name = "txtBoxURL";
            this.txtBoxURL.Size = new System.Drawing.Size(236, 20);
            this.txtBoxURL.TabIndex = 0;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(10, 97);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // cbFrequency
            // 
            this.cbFrequency.FormattingEnabled = true;
            this.cbFrequency.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30"});
            this.cbFrequency.Location = new System.Drawing.Point(10, 72);
            this.cbFrequency.Name = "cbFrequency";
            this.cbFrequency.Size = new System.Drawing.Size(120, 21);
            this.cbFrequency.TabIndex = 2;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(135, 72);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(112, 21);
            this.cbCategory.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(91, 97);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(171, 97);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "URL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Update frequency:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(135, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Category:";
            // 
            // listViewPodcasts
            // 
            this.listViewPodcasts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmnEpisode,
            this.clmnName,
            this.clmnFrequency,
            this.clmnCategory});
            this.listViewPodcasts.FullRowSelect = true;
            this.listViewPodcasts.HideSelection = false;
            this.listViewPodcasts.Location = new System.Drawing.Point(10, 139);
            this.listViewPodcasts.Margin = new System.Windows.Forms.Padding(2);
            this.listViewPodcasts.Name = "listViewPodcasts";
            this.listViewPodcasts.Size = new System.Drawing.Size(478, 162);
            this.listViewPodcasts.TabIndex = 9;
            this.listViewPodcasts.UseCompatibleStateImageBehavior = false;
            this.listViewPodcasts.View = System.Windows.Forms.View.Details;
            this.listViewPodcasts.SelectedIndexChanged += new System.EventHandler(this.listViewPodcasts_SelectedIndexChanged);
            // 
            // clmnEpisode
            // 
            this.clmnEpisode.Text = "Episodes";
            this.clmnEpisode.Width = 76;
            // 
            // clmnName
            // 
            this.clmnName.Text = "Name";
            this.clmnName.Width = 194;
            // 
            // clmnFrequency
            // 
            this.clmnFrequency.Text = "Frequeny";
            this.clmnFrequency.Width = 85;
            // 
            // clmnCategory
            // 
            this.clmnCategory.Text = "Category";
            this.clmnCategory.Width = 98;
            // 
            // listBoxEpisodes
            // 
            this.listBoxEpisodes.FormattingEnabled = true;
            this.listBoxEpisodes.Location = new System.Drawing.Point(11, 342);
            this.listBoxEpisodes.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxEpisodes.Name = "listBoxEpisodes";
            this.listBoxEpisodes.Size = new System.Drawing.Size(318, 173);
            this.listBoxEpisodes.TabIndex = 10;
            this.listBoxEpisodes.SelectedIndexChanged += new System.EventHandler(this.listBoxEpisodes_SelectedIndexChanged_1);
            // 
            // lblEpisode
            // 
            this.lblEpisode.AutoSize = true;
            this.lblEpisode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEpisode.Location = new System.Drawing.Point(11, 326);
            this.lblEpisode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEpisode.Name = "lblEpisode";
            this.lblEpisode.Size = new System.Drawing.Size(79, 13);
            this.lblEpisode.TabIndex = 11;
            this.lblEpisode.Text = "All episodes:";
            // 
            // txtBoxCat
            // 
            this.txtBoxCat.Location = new System.Drawing.Point(600, 73);
            this.txtBoxCat.Name = "txtBoxCat";
            this.txtBoxCat.Size = new System.Drawing.Size(236, 20);
            this.txtBoxCat.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(598, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Write new category:";
            // 
            // btnRemoveCat
            // 
            this.btnRemoveCat.Location = new System.Drawing.Point(761, 97);
            this.btnRemoveCat.Name = "btnRemoveCat";
            this.btnRemoveCat.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveCat.TabIndex = 16;
            this.btnRemoveCat.Text = "Remove";
            this.btnRemoveCat.UseVisualStyleBackColor = true;
            this.btnRemoveCat.Click += new System.EventHandler(this.btnRemoveCat_Click);
            // 
            // btnSaveCat
            // 
            this.btnSaveCat.Location = new System.Drawing.Point(682, 97);
            this.btnSaveCat.Name = "btnSaveCat";
            this.btnSaveCat.Size = new System.Drawing.Size(75, 23);
            this.btnSaveCat.TabIndex = 15;
            this.btnSaveCat.Text = "Save";
            this.btnSaveCat.UseVisualStyleBackColor = true;
            this.btnSaveCat.Click += new System.EventHandler(this.btnSaveCat_Click);
            // 
            // btnCreateCat
            // 
            this.btnCreateCat.Location = new System.Drawing.Point(601, 97);
            this.btnCreateCat.Name = "btnCreateCat";
            this.btnCreateCat.Size = new System.Drawing.Size(75, 23);
            this.btnCreateCat.TabIndex = 14;
            this.btnCreateCat.Text = "Create";
            this.btnCreateCat.UseVisualStyleBackColor = true;
            this.btnCreateCat.Click += new System.EventHandler(this.btnCreateCat_Click);
            // 
            // listBoxCat
            // 
            this.listBoxCat.FormattingEnabled = true;
            this.listBoxCat.Location = new System.Drawing.Point(600, 139);
            this.listBoxCat.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxCat.Name = "listBoxCat";
            this.listBoxCat.Size = new System.Drawing.Size(348, 147);
            this.listBoxCat.TabIndex = 17;
            this.listBoxCat.SelectedIndexChanged += new System.EventHandler(this.listBoxCat_SelectedIndexChanged);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(597, 326);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(122, 13);
            this.lblDescription.TabIndex = 19;
            this.lblDescription.Text = "Episode description:";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(252, 33);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.ReadOnly = true;
            this.txtBoxName.Size = new System.Drawing.Size(236, 20);
            this.txtBoxName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(249, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Name:";
            // 
            // webBrowserEpisodes
            // 
            this.webBrowserEpisodes.Location = new System.Drawing.Point(600, 342);
            this.webBrowserEpisodes.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserEpisodes.Name = "webBrowserEpisodes";
            this.webBrowserEpisodes.Size = new System.Drawing.Size(348, 173);
            this.webBrowserEpisodes.TabIndex = 20;
            // 
            // btnSortBy
            // 
            this.btnSortBy.Location = new System.Drawing.Point(873, 52);
            this.btnSortBy.Name = "btnSortBy";
            this.btnSortBy.Size = new System.Drawing.Size(75, 38);
            this.btnSortBy.TabIndex = 21;
            this.btnSortBy.Text = "Sort By Category";
            this.btnSortBy.UseVisualStyleBackColor = true;
            this.btnSortBy.Click += new System.EventHandler(this.btnSortBy_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(873, 96);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(75, 38);
            this.btnShowAll.TabIndex = 22;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(978, 582);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnSortBy);
            this.Controls.Add(this.webBrowserEpisodes);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.listBoxCat);
            this.Controls.Add(this.btnRemoveCat);
            this.Controls.Add(this.btnSaveCat);
            this.Controls.Add(this.btnCreateCat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxCat);
            this.Controls.Add(this.lblEpisode);
            this.Controls.Add(this.listBoxEpisodes);
            this.Controls.Add(this.listViewPodcasts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.cbFrequency);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.txtBoxURL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Podcasts";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxURL;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ComboBox cbFrequency;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listViewPodcasts;
        private System.Windows.Forms.ColumnHeader clmnEpisode;
        private System.Windows.Forms.ColumnHeader clmnName;
        private System.Windows.Forms.ColumnHeader clmnFrequency;
        private System.Windows.Forms.ColumnHeader clmnCategory;
        private System.Windows.Forms.ListBox listBoxEpisodes;
        private System.Windows.Forms.Label lblEpisode;
        private System.Windows.Forms.TextBox txtBoxCat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRemoveCat;
        private System.Windows.Forms.Button btnSaveCat;
        private System.Windows.Forms.Button btnCreateCat;
        private System.Windows.Forms.ListBox listBoxCat;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.WebBrowser webBrowserEpisodes;
        private System.Windows.Forms.Button btnSortBy;
        private System.Windows.Forms.Button btnShowAll;
    }
}

