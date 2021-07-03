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
    public partial class LearnForm : Form, IGameScreen
    {

        DataItem currentItem;
        Queue<DataItem> learningItems = new Queue<DataItem>();
        System.IO.StreamReader file = new System.IO.StreamReader(@"..\..\data\infoData.txt");

        public LearnForm()
        {
            InitializeComponent();
            getLearningItems();
            getItem();        
        }

        private void getItem()
        {
            try
            {
            DataItem current = learningItems.Dequeue();
            DisplayContent(current);

            }
            catch (Exception e)
            {
                MessageBox.Show("no more questions");
                return;

            }
  
        }
        private void getLearningItems()
        {
            string line;
            while ((line = file.ReadLine()) != null)
            {
                string[] fields = line.Split(',');
                if (fields.Length == 4)
                {
                    currentItem = new DataItemWithImage(Int32.Parse(fields[0]), fields[1], fields[2], fields[3]);
                }
                else
                {
                    currentItem = new DataItem(Int32.Parse(fields[0]), fields[1], fields[2]);
                }
                learningItems.Enqueue(currentItem);
            }
        }
        private void DisplayContent(DataItem item)
        {
            if (item is DataItemWithImage)
            {

                string image_path = @"..\..\DIMAGES\" + (item as DataItemWithImage).image;
                pictureBox1.Image = Image.FromFile(image_path);
            }
            else
            {
                pictureBox1.Visible = false;
            }
            textBox1.Text = item.Content;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void LearnForm_Load(object sender, EventArgs e)
        {

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        } 

        private void button1_Click(object sender, EventArgs e)
        {
            getItem();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ScreenChange(new MainMenu("bye bye!"));
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
