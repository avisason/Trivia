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
    public partial class EditContentForm : Form
    {
        public EditContentForm()
        {
            InitializeComponent();
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

        private void button3_Click(object sender, EventArgs e)
        {
            ScreenChange(new EditTriviaForm());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void EditContentForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ScreenChange(new EditLearningForm());
        }
    }
}
