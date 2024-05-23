using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace HotelProject.Forms
{
    public partial class ReservationsFormResponsive : Form
    {
        List<Reservation> reservations= new List<Reservation>();
        public ReservationsFormResponsive()
        {
            InitializeComponent();
        }

        private void ReservationsFormResponsive_Load(object sender, EventArgs e)
        {
            dateTimePickerCheckInDate.Value = DateTime.Now;
            dateTimePickerCheckOutDate.Value = DateTime.Now;
            LoadClientsIDs();
            LoadRoomsIDs();
            LoadReservationsList();
        }

        private void LoadRoomsIDs()
        {
            comboBoxRoomId.DataSource = SqliteDataAccess.LoadRoomIDs();
            comboBoxRoomId.DisplayMember = "RoomNumber";
            comboBoxRoomId.ValueMember = "RoomNumber";
        }

        private void LoadClientsIDs()
        {
            comboBoxClientId.DataSource = SqliteDataAccess.LoadClientIDs();
            comboBoxClientId.DisplayMember = "FullName";
            comboBoxClientId.ValueMember = "ClientID";

        }

        private void LoadReservationsList()
        {
            reservations = SqliteDataAccess.LoadReservations();
            WireUpReservationList();
        }

        private void WireUpReservationList()
        {
            dataGridView_Reservation.DataSource = null;
            dataGridView_Reservation.DataSource = reservations;
        }

        private void btnSaveReservation_Click(object sender, EventArgs e)
        {
            if (textboxReservationID.Text == "")
            {
                MessageBox.Show("Reservation ID - Required Field", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int reservationID = Convert.ToInt32(textboxReservationID.Text);
                int clientID = Convert.ToInt32(comboBoxClientId.SelectedValue.GetHashCode()); ;
                int roomNumber = Convert.ToInt32(comboBoxRoomId.SelectedValue.GetHashCode());

                Console.WriteLine("Res: " + reservationID + " Room: " + roomNumber + " Client: " + clientID);

                DateTime checkInDate = dateTimePickerCheckInDate.Value;
                DateTime checkOutDate = dateTimePickerCheckOutDate.Value;
                try
                {
                    if (SqliteDataAccess.AddReservation(reservationID, clientID, roomNumber, checkInDate, checkOutDate))
                    {
                        SqliteDataAccess.UpdateRoomStatus(roomNumber, "Busy");
                        LoadReservationsList();
                        btnClearReservationDetails.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Reservation Not Added", "Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            if (textboxReservationID.Text == "")
            {
                MessageBox.Show("Reservation ID - Required Field", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int reservationID = Convert.ToInt32(textboxReservationID.Text);
                int clientID = Convert.ToInt32(comboBoxClientId.SelectedValue.GetHashCode()); ;
                int roomNumber = Convert.ToInt32(comboBoxRoomId.SelectedValue.GetHashCode());

                // debugging
                Console.WriteLine("Res: " + reservationID + " Room: " + roomNumber + " Client: " + clientID);

                DateTime checkInDate = dateTimePickerCheckInDate.Value;
                DateTime checkOutDate = dateTimePickerCheckOutDate.Value;
                if (roomNumber != Convert.ToInt32(dataGridView_Reservation.CurrentRow.Cells[2].Value.ToString()))
                {
                    try
                    {
                        if (SqliteDataAccess.EditReservation(reservationID, clientID, roomNumber, checkInDate, checkOutDate))
                        {
                            SqliteDataAccess.UpdateRoomStatus(roomNumber, "Busy");
                            SqliteDataAccess.UpdateRoomStatus(Convert.ToInt32(dataGridView_Reservation.CurrentRow.Cells[2].Value.ToString()), "Free");
                            LoadReservationsList();
                            btnClearReservationDetails.PerformClick();
                        }
                        else
                        {
                            MessageBox.Show("Reservation Not Added", "Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    try
                    {
                        if (SqliteDataAccess.EditReservation(reservationID, clientID, roomNumber, checkInDate, checkOutDate))
                        {
                            SqliteDataAccess.UpdateRoomStatus(roomNumber, "Busy");

                            LoadReservationsList();
                            btnClearReservationDetails.PerformClick();
                        }
                        else
                        {
                            MessageBox.Show("Reservation Not Added", "Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                
            }
        }

        private void dataGridView_Reservation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_Reservation.CurrentRow != null)
            {
                SqliteDataAccess.UpdateRoomStatus(Convert.ToInt32(dataGridView_Reservation.CurrentRow.Cells[2].Value.ToString()), "Free");
                LoadClientsIDs();
                LoadRoomsIDs();
                SqliteDataAccess.UpdateRoomStatus(Convert.ToInt32(dataGridView_Reservation.CurrentRow.Cells[2].Value.ToString()), "Busy");
                textboxReservationID.Text = dataGridView_Reservation.CurrentRow.Cells[0].Value.ToString();
                comboBoxClientId.SelectedValue = dataGridView_Reservation.CurrentRow.Cells[1].Value.ToString();
                Console.Write(dataGridView_Reservation.CurrentRow.Cells[1].Value.ToString());
                comboBoxRoomId.SelectedIndex = comboBoxRoomId.FindStringExact(dataGridView_Reservation.CurrentRow.Cells[2].Value.ToString());
                dateTimePickerCheckInDate.Value = DateTime.Parse(dataGridView_Reservation.CurrentRow.Cells[3].Value.ToString());
                dateTimePickerCheckOutDate.Value = DateTime.Parse(dataGridView_Reservation.CurrentRow.Cells[4].Value.ToString());
            }
        }

        private void btnClearReservationDetails_Click(object sender, EventArgs e)
        {
            textboxReservationID.Clear();
            comboBoxClientId.SelectedIndex = 0;
            comboBoxRoomId.SelectedIndex = 0;
            dateTimePickerCheckInDate.Value = DateTime.Now;
            dateTimePickerCheckOutDate.Value = DateTime.Now;
        }

        private void textboxReservationID_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isDigit = e.KeyChar >= '0' && e.KeyChar <= '9';
            bool isBackspace = e.KeyChar == '\b';

            if (!isDigit && !isBackspace)
            {
                errPrvReservationID.SetError((Control)sender, "Letters are not allowed!");
                e.Handled = true;
            }
            else
            {
                errPrvReservationID.SetError((Control)sender, string.Empty);
            }
        }

        private void btnDeleteReservation_Click(object sender, EventArgs e)
        {
            if (textboxReservationID.Text == "")
            {
                MessageBox.Show("Reservation ID - Required Field", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    int reservationID = Convert.ToInt32(textboxReservationID.Text);
                    Boolean deleteGuest = SqliteDataAccess.DeleteReservation(reservationID);
                    if (deleteGuest)
                    {
                        // MessageBox.Show("Room deleted successfuly", "Room Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadReservationsList();
                        btnClearReservationDetails.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("ERROR - Reservation not deleted", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void reservationsSerializeBinary_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            SaveFileDialog sfd = new SaveFileDialog();

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = File.Create(sfd.FileName))
                {
                    bf.Serialize(fs, reservations);
                }
            }
        }

        private void reservationsSerializeXML_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Reservation>));
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = File.Create(sfd.FileName))
                {
                    serializer.Serialize(fs, reservations);
                }
            }
        }

        private void exportTXTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File | *.txt";
            saveFileDialog.Title = "Save clients as text file";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = File.CreateText(saveFileDialog.FileName))

                {
                    sw.WriteLine("ReservationID, ClientID, RoomNumber, CheckInDate, CheckOutDate");

                    foreach (var reservation in reservations)
                    {
                        sw.WriteLine("\"{0}\", \"{1}\", \"{2}\", \"{3}\", \"{4}\""
                                    , reservation.ReservationID.ToString().Replace("\"", "\"\"")
                                    , reservation.ClientID.ToString().Replace("\"", "\"\"")
                                    , reservation.RoomNumber.ToString().Replace("\"", "\"\"")
                                    , reservation.CheckInDate.ToString().Replace("\"", "\"\"")
                                    , reservation.CheckOutDate.ToString().Replace("\"", "\"\""));
                    }
                }
            }
        }
    }
}
