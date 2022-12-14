using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            int input = int.Parse(tbxROCEra.Text);
            DateTime date = new DateTime(input + 1911, 1, 1);

            // 365 ÷ 7 = 52 … 1，每年都有52個完整週，平年多1天、閏年多2天
            int satIndex = 52;
            int sunIndex = 52;

            // 平年若一年是週六開始，則週六會多一天；閏年則週六週日各多一天
            // 若該年是閏年且第一天是週五，則週六會多一天
            // 同理平年週日開始週日多一天
            if (date.DayOfWeek == DayOfWeek.Saturday)
            {
                satIndex++;
                if (DateTime.IsLeapYear(date.Year))
                    sunIndex++;
            }
            else if (date.DayOfWeek == DayOfWeek.Friday && DateTime.IsLeapYear(date.Year))
                satIndex++;
            else if (date.DayOfWeek == DayOfWeek.Sunday)
                sunIndex++;


            lblSat.Text = satIndex.ToString();
            lblSun.Text = sunIndex.ToString();
        }
    }
}
