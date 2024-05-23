namespace HotelProject
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconButtonDashboard = new FontAwesome.Sharp.IconButton();
            this.iconButtonReservations = new FontAwesome.Sharp.IconButton();
            this.iconButtonClients = new FontAwesome.Sharp.IconButton();
            this.iconButtonRooms = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new FontAwesome.Sharp.IconPictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.btnMaximize = new FontAwesome.Sharp.IconPictureBox();
            this.btnExit = new FontAwesome.Sharp.IconPictureBox();
            this.labelTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.serializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(51)))));
            this.panelMenu.Controls.Add(this.iconButtonDashboard);
            this.panelMenu.Controls.Add(this.iconButtonReservations);
            this.panelMenu.Controls.Add(this.iconButtonClients);
            this.panelMenu.Controls.Add(this.iconButtonRooms);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(257, 591);
            this.panelMenu.TabIndex = 0;
            // 
            // iconButtonDashboard
            // 
            this.iconButtonDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(51)))));
            this.iconButtonDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonDashboard.FlatAppearance.BorderSize = 0;
            this.iconButtonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonDashboard.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonDashboard.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.iconButtonDashboard.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonDashboard.IconSize = 32;
            this.iconButtonDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonDashboard.Location = new System.Drawing.Point(0, 346);
            this.iconButtonDashboard.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.iconButtonDashboard.Name = "iconButtonDashboard";
            this.iconButtonDashboard.Padding = new System.Windows.Forms.Padding(12, 0, 23, 0);
            this.iconButtonDashboard.Size = new System.Drawing.Size(257, 65);
            this.iconButtonDashboard.TabIndex = 4;
            this.iconButtonDashboard.Text = "Dashboard";
            this.iconButtonDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonDashboard.UseVisualStyleBackColor = false;
            this.iconButtonDashboard.Click += new System.EventHandler(this.iconButtonDashboard_Click);
            // 
            // iconButtonReservations
            // 
            this.iconButtonReservations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(51)))));
            this.iconButtonReservations.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonReservations.FlatAppearance.BorderSize = 0;
            this.iconButtonReservations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonReservations.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonReservations.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonReservations.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.iconButtonReservations.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonReservations.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonReservations.IconSize = 32;
            this.iconButtonReservations.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonReservations.Location = new System.Drawing.Point(0, 281);
            this.iconButtonReservations.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.iconButtonReservations.Name = "iconButtonReservations";
            this.iconButtonReservations.Padding = new System.Windows.Forms.Padding(12, 0, 23, 0);
            this.iconButtonReservations.Size = new System.Drawing.Size(257, 65);
            this.iconButtonReservations.TabIndex = 3;
            this.iconButtonReservations.Text = "Reservations";
            this.iconButtonReservations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonReservations.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonReservations.UseVisualStyleBackColor = false;
            this.iconButtonReservations.Click += new System.EventHandler(this.iconButtonReservations_Click);
            // 
            // iconButtonClients
            // 
            this.iconButtonClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(51)))));
            this.iconButtonClients.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonClients.FlatAppearance.BorderSize = 0;
            this.iconButtonClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonClients.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonClients.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonClients.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.iconButtonClients.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonClients.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonClients.IconSize = 32;
            this.iconButtonClients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonClients.Location = new System.Drawing.Point(0, 216);
            this.iconButtonClients.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.iconButtonClients.Name = "iconButtonClients";
            this.iconButtonClients.Padding = new System.Windows.Forms.Padding(12, 0, 23, 0);
            this.iconButtonClients.Size = new System.Drawing.Size(257, 65);
            this.iconButtonClients.TabIndex = 2;
            this.iconButtonClients.Text = "Clients";
            this.iconButtonClients.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonClients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonClients.UseVisualStyleBackColor = false;
            this.iconButtonClients.Click += new System.EventHandler(this.iconButtonClients_Click);
            // 
            // iconButtonRooms
            // 
            this.iconButtonRooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(51)))));
            this.iconButtonRooms.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonRooms.FlatAppearance.BorderSize = 0;
            this.iconButtonRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonRooms.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonRooms.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonRooms.IconChar = FontAwesome.Sharp.IconChar.Bed;
            this.iconButtonRooms.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonRooms.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonRooms.IconSize = 32;
            this.iconButtonRooms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonRooms.Location = new System.Drawing.Point(0, 151);
            this.iconButtonRooms.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.iconButtonRooms.Name = "iconButtonRooms";
            this.iconButtonRooms.Padding = new System.Windows.Forms.Padding(12, 0, 23, 0);
            this.iconButtonRooms.Size = new System.Drawing.Size(257, 65);
            this.iconButtonRooms.TabIndex = 1;
            this.iconButtonRooms.Text = "Rooms";
            this.iconButtonRooms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonRooms.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonRooms.UseVisualStyleBackColor = false;
            this.iconButtonRooms.Click += new System.EventHandler(this.iconButtonRooms_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(51)))));
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(257, 151);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(51)))));
            this.btnHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.Hotel;
            this.btnHome.IconColor = System.Drawing.Color.Gainsboro;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 124;
            this.btnHome.Location = new System.Drawing.Point(26, 19);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(202, 124);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnExit);
            this.panelTitleBar.Controls.Add(this.labelTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(257, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1000, 81);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.btnMinimize.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 27;
            this.btnMinimize.Location = new System.Drawing.Point(897, 3);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(29, 27);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.WaitOnLoad = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.btnMaximize.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.CompressAlt;
            this.btnMaximize.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 27;
            this.btnMaximize.Location = new System.Drawing.Point(933, 4);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(29, 27);
            this.btnMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.WaitOnLoad = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.btnExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnExit.IconColor = System.Drawing.Color.Gainsboro;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 27;
            this.btnExit.Location = new System.Drawing.Point(967, 3);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(29, 27);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnExit.TabIndex = 2;
            this.btnExit.TabStop = false;
            this.btnExit.WaitOnLoad = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labelTitleChildForm
            // 
            this.labelTitleChildForm.AutoSize = true;
            this.labelTitleChildForm.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTitleChildForm.Location = new System.Drawing.Point(56, 39);
            this.labelTitleChildForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitleChildForm.Name = "labelTitleChildForm";
            this.labelTitleChildForm.Size = new System.Drawing.Size(38, 14);
            this.labelTitleChildForm.TabIndex = 1;
            this.labelTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.DarkSlateGray;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 34;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(18, 29);
            this.iconCurrentChildForm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(37, 34);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelDesktop
            // 
            this.panelDesktop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(47)))), ((int)(((byte)(54)))));
            this.panelDesktop.Controls.Add(this.menuStrip1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(257, 81);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1000, 510);
            this.panelDesktop.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(51)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializeToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1000, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // serializeToolStripMenuItem
            // 
            this.serializeToolStripMenuItem.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serializeToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.serializeToolStripMenuItem.Name = "serializeToolStripMenuItem";
            this.serializeToolStripMenuItem.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.serializeToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.serializeToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1257, 591);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Management";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton iconButtonRooms;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private FontAwesome.Sharp.IconButton iconButtonDashboard;
        private FontAwesome.Sharp.IconButton iconButtonReservations;
        private FontAwesome.Sharp.IconButton iconButtonClients;
        private FontAwesome.Sharp.IconPictureBox btnHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label labelTitleChildForm;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconPictureBox btnExit;
        private FontAwesome.Sharp.IconPictureBox btnMinimize;
        private FontAwesome.Sharp.IconPictureBox btnMaximize;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem serializeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
    }
}

