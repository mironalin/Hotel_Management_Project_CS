namespace HotelProject.Forms
{
    partial class ClientsFormResponsive
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
            this.dataGridView_Client = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panelBottomRoom = new System.Windows.Forms.Panel();
            this.textBoxClientEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelClientEmail = new System.Windows.Forms.Label();
            this.textBoxClientPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxClientAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelClientAddress = new System.Windows.Forms.Label();
            this.labelClientPhone = new System.Windows.Forms.Label();
            this.textBoxClientLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelClientLastName = new System.Windows.Forms.Label();
            this.labelClearClientRoom = new System.Windows.Forms.Label();
            this.labelDeleteRoom = new System.Windows.Forms.Label();
            this.labelUpdateRoom = new System.Windows.Forms.Label();
            this.labelSaveRoom = new System.Windows.Forms.Label();
            this.btnClearClientDetails = new FontAwesome.Sharp.IconButton();
            this.btnDeleteClient = new FontAwesome.Sharp.IconButton();
            this.btnUpdateClient = new FontAwesome.Sharp.IconButton();
            this.btnSaveClient = new FontAwesome.Sharp.IconButton();
            this.textBoxClientFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxClientID = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelClientID = new System.Windows.Forms.Label();
            this.labelClientFirstName = new System.Windows.Forms.Label();
            this.errPrvClientID = new System.Windows.Forms.ErrorProvider(this.components);
            this.errPrvClientFirstName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errPrvClientLastName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errPrvClientAddress = new System.Windows.Forms.ErrorProvider(this.components);
            this.errPrvClientPhone = new System.Windows.Forms.ErrorProvider(this.components);
            this.errPrvClientEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.clientsContextMenuStrip = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.serializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsSerializeBinary = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsSerializeXML = new System.Windows.Forms.ToolStripMenuItem();
            this.exportTXTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelTopRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Client)).BeginInit();
            this.panelBottomRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errPrvClientID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPrvClientFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPrvClientLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPrvClientAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPrvClientPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPrvClientEmail)).BeginInit();
            this.clientsContextMenuStrip.SuspendLayout();
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
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panelTopRoom
            // 
            this.panelTopRoom.Controls.Add(this.dataGridView_Client);
            this.panelTopRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTopRoom.Location = new System.Drawing.Point(3, 3);
            this.panelTopRoom.Name = "panelTopRoom";
            this.panelTopRoom.Padding = new System.Windows.Forms.Padding(14);
            this.panelTopRoom.Size = new System.Drawing.Size(994, 244);
            this.panelTopRoom.TabIndex = 0;
            // 
            // dataGridView_Client
            // 
            this.dataGridView_Client.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Inter", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gainsboro;
            this.dataGridView_Client.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Client.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Client.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Client.ColumnHeadersHeight = 35;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Client.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_Client.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Client.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            this.dataGridView_Client.Location = new System.Drawing.Point(14, 14);
            this.dataGridView_Client.Name = "dataGridView_Client";
            this.dataGridView_Client.ReadOnly = true;
            this.dataGridView_Client.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Client.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_Client.RowHeadersVisible = false;
            this.dataGridView_Client.RowTemplate.Height = 27;
            this.dataGridView_Client.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Client.Size = new System.Drawing.Size(966, 216);
            this.dataGridView_Client.TabIndex = 1;
            this.dataGridView_Client.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.dataGridView_Client.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.dataGridView_Client.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Inter", 9.75F);
            this.dataGridView_Client.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Gainsboro;
            this.dataGridView_Client.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dataGridView_Client.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Gainsboro;
            this.dataGridView_Client.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.dataGridView_Client.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            this.dataGridView_Client.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            this.dataGridView_Client.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_Client.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_Client.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Gainsboro;
            this.dataGridView_Client.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_Client.ThemeStyle.HeaderStyle.Height = 35;
            this.dataGridView_Client.ThemeStyle.ReadOnly = true;
            this.dataGridView_Client.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.dataGridView_Client.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_Client.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_Client.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Gainsboro;
            this.dataGridView_Client.ThemeStyle.RowsStyle.Height = 27;
            this.dataGridView_Client.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dataGridView_Client.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Gainsboro;
            this.dataGridView_Client.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Client_CellClick);
            // 
            // panelBottomRoom
            // 
            this.panelBottomRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelBottomRoom.Controls.Add(this.textBoxClientEmail);
            this.panelBottomRoom.Controls.Add(this.labelClientEmail);
            this.panelBottomRoom.Controls.Add(this.textBoxClientPhone);
            this.panelBottomRoom.Controls.Add(this.textBoxClientAddress);
            this.panelBottomRoom.Controls.Add(this.labelClientAddress);
            this.panelBottomRoom.Controls.Add(this.labelClientPhone);
            this.panelBottomRoom.Controls.Add(this.textBoxClientLastName);
            this.panelBottomRoom.Controls.Add(this.labelClientLastName);
            this.panelBottomRoom.Controls.Add(this.labelClearClientRoom);
            this.panelBottomRoom.Controls.Add(this.labelDeleteRoom);
            this.panelBottomRoom.Controls.Add(this.labelUpdateRoom);
            this.panelBottomRoom.Controls.Add(this.labelSaveRoom);
            this.panelBottomRoom.Controls.Add(this.btnClearClientDetails);
            this.panelBottomRoom.Controls.Add(this.btnDeleteClient);
            this.panelBottomRoom.Controls.Add(this.btnUpdateClient);
            this.panelBottomRoom.Controls.Add(this.btnSaveClient);
            this.panelBottomRoom.Controls.Add(this.textBoxClientFirstName);
            this.panelBottomRoom.Controls.Add(this.textBoxClientID);
            this.panelBottomRoom.Controls.Add(this.labelClientID);
            this.panelBottomRoom.Controls.Add(this.labelClientFirstName);
            this.panelBottomRoom.Location = new System.Drawing.Point(3, 253);
            this.panelBottomRoom.Name = "panelBottomRoom";
            this.panelBottomRoom.Size = new System.Drawing.Size(994, 244);
            this.panelBottomRoom.TabIndex = 1;
            // 
            // textBoxClientEmail
            // 
            this.textBoxClientEmail.Animated = true;
            this.textBoxClientEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            this.textBoxClientEmail.BorderRadius = 6;
            this.textBoxClientEmail.BorderThickness = 2;
            this.textBoxClientEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxClientEmail.DefaultText = "";
            this.textBoxClientEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxClientEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxClientEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxClientEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxClientEmail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.textBoxClientEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxClientEmail.Font = new System.Drawing.Font("Inter", 8.25F);
            this.textBoxClientEmail.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxClientEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxClientEmail.Location = new System.Drawing.Point(683, 115);
            this.textBoxClientEmail.Name = "textBoxClientEmail";
            this.textBoxClientEmail.PasswordChar = '\0';
            this.textBoxClientEmail.PlaceholderText = "";
            this.textBoxClientEmail.SelectedText = "";
            this.textBoxClientEmail.Size = new System.Drawing.Size(155, 25);
            this.textBoxClientEmail.TabIndex = 57;
            this.textBoxClientEmail.Leave += new System.EventHandler(this.textBoxClientEmail_Leave);
            // 
            // labelClientEmail
            // 
            this.labelClientEmail.AutoSize = true;
            this.labelClientEmail.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelClientEmail.Location = new System.Drawing.Point(593, 119);
            this.labelClientEmail.Name = "labelClientEmail";
            this.labelClientEmail.Size = new System.Drawing.Size(79, 16);
            this.labelClientEmail.TabIndex = 56;
            this.labelClientEmail.Text = "Client Email";
            // 
            // textBoxClientPhone
            // 
            this.textBoxClientPhone.Animated = true;
            this.textBoxClientPhone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            this.textBoxClientPhone.BorderRadius = 6;
            this.textBoxClientPhone.BorderThickness = 2;
            this.textBoxClientPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxClientPhone.DefaultText = "";
            this.textBoxClientPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxClientPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxClientPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxClientPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxClientPhone.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.textBoxClientPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxClientPhone.Font = new System.Drawing.Font("Inter", 8.25F);
            this.textBoxClientPhone.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxClientPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxClientPhone.Location = new System.Drawing.Point(683, 67);
            this.textBoxClientPhone.Name = "textBoxClientPhone";
            this.textBoxClientPhone.PasswordChar = '\0';
            this.textBoxClientPhone.PlaceholderText = "";
            this.textBoxClientPhone.SelectedText = "";
            this.textBoxClientPhone.Size = new System.Drawing.Size(155, 25);
            this.textBoxClientPhone.TabIndex = 55;
            this.textBoxClientPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxClientPhone_KeyPress);
            // 
            // textBoxClientAddress
            // 
            this.textBoxClientAddress.Animated = true;
            this.textBoxClientAddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            this.textBoxClientAddress.BorderRadius = 6;
            this.textBoxClientAddress.BorderThickness = 2;
            this.textBoxClientAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxClientAddress.DefaultText = "";
            this.textBoxClientAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxClientAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxClientAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxClientAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxClientAddress.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.textBoxClientAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxClientAddress.Font = new System.Drawing.Font("Inter", 8.25F);
            this.textBoxClientAddress.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxClientAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxClientAddress.Location = new System.Drawing.Point(683, 20);
            this.textBoxClientAddress.Name = "textBoxClientAddress";
            this.textBoxClientAddress.PasswordChar = '\0';
            this.textBoxClientAddress.PlaceholderText = "";
            this.textBoxClientAddress.SelectedText = "";
            this.textBoxClientAddress.Size = new System.Drawing.Size(155, 25);
            this.textBoxClientAddress.TabIndex = 54;
            this.textBoxClientAddress.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxClientAddress_Validating);
            this.textBoxClientAddress.Validated += new System.EventHandler(this.textBoxClientAddress_Validated);
            // 
            // labelClientAddress
            // 
            this.labelClientAddress.AutoSize = true;
            this.labelClientAddress.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelClientAddress.Location = new System.Drawing.Point(573, 25);
            this.labelClientAddress.Name = "labelClientAddress";
            this.labelClientAddress.Size = new System.Drawing.Size(99, 16);
            this.labelClientAddress.TabIndex = 53;
            this.labelClientAddress.Text = "Client Address";
            // 
            // labelClientPhone
            // 
            this.labelClientPhone.AutoSize = true;
            this.labelClientPhone.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelClientPhone.Location = new System.Drawing.Point(585, 71);
            this.labelClientPhone.Name = "labelClientPhone";
            this.labelClientPhone.Size = new System.Drawing.Size(87, 16);
            this.labelClientPhone.TabIndex = 52;
            this.labelClientPhone.Text = "Client Phone";
            // 
            // textBoxClientLastName
            // 
            this.textBoxClientLastName.Animated = true;
            this.textBoxClientLastName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            this.textBoxClientLastName.BorderRadius = 6;
            this.textBoxClientLastName.BorderThickness = 2;
            this.textBoxClientLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxClientLastName.DefaultText = "";
            this.textBoxClientLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxClientLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxClientLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxClientLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxClientLastName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.textBoxClientLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxClientLastName.Font = new System.Drawing.Font("Inter", 8.25F);
            this.textBoxClientLastName.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxClientLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxClientLastName.Location = new System.Drawing.Point(257, 115);
            this.textBoxClientLastName.Name = "textBoxClientLastName";
            this.textBoxClientLastName.PasswordChar = '\0';
            this.textBoxClientLastName.PlaceholderText = "";
            this.textBoxClientLastName.SelectedText = "";
            this.textBoxClientLastName.Size = new System.Drawing.Size(155, 25);
            this.textBoxClientLastName.TabIndex = 51;
            this.textBoxClientLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxClientLastName_KeyPress);
            // 
            // labelClientLastName
            // 
            this.labelClientLastName.AutoSize = true;
            this.labelClientLastName.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelClientLastName.Location = new System.Drawing.Point(173, 119);
            this.labelClientLastName.Name = "labelClientLastName";
            this.labelClientLastName.Size = new System.Drawing.Size(73, 16);
            this.labelClientLastName.TabIndex = 50;
            this.labelClientLastName.Text = "Last Name";
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
            this.btnClearClientDetails.Click += new System.EventHandler(this.btnClearClientDetails_Click);
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
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
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
            this.btnSaveClient.Click += new System.EventHandler(this.btnSaveClient_Click);
            // 
            // textBoxClientFirstName
            // 
            this.textBoxClientFirstName.Animated = true;
            this.textBoxClientFirstName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            this.textBoxClientFirstName.BorderRadius = 6;
            this.textBoxClientFirstName.BorderThickness = 2;
            this.textBoxClientFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxClientFirstName.DefaultText = "";
            this.textBoxClientFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxClientFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxClientFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxClientFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxClientFirstName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.textBoxClientFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxClientFirstName.Font = new System.Drawing.Font("Inter", 8.25F);
            this.textBoxClientFirstName.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxClientFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxClientFirstName.Location = new System.Drawing.Point(257, 67);
            this.textBoxClientFirstName.Name = "textBoxClientFirstName";
            this.textBoxClientFirstName.PasswordChar = '\0';
            this.textBoxClientFirstName.PlaceholderText = "";
            this.textBoxClientFirstName.SelectedText = "";
            this.textBoxClientFirstName.Size = new System.Drawing.Size(155, 25);
            this.textBoxClientFirstName.TabIndex = 7;
            this.textBoxClientFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxClientFirstName_KeyPress);
            // 
            // textBoxClientID
            // 
            this.textBoxClientID.Animated = true;
            this.textBoxClientID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            this.textBoxClientID.BorderRadius = 6;
            this.textBoxClientID.BorderThickness = 2;
            this.textBoxClientID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxClientID.DefaultText = "";
            this.textBoxClientID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxClientID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxClientID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxClientID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxClientID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.textBoxClientID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxClientID.Font = new System.Drawing.Font("Inter", 8.25F);
            this.textBoxClientID.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxClientID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxClientID.Location = new System.Drawing.Point(257, 20);
            this.textBoxClientID.Name = "textBoxClientID";
            this.textBoxClientID.PasswordChar = '\0';
            this.textBoxClientID.PlaceholderText = "";
            this.textBoxClientID.SelectedText = "";
            this.textBoxClientID.Size = new System.Drawing.Size(155, 25);
            this.textBoxClientID.TabIndex = 4;
            this.textBoxClientID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxClientID_KeyPress);
            // 
            // labelClientID
            // 
            this.labelClientID.AutoSize = true;
            this.labelClientID.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelClientID.Location = new System.Drawing.Point(189, 25);
            this.labelClientID.Name = "labelClientID";
            this.labelClientID.Size = new System.Drawing.Size(59, 16);
            this.labelClientID.TabIndex = 1;
            this.labelClientID.Text = "Client ID";
            // 
            // labelClientFirstName
            // 
            this.labelClientFirstName.AutoSize = true;
            this.labelClientFirstName.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelClientFirstName.Location = new System.Drawing.Point(173, 71);
            this.labelClientFirstName.Name = "labelClientFirstName";
            this.labelClientFirstName.Size = new System.Drawing.Size(75, 16);
            this.labelClientFirstName.TabIndex = 0;
            this.labelClientFirstName.Text = "First Name";
            // 
            // errPrvClientID
            // 
            this.errPrvClientID.ContainerControl = this;
            // 
            // errPrvClientFirstName
            // 
            this.errPrvClientFirstName.ContainerControl = this;
            // 
            // errPrvClientLastName
            // 
            this.errPrvClientLastName.ContainerControl = this;
            // 
            // errPrvClientAddress
            // 
            this.errPrvClientAddress.ContainerControl = this;
            // 
            // errPrvClientPhone
            // 
            this.errPrvClientPhone.ContainerControl = this;
            // 
            // errPrvClientEmail
            // 
            this.errPrvClientEmail.ContainerControl = this;
            // 
            // clientsContextMenuStrip
            // 
            this.clientsContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializeToolStripMenuItem,
            this.exportTXTToolStripMenuItem});
            this.clientsContextMenuStrip.Name = "clientsContextMenuStrip";
            this.clientsContextMenuStrip.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.clientsContextMenuStrip.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.clientsContextMenuStrip.RenderStyle.ColorTable = null;
            this.clientsContextMenuStrip.RenderStyle.RoundedEdges = true;
            this.clientsContextMenuStrip.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.clientsContextMenuStrip.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.clientsContextMenuStrip.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.clientsContextMenuStrip.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.clientsContextMenuStrip.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.clientsContextMenuStrip.Size = new System.Drawing.Size(131, 48);
            // 
            // serializeToolStripMenuItem
            // 
            this.serializeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientsSerializeBinary,
            this.clientsSerializeXML});
            this.serializeToolStripMenuItem.Name = "serializeToolStripMenuItem";
            this.serializeToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.serializeToolStripMenuItem.Text = "Serialize";
            // 
            // clientsSerializeBinary
            // 
            this.clientsSerializeBinary.Name = "clientsSerializeBinary";
            this.clientsSerializeBinary.Size = new System.Drawing.Size(107, 22);
            this.clientsSerializeBinary.Text = "Binary";
            this.clientsSerializeBinary.Click += new System.EventHandler(this.binaryToolStripMenuItem_Click);
            // 
            // clientsSerializeXML
            // 
            this.clientsSerializeXML.Name = "clientsSerializeXML";
            this.clientsSerializeXML.Size = new System.Drawing.Size(107, 22);
            this.clientsSerializeXML.Text = "XML";
            this.clientsSerializeXML.Click += new System.EventHandler(this.clientsSerializeXML_Click);
            // 
            // exportTXTToolStripMenuItem
            // 
            this.exportTXTToolStripMenuItem.Name = "exportTXTToolStripMenuItem";
            this.exportTXTToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.exportTXTToolStripMenuItem.Text = "Export TXT";
            this.exportTXTToolStripMenuItem.Click += new System.EventHandler(this.exportTXTToolStripMenuItem_Click);
            // 
            // ClientsFormResponsive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(47)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.ContextMenuStrip = this.clientsContextMenuStrip;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ClientsFormResponsive";
            this.Text = "Clients";
            this.Load += new System.EventHandler(this.ClientsFormResponsive_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelTopRoom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Client)).EndInit();
            this.panelBottomRoom.ResumeLayout(false);
            this.panelBottomRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errPrvClientID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPrvClientFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPrvClientLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPrvClientAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPrvClientPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPrvClientEmail)).EndInit();
            this.clientsContextMenuStrip.ResumeLayout(false);
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
        private FontAwesome.Sharp.IconButton btnClearClientDetails;
        private FontAwesome.Sharp.IconButton btnDeleteClient;
        private FontAwesome.Sharp.IconButton btnUpdateClient;
        private FontAwesome.Sharp.IconButton btnSaveClient;
        private Guna.UI2.WinForms.Guna2TextBox textBoxClientFirstName;
        private Guna.UI2.WinForms.Guna2TextBox textBoxClientID;
        private System.Windows.Forms.Label labelClientID;
        private System.Windows.Forms.Label labelClientFirstName;
        private Guna.UI2.WinForms.Guna2TextBox textBoxClientLastName;
        private System.Windows.Forms.Label labelClientLastName;
        private Guna.UI2.WinForms.Guna2TextBox textBoxClientEmail;
        private System.Windows.Forms.Label labelClientEmail;
        private Guna.UI2.WinForms.Guna2TextBox textBoxClientPhone;
        private Guna.UI2.WinForms.Guna2TextBox textBoxClientAddress;
        private System.Windows.Forms.Label labelClientAddress;
        private System.Windows.Forms.Label labelClientPhone;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView_Client;
        private System.Windows.Forms.ErrorProvider errPrvClientID;
        private System.Windows.Forms.ErrorProvider errPrvClientFirstName;
        private System.Windows.Forms.ErrorProvider errPrvClientLastName;
        private System.Windows.Forms.ErrorProvider errPrvClientAddress;
        private System.Windows.Forms.ErrorProvider errPrvClientPhone;
        private System.Windows.Forms.ErrorProvider errPrvClientEmail;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip clientsContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem serializeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsSerializeBinary;
        private System.Windows.Forms.ToolStripMenuItem clientsSerializeXML;
        private System.Windows.Forms.ToolStripMenuItem exportTXTToolStripMenuItem;
    }
}