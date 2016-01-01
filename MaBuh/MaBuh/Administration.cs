namespace MaBuh
{
    class Administration
    {
        private int days;
        private int workedDays;
        private double sum;

        public int Days 
        {
            get { return days; }
            set { days = value; }
        }

        public int WorkedDays
        {
            get { return workedDays; }
            set { workedDays = value; }
        }

        public double Sum
        {
            get { return sum; }
            set { sum = value; }
        }

        public double CalcWorkedYears()
        {
            return (0.2 * Sum * WorkedDays / Days);
        }

        public double CalcWorkedBySum()
        {
            return (Sum*WorkedDays/Days);
        }

        public double CalcIntensity()
        {
            return (0.5*Sum*WorkedDays/Days);
        }

        public double CalcTotal()
        {
            return (0.2 * Sum * WorkedDays / Days) +
                (Sum * WorkedDays / Days) + (0.5 * Sum * WorkedDays / Days);
        }

        public double CalcOneAndHalfPercent()
        {
            return 0.015*CalcTotal();
        }

        public double CalcThreeDotSixPercent()
        {
            return 0.036 * CalcTotal();
        }

        public double CalcFifteenPercent()
        {
            return 0.15*(CalcTotal() - CalcThreeDotSixPercent());
        }

        public double CalcTax()
        {
            return CalcOneAndHalfPercent() +
                   CalcThreeDotSixPercent() +
                   CalcFifteenPercent();
        }

        public double CalcResult()
        {
            return CalcTotal() -
                   CalcTax();
        }
    }
}
