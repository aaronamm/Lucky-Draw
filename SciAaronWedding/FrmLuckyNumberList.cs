using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SciAaronWedding
{
    public partial class FrmLuckyNumberList : Form
    {

        public FrmLuckyNumberList(IList<int> luckyNumberList)
        {
            InitializeComponent();
            LblLuckyList.Text = string.Join("\n", luckyNumberList.ToArray());
        }


    }
}
