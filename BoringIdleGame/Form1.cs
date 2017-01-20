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

        //bonus bar
        decimal dbProgressAmount = 0;
        int intProgressGoal = 1;

        //item 1
        int intItem1 = 0;
        int intItem1Lvl = 0;
        int intItem1Prc = 10;

        //item 2 is intButton
        int intItem2Lvl = 1;
        int intItem2Prc = 100;

        int intItem3 = 0;
        int intItem3Lvl = 0;
        int intItem3Prc = 500;


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
            lblNumber.Text = Convert.ToString(intNumber);

            if (dbProgressAmount < 2)
                dbProgressAmount += .126m;


        }


        //Item 1 Button (Auto Clicker 1)
        private void btnItem1_Click(object sender, EventArgs e)
        {
            Upgrade(ref intItem1, 1, ref intItem1Prc, 1.33, ref intItem1Lvl, lblItem1Prc, lblItem1Lvl);
        }

        //Item 2 Button (Button Upgrade
        private void btnItem2_Click(object sender, EventArgs e)
        {
            Upgrade(ref intButton, 1, ref intItem2Prc, 1.71, ref intItem2Lvl, lblItem2Prc, lblItem2Lvl);
        }

        //Item 3 Button
        private void btnItem3_Click(object sender, EventArgs e)
        {
            Upgrade(ref intItem3, 1, ref intItem3Prc, 2.11, ref intItem3Lvl, lblItem3Prc, lblItem3Lvl);
            timerNumberUpdater.Interval = Convert.ToInt32(timerNumberUpdater.Interval * 0.81);
        }

        //Numbers per second
        private void timerNumberUpdater_Tick(object sender, EventArgs e)
        {
            intNumber += intItem1;
            lblNumber.Text = Convert.ToString(intNumber);

        }

        //Label Updater
        private void timerLabelUpdater_Tick(object sender, EventArgs e)
        {
            //Auto Clicks
            lblAutoClick.Text = "Auto Clicks: " + intItem1;

            //Item 1
            btnItem1.Enabled = (intNumber >= intItem1Prc) ? true : false;

            //Item 2
            btnItem2.Enabled = (intNumber >= intItem2Prc) ? true : false;

            //Item 3
            btnItem3.Enabled = (intNumber >= intItem3Prc) ? true : false;
        }


        //Progress bar timer
        private void timerProgressBar_Tick(object sender, EventArgs e)
        {
            if (dbProgressAmount > -10 && progressBarButton.Value > 1)
            {
                dbProgressAmount -= 0.0123m;
            }

            if (dbProgressAmount > 0)
            {
                if (progressBarButton.Value + Convert.ToInt32(dbProgressAmount) < progressBarButton.Maximum)
                {
                    progressBarButton.Value += Convert.ToInt32(dbProgressAmount);
                }
                else
                {
                    //dbProgressAmount = 0;
                    progressBarButton.Value = 0;
                    intNumber = Convert.ToInt32(Convert.ToDouble(intNumber) * 1.5);
                }
            }

            if (dbProgressAmount < 0 && progressBarButton.Value + Convert.ToInt32(dbProgressAmount) > 0)
            {
                progressBarButton.Value += Convert.ToInt32(dbProgressAmount);
            }
            else if (progressBarButton.Value + Convert.ToInt32(dbProgressAmount) < 0)
            {
                progressBarButton.Value = 0;
                dbProgressAmount = 0;
            }

        }

        //upgrade method
        public void Upgrade(ref int Item, int ItemAmount, ref int Price, double PrcInc, ref int Level, Label lblPrice, Label lblLevel)
        {
            intNumber -= Price;
            lblNumber.Text = Convert.ToString(intNumber);

            ++Level;
            lblLevel.Text = Convert.ToString(Level);

            Price = Convert.ToInt32(Math.Round(Convert.ToDouble(Price) * PrcInc));
            lblPrice.Text = Convert.ToString(Price);

            Item += ItemAmount;
        }
    }
}
