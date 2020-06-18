namespace Metronome
{
    partial class Form1
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
            this.setBPM = new System.Windows.Forms.Button();
            this.BPMinput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mTimer1 = new System.Windows.Forms.RadioButton();
            this.mTimer2 = new System.Windows.Forms.RadioButton();
            this.mTimer3 = new System.Windows.Forms.RadioButton();
            this.mTimer4 = new System.Windows.Forms.RadioButton();
            this.playButton = new System.Windows.Forms.Button();
            this.metronomeBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // setBPM
            // 
            this.setBPM.AccessibleName = "";
            this.setBPM.Location = new System.Drawing.Point(403, 185);
            this.setBPM.Name = "setBPM";
            this.setBPM.Size = new System.Drawing.Size(75, 23);
            this.setBPM.TabIndex = 0;
            this.setBPM.Text = "setBPM";
            this.setBPM.UseVisualStyleBackColor = true;
            this.setBPM.Click += new System.EventHandler(this.setBPM_Click);
            // 
            // BPMinput
            // 
            this.BPMinput.Location = new System.Drawing.Point(281, 187);
            this.BPMinput.Name = "BPMinput";
            this.BPMinput.Size = new System.Drawing.Size(116, 20);
            this.BPMinput.TabIndex = 1;
            this.BPMinput.TextChanged += new System.EventHandler(this.BPMtxt_Changed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "BPM";
            this.label1.Click += new System.EventHandler(this.BPMLabel_Click);
            // 
            // mTimer1
            // 
            this.mTimer1.AutoSize = true;
            this.mTimer1.Location = new System.Drawing.Point(248, 218);
            this.mTimer1.Name = "mTimer1";
            this.mTimer1.Size = new System.Drawing.Size(31, 17);
            this.mTimer1.TabIndex = 4;
            this.mTimer1.TabStop = true;
            this.mTimer1.Text = "1";
            this.mTimer1.UseVisualStyleBackColor = true;
            // 
            // mTimer2
            // 
            this.mTimer2.AutoSize = true;
            this.mTimer2.Location = new System.Drawing.Point(317, 218);
            this.mTimer2.Name = "mTimer2";
            this.mTimer2.Size = new System.Drawing.Size(31, 17);
            this.mTimer2.TabIndex = 5;
            this.mTimer2.TabStop = true;
            this.mTimer2.Text = "2";
            this.mTimer2.UseVisualStyleBackColor = true;
            // 
            // mTimer3
            // 
            this.mTimer3.AutoSize = true;
            this.mTimer3.Location = new System.Drawing.Point(386, 217);
            this.mTimer3.Name = "mTimer3";
            this.mTimer3.Size = new System.Drawing.Size(31, 17);
            this.mTimer3.TabIndex = 6;
            this.mTimer3.TabStop = true;
            this.mTimer3.Text = "3";
            this.mTimer3.UseVisualStyleBackColor = true;
            // 
            // mTimer4
            // 
            this.mTimer4.AutoSize = true;
            this.mTimer4.Location = new System.Drawing.Point(456, 217);
            this.mTimer4.Name = "mTimer4";
            this.mTimer4.Size = new System.Drawing.Size(31, 17);
            this.mTimer4.TabIndex = 7;
            this.mTimer4.TabStop = true;
            this.mTimer4.Text = "4";
            this.mTimer4.UseVisualStyleBackColor = true;
            // 
            // playButton
            // 
            this.playButton.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(493, 185);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 50);
            this.playButton.TabIndex = 8;
            this.playButton.Text = "PLAY";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // metronomeBackgroundWorker
            // 
            this.metronomeBackgroundWorker.WorkerSupportsCancellation = true;
            this.metronomeBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.MetronomeBackgroundWorker_DoWork);
            this.metronomeBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.MetronomeBackgroundWorker_Completed);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.mTimer4);
            this.Controls.Add(this.mTimer3);
            this.Controls.Add(this.mTimer2);
            this.Controls.Add(this.mTimer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BPMinput);
            this.Controls.Add(this.setBPM);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button setBPM;
        private System.Windows.Forms.TextBox BPMinput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton mTimer1;
        private System.Windows.Forms.RadioButton mTimer2;
        private System.Windows.Forms.RadioButton mTimer3;
        private System.Windows.Forms.RadioButton mTimer4;
        private System.Windows.Forms.Button playButton;
        private System.ComponentModel.BackgroundWorker metronomeBackgroundWorker;
    }
}

