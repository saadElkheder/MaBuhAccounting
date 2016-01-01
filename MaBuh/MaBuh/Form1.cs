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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonSalary_Click(object sender, EventArgs e)
        {
            Salary salary = new Salary();

            DialogResult result = salary.ShowDialog();
            CloseForm(result);
        }

        private void buttonMedicine_Click(object sender, EventArgs e)
        {
            MedicineDays medDays = new MedicineDays();

            DialogResult result = medDays.ShowDialog();
            CloseForm(result);
        }

        private void buttonVaсation_Click(object sender, EventArgs e)
        {
            Vacation vacation = new Vacation();

            DialogResult result = vacation.ShowDialog();
            CloseForm(result);
        }

        private void CloseForm(DialogResult result)
        {
            if (result == DialogResult.Cancel)
            {
                this.Close();
            }
        }
    }
}
