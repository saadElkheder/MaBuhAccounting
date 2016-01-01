using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaBuh
{
    class MedicineDaysCalculate
    {
        private double totalPeriodSalary;
        private int periodDays;
        private int periodHolidays;
        private int medicineDays;

        public double TotalPeriodSalary
        {
            set { this.totalPeriodSalary = value; }
        }

        public int PeriodDays
        {
            set { this.periodDays = value; }
        }

        public int PeriodHolidays
        {
            set { this.periodHolidays = value; }
        }

        public int MedicineDays
        {
            set { this.medicineDays = value; }
        }

        public double CalcTotalSum()
        {
            return totalPeriodSalary / (periodDays - periodHolidays) * medicineDays;
        }

        public double Calc15PercentTax()
        {
            return 0.15 * (CalcTotalSum() - Calc3Dot6PercentTax());
        }

        public double Calc1Dot5PercentTax()
        {
            return 0.015 * CalcTotalSum();
        }

        public double Calc3Dot6PercentTax()
        {
            return 0.036 * CalcTotalSum();
        }

        public double CalcTotalTax()
        {
            return Calc15PercentTax() +
                   Calc1Dot5PercentTax() +
                   Calc3Dot6PercentTax();
        }

        public double CalcResultSum()
        {
            return CalcTotalSum() -
                   CalcTotalTax();
        }
    }
}
