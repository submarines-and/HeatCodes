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
            this.drawingLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.miscLabel = new System.Windows.Forms.Label();
            this.noteText = new System.Windows.Forms.TextBox();
            this.laserLbl = new System.Windows.Forms.Label();
            this.laserCB = new System.Windows.Forms.ComboBox();
            this.documentPreview = new System.Windows.Forms.WebBrowser();
            this.browseDrawing = new System.Windows.Forms.Button();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.certLabel = new System.Windows.Forms.Label();
            this.certCB = new System.Windows.Forms.ComboBox();
            this.browseCert = new System.Windows.Forms.Button();
            this.miscCB = new System.Windows.Forms.ComboBox();
            this.browseMisc = new System.Windows.Forms.Button();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // drawingCB
            // 
            this.drawingCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drawingCB.FormattingEnabled = true;
            this.drawingCB.Location = new System.Drawing.Point(908, 159);
            this.drawingCB.Margin = new System.Windows.Forms.Padding(2);
            this.drawingCB.Name = "drawingCB";
            this.drawingCB.Size = new System.Drawing.Size(146, 21);
            this.drawingCB.TabIndex = 1;
            this.drawingCB.SelectedIndexChanged += new System.EventHandler(this.DrawingListListener);
            // 
            // drawingLabel
            // 
            this.drawingLabel.AutoSize = true;
            this.drawingLabel.Location = new System.Drawing.Point(843, 162);
            this.drawingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.drawingLabel.Name = "drawingLabel";
            this.drawingLabel.Size = new System.Drawing.Size(40, 13);
            this.drawingLabel.TabIndex = 3;
            this.drawingLabel.Text = "Ritning";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(969, 11);
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
            this.miscLabel.Location = new System.Drawing.Point(841, 314);
            this.miscLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.miscLabel.Name = "miscLabel";
            this.miscLabel.Size = new System.Drawing.Size(60, 13);
            this.miscLabel.TabIndex = 6;
            this.miscLabel.Text = "Kommentar";
            // 
            // miscText
            // 
            this.noteText.Location = new System.Drawing.Point(907, 311);
            this.noteText.Margin = new System.Windows.Forms.Padding(2);
            this.noteText.Name = "miscText";
            this.noteText.Size = new System.Drawing.Size(220, 20);
            this.noteText.TabIndex = 7;
            // 
            // laserLbl
            // 
            this.laserLbl.AutoSize = true;
            this.laserLbl.Location = new System.Drawing.Point(842, 240);
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
            this.laserCB.Location = new System.Drawing.Point(907, 240);
            this.laserCB.Margin = new System.Windows.Forms.Padding(2);
            this.laserCB.Name = "laserCB";
            this.laserCB.Size = new System.Drawing.Size(146, 21);
            this.laserCB.TabIndex = 10;
            // 
            // documentPreview
            // 
            this.documentPreview.Location = new System.Drawing.Point(11, 11);
            this.documentPreview.Margin = new System.Windows.Forms.Padding(2);
            this.documentPreview.MinimumSize = new System.Drawing.Size(15, 16);
            this.documentPreview.Name = "documentPreview";
            this.documentPreview.Size = new System.Drawing.Size(760, 579);
            this.documentPreview.TabIndex = 12;
            // 
            // browseDrawing
            // 
            this.browseDrawing.Location = new System.Drawing.Point(1059, 159);
            this.browseDrawing.Margin = new System.Windows.Forms.Padding(2);
            this.browseDrawing.Name = "browseDrawing";
            this.browseDrawing.Size = new System.Drawing.Size(21, 19);
            this.browseDrawing.TabIndex = 13;
            this.browseDrawing.Text = "...";
            this.browseDrawing.UseVisualStyleBackColor = true;
            this.browseDrawing.Click += new System.EventHandler(this.BrowseForDrawing);
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem4});
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
            // menuItem4
            // 
            this.menuItem4.Index = 1;
            this.menuItem4.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem5});
            this.menuItem4.Text = "Edit";
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 0;
            this.menuItem5.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem6,
            this.menuItem7,
            this.menuItem8,
            this.menuItem9});
            this.menuItem5.Text = "Paths";
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 0;
            this.menuItem6.Text = "Drawings";
            this.menuItem6.Click += new System.EventHandler(this.ChangeDrawingPath);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 1;
            this.menuItem7.Text = "Laser Alignment";
            this.menuItem7.Click += new System.EventHandler(this.ChangeLaserPath);
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 2;
            this.menuItem8.Text = "Certificates";
            this.menuItem8.Click += new System.EventHandler(this.ChangeCertificatePath);
            // 
            // certLabel
            // 
            this.certLabel.AutoSize = true;
            this.certLabel.Location = new System.Drawing.Point(842, 205);
            this.certLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.certLabel.Name = "certLabel";
            this.certLabel.Size = new System.Drawing.Size(48, 13);
            this.certLabel.TabIndex = 18;
            this.certLabel.Text = "Certifikat";
            // 
            // certCB
            // 
            this.certCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.certCB.FormattingEnabled = true;
            this.certCB.Location = new System.Drawing.Point(908, 202);
            this.certCB.Margin = new System.Windows.Forms.Padding(2);
            this.certCB.Name = "certCB";
            this.certCB.Size = new System.Drawing.Size(146, 21);
            this.certCB.TabIndex = 17;
            this.certCB.SelectedIndexChanged += new System.EventHandler(this.CertListListener);
            // 
            // browseCert
            // 
            this.browseCert.Location = new System.Drawing.Point(1058, 202);
            this.browseCert.Margin = new System.Windows.Forms.Padding(2);
            this.browseCert.Name = "browseCert";
            this.browseCert.Size = new System.Drawing.Size(21, 19);
            this.browseCert.TabIndex = 19;
            this.browseCert.Text = "...";
            this.browseCert.UseVisualStyleBackColor = true;
            this.browseCert.Click += new System.EventHandler(this.BrowseForCertificate);
            // 
            // miscCB
            // 
            this.miscCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.miscCB.FormattingEnabled = true;
            this.miscCB.Location = new System.Drawing.Point(907, 276);
            this.miscCB.Margin = new System.Windows.Forms.Padding(2);
            this.miscCB.Name = "miscCB";
            this.miscCB.Size = new System.Drawing.Size(146, 21);
            this.miscCB.TabIndex = 20;
            this.miscCB.SelectedIndexChanged += new System.EventHandler(this.MiscListListener);
            // 
            // browseMisc
            // 
            this.browseMisc.Location = new System.Drawing.Point(1059, 276);
            this.browseMisc.Margin = new System.Windows.Forms.Padding(2);
            this.browseMisc.Name = "browseMisc";
            this.browseMisc.Size = new System.Drawing.Size(21, 19);
            this.browseMisc.TabIndex = 21;
            this.browseMisc.Text = "...";
            this.browseMisc.UseVisualStyleBackColor = true;
            this.browseMisc.Click += new System.EventHandler(this.BrowseForMisc);
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 3;
            this.menuItem9.Text = "Övrigt";
            this.menuItem9.Click += new System.EventHandler(this.ChangeMiscPath);
            // 
            // StartFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1232, 623);
            this.Controls.Add(this.browseMisc);
            this.Controls.Add(this.miscCB);
            this.Controls.Add(this.browseCert);
            this.Controls.Add(this.certLabel);
            this.Controls.Add(this.certCB);
            this.Controls.Add(this.browseDrawing);
            this.Controls.Add(this.documentPreview);
            this.Controls.Add(this.laserLbl);
            this.Controls.Add(this.laserCB);
            this.Controls.Add(this.noteText);
            this.Controls.Add(this.miscLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.drawingLabel);
            this.Controls.Add(this.drawingCB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Menu = this.mainMenu1;
            this.Name = "StartFrame";
            this.Text = "HeatCodes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox drawingCB;
        private System.Windows.Forms.Label drawingLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label miscLabel;
        private System.Windows.Forms.TextBox noteText;
        private System.Windows.Forms.Label laserLbl;
        private System.Windows.Forms.ComboBox laserCB;
        private System.Windows.Forms.WebBrowser documentPreview;
        private System.Windows.Forms.Button browseDrawing;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.MenuItem menuItem8;
        private System.Windows.Forms.Label certLabel;
        private System.Windows.Forms.ComboBox certCB;
        private System.Windows.Forms.Button browseCert;
        private System.Windows.Forms.ComboBox miscCB;
        private System.Windows.Forms.Button browseMisc;
        private System.Windows.Forms.MenuItem menuItem9;
    }
}

