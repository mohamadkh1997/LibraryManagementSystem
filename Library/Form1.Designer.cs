namespace Library
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            user = new TextBox();
            pass = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            button2 = new Button();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            error = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.MediumTurquoise;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(97, 507);
            button1.Name = "button1";
            button1.Size = new Size(376, 53);
            button1.TabIndex = 1;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSeaGreen;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.ForeColor = SystemColors.Desktop;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(504, 0);
            button3.Name = "button3";
            button3.Size = new Size(50, 50);
            button3.TabIndex = 4;
            button3.TextImageRelation = TextImageRelation.ImageAboveText;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(199, 64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 159);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // user
            // 
            user.BackColor = Color.LightSeaGreen;
            user.BorderStyle = BorderStyle.None;
            user.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            user.ForeColor = SystemColors.Window;
            user.Location = new Point(184, 277);
            user.Name = "user";
            user.Size = new Size(289, 39);
            user.TabIndex = 6;
            // 
            // pass
            // 
            pass.BackColor = Color.LightSeaGreen;
            pass.BorderStyle = BorderStyle.None;
            pass.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pass.ForeColor = SystemColors.HighlightText;
            pass.Location = new Point(184, 351);
            pass.Name = "pass";
            pass.Size = new Size(289, 36);
            pass.TabIndex = 7;
            pass.TextChanged += pass_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(97, 276);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(72, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(97, 349);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(72, 39);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Honeydew;
            panel1.Location = new Point(184, 318);
            panel1.Name = "panel1";
            panel1.Size = new Size(289, 1);
            panel1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Honeydew;
            panel2.Location = new Point(184, 394);
            panel2.Name = "panel2";
            panel2.Size = new Size(289, 1);
            panel2.TabIndex = 11;
            // 
            // button2
            // 
            button2.BackColor = Color.MediumTurquoise;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(97, 434);
            button2.Name = "button2";
            button2.Size = new Size(376, 53);
            button2.TabIndex = 12;
            button2.Text = "Sign in";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // error
            // 
            error.AutoSize = true;
            error.Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            error.ForeColor = SystemColors.MenuText;
            error.Location = new Point(97, 572);
            error.Name = "error";
            error.Size = new Size(0, 32);
            error.TabIndex = 13;
            error.Click += error_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(552, 661);
            Controls.Add(error);
            Controls.Add(button2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pass);
            Controls.Add(user);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button1);
            ForeColor = SystemColors.MenuHighlight;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Library";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button3;
        private PictureBox pictureBox1;
        private TextBox user;
        private TextBox pass;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel1;
        private Panel panel2;
        private Button button2;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private Label error;
    }
}
