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
            Properties.Settings.Default.Reload();
            InitializeComponent();
            System.Collections.Specialized.StringCollection items = Properties.Settings.Default.test;
            foreach(string item in items)
            {
                listBox1.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(test.Text);
            for(int i = 0; i < listBox1.Items.Count; i++) {
                //Properties.Settings.Default.test.Add(listBox1.Items[i].ToString());
            }
        }

        private void collection_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void bremove_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(0);
        }
    }
}
