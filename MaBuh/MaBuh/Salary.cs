using System;
using System.Windows.Forms;

namespace MaBuh
{
    public partial class Salary : Form
    {
        private Administration admin = new Administration();
        private MedicineStaff medStaff = new MedicineStaff();
        private JuniorMedicineStaff junMedStaff = new JuniorMedicineStaff();
        private Security security = new Security();

        public Salary()
        {
            InitializeComponent();
        }

        private void buttonAdminCalc_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    admin.Days = Convert.ToInt32(adminDays.Text);
                }
                catch
                {
                    View.IncorectDays();
                    throw new Exception();
                }

                try
                {
                    admin.WorkedDays = Convert.ToInt32(adminWorkedDays.Text);
                }
                catch
                {
                    View.IncorectWorkedDays();
                    throw new Exception();
                }

                try
                {
                    admin.Sum = Convert.ToDouble(adminSum.Text);
                }
                catch
                {
                    View.IncorectSum();
                    throw new Exception();
                }

                CalcAdminSalary();
            }
            catch
            {
                CleanCalculabableAdminFields();
            }
        }

        private void buttonMedCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    medStaff.NormDay = Convert.ToInt32(medNorm.Text);
                }
                catch
                {
                    View.IncorectMedNorm();
                    throw new Exception();
                }

                try
                {
                    medStaff.WorkedDay = Convert.ToInt32(medWorked.Text);
                }
                catch
                {
                    View.IncorectWorkedDays();
                    throw new Exception();
                }

                try
                {
                    medStaff.NightDay = Convert.ToInt32(medNightDay.Text);
                }
                catch
                {
                    View.IncorectNightDays();
                    throw new Exception();
                }

                try
                {
                    medStaff.Holiday = Convert.ToInt32(medHoliday.Text);
                }
                catch
                {
                    View.IncorectHolidays();
                    throw new Exception();
                }

                try
                {
                    medStaff.Sum = Convert.ToDouble(medSum.Text);
                }
                catch
                {
                    View.IncorectSum();
                    throw new Exception();
                }

                CalcMedStuffSalary();
            }
            catch
            {
                CleanCalculabableMedStuffFields();
            }
            
        }

        private void junMedStaffCalcSalary_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    junMedStaff.NormDay = Convert.ToInt32(junMedStaffNormDay.Text);
                }
                catch
                {
                    View.IncorectMedNorm();
                    throw new Exception();
                }

                try
                {
                    junMedStaff.WorkedDay = Convert.ToInt32(junMedStaffWorkedDay.Text);
                }
                catch
                {
                    View.IncorectWorkedDays();
                    throw new Exception();
                }

                try
                {
                    junMedStaff.NightDay = Convert.ToInt32(junMedStaffNightDay.Text);
                }
                catch
                {
                    View.IncorectNightDays();
                    throw new Exception();
                }

                try
                {
                    junMedStaff.Holiday = Convert.ToInt32(junMedStaffHoliday.Text);
                }
                catch
                {
                    View.IncorectHolidays();
                    throw new Exception();
                }

                try
                {
                    junMedStaff.Sum = Convert.ToDouble(junMedStaffSum.Text);
                }
                catch
                {
                    View.IncorectSum();
                    throw new Exception();
                }

                CalcJunMedStuffSalary();
            }
            catch
            {
                CleanCalculabableJunMedStuffFields();
            }
        }

        private void buttonSecurityCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    security.NormDay = Convert.ToInt32(securityNormDay.Text);
                }
                catch
                {
                    View.IncorectMedNorm();
                    throw new Exception();
                }

                try
                {
                    security.WorkedDay = Convert.ToInt32(securityWorkedDay.Text);
                }
                catch
                {
                    View.IncorectWorkedDays();
                    throw new Exception();
                }

                try
                {
                    security.NightDay = Convert.ToInt32(securityNightDay.Text);
                }
                catch
                {
                    View.IncorectNightDays();
                    throw new Exception();
                }

                try
                {
                    security.Holiday = Convert.ToInt32(securityHoliday.Text);
                }
                catch
                {
                    View.IncorectHolidays();
                    throw new Exception();
                }

                try
                {
                    security.Sum = Convert.ToDouble(securitySum.Text);
                }
                catch
                {
                    View.IncorectSum();
                    throw new Exception();
                }

                CalcSecuritySalary();
            }
            catch
            {
                CleanCalculableSecurityFields();
            }
        }
        
        private void buttonAdminClean_Click(object sender, EventArgs e)
        {
            CleanAllAdminFields();
        }

        private void buttonMedCleanAll_Click(object sender, EventArgs e)
        {
            CleanAllMedStuffFields();
        }

        private void junMedStaffCleanAll_Click(object sender, EventArgs e)
        {
            CleanAllJunMedStuffFields();
        }

        private void buttonSecurityClearAll_Click(object sender, EventArgs e)
        {
            CleanAllSecurityFields();
        }

        private void вийтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void головнеВікноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        //Incapsulation of salary calculation
        private void CalcAdminSalary()
        {
            adminWorkedBySum.Text = Math.Round(admin.CalcWorkedBySum(), 2).ToString();
            adminIntensity.Text = Math.Round(admin.CalcIntensity(), 2).ToString();
            adminWorkedYears.Text = Math.Round(admin.CalcWorkedYears(), 2).ToString();
            adminTotal.Text = Math.Round(admin.CalcTotal(), 2).ToString();
            admin1d5Perc.Text = Math.Round(admin.CalcOneAndHalfPercent(), 2).ToString();
            admin3d6Perc.Text = Math.Round(admin.CalcThreeDotSixPercent(), 2).ToString();
            admin15Perc.Text = Math.Round(admin.CalcFifteenPercent(), 2).ToString();
            adminTax.Text = Math.Round(admin.CalcTax(), 2).ToString();
            adminResult.Text = Math.Round(admin.CalcResult(), 2).ToString();
        }

        private void CalcMedStuffSalary()
        {
            medWorkedBySum.Text = Math.Round(medStaff.CalcWorkedDaysBySum(), 2).ToString();
            medBedIll.Text = Math.Round(medStaff.CalcBedIll(), 2).ToString();
            medNightSum.Text = Math.Round(medStaff.CalcNightDays(), 2).ToString();
            medWorkedYearsSum.Text = Math.Round(medStaff.CalcWorkedYearsSum(), 2).ToString();
            medIntensitySum.Text = Math.Round(medStaff.CalcIntensity(), 2).ToString();
            medHolidaySum.Text = Math.Round(medStaff.CalcHolidaySum(), 2).ToString();

            medTotalSum.Text = Math.Round(medStaff.CalcTotalSum(), 2).ToString();

            med3Dot6PercentSum.Text = Math.Round(medStaff.Calc3Dot6Percent(), 2).ToString();
            med15PercentSum.Text = Math.Round(medStaff.Calc15Percent(), 2).ToString();
            med1dot5PercentSum.Text = Math.Round(medStaff.Calc1Dot5Percent(), 2).ToString();

            medTaxSum.Text = Math.Round(medStaff.CalcTaxSum(), 2).ToString();
            medResultSum.Text = Math.Round(medStaff.CalcResultSum(), 2).ToString();
        }

        private void CalcJunMedStuffSalary()
        {
            junMedStaffWorkedBySum.Text = Math.Round(junMedStaff.CalcWorkedDaysBySum(), 2).ToString();
            junMedStaffBedIll.Text = Math.Round(junMedStaff.CalcBedIll(), 2).ToString();
            junMedStaffNightSum.Text = Math.Round(junMedStaff.CalcNightDays(), 2).ToString();
            junMedStaffIntensitySum.Text = Math.Round(junMedStaff.CalcIntensity(), 2).ToString();
            junMedStaffHolidaySum.Text = Math.Round(junMedStaff.CalcHolidaySum(), 2).ToString();

            junMedStaffTotalSum.Text = Math.Round(junMedStaff.CalcTotalSum(), 2).ToString();

            junMedStaff3Dot6PercentSum.Text = Math.Round(junMedStaff.Calc3Dot6Percent(), 2).ToString();
            junMedStaff15PercentSum.Text = Math.Round(junMedStaff.Calc15Percent(), 2).ToString();
            junMedStaff1Dot5PercentSum.Text = Math.Round(junMedStaff.Calc1Dot5Percent(), 2).ToString();

            junMedStafftaxSum.Text = Math.Round(junMedStaff.CalcTaxSum(), 2).ToString();
            junMedStaffResultSum.Text = Math.Round(junMedStaff.CalcResultSum(), 2).ToString();

        }

        private void CalcSecuritySalary()
        {
            securityWorkedBySum.Text = Math.Round(security.CalcWorkedDaysBySum(), 2).ToString();
            securityNightDaySum.Text = Math.Round(security.CalcNightDays(), 2).ToString();
            securityIntensitySum.Text = Math.Round(security.CalcIntensity(), 2).ToString();
            securityHolidaySum.Text = Math.Round(security.CalcHolidaySum(), 2).ToString();

            securityTotalSum.Text = Math.Round(security.CalcTotalSum(), 2).ToString();

            security3Dot6PercentSum.Text = Math.Round(security.Calc3Dot6Percent(), 2).ToString();
            security15PercentSum.Text = Math.Round(security.Calc15Percent(), 2).ToString();
            security1Dot5PercentSum.Text = Math.Round(security.Calc1Dot5Percent(), 2).ToString();

            securityTaxSum.Text = Math.Round(security.CalcTaxSum(), 2).ToString();
            securityResultSum.Text = Math.Round(security.CalcResultSum(), 2).ToString();
        }


        //Incapsulation of cleaning necessary fields
        private void CleanAllAdminFields()
        {
            adminDays.Text = "";
            adminWorkedDays.Text = "";
            adminSum.Text = "";
            adminWorkedBySum.Text = "";
            adminIntensity.Text = "";
            adminWorkedYears.Text = "";
            adminTotal.Text = "";
            admin1d5Perc.Text = "";
            admin3d6Perc.Text = "";
            admin15Perc.Text = "";
            adminTax.Text = "";
            adminResult.Text = "";
        }

        private void CleanCalculabableAdminFields()
        {

            adminWorkedBySum.Text = "";
            adminIntensity.Text = "";
            adminWorkedYears.Text = "";
            adminTotal.Text = "";
            admin1d5Perc.Text = "";
            admin3d6Perc.Text = "";
            admin15Perc.Text = "";
            adminTax.Text = "";
            adminResult.Text = "";
        }

        private void CleanAllMedStuffFields()
        {
            medNorm.Text = "";
            medWorked.Text = "";
            medNightDay.Text = "";
            medHoliday.Text = "";
            medSum.Text = "";
            medWorkedBySum.Text = "";
            medBedIll.Text = "";
            medNightSum.Text = "";
            medHolidaySum.Text = "";
            medWorkedYearsSum.Text = "";
            medIntensitySum.Text = "";
            medTotalSum.Text = "";
            med1dot5PercentSum.Text = "";
            med3Dot6PercentSum.Text = "";
            med15PercentSum.Text = "";
            medTaxSum.Text = "";
            medResultSum.Text = "";
        }

        private void CleanCalculabableMedStuffFields()
        {
            medWorkedBySum.Text = "";
            medBedIll.Text = "";
            medNightSum.Text = "";
            medHolidaySum.Text = "";
            medWorkedYearsSum.Text = "";
            medIntensitySum.Text = "";
            medTotalSum.Text = "";
            med1dot5PercentSum.Text = "";
            med3Dot6PercentSum.Text = "";
            med15PercentSum.Text = "";
            medTaxSum.Text = "";
            medResultSum.Text = "";
        }

        private void CleanAllJunMedStuffFields()
        {
            junMedStaffNormDay.Text = "";
            junMedStaffSum.Text = "";
            junMedStaffHoliday.Text = "";
            junMedStaffNightDay.Text = "";
            junMedStaffWorkedDay.Text = "";

            junMedStaffWorkedBySum.Text = "";
            junMedStaffBedIll.Text = "";
            junMedStaffNightSum.Text = "";
            junMedStaffIntensitySum.Text = "";
            junMedStaffHolidaySum.Text = "";
            junMedStaffTotalSum.Text = "";
            junMedStaff3Dot6PercentSum.Text = "";
            junMedStaff15PercentSum.Text = "";
            junMedStaff1Dot5PercentSum.Text = "";
            junMedStafftaxSum.Text = "";
            junMedStaffResultSum.Text = "";
        }

        private void CleanCalculabableJunMedStuffFields()
        {
            junMedStaffWorkedBySum.Text = "";
            junMedStaffBedIll.Text = "";
            junMedStaffNightSum.Text = "";
            junMedStaffIntensitySum.Text = "";
            junMedStaffHolidaySum.Text = "";
            junMedStaffTotalSum.Text = "";
            junMedStaff3Dot6PercentSum.Text = "";
            junMedStaff15PercentSum.Text = "";
            junMedStaff1Dot5PercentSum.Text = "";
            junMedStafftaxSum.Text = "";
            junMedStaffResultSum.Text = "";
        }

        private void CleanAllSecurityFields()
        {
            securityNormDay.Text = "";
            securityWorkedDay.Text = "";
            securityHoliday.Text = "";
            securityNightDay.Text = "";
            securitySum.Text = "";
            securityWorkedBySum.Text = "";
            securityNightDaySum.Text = "";
            securityIntensitySum.Text = "";
            securityHolidaySum.Text = "";
            securityTotalSum.Text = "";
            security3Dot6PercentSum.Text = "";
            security15PercentSum.Text = "";
            security1Dot5PercentSum.Text = "";
            securityTaxSum.Text = "";
            securityResultSum.Text = "";
        }

        private void CleanCalculableSecurityFields()
        {
            securityWorkedBySum.Text = "";
            securityNightDaySum.Text = "";
            securityIntensitySum.Text = "";
            securityHolidaySum.Text = "";
            securityTotalSum.Text = "";
            security3Dot6PercentSum.Text = "";
            security15PercentSum.Text = "";
            security1Dot5PercentSum.Text = "";
            securityTaxSum.Text = "";
            securityResultSum.Text = "";
        }
    }
}
