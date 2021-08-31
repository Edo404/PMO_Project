using MEMBERS_MANAGER;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEMBERS_MANAGER
{
    public partial class NewMemberPage : Form
    {
        private String sex;
        public List<Member> members { get; set; }
        
        public NewMemberPage(List<Member> members)
        {
            InitializeComponent();
            this.members = members;
            this.sex = null;
  
        }
        
        //method for adding a member inside the members' list and the data inside the dateList
        private void AddMember()
        {
            var member = new Member(txtName.Text, txtSurname.Text, int.Parse(txtRanking.Text),
                float.Parse(txtHeight.Text), sex, dtpBirthday.Value);
            members.Add(member);
            member.DateList.Add(DateTime.Now);
        }

        //method for checking and adding a new member clicking OK
        private void bttnOk_Click(object sender, EventArgs e)
        {
            
            if (CheckFields())
            {
                CheckRadioBttn();
                AddMember();
                Close();
            }
            else
            {
                MessageBox.Show("Riempi tutti i campi!");
            }
           
        }

        //method for the annulment of the creation of a new member clicking Cancel
        private void bttnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
                
        //method for checking data fields
        private bool CheckFields()
        {
            return !string.IsNullOrEmpty(txtName.Text)
                && !string.IsNullOrEmpty(txtSurname.Text)
                && !string.IsNullOrEmpty(txtRanking.Text)
                && !string.IsNullOrEmpty(txtHeight.Text)
                && (rBttnFemale.Checked 
                ||  rBttnMale.Checked);       
        }

        //method for checking the radio buttons
        private void CheckRadioBttn()
        {
            if (rBttnFemale.Checked)
            {
                sex = "Femmina";
            }
            else
            {
                sex = "Maschio";
            }

        }

        //method for blocking wrong inputs
        internal void HandleInput(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar == ',');
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }
    }
}
