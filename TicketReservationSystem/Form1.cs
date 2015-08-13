using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace TicketReservationSystem
{
    public partial class CustomerLogin : Form
    {
        OleDbConnection libraryConn;
        OleDbCommand oledbCmd = new OleDbCommand();
        string connectionString =
            @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Jet\Desktop\Plane-Ticket-Reservation-System\AirAsianDataBase.mdb";

        public CustomerLogin()
        {
            InitializeComponent();
            libraryConn = new OleDbConnection(connectionString);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            libraryConn.Open();
            try
            {
                string name = txtName.Text;
                string email = txtEmail.Text;
                string contactnumber = txtHP.Text;
                string gender;

                if (MaleRadioButton.Checked == true)
                    gender = "Male";
                else
                    gender = "Female";

                int birthdayDate = Convert.ToInt16(comboBoxDate.SelectedItem.ToString());
                int birthdayMonth = Convert.ToInt16(comboBoxMonth.SelectedItem.ToString());
                int birthdayYear = Convert.ToInt16(comboBoxYear.SelectedItem.ToString());
                string membership = cboxCustType.SelectedItem.ToString();

                string insertstring = "Insert into Customer ([FullName], [Gender], [BirthdayDate], [BirthdayMonth], [BirthdayYear], [Contact], [Email], [MemberShip]) values (@name,@gender,@birthdayDate,@birthdayMoth,@birthdayYear,@contactnumber, @email, @membership)";

                oledbCmd.Connection = libraryConn;
                oledbCmd.CommandText = insertstring;
                oledbCmd.Parameters.AddWithValue("@name", name);
                oledbCmd.Parameters.AddWithValue("@gender", gender);
                oledbCmd.Parameters.AddWithValue("@birthdayDate", birthdayDate);
                oledbCmd.Parameters.AddWithValue("@birthdayMonth", birthdayMonth);
                oledbCmd.Parameters.AddWithValue("@birthdayYear", birthdayYear);
                oledbCmd.Parameters.AddWithValue("@contactnumber", contactnumber);
                oledbCmd.Parameters.AddWithValue("@email", email);
                oledbCmd.Parameters.AddWithValue("@membership", membership);

                int temp = oledbCmd.ExecuteNonQuery();

                if (temp > 0)
                {
                    MessageBox.Show("Registered successfully!");
                }
                else
                {
                    MessageBox.Show("Error occured! Unable to register!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            libraryConn.Close();                // close the connection to the database
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            libraryConn.Open();                                         // 4. open the connection to the database
            string loginName = txtLoginName.Text;

            string strSelect = "Select * from Customer where [LibraryID] = @ID";                //5. prepare to select data from database
            OleDbDataAdapter da = new OleDbDataAdapter(strSelect, libraryConn);
            da.SelectCommand.Parameters.AddWithValue("@ID", txtID.Text);
            OleDbCommandBuilder cBuilder = new OleDbCommandBuilder(da);

            DataTable datatable = new DataTable();

            //use the da to fill in the data that retrieve from the table
            da.Fill(datatable);

            if (datatable.Rows.Count > 0)
            {
                this.Hide();
                MainMenu m = new MainMenu();
                m.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login Fail, please try again!");
            }

            libraryConn.Close();                // close the connection to the database
        }
    }
}
