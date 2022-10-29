using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
{
    public partial class record : Form
    {
        public record()
        {
            InitializeComponent();
        }

        

        private void showall_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in Form1.listview.Items)
                listView1.Items.Add((ListViewItem)item.Clone());
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach(ListViewItem item in Form1.listview.Items)
            {
                String[] str = item.SubItems[0].Text.Split(' ');

                if(str.Length >= 2)
                {
                    if(str[1].ToUpper() == lname2.Text.ToUpper())
                    {
                        listView1.Items.Add((ListViewItem)item.Clone());
                    }
                }
            }
        }
    }
}
