namespace WinForms
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
            fname = new TextBox();
            address = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            sname = new TextBox();
            label3 = new Label();
            label4 = new Label();
            mob = new TextBox();
            label5 = new Label();
            email = new TextBox();
            label6 = new Label();
            confirmPassword = new TextBox();
            label7 = new Label();
            password = new TextBox();
            register = new Button();
            label8 = new Label();
            SuspendLayout();
            // 
            // fname
            // 
            fname.Location = new Point(273, 126);
            fname.Name = "fname";
            fname.Size = new Size(100, 23);
            fname.TabIndex = 0;
            fname.TextChanged += textBox1_TextChanged;
            // 
            // address
            // 
            address.Location = new Point(273, 265);
            address.Name = "address";
            address.Size = new Size(372, 67);
            address.TabIndex = 1;
            address.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Azonix", 9F);
            label1.Location = new Point(163, 134);
            label1.Name = "label1";
            label1.Size = new Size(91, 12);
            label1.TabIndex = 2;
            label1.Text = "First Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Azonix", 9F);
            label2.Location = new Point(394, 134);
            label2.Name = "label2";
            label2.Size = new Size(105, 12);
            label2.TabIndex = 4;
            label2.Text = "Second Name";
            // 
            // sname
            // 
            sname.Location = new Point(545, 123);
            sname.Name = "sname";
            sname.Size = new Size(100, 23);
            sname.TabIndex = 3;
            sname.TextChanged += sname_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Azonix", 9F);
            label3.Location = new Point(163, 265);
            label3.Name = "label3";
            label3.Size = new Size(71, 12);
            label3.TabIndex = 5;
            label3.Text = "Address";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Azonix", 9F);
            label4.Location = new Point(394, 173);
            label4.Name = "label4";
            label4.Size = new Size(54, 12);
            label4.TabIndex = 9;
            label4.Text = "Mobile";
            // 
            // mob
            // 
            mob.Location = new Point(545, 162);
            mob.Name = "mob";
            mob.Size = new Size(100, 23);
            mob.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Azonix", 9F);
            label5.Location = new Point(163, 173);
            label5.Name = "label5";
            label5.Size = new Size(45, 12);
            label5.TabIndex = 7;
            label5.Text = "Email";
            label5.Click += label5_Click;
            // 
            // email
            // 
            email.Location = new Point(273, 165);
            email.Name = "email";
            email.Size = new Size(100, 23);
            email.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Azonix", 9F);
            label6.Location = new Point(394, 211);
            label6.Name = "label6";
            label6.Size = new Size(141, 12);
            label6.TabIndex = 13;
            label6.Text = "Confirm Password";
            label6.Click += label6_Click;
            // 
            // confirmPassword
            // 
            confirmPassword.Location = new Point(545, 200);
            confirmPassword.Name = "confirmPassword";
            confirmPassword.PasswordChar = '*';
            confirmPassword.Size = new Size(100, 23);
            confirmPassword.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Azonix", 9F);
            label7.Location = new Point(163, 211);
            label7.Name = "label7";
            label7.Size = new Size(76, 12);
            label7.TabIndex = 11;
            label7.Text = "Password";
            // 
            // password
            // 
            password.Location = new Point(273, 203);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(100, 23);
            password.TabIndex = 10;
            // 
            // register
            // 
            register.BackColor = Color.Red;
            register.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            register.Location = new Point(545, 349);
            register.Name = "register";
            register.Size = new Size(100, 30);
            register.TabIndex = 14;
            register.Text = "Register";
            register.UseVisualStyleBackColor = false;
            register.Click += register_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Glitch Inside", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(163, 48);
            label8.Name = "label8";
            label8.Size = new Size(490, 37);
            label8.TabIndex = 15;
            label8.Text = "REGISTRATION FORM";
            label8.Click += label8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            ClientSize = new Size(800, 459);
            Controls.Add(label8);
            Controls.Add(register);
            Controls.Add(label6);
            Controls.Add(confirmPassword);
            Controls.Add(label7);
            Controls.Add(password);
            Controls.Add(label4);
            Controls.Add(mob);
            Controls.Add(label5);
            Controls.Add(email);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(sname);
            Controls.Add(label1);
            Controls.Add(address);
            Controls.Add(fname);
            ForeColor = SystemColors.ControlLightLight;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox fname;
        private RichTextBox address;
        private Label label1;
        private Label label2;
        private TextBox sname;
        private Label label3;
        private Label label4;
        private TextBox mob;
        private Label label5;
        private TextBox email;
        private Label label6;
        private TextBox confirmPassword;
        private Label label7;
        private TextBox password;
        private Button register;
        private Label label8;
    }
}
