namespace MMI
{
    partial class mainForm
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
            this.components = new System.ComponentModel.Container();
            this.txtB_IdGoogl = new System.Windows.Forms.TextBox();
            this.txtB_IdFacebook = new System.Windows.Forms.TextBox();
            this.rTxtB_FacebookToken = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rTxtB_MissionResult = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtB_IdMission = new System.Windows.Forms.TextBox();
            this.button_Start = new System.Windows.Forms.Button();
            this.button_Stop = new System.Windows.Forms.Button();
            this.txtB_ENConsume = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkB_loop = new System.Windows.Forms.CheckBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.button_save = new System.Windows.Forms.Button();
            this.timer_loop = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label_MissionDone = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtB_NbrRepeat = new System.Windows.Forms.TextBox();
            this.label_timeleft = new System.Windows.Forms.Label();
            this.timer_count = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtB_IdGoogl
            // 
            this.txtB_IdGoogl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtB_IdGoogl.Location = new System.Drawing.Point(131, 42);
            this.txtB_IdGoogl.Name = "txtB_IdGoogl";
            this.txtB_IdGoogl.Size = new System.Drawing.Size(224, 20);
            this.txtB_IdGoogl.TabIndex = 0;
            this.txtB_IdGoogl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtB_IdFacebook
            // 
            this.txtB_IdFacebook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtB_IdFacebook.Location = new System.Drawing.Point(131, 68);
            this.txtB_IdFacebook.Name = "txtB_IdFacebook";
            this.txtB_IdFacebook.Size = new System.Drawing.Size(224, 20);
            this.txtB_IdFacebook.TabIndex = 2;
            this.txtB_IdFacebook.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rTxtB_FacebookToken
            // 
            this.rTxtB_FacebookToken.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rTxtB_FacebookToken.Cursor = System.Windows.Forms.Cursors.Default;
            this.rTxtB_FacebookToken.Location = new System.Drawing.Point(131, 94);
            this.rTxtB_FacebookToken.Name = "rTxtB_FacebookToken";
            this.rTxtB_FacebookToken.Size = new System.Drawing.Size(224, 89);
            this.rTxtB_FacebookToken.TabIndex = 3;
            this.rTxtB_FacebookToken.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Facebook ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Facebook Token";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Google advertiser ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(373, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mission";
            // 
            // rTxtB_MissionResult
            // 
            this.rTxtB_MissionResult.BackColor = System.Drawing.SystemColors.Control;
            this.rTxtB_MissionResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rTxtB_MissionResult.Cursor = System.Windows.Forms.Cursors.Default;
            this.rTxtB_MissionResult.Location = new System.Drawing.Point(376, 94);
            this.rTxtB_MissionResult.Name = "rTxtB_MissionResult";
            this.rTxtB_MissionResult.Size = new System.Drawing.Size(265, 89);
            this.rTxtB_MissionResult.TabIndex = 9;
            this.rTxtB_MissionResult.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(373, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mission results";
            // 
            // txtB_IdMission
            // 
            this.txtB_IdMission.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtB_IdMission.Location = new System.Drawing.Point(421, 42);
            this.txtB_IdMission.Name = "txtB_IdMission";
            this.txtB_IdMission.Size = new System.Drawing.Size(220, 20);
            this.txtB_IdMission.TabIndex = 11;
            this.txtB_IdMission.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_Start
            // 
            this.button_Start.Location = new System.Drawing.Point(15, 286);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(134, 23);
            this.button_Start.TabIndex = 12;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // button_Stop
            // 
            this.button_Stop.Location = new System.Drawing.Point(155, 286);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new System.Drawing.Size(134, 23);
            this.button_Stop.TabIndex = 13;
            this.button_Stop.Text = "Stop";
            this.button_Stop.UseVisualStyleBackColor = true;
            this.button_Stop.Click += new System.EventHandler(this.button_Stop_Click);
            // 
            // txtB_ENConsume
            // 
            this.txtB_ENConsume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtB_ENConsume.Location = new System.Drawing.Point(131, 189);
            this.txtB_ENConsume.Name = "txtB_ENConsume";
            this.txtB_ENConsume.Size = new System.Drawing.Size(54, 20);
            this.txtB_ENConsume.TabIndex = 14;
            this.txtB_ENConsume.Text = "0";
            this.txtB_ENConsume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Energy cost by mission";
            // 
            // chkB_loop
            // 
            this.chkB_loop.AutoSize = true;
            this.chkB_loop.Location = new System.Drawing.Point(191, 192);
            this.chkB_loop.Name = "chkB_loop";
            this.chkB_loop.Size = new System.Drawing.Size(50, 17);
            this.chkB_loop.TabIndex = 16;
            this.chkB_loop.Text = "Loop";
            this.chkB_loop.UseVisualStyleBackColor = true;
            this.chkB_loop.CheckedChanged += new System.EventHandler(this.chkB_loop_CheckedChanged);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(326, 156);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(29, 27);
            this.webBrowser1.TabIndex = 17;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(295, 286);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(134, 23);
            this.button_save.TabIndex = 18;
            this.button_save.Text = "Save data";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // timer_loop
            // 
            this.timer_loop.Interval = 1000;
            this.timer_loop.Tick += new System.EventHandler(this.timer_loop_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 12);
            this.progressBar1.Maximum = 60;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(629, 19);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 19;
            this.progressBar1.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Missions done";
            // 
            // label_MissionDone
            // 
            this.label_MissionDone.AutoSize = true;
            this.label_MissionDone.Location = new System.Drawing.Point(152, 257);
            this.label_MissionDone.Name = "label_MissionDone";
            this.label_MissionDone.Size = new System.Drawing.Size(19, 13);
            this.label_MissionDone.TabIndex = 21;
            this.label_MissionDone.Text = "00";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(191, 218);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 17);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.Text = "repeat";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Nbr of repeats";
            // 
            // txtB_NbrRepeat
            // 
            this.txtB_NbrRepeat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtB_NbrRepeat.Location = new System.Drawing.Point(131, 215);
            this.txtB_NbrRepeat.Name = "txtB_NbrRepeat";
            this.txtB_NbrRepeat.Size = new System.Drawing.Size(54, 20);
            this.txtB_NbrRepeat.TabIndex = 22;
            this.txtB_NbrRepeat.Text = "0";
            this.txtB_NbrRepeat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_timeleft
            // 
            this.label_timeleft.AutoSize = true;
            this.label_timeleft.Location = new System.Drawing.Point(273, 191);
            this.label_timeleft.Name = "label_timeleft";
            this.label_timeleft.Size = new System.Drawing.Size(76, 13);
            this.label_timeleft.TabIndex = 25;
            this.label_timeleft.Text = "00 Minutes left";
            // 
            // timer_count
            // 
            this.timer_count.Interval = 65000;
            this.timer_count.Tick += new System.EventHandler(this.timer_count_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 321);
            this.Controls.Add(this.label_timeleft);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtB_NbrRepeat);
            this.Controls.Add(this.label_MissionDone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.chkB_loop);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtB_ENConsume);
            this.Controls.Add(this.button_Stop);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.txtB_IdMission);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rTxtB_MissionResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rTxtB_FacebookToken);
            this.Controls.Add(this.txtB_IdFacebook);
            this.Controls.Add(this.txtB_IdGoogl);
            this.Controls.Add(this.webBrowser1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mila\'s bot Interface @by Dervich ^^";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_keydown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtB_IdGoogl;
        private System.Windows.Forms.TextBox txtB_IdFacebook;
        private System.Windows.Forms.RichTextBox rTxtB_FacebookToken;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rTxtB_MissionResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtB_IdMission;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Button button_Stop;
        private System.Windows.Forms.TextBox txtB_ENConsume;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkB_loop;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Timer timer_loop;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_MissionDone;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtB_NbrRepeat;
        private System.Windows.Forms.Label label_timeleft;
        private System.Windows.Forms.Timer timer_count;
    }
}

