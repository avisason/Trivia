using Sentence_Rating.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sentence_Rating.forms
{
    enum QuestionType
    {
        multichoice=1,
        TF=2,
        TFwithImage=3,
        MCwithImage=4,
        Default=5
    }

    public partial class EditTriviaForm : Form
    {

        private int q_type { set; get; }

        private int right_question { set; get; }

        List<Answer> answers = new List<Answer>();
        public EditTriviaForm()
        {
            InitializeComponent();
        }


       
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void EditTriviaForm_Load(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        //question
        private void question_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void answer_a_TextChanged(object sender, EventArgs e)
        {
        }
        private void answer_b_TextChanged(object sender, EventArgs e)
        {
        }
        private void answer_c_TextChanged(object sender, EventArgs e)
        { 
            
        }
        private void answer_d_TextChanged(object sender, EventArgs e)
        {
        }



        private void tabPage1_Click(object sender, EventArgs e)
        {
            q_type = 1;
        }
        private void tabPage2_Click(object sender, EventArgs e)
        {
            q_type = 2;

        }
        private void tabPage3_Click(object sender, EventArgs e)
        {
            q_type = 3;
        }
        private void tabPage4_Click(object sender, EventArgs e)
        {
            q_type = 4;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            validateContent(q_type);
        }


        private void validateContent(int question_type)
        {
            if (answer_a.Text == "" || answer_d.Text == "" || answer_c.Text == "" || answer_b.Text == "")
            {
                MessageBox.Show("you cannot provide empty answer");
                throw new Exception("empty answer");
            }
            answers.Add(new Answer(right_question==1, answer_a.Text));
            answers.Add(new Answer(right_question==2, answer_b.Text));
            answers.Add(new Answer(right_question == 3, answer_c.Text));
            answers.Add(new Answer(right_question == 4, answer_d.Text));

            Question new_question = new Question(q_type,question.Text ,answers);
            new_question.store();
            
        }

        private void selection_a_CheckedChanged(object sender, EventArgs e)
        {
            if (selection_a.Checked)
            {
                right_question = 1;
            }
        }
        private void selection_b_CheckedChanged(object sender, EventArgs e)
        {
            if (selection_a.Checked)
            {
                right_question = 2;
            }
        }
        private void isSelected_c_CheckedChanged(object sender, EventArgs e)
        {
            if (selection_a.Checked)
            {
                right_question = 3;
            }
        }
        private void selection_d_CheckedChanged(object sender, EventArgs e)
        {
            if (selection_a.Checked)
            {
                right_question = 4;
            }
        }
    }
}
