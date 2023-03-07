namespace WinFormsDistroboot
{
    partial class Distroboot
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

            //public void InitializeComponent();

        //#region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Distroboot));
            ImagesOnline = new CheckedListBox();
            DLDistro = new Button();
            RamdiskSize = new GroupBox();
            ShowOutput = new CheckBox();
            radio10GB = new RadioButton();
            radio4GB = new RadioButton();
            lblId = new Label();
            lblIso = new Label();
            lblUrl = new Label();
            GrpImageDetails = new GroupBox();
            lblSpeed = new Label();
            progressBar1 = new ProgressBar();
            helpProvider1 = new HelpProvider();
            ImagesLocal = new ListBox();
            AddImage = new Button();
            RemoveImage = new Button();
            button1 = new Button();
            RamdiskSize.SuspendLayout();
            GrpImageDetails.SuspendLayout();
            //SuspendLayout();
            // 
            // ImagesOnline
            // 
            ImagesOnline.BackColor = Color.Beige;
            ImagesOnline.BorderStyle = BorderStyle.None;
            ImagesOnline.CheckOnClick = true;
            ImagesOnline.Font = new Font("Franklin Gothic Medium", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ImagesOnline.ForeColor = Color.Indigo;
            ImagesOnline.FormattingEnabled = true;
            ImagesOnline.Items.AddRange(new object[] { "MX", "Endeavour", "Mint", "manjaro-kde", "manjaro-gnome", "pop-os Intel", "pop-os Nvidia", "Fedora-WS", "Ubuntu Desktop", "Ubuntu Studio", "Ubuntu Server", "Debian", "Linux Lite", "Garuda dr460nized", "elementaryOS", "Voyager Live", "AV Linux", "Haiku", "dragonFly BSD", "extix", "feren", "Nobara", "Qubes", "Neptune", "Athena OS", "Slax 64Bit", "Zorin core", "kali", "calculate linux", "coreplus", "Oracle Linux", "Open BSD", "LXLE-Focal-Release", "GeckoLinux", "Peropesis", "MakuluLinux-ShiFt", "kodachi", "bodhi", "Tuxedo OS", "Tails", "Slackware", "Linux FX Win 10", "Linux FX Win 11", "fossapup64", "Arco Linux", "Easy Linux", "Nitrux", "Rocky Linux", "Salix", "Devuan Beowulf", "gentoo", "pure OS", "ELD", "prime OS", "Bliss OS", "React OS", "peppermint OS", "Clear Linux", "Redcore.Linux.Hardened", "Loc OS", "Mabox", "Reloaded OS", "Emmabuntus", "arcolinux", "open Mandriva", "Legacy OS", "Xiaopan", "cachy OS", "Slint", "Neurolinux", "Jarro Negro", "Predator OS", "xos workstation", "Dragon OS", "Lirix", "Circle OS", "Roling OS", "Titan Linux", "Crowz OS", "Dat Linux", "Freedom OS", "Metis OS", "Chimaera OS", "daedalus", "convectix darwin", "convectix myb-13.1.2.iso", "Shiny OS", "Carbon OS", "PikaOS Gnome", "PikaOS KDE", "Blend OS", "Accessible Coconut" });
            ImagesOnline.Location = new Point(779, -1);
            ImagesOnline.Margin = new Padding(4, 2, 4, 2);
            ImagesOnline.MultiColumn = true;
            ImagesOnline.Name = "ImagesOnline";
            helpProvider1.SetShowHelp(ImagesOnline, false);
            ImagesOnline.Size = new Size(733, 396);
            ImagesOnline.TabIndex = 0;
            ImagesOnline.ThreeDCheckBoxes = true;
            ImagesOnline.UseWaitCursor = true;
            ImagesOnline.ItemCheck += ShowDetailedInfo;
            ImagesOnline.BackColorChanged += radio10GB_SelectedChanged;
            // 
            // DLDistro
            // 
            DLDistro.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DLDistro.Location = new Point(626, 0);
            DLDistro.Margin = new Padding(4, 2, 4, 2);
            DLDistro.Name = "DLDistro";
            DLDistro.Size = new Size(151, 98);
            DLDistro.TabIndex = 4;
            DLDistro.Text = "Download";
            DLDistro.TextAlign = ContentAlignment.MiddleRight;
            DLDistro.UseVisualStyleBackColor = true;
            DLDistro.UseWaitCursor = true;
            DLDistro.Click += DownloadItemAsync;
            // 
            // RamdiskSize
            // 
            RamdiskSize.BackColor = Color.Beige;
            RamdiskSize.Controls.Add(ShowOutput);
            RamdiskSize.Controls.Add(radio10GB);
            RamdiskSize.Controls.Add(radio4GB);
            RamdiskSize.Location = new Point(448, 3);
            RamdiskSize.Margin = new Padding(4, 2, 4, 2);
            RamdiskSize.Name = "RamdiskSize";
            RamdiskSize.Padding = new Padding(4, 2, 4, 2);
            RamdiskSize.Size = new Size(170, 97);
            RamdiskSize.TabIndex = 6;
            RamdiskSize.TabStop = false;
            RamdiskSize.Text = "ramdisk size";
            RamdiskSize.UseWaitCursor = true;
            // 
            // ShowOutput
            // 
            ShowOutput.AutoSize = true;
            ShowOutput.BackColor = Color.FromArgb(0, 64, 0);
            ShowOutput.Checked = true;
            ShowOutput.CheckState = CheckState.Checked;
            ShowOutput.ForeColor = Color.Gold;
            ShowOutput.Location = new Point(7, 68);
            ShowOutput.Name = "ShowOutput";
            ShowOutput.Size = new Size(126, 24);
            ShowOutput.TabIndex = 5;
            ShowOutput.Text = "Show terminal";
            ShowOutput.UseVisualStyleBackColor = true;
            ShowOutput.UseWaitCursor = false;
            // 
            // radio10GB
            // 
            radio10GB.AutoSize = true;
            radio10GB.Checked = true;
            radio10GB.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            radio10GB.Location = new Point(60, 18);
            radio10GB.Margin = new Padding(4, 2, 4, 2);
            radio10GB.Name = "radio10GB";
            radio10GB.Size = new Size(64, 23);
            radio10GB.TabIndex = 4;
            radio10GB.TabStop = true;
            radio10GB.Text = "10GB";
            radio10GB.UseVisualStyleBackColor = true;
            radio10GB.UseWaitCursor = false;
            //radio10GB.CheckedChanged += FindImage;
            // 
            // radio4GB
            // 
            radio4GB.AutoSize = true;
            radio4GB.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            radio4GB.Location = new Point(6, 18);
            radio4GB.Margin = new Padding(4, 2, 4, 2);
            radio4GB.Name = "radio4GB";
            radio4GB.Size = new Size(56, 23);
            radio4GB.TabIndex = 3;
            radio4GB.TabStop = true;
            radio4GB.Text = "4GB";
            radio4GB.UseVisualStyleBackColor = true;
            radio4GB.UseWaitCursor = true;
            //EventHandler SHOW_HIDECMD = null;
            //radio4GB.CheckedChanged += FindImage;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(19, 250);
            lblId.Margin = new Padding(4, 0, 4, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(0, 20);
            lblId.TabIndex = 7;
            lblId.UseWaitCursor = true;
            lblId.Visible = false;
            // 
            // lblIso
            // 
            lblIso.AutoSize = true;
            lblIso.Location = new Point(-124, 24);
            lblIso.Margin = new Padding(4, 0, 4, 0);
            lblIso.Name = "lblIso";
            lblIso.Size = new Size(0, 20);
            lblIso.TabIndex = 8;
            lblIso.UseWaitCursor = true;
            // 
            // lblUrl
            // 
            lblUrl.AutoSize = true;
            lblUrl.Location = new Point(8, 22);
            lblUrl.Margin = new Padding(4, 0, 4, 0);
            lblUrl.Name = "lblUrl";
            lblUrl.Size = new Size(15, 20);
            lblUrl.TabIndex = 9;
            lblUrl.Text = "..";
            lblUrl.UseWaitCursor = true;
            // 
            // GrpImageDetails
            // 
            GrpImageDetails.Controls.Add(lblSpeed);
            GrpImageDetails.Controls.Add(lblUrl);
            GrpImageDetails.Controls.Add(lblIso);
            GrpImageDetails.Location = new Point(0, 302);
            GrpImageDetails.Margin = new Padding(4, 2, 4, 2);
            GrpImageDetails.Name = "GrpImageDetails";
            GrpImageDetails.Padding = new Padding(4, 2, 4, 2);
            GrpImageDetails.Size = new Size(777, 95);
            GrpImageDetails.TabIndex = 10;
            GrpImageDetails.TabStop = false;
            GrpImageDetails.Text = "download speed";
            GrpImageDetails.UseWaitCursor = true;
            GrpImageDetails.Visible = false;
            // 
            // lblSpeed
            // 
            lblSpeed.AutoSize = true;
            lblSpeed.Location = new Point(460, 67);
            lblSpeed.Margin = new Padding(4, 0, 4, 0);
            lblSpeed.Name = "lblSpeed";
            lblSpeed.Size = new Size(41, 20);
            lblSpeed.TabIndex = 0;
            lblSpeed.Text = " ";
            //lblSpeed.UseWaitCursor = true;
            // 
            // progressBar1
            // 
            progressBar1.BackColor = Color.Red;
            progressBar1.ForeColor = Color.FromArgb(0, 0, 64);
            progressBar1.Location = new Point(0, 391);
            progressBar1.Margin = new Padding(4, 2, 4, 2);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(1512, 73);
            progressBar1.TabIndex = 11;
            progressBar1.UseWaitCursor = true;
            // 
            // ImagesLocal
            // 
            ImagesLocal.BackColor = Color.Beige;
            ImagesLocal.BorderStyle = BorderStyle.None;
            ImagesLocal.FormattingEnabled = true;
            ImagesLocal.ItemHeight = 20;
            ImagesLocal.Location = new Point(0, 103);
            ImagesLocal.Margin = new Padding(4);
            ImagesLocal.Name = "ImagesLocal";
            ImagesLocal.Size = new Size(777, 200);
            ImagesLocal.TabIndex = 12;
            ImagesLocal.UseWaitCursor = false;
            ImagesLocal.MouseDoubleClick += StartImage;
            // 
            // AddImage
            // 
            AddImage.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AddImage.Location = new Point(0, 2);
            AddImage.Margin = new Padding(4);
            AddImage.Name = "AddImage";
            AddImage.Size = new Size(134, 98);
            AddImage.TabIndex = 13;
            AddImage.Text = "Add Image";
            AddImage.UseVisualStyleBackColor = true;
            AddImage.UseWaitCursor = true;
            AddImage.Click += FindImage;
            // 
            // RemoveImage
            // 
            RemoveImage.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RemoveImage.Location = new Point(142, 2);
            RemoveImage.Margin = new Padding(4);
            RemoveImage.Name = "RemoveImage";
            RemoveImage.Size = new Size(134, 98);
            RemoveImage.TabIndex = 14;
            RemoveImage.Text = "Remove Image";
            RemoveImage.UseVisualStyleBackColor = true;
            RemoveImage.UseWaitCursor = true;
            RemoveImage.Click += RemoveItem;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(284, 2);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(156, 98);
            button1.TabIndex = 15;
            button1.Text = "Scan iso folder";
            button1.UseVisualStyleBackColor = true;
            button1.UseWaitCursor = false;
            button1.Click += ScanImages;
            // 
            // Distroboot
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.PaleGoldenrod;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1513, 464);
            Controls.Add(button1);
            Controls.Add(RemoveImage);
            Controls.Add(AddImage);
            Controls.Add(RamdiskSize);
            Controls.Add(DLDistro);
            Controls.Add(ImagesOnline);
            Controls.Add(progressBar1);
            Controls.Add(ImagesLocal);
            Controls.Add(lblId);
            Controls.Add(GrpImageDetails);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(4, 2, 4, 2);
            Name = "Distroboot";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "Distroboot";
            TopMost = true;
            TransparencyKey = Color.Ivory;
            UseWaitCursor = true;
            Load += Distroboot_Load;
            RamdiskSize.ResumeLayout(false);
            RamdiskSize.PerformLayout();
            GrpImageDetails.ResumeLayout(false);
            GrpImageDetails.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        //#endregion

        private CheckedListBox ImagesOnline;
        private Button DLDistro;
        private GroupBox RamdiskSize;
        private Label lblId;
        private Label lblIso;
        private Label lblUrl;
        private GroupBox GrpImageDetails;
        private ProgressBar progressBar1;
        private RadioButton radio10GB;
        private RadioButton radio4GB;
        private HelpProvider helpProvider1;
        private ListBox ImagesLocal;
        private Button AddImage;
        private Button RemoveImage;
        private Button button1;
        private GroupBox SpeedCounters;
        private Label Downloaded;
        private Label label1;
        private Label lblSpeed;
        private CheckBox ShowOutput;
    }
}