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
    public partial class MatchingForm : Form
    {
        MemberClass member;
        public MatchingForm(MemberClass memberClass)
        {
            member = memberClass;
            InitializeComponent();
        }

        private void btnSearchMatching_Click(object sender, EventArgs e)
        {
            MessageBox.Show("この条件で検索します");
        }
    }
}
