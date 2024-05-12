namespace jokeGen
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            genButton = new Button();
            jokeBox = new TextBox();
            copyButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            label1.Location = new Point(111, 9);
            label1.Name = "label1";
            label1.Size = new Size(562, 45);
            label1.TabIndex = 1;
            label1.Text = "Ultimate Sigma Joke Generator";
            // 
            // genButton
            // 
            genButton.Location = new Point(329, 85);
            genButton.Name = "genButton";
            genButton.Size = new Size(112, 34);
            genButton.TabIndex = 2;
            genButton.Text = "Generate";
            genButton.UseVisualStyleBackColor = true;
            genButton.Click += genButton_Click;
            // 
            // jokeBox
            // 
            jokeBox.Location = new Point(12, 155);
            jokeBox.Name = "jokeBox";
            jokeBox.Size = new Size(762, 30);
            jokeBox.TabIndex = 3;
            // 
            // copyButton
            // 
            copyButton.Location = new Point(12, 191);
            copyButton.Name = "copyButton";
            copyButton.Size = new Size(67, 32);
            copyButton.TabIndex = 4;
            copyButton.Text = "Copy";
            copyButton.UseVisualStyleBackColor = true;
            copyButton.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(786, 487);
            Controls.Add(copyButton);
            Controls.Add(jokeBox);
            Controls.Add(genButton);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Form1";
            Text = "USJG";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button genButton;
        private TextBox jokeBox;
        private Button copyButton;
    }
}
