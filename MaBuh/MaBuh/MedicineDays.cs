using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaBuh
{
    public partial class MedicineDays : Form
    {
        MedicineDaysCalculate medDays = new MedicineDaysCalculate();
        public MedicineDays()
        {
            InitializeComponent();
        }

        private void buttonMedicineCalcucate_Click(object sender, EventArgs e)
        {
            try
            {
                InitializePeriodDays();
                InitializeHolidays();
                InitializeTotalPeriodSalary();
                InitializeVacationDaysAmount();

                CalcVacation();
            }
            catch
            {
                CleanCalculableVacationFileds();
            }
        }

        private void buttonMedicineCleanAll_Click(object sender, EventArgs e)
        {
            CleanAllVacationFields();
        }

        private void головнеВікноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void вийтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        //Incapsulates all vacation calculations
        private void CalcVacation()
        {
            this.textBoxTotalSum.Text = Math.Round(medDays.CalcTotalSum(), 2).ToString();
            this.textBox15Percent.Text = Math.Round(medDays.Calc15PercentTax(), 2).ToString();
            this.textBox1Dot5Percent.Text = Math.Round(medDays.Calc1Dot5PercentTax(), 2).ToString();
            this.textBox3Dot6Percent.Text = Math.Round(medDays.Calc3Dot6PercentTax(), 2).ToString();
            this.textBoxTax.Text = Math.Round(medDays.CalcTotalTax(), 2).ToString();
            this.textBoxResultSum.Text = Math.Round(medDays.CalcResultSum(), 2).ToString();
        }

        //Incapsulate fields cleaning
        private void CleanAllVacationFields()
        {
            this.textBoxPeriodDaysAmount.Text = "";
            this.textBoxPeriodHolidays.Text = "";
            this.textBoxMedicineDaysAmount.Text = "";
            this.textBoxPeriodTotalSalary.Text = "";

            CleanCalculableVacationFileds();
        }

        private void CleanCalculableVacationFileds()
        {
            this.textBoxTotalSum.Text = "";
            this.textBox15Percent.Text = "";
            this.textBox1Dot5Percent.Text = "";
            this.textBox3Dot6Percent.Text = "";
            this.textBoxTax.Text = "";
            this.textBoxTotalSum.Text = "";
            this.textBoxResultSum.Text = "";
        }

        //Incapsulate initialization of fields for vacation calculation
        private void InitializePeriodDays()
        {
            try
            {
                medDays.PeriodDays = Convert.ToInt32(this.textBoxPeriodDaysAmount.Text);
            }
            catch
            {
                View.IncorectDays();
                throw new Exception();
            }
        }

        private void InitializeHolidays()
        {
            try
            {
                medDays.PeriodHolidays = Convert.ToInt32(this.textBoxPeriodHolidays.Text);
            }
            catch
            {
                View.IncorectHolidays();
                throw new Exception();
            }
        }

        private void InitializeTotalPeriodSalary()
        {
            try
            {
                medDays.TotalPeriodSalary = Convert.ToDouble(this.textBoxPeriodTotalSalary.Text);
            }
            catch
            {
                View.IncorectSum();
                throw new Exception();
            }
        }

        private void InitializeVacationDaysAmount()
        {
            try
            {
                medDays.MedicineDays = Convert.ToInt32(this.textBoxMedicineDaysAmount.Text);
            }
            catch
            {
                View.IncorectVacationDays();
                throw new Exception();
            }
        }
    }
}
