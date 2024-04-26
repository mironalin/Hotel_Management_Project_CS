namespace HotelProject.Forms
{
    partial class RoomsFormResponsive
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
            this.panelTopRoom = new System.Windows.Forms.Panel();
            this.listViewRooms = new System.Windows.Forms.ListView();
            this.placeholder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RoomNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RoomType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RoomPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RoomStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelBottomRoom = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radBtnBusy = new System.Windows.Forms.RadioButton();
            this.radBtnFree = new System.Windows.Forms.RadioButton();
            this.comboBoxRoomType = new System.Windows.Forms.ComboBox();
            this.labelClearRoomDetails = new System.Windows.Forms.Label();
            this.labelDeleteRoom = new System.Windows.Forms.Label();
            this.labelUpdateRoom = new System.Windows.Forms.Label();
            this.labelSaveRoom = new System.Windows.Forms.Label();
            this.btnClearRoomDetails = new FontAwesome.Sharp.IconButton();
            this.btnDeleteRoom = new FontAwesome.Sharp.IconButton();
            this.btnUpdateRoom = new FontAwesome.Sharp.IconButton();
            this.btnSaveRoom = new FontAwesome.Sharp.IconButton();
            this.labelRoomStatus = new System.Windows.Forms.Label();
            this.labelRoomType = new System.Windows.Forms.Label();
            this.labelRoomPhone = new System.Windows.Forms.Label();
            this.labelRoomNumber = new System.Windows.Forms.Label();
            this.textBoxClientFirstName = new System.Windows.Forms.TextBox();
            this.textBoxClientID = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelTopRoom.SuspendLayout();
            this.panelBottomRoom.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panelTopRoom, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelBottomRoom, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1000, 500);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelTopRoom
            // 
            this.panelTopRoom.Controls.Add(this.listViewRooms);
            this.panelTopRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTopRoom.Location = new System.Drawing.Point(3, 3);
            this.panelTopRoom.Name = "panelTopRoom";
            this.panelTopRoom.Padding = new System.Windows.Forms.Padding(14);
            this.panelTopRoom.Size = new System.Drawing.Size(994, 244);
            this.panelTopRoom.TabIndex = 0;
            // 
            // listViewRooms
            // 
            this.listViewRooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.listViewRooms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewRooms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.placeholder,
            this.RoomNumber,
            this.RoomType,
            this.RoomPhone,
            this.RoomStatus});
            this.listViewRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewRooms.FullRowSelect = true;
            this.listViewRooms.HideSelection = false;
            this.listViewRooms.Location = new System.Drawing.Point(14, 14);
            this.listViewRooms.Name = "listViewRooms";
            this.listViewRooms.Size = new System.Drawing.Size(966, 216);
            this.listViewRooms.TabIndex = 1;
            this.listViewRooms.UseCompatibleStateImageBehavior = false;
            this.listViewRooms.View = System.Windows.Forms.View.Details;
            // 
            // placeholder
            // 
            this.placeholder.Text = "966/ ";
            this.placeholder.Width = 0;
            // 
            // RoomNumber
            // 
            this.RoomNumber.Text = "Room Number";
            this.RoomNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RoomNumber.Width = 246;
            // 
            // RoomType
            // 
            this.RoomType.Text = "Room Type";
            this.RoomType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RoomType.Width = 246;
            // 
            // RoomPhone
            // 
            this.RoomPhone.Text = "Room Phone";
            this.RoomPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RoomPhone.Width = 245;
            // 
            // RoomStatus
            // 
            this.RoomStatus.Text = "Room Status";
            this.RoomStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RoomStatus.Width = 245;
            // 
            // panelBottomRoom
            // 
            this.panelBottomRoom.Controls.Add(this.panel3);
            this.panelBottomRoom.Controls.Add(this.comboBoxRoomType);
            this.panelBottomRoom.Controls.Add(this.labelClearRoomDetails);
            this.panelBottomRoom.Controls.Add(this.labelDeleteRoom);
            this.panelBottomRoom.Controls.Add(this.labelUpdateRoom);
            this.panelBottomRoom.Controls.Add(this.labelSaveRoom);
            this.panelBottomRoom.Controls.Add(this.btnClearRoomDetails);
            this.panelBottomRoom.Controls.Add(this.btnDeleteRoom);
            this.panelBottomRoom.Controls.Add(this.btnUpdateRoom);
            this.panelBottomRoom.Controls.Add(this.btnSaveRoom);
            this.panelBottomRoom.Controls.Add(this.labelRoomStatus);
            this.panelBottomRoom.Controls.Add(this.labelRoomType);
            this.panelBottomRoom.Controls.Add(this.labelRoomPhone);
            this.panelBottomRoom.Controls.Add(this.labelRoomNumber);
            this.panelBottomRoom.Controls.Add(this.textBoxClientFirstName);
            this.panelBottomRoom.Controls.Add(this.textBoxClientID);
            this.panelBottomRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottomRoom.Location = new System.Drawing.Point(3, 253);
            this.panelBottomRoom.Name = "panelBottomRoom";
            this.panelBottomRoom.Size = new System.Drawing.Size(994, 244);
            this.panelBottomRoom.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.Controls.Add(this.radBtnBusy);
            this.panel3.Controls.Add(this.radBtnFree);
            this.panel3.Location = new System.Drawing.Point(677, 64);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(132, 21);
            this.panel3.TabIndex = 63;
            // 
            // radBtnBusy
            // 
            this.radBtnBusy.AutoSize = true;
            this.radBtnBusy.Dock = System.Windows.Forms.DockStyle.Right;
            this.radBtnBusy.ForeColor = System.Drawing.Color.Gainsboro;
            this.radBtnBusy.Location = new System.Drawing.Point(77, 0);
            this.radBtnBusy.Margin = new System.Windows.Forms.Padding(0);
            this.radBtnBusy.Name = "radBtnBusy";
            this.radBtnBusy.Size = new System.Drawing.Size(55, 21);
            this.radBtnBusy.TabIndex = 1;
            this.radBtnBusy.TabStop = true;
            this.radBtnBusy.Text = "Busy";
            this.radBtnBusy.UseVisualStyleBackColor = true;
            // 
            // radBtnFree
            // 
            this.radBtnFree.AutoSize = true;
            this.radBtnFree.Dock = System.Windows.Forms.DockStyle.Left;
            this.radBtnFree.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.radBtnFree.ForeColor = System.Drawing.Color.Gainsboro;
            this.radBtnFree.Location = new System.Drawing.Point(0, 0);
            this.radBtnFree.Name = "radBtnFree";
            this.radBtnFree.Size = new System.Drawing.Size(54, 21);
            this.radBtnFree.TabIndex = 0;
            this.radBtnFree.TabStop = true;
            this.radBtnFree.Text = "Free";
            this.radBtnFree.UseVisualStyleBackColor = true;
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
            this.comboBoxRoomType.Location = new System.Drawing.Point(677, 19);
            this.comboBoxRoomType.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxRoomType.Name = "comboBoxRoomType";
            this.comboBoxRoomType.Size = new System.Drawing.Size(132, 24);
            this.comboBoxRoomType.TabIndex = 62;
            // 
            // labelClearRoomDetails
            // 
            this.labelClearRoomDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelClearRoomDetails.AutoSize = true;
            this.labelClearRoomDetails.BackColor = System.Drawing.Color.Transparent;
            this.labelClearRoomDetails.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClearRoomDetails.ForeColor = System.Drawing.Color.Transparent;
            this.labelClearRoomDetails.Location = new System.Drawing.Point(625, 212);
            this.labelClearRoomDetails.Name = "labelClearRoomDetails";
            this.labelClearRoomDetails.Size = new System.Drawing.Size(34, 14);
            this.labelClearRoomDetails.TabIndex = 61;
            this.labelClearRoomDetails.Text = "Clear";
            // 
            // labelDeleteRoom
            // 
            this.labelDeleteRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDeleteRoom.AutoSize = true;
            this.labelDeleteRoom.BackColor = System.Drawing.Color.Transparent;
            this.labelDeleteRoom.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeleteRoom.ForeColor = System.Drawing.Color.Transparent;
            this.labelDeleteRoom.Location = new System.Drawing.Point(528, 212);
            this.labelDeleteRoom.Name = "labelDeleteRoom";
            this.labelDeleteRoom.Size = new System.Drawing.Size(40, 14);
            this.labelDeleteRoom.TabIndex = 60;
            this.labelDeleteRoom.Text = "Delete";
            // 
            // labelUpdateRoom
            // 
            this.labelUpdateRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUpdateRoom.AutoSize = true;
            this.labelUpdateRoom.BackColor = System.Drawing.Color.Transparent;
            this.labelUpdateRoom.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpdateRoom.ForeColor = System.Drawing.Color.Transparent;
            this.labelUpdateRoom.Location = new System.Drawing.Point(434, 212);
            this.labelUpdateRoom.Name = "labelUpdateRoom";
            this.labelUpdateRoom.Size = new System.Drawing.Size(45, 14);
            this.labelUpdateRoom.TabIndex = 59;
            this.labelUpdateRoom.Text = "Update";
            // 
            // labelSaveRoom
            // 
            this.labelSaveRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSaveRoom.AutoSize = true;
            this.labelSaveRoom.BackColor = System.Drawing.Color.Transparent;
            this.labelSaveRoom.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaveRoom.ForeColor = System.Drawing.Color.Transparent;
            this.labelSaveRoom.Location = new System.Drawing.Point(358, 212);
            this.labelSaveRoom.Name = "labelSaveRoom";
            this.labelSaveRoom.Size = new System.Drawing.Size(32, 14);
            this.labelSaveRoom.TabIndex = 58;
            this.labelSaveRoom.Text = "Save";
            // 
            // btnClearRoomDetails
            // 
            this.btnClearRoomDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClearRoomDetails.BackColor = System.Drawing.Color.Transparent;
            this.btnClearRoomDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClearRoomDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearRoomDetails.FlatAppearance.BorderSize = 0;
            this.btnClearRoomDetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClearRoomDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClearRoomDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearRoomDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(47)))), ((int)(((byte)(54)))));
            this.btnClearRoomDetails.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnClearRoomDetails.IconColor = System.Drawing.Color.Gainsboro;
            this.btnClearRoomDetails.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClearRoomDetails.IconSize = 50;
            this.btnClearRoomDetails.Location = new System.Drawing.Point(614, 168);
            this.btnClearRoomDetails.Name = "btnClearRoomDetails";
            this.btnClearRoomDetails.Size = new System.Drawing.Size(48, 48);
            this.btnClearRoomDetails.TabIndex = 57;
            this.btnClearRoomDetails.UseVisualStyleBackColor = false;
            // 
            // btnDeleteRoom
            // 
            this.btnDeleteRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteRoom.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDeleteRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteRoom.FlatAppearance.BorderSize = 0;
            this.btnDeleteRoom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDeleteRoom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDeleteRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(47)))), ((int)(((byte)(54)))));
            this.btnDeleteRoom.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDeleteRoom.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDeleteRoom.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteRoom.IconSize = 46;
            this.btnDeleteRoom.Location = new System.Drawing.Point(524, 168);
            this.btnDeleteRoom.Name = "btnDeleteRoom";
            this.btnDeleteRoom.Size = new System.Drawing.Size(48, 48);
            this.btnDeleteRoom.TabIndex = 56;
            this.btnDeleteRoom.UseVisualStyleBackColor = false;
            // 
            // btnUpdateRoom
            // 
            this.btnUpdateRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateRoom.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdateRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateRoom.FlatAppearance.BorderSize = 0;
            this.btnUpdateRoom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUpdateRoom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUpdateRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(47)))), ((int)(((byte)(54)))));
            this.btnUpdateRoom.IconChar = FontAwesome.Sharp.IconChar.ArrowsRotate;
            this.btnUpdateRoom.IconColor = System.Drawing.Color.Gainsboro;
            this.btnUpdateRoom.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdateRoom.IconSize = 50;
            this.btnUpdateRoom.Location = new System.Drawing.Point(434, 168);
            this.btnUpdateRoom.Name = "btnUpdateRoom";
            this.btnUpdateRoom.Size = new System.Drawing.Size(48, 48);
            this.btnUpdateRoom.TabIndex = 55;
            this.btnUpdateRoom.UseVisualStyleBackColor = false;
            // 
            // btnSaveRoom
            // 
            this.btnSaveRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveRoom.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSaveRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveRoom.FlatAppearance.BorderSize = 0;
            this.btnSaveRoom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSaveRoom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSaveRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(47)))), ((int)(((byte)(54)))));
            this.btnSaveRoom.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnSaveRoom.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSaveRoom.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSaveRoom.Location = new System.Drawing.Point(349, 168);
            this.btnSaveRoom.Name = "btnSaveRoom";
            this.btnSaveRoom.Size = new System.Drawing.Size(48, 48);
            this.btnSaveRoom.TabIndex = 54;
            this.btnSaveRoom.UseVisualStyleBackColor = false;
            // 
            // labelRoomStatus
            // 
            this.labelRoomStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRoomStatus.AutoSize = true;
            this.labelRoomStatus.BackColor = System.Drawing.Color.Transparent;
            this.labelRoomStatus.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoomStatus.ForeColor = System.Drawing.Color.Transparent;
            this.labelRoomStatus.Location = new System.Drawing.Point(584, 66);
            this.labelRoomStatus.Name = "labelRoomStatus";
            this.labelRoomStatus.Size = new System.Drawing.Size(86, 16);
            this.labelRoomStatus.TabIndex = 52;
            this.labelRoomStatus.Text = "Room Status";
            // 
            // labelRoomType
            // 
            this.labelRoomType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRoomType.AutoSize = true;
            this.labelRoomType.BackColor = System.Drawing.Color.Transparent;
            this.labelRoomType.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoomType.ForeColor = System.Drawing.Color.Transparent;
            this.labelRoomType.Location = new System.Drawing.Point(595, 21);
            this.labelRoomType.Name = "labelRoomType";
            this.labelRoomType.Size = new System.Drawing.Size(76, 16);
            this.labelRoomType.TabIndex = 51;
            this.labelRoomType.Text = "Room Type";
            // 
            // labelRoomPhone
            // 
            this.labelRoomPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRoomPhone.AutoSize = true;
            this.labelRoomPhone.BackColor = System.Drawing.Color.Transparent;
            this.labelRoomPhone.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoomPhone.ForeColor = System.Drawing.Color.Transparent;
            this.labelRoomPhone.Location = new System.Drawing.Point(173, 68);
            this.labelRoomPhone.Name = "labelRoomPhone";
            this.labelRoomPhone.Size = new System.Drawing.Size(86, 16);
            this.labelRoomPhone.TabIndex = 49;
            this.labelRoomPhone.Text = "Room Phone";
            // 
            // labelRoomNumber
            // 
            this.labelRoomNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRoomNumber.AutoSize = true;
            this.labelRoomNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelRoomNumber.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoomNumber.ForeColor = System.Drawing.Color.Transparent;
            this.labelRoomNumber.Location = new System.Drawing.Point(163, 19);
            this.labelRoomNumber.Name = "labelRoomNumber";
            this.labelRoomNumber.Size = new System.Drawing.Size(96, 16);
            this.labelRoomNumber.TabIndex = 48;
            this.labelRoomNumber.Text = "Room Number";
            this.labelRoomNumber.Click += new System.EventHandler(this.labelRoomNumber_Click);
            // 
            // textBoxClientFirstName
            // 
            this.textBoxClientFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxClientFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.textBoxClientFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxClientFirstName.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxClientFirstName.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxClientFirstName.Location = new System.Drawing.Point(266, 68);
            this.textBoxClientFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxClientFirstName.Name = "textBoxClientFirstName";
            this.textBoxClientFirstName.Size = new System.Drawing.Size(132, 21);
            this.textBoxClientFirstName.TabIndex = 43;
            // 
            // textBoxClientID
            // 
            this.textBoxClientID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxClientID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.textBoxClientID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxClientID.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxClientID.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxClientID.Location = new System.Drawing.Point(266, 19);
            this.textBoxClientID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxClientID.Name = "textBoxClientID";
            this.textBoxClientID.Size = new System.Drawing.Size(132, 21);
            this.textBoxClientID.TabIndex = 42;
            // 
            // RoomsFormResponsive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(47)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RoomsFormResponsive";
            this.Text = "Rooms";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelTopRoom.ResumeLayout(false);
            this.panelBottomRoom.ResumeLayout(false);
            this.panelBottomRoom.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelTopRoom;
        private System.Windows.Forms.ListView listViewRooms;
        private System.Windows.Forms.ColumnHeader placeholder;
        private System.Windows.Forms.ColumnHeader RoomNumber;
        private System.Windows.Forms.ColumnHeader RoomType;
        private System.Windows.Forms.ColumnHeader RoomPhone;
        private System.Windows.Forms.ColumnHeader RoomStatus;
        private System.Windows.Forms.Panel panelBottomRoom;
        private System.Windows.Forms.Label labelClearRoomDetails;
        private System.Windows.Forms.Label labelDeleteRoom;
        private System.Windows.Forms.Label labelUpdateRoom;
        private System.Windows.Forms.Label labelSaveRoom;
        private FontAwesome.Sharp.IconButton btnClearRoomDetails;
        private FontAwesome.Sharp.IconButton btnDeleteRoom;
        private FontAwesome.Sharp.IconButton btnUpdateRoom;
        private FontAwesome.Sharp.IconButton btnSaveRoom;
        private System.Windows.Forms.Label labelRoomStatus;
        private System.Windows.Forms.Label labelRoomType;
        private System.Windows.Forms.Label labelRoomPhone;
        private System.Windows.Forms.Label labelRoomNumber;
        private System.Windows.Forms.TextBox textBoxClientFirstName;
        private System.Windows.Forms.TextBox textBoxClientID;
        private System.Windows.Forms.ComboBox comboBoxRoomType;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radBtnBusy;
        private System.Windows.Forms.RadioButton radBtnFree;
    }
}