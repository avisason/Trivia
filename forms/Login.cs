using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sentence_Rating
{
    public partial class Login : Form, IGameScreen 
    {

        // played games;
        // users
        // questions
        // answers


        private string Email { get; set; }
        private readonly string path_to_users_file = @"..\..\data\users.txt";

        private List<string> usersList;
        public Login()
        {
            InitializeComponent();
        
        }


        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Email = emailBox.Text;
        }

        public void ScreenChange(Form target_form)
        {
            var frm = target_form;
            frm.Location = Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { Show(); };
            frm.Show();
            Hide();
        }

        private List<string> GetUsers()
        {
            List<string> usersList = System.IO.File.ReadAllLines(path_to_users_file).ToList();
            return usersList;
        }
        private void SetUsers(List<string> usersList)
        {
            File.WriteAllLines(path_to_users_file, usersList);
        }
        private bool UpsertUsersList(string email)
        {

            usersList = GetUsers();

            if (usersList.Contains(email)){
                return true;
            }
            usersList.Add(email);
            SetUsers(usersList);
            
            return false;
        }
        private void Button1_Click_1(object sender, EventArgs e)
        {
 
            if (IsValidEmail(Email))
            {

                ScreenChange(new MainMenu(UpsertUsersList(Email) ? "welcome back!" : "It seems like you are new here, please what the menu"));
            }
            else
            {
               MessageBox.Show("This is an invalid email");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
