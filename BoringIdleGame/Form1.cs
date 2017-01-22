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
using System.Security;
using System.Security.Cryptography;

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
        Int64 intButton = 1;
        decimal decNumber = 0;
        Int64 intAutoClicks = 0;


        //items
        //item 1
        Int64 intItem1 = 0;
        Int64 intItem1Lvl = 0;
        Int64 intItem1Prc = 10;

        //item 2
        Int64 intItem2 = 0;
        Int64 intItem2Lvl = 0;
        Int64 intItem2Prc = 250;

        //item 3
        Int64 intItem3 = 0;
        Int64 intItem3Lvl = 0;
        Int64 intItem3Prc = 5000;

        //item 4
        Int64 intItem4 = 0;
        Int64 intItem4Lvl = 0;
        Int64 intItem4Prc = 100000;

        //item 5
        Int64 intItem5 = 0;
        Int64 intItem5Lvl = 0;
        Int64 intItem5Prc = 1000000;

        //item 6
        Int64 intItem6 = 0;
        Int64 intItem6Lvl = 0;
        Int64 intItem6Prc = 25000000;

        //item 7
        Int64 intItem7 = 0;
        Int64 intItem7Lvl = 0;
        Int64 intItem7Prc = 1000000000;

        //item 8
        Int64 intItem8 = 0;
        Int64 intItem8Lvl = 0;
        Int64 intItem8Prc = 100000000000;

        //upgrades

        //upgrade 1
        // upgrade 1 is intButton
        Int64 intUpgrade1Lvl = 1;
        Int64 intUpgrade1Prc = 100;

        //upgrade 2
        Int64 intUpgrade2 = 0;
        Int64 intUpgrade2Lvl = 0;
        Int64 intUpgrade2Prc = 1000;

        //upgrade 3
        Int64 intUpgrade3 = 0;
        Int64 intUpgrade3Lvl = 0;
        Int64 intUpgrade3Prc = 100000;

        //upgrade 4
        Int64 intUpgrade4 = 0;
        Int64 intUpgrade4Lvl = 0;
        Int64 intUpgrade4Prc = 1500000;

        //Upgrade 5
        // upgrade 5 is intButton
        Int64 intUpgrade5Lvl = 0;
        Int64 intUpgrade5Prc = 10000000;

        //Win
        bool blWin = false; //This is if you reach the max number

        //Date/time
        DateTime dtCurrent = DateTime.Now; //The current date
        DateTime dtPast = DateTime.Now; //The date since last login
        DateTime lastModified = System.IO.File.GetLastWriteTime("SavedGame.txt");


        //Bonus Bar
        double dbBonusBar = 0; //Counter
        double dbBonusBarLimit = 1; //What counter needs to reach




        //form load
        private void Game_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            //Start timers
            timerNumberUpdater.Start();
            timerLabelUpdater.Start();
            timerProgressBar.Start();


            //Load

            // create reader & open file
            try
            {
                TextReader tr = new StreamReader("SavedGame.txt");

                // read lines of text
                tr.ReadLine();
                string intButtonString = tr.ReadLine();
                string decNumberString = tr.ReadLine();
                string intAutoClicksString = tr.ReadLine();
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
                string dtPastString = tr.ReadLine();
                string intUpgrade5LvlString = tr.ReadLine();
                string intUpgrade5PrcString = tr.ReadLine();

                //Convert the strings to int
                intButton = Convert.ToInt64(intButtonString);
                decNumber = Convert.ToDecimal(decNumberString);
                intAutoClicks = Convert.ToInt64(intAutoClicksString);
                intItem1 = Convert.ToInt64(intItem1String);
                intItem1Lvl = Convert.ToInt64(intItem1LvlString);
                intItem1Prc = Convert.ToInt64(intItem1PrcString);
                intItem2 = Convert.ToInt64(intItem2String);
                intItem2Lvl = Convert.ToInt64(intItem2LvlString);
                intItem2Prc = Convert.ToInt64(intItem2PrcString);
                intItem3 = Convert.ToInt64(intItem3String);
                intItem3Lvl = Convert.ToInt64(intItem3LvlString);
                intItem3Prc = Convert.ToInt64(intItem3PrcString);
                intItem4 = Convert.ToInt64(intItem4String);
                intItem4Lvl = Convert.ToInt64(intItem4LvlString);
                intItem4Prc = Convert.ToInt64(intItem4PrcString);
                intItem5 = Convert.ToInt64(intItem5String);
                intItem5Lvl = Convert.ToInt64(intItem5LvlString);
                intItem5Prc = Convert.ToInt64(intItem5PrcString);
                intItem6 = Convert.ToInt64(intItem6String);
                intItem6Lvl = Convert.ToInt64(intItem6LvlString);
                intItem6Prc = Convert.ToInt64(intItem6PrcString);
                intItem7 = Convert.ToInt64(intItem7String);
                intItem7Lvl = Convert.ToInt64(intItem7LvlString);
                intItem7Prc = Convert.ToInt64(intItem7PrcString);
                intItem8 = Convert.ToInt64(intItem8String);
                intItem8Lvl = Convert.ToInt64(intItem8LvlString);
                intItem8Prc = Convert.ToInt64(intItem8PrcString);
                intUpgrade1Lvl = Convert.ToInt64(intUpgrade1LvlString);
                intUpgrade1Prc = Convert.ToInt64(intUpgrade1PrcString);
                intUpgrade2 = Convert.ToInt64(intUpgrade2String);
                intUpgrade2Lvl = Convert.ToInt64(intUpgrade2LvlString);
                intUpgrade2Prc = Convert.ToInt64(intUpgrade2PrcString);
                intUpgrade3 = Convert.ToInt64(intUpgrade3String);
                intUpgrade3Lvl = Convert.ToInt64(intUpgrade3LvlString);
                intUpgrade3Prc = Convert.ToInt64(intUpgrade3PrcString);
                intUpgrade4 = Convert.ToInt64(intUpgrade4String);
                intUpgrade4Lvl = Convert.ToInt64(intUpgrade4LvlString);
                intUpgrade4Prc = Convert.ToInt64(intUpgrade4PrcString);
                dtPast = Convert.ToDateTime(dtPastString);
                intUpgrade5Lvl = Convert.ToInt64(intUpgrade5LvlString);
                intUpgrade5Prc = Convert.ToInt64(intUpgrade5PrcString);

                // close the stream
                tr.Close();
            }
            catch
            { }
            //Calculate auto clicks since last login
            Int64 intMilliseconds = Convert.ToInt64((dtCurrent - dtPast).TotalMilliseconds);
            decNumber += (intMilliseconds/timerNumberUpdater.Interval) * (intItem1 + intItem2 + intItem3 + intItem4 + intItem5 + intItem6 + intItem7 + intItem8);



            //if file has been modified, reset
            try
            {

                if (dtPast.AddMilliseconds(1000) < lastModified) 
                {
                    MessageBox.Show("The game has been reset because you tried to cheat. Next time, heed the warning.", "Cheater");
                    Reset();
                }
            }
            catch
            { }

            //start saving
            timerSave.Start();
            Cursor.Current = Cursors.Default;
        
        }



        //click the button
        private void btnButton_MouseDown(object sender, MouseEventArgs e)
        {
            //right click
            if (e.Button == MouseButtons.Right && intUpgrade4 > 0)
            {
                decNumber += intButton;
                lblNumber.Text = String.Format("{0:n0}", decNumber);

                //reset bonus bar
                dbBonusBar = 0;
                if (progressBarButton.Value != progressBarButton.Maximum)
                    progressBarButton.Value += 1;
                
            }

            //left click
            if (e.Button == MouseButtons.Left)
            {
                decNumber += intButton;
                lblNumber.Text = String.Format("{0:n0}", decNumber);

                //reset bonus bar
                dbBonusBar = 0;
                if (progressBarButton.Value != progressBarButton.Maximum)
                    progressBarButton.Value += 1;
            }
        }





        //Items
        //Item 1 Button 
        private void btnItem1_Click(object sender, EventArgs e)
        {
            Upgrade(ref intItem1, 1, ref intItem1Prc, 1.16, ref intItem1Lvl, lblItem1Prc, lblItem1Lvl);
        }

        //Item 2 Button 
        private void btnItem2_Click(object sender, EventArgs e)
        {
            Upgrade(ref intItem2, 10, ref intItem2Prc, 1.27, ref intItem2Lvl, lblItem2Prc, lblItem2Lvl);
        }

        //Item 3 Button 
        private void btnItem3_Click(object sender, EventArgs e)
        {
            Upgrade(ref intItem3, 50, ref intItem3Prc, 1.30, ref intItem3Lvl, lblItem3Prc, lblItem3Lvl);
        }

        //Item 4 Button 
        private void btnItem4_Click(object sender, EventArgs e)
        {
            Upgrade(ref intItem4, 1000, ref intItem4Prc, 1.33, ref intItem4Lvl, lblItem4Prc, lblItem4Lvl);
        }

        //Item 5 Button 
        private void btnItem5_Click(object sender, EventArgs e)
        {
            Upgrade(ref intItem5, 5000, ref intItem5Prc, 1.35, ref intItem5Lvl, lblItem5Prc, lblItem5Lvl);
        }

        //Item 6 Button 
        private void btnItem6_Click(object sender, EventArgs e)
        {
            Upgrade(ref intItem6, 50000, ref intItem6Prc, 1.37, ref intItem6Lvl, lblItem6Prc, lblItem6Lvl);
        }

        //Item 7 Button 
        private void btnItem7_Click(object sender, EventArgs e)
        {
            Upgrade(ref intItem7, 100000, ref intItem7Prc, 1.39, ref intItem7Lvl, lblItem7Prc, lblItem7Lvl);
        }

        //Item 8 Button 
        private void btnItem8_Click(object sender, EventArgs e)
        {
            Upgrade(ref intItem8, 1000000, ref intItem8Prc, 1.43, ref intItem8Lvl, lblItem8Prc, lblItem8Lvl);
        }







        //Upgrades
        //Upgrade 1 Button (Button Upgrade)
        private void btnUpgrade1_Click(object sender, EventArgs e)
        {
            Upgrade(ref intButton, 1, ref intUpgrade1Prc, 1.29, ref intUpgrade1Lvl, lblUpgrade1Prc, lblUpgrade1Lvl);
        }

        //Upgrade 2 Button (Auto Clicker Upgrade)
        private void btnUpgrade2_Click(object sender, EventArgs e)
        {
            Upgrade(ref intUpgrade2, 1, ref intUpgrade2Prc, 1.74, ref intUpgrade2Lvl, lblUpgrade2Prc, lblUpgrade2Lvl);
            timerNumberUpdater.Interval = Convert.ToInt32(timerNumberUpdater.Interval * 0.93);
        }

        //Upgrade 3 Button (Bonus Bar Upgrade)
        private void btnUpgrade3_Click(object sender, EventArgs e)
        {
            Upgrade(ref intUpgrade3, 1, ref intUpgrade3Prc, 1.55, ref intUpgrade3Lvl, lblUpgrade3Prc, lblUpgrade3Lvl);
            progressBarButton.Maximum = Convert.ToInt32(progressBarButton.Maximum * .84);
        }

        //Upgrade 4 Button (Right Click)
        private void btnUpgrade4_Click(object sender, EventArgs e)
        {
            Upgrade(ref intUpgrade4, 1, ref intUpgrade4Prc, 0, ref intUpgrade4Lvl, lblUpgrade4Prc, lblUpgrade4Lvl);
            lblUpgrade4Prc.Text = "---";
        }

        //Upgrade 5 Button
        private void btnUpgrade5_Click(object sender, EventArgs e)
        {
            Upgrade(ref intButton, 10000, ref intUpgrade1Prc, 1.19, ref intUpgrade5Lvl, lblUpgrade5Prc, lblUpgrade5Lvl);
        }



        //Numbers per second
        private void timerNumberUpdater_Tick(object sender, EventArgs e)
        {
            try
            {
                decNumber += intItem1 + intItem2 + intItem3 + intItem4 + intItem5 + intItem6 + intItem7 + intItem8;
            }
            catch 
            {

            }
            lblNumber.Text = String.Format("{0:n0}", decNumber);

        }






        //Label Updater
        private void timerLabelUpdater_Tick(object sender, EventArgs e)
        {
            //Auto Clicks
            intAutoClicks = intItem1 + intItem2 + intItem3 + intItem4 + intItem5 + intItem6 + intItem7 + intItem8;
            lblAutoClick.Text = "Auto Clicks: " + String.Format("{0:n0}",intAutoClicks);

            //Item 1
            btnItem1.Enabled = (decNumber >= intItem1Prc) ? true : false;

            //Item 2
            btnItem2.Enabled = (decNumber >= intItem2Prc) ? true : false;

            //Item 3
            btnItem3.Enabled = (decNumber >= intItem3Prc) ? true : false;

            //Item 4
            btnItem4.Enabled = (decNumber >= intItem4Prc) ? true : false;

            //Item 5
            btnItem5.Enabled = (decNumber >= intItem5Prc) ? true : false;

            //Item 6
            btnItem6.Enabled = (decNumber >= intItem6Prc) ? true : false;

            //Item 7
            btnItem7.Enabled = (decNumber >= intItem7Prc) ? true : false;

            //Item 8
            btnItem8.Enabled = (decNumber >= intItem8Prc) ? true : false;

            //Upgrade 1
            btnUpgrade1.Enabled = (decNumber >= intUpgrade1Prc) ? true : false;

            //Upgrade 2
            btnUpgrade2.Enabled = (decNumber >= intUpgrade2Prc) ? true : false;

            //Upgrade 3
            btnUpgrade3.Enabled = (decNumber >= intUpgrade3Prc) ? true : false;

            //Upgrade 4
            btnUpgrade4.Enabled = (decNumber >= intUpgrade4Prc && intUpgrade4 < 1) ? true : false;

            //Upgrade 5
            btnUpgrade5.Enabled = (decNumber >= intUpgrade5Prc) ? true : false;

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
            lblUpgrade5Lvl.Text = String.Format("{0:n0}", intUpgrade5Lvl);

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
            
            if (intUpgrade4Lvl != 1)
            {
                lblUpgrade4Prc.Text = String.Format("{0:n0}", intUpgrade4Prc);
            }

            lblUpgrade5Prc.Text = String.Format("{0:n0}", intUpgrade5Prc);

            lblAutoClick.Text = "Auto Clicks: " + String.Format("{0:n0}", intAutoClicks);

            if (decNumber >= 79228000000000000000000000000m && blWin == false)
            {
                MessageBox.Show("You win! Get a life!", "Winner!");
                blWin = true;
                Reset();
                blWin = false;


            }



        }






        //Progress bar timer
        private void timerProgressBar_Tick(object sender, EventArgs e)
        {
            

            dbBonusBar += 0.01;

            //change limit
            dbBonusBarLimit = Convert.ToDouble((1 - (Convert.ToDecimal(progressBarButton.Value) / Convert.ToDecimal(progressBarButton.Maximum)))/1.7m);
            if (dbBonusBarLimit < .1)
            {
               dbBonusBarLimit = .1;
            }
            
            //subtract
            if (dbBonusBar >= dbBonusBarLimit)
            {
                if (progressBarButton.Value - 1 >= 0)
                {
                    progressBarButton.Value -= 1;
                }

            }

            if (progressBarButton.Value == progressBarButton.Maximum)
            {
                progressBarButton.Value = 0;
                decNumber *= 1.3m;
            }
        }

        //Save timer
        private void timerSave_Tick(object sender, EventArgs e)
        {
            dtPast = DateTime.Now;

            TextWriter tw = new StreamWriter("SavedGame.txt");

            // write lines of text to the file
            tw.WriteLine("Changing this file will result in everything being deleted.");
            tw.WriteLine(intButton);
            tw.WriteLine(decNumber);
            tw.WriteLine(intAutoClicks);
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
            tw.WriteLine(dtPast);
            tw.WriteLine(intUpgrade5Lvl);
            tw.WriteLine(intUpgrade5Prc);



            // close the stream     
            tw.Close();
        }



        //upgrade method
        public void Upgrade(ref Int64 Item, Int64 ItemAmount, ref Int64 Price, double PrcInc, ref Int64 Level, Label lblPrice, Label lblLevel)
        {
            decNumber -= Price;
            lblNumber.Text = String.Format("{0:n0}", decNumber);

            ++Level;
            lblLevel.Text = String.Format("{0:n0}", Level);

            try
            {
                Price = Convert.ToInt64(Math.Round(Convert.ToDouble(Price) * PrcInc));
                lblPrice.Text = String.Format("{0:n0}", Price);
            }
            catch { }

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
                    Reset();
                    Cursor.Current = Cursors.Default;
                }
            }
        }

        public void Reset()
        {
            //button
            intButton = 1;
            decNumber = 0;
            intAutoClicks = 0;


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
            intItem3Prc = 5000;

            //item 4
            intItem4 = 0;
            intItem4Lvl = 0;
            intItem4Prc = 100000;

            //item 5
            intItem5 = 0;
            intItem5Lvl = 0;
            intItem5Prc = 1000000;

            //item 6
            intItem6 = 0;
            intItem6Lvl = 0;
            intItem6Prc = 25000000;

            //item 7
            intItem7 = 0;
            intItem7Lvl = 0;
            intItem7Prc = 1000000000;

            //item 8
            intItem8 = 0;
            intItem8Lvl = 0;
            intItem8Prc = 100000000000;

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
            intUpgrade4Prc = 1500000;

            //Upgrade 5
            // upgrade 5 is intButton
            intUpgrade5Lvl = 0;
            intUpgrade5Prc = 10000000;
        }

    }
}
