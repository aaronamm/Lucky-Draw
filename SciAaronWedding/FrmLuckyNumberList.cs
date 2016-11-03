using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SciAaronWedding
{
    public partial class FrmLuckyNumberList : Form
    {

        public FrmLuckyNumberList(IList<int> luckyNumberList)
        {
            InitializeComponent();
            LblLuckyList.Text = FormatList(luckyNumberList);
        }

        private static string FormatList(IList<int> luckNumberList)
        {
            StringBuilder stringBuilder =new StringBuilder();
            foreach (var number in luckNumberList)
            {
                stringBuilder.AppendFormat("{0}\n", number);
            }
            return stringBuilder.ToString();
        }


    }
}
