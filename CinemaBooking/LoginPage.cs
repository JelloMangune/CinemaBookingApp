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

namespace CinemaBooking
{
    
    public partial class LoginPage : Form
    {
        public static string connectionString = userInfo.connectionString();
        SqlConnection conn = new SqlConnection(connectionString);
        userInfo newUser = new userInfo();
        userInfo exstUser = new userInfo();
        hello hi = new hello(); 
        string adminUser = "Admin";
        string adminPassword = "Admin";
        public static string sendtext;
        public static string sendtext2;
        public LoginPage()
        {
            InitializeComponent();
            regButton.Enabled = false;
            regButton.BackColor = Color.Silver;
            AdminPage adminpage = new AdminPage();
        }
        public void setNewUserData()
        {   
            newUser.UserName = regUser.Text;
            newUser.Password = regPass.Text;
            newUser.FirstName = regFirst.Text;
            newUser.LastName = regLast.Text;
            newUser.WholeName = regFirst.Text + " " + regLast.Text;
            newUser.Balance = 0;
            
        }
        public void setUserInfo()
        {
            exstUser.UserName = loginUser.Text;
            exstUser.Password= loginPass.Text;
        }
        public void clearText()
        {
            regUser.Text = ""; userNote.Text = "";
            regPass.Text = ""; passNote.Text = "";
            regFirst.Text = ""; firstNote.Text = "";
            regLast.Text = ""; lastNote.Text = "";
            regConf.Text = ""; confNote.Text = "";
        }
        public bool confirmPass()
        {
            if (regConf.Text == regPass.Text)
                return true;

            else
                return false;
        }
        public void checkData()
        {
            setNewUserData();
            if (confirmPass() && newUser.UserName.Length > 5 && newUser.FirstName.Length > 3 && newUser.LastName.Length > 3 && newUser.Password.Length > 3)
            {
                regButton.Enabled = true;
                regButton.BackColor = Color.Maroon;
            }
            else
            {
                regButton.Enabled = false;
                regButton.BackColor = Color.Silver;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginPanel.BringToFront();
            loginTop.BackColor = Color.DimGray;
            registerTop.BackColor = Color.Black;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            registerPanel.BringToFront();
            registerTop.BackColor = Color.DimGray;
            loginTop.BackColor = Color.Black;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            setUserInfo();
            SqlConnection conn2 = new SqlConnection(connectionString);
            SqlDataAdapter sda2 = new SqlDataAdapter("select count(*) from UserData where Username ='"+exstUser.UserName+"' and Password='"+exstUser.Password+"'", conn2);
            DataTable dt = new DataTable();
            sda2.Fill(dt);
            if (exstUser.UserName == adminUser && exstUser.Password == adminPassword)
            {
                this.Hide();
                MessageBox.Show(hi.greet());     
                AdminPage adminpage = new AdminPage();
                adminpage.Show(); 
            } 
            else if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                hi.Greetings = exstUser.UserName;              
                MessageBox.Show(hi.ReturnGreet);
                sendtext = loginUser.Text;
                sendtext2 = loginPass.Text; 
                UserPage userpage = new UserPage();
                userpage.Show();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loginPass.Text = "";
            }
        }
        private void regButton_Click(object sender, EventArgs e)
        {
            //setNewUserData();
            SqlConnection conn3 = new SqlConnection(connectionString);
            SqlCommand cmd3 = new SqlCommand("insert into UserData (Username,Password,Firstname,Lastname,Fullname,Balance) values ('"+newUser.UserName+"','"+newUser.Password+"','"+newUser.FirstName+"','"+newUser.LastName+"','"+newUser.WholeName+"','"+newUser.Balance+"')",conn3);
            conn3.Open();
            cmd3.ExecuteNonQuery();
            //Message box confirming the registration
            MessageBox.Show("Registered Successfully!","", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Clear Text boxes
            clearText();
            //Move to Login Panel
            loginPanel.BringToFront();
            loginTop.BackColor = Color.DimGray;
            registerTop.BackColor = Color.Black;
            
        }
        private void regFirst_TextChanged(object sender, EventArgs e)
        {
            checkData();
            if (newUser.FirstName.Length < 4) firstNote.Text = "Please input 4 or more characters"; else firstNote.Text = "";
            if (System.Text.RegularExpressions.Regex.IsMatch(regFirst.Text, "^[a-zA-Z]+$")|| regFirst.Text == "")
            {
            }
            else
            {
                regFirst.Text = regFirst.Text.Remove(regFirst.Text.Length - 1);
                MessageBox.Show("Enter only Alphabets");
            }
        }
        private void regLast_TextChanged(object sender, EventArgs e)
        {
            checkData();
            if (newUser.LastName.Length < 4) lastNote.Text = "Please 4 or more characters"; else lastNote.Text = "";
            if (System.Text.RegularExpressions.Regex.IsMatch(regLast.Text, "^[a-zA-Z]+$") || regLast.Text == "")
            {
            }
            else
            {
                regLast.Text = regLast.Text.Remove(regLast.Text.Length - 1);
                MessageBox.Show("Enter only Alphabets");
            }
        }
        private void regUser_TextChanged(object sender, EventArgs e)
        {
            checkData();
            if (newUser.UserName.Length < 6) userNote.Text = "Please input 6 or more characters"; else userNote.Text = "";
        }
        private void regPass_TextChanged(object sender, EventArgs e)
        {
            checkData();
            if (newUser.Password.Length < 4) passNote.Text = "Please input 5 or more characters"; else passNote.Text = "";
        }
        private void regConf_TextChanged(object sender, EventArgs e)
        {
            checkData();
            if (newUser.Password == regConf.Text) confNote.Text = ""; else confNote.Text = "Password doesn't match";
        }
      
        
        public string checkPassword()
        {
            return sendtext2;
        }
        //runtime polymorphism
        public override string ToString()
        {
            return sendtext;
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

    }
}
