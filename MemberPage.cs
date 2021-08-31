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
    public partial class MemberPage : Form
    {
        private Member memberStats;
        public MemberPage(Member m)
        {
            InitializeComponent();
            this.memberStats = m;
            this.txtName.Text = m.Name;
            this.txtSurname.Text = m.Surname;
            this.txtFirstRanking.Text = m.RankingsList[0].ToString();
            this.txtLastRanking.Text = m.LastRanking(m.RankingsList).ToString();
            this.txtHeight.Text = m.Height.ToString();
            this.txtAge.Text = m.Age.ToString();
            this.txtSex.Text = m.Sex;
            this.dtpFirstRanking.Value = m.DateList[0];
            this.dtpLastRanking.Value = m.LastDate(m.DateList);
            this.txtAverageRanking.Text = AverageRankingCalculator().ToString();
            this.txtRankingChanged.Text = RankingChangedCalculator().ToString();
        }

        //method for the calculation of the difference between the first and last ranking
        private int RankingChangedCalculator()
        {
            int lastRanking;
            int firstRanking;
            int rankingChanged;
            lastRanking = memberStats.LastRanking(memberStats.RankingsList);
            firstRanking = memberStats.RankingsList[0];
            rankingChanged = Math.Abs(lastRanking - firstRanking);
            //approximation to 1 number after the decimal point
            return rankingChanged;
        }

        //method for the calculation of the average ranking of the selected member
        private int AverageRankingCalculator()
        {
            int averageRanking;
            int lastRanking;
            int firstRanking;
            lastRanking = memberStats.LastRanking(memberStats.RankingsList);
            firstRanking = memberStats.RankingsList[0];
            averageRanking = (lastRanking + firstRanking) / 2;
            //approximation to 1 number after the decimal point
            return averageRanking;
        }
        
        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
