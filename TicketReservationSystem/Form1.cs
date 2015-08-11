using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketReservationSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Customer newCust;
            string name = txtName.Text, 
                   custType = cboxCustType.SelectedItem.ToString();
           
            if (custType == "Regular"){   
             //   newCust = new Regular(name);
                msgCustDetails.Text = displayCustMsg(name, custType);
            }
            else if (custType == "Member"){
            //    newCust = new Member(name);
                msgCustDetails.Text = displayCustMsg(name, custType);
            }

            cboxCustType.Enabled = false;
            txtName.Enabled = false;
        }

        public string displayCustMsg(string name, string custType)
        { return "Your Name : " + name + "\nYour Type : " + custType; }
    }
}
