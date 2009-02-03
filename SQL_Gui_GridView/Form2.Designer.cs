namespace SQL_Gui_GridView
{
    partial class Form2
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
            this.serverip_Label = new System.Windows.Forms.Label();
            this.username_Label = new System.Windows.Forms.Label();
            this.Passwort_Label = new System.Windows.Forms.Label();
            this.ip_textBox1 = new System.Windows.Forms.TextBox();
            this.user_textBox2 = new System.Windows.Forms.TextBox();
            this.pw_textBox3 = new System.Windows.Forms.TextBox();
            this.server_button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serverip_Label
            // 
            this.serverip_Label.AutoSize = true;
            this.serverip_Label.Location = new System.Drawing.Point(31, 21);
            this.serverip_Label.Name = "serverip_Label";
            this.serverip_Label.Size = new System.Drawing.Size(20, 13);
            this.serverip_Label.TabIndex = 0;
            this.serverip_Label.Text = "IP:";
            // 
            // username_Label
            // 
            this.username_Label.AutoSize = true;
            this.username_Label.Location = new System.Drawing.Point(11, 47);
            this.username_Label.Name = "username_Label";
            this.username_Label.Size = new System.Drawing.Size(58, 13);
            this.username_Label.TabIndex = 1;
            this.username_Label.Text = "Username:";
            // 
            // Passwort_Label
            // 
            this.Passwort_Label.AutoSize = true;
            this.Passwort_Label.Location = new System.Drawing.Point(11, 73);
            this.Passwort_Label.Name = "Passwort_Label";
            this.Passwort_Label.Size = new System.Drawing.Size(56, 13);
            this.Passwort_Label.TabIndex = 2;
            this.Passwort_Label.Text = "Password:";
            // 
            // ip_textBox1
            // 
            this.ip_textBox1.Location = new System.Drawing.Point(75, 18);
            this.ip_textBox1.Name = "ip_textBox1";
            this.ip_textBox1.Size = new System.Drawing.Size(100, 20);
            this.ip_textBox1.TabIndex = 3;
            this.ip_textBox1.TextChanged += new System.EventHandler(this.ip_textBox1_TextChanged);
            // 
            // user_textBox2
            // 
            this.user_textBox2.Location = new System.Drawing.Point(75, 44);
            this.user_textBox2.Name = "user_textBox2";
            this.user_textBox2.Size = new System.Drawing.Size(100, 20);
            this.user_textBox2.TabIndex = 4;
            this.user_textBox2.TextChanged += new System.EventHandler(this.user_textBox2_TextChanged);
            // 
            // pw_textBox3
            // 
            this.pw_textBox3.Location = new System.Drawing.Point(75, 70);
            this.pw_textBox3.Name = "pw_textBox3";
            this.pw_textBox3.Size = new System.Drawing.Size(100, 20);
            this.pw_textBox3.TabIndex = 5;
            this.pw_textBox3.TextChanged += new System.EventHandler(this.pw_textBox3_TextChanged);
            // 
            // server_button1
            // 
            this.server_button1.Location = new System.Drawing.Point(203, 42);
            this.server_button1.Name = "server_button1";
            this.server_button1.Size = new System.Drawing.Size(75, 23);
            this.server_button1.TabIndex = 6;
            this.server_button1.Text = "Save";
            this.server_button1.UseVisualStyleBackColor = true;
            this.server_button1.Click += new System.EventHandler(this.server_button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 129);
            this.Controls.Add(this.server_button1);
            this.Controls.Add(this.pw_textBox3);
            this.Controls.Add(this.user_textBox2);
            this.Controls.Add(this.ip_textBox1);
            this.Controls.Add(this.Passwort_Label);
            this.Controls.Add(this.username_Label);
            this.Controls.Add(this.serverip_Label);
            this.Name = "Form2";
            this.Text = "SQL Server Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label serverip_Label;
        private System.Windows.Forms.Label username_Label;
        private System.Windows.Forms.Label Passwort_Label;
        private System.Windows.Forms.TextBox ip_textBox1;
        private System.Windows.Forms.TextBox user_textBox2;
        private System.Windows.Forms.TextBox pw_textBox3;
        private System.Windows.Forms.Button server_button1;
    }
}