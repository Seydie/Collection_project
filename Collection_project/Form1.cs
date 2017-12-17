using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Collection_project
{
    public partial class collection_form : Form
    {
        public collection_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();
            Properties.Settings.Default.test = test.Text;
            label.Text = Properties.Settings.Default.test;
        }

        private void collection_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Upgrade();
            Properties.Settings.Default.Save();
        }
    }
}
