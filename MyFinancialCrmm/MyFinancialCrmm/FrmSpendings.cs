using MyFinancialCrmm.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MyFinancialCrmm
{
    public partial class FrmSpendings : Form
    {
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        public FrmSpendings()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBankHark_Click(object sender, EventArgs e)
        {
            FrmBanks frmBanks = new FrmBanks();
            frmBanks.Show();
            this.Hide();
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            FrmBilling billing = new FrmBilling();
            billing.Show();
            this.Hide();
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frmDashBoard = new FrmDashboard();
            frmDashBoard.Show();
            this.Hide();
        }

        private int count = 0;
        private void FrmSpendings_Load(object sender, EventArgs e)
        {
            var totalSpend = db.Spendings.Sum(x => x.SpendingAmount);
            lblTotalSpend.Text = totalSpend.ToString() + " ₺";


            timer1.Interval = 1000;
            timer1.Start();

           

        {
                var spendingdata = db.Spendings.Select(x => new
                {
                    x.SpendingTitle,
                    x.SpendingAmount,
                }).ToList();
                chart1.Series.Clear();
                var series = chart1.Series.Add("Harcanan Yerler");
                series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                foreach (var item in spendingdata)
                {
                    series.Points.AddXY(item.SpendingTitle, item.SpendingAmount);
                }
            }
        }
    
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            var spendingsList = db.Spendings.OrderBy(x => x.SpendingId).ToList();

            if (spendingsList.Count > 0)
            {
                var index = count % spendingsList.Count;
                var spending = spendingsList.ElementAtOrDefault(index);

                if (spending != null)
                {
                    lblSpendingAreas.Text = spending.SpendingTitle;
                    lblSpendingAreas.Text = spending.SpendingAmount?.ToString() + " ₺";
                }

                count++;
            }
        }

       
        private void lblTotalSpend_Click(object sender, EventArgs e)
        {
            var totalSpend = db.Spendings.Sum(x => x.SpendingAmount);
            lblTotalSpend.Text = totalSpend.ToString() + " ₺";


            timer1.Interval = 1000;
            timer1.Start();

        }

        private void FrmCategory_Click(object sender, EventArgs e)
        {
            FrmCategory categoryForm = new FrmCategory();
            categoryForm.Show();
            this.Hide();
        }

        private void btnBanks_Click_1(object sender, EventArgs e)
        {
            FrmBanks frmBanks = new FrmBanks();
            frmBanks.Show();
            this.Hide();
        }

        private void btnBills_Click_1(object sender, EventArgs e)
        {
            FrmBilling billing = new FrmBilling();
            billing.Show();
            this.Hide();
        }

        private void btnSpendings_Click(object sender, EventArgs e)
        {
           this.Show();

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frmDashBoard = new FrmDashboard();
            frmDashBoard.Show();
            this.Hide();
        }

       
    }
}
    
