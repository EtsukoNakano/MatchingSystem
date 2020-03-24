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
    public partial class MainMenuForm : Form
    {
        MemberClass member = new MemberClass();
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void btnMemberMenu_Click(object sender, EventArgs e)
        {
            MemberMenuForm frmMembermenu = new MemberMenuForm();
            frmMembermenu.ShowDialog();
        }

        private void btnMachingMenu_Click(object sender, EventArgs e)
        {
            MachingMenuForm frmMatchingMenu = new MachingMenuForm();
            frmMatchingMenu.ShowDialog();
        }

        private void btnReferralMenu_Click(object sender, EventArgs e)
        {
            ReferralMenuForm  frmReferralMenu = new ReferralMenuForm();
            frmReferralMenu.ShowDialog();
        }
    }
}
