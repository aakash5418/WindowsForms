using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tickects
{
    public partial class FrmTickets : Form
    {
        public FrmTickets()
        {
            InitializeComponent();
        }

        private void btnTickects_Click(object sender, EventArgs e)
        {
            int age;
            double price = 0;

            age = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("please enter your age:", "Tickects", ""));

            if (age <= 10)
            {
                price = 5.0;
            }
            else if (age >= 11 && age <= 18 )
            {
                price = 10.0;

            }
            else if (age >= 19 && age <= 45 )
            {
                price = 20.0;
            }
            else if (age >= 46 )
            {
                price = 5.5;
            }

            MessageBox.Show("Your price is :" + price.ToString("c"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int gas;
            double bill = 0;

            gas = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("please enter your gas useage in ccf:", "Gas Bill", ""));

            if (gas <= 10)
            {
                bill = gas * .50;
            }
            else if (gas >= 11 )
            {
                bill = 11 * .50 + (gas - 11) * .30;
            }
            MessageBox.Show ("Your gas bill is" + bill.ToString("c"));
        }

        private void btnHydro_Click(object sender, EventArgs e)
        {
            int kwh;
            double bill = 0;

            kwh = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("please enter your kwh usage:", "Hydro Bill", ""));
             
            if (kwh <= 12)
            {
                bill = 2.80;
            }
            else if (kwh >12 && kwh >90)
            {
                bill = 2.80 + (kwh - 12) * 0.8;
            }
            else if (kwh <90)
            {
                bill = 2.80 + 78 * 0.8 + (kwh - 90) * 0.6;
            }

            MessageBox.Show("Your hydrogas bill is " + bill.ToString("c"));
        }
    }
}
