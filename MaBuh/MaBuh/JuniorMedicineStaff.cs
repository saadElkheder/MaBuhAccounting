namespace MaBuh
{
    class JuniorMedicineStaff : MedicineStaff
    {
        new public double CalcNightDays()
        {
            return 0.35*NightDay*(Sum + CalcBedIll())/NormDay;
        }

        new public double CalcIntensity()
        {
            return 0.2*(Sum + CalcBedIll());
        }

        new public double CalcHolidaySum()
        {
            return Holiday*(Sum + CalcBedIll())/NormDay;
        }

        new public double CalcTotalSum()
        {
            return CalcWorkedDaysBySum() +
                CalcBedIll() +
                CalcNightDays() +
                CalcHolidaySum() +
                CalcIntensity();
        }

        new public double Calc1Dot5Percent()
        {
            return 0.015 * CalcTotalSum();
        }

        new public double Calc3Dot6Percent()
        {
            return 0.036 * CalcTotalSum();
        }

        new public double Calc15Percent()
        {
            return 0.15 * (CalcTotalSum() - Calc3Dot6Percent());
        }

        new public double CalcTaxSum()
        {
            return Calc1Dot5Percent() +
                   Calc3Dot6Percent() +
                   Calc15Percent();
        }

        new public double CalcResultSum()
        {
            return CalcTotalSum() - CalcTaxSum();
        }
    }
}
