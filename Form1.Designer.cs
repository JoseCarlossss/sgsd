namespace XMLtoDatabase
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Button btnImportAccessory;


        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtConnectionString = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            button17 = new Button();
            button16 = new Button();
            label3 = new Label();
            button15 = new Button();
            button14 = new Button();
            button13 = new Button();
            button12 = new Button();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            progressBar1 = new ProgressBar();
            btnConnect = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtConnectionString
            // 
            txtConnectionString.Location = new Point(20, 94);
            txtConnectionString.Name = "txtConnectionString";
            txtConnectionString.Size = new Size(554, 23);
            txtConnectionString.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 71);
            label1.Name = "label1";
            label1.Size = new Size(148, 21);
            label1.TabIndex = 1;
            label1.Text = "ConnectionString:";
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.bg1;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(button17);
            panel1.Controls.Add(button16);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button15);
            panel1.Controls.Add(button14);
            panel1.Controls.Add(button13);
            panel1.Controls.Add(button12);
            panel1.Controls.Add(button11);
            panel1.Controls.Add(button10);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(progressBar1);
            panel1.Controls.Add(btnConnect);
            panel1.Controls.Add(txtConnectionString);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(760, 398);
            panel1.TabIndex = 2;
            // 
            // 
            // btnImportAccessory
            // 
            btnImportAccessory = new Button();
            btnImportAccessory.Location = new Point(300, 254);
            btnImportAccessory.Name = "btnImportAccessory";
            btnImportAccessory.Size = new Size(134, 32);
            btnImportAccessory.TabIndex = 25;
            btnImportAccessory.Text = "AccessoryStatus.xml";
            btnImportAccessory.UseVisualStyleBackColor = true;
            btnImportAccessory.Click += new EventHandler(btnImportAccessory_Click);
            panel1.Controls.Add(btnImportAccessory);


            // button17
            // 
            button17.Location = new Point(160, 254);
            button17.Name = "button17";
            button17.Size = new Size(134, 32);
            button17.TabIndex = 24;
            button17.Text = "Scan.xml";
            button17.UseVisualStyleBackColor = true;
            button17.Click += button17_Click;
            // 
            // button16
            // 
            button16.Location = new Point(20, 254);
            button16.Name = "button16";
            button16.Size = new Size(134, 32);
            button16.TabIndex = 23;
            button16.Text = "Container.xml";
            button16.UseVisualStyleBackColor = true;
            button16.Click += button16_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(631, 377);
            label3.Name = "label3";
            label3.Size = new Size(125, 17);
            label3.TabIndex = 22;
            label3.Text = "Atualized By JC";
            // 
            // button15
            // 
            button15.Location = new Point(581, 217);
            button15.Name = "button15";
            button15.Size = new Size(134, 32);
            button15.TabIndex = 21;
            button15.Text = "Hatch.xml";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // button14
            // 
            button14.Location = new Point(440, 217);
            button14.Name = "button14";
            button14.Size = new Size(134, 32);
            button14.TabIndex = 20;
            button14.Text = "Summon.xml";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // button13
            // 
            button13.Location = new Point(300, 217);
            button13.Name = "button13";
            button13.Size = new Size(134, 32);
            button13.TabIndex = 19;
            button13.Text = "DigimonSkill.xml";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // button12
            // 
            button12.Location = new Point(160, 217);
            button12.Name = "button12";
            button12.Size = new Size(134, 32);
            button12.TabIndex = 18;
            button12.Text = "Skill.xml (SkillInfo)";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button11
            // 
            button11.Location = new Point(20, 217);
            button11.Name = "button11";
            button11.Size = new Size(134, 32);
            button11.TabIndex = 17;
            button11.Text = "Skill.xml (Code)";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button10
            // 
            button10.Location = new Point(580, 179);
            button10.Name = "button10";
            button10.Size = new Size(134, 32);
            button10.TabIndex = 16;
            button10.Text = "ItemXAI.xml";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button9
            // 
            button9.Location = new Point(580, 143);
            button9.Name = "button9";
            button9.Size = new Size(134, 32);
            button9.TabIndex = 15;
            button9.Text = "ItemList.xml";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.Location = new Point(440, 179);
            button8.Name = "button8";
            button8.Size = new Size(134, 32);
            button8.TabIndex = 14;
            button8.Text = "MasterCard.xml";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Location = new Point(300, 179);
            button7.Name = "button7";
            button7.Size = new Size(134, 32);
            button7.TabIndex = 13;
            button7.Text = "Quest.xml";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(160, 180);
            button6.Name = "button6";
            button6.Size = new Size(134, 32);
            button6.TabIndex = 12;
            button6.Text = "MapPortal.xml";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(20, 180);
            button5.Name = "button5";
            button5.Size = new Size(134, 32);
            button5.TabIndex = 11;
            button5.Text = "NPC.xml";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(440, 143);
            button4.Name = "button4";
            button4.Size = new Size(134, 32);
            button4.TabIndex = 10;
            button4.Text = "MapList.xml";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(300, 143);
            button3.Name = "button3";
            button3.Size = new Size(134, 32);
            button3.TabIndex = 9;
            button3.Text = "DigimonEvo.xml";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(160, 143);
            button2.Name = "button2";
            button2.Size = new Size(134, 32);
            button2.TabIndex = 8;
            button2.Text = "DigimonList.xml";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(20, 143);
            button1.Name = "button1";
            button1.Size = new Size(134, 32);
            button1.TabIndex = 7;
            button1.Text = "ItemMake.xml";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Impact", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(248, 7);
            label2.Name = "label2";
            label2.Size = new Size(271, 43);
            label2.TabIndex = 6;
            label2.Text = "XML TO DATABASE";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(20, 336);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(694, 23);
            progressBar1.TabIndex = 5;
            progressBar1.Visible = false;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(580, 88);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(134, 32);
            btnConnect.TabIndex = 4;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 402);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DB Importer v16";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtConnectionString;
        private Label label1;
        private Panel panel1;
        private ProgressBar progressBar1;
        private Button btnConnect;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button4;
        private Button button3;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button13;
        private Button button12;
        private Button button11;
        private Button button14;
        private Button button15;
        private Label label3;
        private Button button16;
        private Button button17;
    }
}
