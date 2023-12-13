using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Clear all
            richTextBox1.Clear();
            richTextBox1.SelectionBullet = true;

            // Set indentation in pixels for list items
            richTextBox1.BulletIndent = 50;
            richTextBox1.SelectionFont = new Font("Arial", 18);

            // Display text that is not affected by the set
            // indentation (SelectionBullet = false)
            richTextBox1.SelectedText = "Below is a list \n";
            richTextBox1.SelectionFont = new Font("Arial", 12);

            // Next is a list
            richTextBox1.SelectionBullet = true;
            richTextBox1.SelectionColor = Color.Red;
            richTextBox1.SelectedText = "Apple" + "\n";
            richTextBox1.SelectionFont = new Font("Arial", 12);
            richTextBox1.SelectionColor = Color.Orange;
            richTextBox1.SelectedText = "Orange" + "\n";
            richTextBox1.SelectionFont = new Font("Arial", 12);
            richTextBox1.SelectionColor = Color.Purple;
            richTextBox1.SelectedText = "Grapes" + "\n";
            richTextBox1.SelectionBullet = false;
            richTextBox1.SelectionFont = new Font("Verdana", 10);
            richTextBox1.SelectedText = "The list is over \n";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "My site http: \\ moi.ru";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            string sText1, sText2, sText3, sText4, sText5;
            for (int i = 1; i <= 5; i++)
            {
                richTextBox1.Text += "String" + (Convert.ToInt32(i)).ToString() +
                 System.Environment.NewLine;
            }

            // Copies of the entered lines
            sText1 = "String" + (Convert.ToInt32(1)).ToString();
            sText2 = "String" + (Convert.ToInt32(2)).ToString();
            sText3 = "String" + (Convert.ToInt32(3)).ToString();
            sText4 = "String" + (Convert.ToInt32(4)).ToString();
            sText5 = "String" + (Convert.ToInt32(5)).ToString();
            richTextBox1.Select(richTextBox1.Find(sText1), sText1.Length);
            richTextBox1.SelectionFont = new Font("Arial",
                    10, System.Drawing.FontStyle.Regular);
            richTextBox1.SelectionColor = Color.Red;
            richTextBox1.Select(richTextBox1.Find(sText2), sText2.Length);
            richTextBox1.SelectionFont = new Font("Arial",
                    12, System.Drawing.FontStyle.Underline);
            richTextBox1.SelectionColor = Color.Blue;
            richTextBox1.Select(richTextBox1.Find(sText3), sText3.Length);
            richTextBox1.SelectionFont = new Font("Arial",
                    14, System.Drawing.FontStyle.Bold);
            richTextBox1.SelectionColor = Color.Aqua;
            richTextBox1.Select(richTextBox1.Find(sText4), sText4.Length);
            richTextBox1.SelectionFont = new Font("Arial",
                     16, System.Drawing.FontStyle.Bold |
                              System.Drawing.FontStyle.Italic);
            richTextBox1.SelectionColor = Color.Cyan;
            richTextBox1.Select(richTextBox1.Find(sText5), sText5.Length);
            richTextBox1.SelectionFont = new Font("Arial", 18,
               System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic
                | System.Drawing.FontStyle.Strikeout);
            richTextBox1.SelectionColor = Color.Brown;

            // Remove the selection
            richTextBox1.SelectionStart = 0;
            richTextBox1.SelectionLength = 0;

            FontStyle fs;
            //again the line
            richTextBox1.Select(richTextBox1.Find(sText5), sText5.Length);
            // Remember the font style
            fs = richTextBox1.SelectionFont.Style;
            // Remove strikethrough
            fs = fs &~ System.Drawing.FontStyle.Strikeout;
            richTextBox1.SelectionFont = new Font("Arial", 18, fs);
            richTextBox1.SelectionStart = 0;
            richTextBox1.SelectionLength = 0;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.SaveFile("a.rtf", RichTextBoxStreamType.RichText);
            // save the file a.rtf in the Debug folder of our project
            richTextBox1.Clear(); // clear 
            // and again load 
            richTextBox1.LoadFile("a.rtf", RichTextBoxStreamType.RichText);

        }
    }
}
