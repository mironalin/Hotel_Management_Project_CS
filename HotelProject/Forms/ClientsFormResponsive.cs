using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace HotelProject.Forms
{
    public partial class ClientsFormResponsive : Form
    {
        List<Client> clients = new List<Client>();
        public ClientsFormResponsive()
        {
            InitializeComponent();
        }

        private void ClientsFormResponsive_Load(object sender, EventArgs e)
        {
            LoadClientsList();
        }

        private void LoadClientsList()
        {
            clients = SqliteDataAccess.LoadClients();
            WireUpClientList();
        }

        private void WireUpClientList()
        {
            dataGridView_Client.DataSource = null;
            dataGridView_Client.DataSource = clients;
        }

        private void btnSaveClient_Click(object sender, EventArgs e)
        {
            if (textBoxClientID.Text == "")
            {
                MessageBox.Show("Client ID - Required Field", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (textBoxClientFirstName.Text == "")
            {
                MessageBox.Show("Client First Name - Required Field", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (textBoxClientLastName.Text == "")
            {
                MessageBox.Show("Client Last Name - Required Field", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (textBoxClientPhone.Text == "")
            {
                MessageBox.Show("Client Phone - Required Field", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (textBoxClientAddress.Text == "")
            {
                MessageBox.Show("Client Address - Required Field", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (textBoxClientEmail.Text == "")
            {
                MessageBox.Show("Client E-mail - Required Field", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int clientID = Convert.ToInt32(textBoxClientID.Text.Trim());
                string clientFirstName = textBoxClientFirstName.Text.Trim();
                string clientLastName = textBoxClientLastName.Text.Trim();
                string clientAddress = textBoxClientAddress.Text.Trim();
                string clientPhone = textBoxClientPhone.Text.Trim();
                string clientEmail = textBoxClientEmail.Text.Trim();

                try
                {
                    if (SqliteDataAccess.AddClient(clientID, clientFirstName, clientLastName, clientAddress, clientPhone, clientEmail))
                    {
                        LoadClientsList();
                        btnClearClientDetails.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Client Not Added", "Client Room", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
            if (textBoxClientID.Text == "")
            {
                MessageBox.Show("Client ID - Required Field", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (textBoxClientFirstName.Text == "")
            {
                MessageBox.Show("Client First Name - Required Field", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (textBoxClientLastName.Text == "")
            {
                MessageBox.Show("Client Last Name - Required Field", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (textBoxClientPhone.Text == "")
            {
                MessageBox.Show("Client Phone - Required Field", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (textBoxClientAddress.Text == "")
            {
                MessageBox.Show("Client Address - Required Field", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (textBoxClientEmail.Text == "")
            {
                MessageBox.Show("Client E-mail - Required Field", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int clientID = Convert.ToInt32(textBoxClientID.Text);
                string clientFirstName = textBoxClientFirstName.Text.Trim();
                string clientLastName = textBoxClientLastName.Text.Trim();
                string clientAddress = textBoxClientAddress.Text.Trim();
                string clientPhone = textBoxClientPhone.Text.Trim();
                string clientEmail = textBoxClientEmail.Text.Trim();

                try
                {
                    if (SqliteDataAccess.EditClient(clientID, clientFirstName, clientLastName, clientAddress, clientPhone, clientEmail))
                    {
                        LoadClientsList();
                        btnClearClientDetails.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Client Not Edited", "Client Room", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            if (textBoxClientID.Text == "")
            {
                MessageBox.Show("Client ID - Required Field", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    int clientID = Convert.ToInt32(textBoxClientID.Text.Trim());
                    Boolean deleteGuest = SqliteDataAccess.DeleteClient(clientID);
                    if (deleteGuest)
                    {
                        // MessageBox.Show("Room deleted successfuly", "Room Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadClientsList();
                        btnClearClientDetails.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("ERROR - Client not deleted", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btnClearClientDetails_Click(object sender, EventArgs e)
        {
            textBoxClientID.Clear();
            textBoxClientFirstName.Clear();
            textBoxClientLastName.Clear();
            textBoxClientAddress.Clear();
            textBoxClientPhone.Clear();
            textBoxClientEmail.Clear();
        }

        private void dataGridView_Client_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_Client.CurrentRow != null)
            {
                textBoxClientID.Text = dataGridView_Client.CurrentRow.Cells[0].Value.ToString();
                textBoxClientFirstName.Text = dataGridView_Client.CurrentRow.Cells[1].Value.ToString();
                textBoxClientLastName.Text = dataGridView_Client.CurrentRow.Cells[2].Value.ToString();
                textBoxClientAddress.Text = dataGridView_Client.CurrentRow.Cells[3].Value.ToString();
                textBoxClientPhone.Text = dataGridView_Client.CurrentRow.Cells[4].Value.ToString();
                textBoxClientEmail.Text = dataGridView_Client.CurrentRow.Cells[5].Value.ToString();
            }
        }

        private void textBoxClientID_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isDigit = e.KeyChar >= '0' && e.KeyChar <= '9';
            bool isBackspace = e.KeyChar == '\b';

            if (!isDigit && !isBackspace)
            {
                errPrvClientID.SetError((Control)sender, "Letters are not allowed!");
                e.Handled = true;
            }
            else
            {
                errPrvClientID.SetError((Control)sender, string.Empty);
            }
        }

        private void textBoxClientFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isDigit = e.KeyChar >= '0' && e.KeyChar <= '9';

            if (isDigit)
            {
                errPrvClientFirstName.SetError((Control)sender, "Digits are not allowed!");
                e.Handled = true;
            }
            else
            {
                errPrvClientFirstName.SetError((Control)sender, string.Empty);
            }
        }

        private void textBoxClientLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isDigit = e.KeyChar >= '0' && e.KeyChar <= '9';

            if (isDigit)
            {
                errPrvClientLastName.SetError((Control)sender, "Digits are not allowed!");
                e.Handled = true;
            }
            else
            {
                errPrvClientLastName.SetError((Control)sender, string.Empty);
            }
        }

        private void textBoxClientPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isDigit = e.KeyChar >= '0' && e.KeyChar <= '9';
            bool isBackspace = e.KeyChar == '\b';

            if (!isDigit && !isBackspace)
            {
                errPrvClientPhone.SetError((Control)sender, "Letters are not allowed!");
                e.Handled = true;
            }
            else
            {
                errPrvClientPhone.SetError((Control)sender, string.Empty);
            }
        }

        private void textBoxClientEmail_Leave(object sender, EventArgs e)
        {
            Regex mRegxExpression;
            if (textBoxClientEmail.Text.Trim() != string.Empty)
            {
                mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                if (!mRegxExpression.IsMatch(textBoxClientEmail.Text.Trim()))
                {
                    errPrvClientEmail.SetError((Control)sender, "E-mail address is not valid!");
                    MessageBox.Show("E-mail address format is not correct.", "E-mail Address", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxClientEmail.Focus();
                }
                else
                {
                    errPrvClientEmail.SetError((Control)sender, string.Empty);
                }
            }
        }

        private void textBoxClientAddress_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxClientAddress.Text.Trim() == "")
            {
                e.Cancel = true;
                errPrvClientAddress.SetError((Control)sender, "Can't be empty");
            }
        }

        private void textBoxClientAddress_Validated(object sender, EventArgs e)
        {
            errPrvClientAddress.SetError((Control)sender, string.Empty);
        }

        private void binaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            SaveFileDialog sfd = new SaveFileDialog();

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = File.Create(sfd.FileName))
                {
                    bf.Serialize(fs, clients);
                }
            }
        }

        private void clientsSerializeXML_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Client>));
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = File.Create(sfd.FileName))
                {
                    serializer.Serialize(fs, clients);
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
                    sw.WriteLine("FirstName, LastName, ClientAddress, ClientPhone, ClientEmail");

                    foreach (var client in clients)
                    {
                        sw.WriteLine("\"{0}\", \"{1}\", \"{2}\", \"{3}\", \"{4}\""
                                    , client.ClientFirstName.Replace("\"", "\"\"")
                                    , client.ClientLastName.Replace("\"", "\"\"")
                                    , client.ClientAddress.Replace("\"", "\"\"")
                                    , client.ClientPhone.Replace("\"", "\"\"")
                                    , client.ClientEmail.Replace("\"", "\"\""));
                    }
                }
            }
        }
    }
}
