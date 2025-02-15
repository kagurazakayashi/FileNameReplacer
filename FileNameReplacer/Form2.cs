using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FileNameReplacer
{
    public partial class Form2: Form
    {
        public string Value = "";

        public void updateValue()
        {
            List<string> list = new List<string>();
            foreach (string v in listBox1.Items)
            {
                list.Add(v);
            }
            Value = string.Join(";", list);
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void loadData(string val)
        {
            Value = val;
            foreach (string v in val.Split(';'))
            {
                if (v.Length > 0)
                {
                    listBox1.Items.Add(v);
                }
            }
            updateValue();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Text = "";
                updateValue();
            }
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<object> itemsToRemove = new List<object>();
            foreach (var item in listBox1.SelectedItems)
            {
                itemsToRemove.Add(item);
            }
            foreach (var item in itemsToRemove)
            {
                listBox1.Items.Remove(item);
            }
            updateValue();
            textBox1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            updateValue();
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            updateValue();
            textBox1.Focus();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Enabled = listBox1.SelectedItems.Count > 0;
        }
    }
}
