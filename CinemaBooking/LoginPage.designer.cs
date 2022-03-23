namespace CinemaBooking
{
    partial class LoginPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.loginTop = new System.Windows.Forms.Button();
            this.registerTop = new System.Windows.Forms.Button();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.loginButton = new System.Windows.Forms.Button();
            this.loginPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.loginUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.registerPanel = new System.Windows.Forms.Panel();
            this.confNote = new System.Windows.Forms.Label();
            this.passNote = new System.Windows.Forms.Label();
            this.userNote = new System.Windows.Forms.Label();
            this.lastNote = new System.Windows.Forms.Label();
            this.firstNote = new System.Windows.Forms.Label();
            this.regConf = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.regPass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.regUser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.regButton = new System.Windows.Forms.Button();
            this.regLast = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.regFirst = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginPanel.SuspendLayout();
            this.registerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginTop
            // 
            this.loginTop.BackColor = System.Drawing.Color.DimGray;
            this.loginTop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTop.ForeColor = System.Drawing.Color.White;
            this.loginTop.Location = new System.Drawing.Point(3, 175);
            this.loginTop.Name = "loginTop";
            this.loginTop.Size = new System.Drawing.Size(264, 47);
            this.loginTop.TabIndex = 0;
            this.loginTop.Text = "Login";
            this.loginTop.UseVisualStyleBackColor = false;
            this.loginTop.Click += new System.EventHandler(this.button1_Click);
            // 
            // registerTop
            // 
            this.registerTop.BackColor = System.Drawing.Color.Black;
            this.registerTop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerTop.ForeColor = System.Drawing.Color.White;
            this.registerTop.Location = new System.Drawing.Point(278, 175);
            this.registerTop.Name = "registerTop";
            this.registerTop.Size = new System.Drawing.Size(264, 47);
            this.registerTop.TabIndex = 1;
            this.registerTop.Text = "Register";
            this.registerTop.UseVisualStyleBackColor = false;
            this.registerTop.Click += new System.EventHandler(this.button2_Click);
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.Color.DimGray;
            this.loginPanel.Controls.Add(this.loginButton);
            this.loginPanel.Controls.Add(this.loginPass);
            this.loginPanel.Controls.Add(this.label2);
            this.loginPanel.Controls.Add(this.loginUser);
            this.loginPanel.Controls.Add(this.label1);
            this.loginPanel.Location = new System.Drawing.Point(5, 232);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(537, 395);
            this.loginPanel.TabIndex = 2;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Maroon;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(46, 234);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(444, 50);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // loginPass
            // 
            this.loginPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginPass.Location = new System.Drawing.Point(167, 143);
            this.loginPass.Multiline = true;
            this.loginPass.Name = "loginPass";
            this.loginPass.PasswordChar = '*';
            this.loginPass.Size = new System.Drawing.Size(339, 28);
            this.loginPass.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // loginUser
            // 
            this.loginUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginUser.Location = new System.Drawing.Point(167, 73);
            this.loginUser.Multiline = true;
            this.loginUser.Name = "loginUser";
            this.loginUser.Size = new System.Drawing.Size(339, 28);
            this.loginUser.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // registerPanel
            // 
            this.registerPanel.BackColor = System.Drawing.Color.DimGray;
            this.registerPanel.Controls.Add(this.confNote);
            this.registerPanel.Controls.Add(this.passNote);
            this.registerPanel.Controls.Add(this.userNote);
            this.registerPanel.Controls.Add(this.lastNote);
            this.registerPanel.Controls.Add(this.firstNote);
            this.registerPanel.Controls.Add(this.regConf);
            this.registerPanel.Controls.Add(this.label7);
            this.registerPanel.Controls.Add(this.regPass);
            this.registerPanel.Controls.Add(this.label6);
            this.registerPanel.Controls.Add(this.regUser);
            this.registerPanel.Controls.Add(this.label5);
            this.registerPanel.Controls.Add(this.regButton);
            this.registerPanel.Controls.Add(this.regLast);
            this.registerPanel.Controls.Add(this.label3);
            this.registerPanel.Controls.Add(this.regFirst);
            this.registerPanel.Controls.Add(this.label4);
            this.registerPanel.Location = new System.Drawing.Point(5, 232);
            this.registerPanel.Name = "registerPanel";
            this.registerPanel.Size = new System.Drawing.Size(537, 392);
            this.registerPanel.TabIndex = 5;
            // 
            // confNote
            // 
            this.confNote.AutoSize = true;
            this.confNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confNote.ForeColor = System.Drawing.Color.Red;
            this.confNote.Location = new System.Drawing.Point(164, 293);
            this.confNote.Name = "confNote";
            this.confNote.Size = new System.Drawing.Size(0, 16);
            this.confNote.TabIndex = 14;
            // 
            // passNote
            // 
            this.passNote.AutoSize = true;
            this.passNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passNote.ForeColor = System.Drawing.Color.Red;
            this.passNote.Location = new System.Drawing.Point(164, 234);
            this.passNote.Name = "passNote";
            this.passNote.Size = new System.Drawing.Size(0, 16);
            this.passNote.TabIndex = 13;
            // 
            // userNote
            // 
            this.userNote.AutoSize = true;
            this.userNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNote.ForeColor = System.Drawing.Color.Red;
            this.userNote.Location = new System.Drawing.Point(164, 174);
            this.userNote.Name = "userNote";
            this.userNote.Size = new System.Drawing.Size(0, 16);
            this.userNote.TabIndex = 12;
            // 
            // lastNote
            // 
            this.lastNote.AutoSize = true;
            this.lastNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNote.ForeColor = System.Drawing.Color.Red;
            this.lastNote.Location = new System.Drawing.Point(164, 113);
            this.lastNote.Name = "lastNote";
            this.lastNote.Size = new System.Drawing.Size(0, 16);
            this.lastNote.TabIndex = 11;
            // 
            // firstNote
            // 
            this.firstNote.AutoSize = true;
            this.firstNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNote.ForeColor = System.Drawing.Color.Red;
            this.firstNote.Location = new System.Drawing.Point(164, 54);
            this.firstNote.Name = "firstNote";
            this.firstNote.Size = new System.Drawing.Size(0, 16);
            this.firstNote.TabIndex = 10;
            // 
            // regConf
            // 
            this.regConf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regConf.Location = new System.Drawing.Point(167, 262);
            this.regConf.Multiline = true;
            this.regConf.Name = "regConf";
            this.regConf.PasswordChar = '*';
            this.regConf.Size = new System.Drawing.Size(339, 28);
            this.regConf.TabIndex = 5;
            this.regConf.TextChanged += new System.EventHandler(this.regConf_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(22, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Confirm Pass:";
            // 
            // regPass
            // 
            this.regPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regPass.Location = new System.Drawing.Point(167, 203);
            this.regPass.Multiline = true;
            this.regPass.Name = "regPass";
            this.regPass.PasswordChar = '*';
            this.regPass.Size = new System.Drawing.Size(339, 28);
            this.regPass.TabIndex = 4;
            this.regPass.TextChanged += new System.EventHandler(this.regPass_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(24, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 29);
            this.label6.TabIndex = 7;
            this.label6.Text = "Password:";
            // 
            // regUser
            // 
            this.regUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regUser.Location = new System.Drawing.Point(167, 144);
            this.regUser.Multiline = true;
            this.regUser.Name = "regUser";
            this.regUser.Size = new System.Drawing.Size(339, 28);
            this.regUser.TabIndex = 3;
            this.regUser.TextChanged += new System.EventHandler(this.regUser_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(24, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Username:";
            // 
            // regButton
            // 
            this.regButton.BackColor = System.Drawing.Color.Silver;
            this.regButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regButton.ForeColor = System.Drawing.Color.White;
            this.regButton.Location = new System.Drawing.Point(51, 324);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(444, 50);
            this.regButton.TabIndex = 6;
            this.regButton.Text = "Register";
            this.regButton.UseVisualStyleBackColor = false;
            this.regButton.Click += new System.EventHandler(this.regButton_Click);
            // 
            // regLast
            // 
            this.regLast.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.regLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regLast.Location = new System.Drawing.Point(167, 85);
            this.regLast.Multiline = true;
            this.regLast.Name = "regLast";
            this.regLast.Size = new System.Drawing.Size(339, 28);
            this.regLast.TabIndex = 2;
            this.regLast.TextChanged += new System.EventHandler(this.regLast_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name:";
            // 
            // regFirst
            // 
            this.regFirst.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.regFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regFirst.Location = new System.Drawing.Point(167, 26);
            this.regFirst.Multiline = true;
            this.regFirst.Name = "regFirst";
            this.regFirst.Size = new System.Drawing.Size(339, 28);
            this.regFirst.TabIndex = 1;
            this.regFirst.TextChanged += new System.EventHandler(this.regFirst_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(24, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "First Name:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(71, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(401, 193);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(547, 632);
            this.Controls.Add(this.registerTop);
            this.Controls.Add(this.loginTop);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.registerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eye-Max Cinema Booking App";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.registerPanel.ResumeLayout(false);
            this.registerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loginTop;
        private System.Windows.Forms.Button registerTop;
        private System.Windows.Forms.Panel loginPanel;
        public System.Windows.Forms.TextBox loginUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox loginPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel registerPanel;
        private System.Windows.Forms.TextBox regConf;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox regPass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox regUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button regButton;
        private System.Windows.Forms.TextBox regLast;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox regFirst;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label confNote;
        private System.Windows.Forms.Label passNote;
        private System.Windows.Forms.Label userNote;
        private System.Windows.Forms.Label lastNote;
        private System.Windows.Forms.Label firstNote;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

