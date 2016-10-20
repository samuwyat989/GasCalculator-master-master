//Due: October 14 2016, Created by Sam Wyatt, calculates gas prices and fullness of your car.
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
        //Declair variables 
        const double GAS_PRIEMIUM = 1.019;
        const double GAS_REGULAR = 0.869;
        const double GAS_MID = 0.946;
        const double CAR_V = 49.9;
        const double TRUCK_V = 87;
        const double MINI_V = 76;
        string gasIn;
        string gasOut;
        string spend;
        string tender;
        double cost;
        double fuel;
        double given;
        double tax;
        double costWithoutTax;
        double change;
        double gasAmount;
        double gasRate;
        double vehicalType;

        public storeInterface()
        {
            InitializeComponent();
        }

        private void storeInterface_Load(object sender, EventArgs e)
        {
            //hide rates
            regularBox.Visible = false;
            midBox.Visible = false;
            premiumBox.Visible = false;
        }
        //The following series of events enables you to see the rate of the gas type when you hover over them
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

        private void costButton_Click(object sender, EventArgs e)  //Calculates Total Cost
        {
            gasIn = fuelAmount.Text;
            gasOut = fuelNeeded.Text;
            
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
                    vehicalType = CAR_V;
                }
                else if (truckCheck.Checked)
                {
                    vehicalType = TRUCK_V;
                }
                else
                {
                    vehicalType = MINI_V;
                }

                costWithoutTax = ((Convert.ToDouble(gasOut) - Convert.ToDouble(gasIn)) * gasRate * vehicalType);//set for the print
                tax = (Convert.ToDouble(gasOut) - Convert.ToDouble(gasIn)) * gasRate * vehicalType * 0.13;//set for the print
                
                if (option1.Checked)
                {
                    cost = ((Convert.ToDouble(gasOut) - Convert.ToDouble(gasIn)) * gasRate * vehicalType) * 1.13; //calculates cost
                    outputLabel1.Text = "The cost is: " + cost.ToString("C");

                    gasIn = fuelAmount.Text;
                    gasOut = fuelNeeded.Text;
                    gasAmount = (Convert.ToDouble(gasOut) - Convert.ToDouble(gasIn)) * vehicalType; //set for the print
                }
            }
            catch
            {
                outputLabel2.ForeColor = Color.Navy;
                outputLabel1.Text = "Please remember to fill all requirements. \nCheck the help section above if needed.";
            }
        }

        private void fullButton_Click(object sender, EventArgs e)
        {
            ///The if statments need to be made again because you can't click the cost button when option 2 is selected and because 
            ///I don't know how to declair if statements globally.
     
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
                vehicalType = CAR_V;
            }
            else if (truckCheck.Checked)
            {
                vehicalType = TRUCK_V;
            }
            else
            {
                vehicalType = MINI_V;
            }
      
            spend = moneyRequest.Text;
            gasIn = fuelAmount.Text;

            try
            {
                    fuel = ((Convert.ToDouble(spend) / gasRate) + (Convert.ToDouble(gasIn) * vehicalType)) / vehicalType * 100;
                    if (fuel > 100)
                    {
                        fuel = (1 - Convert.ToDouble(gasIn)) * gasRate * vehicalType;
                        outputLabel2.Text = "Your tank is over filled.\nThe amount of money needed\nto fill your tank is: "
                        + fuel.ToString("C");
                    }
                    else
                    {
                        fuel = (((Convert.ToDouble(gasIn) * vehicalType) + (Convert.ToDouble(spend) / gasRate)) / vehicalType) * 100;
                        outputLabel2.Text = "Your tank is: " + fuel.ToString(".##") + "% full.";

                    gasIn = fuelAmount.Text;
                    gasOut = fuelNeeded.Text;
                    gasAmount = (Convert.ToDouble(gasOut) - Convert.ToDouble(gasIn)) * vehicalType; //set for the print
                } 
            }
            catch
            {
                outputLabel2.ForeColor = Color.Navy;
                outputLabel2.Text = "Please remember to fill all\nrequirements. Check the help\nsection above if needed.";
            }    
        }

        private void changeButton_Click(object sender, EventArgs e)     //Calculates Change
        {
            

            try
            {
                tender = tenderBox.Text;
                given = Convert.ToDouble(tender);
                change = Convert.ToDouble(tender) - cost;
                
                if (change < 0)
                {
                    outputLabel1.Text = "There are insuficient funds.";
                }
                else if (change == given)
                {
                    outputLabel1.Text = "Please calculate cost first.";
                }

                else
                {
                    outputLabel1.Text = "The cost is: " + cost.ToString("C") +
                        "\nYour change is: " + change.ToString("C");
                }
            }
            catch
            {
                outputLabel2.ForeColor = Color.Navy;
                outputLabel1.Text = "Please remember to fill all requirements. \nCheck the help section above if needed.";
            }
        }

        private void printButton_Click(object sender, EventArgs e)//Prints Receipt
        {
            try 
            {
                tender = tenderBox.Text; 
                given = Convert.ToDouble(tender);
                

                this.Size = new Size(1021, 484);
                Graphics print = this.CreateGraphics();
                SolidBrush whiteBrush = new SolidBrush(Color.White);
                SolidBrush textBrush = new SolidBrush(Color.Black);
                Font printFont = new Font("Courier New", 11, FontStyle.Bold);
                Font smallFont = new Font("Courier New", 9);

                    print.FillRectangle(whiteBrush, 735, 20, 225, 400);
                    print.DrawString("THE GAS CORNER", printFont, textBrush, 765, 30);

                    print.DrawString("Sub Total:", smallFont, textBrush, 765, 60);
                    print.DrawString(costWithoutTax.ToString("C"), smallFont, textBrush, 900, 60);

                    print.DrawString("Tax @ 13%:", smallFont, textBrush, 765, 100);
                    print.DrawString(tax.ToString("C"), smallFont, textBrush, 900, 100);

                    print.DrawString("Total:", smallFont, textBrush, 765, 140);                                
                    print.DrawString(cost.ToString("C"), smallFont, textBrush, 900, 140);

                    print.DrawString("Amount of gas:", smallFont, textBrush, 765, 180);
                    print.DrawString(gasAmount.ToString("##.## L"), smallFont, textBrush, 895, 180);

                    print.DrawString("Tender Amount:", smallFont, textBrush, 765, 220);
                    print.DrawString(given.ToString("C"), smallFont, textBrush, 900, 220);

                    print.DrawString("Change:", smallFont, textBrush, 765, 260);
                    print.DrawString(change.ToString("C"), smallFont, textBrush, 900, 260);

                    print.DrawString("Thank you.", printFont, textBrush, 765, 350);

                    /*int loopNumber = 300;
                    int xr = 721;
                    for (int x = 0; x < loopNumber; x++)
                    {
                        this.Size = new Size(xr, 484);
                        Thread.Sleep(1);
                        xr++;
                    }*/
                    
                //}

                //else if (option2.Checked)
                //{
                    /*cost = Convert.ToDouble(moneyRequest.Text) / gasRate;
                    print.DrawString(cost.ToString("##.## L"), smallFont, textBrush, 795, 80);
                    print.DrawString("Amount of gas recived:", smallFont, textBrush, 765, 60);
                    print.DrawString("Rate:", smallFont, textBrush, 765, 100);
                    print.DrawString(gasRate.ToString("$ #.### / L"), smallFont, textBrush, 795, 120);
                    print.DrawString("Thank you.", printFont, textBrush, 765, 350);*/
                //}
            }
            catch
            {
                outputLabel2.ForeColor = Color.Red;
                outputLabel2.Text = "Please remember to fill all\nrequirements. Check the help\nsection above if needed.";
            }
            
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)//Resets everything 
        {
            fuelAmount.Text = "Ex. 50% full = 0.5";
            fuelNeeded.Text = "Ex. 100% full = 1";
            tenderBox.Text = "Tendered Amount";
            moneyRequest.Text = "";
            regCheck.Checked = false;
            midCheck.Checked = false;
            premCheck.Checked = false;
            option1.Checked = false;
            option2.Checked = false;
            carCheck.Checked = false;
            truckCheck.Checked = false;
            miniCheck.Checked = false;
            outputLabel1.Text = "";
            outputLabel2.Text = "";
            this.Size = new Size(721, 484);
        }

        //When a check box is checked the other options are disabled, when it is unchecked it goes back to normal
        private void option1_CheckStateChanged(object sender, EventArgs e)
        {
            if (option2.Enabled == true)
            {
                option2.Enabled = false;
                moneyRequest.Enabled = false;
                fullButton.Enabled = false;
                fullButton.BackColor = Color.Black;
                reqirements3.ForeColor = Color.Black;
                moneyRequest.BackColor = Color.Black;
                outputLabel2.Text = "";
            }
            else
            {
                option2.Enabled = true;
                moneyRequest.Enabled = true;
                fullButton.Enabled = true;
                fullButton.BackColor = Color.FromArgb(224,224,224);
                reqirements3.ForeColor = Color.White;
                moneyRequest.BackColor = Color.White;
                fuelNeeded.Text = "Ex. 100% full = 1";
                tenderBox.Text = "Tendered Amount";
                outputLabel1.Text = "";
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
                costButton.Enabled = false;
                fuelNeeded.BackColor = Color.Black;
                tenderBox.BackColor = Color.Black;
                fuelNeeded.Text = "";
                tenderBox.Text = "";
                costButton.BackColor = Color.Black;
                changeButton.BackColor = Color.Black;
                outputLabel1.Text = "";
            }
            else
            {
                option1.Enabled = true;
                fuelNeeded.Enabled = true;
                tenderBox.Enabled = true;
                changeButton.Enabled = true;
                costButton.Enabled = true;
                fuelNeeded.BackColor = Color.White;
                tenderBox.BackColor = Color.White;
                fuelNeeded.Text = "Ex. 100% full = 1";
                tenderBox.Text = "Tendered Amount";
                costButton.BackColor = Color.FromArgb(224, 224, 224); 
                changeButton.BackColor = Color.FromArgb(224, 224, 224);
                moneyRequest.Text = "";
                outputLabel2.Text = "";          
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
            if (truckCheck.Enabled == true && miniCheck.Enabled == true)
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

        private void storeInterface_Paint(object sender, PaintEventArgs e)
        {
            Graphics box = this.CreateGraphics();
            SolidBrush redBrush = new SolidBrush(Color.Red);
            Pen redPen = new Pen(Color.Red, 3);
            box.FillRectangle(redBrush, 16, 405, 680, 33);
            box.DrawLine(redPen, 16, 47, 690, 47);
        }
    }
}
