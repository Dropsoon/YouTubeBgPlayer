
namespace YouTubeBgPlayer
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
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.flowControls = new System.Windows.Forms.FlowLayoutPanel();
            this.bNext = new System.Windows.Forms.Button();
            this.bPrevious = new System.Windows.Forms.Button();
            this.flowControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(2, 2);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(70, 29);
            this.buttonPlay.TabIndex = 0;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(76, 2);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(66, 29);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // flowControls
            // 
            this.flowControls.Controls.Add(this.buttonPlay);
            this.flowControls.Controls.Add(this.buttonStop);
            this.flowControls.Controls.Add(this.bNext);
            this.flowControls.Controls.Add(this.bPrevious);
            this.flowControls.Location = new System.Drawing.Point(16, 62);
            this.flowControls.Margin = new System.Windows.Forms.Padding(2);
            this.flowControls.Name = "flowControls";
            this.flowControls.Size = new System.Drawing.Size(286, 35);
            this.flowControls.TabIndex = 2;
            // 
            // bNext
            // 
            this.bNext.Location = new System.Drawing.Point(146, 2);
            this.bNext.Margin = new System.Windows.Forms.Padding(2);
            this.bNext.Name = "bNext";
            this.bNext.Size = new System.Drawing.Size(66, 29);
            this.bNext.TabIndex = 2;
            this.bNext.Text = "Next";
            this.bNext.UseVisualStyleBackColor = true;
            this.bNext.Click += new System.EventHandler(this.bNext_Click);
            // 
            // bPrevious
            // 
            this.bPrevious.Location = new System.Drawing.Point(216, 2);
            this.bPrevious.Margin = new System.Windows.Forms.Padding(2);
            this.bPrevious.Name = "bPrevious";
            this.bPrevious.Size = new System.Drawing.Size(66, 29);
            this.bPrevious.TabIndex = 3;
            this.bPrevious.Text = "Pervious";
            this.bPrevious.UseVisualStyleBackColor = true;
            this.bPrevious.Click += new System.EventHandler(this.bPrevious_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 253);
            this.Controls.Add(this.flowControls);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(14, 60, 14, 15);
            this.Text = "YouTubePlayer";
            this.flowControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.FlowLayoutPanel flowControls;
        private System.Windows.Forms.Button bNext;
        private System.Windows.Forms.Button bPrevious;
    }
}

