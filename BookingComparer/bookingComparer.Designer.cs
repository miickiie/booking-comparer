namespace BookingComparer
{
    partial class BookingComparer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingComparer));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.csv_btn_1 = new System.Windows.Forms.Button();
            this.tbFilePath1 = new System.Windows.Forms.TextBox();
            this.process_btn = new System.Windows.Forms.Button();
            this.tbFilePath2 = new System.Windows.Forms.TextBox();
            this.tbFilePath3 = new System.Windows.Forms.TextBox();
            this.tbFilePath4 = new System.Windows.Forms.TextBox();
            this.csv_btn_2 = new System.Windows.Forms.Button();
            this.a_btn = new System.Windows.Forms.Button();
            this.b_button = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // csv_btn_1
            // 
            this.csv_btn_1.Location = new System.Drawing.Point(592, 27);
            this.csv_btn_1.Name = "csv_btn_1";
            this.csv_btn_1.Size = new System.Drawing.Size(129, 23);
            this.csv_btn_1.TabIndex = 0;
            this.csv_btn_1.Text = "Load CSV ";
            this.csv_btn_1.UseVisualStyleBackColor = true;
            this.csv_btn_1.Click += new System.EventHandler(this.csv_btn_1_Click);
            // 
            // tbFilePath1
            // 
            this.tbFilePath1.Location = new System.Drawing.Point(22, 27);
            this.tbFilePath1.Name = "tbFilePath1";
            this.tbFilePath1.Size = new System.Drawing.Size(564, 20);
            this.tbFilePath1.TabIndex = 1;
            // 
            // process_btn
            // 
            this.process_btn.Location = new System.Drawing.Point(659, 352);
            this.process_btn.Name = "process_btn";
            this.process_btn.Size = new System.Drawing.Size(99, 96);
            this.process_btn.TabIndex = 2;
            this.process_btn.Text = "Process";
            this.process_btn.UseVisualStyleBackColor = true;
            this.process_btn.Click += new System.EventHandler(this.process_btn_Click);
            // 
            // tbFilePath2
            // 
            this.tbFilePath2.Location = new System.Drawing.Point(22, 30);
            this.tbFilePath2.Name = "tbFilePath2";
            this.tbFilePath2.Size = new System.Drawing.Size(564, 20);
            this.tbFilePath2.TabIndex = 3;
            // 
            // tbFilePath3
            // 
            this.tbFilePath3.Location = new System.Drawing.Point(22, 28);
            this.tbFilePath3.Name = "tbFilePath3";
            this.tbFilePath3.Size = new System.Drawing.Size(564, 20);
            this.tbFilePath3.TabIndex = 4;
            // 
            // tbFilePath4
            // 
            this.tbFilePath4.Location = new System.Drawing.Point(22, 29);
            this.tbFilePath4.Name = "tbFilePath4";
            this.tbFilePath4.Size = new System.Drawing.Size(564, 20);
            this.tbFilePath4.TabIndex = 5;
            // 
            // csv_btn_2
            // 
            this.csv_btn_2.Location = new System.Drawing.Point(592, 27);
            this.csv_btn_2.Name = "csv_btn_2";
            this.csv_btn_2.Size = new System.Drawing.Size(129, 23);
            this.csv_btn_2.TabIndex = 6;
            this.csv_btn_2.Text = "Load CSV";
            this.csv_btn_2.UseVisualStyleBackColor = true;
            this.csv_btn_2.Click += new System.EventHandler(this.csv_btn_2_Click);
            // 
            // a_btn
            // 
            this.a_btn.Location = new System.Drawing.Point(592, 26);
            this.a_btn.Name = "a_btn";
            this.a_btn.Size = new System.Drawing.Size(129, 23);
            this.a_btn.TabIndex = 7;
            this.a_btn.Text = "Load allocate for A";
            this.a_btn.UseVisualStyleBackColor = true;
            this.a_btn.Click += new System.EventHandler(this.a_btn_Click);
            // 
            // b_button
            // 
            this.b_button.Location = new System.Drawing.Point(592, 26);
            this.b_button.Name = "b_button";
            this.b_button.Size = new System.Drawing.Size(129, 23);
            this.b_button.TabIndex = 8;
            this.b_button.Text = "Load allocate for B";
            this.b_button.UseVisualStyleBackColor = true;
            this.b_button.Click += new System.EventHandler(this.b_button_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(59, 555);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(699, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTextBox.ForeColor = System.Drawing.Color.Blue;
            this.resultTextBox.Location = new System.Drawing.Point(59, 352);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultTextBox.Size = new System.Drawing.Size(594, 185);
            this.resultTextBox.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(669, 454);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 82);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbFilePath1);
            this.groupBox1.Controls.Add(this.csv_btn_1);
            this.groupBox1.Location = new System.Drawing.Point(37, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(728, 66);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CSV file of period before update";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.csv_btn_2);
            this.groupBox2.Controls.Add(this.tbFilePath2);
            this.groupBox2.Location = new System.Drawing.Point(37, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(728, 66);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CSV file of period after update";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.a_btn);
            this.groupBox3.Controls.Add(this.tbFilePath3);
            this.groupBox3.Location = new System.Drawing.Point(37, 185);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(728, 66);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CSV file of sample group A";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbFilePath4);
            this.groupBox4.Controls.Add(this.b_button);
            this.groupBox4.Location = new System.Drawing.Point(37, 271);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(728, 66);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "CSV file of sample group B";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(56, 592);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(168, 13);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Click to query CSV from Metabase";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(642, 592);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Made with (♥) in Castle";
            // 
            // bookingComparer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 619);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.process_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Name = "bookingComparer";
            this.Text = "Booking Comparer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button csv_btn_1;
        private System.Windows.Forms.TextBox tbFilePath1;
        private System.Windows.Forms.Button process_btn;
        private System.Windows.Forms.TextBox tbFilePath2;
        private System.Windows.Forms.TextBox tbFilePath3;
        private System.Windows.Forms.TextBox tbFilePath4;
        private System.Windows.Forms.Button csv_btn_2;
        private System.Windows.Forms.Button a_btn;
        private System.Windows.Forms.Button b_button;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
    }
}

