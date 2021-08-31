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
using MEMBERS_MANAGER.Extensions;

namespace MEMBERS_MANAGER
{
    public partial class MainPage : Form
    {
        //index used to insert in the correct line of the listview, a member
        private int index;
        private List<Member> members;
        private ListViewItem memberItem;
        private DBclass dbHandler;

        public MainPage()
        {
            InitializeComponent();
            this.members = new List<Member>();
            //use of the pattern singleton
            dbHandler = DBclass.GetInstance();
            //loading the database
            LoadDB();
            //loaded the database, the index is initialized based on the number of the members of the listview
            this.index = members.Count;
            //method to save data inside the database
            Application.ApplicationExit += new EventHandler(FinalSaveData);
        }

        //method for the creation of the selected member's MemberPage
        private void bttnMemberPage_Click(object sender, EventArgs e)
        {

            if (lstVwMain.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Seleziona un socio", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MemberPage MemberPageForm = new MemberPage(members[lstVwMain.SelectedIndices[0]]);
                MemberPageForm.ShowDialog();

            }
        }

        //method for the creation of the NewMember that opens the NewMemberPage
        private void bttnNewMember_Click(object sender, EventArgs e)
        {
            NewMemberPage NewMemberPageForm = new NewMemberPage(members);
            NewMemberPageForm.ShowDialog();
            //the insertion is canceled when the index has the same value of the members inside the listview
            //this means that the number of members inside the listview isn't changed.
            if (NewMemberPageForm.members.Count!=index)
            {
                members = NewMemberPageForm.members;
                memberItem = new ListViewItem();
                memberItem = members[index].ToListViewItem();
                lstVwMain.Items.Add(memberItem);
                index++;
            }
        }

        //method for the creation of the UpdateRankingPage, used also for the insertion of a new ranking and a data of insertion, inside the listview
        private void bttnUpdateRanking_Click(object sender, EventArgs e)
        {
            if (lstVwMain.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Seleziona un socio", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int editIndex;
                UpdateRankingPage UpdateRankingPageForm = new UpdateRankingPage(members[lstVwMain.SelectedIndices[0]]);
                UpdateRankingPageForm.ShowDialog();
                editIndex = lstVwMain.SelectedItems[0].Index;
                members.RemoveAt(editIndex);
                lstVwMain.Items.RemoveAt(editIndex);
                members.Insert(editIndex, UpdateRankingPageForm.member);
                lstVwMain.Items.Insert(editIndex, UpdateRankingPageForm.member.ToListViewItem());
            }

        }

        //method for the creation of the EditMemberPage used to edit any date of the selected member
        private void bttnEditMember_Click(object sender, EventArgs e)
        {
            if (lstVwMain.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Seleziona un socio", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int editIndex;
                EditMemberPage EditMemberPageForm = new EditMemberPage(members[lstVwMain.SelectedIndices[0]]);
                EditMemberPageForm.ShowDialog();
                editIndex = lstVwMain.SelectedItems[0].Index;
                members.RemoveAt(editIndex);
                lstVwMain.Items.RemoveAt(editIndex);
                members.Insert(editIndex, EditMemberPageForm.editedMember);
                lstVwMain.Items.Insert(editIndex, EditMemberPageForm.editedMember.ToListViewItem());
            }
           
        }

        //method for the remotion of a member
        private void bttnDelete_Click(object sender, EventArgs e)
        {
           
            if (lstVwMain.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Seleziona un socio", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Il socio verrà rimosso, sei sicuro?", "Conferma", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    members.Remove(members[lstVwMain.SelectedIndices[0]]);
                    lstVwMain.Items.Remove(lstVwMain.SelectedItems[0]);
                    chrtRanking.Series[0].Points.Clear();
                    index--;
                }    
            }
        }
            
        //method used for reading the database and insert inside the listview every memeber
        private void LoadDB()
        {
            members = dbHandler.GetData();
            for(int i = 0; i < members.Count; i++)
            {
                memberItem = new ListViewItem();
                memberItem = members[i].ToListViewItem();
                lstVwMain.Items.Add(memberItem);
            }
        }

        //method for the generation, after the selection of a member, of the relative diagram
        private void lstVwMain_ItemActivate(object sender, EventArgs e)
        {
            var posizioneSeries = chrtRanking.Series[0];
            posizioneSeries.Points.Clear();
            var selectedMember = members[lstVwMain.SelectedIndices[0]];
            chrtRanking.ChartAreas[0].AxisY.Minimum = (selectedMember.FindMinimumRanking()) - 1;
            for (int i = 0; i < selectedMember.DateList.Count; i++)
            {
                var date = selectedMember.DateList[i];
                var ranking = selectedMember.RankingsList[i];
                posizioneSeries.Points.AddXY(date, ranking);
            }

        }

        //method used for saving the data inside the database
        private void FinalSaveData(object sender, EventArgs e)
        {
            dbHandler.SaveData(members);
        }

        private void lstVwMain_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      
    }
}
