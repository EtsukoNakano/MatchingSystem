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
    public partial class NewMemberForm : Form
    {
        public NewMemberForm()
        {
            InitializeComponent();
        }

        private void btnEntryBaseData_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{txtName.Text} 様の情報を登録しました。");
        }
    }
}
