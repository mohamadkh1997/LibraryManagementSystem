namespace Library
{
    partial class ModifyShelf
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
            save = new Button();
            description = new RichTextBox();
            location = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            title = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // save
            // 
            save.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            save.Location = new Point(3, 532);
            save.Name = "save";
            save.Size = new Size(406, 58);
            save.TabIndex = 11;
            save.Text = "Save";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // description
            // 
            description.Location = new Point(112, 256);
            description.Name = "description";
            description.Size = new Size(297, 175);
            description.TabIndex = 10;
            description.Text = "";
            // 
            // location
            // 
            location.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            location.Location = new Point(112, 170);
            location.Name = "location";
            location.Size = new Size(297, 29);
            location.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 256);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 8;
            label3.Text = "Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 174);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 7;
            label2.Text = "Location*";
            // 
            // panel1
            // 
            panel1.Controls.Add(title);
            panel1.Location = new Point(3, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(406, 100);
            panel1.TabIndex = 6;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.Location = new Point(128, 40);
            title.Name = "title";
            title.Size = new Size(81, 21);
            title.TabIndex = 0;
            title.Text = "edit shelf";
            // 
            // ModifyShelf
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 626);
            Controls.Add(save);
            Controls.Add(description);
            Controls.Add(location);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "ModifyShelf";
            Text = "ModifyShelf";
            Load += ModifyShelf_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button save;
        private RichTextBox description;
        private TextBox location;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private Label title;
    }
}