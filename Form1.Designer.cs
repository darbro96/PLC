namespace ProgramowanieWSrodowskuWindowsProjekt
{
    partial class Form1
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button18 = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.button17 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button16 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button14 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button15 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.ramka = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.ramka.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Otwórz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.openPort);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(140, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(21, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "R";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.refreshComList);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(453, 41);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "RESET";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.resetButton);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(20, 119);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(324, 47);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            this.richTextBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.selectHex);
            this.richTextBox1.TextChanged += new System.EventHandler(this.hexToAscii);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(13, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(39, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "DL";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(13, 20);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 17);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "PHY";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 9;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(260, 43);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Zamknij";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.closePort);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Do nadania HEX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Odbiór";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Enabled = false;
            this.richTextBox2.Location = new System.Drawing.Point(-2, -2);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(315, 78);
            this.richTextBox2.TabIndex = 11;
            this.richTextBox2.Text = "";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(13, 39);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "Czyść";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.clearTxText);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(13, 239);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 13;
            this.button6.Text = "Czyść";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.clearRxText);
            // 
            // button7
            // 
            this.button7.Enabled = false;
            this.button7.Location = new System.Drawing.Point(13, 62);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 14;
            this.button7.Text = "Wyślij";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.send);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Bytes to read: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Modulacja:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "B-PSK",
            "Q-PSK",
            "8-PSK",
            "B-FSK",
            "B-PSK coded",
            "Q-PSK coded",
            "B-PSK coded with PNA"});
            this.comboBox2.Location = new System.Drawing.Point(75, 104);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(90, 21);
            this.comboBox2.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 75);
            this.panel1.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(12, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Komunikator";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ProgramowanieWSrodowskuWindowsProjekt.Properties.Resources.plugs_512pxGREY;
            this.pictureBox1.Location = new System.Drawing.Point(161, -135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(395, 248);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCyan;
            this.panel2.Controls.Add(this.button18);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Location = new System.Drawing.Point(363, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(193, 347);
            this.panel2.TabIndex = 20;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(13, 172);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(141, 23);
            this.button18.TabIndex = 19;
            this.button18.Text = "Zapisz konfigurację";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.saveConfiguration);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Controls.Add(this.button17);
            this.panel9.Location = new System.Drawing.Point(16, 439);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(112, 112);
            this.panel9.TabIndex = 30;
            this.panel9.Visible = false;
            // 
            // panel10
            // 
            this.panel10.BackgroundImage = global::ProgramowanieWSrodowskuWindowsProjekt.Properties.Resources.cat_grumpy;
            this.panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel10.Location = new System.Drawing.Point(21, 13);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(65, 60);
            this.panel10.TabIndex = 27;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(12, 79);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(90, 23);
            this.button17.TabIndex = 27;
            this.button17.Text = "OK";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.buttonAll_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.button16);
            this.panel7.Location = new System.Drawing.Point(141, 439);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(112, 112);
            this.panel7.TabIndex = 29;
            this.panel7.Visible = false;
            // 
            // panel8
            // 
            this.panel8.BackgroundImage = global::ProgramowanieWSrodowskuWindowsProjekt.Properties.Resources.cat_ghost;
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel8.Location = new System.Drawing.Point(25, 12);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(65, 60);
            this.panel8.TabIndex = 27;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(12, 78);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(90, 22);
            this.button16.TabIndex = 27;
            this.button16.Text = "OK";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.buttonAll_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.button14);
            this.panel3.Location = new System.Drawing.Point(270, 439);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(116, 111);
            this.panel3.TabIndex = 26;
            this.panel3.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::ProgramowanieWSrodowskuWindowsProjekt.Properties.Resources.cat_banjo;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Location = new System.Drawing.Point(26, 13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(65, 60);
            this.panel4.TabIndex = 27;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(14, 80);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(90, 24);
            this.button14.TabIndex = 27;
            this.button14.Text = "OK";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.buttonAll_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.button15);
            this.panel5.Location = new System.Drawing.Point(396, 441);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(121, 109);
            this.panel5.TabIndex = 28;
            this.panel5.Visible = false;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::ProgramowanieWSrodowskuWindowsProjekt.Properties.Resources.cat_food;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel6.Location = new System.Drawing.Point(26, 12);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(65, 60);
            this.panel6.TabIndex = 27;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(15, 78);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(90, 23);
            this.button15.TabIndex = 27;
            this.button15.Text = "OK";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.buttonAll_Click);
            // 
            // button13
            // 
            this.button13.BackgroundImage = global::ProgramowanieWSrodowskuWindowsProjekt.Properties.Resources.speaker;
            this.button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button13.Enabled = false;
            this.button13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.Location = new System.Drawing.Point(280, 247);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(64, 35);
            this.button13.TabIndex = 25;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.buttonIcon3E);
            // 
            // button12
            // 
            this.button12.BackgroundImage = global::ProgramowanieWSrodowskuWindowsProjekt.Properties.Resources.cat_grumpy;
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button12.Enabled = false;
            this.button12.Location = new System.Drawing.Point(140, 243);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(34, 35);
            this.button12.TabIndex = 24;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.buttonIcon3A);
            // 
            // button11
            // 
            this.button11.BackgroundImage = global::ProgramowanieWSrodowskuWindowsProjekt.Properties.Resources.cat_ghost;
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button11.Enabled = false;
            this.button11.Location = new System.Drawing.Point(99, 243);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(34, 35);
            this.button11.TabIndex = 23;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.buttonIcon3B);
            // 
            // button10
            // 
            this.button10.BackgroundImage = global::ProgramowanieWSrodowskuWindowsProjekt.Properties.Resources.cat_food;
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button10.Enabled = false;
            this.button10.Location = new System.Drawing.Point(60, 243);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(34, 35);
            this.button10.TabIndex = 22;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.buttonIcon3C);
            // 
            // button9
            // 
            this.button9.BackgroundImage = global::ProgramowanieWSrodowskuWindowsProjekt.Properties.Resources.cat_banjo;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button9.Enabled = false;
            this.button9.Location = new System.Drawing.Point(20, 243);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(34, 35);
            this.button9.TabIndex = 21;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.buttonIcon3D);
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(20, 188);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(324, 49);
            this.richTextBox3.TabIndex = 31;
            this.richTextBox3.Text = "";
            this.richTextBox3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.selectAscii);
            this.richTextBox3.TextChanged += new System.EventHandler(this.asciiToHex);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Do nadania ASCII";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.ramka);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(20, 296);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(324, 100);
            this.tabControl1.TabIndex = 33;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.richTextBox4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(316, 74);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "wiadomość";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // richTextBox4
            // 
            this.richTextBox4.Enabled = false;
            this.richTextBox4.Location = new System.Drawing.Point(-2, -2);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(318, 79);
            this.richTextBox4.TabIndex = 34;
            this.richTextBox4.Text = "";
            // 
            // ramka
            // 
            this.ramka.Controls.Add(this.richTextBox2);
            this.ramka.Location = new System.Drawing.Point(4, 22);
            this.ramka.Name = "ramka";
            this.ramka.Padding = new System.Windows.Forms.Padding(3);
            this.ramka.Size = new System.Drawing.Size(316, 74);
            this.ramka.TabIndex = 1;
            this.ramka.Text = "ramka";
            this.ramka.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.richTextBox5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(316, 74);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "wszystko odebrane";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBox5
            // 
            this.richTextBox5.Enabled = false;
            this.richTextBox5.Location = new System.Drawing.Point(2, 3);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.Size = new System.Drawing.Size(311, 68);
            this.richTextBox5.TabIndex = 0;
            this.richTextBox5.Text = "";
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 50;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 559);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Komunikator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ramka.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.TabPage ramka;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBox5;
    }
}

