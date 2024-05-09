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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelTopRoom = new System.Windows.Forms.Panel();
            this.dataGridView_Reservation = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panelBottomRoom = new System.Windows.Forms.Panel();
            this.labelCheckOutDate = new System.Windows.Forms.Label();
            this.labelCheckInDate = new System.Windows.Forms.Label();
            this.guna2DateTimePicker2 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2ComboBox2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.labelClient = new System.Windows.Forms.Label();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.labelRoom = new System.Windows.Forms.Label();
            this.labelClearClientRoom = new System.Windows.Forms.Label();
            this.labelDeleteRoom = new System.Windows.Forms.Label();
            this.labelUpdateRoom = new System.Windows.Forms.Label();
            this.labelSaveRoom = new System.Windows.Forms.Label();
            this.btnClearClientDetails = new FontAwesome.Sharp.IconButton();
            this.btnDeleteClient = new FontAwesome.Sharp.IconButton();
            this.btnUpdateClient = new FontAwesome.Sharp.IconButton();
            this.btnSaveClient = new FontAwesome.Sharp.IconButton();
            this.guna2ClientID = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelReservation = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelTopRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Reservation)).BeginInit();
            this.panelBottomRoom.SuspendLayout();
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
            this.dataGridView_Reservation.AllowUserToAddRows = false;
            this.dataGridView_Reservation.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dataGridView_Reservation.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_Reservation.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Reservation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_Reservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Reservation.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_Reservation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Reservation.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_Reservation.Location = new System.Drawing.Point(14, 14);
            this.dataGridView_Reservation.Name = "dataGridView_Reservation";
            this.dataGridView_Reservation.ReadOnly = true;
            this.dataGridView_Reservation.RowHeadersVisible = false;
            this.dataGridView_Reservation.Size = new System.Drawing.Size(966, 216);
            this.dataGridView_Reservation.TabIndex = 0;
            this.dataGridView_Reservation.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_Reservation.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView_Reservation.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView_Reservation.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView_Reservation.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView_Reservation.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.dataGridView_Reservation.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_Reservation.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView_Reservation.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_Reservation.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_Reservation.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_Reservation.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView_Reservation.ThemeStyle.HeaderStyle.Height = 23;
            this.dataGridView_Reservation.ThemeStyle.ReadOnly = true;
            this.dataGridView_Reservation.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_Reservation.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_Reservation.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_Reservation.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_Reservation.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridView_Reservation.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_Reservation.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // panelBottomRoom
            // 
            this.panelBottomRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelBottomRoom.Controls.Add(this.labelCheckOutDate);
            this.panelBottomRoom.Controls.Add(this.labelCheckInDate);
            this.panelBottomRoom.Controls.Add(this.guna2DateTimePicker2);
            this.panelBottomRoom.Controls.Add(this.guna2DateTimePicker1);
            this.panelBottomRoom.Controls.Add(this.guna2ComboBox2);
            this.panelBottomRoom.Controls.Add(this.labelClient);
            this.panelBottomRoom.Controls.Add(this.guna2ComboBox1);
            this.panelBottomRoom.Controls.Add(this.labelRoom);
            this.panelBottomRoom.Controls.Add(this.labelClearClientRoom);
            this.panelBottomRoom.Controls.Add(this.labelDeleteRoom);
            this.panelBottomRoom.Controls.Add(this.labelUpdateRoom);
            this.panelBottomRoom.Controls.Add(this.labelSaveRoom);
            this.panelBottomRoom.Controls.Add(this.btnClearClientDetails);
            this.panelBottomRoom.Controls.Add(this.btnDeleteClient);
            this.panelBottomRoom.Controls.Add(this.btnUpdateClient);
            this.panelBottomRoom.Controls.Add(this.btnSaveClient);
            this.panelBottomRoom.Controls.Add(this.guna2ClientID);
            this.panelBottomRoom.Controls.Add(this.labelReservation);
            this.panelBottomRoom.Location = new System.Drawing.Point(3, 253);
            this.panelBottomRoom.Name = "panelBottomRoom";
            this.panelBottomRoom.Size = new System.Drawing.Size(994, 244);
            this.panelBottomRoom.TabIndex = 1;
            this.panelBottomRoom.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBottomRoom_Paint);
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
            // guna2DateTimePicker2
            // 
            this.guna2DateTimePicker2.Animated = true;
            this.guna2DateTimePicker2.BackColor = System.Drawing.Color.Transparent;
            this.guna2DateTimePicker2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            this.guna2DateTimePicker2.BorderRadius = 6;
            this.guna2DateTimePicker2.BorderThickness = 2;
            this.guna2DateTimePicker2.Checked = true;
            this.guna2DateTimePicker2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.guna2DateTimePicker2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.guna2DateTimePicker2.Font = new System.Drawing.Font("Inter", 9F);
            this.guna2DateTimePicker2.ForeColor = System.Drawing.Color.Gainsboro;
            this.guna2DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            this.guna2DateTimePicker2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.guna2DateTimePicker2.HoverState.ForeColor = System.Drawing.Color.Gainsboro;
            this.guna2DateTimePicker2.Location = new System.Drawing.Point(583, 126);
            this.guna2DateTimePicker2.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker2.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker2.Name = "guna2DateTimePicker2";
            this.guna2DateTimePicker2.Size = new System.Drawing.Size(215, 25);
            this.guna2DateTimePicker2.TabIndex = 55;
            this.guna2DateTimePicker2.UseTransparentBackground = true;
            this.guna2DateTimePicker2.Value = new System.DateTime(2024, 4, 28, 15, 3, 51, 994);
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.Animated = true;
            this.guna2DateTimePicker1.BackColor = System.Drawing.Color.Transparent;
            this.guna2DateTimePicker1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            this.guna2DateTimePicker1.BorderRadius = 6;
            this.guna2DateTimePicker1.BorderThickness = 2;
            this.guna2DateTimePicker1.Checked = true;
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.guna2DateTimePicker1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Inter", 9F);
            this.guna2DateTimePicker1.ForeColor = System.Drawing.Color.Gainsboro;
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            this.guna2DateTimePicker1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.guna2DateTimePicker1.HoverState.ForeColor = System.Drawing.Color.Gainsboro;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(206, 126);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(215, 25);
            this.guna2DateTimePicker1.TabIndex = 54;
            this.guna2DateTimePicker1.UseTransparentBackground = true;
            this.guna2DateTimePicker1.Value = new System.DateTime(2024, 4, 28, 15, 3, 51, 994);
            // 
            // guna2ComboBox2
            // 
            this.guna2ComboBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            this.guna2ComboBox2.BorderRadius = 6;
            this.guna2ComboBox2.BorderThickness = 2;
            this.guna2ComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.guna2ComboBox2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox2.ForeColor = System.Drawing.Color.Gainsboro;
            this.guna2ComboBox2.ItemHeight = 19;
            this.guna2ComboBox2.Location = new System.Drawing.Point(643, 55);
            this.guna2ComboBox2.Name = "guna2ComboBox2";
            this.guna2ComboBox2.Size = new System.Drawing.Size(155, 25);
            this.guna2ComboBox2.TabIndex = 53;
            this.guna2ComboBox2.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox2_SelectedIndexChanged);
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
            this.labelClient.Click += new System.EventHandler(this.label1_Click);
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            this.guna2ComboBox1.BorderRadius = 6;
            this.guna2ComboBox1.BorderThickness = 2;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.guna2ComboBox1.ItemHeight = 19;
            this.guna2ComboBox1.Location = new System.Drawing.Point(422, 55);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(155, 25);
            this.guna2ComboBox1.TabIndex = 51;
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
            this.btnClearClientDetails.Location = new System.Drawing.Point(608, 172);
            this.btnClearClientDetails.Name = "btnClearClientDetails";
            this.btnClearClientDetails.Size = new System.Drawing.Size(48, 48);
            this.btnClearClientDetails.TabIndex = 45;
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
            this.btnDeleteClient.Location = new System.Drawing.Point(518, 172);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(48, 48);
            this.btnDeleteClient.TabIndex = 44;
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
            this.btnUpdateClient.Location = new System.Drawing.Point(428, 172);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.Size = new System.Drawing.Size(48, 48);
            this.btnUpdateClient.TabIndex = 43;
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
            this.btnSaveClient.Location = new System.Drawing.Point(343, 172);
            this.btnSaveClient.Name = "btnSaveClient";
            this.btnSaveClient.Size = new System.Drawing.Size(48, 48);
            this.btnSaveClient.TabIndex = 42;
            this.btnSaveClient.UseVisualStyleBackColor = false;
            // 
            // guna2ClientID
            // 
            this.guna2ClientID.Animated = true;
            this.guna2ClientID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            this.guna2ClientID.BorderRadius = 6;
            this.guna2ClientID.BorderThickness = 2;
            this.guna2ClientID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2ClientID.DefaultText = "";
            this.guna2ClientID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2ClientID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2ClientID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2ClientID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2ClientID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.guna2ClientID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ClientID.Font = new System.Drawing.Font("Inter", 8.25F);
            this.guna2ClientID.ForeColor = System.Drawing.Color.Gainsboro;
            this.guna2ClientID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ClientID.Location = new System.Drawing.Point(206, 55);
            this.guna2ClientID.Name = "guna2ClientID";
            this.guna2ClientID.PasswordChar = '\0';
            this.guna2ClientID.PlaceholderText = "";
            this.guna2ClientID.SelectedText = "";
            this.guna2ClientID.Size = new System.Drawing.Size(155, 25);
            this.guna2ClientID.TabIndex = 4;
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
            // ReservationsFormResponsive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(47)))), ((int)(((byte)(54)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Inter", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "ReservationsFormResponsive";
            this.Text = "Reservations";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelTopRoom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Reservation)).EndInit();
            this.panelBottomRoom.ResumeLayout(false);
            this.panelBottomRoom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelTopRoom;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView_Reservation;
        private System.Windows.Forms.Panel panelBottomRoom;
        private System.Windows.Forms.Label labelClearClientRoom;
        private System.Windows.Forms.Label labelDeleteRoom;
        private System.Windows.Forms.Label labelUpdateRoom;
        private System.Windows.Forms.Label labelSaveRoom;
        private FontAwesome.Sharp.IconButton btnClearClientDetails;
        private FontAwesome.Sharp.IconButton btnDeleteClient;
        private FontAwesome.Sharp.IconButton btnUpdateClient;
        private FontAwesome.Sharp.IconButton btnSaveClient;
        private Guna.UI2.WinForms.Guna2TextBox guna2ClientID;
        private System.Windows.Forms.Label labelReservation;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox2;
        private System.Windows.Forms.Label labelClient;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private System.Windows.Forms.Label labelRoom;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker2;
        private System.Windows.Forms.Label labelCheckOutDate;
        private System.Windows.Forms.Label labelCheckInDate;
    }
}