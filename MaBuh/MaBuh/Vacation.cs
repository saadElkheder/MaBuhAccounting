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
    public partial class Vacation : Form
    {
        private VacationCalculate vacationCalculate = new VacationCalculate();
        public Vacation()
        {
            InitializeComponent();
        }

        private void buttonCalcVacation_Click(object sender, EventArgs e)
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

        private void buttonCleanAllVacationFields_Click(object sender, EventArgs e)
        {
            CleanAllVacationFields();
        }

        //Incapsulates all vacation calculations
        private void CalcVacation()
        {
            this.textBoxTotalSum.Text = Math.Round(vacationCalculate.CalcTotalSum(), 2).ToString();
            this.textBox15PercentTax.Text = Math.Round(vacationCalculate.Calc15PercentTax(), 2).ToString();
            this.textBox1Dot5PercentTax.Text = Math.Round(vacationCalculate.Calc1Dot5PercentTax(), 2).ToString();
            this.textBox3Dot6PercentTax.Text = Math.Round(vacationCalculate.Calc3Dot6PercentTax(), 2).ToString();
            this.textBoxTotalTax.Text = Math.Round(vacationCalculate.CalcTotalTax(), 2).ToString();
            this.textBoxResultSum.Text = Math.Round(vacationCalculate.CalcResultSum(), 2).ToString();
        }

        //Incapsulate fields cleaning
        private void CleanAllVacationFields()
        {
            this.textBoxPeriodDaysAmount.Text = "";
            this.textBoxPeriodHolidaysAmount.Text = "";
            this.textBoxVacationDaysAmount.Text = "";
            this.textBoxPeriodTotalSalary.Text = "";

            CleanCalculableVacationFileds();
        }

        private void CleanCalculableVacationFileds()
        {
            this.textBoxTotalSum.Text = "";
            this.textBox15PercentTax.Text = "";
            this.textBox1Dot5PercentTax.Text = "";
            this.textBox3Dot6PercentTax.Text = "";
            this.textBoxTotalTax.Text = "";
            this.textBoxTotalSum.Text = "";
            this.textBoxResultSum.Text = "";
        }

        //Incapsulate initialization of fields for vacation calculation
        private void InitializePeriodDays()
        {
            try
            {
                vacationCalculate.PeriodDays = Convert.ToInt32(this.textBoxPeriodDaysAmount.Text);
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
                vacationCalculate.PeriodHolidays = Convert.ToInt32(this.textBoxPeriodHolidaysAmount.Text);
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
                vacationCalculate.TotalPeriodSalary = Convert.ToDouble(this.textBoxPeriodTotalSalary.Text);
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
                vacationCalculate.VacationDays = Convert.ToInt32(this.textBoxVacationDaysAmount.Text);
            }
            catch
            {
                View.IncorectVacationDays();
                throw new Exception();
            }
        }

        private void вийтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void головнеМенюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
