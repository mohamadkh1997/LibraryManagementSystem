namespace Library
{
    partial class Books
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
            panel4 = new Panel();
            button4 = new Button();
            button3 = new Button();
            panel3 = new Panel();
            button2 = new Button();
            label8 = new Label();
            textBox8 = new TextBox();
            bookshearch = new Button();
            shelf = new TextBox();
            genre = new TextBox();
            year = new TextBox();
            author = new TextBox();
            name = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            Booklist = new DataGridView();
            panel5 = new Panel();
            Shelflist = new DataGridView();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Booklist).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Shelflist).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Beige;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(bookshearch);
            panel1.Controls.Add(shelf);
            panel1.Controls.Add(genre);
            panel1.Controls.Add(year);
            panel1.Controls.Add(author);
            panel1.Controls.Add(name);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1204, 283);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(button4);
            panel4.Controls.Add(button3);
            panel4.Location = new Point(537, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(255, 274);
            panel4.TabIndex = 12;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(20, 85);
            button4.Name = "button4";
            button4.Size = new Size(220, 50);
            button4.TabIndex = 1;
            button4.Text = "New Shelf";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(20, 12);
            button3.Name = "button3";
            button3.Size = new Size(220, 50);
            button3.TabIndex = 0;
            button3.Text = "New Book";
            button3.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(button2);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(textBox8);
            panel3.Location = new Point(798, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(394, 280);
            panel3.TabIndex = 11;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(28, 94);
            button2.Name = "button2";
            button2.Size = new Size(345, 36);
            button2.TabIndex = 16;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(28, 27);
            label8.Name = "label8";
            label8.Size = new Size(108, 21);
            label8.TabIndex = 12;
            label8.Text = "Shelf Location";
            // 
            // textBox8
            // 
            textBox8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox8.Location = new Point(170, 24);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(203, 29);
            textBox8.TabIndex = 15;
            // 
            // bookshearch
            // 
            bookshearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bookshearch.Location = new Point(11, 249);
            bookshearch.Name = "bookshearch";
            bookshearch.Size = new Size(320, 28);
            bookshearch.TabIndex = 10;
            bookshearch.Text = "Search";
            bookshearch.UseVisualStyleBackColor = true;
            // 
            // shelf
            // 
            shelf.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            shelf.Location = new Point(153, 204);
            shelf.Name = "shelf";
            shelf.Size = new Size(178, 29);
            shelf.TabIndex = 9;
            // 
            // genre
            // 
            genre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            genre.Location = new Point(153, 155);
            genre.Name = "genre";
            genre.Size = new Size(178, 29);
            genre.TabIndex = 8;
            // 
            // year
            // 
            year.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            year.Location = new Point(153, 109);
            year.Name = "year";
            year.Size = new Size(178, 29);
            year.TabIndex = 7;
            // 
            // author
            // 
            author.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            author.Location = new Point(153, 62);
            author.Name = "author";
            author.Size = new Size(178, 29);
            author.TabIndex = 6;
            // 
            // name
            // 
            name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            name.Location = new Point(153, 15);
            name.Name = "name";
            name.Size = new Size(178, 29);
            name.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(11, 207);
            label5.Name = "label5";
            label5.Size = new Size(45, 21);
            label5.TabIndex = 4;
            label5.Text = "Shelf";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(11, 158);
            label4.Name = "label4";
            label4.Size = new Size(52, 21);
            label4.TabIndex = 3;
            label4.Text = "Genre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(11, 112);
            label3.Name = "label3";
            label3.Size = new Size(117, 21);
            label3.TabIndex = 2;
            label3.Text = "Publishing Year";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(11, 65);
            label2.Name = "label2";
            label2.Size = new Size(58, 21);
            label2.TabIndex = 1;
            label2.Text = "Author";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 18);
            label1.Name = "label1";
            label1.Size = new Size(91, 21);
            label1.TabIndex = 0;
            label1.Text = "Book Name";
            // 
            // panel2
            // 
            panel2.Controls.Add(Booklist);
            panel2.Location = new Point(1, 283);
            panel2.Name = "panel2";
            panel2.Size = new Size(1073, 376);
            panel2.TabIndex = 1;
            // 
            // Booklist
            // 
            Booklist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Booklist.Location = new Point(3, 6);
            Booklist.Name = "Booklist";
            Booklist.Size = new Size(1073, 367);
            Booklist.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(Shelflist);
            panel5.Location = new Point(1080, 283);
            panel5.Name = "panel5";
            panel5.Size = new Size(116, 379);
            panel5.TabIndex = 2;
            // 
            // Shelflist
            // 
            Shelflist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Shelflist.Location = new Point(3, 3);
            Shelflist.Name = "Shelflist";
            Shelflist.Size = new Size(110, 373);
            Shelflist.TabIndex = 0;
            // 
            // Books
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1205, 705);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Books";
            Text = "Books";
            Load += Books_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Booklist).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Shelflist).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button bookshearch;
        private TextBox shelf;
        private TextBox genre;
        private TextBox year;
        private TextBox author;
        private TextBox name;
        private Label label5;
        private Panel panel3;
        private Panel panel2;
        private Panel panel4;
        private Button button4;
        private Button button3;
        private Button button2;
        private Label label8;
        private TextBox textBox8;
        private Panel panel5;
        private DataGridView Booklist;
        private DataGridView Shelflist;
    }
}