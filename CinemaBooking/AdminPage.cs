using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic;

namespace CinemaBooking
{
    public partial class AdminPage : Form
    {   public static string connectionString = userInfo.connectionString();
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        public AdminPage()
        {
            InitializeComponent();
            dataGridView1.Hide();
            dataGridView2.Hide();
        }

        private void userDataBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userDataBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);
            
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet1.SeatTable' table. You can move, or remove it, as needed.
            this.seatTableTableAdapter.Fill(this.databaseDataSet1.SeatTable);
            // TODO: This line of code loads data into the 'databaseDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.databaseDataSet.Table);
            // TODO: This line of code loads data into the 'databaseDataSet.UserData' table. You can move, or remove it, as needed.
            this.userDataTableAdapter.Fill(this.databaseDataSet.UserData);
            gridbind();
            gridbind2();
        }
        private void gridbind()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            sda = new SqlDataAdapter("SELECT * FROM UserData", conn);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void gridbind2()
        {
            SqlConnection conn2 = new SqlConnection(connectionString);
            SqlDataAdapter sda2 = new SqlDataAdapter("SELECT * FROM SeatTable", conn2);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            dataGridView2.DataSource = dt2;
        }

        private void usersAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Show();
            dataGridView1.BringToFront();
        }

        private void seatManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView2.Show();
            dataGridView2.BringToFront();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Show();
            panel1.BringToFront();
        }
        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Confirm Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                this.Hide();
                LoginPage login = new LoginPage();
                login.Show();
            }
        }

        private void clearAllSeatsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int seat = 1;
            string owner = "";
            DialogResult confirm = MessageBox.Show("Clear all seats and their owner?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                SqlConnection conn3 = new SqlConnection(connectionString);
                conn3.Open();
                SqlCommand cmd3 = conn3.CreateCommand();
                for (int i = 1; i < 22; i++)
                {
                    cmd3.CommandText = "update SeatTable set Available = '" + seat + "', Owner = '" + owner + "' where Id='" + i + "'";
                    cmd3.ExecuteNonQuery();
                }
                conn3.Close();
                gridbind2();
            }
            else
            {

            }
        }
       

        private void deleteUserAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message, title, defaultValue, myValue;
            message = "Input user Id to delete";
            title = "Delete Account";
            defaultValue = "0";
            myValue = Interaction.InputBox(message, title, defaultValue);
            try
            {
                SqlConnection conn4 = new SqlConnection(connectionString);
                conn4.Open();
                SqlCommand cmd4 = conn4.CreateCommand();
                cmd4.CommandText = "DELETE from UserData where Id = '" + Convert.ToInt32(myValue) + "'";
                cmd4.ExecuteNonQuery();
                conn4.Close();
                gridbind();
            }
            catch(Exception ex)
            {
                myValue = "0";
            }
            
        }
    }
}
