namespace BoringIdleGame
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnButton = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblItem3Prc = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblItem3Lvl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnItem3 = new System.Windows.Forms.Button();
            this.lblItem2Prc = new System.Windows.Forms.Label();
            this.lblItem2Lvl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnItem2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblItem1Prc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblItem1Lvl = new System.Windows.Forms.Label();
            this.btnItem1 = new System.Windows.Forms.Button();
            this.timerNumberUpdater = new System.Windows.Forms.Timer(this.components);
            this.timerLabelUpdater = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.progressBarButton = new System.Windows.Forms.ProgressBar();
            this.timerProgressBar = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.lblAutoClick = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Coolvetica Rg", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number:";
            // 
            // btnButton
            // 
            this.btnButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnButton.Font = new System.Drawing.Font("Coolvetica Rg", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnButton.Location = new System.Drawing.Point(13, 69);
            this.btnButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnButton.Name = "btnButton";
            this.btnButton.Size = new System.Drawing.Size(260, 91);
            this.btnButton.TabIndex = 1;
            this.btnButton.Text = "Button";
            this.toolTip1.SetToolTip(this.btnButton, "Click");
            this.btnButton.UseVisualStyleBackColor = true;
            this.btnButton.Click += new System.EventHandler(this.btnButton_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Coolvetica Rg", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(211, 9);
            this.lblNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(48, 57);
            this.lblNumber.TabIndex = 2;
            this.lblNumber.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblItem3Prc);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblItem3Lvl);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnItem3);
            this.groupBox1.Controls.Add(this.lblItem2Prc);
            this.groupBox1.Controls.Add(this.lblItem2Lvl);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnItem2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblItem1Prc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblItem1Lvl);
            this.groupBox1.Controls.Add(this.btnItem1);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(650, 471);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Purchase Items";
            // 
            // lblItem3Prc
            // 
            this.lblItem3Prc.AutoSize = true;
            this.lblItem3Prc.Location = new System.Drawing.Point(380, 137);
            this.lblItem3Prc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItem3Prc.Name = "lblItem3Prc";
            this.lblItem3Prc.Size = new System.Drawing.Size(49, 29);
            this.lblItem3Prc.TabIndex = 14;
            this.lblItem3Prc.Text = "500";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(303, 137);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "Price:";
            // 
            // lblItem3Lvl
            // 
            this.lblItem3Lvl.AutoSize = true;
            this.lblItem3Lvl.Location = new System.Drawing.Point(251, 137);
            this.lblItem3Lvl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItem3Lvl.Name = "lblItem3Lvl";
            this.lblItem3Lvl.Size = new System.Drawing.Size(25, 29);
            this.lblItem3Lvl.TabIndex = 12;
            this.lblItem3Lvl.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(171, 137);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Level:";
            // 
            // btnItem3
            // 
            this.btnItem3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnItem3.Enabled = false;
            this.btnItem3.Font = new System.Drawing.Font("Coolvetica Rg", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItem3.Location = new System.Drawing.Point(7, 127);
            this.btnItem3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnItem3.Name = "btnItem3";
            this.btnItem3.Size = new System.Drawing.Size(156, 42);
            this.btnItem3.TabIndex = 10;
            this.btnItem3.Text = "Item 3";
            this.toolTip1.SetToolTip(this.btnItem3, "Increases Auto Click Speed");
            this.btnItem3.UseVisualStyleBackColor = true;
            this.btnItem3.Click += new System.EventHandler(this.btnItem3_Click);
            // 
            // lblItem2Prc
            // 
            this.lblItem2Prc.AutoSize = true;
            this.lblItem2Prc.Location = new System.Drawing.Point(380, 88);
            this.lblItem2Prc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItem2Prc.Name = "lblItem2Prc";
            this.lblItem2Prc.Size = new System.Drawing.Size(44, 29);
            this.lblItem2Prc.TabIndex = 9;
            this.lblItem2Prc.Text = "100";
            // 
            // lblItem2Lvl
            // 
            this.lblItem2Lvl.AutoSize = true;
            this.lblItem2Lvl.Location = new System.Drawing.Point(251, 88);
            this.lblItem2Lvl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItem2Lvl.Name = "lblItem2Lvl";
            this.lblItem2Lvl.Size = new System.Drawing.Size(25, 29);
            this.lblItem2Lvl.TabIndex = 8;
            this.lblItem2Lvl.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 88);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 88);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Level:";
            // 
            // btnItem2
            // 
            this.btnItem2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnItem2.Enabled = false;
            this.btnItem2.Font = new System.Drawing.Font("Coolvetica Rg", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItem2.Location = new System.Drawing.Point(7, 79);
            this.btnItem2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnItem2.Name = "btnItem2";
            this.btnItem2.Size = new System.Drawing.Size(156, 42);
            this.btnItem2.TabIndex = 5;
            this.btnItem2.Text = "Item 2";
            this.toolTip1.SetToolTip(this.btnItem2, "+1 Button Click");
            this.btnItem2.UseVisualStyleBackColor = true;
            this.btnItem2.Click += new System.EventHandler(this.btnItem2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Level:";
            // 
            // lblItem1Prc
            // 
            this.lblItem1Prc.AutoSize = true;
            this.lblItem1Prc.Location = new System.Drawing.Point(380, 39);
            this.lblItem1Prc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItem1Prc.Name = "lblItem1Prc";
            this.lblItem1Prc.Size = new System.Drawing.Size(32, 29);
            this.lblItem1Prc.TabIndex = 3;
            this.lblItem1Prc.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price:";
            // 
            // lblItem1Lvl
            // 
            this.lblItem1Lvl.AutoSize = true;
            this.lblItem1Lvl.Location = new System.Drawing.Point(251, 39);
            this.lblItem1Lvl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItem1Lvl.Name = "lblItem1Lvl";
            this.lblItem1Lvl.Size = new System.Drawing.Size(25, 29);
            this.lblItem1Lvl.TabIndex = 1;
            this.lblItem1Lvl.Text = "0";
            // 
            // btnItem1
            // 
            this.btnItem1.BackColor = System.Drawing.Color.Transparent;
            this.btnItem1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnItem1.Enabled = false;
            this.btnItem1.Font = new System.Drawing.Font("Coolvetica Rg", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItem1.Location = new System.Drawing.Point(7, 31);
            this.btnItem1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnItem1.Name = "btnItem1";
            this.btnItem1.Size = new System.Drawing.Size(156, 42);
            this.btnItem1.TabIndex = 0;
            this.btnItem1.Text = "Item 1";
            this.toolTip1.SetToolTip(this.btnItem1, "+1 Auto Click");
            this.btnItem1.UseVisualStyleBackColor = false;
            this.btnItem1.Click += new System.EventHandler(this.btnItem1_Click);
            // 
            // timerNumberUpdater
            // 
            this.timerNumberUpdater.Interval = 1000;
            this.timerNumberUpdater.Tick += new System.EventHandler(this.timerNumberUpdater_Tick);
            // 
            // timerLabelUpdater
            // 
            this.timerLabelUpdater.Interval = 20;
            this.timerLabelUpdater.Tick += new System.EventHandler(this.timerLabelUpdater_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabControl1.Location = new System.Drawing.Point(281, 70);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(674, 525);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Size = new System.Drawing.Size(666, 483);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Buy stuff";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Size = new System.Drawing.Size(666, 499);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Buy More Stuff";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // progressBarButton
            // 
            this.progressBarButton.Location = new System.Drawing.Point(13, 601);
            this.progressBarButton.MarqueeAnimationSpeed = 10;
            this.progressBarButton.Maximum = 2000;
            this.progressBarButton.Name = "progressBarButton";
            this.progressBarButton.Size = new System.Drawing.Size(942, 27);
            this.progressBarButton.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarButton.TabIndex = 6;
            this.toolTip1.SetToolTip(this.progressBarButton, "Fill the bar for a bonus!");
            // 
            // timerProgressBar
            // 
            this.timerProgressBar.Interval = 10;
            this.timerProgressBar.Tick += new System.EventHandler(this.timerProgressBar_Tick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 537);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(260, 58);
            this.label8.TabIndex = 7;
            this.label8.Text = "Hover over things to see\r\nwhat they do.\r\n";
            // 
            // lblAutoClick
            // 
            this.lblAutoClick.AutoSize = true;
            this.lblAutoClick.Location = new System.Drawing.Point(13, 173);
            this.lblAutoClick.Name = "lblAutoClick";
            this.lblAutoClick.Size = new System.Drawing.Size(147, 29);
            this.lblAutoClick.TabIndex = 8;
            this.lblAutoClick.Text = "Auto Clicks: 0";
            // 
            // Game
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(967, 640);
            this.Controls.Add(this.lblAutoClick);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.progressBarButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.btnButton);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Coolvetica Rg", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(983, 679);
            this.MinimumSize = new System.Drawing.Size(983, 679);
            this.Name = "Game";
            this.Text = "Boring Idle Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnButton;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblItem1Prc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblItem1Lvl;
        private System.Windows.Forms.Button btnItem1;
        private System.Windows.Forms.Timer timerNumberUpdater;
        private System.Windows.Forms.Timer timerLabelUpdater;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblItem2Prc;
        private System.Windows.Forms.Label lblItem2Lvl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnItem2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ProgressBar progressBarButton;
        private System.Windows.Forms.Timer timerProgressBar;
        private System.Windows.Forms.Label lblItem3Prc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblItem3Lvl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnItem3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAutoClick;
    }
}

