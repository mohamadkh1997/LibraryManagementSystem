namespace Library
{
    partial class detailForm
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
            panel1 = new Panel();
            label1 = new Label();
            button1 = new Button();
            datbirth = new DateTimePicker();
            address = new RichTextBox();
            email = new TextBox();
            phnumber = new TextBox();
            lname = new TextBox();
            fname = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label7 = new Label();
            label8 = new Label();
            isactive = new ComboBox();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(585, 125);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(257, 59);
            label1.Name = "label1";
            label1.Size = new Size(91, 21);
            label1.TabIndex = 0;
            label1.Text = "Detail Info";
            // 
            // button1
            // 
            button1.Location = new Point(278, 560);
            button1.Name = "button1";
            button1.Size = new Size(222, 49);
            button1.TabIndex = 26;
            button1.Text = "Save Data";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // datbirth
            // 
            datbirth.Location = new Point(278, 465);
            datbirth.Name = "datbirth";
            datbirth.Size = new Size(222, 23);
            datbirth.TabIndex = 25;
            // 
            // address
            // 
            address.Location = new Point(278, 353);
            address.Name = "address";
            address.Size = new Size(222, 96);
            address.TabIndex = 24;
            address.Text = "";
            // 
            // email
            // 
            email.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            email.Location = new Point(278, 301);
            email.Name = "email";
            email.Size = new Size(222, 33);
            email.TabIndex = 23;
            // 
            // phnumber
            // 
            phnumber.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phnumber.Location = new Point(278, 254);
            phnumber.Name = "phnumber";
            phnumber.Size = new Size(222, 33);
            phnumber.TabIndex = 22;
            // 
            // lname
            // 
            lname.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lname.Location = new Point(278, 208);
            lname.Name = "lname";
            lname.Size = new Size(222, 33);
            lname.TabIndex = 21;
            // 
            // fname
            // 
            fname.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fname.Location = new Point(278, 165);
            fname.Name = "fname";
            fname.Size = new Size(222, 33);
            fname.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(86, 351);
            label6.Name = "label6";
            label6.Size = new Size(66, 21);
            label6.TabIndex = 19;
            label6.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(86, 465);
            label5.Name = "label5";
            label5.Size = new Size(97, 21);
            label5.TabIndex = 18;
            label5.Text = "Date of Birth";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(86, 305);
            label4.Name = "label4";
            label4.Size = new Size(55, 21);
            label4.TabIndex = 17;
            label4.Text = "Email*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(86, 260);
            label3.Name = "label3";
            label3.Size = new Size(116, 21);
            label3.TabIndex = 16;
            label3.Text = "Phone Number";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(86, 216);
            label7.Name = "label7";
            label7.Size = new Size(91, 21);
            label7.TabIndex = 15;
            label7.Text = "Last Name*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(86, 171);
            label8.Name = "label8";
            label8.Size = new Size(93, 21);
            label8.TabIndex = 14;
            label8.Text = "First Name*";
            // 
            // isactive
            // 
            isactive.DisplayMember = "dsds";
            isactive.DropDownStyle = ComboBoxStyle.DropDownList;
            isactive.FormattingEnabled = true;
            isactive.Location = new Point(278, 511);
            isactive.Name = "isactive";
            isactive.Size = new Size(222, 23);
            isactive.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(86, 513);
            label2.Name = "label2";
            label2.Size = new Size(149, 21);
            label2.TabIndex = 28;
            label2.Text = "Member Is Active is ";
            // 
            // detailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 687);
            Controls.Add(label2);
            Controls.Add(isactive);
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
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(panel1);
            Name = "detailForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "detailForm";
            Load += detailForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button1;
        private DateTimePicker datbirth;
        private RichTextBox address;
        private TextBox email;
        private TextBox phnumber;
        private TextBox lname;
        private TextBox fname;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label7;
        private Label label8;
        private ComboBox isactive;
        private Label label2;
    }
}