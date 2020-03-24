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
    public partial class MatchJudgeForm : Form
    {
        MemberClass member;
        public MatchJudgeForm(MemberClass memberClass)
        {
            member = memberClass;
            InitializeComponent();
        }
    }
}
