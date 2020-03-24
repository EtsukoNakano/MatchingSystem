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
    public partial class NewReferralForm : Form
    {
        public NewReferralForm()
        {
            InitializeComponent();
        }

        private void btnEntryReferralData_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{txtMaleName} 様\n{} 様\n上記2名の紹介情報を登録しました。");
        }
    }
}
