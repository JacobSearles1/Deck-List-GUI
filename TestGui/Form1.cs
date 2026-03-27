using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGui
{
    public partial class Form1 : Form
    {
        int cardAmt = 0;
        int[] deckSizes = new int[3] { 100, 60, 51 };
       
        public Form1()
        {
            InitializeComponent();
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            if (deckSelect.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a deck type");
                return;
            }
            if (commanderButton.Checked)
            {
                deckList.Items.Insert(0, "Leader - " + cardInput.Text);
                commanderButton.Checked = false;
                commanderButton.Enabled = false;
                cardAmt++;
                cardInput.Text = null;
            }
            else
            {
                deckList.Items.Add((int)cardQty.Value + "x " + cardInput.Text);
                cardInput.Text = null;
                cardAmt += (int)cardQty.Value;
                Console.WriteLine((int)cardQty.Value);
            }
            Console.WriteLine(cardAmt);
            deckSelect.Enabled = false;
            cardCountBar.Value = cardAmt;
            cardNumLabel.Text = $"{cardAmt} / {deckSizes[deckSelect.SelectedIndex]}";
        }


        private void deckSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            cardCountBar.Maximum = deckSizes[deckSelect.SelectedIndex];
            cardNumLabel.Text = $"0 / { deckSizes[deckSelect.SelectedIndex]}";
            if(deckSelect.SelectedIndex == 0)
            {
                commanderButton.Enabled = true;
                commanderButton.Text = "Commander?";
            } else if (deckSelect.SelectedIndex == 1)
            {
                commanderButton.Enabled = false;
            } else
            {
                commanderButton.Enabled = true;
                commanderButton.Text = "Leader?";
            }
        }


        private void clearButton_Click(object sender, EventArgs e)
        {
            deckSelect.Enabled = true;
            commanderButton.Enabled = true;
            deckList.Items.Clear();
            cardAmt = 0;
            if (deckSelect.SelectedIndex == -1)
            {
                return;
            }
            cardInput.Text = null;
            deckName.Text = null;
            cardNumLabel.Text = $"0 / {deckSizes[deckSelect.SelectedIndex]}";
            cardCountBar.Value = 0;
        }


        private void exportButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt";
            saveFileDialog1.Title = "Save a text file";
            saveFileDialog1.InitialDirectory = @"C:\";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;


                using (StreamWriter sw = new StreamWriter(filePath, true))
                {
                    sw.WriteLine(deckName.Text);
                    foreach (string item in deckList.Items)
                    {
                        sw.WriteLine(item);
                    }
                    MessageBox.Show("Export Successful!");
                }
            }
        }


        private void removeButton_Click(object sender, EventArgs e)
        {
            if (deckList.SelectedIndex == -1) 
            {
                return;
            }
            if (deckList.SelectedItem.ToString().Split(' ')[0] == "Leader")
            {
                commanderButton.Enabled = true;
                cardAmt -= 1;
            }
            else
            {
                cardAmt -= Int32.Parse(deckList.SelectedItem.ToString().Split('x')[0]);
            }
            cardNumLabel.Text = $"{cardAmt} / {deckSizes[deckSelect.SelectedIndex]}";
            cardCountBar.Value = cardAmt;
            deckList.Items.Remove(deckList.SelectedItem);

            if (cardAmt == 0) 
            {
                deckSelect.Enabled = true;
            }
        }


        private void importButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog importFile = new OpenFileDialog();
            importFile.Filter = "Text files (*.txt)|*.txt";
            importFile.Title = "Open text file";
            importFile.InitialDirectory = @"C:\";

            if (importFile.ShowDialog() == DialogResult.OK)
            {
                string filePath = importFile.FileName;

                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    if ((line = sr.ReadLine()) != null)
                    { 
                        deckName.Text = line;

                        while ((line = sr.ReadLine()) != null)
                        {
                            if (line.Contains("Leader"))
                            {
                                deckSelect.SelectedIndex = 2;
                                Console.WriteLine("Leader Detected");
                                commanderButton.Enabled = false;
                                cardAmt++;
                            }
                            else if (line.Contains("Commander"))
                            {
                                deckSelect.SelectedIndex = 0;
                                Console.WriteLine("Commander Spotted");
                                commanderButton.Enabled = false;
                                cardAmt++;
                            } else 
                            {
                                cardAmt += Int32.Parse(line.ToString().Split('x')[0]);
                            }

                            deckList.Items.Add(line);
                            
                        }
                        cardNumLabel.Text = $"{cardAmt} / {deckSizes[deckSelect.SelectedIndex]}";
                        cardCountBar.Value = cardAmt;
                    }
                }
            }
        }
    }
}
