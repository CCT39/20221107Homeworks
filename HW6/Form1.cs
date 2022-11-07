using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int input = int.Parse(tbxCommonEra.Text);
            DateTime beggingOfTheYear = new DateTime(input, 1, 1);
            DateTime endingOfTheYear = new DateTime(input + 1, 1, 1);

            int satIndex = 0;
            int sunIndex = 0;

            for (DateTime date = beggingOfTheYear; date < endingOfTheYear; date = date.AddDays(1.0))
            {
                if (date.DayOfWeek == DayOfWeek.Saturday)
                    satIndex++;
                else if (date.DayOfWeek == DayOfWeek.Sunday)
                    sunIndex++;
            }

            lblSat.Text = satIndex.ToString();
            lblSun.Text = sunIndex.ToString();
        }
    }
}
