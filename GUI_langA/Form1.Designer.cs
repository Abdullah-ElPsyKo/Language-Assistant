namespace GUI_langA
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
            sidePanel = new Panel();
            label1 = new Label();
            translateBtn = new Button();
            listBtn = new Button();
            titlePanel = new Panel();
            Title = new Label();
            mainBody = new Panel();
            panel1 = new Panel();
            label6 = new Label();
            removeTranslation = new TextBox();
            remove = new Button();
            textBox5 = new TextBox();
            label5 = new Label();
            error = new Label();
            clipboard = new Button();
            confirm = new Button();
            menuStrip1 = new MenuStrip();
            toolStripComboBox1 = new ToolStripComboBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            menuStrip2 = new MenuStrip();
            toolStripComboBox2 = new ToolStripComboBox();
            save = new Button();
            reset = new Button();
            panel2 = new Panel();
            sidePanel.SuspendLayout();
            titlePanel.SuspendLayout();
            mainBody.SuspendLayout();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            menuStrip2.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // sidePanel
            // 
            sidePanel.BorderStyle = BorderStyle.FixedSingle;
            sidePanel.Controls.Add(label1);
            sidePanel.Controls.Add(translateBtn);
            sidePanel.Controls.Add(listBtn);
            sidePanel.Controls.Add(titlePanel);
            sidePanel.Dock = DockStyle.Left;
            sidePanel.Location = new Point(0, 0);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(220, 550);
            sidePanel.TabIndex = 0;
            sidePanel.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(77, 118);
            label1.Name = "label1";
            label1.Size = new Size(64, 23);
            label1.TabIndex = 3;
            label1.Text = "Menu";
            label1.Click += label1_Click_1;
            // 
            // translateBtn
            // 
            translateBtn.FlatStyle = FlatStyle.Flat;
            translateBtn.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            translateBtn.ForeColor = Color.White;
            translateBtn.Location = new Point(-1, 161);
            translateBtn.Name = "translateBtn";
            translateBtn.Size = new Size(220, 43);
            translateBtn.TabIndex = 2;
            translateBtn.Text = "Translate";
            translateBtn.UseVisualStyleBackColor = true;
            translateBtn.Click += button1_Click;
            // 
            // listBtn
            // 
            listBtn.FlatStyle = FlatStyle.Flat;
            listBtn.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            listBtn.ForeColor = Color.White;
            listBtn.Location = new Point(-1, 210);
            listBtn.Name = "listBtn";
            listBtn.Size = new Size(220, 43);
            listBtn.TabIndex = 3;
            listBtn.Text = "List";
            listBtn.UseVisualStyleBackColor = true;
            listBtn.Click += button2_Click;
            // 
            // titlePanel
            // 
            titlePanel.BorderStyle = BorderStyle.FixedSingle;
            titlePanel.Controls.Add(Title);
            titlePanel.Dock = DockStyle.Top;
            titlePanel.Location = new Point(0, 0);
            titlePanel.Name = "titlePanel";
            titlePanel.Size = new Size(218, 100);
            titlePanel.TabIndex = 1;
            titlePanel.Paint += panel2_Paint;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point);
            Title.ForeColor = Color.White;
            Title.Location = new Point(9, 37);
            Title.Name = "Title";
            Title.Size = new Size(198, 23);
            Title.TabIndex = 2;
            Title.Text = "Language Assistant";
            Title.Click += label1_Click;
            // 
            // mainBody
            // 
            mainBody.Controls.Add(panel1);
            mainBody.Controls.Add(error);
            mainBody.Controls.Add(clipboard);
            mainBody.Controls.Add(confirm);
            mainBody.Controls.Add(menuStrip1);
            mainBody.Controls.Add(textBox2);
            mainBody.Controls.Add(textBox1);
            mainBody.Controls.Add(label4);
            mainBody.Controls.Add(label3);
            mainBody.Controls.Add(label2);
            mainBody.Controls.Add(menuStrip2);
            mainBody.Controls.Add(save);
            mainBody.Controls.Add(reset);
            mainBody.Dock = DockStyle.Fill;
            mainBody.Location = new Point(0, 0);
            mainBody.Name = "mainBody";
            mainBody.Size = new Size(744, 550);
            mainBody.TabIndex = 2;
            mainBody.Paint += mainBody_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(label6);
            panel1.Controls.Add(removeTranslation);
            panel1.Controls.Add(remove);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(744, 550);
            panel1.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(21, 524);
            label6.Name = "label6";
            label6.Size = new Size(711, 17);
            label6.TabIndex = 4;
            label6.Text = "Copy and paste here a translation you want to remove from the list. (Make sure to copy the full element from 1 column)";
            // 
            // removeTranslation
            // 
            removeTranslation.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            removeTranslation.Location = new Point(47, 471);
            removeTranslation.Multiline = true;
            removeTranslation.Name = "removeTranslation";
            removeTranslation.Size = new Size(555, 43);
            removeTranslation.TabIndex = 22;
            removeTranslation.TextChanged += removeTranslation_TextChanged;
            // 
            // remove
            // 
            remove.FlatStyle = FlatStyle.Flat;
            remove.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            remove.ForeColor = Color.White;
            remove.Location = new Point(617, 471);
            remove.Name = "remove";
            remove.Size = new Size(80, 43);
            remove.TabIndex = 21;
            remove.Text = "Remove";
            remove.UseVisualStyleBackColor = true;
            remove.Click += remove_Click;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(41, 44, 51);
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.ForeColor = Color.White;
            textBox5.Location = new Point(48, 99);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.ScrollBars = ScrollBars.Vertical;
            textBox5.Size = new Size(648, 366);
            textBox5.TabIndex = 20;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(41, 39);
            label5.Name = "label5";
            label5.Size = new Size(121, 23);
            label5.TabIndex = 19;
            label5.Text = "Translations";
            label5.Click += label5_Click_3;
            // 
            // error
            // 
            error.AutoSize = true;
            error.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            error.ForeColor = Color.FromArgb(255, 128, 128);
            error.Location = new Point(44, 77);
            error.Name = "error";
            error.Size = new Size(39, 19);
            error.TabIndex = 17;
            error.Text = "error";
            error.Visible = false;
            error.Click += error_Click;
            // 
            // clipboard
            // 
            clipboard.FlatStyle = FlatStyle.Flat;
            clipboard.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            clipboard.ForeColor = Color.White;
            clipboard.Location = new Point(429, 254);
            clipboard.Name = "clipboard";
            clipboard.Size = new Size(130, 43);
            clipboard.TabIndex = 16;
            clipboard.Text = "Clipboard";
            clipboard.UseVisualStyleBackColor = true;
            clipboard.Click += clipboard_Click;
            // 
            // confirm
            // 
            confirm.FlatStyle = FlatStyle.Flat;
            confirm.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            confirm.ForeColor = Color.White;
            confirm.Location = new Point(565, 254);
            confirm.Name = "confirm";
            confirm.Size = new Size(130, 43);
            confirm.TabIndex = 15;
            confirm.Text = "Enter";
            confirm.UseVisualStyleBackColor = true;
            confirm.Click += confirm_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripComboBox1 });
            menuStrip1.Location = new Point(90, 262);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(131, 27);
            menuStrip1.TabIndex = 14;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            toolStripComboBox1.FlatStyle = FlatStyle.Flat;
            toolStripComboBox1.Items.AddRange(new object[] { "Arabic (ar)", "Czech (cs)", "Danish (da)", "Dutch (nl)", "English (en)", "Finnish (fi)", "French (fr)", "German (de)", "Greek (el)", "Hebrew (he)", "Hindi (hi)", "Hungarian (hu)", "Indonesian (id)", "Italian (it)", "Japanese (ja)", "Korean (ko)", "Norwegian (nb)", "Polish (pl)", "Portuguese (Brazil) (pt)", "Russian (ru)", "Spanish (es)", "Swedish (sv)", "Turkish (tr)" });
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(121, 23);
            toolStripComboBox1.Click += toolStripComboBox1_Click_1;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.Black;
            textBox2.Location = new Point(47, 99);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(650, 124);
            textBox2.TabIndex = 13;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(47, 314);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(650, 124);
            textBox1.TabIndex = 12;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(325, 15);
            label4.Name = "label4";
            label4.Size = new Size(95, 23);
            label4.TabIndex = 11;
            label4.Text = "Translate";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(229, 270);
            label3.Name = "label3";
            label3.Size = new Size(27, 19);
            label3.TabIndex = 10;
            label3.Text = "To:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(41, 270);
            label2.Name = "label2";
            label2.Size = new Size(46, 19);
            label2.TabIndex = 9;
            label2.Text = "From:";
            // 
            // menuStrip2
            // 
            menuStrip2.Dock = DockStyle.None;
            menuStrip2.Items.AddRange(new ToolStripItem[] { toolStripComboBox2 });
            menuStrip2.Location = new Point(259, 262);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(131, 27);
            menuStrip2.TabIndex = 8;
            menuStrip2.Text = "menuStrip2";
            // 
            // toolStripComboBox2
            // 
            toolStripComboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            toolStripComboBox2.FlatStyle = FlatStyle.Flat;
            toolStripComboBox2.Items.AddRange(new object[] { "Arabic (ar)", "Czech (cs)", "Danish (da)", "Dutch (nl)", "English (en)", "Finnish (fi)", "French (fr)", "German (de)", "Greek (el)", "Hebrew (he)", "Hindi (hi)", "Hungarian (hu)", "Indonesian (id)", "Italian (it)", "Japanese (ja)", "Korean (ko)", "Norwegian (nb)", "Polish (pl)", "Portuguese (Brazil) (pt)", "Russian (ru)", "Spanish (es)", "Swedish (sv)", "Turkish (tr)" });
            toolStripComboBox2.Name = "toolStripComboBox2";
            toolStripComboBox2.Size = new Size(121, 23);
            toolStripComboBox2.Click += toolStripComboBox2_Click;
            // 
            // save
            // 
            save.FlatStyle = FlatStyle.Flat;
            save.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            save.ForeColor = Color.White;
            save.Location = new Point(477, 471);
            save.Name = "save";
            save.Size = new Size(220, 43);
            save.TabIndex = 5;
            save.Text = "Save";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // reset
            // 
            reset.FlatStyle = FlatStyle.Flat;
            reset.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            reset.ForeColor = Color.White;
            reset.Location = new Point(44, 471);
            reset.Name = "reset";
            reset.Size = new Size(220, 43);
            reset.TabIndex = 4;
            reset.Text = "Reset";
            reset.UseVisualStyleBackColor = true;
            reset.Click += reset_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(mainBody);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(220, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(744, 550);
            panel2.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 44, 51);
            ClientSize = new Size(964, 550);
            Controls.Add(panel2);
            Controls.Add(sidePanel);
            Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Language Assistant";
            Load += Form1_Load;
            sidePanel.ResumeLayout(false);
            sidePanel.PerformLayout();
            titlePanel.ResumeLayout(false);
            titlePanel.PerformLayout();
            mainBody.ResumeLayout(false);
            mainBody.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel sidePanel;
        private Panel titlePanel;
        private Label Title;
        private Button translateBtn;
        private Button listBtn;
        private Label label1;
        private Panel mainBody;
        private Button reset;
        private Button save;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox2;
        private MenuStrip menuStrip2;
        private ToolStripComboBox toolStripComboBox2;
        private MenuStrip menuStrip1;
        private ToolStripComboBox toolStripComboBox1;
        private Button confirm;
        private Button clipboard;
        private Label error;
        private TextBox textBox3;
        private TextBox textBox4;
        private Panel panel1;
        private Label label5;
        private TextBox textBox5;
        private Panel panel2;
        private Label label6;
        private TextBox removeTranslation;
        private Button remove;
    }
}