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
            this.drawingLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.miscLabel = new System.Windows.Forms.Label();
            this.noteText = new System.Windows.Forms.TextBox();
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
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.browseCert = new System.Windows.Forms.Button();
            this.certCB = new System.Windows.Forms.ComboBox();
            this.certLabel = new System.Windows.Forms.Label();
            this.laserLbl = new System.Windows.Forms.Label();
            this.laserCB = new System.Windows.Forms.ComboBox();
            this.browseMisc = new System.Windows.Forms.Button();
            this.miscCB = new System.Windows.Forms.ComboBox();
            this.debugLbl = new System.Windows.Forms.Label();
            this.cfgLbl = new System.Windows.Forms.Label();
            this.drawingListBox = new System.Windows.Forms.ListBox();
            this.chosenDrawingsListBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // drawingLabel
            // 
            this.drawingLabel.AutoSize = true;
            this.drawingLabel.Location = new System.Drawing.Point(854, 201);
            this.drawingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.drawingLabel.Name = "drawingLabel";
            this.drawingLabel.Size = new System.Drawing.Size(49, 13);
            this.drawingLabel.TabIndex = 3;
            this.drawingLabel.Text = "Ritningar";
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
            this.miscLabel.Location = new System.Drawing.Point(842, 497);
            this.miscLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.miscLabel.Name = "miscLabel";
            this.miscLabel.Size = new System.Drawing.Size(60, 13);
            this.miscLabel.TabIndex = 6;
            this.miscLabel.Text = "Kommentar";
            // 
            // noteText
            // 
            this.noteText.Location = new System.Drawing.Point(908, 494);
            this.noteText.Margin = new System.Windows.Forms.Padding(2);
            this.noteText.Name = "noteText";
            this.noteText.Size = new System.Drawing.Size(220, 20);
            this.noteText.TabIndex = 7;
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
            this.browseDrawing.Location = new System.Drawing.Point(1150, 309);
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
            this.menuItem4,
            this.menuItem10});
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
            // menuItem9
            // 
            this.menuItem9.Index = 3;
            this.menuItem9.Text = "Övrigt";
            this.menuItem9.Click += new System.EventHandler(this.ChangeMiscPath);
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 2;
            this.menuItem10.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem11});
            this.menuItem10.Text = "Tools";
            // 
            // menuItem11
            // 
            this.menuItem11.Index = 0;
            this.menuItem11.Text = "Toggle Debug";
            this.menuItem11.Click += new System.EventHandler(this.MenuToggleDebug);
            // 
            // browseCert
            // 
            this.browseCert.Location = new System.Drawing.Point(1059, 370);
            this.browseCert.Margin = new System.Windows.Forms.Padding(2);
            this.browseCert.Name = "browseCert";
            this.browseCert.Size = new System.Drawing.Size(21, 19);
            this.browseCert.TabIndex = 19;
            this.browseCert.Text = "...";
            this.browseCert.UseVisualStyleBackColor = true;
            this.browseCert.Click += new System.EventHandler(this.BrowseForCertificate);
            // 
            // certCB
            // 
            this.certCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.certCB.FormattingEnabled = true;
            this.certCB.Location = new System.Drawing.Point(909, 370);
            this.certCB.Margin = new System.Windows.Forms.Padding(2);
            this.certCB.Name = "certCB";
            this.certCB.Size = new System.Drawing.Size(146, 21);
            this.certCB.TabIndex = 17;
            this.certCB.SelectedIndexChanged += new System.EventHandler(this.CertListListener);
            // 
            // certLabel
            // 
            this.certLabel.AutoSize = true;
            this.certLabel.Location = new System.Drawing.Point(854, 373);
            this.certLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.certLabel.Name = "certLabel";
            this.certLabel.Size = new System.Drawing.Size(48, 13);
            this.certLabel.TabIndex = 18;
            this.certLabel.Text = "Certifikat";
            // 
            // laserLbl
            // 
            this.laserLbl.AutoSize = true;
            this.laserLbl.Location = new System.Drawing.Point(869, 411);
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
            this.laserCB.Location = new System.Drawing.Point(908, 408);
            this.laserCB.Margin = new System.Windows.Forms.Padding(2);
            this.laserCB.Name = "laserCB";
            this.laserCB.Size = new System.Drawing.Size(146, 21);
            this.laserCB.TabIndex = 10;
            // 
            // browseMisc
            // 
            this.browseMisc.Location = new System.Drawing.Point(1060, 444);
            this.browseMisc.Margin = new System.Windows.Forms.Padding(2);
            this.browseMisc.Name = "browseMisc";
            this.browseMisc.Size = new System.Drawing.Size(21, 19);
            this.browseMisc.TabIndex = 21;
            this.browseMisc.Text = "...";
            this.browseMisc.UseVisualStyleBackColor = true;
            this.browseMisc.Click += new System.EventHandler(this.BrowseForMisc);
            // 
            // miscCB
            // 
            this.miscCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.miscCB.FormattingEnabled = true;
            this.miscCB.Location = new System.Drawing.Point(908, 444);
            this.miscCB.Margin = new System.Windows.Forms.Padding(2);
            this.miscCB.Name = "miscCB";
            this.miscCB.Size = new System.Drawing.Size(146, 21);
            this.miscCB.TabIndex = 20;
            this.miscCB.SelectedIndexChanged += new System.EventHandler(this.MiscListListener);
            // 
            // debugLbl
            // 
            this.debugLbl.AutoSize = true;
            this.debugLbl.Location = new System.Drawing.Point(1056, 98);
            this.debugLbl.Name = "debugLbl";
            this.debugLbl.Size = new System.Drawing.Size(52, 13);
            this.debugLbl.TabIndex = 22;
            this.debugLbl.Text = "Debug-lbl";
            // 
            // cfgLbl
            // 
            this.cfgLbl.AutoSize = true;
            this.cfgLbl.Location = new System.Drawing.Point(834, 447);
            this.cfgLbl.Name = "cfgLbl";
            this.cfgLbl.Size = new System.Drawing.Size(69, 13);
            this.cfgLbl.TabIndex = 23;
            this.cfgLbl.Text = "Konfiguration";
            // 
            // drawingListBox
            // 
            this.drawingListBox.FormattingEnabled = true;
            this.drawingListBox.Location = new System.Drawing.Point(857, 233);
            this.drawingListBox.Name = "drawingListBox";
            this.drawingListBox.Size = new System.Drawing.Size(120, 95);
            this.drawingListBox.TabIndex = 24;
            this.drawingListBox.SelectedIndexChanged += new System.EventHandler(this.DrawingListListener);
            // 
            // chosenDrawingsListBox
            // 
            this.chosenDrawingsListBox.FormattingEnabled = true;
            this.chosenDrawingsListBox.Location = new System.Drawing.Point(1025, 233);
            this.chosenDrawingsListBox.Name = "chosenDrawingsListBox";
            this.chosenDrawingsListBox.Size = new System.Drawing.Size(120, 95);
            this.chosenDrawingsListBox.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(982, 244);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 19);
            this.button1.TabIndex = 26;
            this.button1.Text = "-->";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddDrawingButtonListener);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(982, 284);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 19);
            this.button2.TabIndex = 27;
            this.button2.Text = "<--";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.RemoveDrawingButtonListener);
            // 
            // StartFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1232, 623);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chosenDrawingsListBox);
            this.Controls.Add(this.drawingListBox);
            this.Controls.Add(this.cfgLbl);
            this.Controls.Add(this.debugLbl);
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

        private System.Windows.Forms.Label drawingLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label miscLabel;
        private System.Windows.Forms.TextBox noteText;
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
        private System.Windows.Forms.MenuItem menuItem9;
        private System.Windows.Forms.MenuItem menuItem10;
        private System.Windows.Forms.MenuItem menuItem11;
        private System.Windows.Forms.Button browseCert;
        private System.Windows.Forms.ComboBox certCB;
        private System.Windows.Forms.Label certLabel;
        private System.Windows.Forms.Label laserLbl;
        private System.Windows.Forms.ComboBox laserCB;
        private System.Windows.Forms.Button browseMisc;
        private System.Windows.Forms.ComboBox miscCB;
        private System.Windows.Forms.Label debugLbl;
        private System.Windows.Forms.Label cfgLbl;
        private System.Windows.Forms.ListBox drawingListBox;
        private System.Windows.Forms.ListBox chosenDrawingsListBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

