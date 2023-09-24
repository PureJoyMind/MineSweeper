namespace MineSweeper
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
            colorDialog1 = new ColorDialog();
            tenSecTimer = new Button();
            SuspendLayout();
            // 
            // tenSecTimer
            // 
            tenSecTimer.Location = new Point(289, 184);
            tenSecTimer.Name = "tenSecTimer";
            tenSecTimer.Size = new Size(176, 40);
            tenSecTimer.TabIndex = 0;
            tenSecTimer.Text = "10 Second Timer";
            tenSecTimer.UseVisualStyleBackColor = true;
            tenSecTimer.Click += tenSecTimer_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tenSecTimer);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ColorDialog colorDialog1;
        private Button tenSecTimer;
    }
}