using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FileNameReplacer
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        public Help(string Title, string Texts)
        {
            InitializeComponent();
            Text += Title;
            label1.Text = Texts;
        }

        private void Help_Load(object sender, EventArgs e)
        {
            DarkMode.AutoDarkMode(this);
            //label1.Select(0, 0);
        }

        private void Help_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
