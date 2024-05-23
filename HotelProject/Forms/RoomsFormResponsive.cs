using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelProject.Forms
{
    public partial class RoomsFormResponsive : Form
    {
        List<Room> rooms = new List<Room>();
        public RoomsFormResponsive()
        {
            InitializeComponent();

        }
        private void RoomsFormResponsive_Load(object sender, EventArgs e)
        {
            LoadRoomsType();
            LoadRoomsList();
        }
        private void LoadRoomsType()
        {
            comboBoxRoomType.DataSource = SqliteDataAccess.LoadRoomType();
            comboBoxRoomType.DisplayMember = "Label";
            comboBoxRoomType.ValueMember = "CategoryID";

        }
        private void LoadRoomsList()
        {
            rooms = SqliteDataAccess.LoadRooms();
            WireUpRoomList();
        }

        private void WireUpRoomList()
        {
            dataGridView_Room.DataSource = null;
            dataGridView_Room.DataSource = rooms;
        }

        private void btnSaveRoom_Click(object sender, EventArgs e)
        {
            if (textBoxRoomNumber.Text == "")
            {
                MessageBox.Show("Room Number - Required Field", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (textBoxRoomPhone.Text == "")
            {
                MessageBox.Show("Room Phone - Required Field", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (radButFree.Checked == false && radButBusy.Checked == false)
            {
                MessageBox.Show("Please select room status", "Room Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int roomNumber = Convert.ToInt32(textBoxRoomNumber.Text);
                string roomPhone = textBoxRoomPhone.Text;
                string roomType = comboBoxRoomType.GetItemText(comboBoxRoomType.SelectedItem);
                string roomStatus = radButFree.Checked ? "Free" : "Busy";

                try
                {
                    if (SqliteDataAccess.AddRoom(roomNumber, roomType, roomPhone, roomStatus))
                    {
                        // MessageBox.Show("Room Added Successfuly", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadRoomsList();
                        btnClearRoomDetails.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Room Not Added", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btnUpdateRoom_Click(object sender, EventArgs e)
        {
            if (textBoxRoomNumber.Text == "")
            {
                MessageBox.Show("Room Number - Required Field", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (radButFree.Checked == false && radButBusy.Checked == false)
            {
                MessageBox.Show("Please select room status", "Room Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxRoomPhone.Text == "")
            {
                MessageBox.Show("Room Phone - Required Field", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int roomNumber = Convert.ToInt32(textBoxRoomNumber.Text);
                string roomPhone = textBoxRoomPhone.Text;
                string roomType = comboBoxRoomType.GetItemText(comboBoxRoomType.SelectedItem);
                string roomStatus = radButFree.Checked ? "Free" : "Busy";
                try
                {
                    if (SqliteDataAccess.EditRoom(roomNumber, roomType, roomPhone, roomStatus))
                    {
                        // MessageBox.Show("Room Edited Successfuly", "Edit Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadRoomsList();
                        btnClearRoomDetails.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Room Not Edited", "Edit Room", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            if (textBoxRoomNumber.Text == "")
            {
                MessageBox.Show("Room Number - Required Field", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                try
                {
                    int roomNumber = Convert.ToInt32(textBoxRoomNumber.Text);
                    Boolean deleteGuest = SqliteDataAccess.DeleteRoom(roomNumber);
                    if (deleteGuest)
                    {
                        // MessageBox.Show("Room deleted successfuly", "Room Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadRoomsList();
                        btnClearRoomDetails.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("ERROR - Room not deleted", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btnClearRoomDetails_Click(object sender, EventArgs e)
        {
            textBoxRoomNumber.Clear();
            textBoxRoomPhone.Clear();
            comboBoxRoomType.SelectedIndex = 0;
            radButBusy.Checked = false;
            radButFree.Checked = false;
        }
        private void dataGridView_Room_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_Room.CurrentRow != null)
            {
                LoadRoomsType();
                textBoxRoomNumber.Text = dataGridView_Room.CurrentRow.Cells[0].Value.ToString();
                comboBoxRoomType.SelectedIndex = comboBoxRoomType.FindStringExact(dataGridView_Room.CurrentRow.Cells[1].Value.ToString());
                textBoxRoomPhone.Text = dataGridView_Room.CurrentRow.Cells[2].Value.ToString();
                // radio button
                string radioButton = dataGridView_Room.CurrentRow.Cells[3].Value.ToString();

                if (radioButton.Equals("Free"))
                {
                    radButFree.Checked = true;
                }
                else
                {
                    radButBusy.Checked = true;
                }
            }

        }
        // Allow only numbers in the room number text box and if the user tries to enter letters and errorProvider pops up
        private void textBoxRoomNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isDigit = e.KeyChar >= '0' && e.KeyChar <= '9';
            bool isBackspace = e.KeyChar == '\b';

            if (!isDigit && !isBackspace)
            {
                errPrvRoomPhone.SetError((Control)sender, "Letters are not allowed!");
                e.Handled = true;
            } else
            {
                errPrvRoomPhone.SetError((Control)sender, string.Empty);
            }
        }

        // Allow only numbers in the room phone text box and if the user tries to enter letters and errorProvider pops up
        private void textBoxRoomPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isDigit = e.KeyChar >= '0' && e.KeyChar <= '9';
            bool isBackspace = e.KeyChar == '\b';

            if (!isDigit && !isBackspace)
            {
                errPrvRoomNumber.SetError((Control)sender, "Letters are not allowed!");
                e.Handled = true;
            }
            else
            {
                errPrvRoomNumber.SetError((Control)sender, string.Empty);
            }
        }

        private void roomsSerializeBinary_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            SaveFileDialog sfd = new SaveFileDialog();

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = File.Create(sfd.FileName))
                {
                    bf.Serialize(fs, rooms);
                }
            }
        }

        private void roomsSerializeXML_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Room>));
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = File.Create(sfd.FileName))
                {
                    serializer.Serialize(fs, rooms);
                }
            }
        }
    }
}
