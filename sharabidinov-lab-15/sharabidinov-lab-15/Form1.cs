using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) textBox1.BackColor = Color.Red; else textBox1.BackColor = Color.Blue;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) label1.BackColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Clear all
            richTextBox1.Clear();
            richTextBox1.SelectionBullet = true;
            // Set padding in pixels for list items
            richTextBox1.SelectionFont = new Font("Arial", 12);
            // Next is a list
            richTextBox1.SelectionBullet = true;
            richTextBox1.SelectionColor = Color.Red;
            richTextBox1.SelectedText = "Яблоко" + "\n";
            richTextBox1.SelectionFont = new Font("Arial", 12);
            richTextBox1.SelectionColor = Color.Orange;
            richTextBox1.SelectedText = "Апельсин" + "\n";
            richTextBox1.SelectionFont = new Font("Arial", 12);
            richTextBox1.SelectionColor = Color.Purple;
            richTextBox1.SelectedText = "Виноград" + "\n";
            richTextBox1.SelectionBullet = false;
            richTextBox1.SelectionFont = new Font("Verdana", 10);
            richTextBox1.SelectedText = "Список закончился\n";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked) label1.BackColor = Color.Blue;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked) label1.BackColor = Color.Green;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) textBox1.Text = "Привет"; else textBox1.Text = "Пока";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 1; i < 21; i++)
            {
                listBox1.Items.Add("Строка " + i.ToString());
            }
            listBox1.SelectionMode = SelectionMode.One;
            listBox1.SetSelected(0, true);
            listBox1.SetSelected(1, true);
            listBox1.SetSelected(2, true);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Sorted = true;
            listBox1.Items.Clear();
            for (int i = 10; i > 0; i--)
            {
                listBox1.Items.Add(i.ToString());

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new object[] {"Отлично", "Хорошо", "Удовлетворительно","Неудовлетворительно"});
        }

        private void button6_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Remove(comboBox1.SelectedItem);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
