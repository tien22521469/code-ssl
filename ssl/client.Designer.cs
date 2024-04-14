namespace ssl
{
    partial class client
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
            richTextBox1 = new RichTextBox();
            sendMsgTextBox = new RichTextBox();
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            button2 = new Button();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            progressBar1 = new ProgressBar();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 81);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(776, 335);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // sendMsgTextBox
            // 
            sendMsgTextBox.Location = new Point(12, 428);
            sendMsgTextBox.Margin = new Padding(3, 4, 3, 4);
            sendMsgTextBox.Name = "sendMsgTextBox";
            sendMsgTextBox.Size = new Size(644, 119);
            sendMsgTextBox.TabIndex = 1;
            sendMsgTextBox.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(662, 428);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(117, 120);
            button1.TabIndex = 2;
            button1.Text = "Send Message";
            button1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(150, 26);
            openToolStripMenuItem.Text = "Send file";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 45);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(120, 46);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 27);
            textBox2.TabIndex = 10;
            textBox2.Text = "127.0.0.1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 48);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 9;
            label2.Text = "Server address";
            // 
            // button2
            // 
            button2.Location = new Point(588, 46);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(75, 29);
            button2.TabIndex = 11;
            button2.Text = "Connect";
            button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(243, 50);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 12;
            label3.Text = "Username";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(322, 46);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 27);
            textBox1.TabIndex = 13;
            textBox1.Text = "Alice";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(482, 48);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 27);
            textBox3.TabIndex = 15;
            textBox3.Text = "Bob";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(428, 50);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 14;
            label4.Text = "Friend";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(669, 45);
            progressBar1.Margin = new Padding(3, 4, 3, 4);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(119, 29);
            progressBar1.TabIndex = 16;
            // 
            // client
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(progressBar1);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(sendMsgTextBox);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "client";
            Text = "ClientChatForm";
            
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox sendMsgTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private Button button2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox3;
        private Label label4;
        private ProgressBar progressBar1;
    }
}