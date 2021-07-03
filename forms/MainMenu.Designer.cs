namespace Sentence_Rating
{
    partial class MainMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.learnButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(36, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome!";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // learnButton
            // 
            this.learnButton.BackColor = System.Drawing.Color.YellowGreen;
            this.learnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.learnButton.Location = new System.Drawing.Point(47, 176);
            this.learnButton.Name = "learnButton";
            this.learnButton.Size = new System.Drawing.Size(207, 123);
            this.learnButton.TabIndex = 1;
            this.learnButton.Text = "Learn";
            this.learnButton.UseVisualStyleBackColor = false;
            this.learnButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.YellowGreen;
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.playButton.Location = new System.Drawing.Point(289, 176);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(223, 123);
            this.playButton.TabIndex = 2;
            this.playButton.Text = "Play Trivia !";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.Button2_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.YellowGreen;
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.editButton.Location = new System.Drawing.Point(554, 176);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(207, 123);
            this.editButton.TabIndex = 3;
            this.editButton.Text = "Edit Content";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.Button3_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.learnButton);
            this.Controls.Add(this.label1);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button learnButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button editButton;
    }
}