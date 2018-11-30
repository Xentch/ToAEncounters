using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ToARandomEncounters
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            Dictionary<TextBox, WebBrowser> list = new Dictionary<TextBox, WebBrowser>();
            list.Add(textBox1, encounter1Browser);
            list.Add(textBox2, encounter2Browser);
            list.Add(textBox3, encounter3Browser);

            foreach (var encounterBrowser in list)
            {
                int d20 = rand.Next(1, 20);
                encounterBrowser.Key.Text = "Roll = " + d20;
                if (d20 < 16)
                {
                    encounterBrowser.Value.DocumentText = "No Encounter";
                }
                if (d20 >= 16)
                {
                    int percentile = rand.Next(1, 100);
                    encounterBrowser.Key.Text += " Percentile = " + percentile;
                    //var fileStream = new FileStream(@"D:\bdohm\Documents\ToA\encounters.csv", FileMode.Open, FileAccess.Read);
                    var fileStream = new FileStream(@"encounters.csv", FileMode.Open, FileAccess.Read);
                    using (var streamReader = new StreamReader(fileStream))
                    {
                        // Read first line and find the int for the column
                        // we are looking for
                        string line = streamReader.ReadLine();
                        var areaNames = line.Split(new char[] { ';' });
                        int splitTarget = -1;
                        for(int i = 0; i < areaNames.Length; i++)
                        {
                            if (areaNames[i] == comboBox1.Text)
                            {
                                splitTarget = i;
                                break;
                            }
                        }

                        while (!streamReader.EndOfStream)
                        {
                            line = streamReader.ReadLine();
                            var encounterLine = line.Split(new char[] { ';' });

                            // get the important info from the line
                            string encounterName = encounterLine[0];
                            string targetPercentile = encounterLine[splitTarget];
                            var targetPercentileSplit = targetPercentile.Split(new char[] { '-' });
                            if (targetPercentileSplit.Length < 2)
                            {
                                // this means the char is either — or a single digit target
                                int result;
                                if (int.TryParse(targetPercentileSplit[0], out result))
                                {
                                    if (result == 0)
                                    {
                                        // dnd uses 00 to denote 100
                                        result = 100;
                                    }
                                    if (percentile == result)
                                    {
                                        // bingo, this is our encounter
                                        encounterBrowser.Key.Text += " Encounter = " + encounterName;

                                        // Now we try and deduce the url for the encounter
                                        Regex rgx = new Regex("[^a-zA-Z]");
                                        encounterName = rgx.Replace(encounterName, "");

                                        string uri;
                                        if (-1 != encounterName.IndexOf("Dinosaurs"))
                                        {
                                            // all dinos are under a single section
                                            uri = @"https://www.dndbeyond.com/compendium/adventures/toa/random-encounters#" + "Dinosaurs";
                                        }
                                        else if (-1 != encounterName.IndexOf("Undead"))
                                        {
                                            // all undead are under a single section
                                            uri = @"https://www.dndbeyond.com/compendium/adventures/toa/random-encounters#" + "Undead";
                                        }
                                        else
                                        {
                                            uri = @"https://www.dndbeyond.com/compendium/adventures/toa/random-encounters#" + encounterName;
                                        }

                                        encounterBrowser.Key.AppendText(Environment.NewLine);
                                        encounterBrowser.Key.AppendText("uri = " + uri);
                                        encounterBrowser.Value.Navigate(uri);

                                        break;
                                    }
                                }
                            }
                            else if (targetPercentileSplit.Length == 2)
                            {
                                // this means the char is something like 03—07
                                int left, right;
                                if (int.TryParse(targetPercentileSplit[0], out left))
                                {
                                    if (left == 0)
                                    {
                                        // dnd uses 00 to denote 100
                                        left = 100;
                                    }
                                    if (int.TryParse(targetPercentileSplit[1], out right))
                                    {
                                        if (right == 0)
                                        {
                                            // dnd uses 00 to denote 100
                                            right = 100;
                                        }
                                        if (percentile >= left && percentile <= right)
                                        {
                                            // bingo, this is our encounter
                                            encounterBrowser.Key.Text += " Encounter = " + encounterName;

                                            Regex rgx = new Regex("[^a-zA-Z]");
                                            encounterName = rgx.Replace(encounterName, "");

                                            string uri;
                                            if (-1 != encounterName.IndexOf("Dinosaurs"))
                                            {
                                                // all dinos are under a single section
                                                uri = @"https://www.dndbeyond.com/compendium/adventures/toa/random-encounters#" + "Dinosaurs";
                                            }
                                            else if (-1 != encounterName.IndexOf("Undead"))
                                            {
                                                // all undead are under a single section
                                                uri = @"https://www.dndbeyond.com/compendium/adventures/toa/random-encounters#" + "Undead";
                                            }
                                            else
                                            {
                                                uri = @"https://www.dndbeyond.com/compendium/adventures/toa/random-encounters#" + encounterName;
                                            }

                                            encounterBrowser.Key.AppendText(Environment.NewLine);
                                            encounterBrowser.Key.AppendText("uri = " + uri);
                                            encounterBrowser.Value.Navigate(uri);

                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
