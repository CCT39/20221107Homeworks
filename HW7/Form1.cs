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
            DateTime date = new DateTime(input, 1, 1);

            // 365 ÷ 7 = 52 … 1，每年都有52個完整週，平年多1天、閏年多2天
            int satIndex = 52;
            int sunIndex = 52;

            // 平年若一年是週六開始，則週六會多一天；閏年則週六週日各多一天。同理平年週日開始週日多一天
            if (date.DayOfWeek == DayOfWeek.Saturday)
            {
                satIndex++;
                if (DateTime.IsLeapYear(date.Year))
                    sunIndex++;
            }
            else if (date.DayOfWeek == DayOfWeek.Sunday)
                sunIndex++;


            lblSat.Text = satIndex.ToString();
            lblSun.Text = sunIndex.ToString();
        }
    }
}
