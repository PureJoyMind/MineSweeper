namespace MineSweeper
{
    partial class TenSecTimer
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TenSecTimer));
            textBox1 = new TextBox();
            label1 = new Label();
            notifyIcon1 = new NotifyIcon(components);
            timer1 = new System.Windows.Forms.Timer(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            startTimerToolStripMenuItem = new ToolStripMenuItem();
            stopTimerToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(119, 82);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 59);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 1;
            label1.Text = "Elapsed Time";
            // 
            // notifyIcon1
            // 
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipTitle = "Timer";
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "notifyIcon1";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { startTimerToolStripMenuItem, stopTimerToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(211, 80);
            // 
            // startTimerToolStripMenuItem
            // 
            startTimerToolStripMenuItem.Name = "startTimerToolStripMenuItem";
            startTimerToolStripMenuItem.Size = new Size(210, 24);
            startTimerToolStripMenuItem.Text = "Start Timer";
            // 
            // stopTimerToolStripMenuItem
            // 
            stopTimerToolStripMenuItem.Name = "stopTimerToolStripMenuItem";
            stopTimerToolStripMenuItem.Size = new Size(210, 24);
            stopTimerToolStripMenuItem.Text = "Stop Timer";
            // 
            // TenSecTimer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 177);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "TenSecTimer";
            Text = "10 Second Timer";
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer timer1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem startTimerToolStripMenuItem;
        private ToolStripMenuItem stopTimerToolStripMenuItem;
    }
}