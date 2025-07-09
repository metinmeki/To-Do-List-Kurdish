namespace To_Do_List
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
            label1 = new Label();
            titleTextbox = new TextBox();
            label2 = new Label();
            descripitionTextbox = new TextBox();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            toDoListView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)toDoListView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1344, 43);
            label1.TabIndex = 0;
            label1.Text = "لیستی کارەکان";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // titleTextbox
            // 
            titleTextbox.Location = new Point(12, 116);
            titleTextbox.Multiline = true;
            titleTextbox.Name = "titleTextbox";
            titleTextbox.Size = new Size(1320, 66);
            titleTextbox.TabIndex = 1;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.CornflowerBlue;
            label2.Location = new Point(0, 58);
            label2.Name = "label2";
            label2.Size = new Size(1344, 43);
            label2.TabIndex = 2;
            label2.Text = ":ناونیشان";
            label2.TextAlign = ContentAlignment.TopRight;
            label2.Click += label2_Click;
            // 
            // descripitionTextbox
            // 
            descripitionTextbox.Location = new Point(12, 240);
            descripitionTextbox.Multiline = true;
            descripitionTextbox.Name = "descripitionTextbox";
            descripitionTextbox.Size = new Size(1320, 66);
            descripitionTextbox.TabIndex = 3;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.CornflowerBlue;
            label3.Location = new Point(-12, 185);
            label3.Name = "label3";
            label3.Size = new Size(1344, 43);
            label3.TabIndex = 4;
            label3.Text = "وەسف";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // button1
            // 
            button1.Location = new Point(12, 337);
            button1.Name = "button1";
            button1.Size = new Size(288, 49);
            button1.TabIndex = 5;
            button1.Text = "نوێ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.ForeColor = Color.White;
            button2.Location = new Point(325, 337);
            button2.Name = "button2";
            button2.Size = new Size(254, 49);
            button2.TabIndex = 6;
            button2.Text = "سڕینەوە";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(596, 337);
            button3.Name = "button3";
            button3.Size = new Size(289, 49);
            button3.TabIndex = 7;
            button3.Text = "بژارکردن";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(906, 337);
            button4.Name = "button4";
            button4.Size = new Size(426, 49);
            button4.TabIndex = 8;
            button4.Text = "هەڵگرتن";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // toDoListView
            // 
            toDoListView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            toDoListView.BackgroundColor = Color.White;
            toDoListView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            toDoListView.Location = new Point(22, 409);
            toDoListView.Name = "toDoListView";
            toDoListView.RowHeadersWidth = 51;
            toDoListView.Size = new Size(1310, 283);
            toDoListView.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1356, 713);
            Controls.Add(toDoListView);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(descripitionTextbox);
            Controls.Add(label2);
            Controls.Add(titleTextbox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)toDoListView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox titleTextbox;
        private Label label2;
        private TextBox descripitionTextbox;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView toDoListView;
    }
}
