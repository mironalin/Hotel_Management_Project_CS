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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelTopRoom = new System.Windows.Forms.Panel();
            this.dataGridView_Reservation = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panelBottomRoom = new System.Windows.Forms.Panel();
            this.labelCheckOutDate = new System.Windows.Forms.Label();
            this.labelCheckInDate = new System.Windows.Forms.Label();
            this.dateTimePickerCheckOutDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dateTimePickerCheckInDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.comboBoxClientId = new Guna.UI2.WinForms.Guna2ComboBox();
            this.labelClient = new System.Windows.Forms.Label();
            this.comboBoxRoomId = new Guna.UI2.WinForms.Guna2ComboBox();
            this.labelRoom = new System.Windows.Forms.Label();
            this.labelClearClientRoom = new System.Windows.Forms.Label();
            this.labelDeleteRoom = new System.Windows.Forms.Label();
            this.labelUpdateRoom = new System.Windows.Forms.Label();
            this.labelSaveRoom = new System.Windows.Forms.Label();
            this.btnClearReservationDetails = new FontAwesome.Sharp.IconButton();
            this.btnDeleteReservation = new FontAwesome.Sharp.IconButton();
            this.btnUpdateClient = new FontAwesome.Sharp.IconButton();
            this.btnSaveReservation = new FontAwesome.Sharp.IconButton();
            this.textboxReservationID = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelReservation = new System.Windows.Forms.Label();
            this.errPrvReservationID = new System.Windows.Forms.ErrorProvider(this.components);
            this.roomsContextMenuStrip = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.reservationsSerialize = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationsSerializeBinary = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationsSerializeXML = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelTopRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Reservation)).BeginInit();
            this.panelBottomRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errPrvReservationID)).BeginInit();
            this.roomsContextMenuStrip.SuspendLayout();
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
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panelTopRoom
            // 
            this.panelTopRoom.Controls.Add(this.dataGridView_Reservation);
            this.panelTopRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTopRoom.Location = new System.Drawing.Point(3, 3);
            this.panelTopRoom.Name = "panelTopRoom";
            this.panelTopRoom.Padding = new System.Windows.Forms.Padding(14);
            this.panelTopRoom.Size = new System.Drawing.Size(994, 244);
            this.panelTopRoom.TabIndex = 0;
            // 
            // dataGridView_Reservation
            // 
            this.dataGridView_Reservation.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Inter", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gainsboro;
            this.dataGridView_Reservation.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Reservation.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Reservation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Reservation.ColumnHeadersHeight = 35;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Reservation.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_Reservation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Reservation.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            this.dataGridView_Reservation.Location = new System.Drawing.Point(14, 14);
            this.dataGridView_Reservation.Name = "dataGridView_Reservation";
            this.dataGridView_Reservation.ReadOnly = true;
            this.dataGridView_Reservation.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Reservation.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_Reservation.RowHeadersVisible = false;
            this.dataGridView_Reservation.RowTemplate.Height = 27;
            this.dataGridView_Reservation.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Reservation.Size = new System.Drawing.Size(966, 216);
            this.dataGridView_Reservation.TabIndex = 2;
            this.dataGridView_Reservation.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.dataGridView_Reservation.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.dataGridView_Reservation.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Inter", 9.75F);
            this.dataGridView_Reservation.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Gainsboro;
            this.dataGridView_Reservation.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dataGridView_Reservation.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Gainsboro;
            this.dataGridView_Reservation.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.dataGridView_Reservation.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            this.dataGridView_Reservation.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            this.dataGridView_Reservation.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_Reservation.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_Reservation.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Gainsboro;
            this.dataGridView_Reservation.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_Reservation.ThemeStyle.HeaderStyle.Height = 35;
            this.dataGridView_Reservation.ThemeStyle.ReadOnly = true;
            this.dataGridView_Reservation.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.dataGridView_Reservation.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_Reservation.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_Reservation.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Gainsboro;
            this.dataGridView_Reservation.ThemeStyle.RowsStyle.Height = 27;
            this.dataGridView_Reservation.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dataGridView_Reservation.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Gainsboro;
            this.dataGridView_Reservation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Reservation_CellClick);
            // 
            // panelBottomRoom
            // 
            this.panelBottomRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelBottomRoom.Controls.Add(this.labelCheckOutDate);
            this.panelBottomRoom.Controls.Add(this.labelCheckInDate);
            this.panelBottomRoom.Controls.Add(this.dateTimePickerCheckOutDate);
            this.panelBottomRoom.Controls.Add(this.dateTimePickerCheckInDate);
            this.panelBottomRoom.Controls.Add(this.comboBoxClientId);
            this.panelBottomRoom.Controls.Add(this.labelClient);
            this.panelBottomRoom.Controls.Add(this.comboBoxRoomId);
            this.panelBottomRoom.Controls.Add(this.labelRoom);
            this.panelBottomRoom.Controls.Add(this.labelClearClientRoom);
            this.panelBottomRoom.Controls.Add(this.labelDeleteRoom);
            this.panelBottomRoom.Controls.Add(this.labelUpdateRoom);
            this.panelBottomRoom.Controls.Add(this.labelSaveRoom);
            this.panelBottomRoom.Controls.Add(this.btnClearReservationDetails);
            this.panelBottomRoom.Controls.Add(this.btnDeleteReservation);
            this.panelBottomRoom.Controls.Add(this.btnUpdateClient);
            this.panelBottomRoom.Controls.Add(this.btnSaveReservation);
            this.panelBottomRoom.Controls.Add(this.textboxReservationID);
            this.panelBottomRoom.Controls.Add(this.labelReservation);
            this.panelBottomRoom.Location = new System.Drawing.Point(3, 253);
            this.panelBottomRoom.Name = "panelBottomRoom";
            this.panelBottomRoom.Size = new System.Drawing.Size(994, 244);
            this.panelBottomRoom.TabIndex = 1;
            // 
            // labelCheckOutDate
            // 
            this.labelCheckOutDate.AutoSize = true;
            this.labelCheckOutDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelCheckOutDate.Location = new System.Drawing.Point(643, 105);
            this.labelCheckOutDate.Name = "labelCheckOutDate";
            this.labelCheckOutDate.Size = new System.Drawing.Size(106, 16);
            this.labelCheckOutDate.TabIndex = 57;
            this.labelCheckOutDate.Text = "Check Out Date";
            // 
            // labelCheckInDate
            // 
            this.labelCheckInDate.AutoSize = true;
            this.labelCheckInDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelCheckInDate.Location = new System.Drawing.Point(264, 104);
            this.labelCheckInDate.Name = "labelCheckInDate";
            this.labelCheckInDate.Size = new System.Drawing.Size(94, 16);
            this.labelCheckInDate.TabIndex = 56;
            this.labelCheckInDate.Text = "Check In Date";
            // 
            // dateTimePickerCheckOutDate
            // 
            this.dateTimePickerCheckOutDate.Animated = true;
            this.dateTimePickerCheckOutDate.BackColor = System.Drawing.Color.Transparent;
            this.dateTimePickerCheckOutDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            this.dateTimePickerCheckOutDate.BorderRadius = 6;
            this.dateTimePickerCheckOutDate.BorderThickness = 2;
            this.dateTimePickerCheckOutDate.Checked = true;
            this.dateTimePickerCheckOutDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.dateTimePickerCheckOutDate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.dateTimePickerCheckOutDate.Font = new System.Drawing.Font("Inter", 9F);
            this.dateTimePickerCheckOutDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.dateTimePickerCheckOutDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePickerCheckOutDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            this.dateTimePickerCheckOutDate.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.dateTimePickerCheckOutDate.HoverState.ForeColor = System.Drawing.Color.Gainsboro;
            this.dateTimePickerCheckOutDate.Location = new System.Drawing.Point(583, 126);
            this.dateTimePickerCheckOutDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerCheckOutDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerCheckOutDate.Name = "dateTimePickerCheckOutDate";
            this.dateTimePickerCheckOutDate.Size = new System.Drawing.Size(215, 25);
            this.dateTimePickerCheckOutDate.TabIndex = 55;
            this.dateTimePickerCheckOutDate.UseTransparentBackground = true;
            this.dateTimePickerCheckOutDate.Value = new System.DateTime(2024, 4, 28, 15, 3, 51, 994);
            // 
            // dateTimePickerCheckInDate
            // 
            this.dateTimePickerCheckInDate.Animated = true;
            this.dateTimePickerCheckInDate.BackColor = System.Drawing.Color.Transparent;
            this.dateTimePickerCheckInDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            this.dateTimePickerCheckInDate.BorderRadius = 6;
            this.dateTimePickerCheckInDate.BorderThickness = 2;
            this.dateTimePickerCheckInDate.Checked = true;
            this.dateTimePickerCheckInDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.dateTimePickerCheckInDate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.dateTimePickerCheckInDate.Font = new System.Drawing.Font("Inter", 9F);
            this.dateTimePickerCheckInDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.dateTimePickerCheckInDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePickerCheckInDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            this.dateTimePickerCheckInDate.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.dateTimePickerCheckInDate.HoverState.ForeColor = System.Drawing.Color.Gainsboro;
            this.dateTimePickerCheckInDate.Location = new System.Drawing.Point(206, 126);
            this.dateTimePickerCheckInDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerCheckInDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerCheckInDate.Name = "dateTimePickerCheckInDate";
            this.dateTimePickerCheckInDate.Size = new System.Drawing.Size(215, 25);
            this.dateTimePickerCheckInDate.TabIndex = 54;
            this.dateTimePickerCheckInDate.UseTransparentBackground = true;
            this.dateTimePickerCheckInDate.Value = new System.DateTime(2024, 4, 28, 15, 3, 51, 994);
            // 
            // comboBoxClientId
            // 
            this.comboBoxClientId.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxClientId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            this.comboBoxClientId.BorderRadius = 6;
            this.comboBoxClientId.BorderThickness = 2;
            this.comboBoxClientId.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxClientId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClientId.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.comboBoxClientId.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxClientId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxClientId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxClientId.ForeColor = System.Drawing.Color.Gainsboro;
            this.comboBoxClientId.ItemHeight = 19;
            this.comboBoxClientId.Location = new System.Drawing.Point(643, 55);
            this.comboBoxClientId.Name = "comboBoxClientId";
            this.comboBoxClientId.Size = new System.Drawing.Size(155, 25);
            this.comboBoxClientId.TabIndex = 53;
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelClient.Location = new System.Drawing.Point(699, 34);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(43, 16);
            this.labelClient.TabIndex = 52;
            this.labelClient.Text = "Client";
            // 
            // comboBoxRoomId
            // 
            this.comboBoxRoomId.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxRoomId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            this.comboBoxRoomId.BorderRadius = 6;
            this.comboBoxRoomId.BorderThickness = 2;
            this.comboBoxRoomId.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxRoomId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoomId.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.comboBoxRoomId.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxRoomId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxRoomId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxRoomId.ForeColor = System.Drawing.Color.Gainsboro;
            this.comboBoxRoomId.ItemHeight = 19;
            this.comboBoxRoomId.Location = new System.Drawing.Point(422, 55);
            this.comboBoxRoomId.Name = "comboBoxRoomId";
            this.comboBoxRoomId.Size = new System.Drawing.Size(155, 25);
            this.comboBoxRoomId.TabIndex = 51;
            // 
            // labelRoom
            // 
            this.labelRoom.AutoSize = true;
            this.labelRoom.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelRoom.Location = new System.Drawing.Point(478, 34);
            this.labelRoom.Name = "labelRoom";
            this.labelRoom.Size = new System.Drawing.Size(42, 16);
            this.labelRoom.TabIndex = 50;
            this.labelRoom.Text = "Room";
            // 
            // labelClearClientRoom
            // 
            this.labelClearClientRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelClearClientRoom.AutoSize = true;
            this.labelClearClientRoom.BackColor = System.Drawing.Color.Transparent;
            this.labelClearClientRoom.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClearClientRoom.ForeColor = System.Drawing.Color.Transparent;
            this.labelClearClientRoom.Location = new System.Drawing.Point(619, 216);
            this.labelClearClientRoom.Name = "labelClearClientRoom";
            this.labelClearClientRoom.Size = new System.Drawing.Size(34, 14);
            this.labelClearClientRoom.TabIndex = 49;
            this.labelClearClientRoom.Text = "Clear";
            // 
            // labelDeleteRoom
            // 
            this.labelDeleteRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDeleteRoom.AutoSize = true;
            this.labelDeleteRoom.BackColor = System.Drawing.Color.Transparent;
            this.labelDeleteRoom.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeleteRoom.ForeColor = System.Drawing.Color.Transparent;
            this.labelDeleteRoom.Location = new System.Drawing.Point(522, 216);
            this.labelDeleteRoom.Name = "labelDeleteRoom";
            this.labelDeleteRoom.Size = new System.Drawing.Size(40, 14);
            this.labelDeleteRoom.TabIndex = 48;
            this.labelDeleteRoom.Text = "Delete";
            // 
            // labelUpdateRoom
            // 
            this.labelUpdateRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUpdateRoom.AutoSize = true;
            this.labelUpdateRoom.BackColor = System.Drawing.Color.Transparent;
            this.labelUpdateRoom.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpdateRoom.ForeColor = System.Drawing.Color.Transparent;
            this.labelUpdateRoom.Location = new System.Drawing.Point(428, 216);
            this.labelUpdateRoom.Name = "labelUpdateRoom";
            this.labelUpdateRoom.Size = new System.Drawing.Size(45, 14);
            this.labelUpdateRoom.TabIndex = 47;
            this.labelUpdateRoom.Text = "Update";
            // 
            // labelSaveRoom
            // 
            this.labelSaveRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSaveRoom.AutoSize = true;
            this.labelSaveRoom.BackColor = System.Drawing.Color.Transparent;
            this.labelSaveRoom.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaveRoom.ForeColor = System.Drawing.Color.Transparent;
            this.labelSaveRoom.Location = new System.Drawing.Point(352, 216);
            this.labelSaveRoom.Name = "labelSaveRoom";
            this.labelSaveRoom.Size = new System.Drawing.Size(32, 14);
            this.labelSaveRoom.TabIndex = 46;
            this.labelSaveRoom.Text = "Save";
            // 
            // btnClearReservationDetails
            // 
            this.btnClearReservationDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClearReservationDetails.BackColor = System.Drawing.Color.Transparent;
            this.btnClearReservationDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClearReservationDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearReservationDetails.FlatAppearance.BorderSize = 0;
            this.btnClearReservationDetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClearReservationDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClearReservationDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearReservationDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(47)))), ((int)(((byte)(54)))));
            this.btnClearReservationDetails.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnClearReservationDetails.IconColor = System.Drawing.Color.Gainsboro;
            this.btnClearReservationDetails.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClearReservationDetails.IconSize = 50;
            this.btnClearReservationDetails.Location = new System.Drawing.Point(608, 172);
            this.btnClearReservationDetails.Name = "btnClearReservationDetails";
            this.btnClearReservationDetails.Size = new System.Drawing.Size(48, 48);
            this.btnClearReservationDetails.TabIndex = 45;
            this.btnClearReservationDetails.UseVisualStyleBackColor = false;
            this.btnClearReservationDetails.Click += new System.EventHandler(this.btnClearReservationDetails_Click);
            // 
            // btnDeleteReservation
            // 
            this.btnDeleteReservation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteReservation.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteReservation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDeleteReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteReservation.FlatAppearance.BorderSize = 0;
            this.btnDeleteReservation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDeleteReservation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDeleteReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteReservation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(47)))), ((int)(((byte)(54)))));
            this.btnDeleteReservation.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDeleteReservation.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDeleteReservation.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteReservation.IconSize = 46;
            this.btnDeleteReservation.Location = new System.Drawing.Point(518, 172);
            this.btnDeleteReservation.Name = "btnDeleteReservation";
            this.btnDeleteReservation.Size = new System.Drawing.Size(48, 48);
            this.btnDeleteReservation.TabIndex = 44;
            this.btnDeleteReservation.UseVisualStyleBackColor = false;
            this.btnDeleteReservation.Click += new System.EventHandler(this.btnDeleteReservation_Click);
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
            this.btnUpdateClient.Location = new System.Drawing.Point(428, 172);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.Size = new System.Drawing.Size(48, 48);
            this.btnUpdateClient.TabIndex = 43;
            this.btnUpdateClient.UseVisualStyleBackColor = false;
            this.btnUpdateClient.Click += new System.EventHandler(this.btnUpdateClient_Click);
            // 
            // btnSaveReservation
            // 
            this.btnSaveReservation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveReservation.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveReservation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSaveReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveReservation.FlatAppearance.BorderSize = 0;
            this.btnSaveReservation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSaveReservation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSaveReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveReservation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(47)))), ((int)(((byte)(54)))));
            this.btnSaveReservation.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnSaveReservation.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSaveReservation.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSaveReservation.Location = new System.Drawing.Point(343, 172);
            this.btnSaveReservation.Name = "btnSaveReservation";
            this.btnSaveReservation.Size = new System.Drawing.Size(48, 48);
            this.btnSaveReservation.TabIndex = 42;
            this.btnSaveReservation.UseVisualStyleBackColor = false;
            this.btnSaveReservation.Click += new System.EventHandler(this.btnSaveReservation_Click);
            // 
            // textboxReservationID
            // 
            this.textboxReservationID.Animated = true;
            this.textboxReservationID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            this.textboxReservationID.BorderRadius = 6;
            this.textboxReservationID.BorderThickness = 2;
            this.textboxReservationID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textboxReservationID.DefaultText = "";
            this.textboxReservationID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textboxReservationID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textboxReservationID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textboxReservationID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textboxReservationID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.textboxReservationID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textboxReservationID.Font = new System.Drawing.Font("Inter", 8.25F);
            this.textboxReservationID.ForeColor = System.Drawing.Color.Gainsboro;
            this.textboxReservationID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textboxReservationID.Location = new System.Drawing.Point(206, 55);
            this.textboxReservationID.Name = "textboxReservationID";
            this.textboxReservationID.PasswordChar = '\0';
            this.textboxReservationID.PlaceholderText = "";
            this.textboxReservationID.SelectedText = "";
            this.textboxReservationID.Size = new System.Drawing.Size(155, 25);
            this.textboxReservationID.TabIndex = 4;
            this.textboxReservationID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxReservationID_KeyPress);
            // 
            // labelReservation
            // 
            this.labelReservation.AutoSize = true;
            this.labelReservation.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelReservation.Location = new System.Drawing.Point(236, 34);
            this.labelReservation.Name = "labelReservation";
            this.labelReservation.Size = new System.Drawing.Size(97, 16);
            this.labelReservation.TabIndex = 1;
            this.labelReservation.Text = "Reservation ID";
            // 
            // errPrvReservationID
            // 
            this.errPrvReservationID.ContainerControl = this;
            // 
            // roomsContextMenuStrip
            // 
            this.roomsContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservationsSerialize});
            this.roomsContextMenuStrip.Name = "clientsContextMenuStrip";
            this.roomsContextMenuStrip.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.roomsContextMenuStrip.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.roomsContextMenuStrip.RenderStyle.ColorTable = null;
            this.roomsContextMenuStrip.RenderStyle.RoundedEdges = true;
            this.roomsContextMenuStrip.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.roomsContextMenuStrip.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.roomsContextMenuStrip.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.roomsContextMenuStrip.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.roomsContextMenuStrip.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.roomsContextMenuStrip.Size = new System.Drawing.Size(117, 26);
            // 
            // reservationsSerialize
            // 
            this.reservationsSerialize.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservationsSerializeBinary,
            this.reservationsSerializeXML});
            this.reservationsSerialize.Name = "reservationsSerialize";
            this.reservationsSerialize.Size = new System.Drawing.Size(116, 22);
            this.reservationsSerialize.Text = "Serialize";
            // 
            // reservationsSerializeBinary
            // 
            this.reservationsSerializeBinary.Name = "reservationsSerializeBinary";
            this.reservationsSerializeBinary.Size = new System.Drawing.Size(107, 22);
            this.reservationsSerializeBinary.Text = "Binary";
            this.reservationsSerializeBinary.Click += new System.EventHandler(this.reservationsSerializeBinary_Click);
            // 
            // reservationsSerializeXML
            // 
            this.reservationsSerializeXML.Name = "reservationsSerializeXML";
            this.reservationsSerializeXML.Size = new System.Drawing.Size(107, 22);
            this.reservationsSerializeXML.Text = "XML";
            this.reservationsSerializeXML.Click += new System.EventHandler(this.reservationsSerializeXML_Click);
            // 
            // ReservationsFormResponsive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(47)))), ((int)(((byte)(54)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.ContextMenuStrip = this.roomsContextMenuStrip;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Inter", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "ReservationsFormResponsive";
            this.Text = "Reservations";
            this.Load += new System.EventHandler(this.ReservationsFormResponsive_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelTopRoom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Reservation)).EndInit();
            this.panelBottomRoom.ResumeLayout(false);
            this.panelBottomRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errPrvReservationID)).EndInit();
            this.roomsContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelTopRoom;
        private System.Windows.Forms.Panel panelBottomRoom;
        private System.Windows.Forms.Label labelClearClientRoom;
        private System.Windows.Forms.Label labelDeleteRoom;
        private System.Windows.Forms.Label labelUpdateRoom;
        private System.Windows.Forms.Label labelSaveRoom;
        private FontAwesome.Sharp.IconButton btnClearReservationDetails;
        private FontAwesome.Sharp.IconButton btnDeleteReservation;
        private FontAwesome.Sharp.IconButton btnUpdateClient;
        private FontAwesome.Sharp.IconButton btnSaveReservation;
        private Guna.UI2.WinForms.Guna2TextBox textboxReservationID;
        private System.Windows.Forms.Label labelReservation;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxClientId;
        private System.Windows.Forms.Label labelClient;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxRoomId;
        private System.Windows.Forms.Label labelRoom;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePickerCheckInDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePickerCheckOutDate;
        private System.Windows.Forms.Label labelCheckOutDate;
        private System.Windows.Forms.Label labelCheckInDate;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView_Reservation;
        private System.Windows.Forms.ErrorProvider errPrvReservationID;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip roomsContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem reservationsSerialize;
        private System.Windows.Forms.ToolStripMenuItem reservationsSerializeBinary;
        private System.Windows.Forms.ToolStripMenuItem reservationsSerializeXML;
    }
}