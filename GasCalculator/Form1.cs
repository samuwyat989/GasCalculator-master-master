using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Threading;

namespace GasCalculator
{
    public partial class storeInterface : Form
    {
        const double GAS_PRIEMIUM = 1.019;
        const double GAS_REGULAR = 0.869;
        const double GAS_MID = 0.946;
        double carV = 49.9;
        double truckV = 87;
        double miniV = 76;
        string gasIn;
        string gasOut;
        string spend;
        string tender;
        double message;
        double change;

        public storeInterface()
        {
            InitializeComponent();
        }

        private void storeInterface_Load(object sender, EventArgs e)
        {
            Graphics lines = this.CreateGraphics();
            Pen redPen = new Pen(Color.Red, 4);
            lines.DrawLine(redPen, 10, 30, 400, 30);
            lines.DrawLine(redPen, 480, 30, 700, 30);

            Graphics gas = this.CreateGraphics();
            gas.DrawImage(Properties.Resources.fuel_gauge, 400, 100, 150 , 250);
           
            regularBox.Visible = false;
            midBox.Visible = false;
            premiumBox.Visible = false;
        }

        private void regCheck_MouseHover(object sender, EventArgs e)
        {
            regularBox.Visible = true;
        }

        private void regCheck_MouseLeave(object sender, EventArgs e)
        {
            regularBox.Visible = false;
        }

        private void midCheck_MouseHover(object sender, EventArgs e)
        {
            midBox.Visible = true;
        }

        private void midCheck_MouseLeave(object sender, EventArgs e)
        {
            midBox.Visible = false;
        }

        private void premCheck_MouseHover(object sender, EventArgs e)
        {
            premiumBox.Visible = true;
        }

        private void premCheck_MouseLeave(object sender, EventArgs e)
        {
            premiumBox.Visible = false;
        }

        private void costButton_Click(object sender, EventArgs e)//Calculates Total Cost
        {
            //posibly have a title screen so that a click event can be made other than the load form

            double gasRate;
            double vehicalType;
            gasIn = fuelAmount.Text;
            gasOut = fuelNeeded.Text;
            spend = moneyRequest.Text;
            tender = tenderBox.Text;

            Graphics box = CreateGraphics();
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            box.FillRectangle(redBrush, 500, 375, 150, 65);

            try
            {
                if (regCheck.Checked) // Checks for what fuel type
                {
                    gasRate = GAS_REGULAR;
                }
                else if (midCheck.Checked)
                {
                    gasRate = GAS_MID;
                }
                else
                {
                    gasRate = GAS_PRIEMIUM;
                }

                if (carCheck.Checked) // Checks for what vehical type
                {
                    vehicalType = carV;
                }
                else if (truckCheck.Checked)
                {
                    vehicalType = truckV;
                }
                else
                {
                    vehicalType = miniV;
                }

                if (option1.Checked) // Checks which option you chose
                {
                    message = (Convert.ToDouble(gasOut) - Convert.ToDouble(gasIn)) * gasRate * vehicalType;
                    outputLabel.Text = "The cost is: " + message.ToString("C");
                }
                else
                {
                    message = ((Convert.ToDouble(spend) / gasRate) + (Convert.ToDouble(gasIn) * vehicalType)) / vehicalType * 100;
                    if (message > 100)
                    {
                        message = (1 - Convert.ToDouble(gasIn)) * gasRate * vehicalType;
                        outputLabel.Text = "Your tank is over filled.\nThe amount of money needed\nto fill your tank is: "
                        + message.ToString(".##");           
                    }
                    else
                    {
                        message = ((Convert.ToDouble(spend) / gasRate) + (Convert.ToDouble(gasIn) * vehicalType)) / vehicalType * 100;
                        outputLabel.Text = "Your tank is:" + message.ToString(".##") + " % full.";
                    }                   
                }
            }
            catch
            {
                outputLabel.Text = "Please remember to fill all requirements. \nCheck the help section above if needed.";
            }
        }

        private void changeButton_Click(object sender, EventArgs e)     //Calculates Change
        {
            double gasRate;
            double vehicalType;
            gasIn = fuelAmount.Text;
            gasOut = fuelNeeded.Text;
            tender = tenderBox.Text;

            try
            {
                if (regCheck.Checked) // Checks for what fuel type
                {
                    gasRate = GAS_REGULAR;
                }

                else if (midCheck.Checked)
                {
                    gasRate = GAS_MID;
                }

                else
                {
                    gasRate = GAS_PRIEMIUM;
                }

                if (carCheck.Checked) // Checks for what vehical type
                {
                    vehicalType = carV;
                }

                else if (truckCheck.Checked)
                {
                    vehicalType = truckV;
                }

                else
                {
                    vehicalType = miniV;
                }

                change = Convert.ToDouble(tender) - ((Convert.ToDouble(gasOut) - Convert.ToDouble(gasIn)) * gasRate * vehicalType);

                if (change < 0)
                {
                    outputLabel.Text = "There are insuficient funds.";
                }
                else
                {
                    outputLabel.Text = "Your change is: " + change.ToString("C");
                }             
            }
            catch
            {
                outputLabel.Text = "Please remember to fill all requirements. \nCheck the help section above if needed.";
            }
        }

        private void printButton_Click(object sender, EventArgs e)//Prints Receipt
        {
            int loopNumber = 300;
            int xr = 721;
            for (int x = 0; x < loopNumber; x++)
            {
                this.Size = new Size(xr, 484);
                Thread.Sleep(1);
                xr++;
            }

            //message = (Convert.ToDouble(gasOut) - Convert.ToDouble(gasIn)) * gasRate * vehicalType;
            //outputLabel.Text = "The cost is: " + message.ToString("C");

            Graphics print = this.CreateGraphics();
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            SolidBrush textBrush = new SolidBrush(Color.Black);
            Font printFont = new Font("Courier New", 12);

            print.FillRectangle(whiteBrush, 735, 20, 225, 400);
            print.DrawString("THE GAS CORNER", printFont, textBrush, 765, 30);
            print.DrawString(Convert.ToString(DateTime.Today), printFont, textBrush, 765, 45);

            double gasRate;
            double vehicalType;
            gasIn = fuelAmount.Text;
            gasOut = fuelNeeded.Text;
            tender = tenderBox.Text;

            if (regCheck.Checked)
            {
                gasRate = GAS_REGULAR; 
            }
            else if (midCheck.Checked)
            {
                gasRate = GAS_MID;
            }
            else
            {
                gasRate = GAS_PRIEMIUM;
            }

            if (carCheck.Checked)
            {
                vehicalType = carV;
            }
            else if (truckCheck.Checked)
            {
                vehicalType = truckV;
            }
            else 
            {
                vehicalType = miniV;
            }

            message = (Convert.ToDouble(gasOut) - Convert.ToDouble(gasIn)) * gasRate * vehicalType; //cost    

            print.DrawString("Sub Total:", printFont, textBrush, 765, 60);
            print.DrawString(message.ToString("C"), printFont, textBrush, 795, 90);
            print.DrawString("Taxes: 13%", printFont, textBrush, 765, 120);

            message = (Convert.ToDouble(gasOut) - Convert.ToDouble(gasIn)) * gasRate * vehicalType * 0.13;
            print.DrawString(message.ToString("C"), printFont, textBrush, 795, 150);

            message = (Convert.ToDouble(gasOut) - Convert.ToDouble(gasIn)) * gasRate * vehicalType * 1.13;
            print.DrawString("Total:", printFont, textBrush, 765, 180);
            print.DrawString(message.ToString("C"), printFont, textBrush, 795, 210);

            print.DrawString("Amount of gas:", printFont, textBrush, 765, 240);
            message = (Convert.ToDouble(gasOut) - Convert.ToDouble(gasIn)) * vehicalType;
            print.DrawString(message.ToString("##.## L"), printFont, textBrush, 795, 270);

            print.DrawString("Thank you.", printFont, textBrush, 765, 300);

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)//Resets everything 
        {
            fuelAmount.Text = "";
            fuelNeeded.Text = "";
            tenderBox.Text = "";
            moneyRequest.Text = "";
            regCheck.Checked = false;
            midCheck.Checked = false;
            premCheck.Checked = false;
            option1.Checked = false;
            option2.Checked = false;
            carCheck.Checked = false;
            truckCheck.Checked = false;
            miniCheck.Checked = false;
            outputLabel.Text = "";
            Graphics box = this.CreateGraphics();
            SolidBrush navyBrush = new SolidBrush(Color.Navy);
            box.FillRectangle(navyBrush, 30, 365, 250, 65);
            box.FillRectangle(navyBrush, 500, 375, 150, 65);

            int loopNumber = 300;
            int xr = 1021;
            for (int x = 0; x < loopNumber; x++)
            {
                this.Size = new Size(xr, 484);
                Thread.Sleep(1);
                xr--;
            }
        }       
 
        //When a check box is checked the other options are disabled, when it is unchecked it goes back to normal
        private void option1_CheckStateChanged(object sender, EventArgs e)
        {
            if (option2.Enabled == true)
            {
                option2.Enabled = false;
                moneyRequest.Enabled = false;
            }
            else
            {
                option2.Enabled = true;
                moneyRequest.Enabled = true;
            }
        }

        private void option2_CheckStateChanged(object sender, EventArgs e)
        {
            if (option1.Enabled == true)
            {
                option1.Enabled = false;
                fuelNeeded.Enabled = false;
                tenderBox.Enabled = false;
                changeButton.Enabled = false;
            }
            else
            {
                option1.Enabled = true;
                fuelNeeded.Enabled = true;
                tenderBox.Enabled = true;
                changeButton.Enabled = true;
            }
        }

        private void regCheck_CheckStateChanged(object sender, EventArgs e)
        {
            if (midCheck.Enabled == true && premCheck.Enabled == true)
            {
                midCheck.Enabled = false;
                premCheck.Enabled = false;
            }
            else
            {
                midCheck.Enabled = true;
                premCheck.Enabled = true;
            }
        }

        private void midCheck_CheckStateChanged(object sender, EventArgs e)
        {
            if (regCheck.Enabled == true && premCheck.Enabled == true)
            {
                regCheck.Enabled = false;
                premCheck.Enabled = false;
            }
            else
            {
                regCheck.Enabled = true;
                premCheck.Enabled = true;
            }
        }

        private void premCheck_CheckStateChanged(object sender, EventArgs e)
        {
            if (midCheck.Enabled == true && regCheck.Enabled == true)
            {
                midCheck.Enabled = false;
                regCheck.Enabled = false;
            }
            else
            {
                midCheck.Enabled = true;
                regCheck.Enabled = true;
            }
        }

        private void carCheck_CheckStateChanged(object sender, EventArgs e)
        {
            if (truckCheck.Enabled == true && miniCheck.Enabled ==true)
            {
                truckCheck.Enabled = false;
                miniCheck.Enabled = false;
            }
            else
            {
                truckCheck.Enabled = true;
                miniCheck.Enabled = true;
            }
        }

        private void truckCheck_CheckStateChanged(object sender, EventArgs e)
        {
            if (carCheck.Enabled == true && miniCheck.Enabled == true)
            {
                carCheck.Enabled = false;
                miniCheck.Enabled = false;
            }
            else
            {
                carCheck.Enabled = true;
                miniCheck.Enabled = true;
            }
        }

        private void miniCheck_CheckStateChanged(object sender, EventArgs e)
        {
            if (truckCheck.Enabled == true && carCheck.Enabled == true)
            {
                truckCheck.Enabled = false;
                carCheck.Enabled = false;
            }
            else
            {
                truckCheck.Enabled = true;
                carCheck.Enabled = true;
            }
        }
    }
}
