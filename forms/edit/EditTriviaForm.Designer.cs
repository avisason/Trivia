namespace Sentence_Rating.forms
{
    partial class EditTriviaForm
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
            this.multichoice = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.question = new System.Windows.Forms.TextBox();
            this.answer_a = new System.Windows.Forms.TextBox();
            this.selection_b = new System.Windows.Forms.RadioButton();
            this.selection_a = new System.Windows.Forms.RadioButton();
            this.answer_b = new System.Windows.Forms.TextBox();
            this.selection_d = new System.Windows.Forms.RadioButton();
            this.answer_d = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.answer_c = new System.Windows.Forms.TextBox();
            this.isSelected_c = new System.Windows.Forms.RadioButton();
            this.multichoice.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // multichoice
            // 
            this.multichoice.Controls.Add(this.tabPage1);
            this.multichoice.Controls.Add(this.tabPage2);
            this.multichoice.Controls.Add(this.tabPage3);
            this.multichoice.Controls.Add(this.tabPage4);
            this.multichoice.Location = new System.Drawing.Point(24, 12);
            this.multichoice.Name = "multichoice";
            this.multichoice.SelectedIndex = 0;
            this.multichoice.Size = new System.Drawing.Size(960, 540);
            this.multichoice.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.isSelected_c);
            this.tabPage1.Controls.Add(this.answer_c);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.question);
            this.tabPage1.Controls.Add(this.answer_a);
            this.tabPage1.Controls.Add(this.selection_b);
            this.tabPage1.Controls.Add(this.selection_a);
            this.tabPage1.Controls.Add(this.answer_b);
            this.tabPage1.Controls.Add(this.selection_d);
            this.tabPage1.Controls.Add(this.answer_d);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(952, 514);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "multichoice";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(770, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 37);
            this.button1.TabIndex = 18;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "please mark the answer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Question:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // question
            // 
            this.question.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.question.Location = new System.Drawing.Point(131, 72);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(747, 20);
            this.question.TabIndex = 15;
            this.question.TextChanged += new System.EventHandler(this.question_TextChanged);
            // 
            // answer_a
            // 
            this.answer_a.Location = new System.Drawing.Point(131, 144);
            this.answer_a.Name = "answer_a";
            this.answer_a.Size = new System.Drawing.Size(747, 20);
            this.answer_a.TabIndex = 14;
            this.answer_a.TextChanged += new System.EventHandler(this.answer_a_TextChanged);
            // 
            // selection_b
            // 
            this.selection_b.AutoSize = true;
            this.selection_b.Location = new System.Drawing.Point(82, 238);
            this.selection_b.Name = "selection_b";
            this.selection_b.Size = new System.Drawing.Size(14, 13);
            this.selection_b.TabIndex = 13;
            this.selection_b.TabStop = true;
            this.selection_b.UseVisualStyleBackColor = true;
            this.selection_b.CheckedChanged += new System.EventHandler(this.selection_b_CheckedChanged);
            // 
            // selection_a
            // 
            this.selection_a.AutoSize = true;
            this.selection_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.selection_a.Location = new System.Drawing.Point(82, 144);
            this.selection_a.Name = "selection_a";
            this.selection_a.Size = new System.Drawing.Size(14, 13);
            this.selection_a.TabIndex = 12;
            this.selection_a.TabStop = true;
            this.selection_a.UseVisualStyleBackColor = true;
            this.selection_a.CheckedChanged += new System.EventHandler(this.selection_a_CheckedChanged);
            // 
            // answer_b
            // 
            this.answer_b.Location = new System.Drawing.Point(131, 238);
            this.answer_b.Name = "answer_b";
            this.answer_b.Size = new System.Drawing.Size(747, 20);
            this.answer_b.TabIndex = 11;
            this.answer_b.TextChanged += new System.EventHandler(this.answer_b_TextChanged);
            // 
            // selection_d
            // 
            this.selection_d.AutoSize = true;
            this.selection_d.Location = new System.Drawing.Point(82, 427);
            this.selection_d.Name = "selection_d";
            this.selection_d.Size = new System.Drawing.Size(14, 13);
            this.selection_d.TabIndex = 9;
            this.selection_d.TabStop = true;
            this.selection_d.UseVisualStyleBackColor = true;
            this.selection_d.CheckedChanged += new System.EventHandler(this.selection_d_CheckedChanged);
            // 
            // answer_d
            // 
            this.answer_d.Location = new System.Drawing.Point(131, 427);
            this.answer_d.Name = "answer_d";
            this.answer_d.Size = new System.Drawing.Size(747, 20);
            this.answer_d.TabIndex = 5;
            this.answer_d.TextChanged += new System.EventHandler(this.answer_d_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Here we will add a multichoice question!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(952, 514);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "True/False";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(952, 514);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "True/False + Image";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(952, 514);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Multichoice + Image";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // answer_c
            // 
            this.answer_c.Location = new System.Drawing.Point(131, 330);
            this.answer_c.Name = "answer_c";
            this.answer_c.Size = new System.Drawing.Size(747, 20);
            this.answer_c.TabIndex = 19;
            this.answer_c.TextChanged += new System.EventHandler(this.answer_c_TextChanged);
            // 
            // isSelected_c
            // 
            this.isSelected_c.AutoSize = true;
            this.isSelected_c.Location = new System.Drawing.Point(82, 333);
            this.isSelected_c.Name = "isSelected_c";
            this.isSelected_c.Size = new System.Drawing.Size(14, 13);
            this.isSelected_c.TabIndex = 20;
            this.isSelected_c.TabStop = true;
            this.isSelected_c.UseVisualStyleBackColor = true;
            this.isSelected_c.CheckedChanged += new System.EventHandler(this.isSelected_c_CheckedChanged);
            // 
            // EditTriviaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 564);
            this.Controls.Add(this.multichoice);
            this.Name = "EditTriviaForm";
            this.Text = "EditTriviaForm";
            this.Load += new System.EventHandler(this.EditTriviaForm_Load);
            this.multichoice.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl multichoice;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox answer_d;
        private System.Windows.Forms.RadioButton selection_d;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox question;
        private System.Windows.Forms.TextBox answer_a;
        private System.Windows.Forms.RadioButton selection_b;
        private System.Windows.Forms.RadioButton selection_a;
        private System.Windows.Forms.TextBox answer_b;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox answer_c;
        private System.Windows.Forms.RadioButton isSelected_c;
    }
}