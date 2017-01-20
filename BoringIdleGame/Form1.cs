using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace BoringIdleGame
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        //Initialize Variables
        //button
        int intButton = 1;
        int intNumber = 0;
        int intAutoClicks = 0;

        //bonus bar
        decimal decProgressAmount = 0;
        int intProgressGoal = 1;
        decimal decProgressAdd = .126m;

        //items
        //item 1
        int intItem1 = 0;
        int intItem1Lvl = 0;
        int intItem1Prc = 10;

        //item 2
        int intItem2 = 0;
        int intItem2Lvl = 0;
        int intItem2Prc = 250;

        //item 3
        int intItem3 = 0;
        int intItem3Lvl = 0;
        int intItem3Prc = 1250;

        //item 4
        int intItem4 = 0;
        int intItem4Lvl = 0;
        int intItem4Prc = 10000;

        //item 5
        int intItem5 = 0;
        int intItem5Lvl = 0;
        int intItem5Prc = 60000;

        //item 6
        int intItem6 = 0;
        int intItem6Lvl = 0;
        int intItem6Prc = 250000;

        //item 7
        int intItem7 = 0;
        int intItem7Lvl = 0;
        int intItem7Prc = 10000000;

        //item 8
        int intItem8 = 0;
        int intItem8Lvl = 0;
        int intItem8Prc = 250000000;

        //upgrades

        //upgrade 1
        // upgrade 1 is intButton
        int intUpgrade1Lvl = 1;
        int intUpgrade1Prc = 100;

        //upgrade 2
        int intUpgrade2 = 0;
        int intUpgrade2Lvl = 0;
        int intUpgrade2Prc = 1000;

        //upgrade 3
        int intUpgrade3 = 0;
        int intUpgrade3Lvl = 0;
        int intUpgrade3Prc = 100000;

        //upgrade 4
        int intUpgrade4 = 1;
        int intUpgrade4Lvl = 0;
        int intUpgrade4Prc = 750000;

        //form load
        private void Game_Load(object sender, EventArgs e)
        {
            timerNumberUpdater.Start();
            timerLabelUpdater.Start();
            timerProgressBar.Start();
        }

        //click the button
        private void btnButton_Click(object sender, EventArgs e)
        {
            intNumber += intButton;
            lblNumber.Text = String.Format( "{0:n0}", intNumber);

            if (decProgressAmount < 2)
                decProgressAmount += decProgressAdd;

        }

        //Right click the button
        private void btnButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && intUpgrade4 > 0)
            {
                intNumber += intButton;
                lblNumber.Text = String.Format("{0:n0}", intNumber);

                if (decProgressAmount < 2)
                    decProgressAmount += decProgressAdd;
            }
        }





        //Items
        //Item 1 Button 
        private void btnItem1_Click(object sender, EventArgs e)
        {
            Upgrade(ref intItem1, 1, ref intItem1Prc, 1.24, ref intItem1Lvl, lblItem1Prc, lblItem1Lvl);
        }

        //Item 2 Button 
        private void btnItem2_Click(object sender, EventArgs e)
        {
            Upgrade(ref intItem2, 5, ref intItem2Prc, 1.27, ref intItem2Lvl, lblItem2Prc, lblItem2Lvl);
        }

        //Item 3 Button 
        private void btnItem3_Click(object sender, EventArgs e)
        {
            Upgrade(ref intItem3, 25, ref intItem3Prc, 1.30, ref intItem3Lvl, lblItem3Prc, lblItem3Lvl);
        }

        //Item 4 Button 
        private void btnItem4_Click(object sender, EventArgs e)
        {
            Upgrade(ref intItem4, 300, ref intItem4Prc, 1.33, ref intItem4Lvl, lblItem4Prc, lblItem4Lvl);
        }

        //Item 5 Button 
        private void btnItem5_Click(object sender, EventArgs e)
        {
            Upgrade(ref intItem5, 1000, ref intItem5Prc, 1.35, ref intItem5Lvl, lblItem5Prc, lblItem5Lvl);
        }

        //Item 6 Button 
        private void btnItem6_Click(object sender, EventArgs e)
        {
            Upgrade(ref intItem6, 2000, ref intItem6Prc, 1.37, ref intItem6Lvl, lblItem6Prc, lblItem6Lvl);
        }

        //Item 7 Button 
        private void btnItem7_Click(object sender, EventArgs e)
        {
            Upgrade(ref intItem7, 10000, ref intItem7Prc, 1.39, ref intItem7Lvl, lblItem7Prc, lblItem7Lvl);
        }

        //Item 8 Button 
        private void btnItem8_Click(object sender, EventArgs e)
        {
            Upgrade(ref intItem8, 100000, ref intItem8Prc, 1.43, ref intItem8Lvl, lblItem8Prc, lblItem8Lvl);
        }







        //Upgrades
        //Upgrade 1 Button (Button Upgrade)
        private void btnUpgrade1_Click(object sender, EventArgs e)
        {
            Upgrade(ref intButton, 1, ref intUpgrade1Prc, 1.49, ref intUpgrade1Lvl, lblUpgrade1Prc, lblUpgrade1Lvl);
        }

        //Upgrade 2 Button (Auto Clicker Upgrade)
        private void btnUpgrade2_Click(object sender, EventArgs e)
        {
            Upgrade(ref intUpgrade2, 1, ref intUpgrade2Prc, 2.53, ref intUpgrade2Lvl, lblUpgrade2Prc, lblUpgrade2Lvl);
            timerNumberUpdater.Interval = Convert.ToInt32(timerNumberUpdater.Interval * 0.93);
        }

        //Upgrade 3 Button (Bonus Bar Upgrade)
        private void btnUpgrade3_Click(object sender, EventArgs e)
        {
            Upgrade(ref intUpgrade3, 1, ref intUpgrade3Prc, 1.55, ref intUpgrade3Lvl, lblUpgrade3Prc, lblUpgrade3Lvl);
            progressBarButton.Maximum = Convert.ToInt32(progressBarButton.Maximum * .76);
        }

        //Upgrade 4 Button (Right Click)
        private void btnUpgrade4_Click(object sender, EventArgs e)
        {
            Upgrade(ref intUpgrade4, 1, ref intUpgrade4Prc, 0, ref intUpgrade4Lvl, lblUpgrade4Prc, lblUpgrade4Lvl);
            lblUpgrade4Prc.Text = "---";
        }



        //Numbers per second
        private void timerNumberUpdater_Tick(object sender, EventArgs e)
        {
            intNumber += intItem1 + intItem2 + intItem3 + intItem4 + intItem5 + intItem6 + intItem7 + intItem8;
            lblNumber.Text = String.Format("{0:n0}", intNumber);

        }






        //Label Updater
        private void timerLabelUpdater_Tick(object sender, EventArgs e)
        {
            //Auto Clicks
            intAutoClicks = intItem1 + intItem2 + intItem3 + intItem4 + intItem5 + intItem6 + intItem7 + intItem8;
            lblAutoClick.Text = "Auto Clicks: " + String.Format("{0:n0}",intAutoClicks);

            //Item 1
            btnItem1.Enabled = (intNumber >= intItem1Prc) ? true : false;

            //Item 2
            btnItem2.Enabled = (intNumber >= intItem2Prc) ? true : false;

            //Item 3
            btnItem3.Enabled = (intNumber >= intItem3Prc) ? true : false;

            //Item 4
            btnItem4.Enabled = (intNumber >= intItem4Prc) ? true : false;

            //Item 5
            btnItem5.Enabled = (intNumber >= intItem5Prc) ? true : false;

            //Item 6
            btnItem6.Enabled = (intNumber >= intItem6Prc) ? true : false;

            //Item 7
            btnItem7.Enabled = (intNumber >= intItem7Prc) ? true : false;

            //Item 8
            btnItem8.Enabled = (intNumber >= intItem8Prc) ? true : false;

            //Upgrade 1
            btnUpgrade1.Enabled = (intNumber >= intUpgrade1Prc) ? true : false;

            //Upgrade 2
            btnUpgrade2.Enabled = (intNumber >= intUpgrade2Prc) ? true : false;

            //Upgrade 3
            btnUpgrade3.Enabled = (intNumber >= intUpgrade3Prc) ? true : false;

            //Upgrade 4
            btnUpgrade4.Enabled = (intNumber >= intUpgrade4Prc && intUpgrade4 < 1) ? true : false;
        }






        //Progress bar timer
        private void timerProgressBar_Tick(object sender, EventArgs e)
        {
            if (decProgressAmount > -10 && progressBarButton.Value > 1)
            {
                decProgressAmount -= 0.0123m;
            }

            if (decProgressAmount > 0)
            {
                if (progressBarButton.Value + Convert.ToInt32(decProgressAmount) < progressBarButton.Maximum)
                {
                    progressBarButton.Value += Convert.ToInt32(decProgressAmount);
                }
                else
                {
                    //decProgressAmount = 0;
                    progressBarButton.Value = 0;
                    intNumber = Convert.ToInt32(Convert.ToDouble(intNumber) * 1.3);
                }
            }

            if (decProgressAmount < 0 && progressBarButton.Value + Convert.ToInt32(decProgressAmount) > 0)
            {
                progressBarButton.Value += Convert.ToInt32(decProgressAmount);
            }
            else if (progressBarButton.Value + Convert.ToInt32(decProgressAmount) < 0)
            {
                progressBarButton.Value = 0;
                decProgressAmount = 0;
            }

        }





        //upgrade method
        public void Upgrade(ref int Item, int ItemAmount, ref int Price, double PrcInc, ref int Level, Label lblPrice, Label lblLevel)
        {
            intNumber -= Price;
            lblNumber.Text = String.Format("{0:n0}", intNumber);

            ++Level;
            lblLevel.Text = String.Format("{0:n0}", Level);

            Price = Convert.ToInt32(Math.Round(Convert.ToDouble(Price) * PrcInc));
            lblPrice.Text = String.Format("{0:n0}", Price);

            Item += ItemAmount;
        }


    }
}
