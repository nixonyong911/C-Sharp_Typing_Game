namespace exampleMenu
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonOption = new System.Windows.Forms.Button();
            this.buttonCredits = new System.Windows.Forms.Button();
            this.MainMenuPanel = new System.Windows.Forms.Panel();
            this.StartGamePanel = new System.Windows.Forms.Panel();
            this.TimeTrialPanel = new System.Windows.Forms.Panel();
            this.buttonBackTT = new System.Windows.Forms.Button();
            this.HardTT = new System.Windows.Forms.Button();
            this.MediumTT = new System.Windows.Forms.Button();
            this.EasyTT = new System.Windows.Forms.Button();
            this.buttonBackMenu = new System.Windows.Forms.Button();
            this.buttonTimeTrial = new System.Windows.Forms.Button();
            this.buttonPoints = new System.Windows.Forms.Button();
            this.OptionPanel = new System.Windows.Forms.Panel();
            this.buttonSoundOff = new System.Windows.Forms.Button();
            this.buttonBackOption = new System.Windows.Forms.Button();
            this.buttonSoundOn = new System.Windows.Forms.Button();
            this.buttonHighScore = new System.Windows.Forms.Button();
            this.MainMenuPanel.SuspendLayout();
            this.StartGamePanel.SuspendLayout();
            this.TimeTrialPanel.SuspendLayout();
            this.OptionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.Transparent;
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStart.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonStart.FlatAppearance.BorderSize = 0;
            this.buttonStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonStart.Location = new System.Drawing.Point(433, 549);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(251, 54);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonOption
            // 
            this.buttonOption.BackColor = System.Drawing.Color.Transparent;
            this.buttonOption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOption.FlatAppearance.BorderSize = 0;
            this.buttonOption.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonOption.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOption.Location = new System.Drawing.Point(464, 625);
            this.buttonOption.Name = "buttonOption";
            this.buttonOption.Size = new System.Drawing.Size(182, 48);
            this.buttonOption.TabIndex = 2;
            this.buttonOption.UseVisualStyleBackColor = false;
            this.buttonOption.Click += new System.EventHandler(this.buttonOption_Click);
            // 
            // buttonCredits
            // 
            this.buttonCredits.BackColor = System.Drawing.Color.Transparent;
            this.buttonCredits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCredits.FlatAppearance.BorderSize = 0;
            this.buttonCredits.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonCredits.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonCredits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCredits.Location = new System.Drawing.Point(464, 697);
            this.buttonCredits.Name = "buttonCredits";
            this.buttonCredits.Size = new System.Drawing.Size(182, 42);
            this.buttonCredits.TabIndex = 3;
            this.buttonCredits.UseVisualStyleBackColor = false;
            this.buttonCredits.Click += new System.EventHandler(this.buttonCredits_Click);
            // 
            // MainMenuPanel
            // 
            this.MainMenuPanel.BackgroundImage = global::exampleMenu.Properties.Resources.mainpage;
            this.MainMenuPanel.Controls.Add(this.StartGamePanel);
            this.MainMenuPanel.Controls.Add(this.OptionPanel);
            this.MainMenuPanel.Controls.Add(this.buttonStart);
            this.MainMenuPanel.Controls.Add(this.buttonCredits);
            this.MainMenuPanel.Controls.Add(this.buttonOption);
            this.MainMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MainMenuPanel.Name = "MainMenuPanel";
            this.MainMenuPanel.Size = new System.Drawing.Size(1103, 827);
            this.MainMenuPanel.TabIndex = 4;
            // 
            // StartGamePanel
            // 
            this.StartGamePanel.BackgroundImage = global::exampleMenu.Properties.Resources.mode;
            this.StartGamePanel.Controls.Add(this.TimeTrialPanel);
            this.StartGamePanel.Controls.Add(this.buttonBackMenu);
            this.StartGamePanel.Controls.Add(this.buttonTimeTrial);
            this.StartGamePanel.Controls.Add(this.buttonPoints);
            this.StartGamePanel.Location = new System.Drawing.Point(0, 0);
            this.StartGamePanel.Name = "StartGamePanel";
            this.StartGamePanel.Size = new System.Drawing.Size(1103, 827);
            this.StartGamePanel.TabIndex = 5;
            // 
            // TimeTrialPanel
            // 
            this.TimeTrialPanel.BackgroundImage = global::exampleMenu.Properties.Resources.difficult;
            this.TimeTrialPanel.Controls.Add(this.buttonBackTT);
            this.TimeTrialPanel.Controls.Add(this.HardTT);
            this.TimeTrialPanel.Controls.Add(this.MediumTT);
            this.TimeTrialPanel.Controls.Add(this.EasyTT);
            this.TimeTrialPanel.Location = new System.Drawing.Point(0, 0);
            this.TimeTrialPanel.Name = "TimeTrialPanel";
            this.TimeTrialPanel.Size = new System.Drawing.Size(1103, 827);
            this.TimeTrialPanel.TabIndex = 6;
            // 
            // buttonBackTT
            // 
            this.buttonBackTT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBackTT.BackColor = System.Drawing.Color.Transparent;
            this.buttonBackTT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonBackTT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBackTT.FlatAppearance.BorderSize = 0;
            this.buttonBackTT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonBackTT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonBackTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackTT.Location = new System.Drawing.Point(501, 765);
            this.buttonBackTT.Name = "buttonBackTT";
            this.buttonBackTT.Size = new System.Drawing.Size(103, 37);
            this.buttonBackTT.TabIndex = 4;
            this.buttonBackTT.UseVisualStyleBackColor = false;
            this.buttonBackTT.Click += new System.EventHandler(this.buttonBackTT_Click);
            // 
            // HardTT
            // 
            this.HardTT.BackColor = System.Drawing.Color.Transparent;
            this.HardTT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HardTT.FlatAppearance.BorderSize = 0;
            this.HardTT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.HardTT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.HardTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HardTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HardTT.ForeColor = System.Drawing.Color.Red;
            this.HardTT.Location = new System.Drawing.Point(495, 697);
            this.HardTT.Name = "HardTT";
            this.HardTT.Size = new System.Drawing.Size(110, 37);
            this.HardTT.TabIndex = 3;
            this.HardTT.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.HardTT.UseVisualStyleBackColor = false;
            this.HardTT.Click += new System.EventHandler(this.HardTT_Click);
            // 
            // MediumTT
            // 
            this.MediumTT.BackColor = System.Drawing.Color.Transparent;
            this.MediumTT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MediumTT.FlatAppearance.BorderSize = 0;
            this.MediumTT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.MediumTT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.MediumTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MediumTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MediumTT.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MediumTT.Location = new System.Drawing.Point(467, 620);
            this.MediumTT.Name = "MediumTT";
            this.MediumTT.Size = new System.Drawing.Size(179, 48);
            this.MediumTT.TabIndex = 1;
            this.MediumTT.UseVisualStyleBackColor = false;
            this.MediumTT.Click += new System.EventHandler(this.MediumTT_Click);
            // 
            // EasyTT
            // 
            this.EasyTT.BackColor = System.Drawing.Color.Transparent;
            this.EasyTT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EasyTT.FlatAppearance.BorderSize = 0;
            this.EasyTT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.EasyTT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.EasyTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EasyTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EasyTT.Location = new System.Drawing.Point(484, 544);
            this.EasyTT.Name = "EasyTT";
            this.EasyTT.Size = new System.Drawing.Size(131, 49);
            this.EasyTT.TabIndex = 2;
            this.EasyTT.UseVisualStyleBackColor = false;
            this.EasyTT.Click += new System.EventHandler(this.EasyTT_Click);
            // 
            // buttonBackMenu
            // 
            this.buttonBackMenu.BackColor = System.Drawing.Color.Transparent;
            this.buttonBackMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBackMenu.FlatAppearance.BorderSize = 0;
            this.buttonBackMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonBackMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonBackMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackMenu.ForeColor = System.Drawing.Color.Red;
            this.buttonBackMenu.Location = new System.Drawing.Point(494, 697);
            this.buttonBackMenu.Name = "buttonBackMenu";
            this.buttonBackMenu.Size = new System.Drawing.Size(110, 45);
            this.buttonBackMenu.TabIndex = 3;
            this.buttonBackMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonBackMenu.UseVisualStyleBackColor = false;
            this.buttonBackMenu.Click += new System.EventHandler(this.buttonBackMenu_Click);
            // 
            // buttonTimeTrial
            // 
            this.buttonTimeTrial.BackColor = System.Drawing.Color.Transparent;
            this.buttonTimeTrial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTimeTrial.FlatAppearance.BorderSize = 0;
            this.buttonTimeTrial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonTimeTrial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonTimeTrial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTimeTrial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimeTrial.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonTimeTrial.Location = new System.Drawing.Point(437, 627);
            this.buttonTimeTrial.Name = "buttonTimeTrial";
            this.buttonTimeTrial.Size = new System.Drawing.Size(230, 45);
            this.buttonTimeTrial.TabIndex = 1;
            this.buttonTimeTrial.UseVisualStyleBackColor = false;
            this.buttonTimeTrial.Click += new System.EventHandler(this.buttonTimeTrial_Click);
            // 
            // buttonPoints
            // 
            this.buttonPoints.BackColor = System.Drawing.Color.Transparent;
            this.buttonPoints.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPoints.FlatAppearance.BorderSize = 0;
            this.buttonPoints.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonPoints.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonPoints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPoints.Location = new System.Drawing.Point(482, 553);
            this.buttonPoints.Name = "buttonPoints";
            this.buttonPoints.Size = new System.Drawing.Size(150, 45);
            this.buttonPoints.TabIndex = 2;
            this.buttonPoints.UseVisualStyleBackColor = false;
            this.buttonPoints.Click += new System.EventHandler(this.buttonPoints_Click);
            // 
            // OptionPanel
            // 
            this.OptionPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OptionPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OptionPanel.BackgroundImage")));
            this.OptionPanel.Controls.Add(this.buttonSoundOff);
            this.OptionPanel.Controls.Add(this.buttonBackOption);
            this.OptionPanel.Controls.Add(this.buttonSoundOn);
            this.OptionPanel.Controls.Add(this.buttonHighScore);
            this.OptionPanel.Location = new System.Drawing.Point(0, 0);
            this.OptionPanel.Name = "OptionPanel";
            this.OptionPanel.Size = new System.Drawing.Size(1103, 827);
            this.OptionPanel.TabIndex = 6;
            // 
            // buttonSoundOff
            // 
            this.buttonSoundOff.BackColor = System.Drawing.Color.Transparent;
            this.buttonSoundOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSoundOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSoundOff.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonSoundOff.FlatAppearance.BorderSize = 0;
            this.buttonSoundOff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonSoundOff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonSoundOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSoundOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSoundOff.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSoundOff.Location = new System.Drawing.Point(611, 679);
            this.buttonSoundOff.Name = "buttonSoundOff";
            this.buttonSoundOff.Size = new System.Drawing.Size(55, 55);
            this.buttonSoundOff.TabIndex = 5;
            this.buttonSoundOff.UseVisualStyleBackColor = false;
            this.buttonSoundOff.Click += new System.EventHandler(this.buttonSoundOff_Click);
            // 
            // buttonBackOption
            // 
            this.buttonBackOption.BackColor = System.Drawing.Color.Transparent;
            this.buttonBackOption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBackOption.FlatAppearance.BorderSize = 0;
            this.buttonBackOption.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonBackOption.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonBackOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackOption.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonBackOption.Location = new System.Drawing.Point(501, 620);
            this.buttonBackOption.Name = "buttonBackOption";
            this.buttonBackOption.Size = new System.Drawing.Size(114, 48);
            this.buttonBackOption.TabIndex = 3;
            this.buttonBackOption.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonBackOption.UseVisualStyleBackColor = false;
            this.buttonBackOption.Click += new System.EventHandler(this.buttonBackOption_Click);
            // 
            // buttonSoundOn
            // 
            this.buttonSoundOn.BackColor = System.Drawing.Color.Transparent;
            this.buttonSoundOn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSoundOn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSoundOn.FlatAppearance.BorderSize = 0;
            this.buttonSoundOn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonSoundOn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonSoundOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSoundOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSoundOn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSoundOn.Location = new System.Drawing.Point(433, 679);
            this.buttonSoundOn.Name = "buttonSoundOn";
            this.buttonSoundOn.Size = new System.Drawing.Size(55, 55);
            this.buttonSoundOn.TabIndex = 1;
            this.buttonSoundOn.UseVisualStyleBackColor = false;
            this.buttonSoundOn.Click += new System.EventHandler(this.buttonSoundOn_Click);
            // 
            // buttonHighScore
            // 
            this.buttonHighScore.BackColor = System.Drawing.Color.Transparent;
            this.buttonHighScore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHighScore.FlatAppearance.BorderSize = 0;
            this.buttonHighScore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonHighScore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonHighScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHighScore.Location = new System.Drawing.Point(426, 544);
            this.buttonHighScore.Name = "buttonHighScore";
            this.buttonHighScore.Size = new System.Drawing.Size(271, 54);
            this.buttonHighScore.TabIndex = 2;
            this.buttonHighScore.UseVisualStyleBackColor = false;
            this.buttonHighScore.Click += new System.EventHandler(this.buttonHighScore_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1099, 826);
            this.Controls.Add(this.MainMenuPanel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.Text = "Final Typing XIII";
            this.MainMenuPanel.ResumeLayout(false);
            this.StartGamePanel.ResumeLayout(false);
            this.TimeTrialPanel.ResumeLayout(false);
            this.OptionPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonOption;
        private System.Windows.Forms.Button buttonCredits;
        private System.Windows.Forms.Panel MainMenuPanel;
        private System.Windows.Forms.Panel StartGamePanel;
        private System.Windows.Forms.Button buttonTimeTrial;
        private System.Windows.Forms.Button buttonPoints;
        private System.Windows.Forms.Button buttonBackMenu;
        private System.Windows.Forms.Panel OptionPanel;
        private System.Windows.Forms.Button buttonSoundOff;
        private System.Windows.Forms.Button buttonBackOption;
        private System.Windows.Forms.Button buttonSoundOn;
        private System.Windows.Forms.Button buttonHighScore;
        private System.Windows.Forms.Panel TimeTrialPanel;
        private System.Windows.Forms.Button buttonBackTT;
        private System.Windows.Forms.Button HardTT;
        private System.Windows.Forms.Button MediumTT;
        private System.Windows.Forms.Button EasyTT;
    }
}

