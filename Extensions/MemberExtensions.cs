using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEMBERS_MANAGER.Extensions
{
    public static class MemberExtensions
    {
        public static ListViewItem ToListViewItem(this Member member)
        {
            string[] row = { member.Name, member.Surname, member.LastRanking(member.RankingsList).ToString(),
                member.Height.ToString()+" m", member.Sex, member.Age.ToString()+" anni" };
            return new ListViewItem(row);
        }


    }
}
