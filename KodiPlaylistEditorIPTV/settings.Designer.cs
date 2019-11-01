﻿namespace PlaylistEditor
{
    partial class settings
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
            this.button_ok = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.textBox_Port = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox_w = new System.Windows.Forms.CheckBox();
            this.textBox_hot = new System.Windows.Forms.TextBox();
            this.checkBox_a = new System.Windows.Forms.CheckBox();
            this.checkBox_s = new System.Windows.Forms.CheckBox();
            this.checkBox_c = new System.Windows.Forms.CheckBox();
            this.checkBox_vlc = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_ok
            // 
            this.button_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ok.Location = new System.Drawing.Point(266, 389);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(101, 34);
            this.button_ok.TabIndex = 3;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.Location = new System.Drawing.Point(119, 389);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(101, 34);
            this.button_cancel.TabIndex = 4;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // textBox_Password
            // 
            this.textBox_Password.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Password.Location = new System.Drawing.Point(202, 203);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(167, 27);
            this.textBox_Password.TabIndex = 32;
            this.toolTip1.SetToolTip(this.textBox_Password, "IP of nfs connected drive");
            // 
            // textBox_Username
            // 
            this.textBox_Username.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Username.Location = new System.Drawing.Point(202, 167);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(167, 27);
            this.textBox_Username.TabIndex = 31;
            this.textBox_Username.Text = "kodi";
            this.toolTip1.SetToolTip(this.textBox_Username, "IP of nfs connected drive");
            // 
            // textBox_Port
            // 
            this.textBox_Port.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_Port.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Port.Location = new System.Drawing.Point(202, 131);
            this.textBox_Port.Name = "textBox_Port";
            this.textBox_Port.Size = new System.Drawing.Size(167, 27);
            this.textBox_Port.TabIndex = 30;
            this.textBox_Port.Text = "8080";
            this.toolTip1.SetToolTip(this.textBox_Port, "IP of nfs connected drive");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(98, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Password";
            this.toolTip1.SetToolTip(this.label6, "nfs path on Kodi system");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(98, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Username";
            this.toolTip1.SetToolTip(this.label5, "nfs path on Kodi system");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(98, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Port";
            this.toolTip1.SetToolTip(this.label4, "nfs path on Kodi system");
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(202, 93);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(167, 27);
            this.textBox2.TabIndex = 26;
            this.textBox2.Text = "192.168.178.91";
            this.toolTip1.SetToolTip(this.textBox2, "IP of nfs connected drive");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(98, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Kodi IP";
            this.toolTip1.SetToolTip(this.label3, "nfs path on Kodi system");
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(287, 144);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(60, 27);
            this.textBox1.TabIndex = 9;
            this.toolTip1.SetToolTip(this.textBox1, "auto reset on open settings ");
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Remove first characters";
            this.toolTip1.SetToolTip(this.label1, "number of characters to delete");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = " on paste cells";
            this.toolTip1.SetToolTip(this.label2, "number of characters to delete");
            // 
            // checkBox_w
            // 
            this.checkBox_w.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_w.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_w.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBox_w.Location = new System.Drawing.Point(136, 192);
            this.checkBox_w.Name = "checkBox_w";
            this.checkBox_w.Size = new System.Drawing.Size(60, 24);
            this.checkBox_w.TabIndex = 23;
            this.checkBox_w.Text = "WIN";
            this.toolTip1.SetToolTip(this.checkBox_w, "Restart to take effect");
            this.checkBox_w.UseVisualStyleBackColor = true;
            // 
            // textBox_hot
            // 
            this.textBox_hot.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_hot.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_hot.Location = new System.Drawing.Point(255, 72);
            this.textBox_hot.MaxLength = 1;
            this.textBox_hot.Name = "textBox_hot";
            this.textBox_hot.Size = new System.Drawing.Size(33, 27);
            this.textBox_hot.TabIndex = 22;
            this.textBox_hot.Text = "I";
            this.textBox_hot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.textBox_hot, "Restart to take effect");
            this.textBox_hot.TextChanged += new System.EventHandler(this.textBox_hot_TextChanged);
            // 
            // checkBox_a
            // 
            this.checkBox_a.Checked = true;
            this.checkBox_a.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_a.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_a.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBox_a.Location = new System.Drawing.Point(137, 152);
            this.checkBox_a.Name = "checkBox_a";
            this.checkBox_a.Size = new System.Drawing.Size(59, 24);
            this.checkBox_a.TabIndex = 20;
            this.checkBox_a.Text = "ALT";
            this.toolTip1.SetToolTip(this.checkBox_a, "Restart to take effect");
            this.checkBox_a.UseVisualStyleBackColor = true;
            // 
            // checkBox_s
            // 
            this.checkBox_s.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_s.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_s.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBox_s.Location = new System.Drawing.Point(137, 113);
            this.checkBox_s.Name = "checkBox_s";
            this.checkBox_s.Size = new System.Drawing.Size(76, 24);
            this.checkBox_s.TabIndex = 19;
            this.checkBox_s.Text = "SHIFT";
            this.toolTip1.SetToolTip(this.checkBox_s, "Restart to take effect");
            this.checkBox_s.UseVisualStyleBackColor = true;
            // 
            // checkBox_c
            // 
            this.checkBox_c.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_c.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBox_c.Location = new System.Drawing.Point(137, 72);
            this.checkBox_c.Name = "checkBox_c";
            this.checkBox_c.Size = new System.Drawing.Size(72, 24);
            this.checkBox_c.TabIndex = 18;
            this.checkBox_c.Text = "CTRL";
            this.toolTip1.SetToolTip(this.checkBox_c, "Restart to take effect");
            this.checkBox_c.UseVisualStyleBackColor = true;
            // 
            // checkBox_vlc
            // 
            this.checkBox_vlc.Checked = true;
            this.checkBox_vlc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_vlc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_vlc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_vlc.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBox_vlc.Location = new System.Drawing.Point(182, 218);
            this.checkBox_vlc.Name = "checkBox_vlc";
            this.checkBox_vlc.Size = new System.Drawing.Size(145, 24);
            this.checkBox_vlc.TabIndex = 20;
            this.checkBox_vlc.Text = "VLC fullscreen";
            this.toolTip1.SetToolTip(this.checkBox_vlc, "Restart to take effect");
            this.checkBox_vlc.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-4, 13);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(475, 356);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DarkBlue;
            this.tabPage3.Controls.Add(this.checkBox_vlc);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.comboBox2);
            this.tabPage3.Controls.Add(this.comboBox1);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.ForeColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(467, 323);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "options";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(56, 222);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Player mode";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Name",
            "id",
            "Title",
            "logo",
            "Name2",
            "Link"});
            this.comboBox2.Location = new System.Drawing.Point(287, 73);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(80, 28);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.comboBox2.Click += new System.EventHandler(this.ComboBox_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Name",
            "id",
            "Title",
            "logo",
            "Name2",
            "Link"});
            this.comboBox1.Location = new System.Drawing.Point(287, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(81, 28);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.Click += new System.EventHandler(this.ComboBox_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Colum search duplicates";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Colum search";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkBlue;
            this.tabPage1.Controls.Add(this.textBox_Password);
            this.tabPage1.Controls.Add(this.textBox_Username);
            this.tabPage1.Controls.Add(this.textBox_Port);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(467, 323);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Kodi";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkBlue;
            this.tabPage2.Controls.Add(this.checkBox_w);
            this.tabPage2.Controls.Add(this.textBox_hot);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.checkBox_a);
            this.tabPage2.Controls.Add(this.checkBox_s);
            this.tabPage2.Controls.Add(this.checkBox_c);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(467, 323);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "Hotkey";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(31, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(392, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Import from Clipboard Hotkey (restart after change)";
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(467, 449);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "settings";
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.TextBox textBox_Port;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox checkBox_w;
        private System.Windows.Forms.TextBox textBox_hot;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox_a;
        private System.Windows.Forms.CheckBox checkBox_s;
        private System.Windows.Forms.CheckBox checkBox_c;
        private System.Windows.Forms.CheckBox checkBox_vlc;
        private System.Windows.Forms.Label label10;
    }
}