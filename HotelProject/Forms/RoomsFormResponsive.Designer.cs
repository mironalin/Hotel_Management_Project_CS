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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelTopRoom = new System.Windows.Forms.Panel();
            this.dataGridView_Room = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panelBottomRoom = new System.Windows.Forms.Panel();
            this.labelClearClientRoom = new System.Windows.Forms.Label();
            this.labelDeleteRoom = new System.Windows.Forms.Label();
            this.labelUpdateRoom = new System.Windows.Forms.Label();
            this.labelSaveRoom = new System.Windows.Forms.Label();
            this.btnClearRoomDetails = new FontAwesome.Sharp.IconButton();
            this.btnDeleteRoom = new FontAwesome.Sharp.IconButton();
            this.btnUpdateRoom = new FontAwesome.Sharp.IconButton();
            this.btnSaveRoom = new FontAwesome.Sharp.IconButton();
            this.radButBusy = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radButFree = new Guna.UI2.WinForms.Guna2RadioButton();
            this.textBoxRoomPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.comboBoxRoomType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.textBoxRoomNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelRoomStatus = new System.Windows.Forms.Label();
            this.labelRoomType = new System.Windows.Forms.Label();
            this.labelRoomNumber = new System.Windows.Forms.Label();
            this.labelRoomPhone = new System.Windows.Forms.Label();
            this.errPrvRoomNumber = new System.Windows.Forms.ErrorProvider(this.components);
            this.errPrvRoomPhone = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panelTopRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Room)).BeginInit();
            this.panelBottomRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errPrvRoomNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPrvRoomPhone)).BeginInit();
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
            this.panelTopRoom.Controls.Add(this.dataGridView_Room);
            this.panelTopRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTopRoom.Location = new System.Drawing.Point(3, 3);
            this.panelTopRoom.Name = "panelTopRoom";
            this.panelTopRoom.Padding = new System.Windows.Forms.Padding(14);
            this.panelTopRoom.Size = new System.Drawing.Size(994, 244);
            this.panelTopRoom.TabIndex = 0;
            // 
            // dataGridView_Room
            // 
            this.dataGridView_Room.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Inter", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gainsboro;
            this.dataGridView_Room.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Room.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Room.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Room.ColumnHeadersHeight = 35;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Room.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_Room.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Room.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            this.dataGridView_Room.Location = new System.Drawing.Point(14, 14);
            this.dataGridView_Room.Name = "dataGridView_Room";
            this.dataGridView_Room.ReadOnly = true;
            this.dataGridView_Room.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Room.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_Room.RowHeadersVisible = false;
            this.dataGridView_Room.RowTemplate.Height = 27;
            this.dataGridView_Room.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Room.Size = new System.Drawing.Size(966, 216);
            this.dataGridView_Room.TabIndex = 0;
            this.dataGridView_Room.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.dataGridView_Room.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.dataGridView_Room.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Inter", 9.75F);
            this.dataGridView_Room.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Gainsboro;
            this.dataGridView_Room.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dataGridView_Room.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Gainsboro;
            this.dataGridView_Room.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.dataGridView_Room.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            this.dataGridView_Room.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            this.dataGridView_Room.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_Room.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_Room.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Gainsboro;
            this.dataGridView_Room.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_Room.ThemeStyle.HeaderStyle.Height = 35;
            this.dataGridView_Room.ThemeStyle.ReadOnly = true;
            this.dataGridView_Room.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.dataGridView_Room.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_Room.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_Room.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Gainsboro;
            this.dataGridView_Room.ThemeStyle.RowsStyle.Height = 27;
            this.dataGridView_Room.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dataGridView_Room.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Gainsboro;
            this.dataGridView_Room.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Room_CellClick);
            // 
            // panelBottomRoom
            // 
            this.panelBottomRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelBottomRoom.Controls.Add(this.labelClearClientRoom);
            this.panelBottomRoom.Controls.Add(this.labelDeleteRoom);
            this.panelBottomRoom.Controls.Add(this.labelUpdateRoom);
            this.panelBottomRoom.Controls.Add(this.labelSaveRoom);
            this.panelBottomRoom.Controls.Add(this.btnClearRoomDetails);
            this.panelBottomRoom.Controls.Add(this.btnDeleteRoom);
            this.panelBottomRoom.Controls.Add(this.btnUpdateRoom);
            this.panelBottomRoom.Controls.Add(this.btnSaveRoom);
            this.panelBottomRoom.Controls.Add(this.radButBusy);
            this.panelBottomRoom.Controls.Add(this.radButFree);
            this.panelBottomRoom.Controls.Add(this.textBoxRoomPhone);
            this.panelBottomRoom.Controls.Add(this.comboBoxRoomType);
            this.panelBottomRoom.Controls.Add(this.textBoxRoomNumber);
            this.panelBottomRoom.Controls.Add(this.labelRoomStatus);
            this.panelBottomRoom.Controls.Add(this.labelRoomType);
            this.panelBottomRoom.Controls.Add(this.labelRoomNumber);
            this.panelBottomRoom.Controls.Add(this.labelRoomPhone);
            this.panelBottomRoom.Location = new System.Drawing.Point(3, 253);
            this.panelBottomRoom.Name = "panelBottomRoom";
            this.panelBottomRoom.Size = new System.Drawing.Size(994, 244);
            this.panelBottomRoom.TabIndex = 1;
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
            this.btnClearRoomDetails.Location = new System.Drawing.Point(608, 172);
            this.btnClearRoomDetails.Name = "btnClearRoomDetails";
            this.btnClearRoomDetails.Size = new System.Drawing.Size(48, 48);
            this.btnClearRoomDetails.TabIndex = 45;
            this.btnClearRoomDetails.UseVisualStyleBackColor = false;
            this.btnClearRoomDetails.Click += new System.EventHandler(this.btnClearRoomDetails_Click);
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
            this.btnDeleteRoom.Location = new System.Drawing.Point(518, 172);
            this.btnDeleteRoom.Name = "btnDeleteRoom";
            this.btnDeleteRoom.Size = new System.Drawing.Size(48, 48);
            this.btnDeleteRoom.TabIndex = 44;
            this.btnDeleteRoom.UseVisualStyleBackColor = false;
            this.btnDeleteRoom.Click += new System.EventHandler(this.btnDeleteRoom_Click);
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
            this.btnUpdateRoom.Location = new System.Drawing.Point(428, 172);
            this.btnUpdateRoom.Name = "btnUpdateRoom";
            this.btnUpdateRoom.Size = new System.Drawing.Size(48, 48);
            this.btnUpdateRoom.TabIndex = 43;
            this.btnUpdateRoom.UseVisualStyleBackColor = false;
            this.btnUpdateRoom.Click += new System.EventHandler(this.btnUpdateRoom_Click);
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
            this.btnSaveRoom.Location = new System.Drawing.Point(343, 172);
            this.btnSaveRoom.Name = "btnSaveRoom";
            this.btnSaveRoom.Size = new System.Drawing.Size(48, 48);
            this.btnSaveRoom.TabIndex = 42;
            this.btnSaveRoom.UseVisualStyleBackColor = false;
            this.btnSaveRoom.Click += new System.EventHandler(this.btnSaveRoom_Click);
            // 
            // radButBusy
            // 
            this.radButBusy.AutoSize = true;
            this.radButBusy.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radButBusy.CheckedState.BorderThickness = 2;
            this.radButBusy.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radButBusy.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            this.radButBusy.CheckedState.InnerOffset = -6;
            this.radButBusy.Font = new System.Drawing.Font("Inter", 9.75F);
            this.radButBusy.ForeColor = System.Drawing.Color.Gainsboro;
            this.radButBusy.Location = new System.Drawing.Point(775, 115);
            this.radButBusy.Name = "radButBusy";
            this.radButBusy.Size = new System.Drawing.Size(55, 20);
            this.radButBusy.TabIndex = 9;
            this.radButBusy.Text = "Busy";
            this.radButBusy.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            this.radButBusy.UncheckedState.BorderThickness = 2;
            this.radButBusy.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radButBusy.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // radButFree
            // 
            this.radButFree.AutoSize = true;
            this.radButFree.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radButFree.CheckedState.BorderThickness = 2;
            this.radButFree.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radButFree.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            this.radButFree.CheckedState.InnerOffset = -6;
            this.radButFree.Font = new System.Drawing.Font("Inter Medium", 9.75F);
            this.radButFree.ForeColor = System.Drawing.Color.Gainsboro;
            this.radButFree.Location = new System.Drawing.Point(700, 115);
            this.radButFree.Name = "radButFree";
            this.radButFree.Size = new System.Drawing.Size(54, 20);
            this.radButFree.TabIndex = 8;
            this.radButFree.Text = "Free";
            this.radButFree.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            this.radButFree.UncheckedState.BorderThickness = 2;
            this.radButFree.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radButFree.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // textBoxRoomPhone
            // 
            this.textBoxRoomPhone.Animated = true;
            this.textBoxRoomPhone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            this.textBoxRoomPhone.BorderRadius = 6;
            this.textBoxRoomPhone.BorderThickness = 2;
            this.textBoxRoomPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxRoomPhone.DefaultText = "";
            this.textBoxRoomPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxRoomPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxRoomPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxRoomPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxRoomPhone.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.textBoxRoomPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxRoomPhone.Font = new System.Drawing.Font("Inter", 8.25F);
            this.textBoxRoomPhone.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxRoomPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxRoomPhone.Location = new System.Drawing.Point(257, 115);
            this.textBoxRoomPhone.Name = "textBoxRoomPhone";
            this.textBoxRoomPhone.PasswordChar = '\0';
            this.textBoxRoomPhone.PlaceholderText = "";
            this.textBoxRoomPhone.SelectedText = "";
            this.textBoxRoomPhone.Size = new System.Drawing.Size(155, 25);
            this.textBoxRoomPhone.TabIndex = 7;
            this.textBoxRoomPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRoomPhone_KeyPress);
            // 
            // comboBoxRoomType
            // 
            this.comboBoxRoomType.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxRoomType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            this.comboBoxRoomType.BorderRadius = 6;
            this.comboBoxRoomType.BorderThickness = 2;
            this.comboBoxRoomType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoomType.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.comboBoxRoomType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxRoomType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxRoomType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxRoomType.ForeColor = System.Drawing.Color.Gainsboro;
            this.comboBoxRoomType.ItemHeight = 19;
            this.comboBoxRoomType.Location = new System.Drawing.Point(686, 52);
            this.comboBoxRoomType.Name = "comboBoxRoomType";
            this.comboBoxRoomType.Size = new System.Drawing.Size(155, 25);
            this.comboBoxRoomType.TabIndex = 6;
            // 
            // textBoxRoomNumber
            // 
            this.textBoxRoomNumber.Animated = true;
            this.textBoxRoomNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            this.textBoxRoomNumber.BorderRadius = 6;
            this.textBoxRoomNumber.BorderThickness = 2;
            this.textBoxRoomNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxRoomNumber.DefaultText = "";
            this.textBoxRoomNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxRoomNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxRoomNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxRoomNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxRoomNumber.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.textBoxRoomNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxRoomNumber.Font = new System.Drawing.Font("Inter", 8.25F);
            this.textBoxRoomNumber.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxRoomNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxRoomNumber.Location = new System.Drawing.Point(257, 52);
            this.textBoxRoomNumber.Name = "textBoxRoomNumber";
            this.textBoxRoomNumber.PasswordChar = '\0';
            this.textBoxRoomNumber.PlaceholderText = "";
            this.textBoxRoomNumber.SelectedText = "";
            this.textBoxRoomNumber.Size = new System.Drawing.Size(155, 25);
            this.textBoxRoomNumber.TabIndex = 4;
            this.textBoxRoomNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRoomNumber_KeyPress);
            // 
            // labelRoomStatus
            // 
            this.labelRoomStatus.AutoSize = true;
            this.labelRoomStatus.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelRoomStatus.Location = new System.Drawing.Point(591, 119);
            this.labelRoomStatus.Name = "labelRoomStatus";
            this.labelRoomStatus.Size = new System.Drawing.Size(86, 16);
            this.labelRoomStatus.TabIndex = 3;
            this.labelRoomStatus.Text = "Room Status";
            // 
            // labelRoomType
            // 
            this.labelRoomType.AutoSize = true;
            this.labelRoomType.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelRoomType.Location = new System.Drawing.Point(601, 57);
            this.labelRoomType.Name = "labelRoomType";
            this.labelRoomType.Size = new System.Drawing.Size(76, 16);
            this.labelRoomType.TabIndex = 2;
            this.labelRoomType.Text = "Room Type";
            // 
            // labelRoomNumber
            // 
            this.labelRoomNumber.AutoSize = true;
            this.labelRoomNumber.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelRoomNumber.Location = new System.Drawing.Point(152, 56);
            this.labelRoomNumber.Name = "labelRoomNumber";
            this.labelRoomNumber.Size = new System.Drawing.Size(96, 16);
            this.labelRoomNumber.TabIndex = 1;
            this.labelRoomNumber.Text = "Room Number";
            // 
            // labelRoomPhone
            // 
            this.labelRoomPhone.AutoSize = true;
            this.labelRoomPhone.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelRoomPhone.Location = new System.Drawing.Point(162, 119);
            this.labelRoomPhone.Name = "labelRoomPhone";
            this.labelRoomPhone.Size = new System.Drawing.Size(86, 16);
            this.labelRoomPhone.TabIndex = 0;
            this.labelRoomPhone.Text = "Room Phone";
            // 
            // errPrvRoomNumber
            // 
            this.errPrvRoomNumber.ContainerControl = this;
            // 
            // errPrvRoomPhone
            // 
            this.errPrvRoomPhone.ContainerControl = this;
            // 
            // RoomsFormResponsive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(47)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RoomsFormResponsive";
            this.Text = "Rooms";
            this.Load += new System.EventHandler(this.RoomsFormResponsive_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelTopRoom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Room)).EndInit();
            this.panelBottomRoom.ResumeLayout(false);
            this.panelBottomRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errPrvRoomNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPrvRoomPhone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelTopRoom;
        private System.Windows.Forms.Panel panelBottomRoom;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView_Room;
        private System.Windows.Forms.Label labelRoomStatus;
        private System.Windows.Forms.Label labelRoomType;
        private System.Windows.Forms.Label labelRoomNumber;
        private System.Windows.Forms.Label labelRoomPhone;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxRoomType;
        private Guna.UI2.WinForms.Guna2TextBox textBoxRoomNumber;
        private Guna.UI2.WinForms.Guna2TextBox textBoxRoomPhone;
        private Guna.UI2.WinForms.Guna2RadioButton radButFree;
        private Guna.UI2.WinForms.Guna2RadioButton radButBusy;
        private System.Windows.Forms.Label labelClearClientRoom;
        private System.Windows.Forms.Label labelDeleteRoom;
        private System.Windows.Forms.Label labelUpdateRoom;
        private System.Windows.Forms.Label labelSaveRoom;
        private FontAwesome.Sharp.IconButton btnClearRoomDetails;
        private FontAwesome.Sharp.IconButton btnDeleteRoom;
        private FontAwesome.Sharp.IconButton btnUpdateRoom;
        private FontAwesome.Sharp.IconButton btnSaveRoom;
        private System.Windows.Forms.ErrorProvider errPrvRoomNumber;
        private System.Windows.Forms.ErrorProvider errPrvRoomPhone;
    }
}