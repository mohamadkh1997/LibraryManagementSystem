namespace Library
{
    partial class Addbook
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            fname = new TextBox();
            lname = new TextBox();
            phnumber = new TextBox();
            email = new TextBox();
            address = new RichTextBox();
            datbirth = new DateTimePicker();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.add_user;
            pictureBox1.Location = new Point(216, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 155);
            label1.Name = "label1";
            label1.Size = new Size(93, 21);
            label1.TabIndex = 1;
            label1.Text = "First Name*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(38, 200);
            label2.Name = "label2";
            label2.Size = new Size(91, 21);
            label2.TabIndex = 2;
            label2.Text = "Last Name*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(38, 244);
            label3.Name = "label3";
            label3.Size = new Size(116, 21);
            label3.TabIndex = 3;
            label3.Text = "Phone Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(38, 289);
            label4.Name = "label4";
            label4.Size = new Size(55, 21);
            label4.TabIndex = 4;
            label4.Text = "Email*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(38, 471);
            label5.Name = "label5";
            label5.Size = new Size(97, 21);
            label5.TabIndex = 5;
            label5.Text = "Date of Birth";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(38, 335);
            label6.Name = "label6";
            label6.Size = new Size(66, 21);
            label6.TabIndex = 6;
            label6.Text = "Address";
            // 
            // fname
            // 
            fname.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fname.Location = new Point(230, 149);
            fname.Name = "fname";
            fname.Size = new Size(222, 33);
            fname.TabIndex = 7;
            // 
            // lname
            // 
            lname.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lname.Location = new Point(230, 192);
            lname.Name = "lname";
            lname.Size = new Size(222, 33);
            lname.TabIndex = 8;
            // 
            // phnumber
            // 
            phnumber.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phnumber.Location = new Point(230, 238);
            phnumber.Name = "phnumber";
            phnumber.Size = new Size(222, 33);
            phnumber.TabIndex = 9;
            // 
            // email
            // 
            email.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            email.Location = new Point(230, 285);
            email.Name = "email";
            email.Size = new Size(222, 33);
            email.TabIndex = 10;
            // 
            // address
            // 
            address.Location = new Point(230, 337);
            address.Name = "address";
            address.Size = new Size(222, 96);
            address.TabIndex = 11;
            address.Text = "";
            // 
            // datbirth
            // 
            datbirth.Location = new Point(230, 471);
            datbirth.Name = "datbirth";
            datbirth.Size = new Size(222, 23);
            datbirth.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(230, 526);
            button1.Name = "button1";
            button1.Size = new Size(222, 49);
            button1.TabIndex = 13;
            button1.Text = "Add Member";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Addbook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 674);
            Controls.Add(button1);
            Controls.Add(datbirth);
            Controls.Add(address);
            Controls.Add(email);
            Controls.Add(phnumber);
            Controls.Add(lname);
            Controls.Add(fname);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Addbook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Addbook";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox fname;
        private TextBox lname;
        private TextBox phnumber;
        private TextBox email;
        private RichTextBox address;
        private DateTimePicker datbirth;
        private Button button1;
    }
}