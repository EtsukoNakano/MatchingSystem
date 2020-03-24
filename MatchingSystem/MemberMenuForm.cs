using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchingSystem
{
    public partial class MemberMenuForm : Form
    {
        public MemberMenuForm()
        {
            InitializeComponent();
        }

        private void btnNewMember_Click(object sender, EventArgs e)
        {
            NewMemberForm frmNewMember = new NewMemberForm();
            frmNewMember.ShowDialog();
        }

        private void btnMemberUpdate_Click(object sender, EventArgs e)
        {
            UpdateMemberForm frmUpdateMember = new UpdateMemberForm();
            frmUpdateMember.ShowDialog();
        }

        private void btnMemberSearch_Click(object sender, EventArgs e)
        {
            SearchMemberForm frmSearchMember = new SearchMemberForm();
            frmSearchMember.ShowDialog();
        }
    }
}
