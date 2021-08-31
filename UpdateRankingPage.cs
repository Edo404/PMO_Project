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
    public partial class UpdateRankingPage : Form
    {
      
        public Member member { get; set; }
        public UpdateRankingPage(Member m)
        {
            InitializeComponent();
            this.member = m;
            //command for setting as minimum date possibly selectable, the last date of the list.
            //this gives to the user the possibility to select only future dates.
            this.dtpRankingData.MinDate = m.LastDate(m.DateList);
            
        }
       
        //method for updating the ranking inserting it inside the member's list of rankings
        private void bttnOk_Click(object sender, EventArgs e)
        {
            member.RankingsList.Add(int.Parse(txtRanking.Text));
            member.DateList.Add(dtpRankingData.Value);
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

        private void UpdateRankingPage_Load(object sender, EventArgs e)
        {

        }
    } 
}
