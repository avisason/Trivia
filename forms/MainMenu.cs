using Sentence_Rating.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sentence_Rating
{
    public partial class MainMenu : Form, IGameScreen
    {
        public MainMenu(string message)
        {
            InitializeComponent();
            MessageBox.Show(message);

        }
       

        private void Form2_Load(object sender, EventArgs e)
        {
          
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ScreenChange(new LearnForm());

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ScreenChange(new TriviaForm());
        }


        private void Button3_Click(object sender, EventArgs e)
        {
            ScreenChange(new EditContentForm());

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
    }
}
