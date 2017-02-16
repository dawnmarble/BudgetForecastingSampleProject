using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApplication
{
    public partial class MainForm : Form
    {
        public BindingList<Income> IncomeList = new BindingList<Income>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            IncomeFrequency.Items.Add("Monthly");
            IncomeFrequency.Items.Add("Semimonthly");
            IncomeFrequency.Items.Add("Biweekly");
            IncomeFrequency.Items.Add("Weekly");
            IncomeListGridView.AutoGenerateColumns = false;
            IncomeListGridView.DataSource = IncomeList;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IncomeInputPanel.Show();
        }

        private void IncomeFrequency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IncomeFrequency.Text == "Semimonthly")
            {
                IncomeDate2.Show();
            } else
            {
                IncomeDate2.Hide();
            }
        }

        private void AddIncomeButton_Click(object sender, EventArgs e)
        {
            Income income = new TestApplication.Income(System.Convert.ToDecimal(IncomeAmount.Text), (Income.PayFrequency)IncomeFrequency.SelectedIndex, IncomeDate1.Value);
            IncomeList.Add(income);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
