namespace HeatCodes
{
    partial class StartFrame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartFrame));
            this.drawingCB = new System.Windows.Forms.ComboBox();
            this.revisionCB = new System.Windows.Forms.ComboBox();
            this.drawingLabel = new System.Windows.Forms.Label();
            this.revisionLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.miscLabel = new System.Windows.Forms.Label();
            this.miscText = new System.Windows.Forms.TextBox();
            this.laserLbl = new System.Windows.Forms.Label();
            this.laserCB = new System.Windows.Forms.ComboBox();
            this.drawingPreview = new System.Windows.Forms.WebBrowser();
            this.browseDrawing = new System.Windows.Forms.Button();
            this.browseLaser = new System.Windows.Forms.Button();
            this.laserPreview = new System.Windows.Forms.DataGridView();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laserPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // drawingCB
            // 
            this.drawingCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drawingCB.FormattingEnabled = true;
            this.drawingCB.Location = new System.Drawing.Point(98, 21);
            this.drawingCB.Margin = new System.Windows.Forms.Padding(2);
            this.drawingCB.Name = "drawingCB";
            this.drawingCB.Size = new System.Drawing.Size(146, 21);
            this.drawingCB.TabIndex = 1;
            this.drawingCB.SelectedIndexChanged += new System.EventHandler(this.DrawingListListener);
            // 
            // revisionCB
            // 
            this.revisionCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.revisionCB.FormattingEnabled = true;
            this.revisionCB.Location = new System.Drawing.Point(98, 65);
            this.revisionCB.Margin = new System.Windows.Forms.Padding(2);
            this.revisionCB.Name = "revisionCB";
            this.revisionCB.Size = new System.Drawing.Size(146, 21);
            this.revisionCB.TabIndex = 2;
            this.revisionCB.SelectedIndexChanged += new System.EventHandler(this.RevisionListListener);
            // 
            // drawingLabel
            // 
            this.drawingLabel.AutoSize = true;
            this.drawingLabel.Location = new System.Drawing.Point(17, 21);
            this.drawingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.drawingLabel.Name = "drawingLabel";
            this.drawingLabel.Size = new System.Drawing.Size(40, 13);
            this.drawingLabel.TabIndex = 3;
            this.drawingLabel.Text = "Ritning";
            // 
            // revisionLabel
            // 
            this.revisionLabel.AutoSize = true;
            this.revisionLabel.Location = new System.Drawing.Point(17, 68);
            this.revisionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.revisionLabel.Name = "revisionLabel";
            this.revisionLabel.Size = new System.Drawing.Size(48, 13);
            this.revisionLabel.TabIndex = 4;
            this.revisionLabel.Text = "Revision";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1103, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // miscLabel
            // 
            this.miscLabel.AutoSize = true;
            this.miscLabel.Location = new System.Drawing.Point(711, 64);
            this.miscLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.miscLabel.Name = "miscLabel";
            this.miscLabel.Size = new System.Drawing.Size(35, 13);
            this.miscLabel.TabIndex = 6;
            this.miscLabel.Text = "Övrigt";
            // 
            // miscText
            // 
            this.miscText.Location = new System.Drawing.Point(777, 61);
            this.miscText.Margin = new System.Windows.Forms.Padding(2);
            this.miscText.Name = "miscText";
            this.miscText.Size = new System.Drawing.Size(146, 20);
            this.miscText.TabIndex = 7;
            // 
            // laserLbl
            // 
            this.laserLbl.AutoSize = true;
            this.laserLbl.Location = new System.Drawing.Point(711, 20);
            this.laserLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laserLbl.Name = "laserLbl";
            this.laserLbl.Size = new System.Drawing.Size(33, 13);
            this.laserLbl.TabIndex = 11;
            this.laserLbl.Text = "Laser";
            // 
            // laserCB
            // 
            this.laserCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.laserCB.FormattingEnabled = true;
            this.laserCB.Location = new System.Drawing.Point(777, 17);
            this.laserCB.Margin = new System.Windows.Forms.Padding(2);
            this.laserCB.Name = "laserCB";
            this.laserCB.Size = new System.Drawing.Size(146, 21);
            this.laserCB.TabIndex = 10;
            this.laserCB.SelectedIndexChanged += new System.EventHandler(this.LaserListlistener);
            // 
            // drawingPreview
            // 
            this.drawingPreview.Location = new System.Drawing.Point(11, 103);
            this.drawingPreview.Margin = new System.Windows.Forms.Padding(2);
            this.drawingPreview.MinimumSize = new System.Drawing.Size(15, 16);
            this.drawingPreview.Name = "drawingPreview";
            this.drawingPreview.Size = new System.Drawing.Size(663, 497);
            this.drawingPreview.TabIndex = 12;
            // 
            // browseDrawing
            // 
            this.browseDrawing.Location = new System.Drawing.Point(247, 22);
            this.browseDrawing.Margin = new System.Windows.Forms.Padding(2);
            this.browseDrawing.Name = "browseDrawing";
            this.browseDrawing.Size = new System.Drawing.Size(21, 19);
            this.browseDrawing.TabIndex = 13;
            this.browseDrawing.Text = "...";
            this.browseDrawing.UseVisualStyleBackColor = true;
            this.browseDrawing.Click += new System.EventHandler(this.BrowseForDrawing);
            // 
            // browseLaser
            // 
            this.browseLaser.Location = new System.Drawing.Point(926, 19);
            this.browseLaser.Margin = new System.Windows.Forms.Padding(2);
            this.browseLaser.Name = "browseLaser";
            this.browseLaser.Size = new System.Drawing.Size(21, 19);
            this.browseLaser.TabIndex = 16;
            this.browseLaser.Text = "...";
            this.browseLaser.UseVisualStyleBackColor = true;
            this.browseLaser.Click += new System.EventHandler(this.BrowseForLaser);
            // 
            // laserPreview
            // 
            this.laserPreview.AllowUserToAddRows = false;
            this.laserPreview.AllowUserToDeleteRows = false;
            this.laserPreview.BackgroundColor = System.Drawing.SystemColors.Window;
            this.laserPreview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.laserPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.laserPreview.Location = new System.Drawing.Point(714, 103);
            this.laserPreview.MultiSelect = false;
            this.laserPreview.Name = "laserPreview";
            this.laserPreview.ReadOnly = true;
            this.laserPreview.Size = new System.Drawing.Size(623, 508);
            this.laserPreview.TabIndex = 17;
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem2,
            this.menuItem3});
            this.menuItem1.Text = "File";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 0;
            this.menuItem2.Text = "Connect";
            this.menuItem2.Click += new System.EventHandler(this.ConnectMenuListener);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 1;
            this.menuItem3.Text = "Print";
            this.menuItem3.Click += new System.EventHandler(this.PrintMenuListener);
            // 
            // StartFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1363, 623);
            this.Controls.Add(this.laserPreview);
            this.Controls.Add(this.browseLaser);
            this.Controls.Add(this.browseDrawing);
            this.Controls.Add(this.drawingPreview);
            this.Controls.Add(this.laserLbl);
            this.Controls.Add(this.laserCB);
            this.Controls.Add(this.miscText);
            this.Controls.Add(this.miscLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.revisionLabel);
            this.Controls.Add(this.drawingLabel);
            this.Controls.Add(this.revisionCB);
            this.Controls.Add(this.drawingCB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Menu = this.mainMenu1;
            this.Name = "StartFrame";
            this.Text = "HeatCodes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laserPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox drawingCB;
        private System.Windows.Forms.ComboBox revisionCB;
        private System.Windows.Forms.Label drawingLabel;
        private System.Windows.Forms.Label revisionLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label miscLabel;
        private System.Windows.Forms.TextBox miscText;
        private System.Windows.Forms.Label laserLbl;
        private System.Windows.Forms.ComboBox laserCB;
        private System.Windows.Forms.WebBrowser drawingPreview;
        private System.Windows.Forms.Button browseDrawing;
        private System.Windows.Forms.Button browseLaser;
        private System.Windows.Forms.DataGridView laserPreview;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem3;
    }
}

