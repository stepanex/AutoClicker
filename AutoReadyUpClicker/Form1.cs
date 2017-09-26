using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace AutoReadyUpClicker
{
    public partial class Form1 : Form
    {
        Color Color1, Color2;
        int colorFromX, colorFromY, clickX, clickY;
        uint clickux, clickuy;
        int intColor, intClickX, intClickY;
        string ChosenPreset;
        List<Save> saveList = new List<Save>();
        string FilePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).ToString();
        int version = 100;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory(FilePath + @"\AutoClicker");
            restore();
        }

        public class Save
        {
            public string Name { get; set; }
            public int ColorARGB { get; set; }
            public int ColorX { get; set; }
            public int ColorY { get; set; }
            public int ClickX { get; set; }
            public int ClickY { get; set; }
        }

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetDesktopWindow();
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetWindowDC(IntPtr window);
        [DllImport("gdi32.dll", SetLastError = true)]
        public static extern uint GetPixel(IntPtr dc, int x, int y);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern int ReleaseDC(IntPtr window, IntPtr dc);
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        //Mouse actions
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;

        public static Color GetColorAt(int x, int y)
        {
            IntPtr desk = GetDesktopWindow();
            IntPtr dc = GetWindowDC(desk);
            int a = (int)GetPixel(dc, x, y);
            ReleaseDC(desk, dc);
            return Color.FromArgb(255, (a >> 0) & 0xff, (a >> 8) & 0xff, (a >> 16) & 0xff);
        }

        private void checkForMostRecentVersion()
        {
            try
            {
                WebClient VersionSite = new WebClient();
                int MostRecentVersion = int.Parse(VersionSite.DownloadString(@"https://github.com/stepanex/AutoClicker/master/version.txt"));
                if (MostRecentVersion > version)
                {
                    if (MessageBox.Show("There is new version in github: https://github.com/stepanex/AutoClicker/releases. Do you want to visit the site and download most recent version?", "Visit", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start("https://github.com/stepanex/AutoClicker/releases");
                    }
                }
            }
            catch (Exception) { }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (buttonStart.Text == "Start")
            {
                if (Color1.ToArgb() != 0)
                {
                    timer2.Interval = int.Parse(textBoxTime.Text) * 100;
                    timer2.Enabled = true;
                    timer1.Enabled = true;
                    timer2.Start();
                    timer1.Start();
                    buttonStart.Text = "Stop";
                }
                else MessageBox.Show("First you need to choose/create preset");
            }
            else
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer1.Stop();
                timer2.Stop();
                buttonStart.Text = "Start";
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer1.Stop();
            buttonStart.Text = "Start";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ready();
        }
        private void timerXY_Tick(object sender, EventArgs e)
        {
            labelXY.Text = "X:" + Cursor.Position.X.ToString() + " Y:" + Cursor.Position.Y.ToString();
        }

        private void ready()
        {
            clickux = Convert.ToUInt32(clickX);
            clickuy = Convert.ToUInt32(clickY);
            Color2 = GetColorAt(colorFromX, colorFromY);
            if (Color2 != Color1)
            {
                Cursor.Position = new Point(clickX, clickY);
                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, clickux, clickuy, 0, 0);
                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 469, 242, 0, 0);
                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 469, 242, 0, 0);
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer1.Stop();
                timer2.Stop();
                buttonStart.Text = "Start";
            }
        }

        private void buttonColorSet_Click(object sender, EventArgs e)
        {
            try
            {
                intColor = GetColorAt(Convert.ToInt32(textBoxColorX.Text), Convert.ToInt32(textBoxColorY.Text)).ToArgb();
                pictureBoxColorDetected.BackColor = Color.FromArgb(intColor);
                textBoxColorX.Enabled = false;
                textBoxColorY.Enabled = false;
                buttonColorSet.Enabled = false;
                buttonColorReset.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("You need to enter a number");
                textBoxColorX.Text = null;
                textBoxColorY.Text = null;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            backup();
        }

        private void buttonColorReset_Click(object sender, EventArgs e)
        {
            intColor = 0;
            pictureBoxColorDetected.BackColor = Color.Transparent;
            textBoxColorX.Text = null;
            textBoxColorY.Text = null;
            textBoxColorX.Enabled = true;
            textBoxColorY.Enabled = true;
            buttonColorSet.Enabled = true;
            buttonColorReset.Enabled = false;
        }


        private void buttonClickSet_Click(object sender, EventArgs e)
        {
            try
            {
                intClickX = Convert.ToInt32(textBoxClickX.Text);
                intClickY = Convert.ToInt32(textBoxClickY.Text);
                textBoxClickX.Enabled = false;
                textBoxClickY.Enabled = false;
                buttonClickSet.Enabled = false;
                buttonClickReset.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("You need to enter a number");
                textBoxClickX.Text = null;
                textBoxClickY.Text = null;
            }
        }


        private void buttonClickReset_Click(object sender, EventArgs e)
        {
            intClickX = 0;
            intClickY = 0;
            textBoxClickX.Text = null;
            textBoxClickY.Text = null;
            textBoxClickX.Enabled = true;
            textBoxClickY.Enabled = true;
            buttonClickSet.Enabled = true;
            buttonClickReset.Enabled = false;
        }
        private void buttonCreatePreset_Click(object sender, EventArgs e)
        {
            if (buttonColorSet.Enabled == false)
            {
                if (buttonClickSet.Enabled == false)
                {
                    if (textBoxPresetName.Text != null && textBoxPresetName.Text != "" && textBoxPresetName.Text != " ")
                    {
                        Save btnSave = new Save()
                        {
                            Name = textBoxPresetName.Text,
                            ColorARGB = intColor,
                            ColorX = Convert.ToInt32(textBoxColorX.Text),
                            ColorY = Convert.ToInt32(textBoxColorY.Text),
                            ClickX = intClickX,
                            ClickY = intClickY
                        };
                        saveList.Add(btnSave);

                        Button newButton = new Button();
                        newButton.Text = textBoxPresetName.Text;
                        newButton.Size = new Size(75, 23);
                        newButton.Tag = JsonConvert.SerializeObject(btnSave);
                        newButton.Click += ButtonPresetClick_Click;
                        newButton.Dock = DockStyle.Top | DockStyle.Left;
                        Label lblColor = new Label();
                        lblColor.Text = "Color";
                        lblColor.BackColor = Color.FromArgb(intColor);
                        lblColor.Dock = DockStyle.Top | DockStyle.Right;
                        Label lblClick = new Label();
                        lblClick.Text = "Clicks on X:" + intClickX.ToString() + " Y:" + intClickY.ToString();
                        lblClick.Dock = DockStyle.Bottom;
                        Panel newPanel = new Panel();
                        newPanel.BorderStyle = BorderStyle.FixedSingle;
                        newPanel.Size = new Size(142, 54);
                        newPanel.Controls.Add(newButton);
                        newPanel.Controls.Add(lblClick);
                        newPanel.Controls.Add(lblColor);
                        flowLayoutPanel1.Controls.Add(newPanel);
                        comboBoxPresets.Items.Add(textBoxPresetName.Text);


                        intClickX = 0;
                        intClickY = 0;
                        intColor = 0;
                        buttonClickReset.PerformClick();
                        buttonColorReset.PerformClick();
                        textBoxPresetName.Text = null;
                    }
                    else
                    {
                        MessageBox.Show("You need to set a preset name");
                    }
                }
                else
                {
                    MessageBox.Show("You need to set a place to click on");
                }
            }
            else
            {
                MessageBox.Show("You need to set a color");
            }
        }

        private void ButtonPresetClick_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Save btn = JsonConvert.DeserializeObject<Save>(clickedButton.Tag.ToString());
            colorFromX = btn.ColorX;
            colorFromY = btn.ColorY;
            clickX = btn.ClickX;
            clickY = btn.ClickY;
            Color1 = Color.FromArgb(btn.ColorARGB);
            labelChosenPreset.Text = "Chosen preset: " + btn.Name;
            ChosenPreset = btn.Name;
        }

        public void backup()
        {
            using (StreamWriter file = File.CreateText(FilePath + @"\AutoClicker\backup.txt"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, saveList);
            }
        }
        public void restore()
        {
            string strg = System.IO.File.ReadAllText(FilePath + @"\AutoClicker\backup.txt");
            List<Save> list = JsonConvert.DeserializeObject<List<Save>>(strg);
            while (list.Count > 0)
            {
                Save btnSave = new Save()
                {
                    Name = list.First().Name,
                    ColorARGB = list.First().ColorARGB,
                    ColorX = list.First().ColorX,
                    ColorY = list.First().ColorY,
                    ClickX = list.First().ClickX,
                    ClickY = list.First().ClickY
                };
                saveList.Add(btnSave);

                Button newButton = new Button();
                newButton.Text = list.First().Name;
                newButton.Size = new Size(75, 23);
                newButton.Tag = JsonConvert.SerializeObject(btnSave);
                newButton.Click += ButtonPresetClick_Click;
                newButton.Dock = DockStyle.Top | DockStyle.Left;
                Label lblColor = new Label();
                lblColor.Text = "Color";
                lblColor.BackColor = Color.FromArgb(list.First().ColorARGB);
                lblColor.Dock = DockStyle.Top | DockStyle.Right;
                Label lblClick = new Label();
                lblClick.Text = "Clicks on X:" + list.First().ClickX.ToString() + " Y:" + list.First().ClickY.ToString();
                lblClick.Dock = DockStyle.Bottom;
                Panel newPanel = new Panel();
                newPanel.BorderStyle = BorderStyle.FixedSingle;
                newPanel.Size = new Size(142, 54);
                newPanel.Controls.Add(newButton);
                newPanel.Controls.Add(lblClick);
                newPanel.Controls.Add(lblColor);
                flowLayoutPanel1.Controls.Add(newPanel);
                comboBoxPresets.Items.Add(list.First().Name);
                list.RemoveAt(0);
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (comboBoxPresets.Text != "")
            {
                var result = MessageBox.Show("Do you really want to remove preset " + comboBoxPresets.Text + " ?", "",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Control foundControl = null;
                    foreach (Control c in flowLayoutPanel1.Controls)
                    {
                        c.Name = comboBoxPresets.Text;
                        foundControl = c;
                    }
                    flowLayoutPanel1.Controls.Remove(foundControl);
                    Save foundSave = null;
                    foreach (Save svf in saveList)
                    {
                        svf.Name = comboBoxPresets.Text;
                        foundSave = svf;
                    }
                    saveList.Remove(foundSave);
                    if (ChosenPreset == comboBoxPresets.Text)
                    {
                        labelChosenPreset.Text = "Chosen preset: None";
                        colorFromX = 0;
                        colorFromY = 0;
                        clickX = 0;
                        clickY = 0;
                        Color1 = Color.FromArgb(0);
                    }
                    comboBoxPresets.Items.Remove(comboBoxPresets.Text);
                }
                else comboBoxPresets.Text = "";
            }
            else MessageBox.Show("You need to choose a preset to remove");
        }

        private void buttonRemoveAll_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you really want to remove all the presets ?", "",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                flowLayoutPanel1.Controls.Clear();
                comboBoxPresets.Items.Clear();
                saveList.Clear();
                labelChosenPreset.Text = "Chosen preset: None";
                colorFromX = 0;
                colorFromY = 0;
                clickX = 0;
                clickY = 0;
                Color1 = Color.FromArgb(0);
            }
        }
    }
}