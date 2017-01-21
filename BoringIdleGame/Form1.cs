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
using System.IO;

namespace BoringIdleGame
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        
        //Initialize variables
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
        int intUpgrade4 = 0;
        int intUpgrade4Lvl = 0;
        int intUpgrade4Prc = 750000;


        //form load
        private void Game_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            timerNumberUpdater.Start();
            timerLabelUpdater.Start();
            timerProgressBar.Start();


            //Load

            // create reader & open file
            TextReader tr = new StreamReader("SavedGame.txt");

            // read lines of text
            string intButtonString = tr.ReadLine();
            string intNumberString= tr.ReadLine();
            string intAutoClicksString = tr.ReadLine();
            string decProgressAmountString = tr.ReadLine();
            string intProgressGoalString = tr.ReadLine();
            string decProgressAddString = tr.ReadLine();
            string intItem1String = tr.ReadLine();
            string intItem1LvlString = tr.ReadLine();
            string intItem1PrcString = tr.ReadLine();
            string intItem2String = tr.ReadLine();
            string intItem2LvlString = tr.ReadLine();
            string intItem2PrcString = tr.ReadLine();
            string intItem3String = tr.ReadLine();
            string intItem3LvlString = tr.ReadLine();
            string intItem3PrcString = tr.ReadLine();
            string intItem4String = tr.ReadLine();
            string intItem4LvlString = tr.ReadLine();
            string intItem4PrcString = tr.ReadLine();
            string intItem5String = tr.ReadLine();
            string intItem5LvlString = tr.ReadLine();
            string intItem5PrcString = tr.ReadLine();
            string intItem6String = tr.ReadLine();
            string intItem6LvlString = tr.ReadLine();
            string intItem6PrcString = tr.ReadLine();
            string intItem7String = tr.ReadLine();
            string intItem7LvlString = tr.ReadLine();
            string intItem7PrcString = tr.ReadLine();
            string intItem8String = tr.ReadLine();
            string intItem8LvlString = tr.ReadLine();
            string intItem8PrcString = tr.ReadLine();
            string intUpgrade1LvlString = tr.ReadLine();
            string intUpgrade1PrcString = tr.ReadLine();
            string intUpgrade2String = tr.ReadLine();
            string intUpgrade2LvlString = tr.ReadLine();
            string intUpgrade2PrcString = tr.ReadLine();
            string intUpgrade3String = tr.ReadLine();
            string intUpgrade3LvlString = tr.ReadLine();
            string intUpgrade3PrcString = tr.ReadLine();
            string intUpgrade4String = tr.ReadLine();
            string intUpgrade4LvlString = tr.ReadLine();
            string intUpgrade4PrcString = tr.ReadLine();


            //Convert the strings to int
            intButton = Convert.ToInt32(intButtonString);
            intNumber = Convert.ToInt32(intNumberString);
            intAutoClicks = Convert.ToInt32(intAutoClicksString);
            decProgressAmount = Convert.ToDecimal(decProgressAmountString);
            intProgressGoal = Convert.ToInt32(intProgressGoalString);
            decProgressAdd = Convert.ToDecimal(decProgressAddString);
            intItem1 = Convert.ToInt32(intItem1String);
            intItem1Lvl = Convert.ToInt32(intItem1LvlString);
            intItem1Prc = Convert.ToInt32(intItem1PrcString);
            intItem2 = Convert.ToInt32(intItem2String);
            intItem2Lvl = Convert.ToInt32(intItem2LvlString);
            intItem2Prc = Convert.ToInt32(intItem2PrcString);
            intItem3 = Convert.ToInt32(intItem3String);
            intItem3Lvl = Convert.ToInt32(intItem3LvlString);
            intItem3Prc = Convert.ToInt32(intItem3PrcString);
            intItem4 = Convert.ToInt32(intItem4String);
            intItem4Lvl = Convert.ToInt32(intItem4LvlString);
            intItem4Prc = Convert.ToInt32(intItem4PrcString);
            intItem5 = Convert.ToInt32(intItem5String);
            intItem5Lvl = Convert.ToInt32(intItem5LvlString);
            intItem5Prc = Convert.ToInt32(intItem5PrcString);
            intItem6 = Convert.ToInt32(intItem6String);
            intItem6Lvl = Convert.ToInt32(intItem6LvlString);
            intItem6Prc = Convert.ToInt32(intItem6PrcString);
            intItem7 = Convert.ToInt32(intItem7String);
            intItem7Lvl = Convert.ToInt32(intItem7LvlString);
            intItem7Prc = Convert.ToInt32(intItem7PrcString);
            intItem8 = Convert.ToInt32(intItem8String);
            intItem8Lvl = Convert.ToInt32(intItem8LvlString);
            intItem8Prc = Convert.ToInt32(intItem8PrcString);
            intUpgrade1Lvl = Convert.ToInt32(intUpgrade1LvlString);
            intUpgrade1Prc = Convert.ToInt32(intUpgrade1PrcString);
            intUpgrade2 = Convert.ToInt32(intUpgrade2String);
            intUpgrade2Lvl = Convert.ToInt32(intUpgrade2LvlString);
            intUpgrade2Prc = Convert.ToInt32(intUpgrade2PrcString);
            intUpgrade3 = Convert.ToInt32(intUpgrade3String);
            intUpgrade3Lvl = Convert.ToInt32(intUpgrade3LvlString);
            intUpgrade3Prc = Convert.ToInt32(intUpgrade3PrcString);
            intUpgrade4 = Convert.ToInt32(intUpgrade4String);
            intUpgrade4Lvl = Convert.ToInt32(intUpgrade4LvlString);
            intUpgrade4Prc = Convert.ToInt32(intUpgrade4PrcString);


            // close the stream
            tr.Close();
            timerSave.Start();
            Cursor.Current = Cursors.Default;
        }



        //click the button
        private void btnButton_MouseDown(object sender, MouseEventArgs e)
        {
            //right click
            if (e.Button == MouseButtons.Right && intUpgrade4 > 0)
            {
                intNumber += intButton;
                lblNumber.Text = String.Format("{0:n0}", intNumber);

                if (decProgressAmount < 2)
                    decProgressAmount += decProgressAdd;
            }

            //left click
            if (e.Button == MouseButtons.Left)
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

            //Prices and Levels
            lblItem1Lvl.Text = String.Format("{0:n0}", intItem1Lvl);
            lblItem2Lvl.Text = String.Format("{0:n0}", intItem2Lvl);
            lblItem3Lvl.Text = String.Format("{0:n0}", intItem3Lvl);
            lblItem4Lvl.Text = String.Format("{0:n0}", intItem4Lvl);
            lblItem5Lvl.Text = String.Format("{0:n0}", intItem5Lvl);
            lblItem6Lvl.Text = String.Format("{0:n0}", intItem6Lvl);
            lblItem7Lvl.Text = String.Format("{0:n0}", intItem7Lvl);
            lblItem8Lvl.Text = String.Format("{0:n0}", intItem8Lvl);
            lblUpgrade1Lvl.Text = String.Format("{0:n0}", intUpgrade1Lvl);
            lblUpgrade2Lvl.Text = String.Format("{0:n0}", intUpgrade2Lvl);
            lblUpgrade3Lvl.Text = String.Format("{0:n0}", intUpgrade3Lvl);
            lblUpgrade4Lvl.Text = String.Format("{0:n0}", intUpgrade4Lvl);

            lblItem1Prc.Text = String.Format("{0:n0}", intItem1Prc);
            lblItem2Prc.Text = String.Format("{0:n0}", intItem2Prc);
            lblItem3Prc.Text = String.Format("{0:n0}", intItem3Prc);
            lblItem4Prc.Text = String.Format("{0:n0}", intItem4Prc);
            lblItem5Prc.Text = String.Format("{0:n0}", intItem5Prc);
            lblItem6Prc.Text = String.Format("{0:n0}", intItem6Prc);
            lblItem7Prc.Text = String.Format("{0:n0}", intItem7Prc);
            lblItem8Prc.Text = String.Format("{0:n0}", intItem8Prc);
            lblUpgrade1Prc.Text = String.Format("{0:n0}", intUpgrade1Prc);
            lblUpgrade2Prc.Text = String.Format("{0:n0}", intUpgrade2Prc);
            lblUpgrade3Prc.Text = String.Format("{0:n0}", intUpgrade3Prc);
            lblUpgrade4Prc.Text = String.Format("{0:n0}", intUpgrade4Prc);

            lblAutoClick.Text = "Auto Clicks: " + String.Format("{0:n0}", intAutoClicks);

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

        //Save timer
        private void timerSave_Tick(object sender, EventArgs e)
        {
            TextWriter tw = new StreamWriter("SavedGame.txt");

            // write lines of text to the file
            tw.WriteLine(intButton);
            tw.WriteLine(intNumber);
            tw.WriteLine(intAutoClicks);
            tw.WriteLine(decProgressAdd);
            tw.WriteLine(intProgressGoal);
            tw.WriteLine(decProgressAmount);
            tw.WriteLine(intItem1);
            tw.WriteLine(intItem1Lvl);
            tw.WriteLine(intItem1Prc);
            tw.WriteLine(intItem2);
            tw.WriteLine(intItem2Lvl);
            tw.WriteLine(intItem2Prc);
            tw.WriteLine(intItem3);
            tw.WriteLine(intItem3Lvl);
            tw.WriteLine(intItem3Prc);
            tw.WriteLine(intItem4);
            tw.WriteLine(intItem4Lvl);
            tw.WriteLine(intItem4Prc);
            tw.WriteLine(intItem5);
            tw.WriteLine(intItem5Lvl);
            tw.WriteLine(intItem5Prc);
            tw.WriteLine(intItem6);
            tw.WriteLine(intItem6Lvl);
            tw.WriteLine(intItem6Prc);
            tw.WriteLine(intItem7);
            tw.WriteLine(intItem7Lvl);
            tw.WriteLine(intItem7Prc);
            tw.WriteLine(intItem8);
            tw.WriteLine(intItem8Lvl);
            tw.WriteLine(intItem8Prc);
            tw.WriteLine(intUpgrade1Lvl);
            tw.WriteLine(intUpgrade1Prc);
            tw.WriteLine(intUpgrade2);
            tw.WriteLine(intUpgrade2Lvl);
            tw.WriteLine(intUpgrade2Prc);
            tw.WriteLine(intUpgrade3);
            tw.WriteLine(intUpgrade3Lvl);
            tw.WriteLine(intUpgrade3Prc);
            tw.WriteLine(intUpgrade4);
            tw.WriteLine(intUpgrade4Lvl);
            tw.WriteLine(intUpgrade4Prc);



            // close the stream     
            tw.Close();
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

        //Reset
        private void button1_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to reset?",
                                     "Confirm Reset",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                var confirmResult2 = MessageBox.Show("Are you ABSOLUTELY sure you want to reset?",
                         "Confirm Reset",
                         MessageBoxButtons.YesNo);
                if (confirmResult2 == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    //Initialize variables
                    //button
                    intButton = 1;
                    intNumber = 0;
                    intAutoClicks = 0;

                    //bonus bar
                    decProgressAmount = 0;
                    intProgressGoal = 1;
                    decProgressAdd = .126m;

                    //items
                    //item 1
                    intItem1 = 0;
                    intItem1Lvl = 0;
                    intItem1Prc = 10;

                    //item 2
                    intItem2 = 0;
                    intItem2Lvl = 0;
                    intItem2Prc = 250;

                    //item 3
                    intItem3 = 0;
                    intItem3Lvl = 0;
                    intItem3Prc = 1250;

                    //item 4
                    intItem4 = 0;
                    intItem4Lvl = 0;
                    intItem4Prc = 10000;

                    //item 5
                    intItem5 = 0;
                    intItem5Lvl = 0;
                    intItem5Prc = 60000;

                    //item 6
                    intItem6 = 0;
                    intItem6Lvl = 0;
                    intItem6Prc = 250000;

                    //item 7
                    intItem7 = 0;
                    intItem7Lvl = 0;
                    intItem7Prc = 10000000;

                    //item 8
                    intItem8 = 0;
                    intItem8Lvl = 0;
                    intItem8Prc = 250000000;

                    //upgrades

                    //upgrade 1
                    // upgrade 1 is intButton
                    intUpgrade1Lvl = 1;
                    intUpgrade1Prc = 100;

                    //upgrade 2
                    intUpgrade2 = 0;
                    intUpgrade2Lvl = 0;
                    intUpgrade2Prc = 1000;

                    //upgrade 3
                    intUpgrade3 = 0;
                    intUpgrade3Lvl = 0;
                    intUpgrade3Prc = 100000;

                    //upgrade 4
                    intUpgrade4 = 0;
                    intUpgrade4Lvl = 0;
                    intUpgrade4Prc = 750000;
                    Cursor.Current = Cursors.Default;
                }
            }
        }
    }
}
