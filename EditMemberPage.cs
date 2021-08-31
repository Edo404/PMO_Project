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
    public partial class EditMemberPage : Form
    {
        public Member editedMember { get; set; }
        //setting values of the member
        public EditMemberPage(Member m)
        {
            InitializeComponent();
            this.editedMember = m;
            this.txtName.Text = m.Name;
            this.txtSurname.Text = m.Surname;
            this.txtRanking.Text = m.RankingsList[0].ToString();
            this.txtHeight.Text = m.Height.ToString();
            this.dtpBirthday.Value = m.BirthdayData;
            SetRadioButton();
        }

        //method for setting the radio button chosen
        private void SetRadioButton()
        {
            if (this.editedMember.Sex == "Maschio")
            {
                this.rBttnMale.Checked = true;
            }
            else
            {
                this.rBttnFemale.Checked = true;
            }

        }

        //method for setting edited dates of the relative editedMember
        private void bttnOk_Click(object sender, EventArgs e)
        {
            this.editedMember.Name = txtName.Text;
            this.editedMember.Surname = txtSurname.Text;
            this.editedMember.Height = float.Parse(txtHeight.Text);
            this.editedMember.RankingsList.RemoveAt(0);
            this.editedMember.RankingsList.Insert(0, int.Parse(txtRanking.Text));
            this.editedMember.BirthdayData = dtpBirthday.Value;
            this.editedMember.Age = this.editedMember.AgeCalculator(dtpBirthday.Value);
            if (rBttnFemale.Checked)
            {
                this.editedMember.Sex = "Femmina";
            }
            else
            {
                this.editedMember.Sex = "Maschio";
            }
            
            Close();
        }
        
        //method for closing the form
        private void bttnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        //method for blocking wrong inputs
        internal void HandleInput(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar == ',');
        }
       

    }
}
