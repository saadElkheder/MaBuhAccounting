using System.Windows.Forms;

namespace MaBuh
{
    static class View
    {
        private const string IncorectDaysMessage = "Введіть правильну кількість днів (наприклад, 19)";
        private const string IncorectDaysNormMessage = "Введіть правильну норму днів";
        private const string IncorectWorkedDaysMessage = "Введіть правильну кількість відпрацьованих днів (наприклад, 18)";
        private const string IncorectNightDaysMessage = "Введіть правильну кількість відпрацьованих нічних днів (наприклад, 18)";
        private const string IncorectHolidaysMessage = "Введіть правильну кількість відпрацьованих вихідних днів (наприклад, 18)";
        private const string IncorectSumMessage = "Введіть правильну суму окладу (наприклад, 2022.6). Як розділювальний знак використовуйте крапку.";
        private const string IncorectVacationDaysMessage = "Введіть правильну кількість днів відпустки.";

        public static void IncorectDays()
        {
            MessageBox.Show(IncorectDaysMessage);
        }

        public static void IncorectMedNorm()
        {
            MessageBox.Show(IncorectDaysNormMessage);
        }

        public static void IncorectWorkedDays()
        {
            MessageBox.Show(IncorectWorkedDaysMessage);
        }

        public static void IncorectNightDays()
        {
            MessageBox.Show(IncorectNightDaysMessage);
        }

        public static void IncorectHolidays()
        {
            MessageBox.Show(IncorectHolidaysMessage);
        }

        public static void IncorectSum()
        {
            MessageBox.Show(IncorectSumMessage);
        }

        public static void IncorectVacationDays()
        {
            MessageBox.Show(IncorectVacationDaysMessage);
        }
    }
}
