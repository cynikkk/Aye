using System.Drawing;

namespace Aye
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.CmdButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CloseButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AyeLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.homeControl1 = new Aye.HomeControl();
            this.cmdControl1 = new Aye.CmdControl();
            this.settingsControl1 = new Aye.SettingsControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 4;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.CmdButton);
            this.panel1.Controls.Add(this.SettingsButton);
            this.panel1.Controls.Add(this.HomeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 487);
            this.panel1.TabIndex = 0;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.SidePanel.Location = new System.Drawing.Point(3, 76);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(13, 61);
            this.SidePanel.TabIndex = 4;
            // 
            // CmdButton
            // 
            this.CmdButton.FlatAppearance.BorderSize = 0;
            this.CmdButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdButton.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdButton.ForeColor = System.Drawing.Color.White;
            this.CmdButton.Image = ((System.Drawing.Image)(resources.GetObject("CmdButton.Image")));
            this.CmdButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CmdButton.Location = new System.Drawing.Point(18, 143);
            this.CmdButton.Name = "CmdButton";
            this.CmdButton.Size = new System.Drawing.Size(163, 61);
            this.CmdButton.TabIndex = 6;
            this.CmdButton.Text = "        Commandes";
            this.CmdButton.UseVisualStyleBackColor = true;
            this.CmdButton.Click += new System.EventHandler(this.CmdButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsButton.ForeColor = System.Drawing.Color.White;
            this.SettingsButton.Image = ((System.Drawing.Image)(resources.GetObject("SettingsButton.Image")));
            this.SettingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsButton.Location = new System.Drawing.Point(18, 210);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(163, 61);
            this.SettingsButton.TabIndex = 5;
            this.SettingsButton.Text = "        Paramètres";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton.ForeColor = System.Drawing.Color.White;
            this.HomeButton.Image = ((System.Drawing.Image)(resources.GetObject("HomeButton.Image")));
            this.HomeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeButton.Location = new System.Drawing.Point(18, 76);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(163, 61);
            this.HomeButton.TabIndex = 4;
            this.HomeButton.Text = "       Home";
            this.HomeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(166, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(795, 10);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 0;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.ImageActive = null;
            this.CloseButton.Location = new System.Drawing.Point(926, 1);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(42, 23);
            this.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseButton.TabIndex = 2;
            this.CloseButton.TabStop = false;
            this.CloseButton.Zoom = 10;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.AyeLabel);
            this.panel4.Location = new System.Drawing.Point(197, 33);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(81, 92);
            this.panel4.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // AyeLabel
            // 
            this.AyeLabel.AutoSize = true;
            this.AyeLabel.Font = new System.Drawing.Font("Adam", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AyeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.AyeLabel.Location = new System.Drawing.Point(15, 62);
            this.AyeLabel.Name = "AyeLabel";
            this.AyeLabel.Size = new System.Drawing.Size(50, 24);
            this.AyeLabel.TabIndex = 4;
            this.AyeLabel.Text = "Aye";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // homeControl1
            // 
            this.homeControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.homeControl1.Location = new System.Drawing.Point(173, 123);
            this.homeControl1.Margin = new System.Windows.Forms.Padding(4);
            this.homeControl1.Name = "homeControl1";
            this.homeControl1.Size = new System.Drawing.Size(774, 368);
            this.homeControl1.TabIndex = 6;
            // 
            // cmdControl1
            // 
            this.cmdControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cmdControl1.Location = new System.Drawing.Point(170, 132);
            this.cmdControl1.Margin = new System.Windows.Forms.Padding(4);
            this.cmdControl1.Name = "cmdControl1";
            this.cmdControl1.Size = new System.Drawing.Size(774, 368);
            this.cmdControl1.TabIndex = 5;
            // 
            // settingsControl1
            // 
            this.settingsControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.settingsControl1.Location = new System.Drawing.Point(170, 132);
            this.settingsControl1.Margin = new System.Windows.Forms.Padding(4);
            this.settingsControl1.Name = "settingsControl1";
            this.settingsControl1.Size = new System.Drawing.Size(774, 368);
            this.settingsControl1.TabIndex = 4;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(961, 512);
            this.Controls.Add(this.homeControl1);
            this.Controls.Add(this.cmdControl1);
            this.Controls.Add(this.settingsControl1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Adam", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.Text = "Aye - Intelligence Artificielle";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuImageButton CloseButton;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuCustomLabel AyeLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button CmdButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button HomeButton;
        private HomeControl homeControl1;
        private CmdControl cmdControl1;
        private SettingsControl settingsControl1;
    }
}

