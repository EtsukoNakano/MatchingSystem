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
    public partial class ReferralMenuForm : Form
    {
        MemberClass member;
        public ReferralMenuForm()
        {
            InitializeComponent();
        }

        private void btnNewReferral_Click(object sender, EventArgs e)
        {
            NewReferralForm frmNewReferral = new NewReferralForm();
            frmNewReferral.ShowDialog();
        }

        private void btnUpdateReferral_Click(object sender, EventArgs e)
        {
            UpdateReferralForm frmUpdateReferral = new UpdateReferralForm();
            frmUpdateReferral.ShowDialog();
        }

        private void btnSearchReferral_Click(object sender, EventArgs e)
        {
            SearchReferralForm frmSearchReferral = new SearchReferralForm();
            frmSearchReferral.ShowDialog();
        }
    }
}
