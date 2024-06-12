namespace Library
{
    partial class Members
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
            searchPanel = new Panel();
            button2 = new Button();
            searchfrompanel = new Panel();
            Phnumber = new TextBox();
            label4 = new Label();
            button1 = new Button();
            DateBirth = new DateTimePicker();
            Email = new TextBox();
            Lname = new TextBox();
            Fname = new TextBox();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            Labelname = new Label();
            Memberpanel = new Panel();
            Memberlist = new DataGridView();
            searchPanel.SuspendLayout();
            searchfrompanel.SuspendLayout();
            Memberpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Memberlist).BeginInit();
            SuspendLayout();
            // 
            // searchPanel
            // 
            searchPanel.BackColor = Color.WhiteSmoke;
            searchPanel.Controls.Add(button2);
            searchPanel.Controls.Add(searchfrompanel);
            searchPanel.Location = new Point(1, 1);
            searchPanel.Name = "searchPanel";
            searchPanel.Size = new Size(1158, 269);
            searchPanel.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(908, 11);
            button2.Name = "button2";
            button2.Size = new Size(230, 58);
            button2.TabIndex = 1;
            button2.Text = "Create New Memeber";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // searchfrompanel
            // 
            searchfrompanel.Controls.Add(Phnumber);
            searchfrompanel.Controls.Add(label4);
            searchfrompanel.Controls.Add(button1);
            searchfrompanel.Controls.Add(DateBirth);
            searchfrompanel.Controls.Add(Email);
            searchfrompanel.Controls.Add(Lname);
            searchfrompanel.Controls.Add(Fname);
            searchfrompanel.Controls.Add(label3);
            searchfrompanel.Controls.Add(label1);
            searchfrompanel.Controls.Add(label2);
            searchfrompanel.Controls.Add(Labelname);
            searchfrompanel.Location = new Point(0, 3);
            searchfrompanel.Name = "searchfrompanel";
            searchfrompanel.Size = new Size(902, 263);
            searchfrompanel.TabIndex = 0;
            // 
            // Phnumber
            // 
            Phnumber.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Phnumber.Location = new Point(157, 134);
            Phnumber.Name = "Phnumber";
            Phnumber.Size = new Size(243, 33);
            Phnumber.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(11, 137);
            label4.Name = "label4";
            label4.Size = new Size(140, 25);
            label4.TabIndex = 9;
            label4.Text = "Phone Number";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(11, 217);
            button1.Name = "button1";
            button1.Size = new Size(389, 36);
            button1.TabIndex = 8;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DateBirth
            // 
            DateBirth.Location = new Point(157, 177);
            DateBirth.Name = "DateBirth";
            DateBirth.Size = new Size(243, 23);
            DateBirth.TabIndex = 7;
            // 
            // Email
            // 
            Email.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Email.Location = new Point(157, 92);
            Email.Name = "Email";
            Email.Size = new Size(243, 33);
            Email.TabIndex = 6;
            // 
            // Lname
            // 
            Lname.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lname.Location = new Point(157, 52);
            Lname.Name = "Lname";
            Lname.Size = new Size(243, 33);
            Lname.TabIndex = 5;
            // 
            // Fname
            // 
            Fname.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Fname.Location = new Point(157, 14);
            Fname.Name = "Fname";
            Fname.Size = new Size(243, 33);
            Fname.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(11, 175);
            label3.Name = "label3";
            label3.Size = new Size(118, 25);
            label3.TabIndex = 3;
            label3.Text = "Date of Birth";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 95);
            label1.Name = "label1";
            label1.Size = new Size(58, 25);
            label1.TabIndex = 2;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(11, 55);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 1;
            label2.Text = "Last Name";
            // 
            // Labelname
            // 
            Labelname.AutoSize = true;
            Labelname.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Labelname.Location = new Point(11, 14);
            Labelname.Name = "Labelname";
            Labelname.Size = new Size(102, 25);
            Labelname.TabIndex = 0;
            Labelname.Text = "First Name";
            // 
            // Memberpanel
            // 
            Memberpanel.Controls.Add(Memberlist);
            Memberpanel.Location = new Point(1, 263);
            Memberpanel.Name = "Memberpanel";
            Memberpanel.Size = new Size(1148, 364);
            Memberpanel.TabIndex = 1;
            // 
            // Memberlist
            // 
            Memberlist.AllowUserToAddRows = false;
            Memberlist.AllowUserToDeleteRows = false;
            Memberlist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Memberlist.Location = new Point(3, 3);
            Memberlist.Name = "Memberlist";
            Memberlist.ReadOnly = true;
            Memberlist.Size = new Size(1142, 358);
            Memberlist.TabIndex = 0;
            Memberlist.CellContentClick += Memberlist_CellContentClick;
            // 
            // Members
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1151, 628);
            Controls.Add(Memberpanel);
            Controls.Add(searchPanel);
            Name = "Members";
            Text = "Manage Members";
            Load += Members_Load;
            searchPanel.ResumeLayout(false);
            searchfrompanel.ResumeLayout(false);
            searchfrompanel.PerformLayout();
            Memberpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Memberlist).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel searchPanel;
        private Panel Memberpanel;
        private DataGridView Memberlist;
        private Panel searchfrompanel;
        private Label label1;
        private Label label2;
        private Label Labelname;
        private TextBox Fname;
        private Label label3;
        private DateTimePicker DateBirth;
        private TextBox Email;
        private TextBox Lname;
        private Button button2;
        private Button button1;
        private TextBox Phnumber;
        private Label label4;
    }
}