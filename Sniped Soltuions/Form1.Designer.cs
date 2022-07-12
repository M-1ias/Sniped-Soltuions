namespace SnipeMask
{
    partial class MainPanel
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Header = new System.Windows.Forms.Panel();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.CheatName = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.BgWorker = new System.ComponentModel.BackgroundWorker();
            this.SubHeader = new System.Windows.Forms.Panel();
            this.ProcLabel = new System.Windows.Forms.Label();
            this.ProcIntro = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.WeaponBackground = new System.Windows.Forms.Panel();
            this.WeaponContainer = new System.Windows.Forms.Panel();
            this.InfiniteGrenades = new System.Windows.Forms.CheckBox();
            this.Rapid = new System.Windows.Forms.CheckBox();
            this.InfiniteAmmo = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NoRecoil = new System.Windows.Forms.CheckBox();
            this.WeaponLabel = new System.Windows.Forms.Label();
            this.PlayerLabel = new System.Windows.Forms.Label();
            this.PlayerContainer = new System.Windows.Forms.Panel();
            this.InfiniteArmor = new System.Windows.Forms.CheckBox();
            this.NoClip = new System.Windows.Forms.CheckBox();
            this.InfiniteHealth = new System.Windows.Forms.CheckBox();
            this.PlayerBackground = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.NName = new System.Windows.Forms.TextBox();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SubHeader.SuspendLayout();
            this.WeaponBackground.SuspendLayout();
            this.WeaponContainer.SuspendLayout();
            this.PlayerContainer.SuspendLayout();
            this.PlayerBackground.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Header.Controls.Add(this.MinimizeButton);
            this.Header.Controls.Add(this.CloseButton);
            this.Header.Controls.Add(this.CheatName);
            this.Header.Controls.Add(this.Logo);
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(350, 50);
            this.Header.TabIndex = 1;
            this.Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            this.Header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Header_MouseMove);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Font = new System.Drawing.Font("Unispace", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MinimizeButton.Location = new System.Drawing.Point(285, 12);
            this.MinimizeButton.Margin = new System.Windows.Forms.Padding(0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(25, 25);
            this.MinimizeButton.TabIndex = 1;
            this.MinimizeButton.Text = "🗕";
            this.MinimizeButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseButton.Location = new System.Drawing.Point(317, 12);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(25, 25);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "x";
            this.CloseButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // CheatName
            // 
            this.CheatName.AutoSize = true;
            this.CheatName.BackColor = System.Drawing.Color.Transparent;
            this.CheatName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheatName.Font = new System.Drawing.Font("Unispace", 14.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CheatName.Location = new System.Drawing.Point(62, 15);
            this.CheatName.Name = "CheatName";
            this.CheatName.Size = new System.Drawing.Size(202, 24);
            this.CheatName.TabIndex = 3;
            this.CheatName.Text = "Sniped Soltuions";
            this.CheatName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CheatName_MouseDown);
            this.CheatName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CheatName_MouseMove);
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Logo.Image = global::Sniped_Soltuions.Properties.Resources.db6sga6_3819e8ca_5679_4223_baf9_eaed6734f0c3_removebg_preview__1_;
            this.Logo.Location = new System.Drawing.Point(-27, 1);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(125, 125);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            this.Logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Logo_MouseDown);
            this.Logo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Logo_MouseMove);
            // 
            // BgWorker
            // 
            this.BgWorker.WorkerReportsProgress = true;
            this.BgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgWorker_DoWork);
            this.BgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BgWorker_RunWorkerCompleted);
            // 
            // SubHeader
            // 
            this.SubHeader.BackColor = System.Drawing.Color.DimGray;
            this.SubHeader.Controls.Add(this.ProcLabel);
            this.SubHeader.Controls.Add(this.ProcIntro);
            this.SubHeader.Location = new System.Drawing.Point(0, 47);
            this.SubHeader.Name = "SubHeader";
            this.SubHeader.Size = new System.Drawing.Size(353, 34);
            this.SubHeader.TabIndex = 2;
            this.SubHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SubHeader_MouseDown);
            this.SubHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SubHeader_MouseMove);
            // 
            // ProcLabel
            // 
            this.ProcLabel.AutoSize = true;
            this.ProcLabel.BackColor = System.Drawing.Color.Transparent;
            this.ProcLabel.ForeColor = System.Drawing.Color.Red;
            this.ProcLabel.Location = new System.Drawing.Point(66, 8);
            this.ProcLabel.Name = "ProcLabel";
            this.ProcLabel.Size = new System.Drawing.Size(64, 15);
            this.ProcLabel.TabIndex = 1;
            this.ProcLabel.Text = "Not Found";
            this.ProcLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProcLabel_MouseDown);
            this.ProcLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProcLabel_MouseMove);
            // 
            // ProcIntro
            // 
            this.ProcIntro.AutoSize = true;
            this.ProcIntro.Location = new System.Drawing.Point(16, 8);
            this.ProcIntro.Name = "ProcIntro";
            this.ProcIntro.Size = new System.Drawing.Size(56, 15);
            this.ProcIntro.TabIndex = 0;
            this.ProcIntro.Text = "Process : ";
            this.ProcIntro.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProcIntro_MouseDown);
            this.ProcIntro.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProcIntro_MouseMove);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel3.ForeColor = System.Drawing.Color.Transparent;
            this.panel3.Location = new System.Drawing.Point(0, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(350, 2);
            this.panel3.TabIndex = 3;
            // 
            // WeaponBackground
            // 
            this.WeaponBackground.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.WeaponBackground.Controls.Add(this.WeaponContainer);
            this.WeaponBackground.Location = new System.Drawing.Point(20, 100);
            this.WeaponBackground.Name = "WeaponBackground";
            this.WeaponBackground.Size = new System.Drawing.Size(140, 200);
            this.WeaponBackground.TabIndex = 4;
            // 
            // WeaponContainer
            // 
            this.WeaponContainer.BackColor = System.Drawing.Color.DimGray;
            this.WeaponContainer.Controls.Add(this.InfiniteGrenades);
            this.WeaponContainer.Controls.Add(this.Rapid);
            this.WeaponContainer.Controls.Add(this.InfiniteAmmo);
            this.WeaponContainer.Controls.Add(this.panel2);
            this.WeaponContainer.Controls.Add(this.NoRecoil);
            this.WeaponContainer.Location = new System.Drawing.Point(2, 2);
            this.WeaponContainer.Name = "WeaponContainer";
            this.WeaponContainer.Size = new System.Drawing.Size(136, 196);
            this.WeaponContainer.TabIndex = 5;
            // 
            // InfiniteGrenades
            // 
            this.InfiniteGrenades.AutoSize = true;
            this.InfiniteGrenades.Location = new System.Drawing.Point(7, 66);
            this.InfiniteGrenades.Name = "InfiniteGrenades";
            this.InfiniteGrenades.Size = new System.Drawing.Size(115, 19);
            this.InfiniteGrenades.TabIndex = 10;
            this.InfiniteGrenades.Text = "Infinite Grenades";
            this.InfiniteGrenades.UseVisualStyleBackColor = true;
            this.InfiniteGrenades.CheckedChanged += new System.EventHandler(this.InfiniteGrenades_CheckedChanged);
            // 
            // Rapid
            // 
            this.Rapid.AutoSize = true;
            this.Rapid.Location = new System.Drawing.Point(7, 91);
            this.Rapid.Name = "Rapid";
            this.Rapid.Size = new System.Drawing.Size(78, 19);
            this.Rapid.TabIndex = 9;
            this.Rapid.Text = "Rapid Fire";
            this.Rapid.UseVisualStyleBackColor = true;
            this.Rapid.CheckedChanged += new System.EventHandler(this.Rapid_CheckedChanged);
            // 
            // InfiniteAmmo
            // 
            this.InfiniteAmmo.AutoSize = true;
            this.InfiniteAmmo.Location = new System.Drawing.Point(8, 41);
            this.InfiniteAmmo.Name = "InfiniteAmmo";
            this.InfiniteAmmo.Size = new System.Drawing.Size(103, 19);
            this.InfiniteAmmo.TabIndex = 2;
            this.InfiniteAmmo.Text = "Infinite Ammo";
            this.InfiniteAmmo.UseVisualStyleBackColor = true;
            this.InfiniteAmmo.CheckedChanged += new System.EventHandler(this.InfiniteAmmo_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Location = new System.Drawing.Point(111, 202);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 200);
            this.panel2.TabIndex = 8;
            // 
            // NoRecoil
            // 
            this.NoRecoil.AutoSize = true;
            this.NoRecoil.Location = new System.Drawing.Point(8, 16);
            this.NoRecoil.Name = "NoRecoil";
            this.NoRecoil.Size = new System.Drawing.Size(77, 19);
            this.NoRecoil.TabIndex = 1;
            this.NoRecoil.Text = "No Recoil";
            this.NoRecoil.UseVisualStyleBackColor = true;
            this.NoRecoil.CheckedChanged += new System.EventHandler(this.NoRecoil_CheckedChanged);
            // 
            // WeaponLabel
            // 
            this.WeaponLabel.AutoSize = true;
            this.WeaponLabel.BackColor = System.Drawing.Color.Transparent;
            this.WeaponLabel.ForeColor = System.Drawing.Color.White;
            this.WeaponLabel.Location = new System.Drawing.Point(30, 90);
            this.WeaponLabel.Name = "WeaponLabel";
            this.WeaponLabel.Size = new System.Drawing.Size(51, 15);
            this.WeaponLabel.TabIndex = 5;
            this.WeaponLabel.Text = "Weapon";
            // 
            // PlayerLabel
            // 
            this.PlayerLabel.AutoSize = true;
            this.PlayerLabel.BackColor = System.Drawing.Color.Transparent;
            this.PlayerLabel.ForeColor = System.Drawing.Color.White;
            this.PlayerLabel.Location = new System.Drawing.Point(200, 90);
            this.PlayerLabel.Name = "PlayerLabel";
            this.PlayerLabel.Size = new System.Drawing.Size(39, 15);
            this.PlayerLabel.TabIndex = 7;
            this.PlayerLabel.Text = "Player";
            // 
            // PlayerContainer
            // 
            this.PlayerContainer.BackColor = System.Drawing.Color.DimGray;
            this.PlayerContainer.Controls.Add(this.InfiniteArmor);
            this.PlayerContainer.Controls.Add(this.NoClip);
            this.PlayerContainer.Controls.Add(this.InfiniteHealth);
            this.PlayerContainer.Location = new System.Drawing.Point(2, 2);
            this.PlayerContainer.Name = "PlayerContainer";
            this.PlayerContainer.Size = new System.Drawing.Size(136, 196);
            this.PlayerContainer.TabIndex = 5;
            // 
            // InfiniteArmor
            // 
            this.InfiniteArmor.AutoSize = true;
            this.InfiniteArmor.Location = new System.Drawing.Point(8, 41);
            this.InfiniteArmor.Name = "InfiniteArmor";
            this.InfiniteArmor.Size = new System.Drawing.Size(100, 19);
            this.InfiniteArmor.TabIndex = 2;
            this.InfiniteArmor.Text = "Infinite Armor";
            this.InfiniteArmor.UseVisualStyleBackColor = true;
            this.InfiniteArmor.CheckedChanged += new System.EventHandler(this.InfiniteArmor_CheckedChanged);
            // 
            // NoClip
            // 
            this.NoClip.AutoSize = true;
            this.NoClip.Location = new System.Drawing.Point(9, 66);
            this.NoClip.Name = "NoClip";
            this.NoClip.Size = new System.Drawing.Size(63, 19);
            this.NoClip.TabIndex = 1;
            this.NoClip.Text = "NoClip";
            this.NoClip.UseVisualStyleBackColor = true;
            this.NoClip.CheckedChanged += new System.EventHandler(this.NoClip_CheckedChanged);
            // 
            // InfiniteHealth
            // 
            this.InfiniteHealth.AutoSize = true;
            this.InfiniteHealth.Location = new System.Drawing.Point(8, 16);
            this.InfiniteHealth.Name = "InfiniteHealth";
            this.InfiniteHealth.Size = new System.Drawing.Size(101, 19);
            this.InfiniteHealth.TabIndex = 0;
            this.InfiniteHealth.Text = "Infinite Health";
            this.InfiniteHealth.UseVisualStyleBackColor = true;
            this.InfiniteHealth.CheckedChanged += new System.EventHandler(this.InfiniteHealth_CheckedChanged);
            // 
            // PlayerBackground
            // 
            this.PlayerBackground.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.PlayerBackground.Controls.Add(this.PlayerContainer);
            this.PlayerBackground.Location = new System.Drawing.Point(190, 100);
            this.PlayerBackground.Name = "PlayerBackground";
            this.PlayerBackground.Size = new System.Drawing.Size(140, 200);
            this.PlayerBackground.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name Changer";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.NName);
            this.panel1.Location = new System.Drawing.Point(20, 310);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 39);
            this.panel1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(195, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Apply Name";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // NName
            // 
            this.NName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NName.Location = new System.Drawing.Point(9, 10);
            this.NName.MaxLength = 16;
            this.NName.Name = "NName";
            this.NName.PlaceholderText = "Enter A Name";
            this.NName.Size = new System.Drawing.Size(123, 23);
            this.NName.TabIndex = 0;
            this.NName.Text = "A";
            this.NName.TextChanged += new System.EventHandler(this.NName_TextChanged);
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(350, 362);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PlayerLabel);
            this.Controls.Add(this.PlayerBackground);
            this.Controls.Add(this.WeaponLabel);
            this.Controls.Add(this.WeaponBackground);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.SubHeader);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainPanel";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.SubHeader.ResumeLayout(false);
            this.SubHeader.PerformLayout();
            this.WeaponBackground.ResumeLayout(false);
            this.WeaponContainer.ResumeLayout(false);
            this.WeaponContainer.PerformLayout();
            this.PlayerContainer.ResumeLayout(false);
            this.PlayerContainer.PerformLayout();
            this.PlayerBackground.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel Header;
        private PictureBox Logo;
        private System.ComponentModel.BackgroundWorker BgWorker;
        private Panel SubHeader;
        private Label ProcLabel;
        private Label ProcIntro;
        private Panel panel3;
        private Panel WeaponBackground;
        private Label PlayerLabel;
        private Panel WeaponContainer;
        private Label WeaponLabel;
        private Panel PlayerContainer;
        private Panel PlayerBackground;
        private Label CheatName;
        private Button MinimizeButton;
        private Button CloseButton;
        private CheckBox InfiniteHealth;
        private CheckBox NoRecoil;
        private CheckBox InfiniteAmmo;
        private CheckBox NoClip;
        private CheckBox InfiniteArmor;
        private Panel panel2;
        private Label label1;
        private Panel panel1;
        private Button button1;
        private TextBox NName;
        private CheckBox Rapid;
        private CheckBox InfiniteGrenades;
    }
}