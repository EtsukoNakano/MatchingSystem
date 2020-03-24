using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MatchingSystem
{
    public partial class MachingMenuForm : Form
    {
        MemberClass member;
        public MachingMenuForm()
        {
            InitializeComponent();
        }

        private void btnMatchingSearch_Click(object sender, EventArgs e)
        {
            MatchingForm frmMatching = new MatchingForm(member);
            frmMatching.ShowDialog();
        }

        private void btnMatchiCheck_Click(object sender, EventArgs e)
        {
            MatchJudgeForm frmMatchJudge = new MatchJudgeForm(member);
            frmMatchJudge.ShowDialog();
        }

        public static void GetIdOrName() // txtIDに入力された値がIDか名前か判定しmemberに格納する
        {

        }
    }
}
