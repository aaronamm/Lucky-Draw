using System;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SciAaronWedding
{

    public delegate void LuckyNumberChangeEventHandler(object sender, int newLuckyNumber, EventArgs eventArgs);

    public partial class FrmMain : Form
    {

        static readonly Random Random = new Random();

        private readonly int DelayInSecond = int.Parse(ConfigurationManager.AppSettings["delayInSeconds"]);
        private readonly int MaxDraw = int.Parse(ConfigurationManager.AppSettings["maxDrawRandomForEachTime"]);
        private readonly int MaxLuckyNumberInList = int.Parse(ConfigurationManager.AppSettings["maxLuckyNumberInList"]);

        private IList<int> luckyNumberList = new List<int>();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void ShowLuckyListForm()
        {
          var frmLuckyNumberList =new  FrmLuckyNumberList(luckyNumberList);
            frmLuckyNumberList.Show();
        }

        private void MLuckyList_Click(object sender, EventArgs e)
        {
            ShowLuckyListForm();
        }

        private async void BtnLuckyDraw_Click(object sender, EventArgs e)
        {
            BtnLuckyDraw.Enabled = false;
            await GetRandomNumber();
            BtnLuckyDraw.Enabled = true;
        }

        private async Task GetRandomNumber()
        {
            if (luckyNumberList.Count == MaxLuckyNumberInList)
            {
                MessageBox.Show($"รายชื่อผู้โชคดีครบ {MaxLuckyNumberInList} คน แล้วครับ");
                ShowLuckyListForm();
                return;
            }

            var luckyNumber = 0;
            do
            {
                for (var time = 0; time < MaxDraw; time++)
                {
                    luckyNumber = Random.Next(1, 301);
                    LblLuckyNumber.Text = luckyNumber.ToString();
                    await Task.Delay(DelayInSecond);
                }

            } while (luckyNumberList.Contains(luckyNumber));
            
            luckyNumberList.Add(luckyNumber);
        }
    }
}
