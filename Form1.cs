using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace ProgramowanieWSrodowskuWindowsProjekt
{
    public partial class Form1 : Form
    {
        List<string> items = new List<string>();
        string com;
        SerialPort port;
        Queue<byte> queue = new Queue<byte>();

        List<byte> rxFrame = new List<byte>();
        List<byte> message = new List<byte>();

        int state = SQ_ENUM.LFB;

        bool is3B = false;
        bool is60 = false;
        bool analyze = false;
        bool isShow = false;
        byte ikona;
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        bool hexIsActive = false;
        bool asciiIsActive = false;


        public Form1()
        {
            InitializeComponent();
            setComboItems();
            radioButton1.Select();
            comboBox2.SelectedIndex = 0;
            player.SoundLocation = "gadu.wav";
            player.Load();
            loadConfiguration();
            
        }

        private void openPort(object sender, EventArgs e)
        {
            try
            {
                com = (string)comboBox1.SelectedItem;
                if (!com.Equals(""))
                {
                    label1.Text = "Wybrano: " + com;
                    label1.Visible = true;
                    button3.Enabled = true;
                }
                port = new mySerialPort(com, 57600, Parity.None, 8, StopBits.One);
                port.DataReceived += new SerialDataReceivedEventHandler(addToQueue);
                port.Open();
                port.RtsEnable = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button4.Enabled = true;
                button7.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = true;
                button13.Enabled = true;
                comboBox1.Enabled = false;
                timer1.Start();
                timer2.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie wybrano COM z listy");
            }
        }

        private void setComboItems()
        {
            comboBox1.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            foreach (string s in ports)
            {
                comboBox1.Items.Add(s);
            }
        }

        private void refreshComList(object sender, EventArgs e)
        {
            label1.Visible = false;
            button3.Enabled = false;
            setComboItems();
        }

        private void resetButton(object sender, EventArgs e)
        {
            port.RtsEnable = true;
            Thread.Sleep(10);
            List<byte> list = makeFrame(0x3C, new byte[0]);
            byte[] tab = listToByte(list);
            port.Write(tab, 0, tab.Length);
            port.RtsEnable = false;
        }

        private byte[] listToByte(List<byte> list)
        {
            byte[] tab = new byte[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                tab[i] = list[i];
            }
            return tab;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label4.Text = "Bytes to read: " + port.BytesToRead;
            //if (port.BytesToRead > 0)
            //{
            //    int a;
            //    for (int i = 0; i < port.BytesToRead; i++)
            //    {
            //        a = port.ReadByte();
            //        queue.Enqueue((getfryte)a);
            //        richTextBox5.Text = richTextBox5.Text + " " + a.ToString("X");
            //    }
            //}
        }

        private void closePort(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            port.Close();
            button4.Enabled = false;
            button1.Enabled = true;
            label1.Visible = false;
            button7.Enabled = false;
            button3.Enabled = false;
            button2.Enabled = true;
            comboBox1.Enabled = true;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            rxFrame.Clear();
            queue.Clear();
        }

        private void clearTxText(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox3.Text = "";
        }

        private void clearRxText(object sender, EventArgs e)
        {
            richTextBox2.Text = "";
            richTextBox4.Text = "";
            richTextBox5.Text = "";
        }

        private void send(object sender, EventArgs e)
        {
            string s = richTextBox1.Text;
            s = s.Replace(" ", "");
            List<byte> list = new List<byte>();
            byte mod = getModulation();
            list.Add(mod);
            bool ok = true;
            for (int i = 0; i < s.Length; i++)
            {

                string str;
                if (i + 1 != s.Length)
                {
                    str = s[i].ToString() + s[i + 1].ToString();
                }
                else
                {
                    str = s[i].ToString();
                }
                try
                {
                    list.Add(byte.Parse(str, System.Globalization.NumberStyles.HexNumber));
                }
                catch (Exception ex)
                {
                    ok = false;
                    MessageBox.Show(ex.Message + "\nznak: " + s[i].ToString() + "\nindeks: " + i, "Błąd");
                }
                if (i + 1 != s.Length)
                {
                    i++;
                }

            }
            if (ok)
            {
                byte[] tabByte = listToByte(list);
                List<byte> frame = makeFrame(getMode(), tabByte);
                port.RtsEnable = true;
                Thread.Sleep(10);
                port.Write(listToByte(frame), 0, listToByte(frame).Length);
                port.RtsEnable = false;
            }
        }

        private List<byte> makeFrame(byte CC, byte[] data)
        {
            List<byte> list = new List<byte>();
            list.Add(02);
            list.Add((byte)data.Length);
            list.Add(CC);
            for (int i = 0; i < data.Length; i++)
            {
                list.Add(data[i]);
            }
            uint checkSum = 0;
            for (int i = 1; i < list.Count; i++)
            {
                checkSum = checkSum + list[i];
            }
            uint a = checkSum >> 8;
            byte aa = (byte)a;
            uint b = checkSum % 256;
            byte bb = (byte)b;
            list.Add(bb);
            list.Add(aa);

            return list;

        }

        private void getFromQueue()
        {
            while (queue.Count > 0)
            {
                byte b;
                if (state == SQ_ENUM.LFB)
                {
                    b = queue.Dequeue();
                    if ((b == 0x02) || (b == 0x03) || (b == 0x06) || (b == 0x15) || (b == 0x3F))
                    {
                        if (b == 0x02)
                        {
                            
                        }
                        rxFrame.Clear();
                        rxFrame.Add(b);
                        if (rxFrame[0] == 0x06 || rxFrame[0] == 0x15)
                        {
                            frameReceived();
                            break;
                        }
                        else
                        {
                            state = SQ_ENUM.LFL;
                            timer3.Start();
                        }
                    }
                }
                if (state == SQ_ENUM.LFL && queue.Count > 0)
                {
                    b = queue.Dequeue();
                    rxFrame.Add(b);
                    if (rxFrame[0] == 0x3F)
                    {
                        state = SQ_ENUM.LFB;
                        frameReceived();
                        break;
                    }
                    else
                    {
                        state = SQ_ENUM.LFCC;
                        timer3.Start();
                    }
                }
                if (state == SQ_ENUM.LFCC && queue.Count > 0)
                {
                    b = queue.Dequeue();
                    rxFrame.Add(b);
                    if (rxFrame[1] > 0)
                    {
                        state = SQ_ENUM.DC;
                        timer3.Start();
                        analyze = true;
                    }
                    else
                    {
                        state = SQ_ENUM.LFC1B;
                        timer3.Start();
                    }
                }
                if (state == SQ_ENUM.DC)
                {
                    while (queue.Count > 0)
                    {
                        b = queue.Dequeue();
                        timer3.Start();
                        rxFrame.Add(b);
                        message.Add(b);
                        if (analyze)
                        {
                            if (is60)
                            {
                                ikona = b;
                                is60 = false;
                                is3B = false;
                                analyze = false;
                                isShow = true;
                            }
                            if (is3B)
                            {
                                if (b == 0x60)
                                {
                                    is60 = true;
                                }
                                else
                                {
                                    is3B = false;
                                    analyze = false;
                                }
                            }
                            if (b == 0x3B && !is3B)
                            {
                                is3B = true;
                            }
                        }
                        if (rxFrame.Count - 3 == rxFrame[1])
                        {
                            state = SQ_ENUM.LFC1B;
                            timer3.Start();
                            analyze = false;
                            break;
                        }
                    }

                }
                if (state == SQ_ENUM.LFC1B && queue.Count > 0)
                {
                    b = queue.Dequeue();
                    rxFrame.Add(b);
                    state = SQ_ENUM.LFC2B;
                    timer3.Start();
                }
                if (state == SQ_ENUM.LFC2B && queue.Count > 0)
                {
                    b = queue.Dequeue();
                    rxFrame.Add(b);

                    int sum = 0;
                    for (int i = 1; i < rxFrame.Count - 2; i++)
                    {
                        sum = sum + rxFrame[i];
                    }
                    int sum2 = rxFrame[rxFrame.Count - 1] << 8;
                    sum2 = sum2 + rxFrame[rxFrame.Count - 2];

                    if (sum == sum2)
                    {
                        frameReceived();
                        break;
                    }
                    state = SQ_ENUM.LFB;
                    timer3.Stop();
                }
            }
        }

        private void frameReceived()
        {
            state = SQ_ENUM.LFB;
            timer3.Stop();
            if(rxFrame[0]==0x02)
            {
                byte[] tab = new byte[1];
                tab[0] = 0x06;
                port.RtsEnable = false;
                port.Write(tab, 0, 1);
            }
            for (int i = 0; i < rxFrame.Count; i++)
            {
                richTextBox2.Text = richTextBox2.Text + " " + rxFrame[i].ToString("X");
            }
            for (int i = 4; i < message.Count; i++)
            {
                char sign = (char)message[i];
                richTextBox4.Text = richTextBox4.Text + sign.ToString();
            }
            message.Clear();
            if (isShow)
            {
                switch (ikona)
                {
                    case 0x3A:
                        panel9.Visible = true;
                        break;
                    case 0x3B:
                        panel7.Visible = true;
                        break;
                    case 0x3C:
                        panel5.Visible = true;
                        break;
                    case 0x3D:
                        panel3.Visible = true;
                        break;
                    case 0x3E:
                        player.Play();
                        break;
                }
                isShow = false;
                is60 = false;
                is3B = false;
                analyze = false;
            }
        }

        private void buttonIcon3D(object sender, EventArgs e)
        {
            sendIcon(0x3D);
        }

        private void buttonIcon3C(object sender, EventArgs e)
        {
            sendIcon(0x3C);
        }

        private void buttonIcon3B(object sender, EventArgs e)
        {
            sendIcon(0x3B);
        }

        private void buttonIcon3E(object sender, EventArgs e)
        {
            sendIcon(0x3E);
        }

        private void buttonIcon3A(object sender, EventArgs e)
        {
            sendIcon(0x3A);
        }

        private void sendIcon(byte icon)
        {
            byte[] byteTab = new byte[4];

            byteTab[0] = getModulation(); ;
            byteTab[1] = 0x3B;
            byteTab[2] = 0x60;
            byteTab[3] = icon;

            List<byte> localFrame = makeFrame(getMode(), byteTab);
            byte[] tab = listToByte(localFrame);
            port.RtsEnable = true;
            Thread.Sleep(10);
            port.Write(tab, 0, tab.Length);
            port.RtsEnable = false;
        }

        private byte getMode()
        {
            byte cc = 0x50;
            if (radioButton1.Checked)
            {
                cc = 0x50;
            }
            if (radioButton2.Checked)
            {
                cc = 0x24;
            }
            return cc;
        }

        private byte getModulation()
        {
            int mod = comboBox2.SelectedIndex;
            if (comboBox2.SelectedIndex == 6)
                mod = 7;
            mod = mod << 4;
            mod = mod | 4;
            return (byte)mod;
        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel5.Visible = false;
            panel7.Visible = false;
            panel9.Visible = false;
        }

        private void hexToAscii(object sender, EventArgs e)
        {
            if (hexIsActive)
            {
                richTextBox3.Text = "";
                string ascii = "";
                string source = richTextBox1.Text;
                source = source.Replace(" ", "");
                for (int i = 0; i < source.Length; i++)
                {
                    if (i + 1 != source.Length)
                    {
                        ascii = ascii + source[i].ToString() + source[i + 1];
                        i++;
                    }
                    else
                    {
                        ascii = ascii + source[i].ToString();
                    }
                    byte b = byte.Parse(ascii, System.Globalization.NumberStyles.HexNumber);
                    char c = (char)b;
                    richTextBox3.Text = richTextBox3.Text + c.ToString();
                    ascii = "";
                }
            }
        }

        private void asciiToHex(object sender, EventArgs e)
        {
            if (asciiIsActive)
            {
                richTextBox1.Text = "";
                for (int i = 0; i < richTextBox3.Text.Length; i++)
                {
                    byte b = (byte)richTextBox3.Text[i];
                    richTextBox1.Text = richTextBox1.Text + b.ToString("X");
                }
            }
        }

        private void selectHex(object sender, MouseEventArgs e)
        {
            hexIsActive = true;
            asciiIsActive = false;
        }

        private void selectAscii(object sender, MouseEventArgs e)
        {
            asciiIsActive = true;
            hexIsActive = false;
        }

        private void saveConfiguration(object sender, EventArgs e)
        {

            if (File.Exists("conf.txt"))
            {
                File.Delete("conf.txt");
            }
            using (StreamWriter outputFile = new StreamWriter(Path.Combine("conf.txt")))
            {
                if (radioButton1.Checked)
                {
                    outputFile.WriteLine("DL");
                }
                else
                {
                    outputFile.WriteLine("PHY");
                }
                outputFile.WriteLine(comboBox2.SelectedIndex);
            }
            MessageBox.Show("Zapisano konfigurację");
        }

        private void loadConfiguration()
        {
            try
            {
                if (File.Exists("conf.txt"))
                {
                    string[] lines = File.ReadAllLines("conf.txt");
                    comboBox2.SelectedIndex = int.Parse(lines[1]);
                    if (lines[0].Equals("PHY"))
                    {
                        radioButton2.Select();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Błąd podczas ładowania konfiguracji");
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            getFromQueue();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            state = SQ_ENUM.LFB;
            timer3.Stop();
        }

        public void addToQueue(object sender, SerialDataReceivedEventArgs args)
        {
            if (port.BytesToRead > 0)
            {
                int a;
                for (int i = 0; i < port.BytesToRead; i++)
                {
                    a = port.ReadByte();
                    queue.Enqueue((byte)a);
                    richTextBox5.Text = richTextBox5.Text + " " + a.ToString("X");
                }
            }
        }
    }

    
}