using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic;
namespace CinemaBooking
{
    public partial class UserPage : Form
    {
        public static string connectionString = userInfo.connectionString();
        //Database connectors
        SqlConnection conn = new SqlConnection(connectionString);
        
        //Allowing the UserPage to use codes under LoginPage
        LoginPage currentUser = new LoginPage();
        string userName, passWord, TotalBalance = "0";

        //variable declarations
        int page = 1, seat = 1;
        decimal spider = 250;

        //For printer
        PrintPreviewDialog prntprv = new PrintPreviewDialog();
        PrintDocument pntdoc = new PrintDocument();

        public UserPage()
        {
            InitializeComponent();
            //getting the user's info from the login page
            userName = currentUser.ToString();
            passWord = currentUser.checkPassword();
            userLabel.Text = currentUser.ToString();
            welcomeLabel.Text = "Hello " + getFullName() + "!";
            conn.Close();
            //Getting the user's balance
            TotalBalance = getBalance();
            balanceLabel.Text = TotalBalance + "₱";
            
            //Hiding the booking panel
            seatSpider.Hide();
            loadSeats();
        }

        public string getBalance()
        {
            string username, password, balance = "";
            SqlCommand cmd = new SqlCommand("SELECT Username, Password, Balance FROM UserData", conn);
            conn.Open();
            SqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                username = dataReader["Username"].ToString();
                password = dataReader["Password"].ToString();
                balance = dataReader["Balance"].ToString().Trim();
                if (username == currentUser.ToString() && password == currentUser.checkPassword())
                {
                    return balance;
                }
            }
            dataReader.Close();
            return balance;
            conn.Close();
        }

        public string getFullName()
        {
            string username, password, fullname = "";
            SqlCommand cmd = new SqlCommand("SELECT Username, Password, Fullname FROM UserData", conn);
            conn.Open();
            SqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                username = dataReader["Username"].ToString();
                password = dataReader["Password"].ToString();
                fullname = dataReader["Fullname"].ToString().Trim();
                if (username == currentUser.ToString() && password == currentUser.checkPassword())
                {
                    return fullname;
                }

            }
            dataReader.Close();
            return fullname;

        }

        //Method used by the previous and next buttons
        public void pageTransition()
        {
            if (page % 2 == 0)
            {
                drPanel.BringToFront();
            }
            else
            {
                drPanel.SendToBack();
            }
        }
        private void nextButton_Click(object sender, EventArgs e)
        {
            ++page;
            pageTransition();
        }
        private void prevButton_Click(object sender, EventArgs e)
        {
            --page;
            pageTransition();
        }

        //Method disabling the already taken seats
        public void loadSeats()
        {
            if (available(1) == 1) { S1.Enabled = true; S1.BackColor = Color.White; }
            else { S1.Enabled = false; S1.BackColor = Color.LightGray; }
            if (available(2) == 1) { S2.Enabled = true; S2.BackColor = Color.White; }
            else { S2.Enabled = false; S2.BackColor = Color.LightGray; }
            if (available(3) == 1) { S3.Enabled = true; S3.BackColor = Color.White; }
            else { S3.Enabled = false; S3.BackColor = Color.LightGray; }
            if (available(4) == 1) { S4.Enabled = true; S4.BackColor = Color.White; }
            else { S4.Enabled = false; S4.BackColor = Color.LightGray; }
            if (available(5) == 1) { S5.Enabled = true; S5.BackColor = Color.White; }
            else { S5.Enabled = false; S5.BackColor = Color.LightGray; }
            if (available(6) == 1) { S6.Enabled = true; S6.BackColor = Color.White; }
            else { S6.Enabled = false; S6.BackColor = Color.LightGray; }
            if (available(7) == 1) { S7.Enabled = true; S7.BackColor = Color.White; }
            else { S7.Enabled = false; S7.BackColor = Color.LightGray; }
            if (available(8) == 1) { S8.Enabled = true; S8.BackColor = Color.White; }
            else {S8.Enabled = false; S8.BackColor = Color.LightGray; }
            if (available(9) == 1) { S9.Enabled = true; S9.BackColor = Color.White; } 
            else {S9.Enabled = false; S9.BackColor = Color.LightGray; }
            if (available(10) == 1) { S10.Enabled = true; S10.BackColor = Color.White; } 
            else {S10.Enabled = false; S10.BackColor = Color.LightGray; }
            if (available(11) == 1) { S11.Enabled = true; S11.BackColor = Color.White; } 
            else {S11.Enabled = false; S11.BackColor = Color.LightGray; }
            if (available(12) == 1) { S12.Enabled = true; S12.BackColor = Color.White; } 
            else {S12.Enabled = false; S12.BackColor = Color.LightGray; }
            if (available(13) == 1) { S13.Enabled = true; S13.BackColor = Color.White; } 
            else {S13.Enabled = false; S13.BackColor = Color.LightGray; }
            if (available(14) == 1) { S14.Enabled = true; S14.BackColor = Color.White; } 
            else {S14.Enabled = false; S14.BackColor = Color.LightGray; }
            if (available(15) == 1) { S15.Enabled = true; S15.BackColor = Color.White; } 
            else {S15.Enabled = false; S15.BackColor = Color.LightGray; }
            if (available(16) == 1) { S16.Enabled = true; S16.BackColor = Color.White; } 
            else {S16.Enabled = false; S16.BackColor = Color.LightGray; }
            if (available(17) == 1) { S17.Enabled = true; S17.BackColor = Color.White; } 
            else {S17.Enabled = false; S17.BackColor = Color.LightGray; }
            if (available(18) == 1) { S18.Enabled = true; S18.BackColor = Color.White; } 
            else {S18.Enabled = false; S18.BackColor = Color.LightGray; }
            if (available(19) == 1) { S19.Enabled = true; S19.BackColor = Color.White; } 
            else {S19.Enabled = false; S19.BackColor = Color.LightGray; }
            if (available(20) == 1) { S20.Enabled = true; S20.BackColor = Color.White; } 
            else {S20.Enabled = false; S20.BackColor = Color.LightGray; }
            if (available(21) == 1) { S21.Enabled = true; S21.BackColor = Color.White; } 
            else {S21.Enabled = false; S21.BackColor = Color.LightGray; }

        }


        //Method to determine if a seat is available
        public int available(int num)
        {
            string nums = num.ToString(), avail = "";
            SqlConnection conn3 = new SqlConnection(connectionString);
            SqlCommand cmd3 = new SqlCommand("SELECT Id, Available FROM SeatTable", conn3);
            conn3.Open();
            SqlDataReader dataReader3 = cmd3.ExecuteReader();
            while (dataReader3.Read())
            {
                nums = dataReader3["Id"].ToString();
                avail = dataReader3["Available"].ToString();
                if (nums == num.ToString())
                {
                    return Convert.ToInt32(avail);
                }

            }
            return Convert.ToInt32(avail);
            conn3.Close();
            dataReader3.Close();
        }
        //Method to clear the controls
        public void defaultSeatSpider()
        {
            seatNum.Text = "S0";
            screenLabel.Text = "";
            dateLabel.Text = "";
            timeLabel.Text = "";
            time1.Checked = false;
            time2.Checked = false;
            time3.Checked = false;
            time4.Checked = false;
            time5.Checked = false;
            time6.Checked = false;
            comboBox1.Text = "";
        }
        //method for canceling the booking
        public void cancel()
        {
            drPanel.Show();
            spiderPanel.Show();
            nextButton.Show();
            prevButton.Show();
            seatSpider.Hide();
            defaultSeatSpider();
        }

        //Method used to deduct the balance when a transaction is made
        public void deductBalance()
        {
            //get balance from database
            string username, password, balance = "";
            decimal totalBalance = 0;
            SqlConnection conn4 = new SqlConnection(connectionString);
            SqlCommand cmd4 = new SqlCommand("SELECT Username, Password, Balance FROM UserData", conn4);
            conn4.Open();
            SqlDataReader dataReader4 = cmd4.ExecuteReader();
            while (dataReader4.Read())
            {
                username = dataReader4["Username"].ToString();
                password = dataReader4["Password"].ToString();
                balance = dataReader4["Balance"].ToString().Trim();
                if (username == currentUser.ToString() && password == currentUser.checkPassword())
                {
                    totalBalance = Convert.ToDecimal(balance);
                }
            }
            dataReader4.Close();
            conn4.Close();

            //deduct balance then update the database
            totalBalance = totalBalance - spider;
            balanceLabel.Text = totalBalance + "₱";
            SqlConnection conn5 = new SqlConnection(connectionString);
            conn5.Open();
            SqlCommand cmd5 = conn5.CreateCommand();
            cmd5.CommandText = "update UserData set Balance = '" + totalBalance + "' where Username='" + userName + "'";
            cmd5.ExecuteNonQuery();
            conn5.Close();
        }
        //method to determine the seat owner
        public void seatOwner()
        {
            SqlConnection conn6 = new SqlConnection(connectionString);
            conn6.Open();
            SqlCommand cmd6 = conn6.CreateCommand();
            cmd6.CommandText = "update SeatTable set Owner = '" + currentUser + "' where Id='" + seat + "'";
            cmd6.ExecuteNonQuery();
            conn6.Close();
        }
        //method that declare the seat as taken in the database (0 = taken) (1 = Available)
        public void removeSeat()
        {
            int avail = 0;
            SqlConnection conn7 = new SqlConnection(connectionString);
            conn7.Open();
            SqlCommand cmd7 = new SqlCommand("SELECT Id, Available FROM SeatTable", conn7);
            cmd7.CommandText = "update SeatTable set Available = '" + avail + "' where Id ='" + seat + "'";
            cmd7.ExecuteNonQuery();
            conn7.Close();
        }

        //methods for printing
        public void Print(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            receiptPanel = pnl;
            getprintarea(pnl);
            prntprv.Document = pntdoc;
            pntdoc.PrintPage += new PrintPageEventHandler(pntdoc_printpage);
            prntprv.ShowDialog();
        }
        public void pntdoc_printpage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memorying, (pagearea.Width / 2) - (this.receiptPanel.Width / 2), this.receiptPanel.Location.Y);

        }
        Bitmap memorying;
        public void getprintarea(Panel pnl)
        {
            memorying = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memorying, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }
        
        //Use to go back to the LoginPage
        private void signout_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Confirm Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                this.Hide();
                MessageBox.Show("You have been logged out!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                currentUser.Show();
            }
            else { }
        }
        //Responsible for label change and 
        //set the value of seat (used to determine the seatowner)
        private void S1_Click(object sender, EventArgs e)
        {
            seatNum.Text = S1.Name;
            seat = 1;
        }
        private void S2_Click(object sender, EventArgs e)
        {
            seatNum.Text = S2.Name;
            seat = 2;
        }
        private void S3_Click(object sender, EventArgs e)
        {
            seatNum.Text = S3.Name;
            seat = 3;
        }
        private void S4_Click(object sender, EventArgs e)
        {
            seatNum.Text = S4.Name;
            seat = 4;
        }
        private void S5_Click(object sender, EventArgs e)
        {
            seatNum.Text = S5.Name;
            seat = 5;
        }
        private void S6_Click(object sender, EventArgs e)
        {
            seatNum.Text = S6.Name;
            seat = 6;
        }
        private void S7_Click(object sender, EventArgs e)
        {
            seatNum.Text = S7.Name;
            seat = 7;
        }
        private void S8_Click(object sender, EventArgs e)
        {
            seatNum.Text = S8.Name;
            seat = 8;
        }
        private void S9_Click(object sender, EventArgs e)
        {
            seatNum.Text = S9.Name;
            seat = 9;
        }
        private void S10_Click(object sender, EventArgs e)
        {
            seatNum.Text = S10.Name;
            seat = 10;
        }
        private void S11_Click(object sender, EventArgs e)
        {
            seatNum.Text = S11.Name;
            seat = 11;
        }
        private void S12_Click(object sender, EventArgs e)
        {
            seatNum.Text = S12.Name;
            seat = 12;
        }
        private void S13_Click(object sender, EventArgs e)
        {
            seatNum.Text = S13.Name;
            seat = 13;
        }
        private void S14_Click(object sender, EventArgs e)
        {
            seatNum.Text = S14.Name;
            seat = 14;
        }
        private void S15_Click(object sender, EventArgs e)
        {
            seatNum.Text = S15.Name;
            seat = 15;
        }
        private void S16_Click(object sender, EventArgs e)
        {
            seatNum.Text = S16.Name;
            seat = 16;
        }
        private void S17_Click(object sender, EventArgs e)
        {
            seatNum.Text = S17.Name;
            seat = 17;
        }
        private void S18_Click(object sender, EventArgs e)
        {
            seatNum.Text = S18.Name;
            seat = 18;
        }
        private void S19_Click(object sender, EventArgs e)
        {
            seatNum.Text = S19.Name;
            seat = 19;
        }
        private void S20_Click(object sender, EventArgs e)
        {
            seatNum.Text = S20.Name;
            seat = 20;
        }
        private void S21_Click(object sender, EventArgs e)
        {
            seatNum.Text = S21.Name;
            seat = 21;
        }
        
        //Event when selecting cinema Box
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            screenLabel.Text = comboBox1.Text;
        }

        //Event when selecting time
        private void timeBox_EnabledChanged(object sender, EventArgs e)
        {
            if (this.time1.Checked)
            {
                timeLabel.Text = time1.Text;
            }
            else if (this.time2.Checked)
            {
                timeLabel.Text = time2.Text;
            }
            else if (this.time3.Checked)
            {
                timeLabel.Text = time3.Text;
            }
            else if (this.time4.Checked)
            {
                timeLabel.Text = time4.Text;
            }
            else if (this.time5.Checked)
            {
                timeLabel.Text = time5.Text;
            }
            else if (this.time6.Checked)
            {
                timeLabel.Text = time6.Text;
            }
        }

        //event when selecting date
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string theDate = date.Value.ToString("yyyy-MM-dd");
            dateLabel.Text = theDate;
        }

        //Event for the cancel in the booking panel
        private void button3_Click(object sender, EventArgs e)
        {
            cancel();
        }
       
        private void UserPage_Load(object sender, EventArgs e)
        {

        }

        //Event for the confirm button
        private void button2_Click(object sender, EventArgs e)
        {
            string username, balance = "";
            decimal amount = 0;
            SqlConnection conn8 = new SqlConnection(connectionString);
            SqlCommand cmd8 = new SqlCommand("SELECT Username, Balance FROM UserData", conn8);
            conn8.Open();
            SqlDataReader dataReader8 = cmd8.ExecuteReader();
            while (dataReader8.Read())
            {
                username = dataReader8["Username"].ToString();
                balance = dataReader8["Balance"].ToString().Trim();
                if (username == currentUser.ToString())
                {
                    amount = Convert.ToDecimal(balance);
                }
            }
            dataReader8.Close();
        
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult confirm = MessageBox.Show("Want to proceed with payment?", "confirm", buttons, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes) 
            {
                if ( Convert.ToDecimal(amount) < 250) {
                    MessageBox.Show("Not enough Balance!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    removeSeat();
                    loadSeats();
                    deductBalance();
                    seatOwner();
                    MessageBox.Show("Please print the copy of your receipt", "Successfully booked a ticket!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Print(this.receiptPanel);
                    cancel();
                }
            }
            else { }

        }

        //Event when the "Book now!" is clicked
        private void book1_Click(object sender, EventArgs e)
        {
            drPanel.Hide();
            spiderPanel.Hide();
            nextButton.Hide();
            prevButton.Hide();
            seatSpider.Show();
            dateLabel.Text = "";
        }
        
        //event when adding money
        private void button1_Click_1(object sender, EventArgs e)
        {
            string username, password, balance = "", balances;
            SqlConnection conn9 = new SqlConnection(connectionString);
            SqlCommand cmd9 = new SqlCommand("SELECT Username, Password, Balance FROM UserData", conn9);
            conn9.Open();
            SqlDataReader dataReader9 = cmd9.ExecuteReader();
            while (dataReader9.Read())
            {
                username = dataReader9["Username"].ToString();
                password = dataReader9["Password"].ToString();
                balances = dataReader9["Balance"].ToString().Trim();
                if (username == currentUser.ToString() && password == currentUser.checkPassword())
                {
                    balance = balances;
                }

            }
            dataReader9.Close();
            
            string message, title, defaultValue, myValue;
            message = "Please input your desired amount";
            title = "Adding Money to Balance";
            defaultValue = "0";
            myValue = Interaction.InputBox(message, title, defaultValue);
            try
            {
                decimal totalBalance = Convert.ToDecimal(myValue) + Convert.ToDecimal(balance);
                balanceLabel.Text = totalBalance + "₱";
                SqlConnection conn10 = new SqlConnection(connectionString);
                conn10.Open();
                SqlCommand cmd10 = conn10.CreateCommand();
                cmd10.CommandText = "update UserData set Balance = '" + totalBalance + "' where Username='" + userName + "'";
                cmd10.ExecuteNonQuery();
                conn10.Close();
            }
            catch (Exception ex)
            {
                decimal TotalBalance = 0;
            }

        }

    }
}
