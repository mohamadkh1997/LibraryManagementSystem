namespace Library
{
    partial class BookPlus
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
            label2 = new Label();
            title = new TextBox();
            author = new TextBox();
            label3 = new Label();
            year = new TextBox();
            label4 = new Label();
            genre = new TextBox();
            label5 = new Label();
            label6 = new Label();
            description = new RichTextBox();
            label7 = new Label();
            location = new ComboBox();
            addbook = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(671, 65);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(275, 31);
            label1.Name = "label1";
            label1.Size = new Size(124, 21);
            label1.TabIndex = 0;
            label1.Text = "Add new Book ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 87);
            label2.Name = "label2";
            label2.Size = new Size(36, 17);
            label2.TabIndex = 1;
            label2.Text = "Title";
            // 
            // title
            // 
            title.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            title.Location = new Point(78, 81);
            title.Name = "title";
            title.Size = new Size(587, 29);
            title.TabIndex = 2;
            // 
            // author
            // 
            author.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            author.Location = new Point(78, 122);
            author.Name = "author";
            author.Size = new Size(587, 29);
            author.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 128);
            label3.Name = "label3";
            label3.Size = new Size(51, 17);
            label3.TabIndex = 3;
            label3.Text = "Author";
            // 
            // year
            // 
            year.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            year.Location = new Point(146, 167);
            year.Name = "year";
            year.Size = new Size(140, 29);
            year.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 173);
            label4.Name = "label4";
            label4.Size = new Size(104, 17);
            label4.TabIndex = 5;
            label4.Text = "Publishing Year";
            // 
            // genre
            // 
            genre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            genre.Location = new Point(78, 211);
            genre.Name = "genre";
            genre.Size = new Size(587, 29);
            genre.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(22, 217);
            label5.Name = "label5";
            label5.Size = new Size(44, 17);
            label5.TabIndex = 7;
            label5.Text = "Genre";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(22, 263);
            label6.Name = "label6";
            label6.Size = new Size(278, 17);
            label6.TabIndex = 9;
            label6.Text = "Description(No more than 250  charachters)";
            // 
            // description
            // 
            description.Location = new Point(300, 262);
            description.Name = "description";
            description.Size = new Size(365, 158);
            description.TabIndex = 10;
            description.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(22, 460);
            label7.Name = "label7";
            label7.Size = new Size(90, 17);
            label7.TabIndex = 11;
            label7.Text = "Located shelf";
            // 
            // location
            // 
            location.DropDownStyle = ComboBoxStyle.DropDownList;
            location.FormattingEnabled = true;
            location.Location = new Point(146, 459);
            location.Name = "location";
            location.Size = new Size(154, 23);
            location.TabIndex = 12;
            // 
            // addbook
            // 
            addbook.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addbook.Location = new Point(12, 599);
            addbook.Name = "addbook";
            addbook.Size = new Size(653, 36);
            addbook.TabIndex = 13;
            addbook.Text = "Add Book";
            addbook.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumSpringGreen;
            panel2.Location = new Point(78, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(522, 1);
            panel2.TabIndex = 14;
            // 
            // BookPlus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 736);
            Controls.Add(panel2);
            Controls.Add(addbook);
            Controls.Add(location);
            Controls.Add(label7);
            Controls.Add(description);
            Controls.Add(label6);
            Controls.Add(genre);
            Controls.Add(label5);
            Controls.Add(year);
            Controls.Add(label4);
            Controls.Add(author);
            Controls.Add(label3);
            Controls.Add(title);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "BookPlus";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookPlus";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox title;
        private TextBox author;
        private Label label3;
        private TextBox year;
        private Label label4;
        private TextBox genre;
        private Label label5;
        private Label label6;
        private RichTextBox description;
        private Label label7;
        private ComboBox location;
        private Button addbook;
        private Panel panel2;
    }
}