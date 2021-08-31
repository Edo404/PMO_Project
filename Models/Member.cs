using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEMBERS_MANAGER
{
    public class Member
    {
        public String Name { get; set; }
        public String Surname { get; set; }
        public String Sex { get; set; }
        public float Height{ get; set; }
        public DateTime BirthdayData { get; set; }
        public int Age { get; set; }
        public List<int> RankingsList { get; set; }
        public List<DateTime> DateList { get; set; }
        
        //setting fields
        public Member(String name,String surname,int ranking,float height,String sex, DateTime bData)
        {
            this.Name = name;
            this.Surname = surname;
            this.Height = height;
            this.Sex = sex;
            this.BirthdayData = bData;
            this.RankingsList = new List<int>();
            this.RankingsList.Add(ranking);
            this.DateList = new List<DateTime>();
            this.Age = AgeCalculator(bData);
        }

        //method for calculating the member's age 
        public int AgeCalculator(DateTime bData)
        {
            DateTime from = bData;
            DateTime to = DateTime.Now;
            TimeSpan timeSpan = to - from;
            int days = timeSpan.Days;
            int age = (int) (days / 365.242199);
            return age;
        }
       
        //method returns the last ranking of the rankingslist
        public int LastRanking(List<int> list)
        {
            return list[(list.Count - 1)];
        }
       
        //method that returns the last date of datelist
        public DateTime LastDate(List<DateTime> list)
        {
            return list[(list.Count - 1)];
        }

        //method for searching that returns the minimun ranking of the rankingslist.
        //the lower number, the higher ranking
        public int FindMinimumRanking()
        {
            int attuale;
            int minimum = 0;
            int minL = 999999;
            for (int i = 0; i < this.RankingsList.Count; i++)
            {
                attuale = this.RankingsList[i];
                if (attuale < minL)
                {
                    minL = attuale;
                    minimum = attuale;
                }
            }
            return minimum;
        }

    }
}
