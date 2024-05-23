using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using FontAwesome.Sharp;
//using HotelProject.Entities;
using HotelProject.Forms;
using Color = System.Drawing.Color;

namespace HotelProject
{
    public partial class MainForm : Form
    {
        // Remove flickering when opening and closing child forms
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }

        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        
        public MainForm()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(10, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            menuStrip1.Renderer = new ToolStripProfessionalRenderer(new LeftMenuColorTable());


        }

        private struct Colors
        {
            public static Color color1 = Color.FromArgb(255, 230, 230);
            public static Color color2 = Color.FromArgb(225, 175, 209);
            public static Color color3 = Color.FromArgb(173, 136, 198);
            public static Color color4 = Color.FromArgb(116, 105, 182);
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(36, 43, 51);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void ActivateButton(object sender, Color color)
        {
            if (sender != null)
            {
                DisableButton();
                currentBtn = (IconButton) sender;
                currentBtn.BackColor = Color.FromArgb(49, 54, 63);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitleChildForm.Text = childForm.Text;
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.DarkSlateGray;
            labelTitleChildForm.Text = "Home";
        }
        private void iconButtonRooms_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Colors.color1);
            RoomsFormResponsive RoomForm = new RoomsFormResponsive();
            OpenChildForm(RoomForm);
        }

        private void iconButtonClients_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Colors.color2);
            OpenChildForm(new ClientsFormResponsive());
        }

        private void iconButtonReservations_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Colors.color3);
            OpenChildForm(new ReservationsFormResponsive());
        }

        private void iconButtonDashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Colors.color4);
            OpenChildForm(new DashboardFormResponsive());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }
        
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }

            base.WndProc(ref m);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        public class submenuColorTable : ProfessionalColorTable
        {
            public override Color MenuItemSelected
            {
                get { return ColorTranslator.FromHtml("#302E2D"); }
            }

            public override Color MenuItemBorder
            {
                get { return Color.Silver; }
            }

            public override Color ToolStripDropDownBackground
            {
                get { return ColorTranslator.FromHtml("#21201F"); }
            }

            public override Color ToolStripContentPanelGradientBegin
            {
                get { return ColorTranslator.FromHtml("#21201F"); }
            }
        }

        public class LeftMenuColorTable : ProfessionalColorTable
        {
            public override Color MenuItemBorder
            {
                get { return ColorTranslator.FromHtml("#BAB9B9"); }
            }

            public override Color MenuBorder  //added for changing the menu border
            {
                get { return Color.Silver; }
            }

            public override Color MenuItemPressedGradientBegin
            {
                get { return ColorTranslator.FromHtml("#4C4A48"); }
            }
            public override Color MenuItemPressedGradientEnd
            {
                get { return ColorTranslator.FromHtml("#5F5D5B"); }
            }

            public override Color ToolStripBorder
            {
                get { return ColorTranslator.FromHtml("#4C4A48"); }
            }

            public override Color MenuItemSelectedGradientBegin
            {
                get { return ColorTranslator.FromHtml("#4C4A48"); }
            }

            public override Color MenuItemSelectedGradientEnd
            {
                get { return ColorTranslator.FromHtml("#5F5D5B"); }
            }

            public override Color ToolStripDropDownBackground
            {
                get { return ColorTranslator.FromHtml("#404040"); }
            }

            public override Color ToolStripGradientBegin
            {
                get { return ColorTranslator.FromHtml("#404040"); }
            }

            public override Color ToolStripGradientEnd
            {
                get { return ColorTranslator.FromHtml("#404040"); }
            }

            public override Color ToolStripGradientMiddle
            {
                get { return ColorTranslator.FromHtml("#404040"); }
            }
        }
    }
}
