using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        void clear()
        {
            fname.Clear();
            lname.Clear();
            whno.Clear();
            cno.Clear();
            address.Clear();
            whname.Clear();
        }

       public static ListView listview = new ListView();

        private void save_Click(object sender, EventArgs e)
        {
            ListViewItem listViewItem = new ListViewItem(fname.Text + " "+ lname.Text);
           
            string gender = "";
            if (male.Checked)
            
                gender = "Male";

            
            else
            
                gender = "Female";
                

            listViewItem.SubItems.Add(cno.Text.ToString());
            listViewItem.SubItems.Add(gender);
            
            listViewItem.SubItems.Add(address.Text);
            listViewItem.SubItems.Add(whno.Text.ToString());
            listViewItem.SubItems.Add(whname.Text);
            listview.Items.Add(listViewItem);
            clear();
            MessageBox.Show("Data saved");
        }

        private void show_Click(object sender, EventArgs e)
        {
            record record = new record();
            record.ShowDialog();
        }

        private void find_Click(object sender, EventArgs e)
        {

            foreach (ListViewItem item in listview.Items)
            {
                String[] str = item.SubItems[0].Text.Split(' ');
                Console.WriteLine(str[0] + " " + str[1]);
                string contactnum = item.SubItems[1].Text.ToString();
                if (cno.Text == contactnum)
                {
                    fname.Text = str[0];
                    lname.Text = str[1];
                    address.Text = item.SubItems[3].Text;
                    whno.Text = item.SubItems[4].Text;
                    whname.Text = item.SubItems[5].Text;
                    MessageBox.Show("Data searched");

                }
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (male.Checked)

                gender = "Male";


            else

                gender = "Female";

            foreach (ListViewItem item in listview.Items)
            {
                String[] str = item.SubItems[0].Text.Split(' ');
                Console.WriteLine(str[0] + " " + str[1]);
                string contactnum = item.SubItems[1].Text.ToString();
                if (cno.Text == contactnum)
                {
                    
                    item.SubItems[0].Text = fname.Text + " " + lname.Text;
                    
                    item.SubItems[2].Text=gender;
                    item.SubItems[3].Text = address.Text;
                    item.SubItems[4].Text=whno.Text.ToString();
                    item.SubItems[5].Text = whname.Text;
                    MessageBox.Show("Data Updated");
                    clear();
                }
            }
        }

        private void adddatabase_Click(object sender, EventArgs e)
        {
            string fn = fname.Text;
            string ln = lname.Text;
            string gender = "";
            if (male.Checked)
            
                gender = "male";
            
            else
            
                gender = "female";
            
            string gnd = gender;
            string cnt = cno.Text;
            string add = address.Text;
            string whsc = whno.Text;
            string whsn = whname.Text;
            string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\workers.mdf;Integrated Security=True";
            SqlConnection sqlc = new SqlConnection(connection);
            string query = "INSERT INTO workers(FirstName,LastName,Gender,Contact,Address,WarehouseNo,WarehouseName) VALUES('" + fn + "', '" + ln + "','" + gnd + "','" + cnt + "','" + add + "','" + whsc + "','" + whsn + "')";
            SqlCommand sqlCommand = new SqlCommand(query, sqlc);
            sqlc.Open();
            int comm = sqlCommand.ExecuteNonQuery();
            if (comm > 0)
            {
                MessageBox.Show("Data Inserted Successfully");

            }
            else if (comm == 0)
            {
                MessageBox.Show("Failure! Data not inserted");
            }
        }
    }
}
