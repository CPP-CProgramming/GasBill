using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GasBill
{
    public partial class billFrm : Form
    {
        public billFrm()
        {
            InitializeComponent();
        }

        private void btnGas_Click(object sender, EventArgs e)
        {
            int gas;
            double bill = 0;

            gas = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("please enter your gas usage","Gas Bill",""));

            if (gas <= 8)
            {
                bill = gas * .50;

            }
            else if ( gas > 0)
            {
                bill = 8 * .50 + (gas-8)*.30;
            }

            MessageBox.Show("your gas bill is  " + bill.ToString("c"));
        }

        private void btnHydroBill_Click(object sender, EventArgs e)
        {
            int kwh;
            double bill = 0;

            kwh = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("please enter your gas usage", "Gas Bill", ""));

            if (kwh <= 12)
            {
                bill = 2.00;
            }
            else if (kwh > 12 && kwh <= 90)
            {
                bill = 2.80 + (kwh - 12) * .80;
            }
            else if (kwh > 90)
            {
                bill = 2.80 + 78 * .08 + (kwh + 90) * 0.06;
        
            }

            MessageBox.Show("Your hydro bill is " + bill.ToString("c"));
        }
    }
}
