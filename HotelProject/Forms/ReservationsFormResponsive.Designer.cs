namespace HotelProject.Forms
{
    partial class ReservationsFormResponsive
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.placeholder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReservationID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReservationClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReservationRoom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReservationCheckInDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReservationCheckOutDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpCheckInDate = new System.Windows.Forms.DateTimePicker();
            this.tbReservationID = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBoxRoomType = new System.Windows.Forms.ComboBox();
            this.lblReservationID = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.lblCheckInDate = new System.Windows.Forms.Label();
            this.dtpCheckOutDate = new System.Windows.Forms.DateTimePicker();
            this.lblCheckOutDate = new System.Windows.Forms.Label();
            this.labelClearClientDetails = new System.Windows.Forms.Label();
            this.labelDeleteClient = new System.Windows.Forms.Label();
            this.labelUpdateClient = new System.Windows.Forms.Label();
            this.labelSaveClient = new System.Windows.Forms.Label();
            this.btnClearClientDetails = new FontAwesome.Sharp.IconButton();
            this.btnDeleteClient = new FontAwesome.Sharp.IconButton();
            this.btnUpdateClient = new FontAwesome.Sharp.IconButton();
            this.btnSaveClient = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1000, 500);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(14);
            this.panel1.Size = new System.Drawing.Size(994, 244);
            this.panel1.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.placeholder,
            this.ReservationID,
            this.ReservationClient,
            this.ReservationRoom,
            this.ReservationCheckInDate,
            this.ReservationCheckOutDate});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(14, 14);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(966, 216);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // placeholder
            // 
            this.placeholder.Text = "";
            this.placeholder.Width = 0;
            // 
            // ReservationID
            // 
            this.ReservationID.Text = "Reservation ID";
            this.ReservationID.Width = 196;
            // 
            // ReservationClient
            // 
            this.ReservationClient.Text = "Client";
            this.ReservationClient.Width = 196;
            // 
            // ReservationRoom
            // 
            this.ReservationRoom.Text = "Room";
            this.ReservationRoom.Width = 196;
            // 
            // ReservationCheckInDate
            // 
            this.ReservationCheckInDate.Text = "Check In Date";
            this.ReservationCheckInDate.Width = 196;
            // 
            // ReservationCheckOutDate
            // 
            this.ReservationCheckOutDate.Text = "Check Out Date";
            this.ReservationCheckOutDate.Width = 198;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelClearClientDetails);
            this.panel2.Controls.Add(this.labelDeleteClient);
            this.panel2.Controls.Add(this.labelUpdateClient);
            this.panel2.Controls.Add(this.labelSaveClient);
            this.panel2.Controls.Add(this.btnClearClientDetails);
            this.panel2.Controls.Add(this.btnDeleteClient);
            this.panel2.Controls.Add(this.btnUpdateClient);
            this.panel2.Controls.Add(this.btnSaveClient);
            this.panel2.Controls.Add(this.lblCheckOutDate);
            this.panel2.Controls.Add(this.dtpCheckOutDate);
            this.panel2.Controls.Add(this.lblCheckInDate);
            this.panel2.Controls.Add(this.lblClient);
            this.panel2.Controls.Add(this.lblRoom);
            this.panel2.Controls.Add(this.lblReservationID);
            this.panel2.Controls.Add(this.dtpCheckInDate);
            this.panel2.Controls.Add(this.tbReservationID);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.comboBoxRoomType);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 253);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(994, 244);
            this.panel2.TabIndex = 1;
            // 
            // dtpCheckInDate
            // 
            this.dtpCheckInDate.CalendarFont = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckInDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.dtpCheckInDate.Location = new System.Drawing.Point(197, 118);
            this.dtpCheckInDate.Name = "dtpCheckInDate";
            this.dtpCheckInDate.Size = new System.Drawing.Size(232, 23);
            this.dtpCheckInDate.TabIndex = 66;
            this.dtpCheckInDate.ValueChanged += new System.EventHandler(this.dtpCheckInDate_ValueChanged);
            // 
            // tbReservationID
            // 
            this.tbReservationID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbReservationID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.tbReservationID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbReservationID.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReservationID.ForeColor = System.Drawing.Color.Gainsboro;
            this.tbReservationID.Location = new System.Drawing.Point(197, 39);
            this.tbReservationID.Margin = new System.Windows.Forms.Padding(4);
            this.tbReservationID.Multiline = true;
            this.tbReservationID.Name = "tbReservationID";
            this.tbReservationID.Size = new System.Drawing.Size(132, 23);
            this.tbReservationID.TabIndex = 65;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.ItemHeight = 16;
            this.comboBox1.Location = new System.Drawing.Point(655, 39);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(132, 24);
            this.comboBox1.TabIndex = 64;
            // 
            // comboBoxRoomType
            // 
            this.comboBoxRoomType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxRoomType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.comboBoxRoomType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxRoomType.ForeColor = System.Drawing.Color.Gainsboro;
            this.comboBoxRoomType.FormattingEnabled = true;
            this.comboBoxRoomType.IntegralHeight = false;
            this.comboBoxRoomType.ItemHeight = 16;
            this.comboBoxRoomType.Location = new System.Drawing.Point(426, 39);
            this.comboBoxRoomType.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxRoomType.Name = "comboBoxRoomType";
            this.comboBoxRoomType.Size = new System.Drawing.Size(132, 24);
            this.comboBoxRoomType.TabIndex = 63;
            // 
            // lblReservationID
            // 
            this.lblReservationID.AutoSize = true;
            this.lblReservationID.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblReservationID.Location = new System.Drawing.Point(217, 22);
            this.lblReservationID.Name = "lblReservationID";
            this.lblReservationID.Size = new System.Drawing.Size(97, 16);
            this.lblReservationID.TabIndex = 68;
            this.lblReservationID.Text = "Reservation ID";
            this.lblReservationID.Click += new System.EventHandler(this.lblReservationID_Click);
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblRoom.Location = new System.Drawing.Point(471, 18);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(42, 16);
            this.lblRoom.TabIndex = 69;
            this.lblRoom.Text = "Room";
            this.lblRoom.Click += new System.EventHandler(this.lblRoom_Click);
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblClient.Location = new System.Drawing.Point(702, 18);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(43, 16);
            this.lblClient.TabIndex = 70;
            this.lblClient.Text = "Client";
            this.lblClient.Click += new System.EventHandler(this.lblClient_Click);
            // 
            // lblCheckInDate
            // 
            this.lblCheckInDate.AutoSize = true;
            this.lblCheckInDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCheckInDate.Location = new System.Drawing.Point(287, 99);
            this.lblCheckInDate.Name = "lblCheckInDate";
            this.lblCheckInDate.Size = new System.Drawing.Size(94, 16);
            this.lblCheckInDate.TabIndex = 71;
            this.lblCheckInDate.Text = "Check In Date";
            this.lblCheckInDate.Click += new System.EventHandler(this.lblCheckInDate_Click);
            // 
            // dtpCheckOutDate
            // 
            this.dtpCheckOutDate.CalendarFont = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckOutDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.dtpCheckOutDate.Location = new System.Drawing.Point(555, 118);
            this.dtpCheckOutDate.Name = "dtpCheckOutDate";
            this.dtpCheckOutDate.Size = new System.Drawing.Size(232, 23);
            this.dtpCheckOutDate.TabIndex = 72;
            // 
            // lblCheckOutDate
            // 
            this.lblCheckOutDate.AutoSize = true;
            this.lblCheckOutDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCheckOutDate.Location = new System.Drawing.Point(625, 99);
            this.lblCheckOutDate.Name = "lblCheckOutDate";
            this.lblCheckOutDate.Size = new System.Drawing.Size(106, 16);
            this.lblCheckOutDate.TabIndex = 73;
            this.lblCheckOutDate.Text = "Check Out Date";
            // 
            // labelClearClientDetails
            // 
            this.labelClearClientDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelClearClientDetails.AutoSize = true;
            this.labelClearClientDetails.BackColor = System.Drawing.Color.Transparent;
            this.labelClearClientDetails.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClearClientDetails.ForeColor = System.Drawing.Color.Transparent;
            this.labelClearClientDetails.Location = new System.Drawing.Point(625, 212);
            this.labelClearClientDetails.Name = "labelClearClientDetails";
            this.labelClearClientDetails.Size = new System.Drawing.Size(34, 14);
            this.labelClearClientDetails.TabIndex = 81;
            this.labelClearClientDetails.Text = "Clear";
            // 
            // labelDeleteClient
            // 
            this.labelDeleteClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDeleteClient.AutoSize = true;
            this.labelDeleteClient.BackColor = System.Drawing.Color.Transparent;
            this.labelDeleteClient.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeleteClient.ForeColor = System.Drawing.Color.Transparent;
            this.labelDeleteClient.Location = new System.Drawing.Point(528, 212);
            this.labelDeleteClient.Name = "labelDeleteClient";
            this.labelDeleteClient.Size = new System.Drawing.Size(40, 14);
            this.labelDeleteClient.TabIndex = 80;
            this.labelDeleteClient.Text = "Delete";
            // 
            // labelUpdateClient
            // 
            this.labelUpdateClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUpdateClient.AutoSize = true;
            this.labelUpdateClient.BackColor = System.Drawing.Color.Transparent;
            this.labelUpdateClient.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpdateClient.ForeColor = System.Drawing.Color.Transparent;
            this.labelUpdateClient.Location = new System.Drawing.Point(434, 212);
            this.labelUpdateClient.Name = "labelUpdateClient";
            this.labelUpdateClient.Size = new System.Drawing.Size(45, 14);
            this.labelUpdateClient.TabIndex = 79;
            this.labelUpdateClient.Text = "Update";
            // 
            // labelSaveClient
            // 
            this.labelSaveClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSaveClient.AutoSize = true;
            this.labelSaveClient.BackColor = System.Drawing.Color.Transparent;
            this.labelSaveClient.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaveClient.ForeColor = System.Drawing.Color.Transparent;
            this.labelSaveClient.Location = new System.Drawing.Point(358, 212);
            this.labelSaveClient.Name = "labelSaveClient";
            this.labelSaveClient.Size = new System.Drawing.Size(32, 14);
            this.labelSaveClient.TabIndex = 78;
            this.labelSaveClient.Text = "Save";
            // 
            // btnClearClientDetails
            // 
            this.btnClearClientDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClearClientDetails.BackColor = System.Drawing.Color.Transparent;
            this.btnClearClientDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClearClientDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearClientDetails.FlatAppearance.BorderSize = 0;
            this.btnClearClientDetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClearClientDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClearClientDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearClientDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(47)))), ((int)(((byte)(54)))));
            this.btnClearClientDetails.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnClearClientDetails.IconColor = System.Drawing.Color.Gainsboro;
            this.btnClearClientDetails.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClearClientDetails.IconSize = 50;
            this.btnClearClientDetails.Location = new System.Drawing.Point(614, 170);
            this.btnClearClientDetails.Name = "btnClearClientDetails";
            this.btnClearClientDetails.Size = new System.Drawing.Size(48, 45);
            this.btnClearClientDetails.TabIndex = 77;
            this.btnClearClientDetails.UseVisualStyleBackColor = false;
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteClient.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDeleteClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteClient.FlatAppearance.BorderSize = 0;
            this.btnDeleteClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDeleteClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDeleteClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(47)))), ((int)(((byte)(54)))));
            this.btnDeleteClient.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDeleteClient.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDeleteClient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteClient.IconSize = 46;
            this.btnDeleteClient.Location = new System.Drawing.Point(524, 170);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(48, 45);
            this.btnDeleteClient.TabIndex = 76;
            this.btnDeleteClient.UseVisualStyleBackColor = false;
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateClient.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdateClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateClient.FlatAppearance.BorderSize = 0;
            this.btnUpdateClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUpdateClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUpdateClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(47)))), ((int)(((byte)(54)))));
            this.btnUpdateClient.IconChar = FontAwesome.Sharp.IconChar.ArrowsRotate;
            this.btnUpdateClient.IconColor = System.Drawing.Color.Gainsboro;
            this.btnUpdateClient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdateClient.IconSize = 50;
            this.btnUpdateClient.Location = new System.Drawing.Point(434, 170);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.Size = new System.Drawing.Size(48, 45);
            this.btnUpdateClient.TabIndex = 75;
            this.btnUpdateClient.UseVisualStyleBackColor = false;
            // 
            // btnSaveClient
            // 
            this.btnSaveClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveClient.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSaveClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveClient.FlatAppearance.BorderSize = 0;
            this.btnSaveClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSaveClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSaveClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(47)))), ((int)(((byte)(54)))));
            this.btnSaveClient.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnSaveClient.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSaveClient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSaveClient.Location = new System.Drawing.Point(349, 170);
            this.btnSaveClient.Name = "btnSaveClient";
            this.btnSaveClient.Size = new System.Drawing.Size(48, 45);
            this.btnSaveClient.TabIndex = 74;
            this.btnSaveClient.UseVisualStyleBackColor = false;
            // 
            // ReservationsFormResponsive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(47)))), ((int)(((byte)(54)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Inter", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "ReservationsFormResponsive";
            this.Text = "Reservations";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader placeholder;
        private System.Windows.Forms.ColumnHeader ReservationID;
        private System.Windows.Forms.ColumnHeader ReservationClient;
        private System.Windows.Forms.ColumnHeader ReservationRoom;
        private System.Windows.Forms.ColumnHeader ReservationCheckInDate;
        private System.Windows.Forms.ColumnHeader ReservationCheckOutDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBoxRoomType;
        private System.Windows.Forms.TextBox tbReservationID;
        private System.Windows.Forms.DateTimePicker dtpCheckInDate;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Label lblReservationID;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label lblCheckInDate;
        private System.Windows.Forms.DateTimePicker dtpCheckOutDate;
        private System.Windows.Forms.Label lblCheckOutDate;
        private System.Windows.Forms.Label labelClearClientDetails;
        private System.Windows.Forms.Label labelDeleteClient;
        private System.Windows.Forms.Label labelUpdateClient;
        private System.Windows.Forms.Label labelSaveClient;
        private FontAwesome.Sharp.IconButton btnClearClientDetails;
        private FontAwesome.Sharp.IconButton btnDeleteClient;
        private FontAwesome.Sharp.IconButton btnUpdateClient;
        private FontAwesome.Sharp.IconButton btnSaveClient;
    }
}