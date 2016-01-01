namespace MaBuh
{
    class Security
    {
        private int normDay;
        private int workedDay;
        private int nightDay;
        private int holiday;
        private double sum;

        public int NormDay
        {
            get { return normDay; }
            set { normDay = value; }
        }

        public int WorkedDay
        {
            get { return workedDay; }
            set { workedDay = value; }
        }

        public int NightDay
        {
            get { return nightDay; }
            set { nightDay = value; }
        }

        public int Holiday
        {
            get { return holiday; }
            set { holiday = value; }
        }

        public double Sum
        {
            get { return sum; }
            set { sum = value; }
        }

        public double CalcWorkedDaysBySum()
        {
            return sum / normDay * workedDay;
        }

        public double CalcNightDays()
        {
            return 0.35 * sum / normDay * nightDay;
        }

        public double CalcIntensity()
        {
            return 0.2 * sum;
        }

        public double CalcHolidaySum()
        {
            return sum / normDay * holiday;
        }

        public double CalcTotalSum()
        {
            return CalcWorkedDaysBySum() + 
                CalcNightDays() + 
                CalcHolidaySum() + 
                CalcIntensity();
        }

        public double Calc1Dot5Percent()
        {
            return 0.015 * CalcTotalSum();
        }

        public double Calc3Dot6Percent()
        {
            return 0.036 * CalcTotalSum();
        }

        public double Calc15Percent()
        {
            return 0.15 * (CalcTotalSum() - Calc3Dot6Percent());
        }

        public double CalcTaxSum()
        {
            return Calc1Dot5Percent() +
                   Calc3Dot6Percent() +
                   Calc15Percent();
        }

        public double CalcResultSum()
        {
            return CalcTotalSum() - CalcTaxSum();
        }
    }
}
