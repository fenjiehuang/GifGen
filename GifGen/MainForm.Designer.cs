namespace GifGen
{
    partial class MainForm
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
            this.openFileDialog_in_video = new System.Windows.Forms.OpenFileDialog();
            this.button_in_video = new System.Windows.Forms.Button();
            this.textBox_in_video_path = new System.Windows.Forms.TextBox();
            this.textBox_save_path = new System.Windows.Forms.TextBox();
            this.dateTimePicker_start_time = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown_duration = new System.Windows.Forms.NumericUpDown();
            this.button_gen = new System.Windows.Forms.Button();
            this.saveFileDialog_out = new System.Windows.Forms.SaveFileDialog();
            this.button_save_path = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown_framerate = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox_subtitle = new System.Windows.Forms.CheckBox();
            this.dataGridView_subtitle = new System.Windows.Forms.DataGridView();
            this.Column_start_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_end_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_add_row = new System.Windows.Forms.Button();
            this.numericUpDown_font_size = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.colorDialog_font_color = new System.Windows.Forms.ColorDialog();
            this.button_font_color = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_resolution = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_duration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_framerate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_subtitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_font_size)).BeginInit();
            this.SuspendLayout();
            // 
            // button_in_video
            // 
            this.button_in_video.Location = new System.Drawing.Point(236, 43);
            this.button_in_video.Name = "button_in_video";
            this.button_in_video.Size = new System.Drawing.Size(75, 23);
            this.button_in_video.TabIndex = 0;
            this.button_in_video.Text = "选择";
            this.button_in_video.UseVisualStyleBackColor = true;
            this.button_in_video.Click += new System.EventHandler(this.button_in_video_Click);
            // 
            // textBox_in_video_path
            // 
            this.textBox_in_video_path.Location = new System.Drawing.Point(20, 45);
            this.textBox_in_video_path.Name = "textBox_in_video_path";
            this.textBox_in_video_path.Size = new System.Drawing.Size(210, 21);
            this.textBox_in_video_path.TabIndex = 1;
            // 
            // textBox_save_path
            // 
            this.textBox_save_path.Location = new System.Drawing.Point(20, 104);
            this.textBox_save_path.Name = "textBox_save_path";
            this.textBox_save_path.Size = new System.Drawing.Size(210, 21);
            this.textBox_save_path.TabIndex = 2;
            // 
            // dateTimePicker_start_time
            // 
            this.dateTimePicker_start_time.CustomFormat = "HH:mm:ss";
            this.dateTimePicker_start_time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker_start_time.Location = new System.Drawing.Point(125, 149);
            this.dateTimePicker_start_time.Name = "dateTimePicker_start_time";
            this.dateTimePicker_start_time.ShowUpDown = true;
            this.dateTimePicker_start_time.Size = new System.Drawing.Size(73, 21);
            this.dateTimePicker_start_time.TabIndex = 3;
            this.dateTimePicker_start_time.Value = new System.DateTime(2018, 4, 14, 0, 0, 0, 0);
            // 
            // numericUpDown_duration
            // 
            this.numericUpDown_duration.Location = new System.Drawing.Point(125, 193);
            this.numericUpDown_duration.Name = "numericUpDown_duration";
            this.numericUpDown_duration.Size = new System.Drawing.Size(73, 21);
            this.numericUpDown_duration.TabIndex = 4;
            this.numericUpDown_duration.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // button_gen
            // 
            this.button_gen.Location = new System.Drawing.Point(236, 343);
            this.button_gen.Name = "button_gen";
            this.button_gen.Size = new System.Drawing.Size(75, 23);
            this.button_gen.TabIndex = 5;
            this.button_gen.Text = "生成";
            this.button_gen.UseVisualStyleBackColor = true;
            this.button_gen.Click += new System.EventHandler(this.button_gen_Click);
            // 
            // saveFileDialog_out
            // 
            this.saveFileDialog_out.DefaultExt = "gif";
            this.saveFileDialog_out.Filter = "GIF files|*.gif";
            // 
            // button_save_path
            // 
            this.button_save_path.Location = new System.Drawing.Point(236, 102);
            this.button_save_path.Name = "button_save_path";
            this.button_save_path.Size = new System.Drawing.Size(75, 23);
            this.button_save_path.TabIndex = 6;
            this.button_save_path.Text = "选择";
            this.button_save_path.UseVisualStyleBackColor = true;
            this.button_save_path.Click += new System.EventHandler(this.button_save_path_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "开始时间：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "截取长度：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "秒";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "待截取视频：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "Gif输出路径：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "动图帧率：";
            // 
            // numericUpDown_framerate
            // 
            this.numericUpDown_framerate.Location = new System.Drawing.Point(125, 246);
            this.numericUpDown_framerate.Name = "numericUpDown_framerate";
            this.numericUpDown_framerate.Size = new System.Drawing.Size(73, 21);
            this.numericUpDown_framerate.TabIndex = 13;
            this.numericUpDown_framerate.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(223, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "fps";
            // 
            // checkBox_subtitle
            // 
            this.checkBox_subtitle.AutoSize = true;
            this.checkBox_subtitle.Location = new System.Drawing.Point(342, 47);
            this.checkBox_subtitle.Name = "checkBox_subtitle";
            this.checkBox_subtitle.Size = new System.Drawing.Size(72, 16);
            this.checkBox_subtitle.TabIndex = 15;
            this.checkBox_subtitle.Text = "添加字幕";
            this.checkBox_subtitle.UseVisualStyleBackColor = true;
            this.checkBox_subtitle.CheckStateChanged += new System.EventHandler(this.checkBox_subtitle_CheckStateChanged);
            // 
            // dataGridView_subtitle
            // 
            this.dataGridView_subtitle.AllowUserToAddRows = false;
            this.dataGridView_subtitle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_subtitle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_start_time,
            this.Column_end_time,
            this.Column_content});
            this.dataGridView_subtitle.Enabled = false;
            this.dataGridView_subtitle.Location = new System.Drawing.Point(342, 81);
            this.dataGridView_subtitle.Name = "dataGridView_subtitle";
            this.dataGridView_subtitle.RowTemplate.Height = 23;
            this.dataGridView_subtitle.Size = new System.Drawing.Size(519, 285);
            this.dataGridView_subtitle.TabIndex = 16;
            this.dataGridView_subtitle.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_subtitle_CellEndEdit);
            // 
            // Column_start_time
            // 
            this.Column_start_time.HeaderText = "开始时间";
            this.Column_start_time.Name = "Column_start_time";
            this.Column_start_time.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column_start_time.Width = 80;
            // 
            // Column_end_time
            // 
            this.Column_end_time.HeaderText = "结束时间";
            this.Column_end_time.Name = "Column_end_time";
            this.Column_end_time.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column_end_time.Width = 80;
            // 
            // Column_content
            // 
            this.Column_content.HeaderText = "字幕内容";
            this.Column_content.Name = "Column_content";
            this.Column_content.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column_content.Width = 300;
            // 
            // button_add_row
            // 
            this.button_add_row.Enabled = false;
            this.button_add_row.Location = new System.Drawing.Point(754, 40);
            this.button_add_row.Name = "button_add_row";
            this.button_add_row.Size = new System.Drawing.Size(75, 23);
            this.button_add_row.TabIndex = 18;
            this.button_add_row.Text = "添加一行";
            this.button_add_row.UseVisualStyleBackColor = true;
            this.button_add_row.Click += new System.EventHandler(this.button_add_row_Click);
            // 
            // numericUpDown_font_size
            // 
            this.numericUpDown_font_size.Location = new System.Drawing.Point(505, 43);
            this.numericUpDown_font_size.Name = "numericUpDown_font_size";
            this.numericUpDown_font_size.Size = new System.Drawing.Size(45, 21);
            this.numericUpDown_font_size.TabIndex = 19;
            this.numericUpDown_font_size.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(434, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 20;
            this.label8.Text = "字体大小：";
            // 
            // button_font_color
            // 
            this.button_font_color.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_font_color.Location = new System.Drawing.Point(639, 40);
            this.button_font_color.Name = "button_font_color";
            this.button_font_color.Size = new System.Drawing.Size(75, 23);
            this.button_font_color.TabIndex = 21;
            this.button_font_color.UseVisualStyleBackColor = false;
            this.button_font_color.Click += new System.EventHandler(this.button_font_color_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(568, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 22;
            this.label9.Text = "字体颜色：";
            // 
            // textBox_resolution
            // 
            this.textBox_resolution.Location = new System.Drawing.Point(125, 297);
            this.textBox_resolution.Name = "textBox_resolution";
            this.textBox_resolution.Size = new System.Drawing.Size(73, 21);
            this.textBox_resolution.TabIndex = 23;
            this.textBox_resolution.Text = "320:-1";
            this.textBox_resolution.TextChanged += new System.EventHandler(this.textBox_resolution_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 300);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 24;
            this.label10.Text = "分辨率：";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 377);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox_resolution);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button_font_color);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericUpDown_font_size);
            this.Controls.Add(this.button_add_row);
            this.Controls.Add(this.dataGridView_subtitle);
            this.Controls.Add(this.checkBox_subtitle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDown_framerate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_save_path);
            this.Controls.Add(this.button_gen);
            this.Controls.Add(this.numericUpDown_duration);
            this.Controls.Add(this.dateTimePicker_start_time);
            this.Controls.Add(this.textBox_save_path);
            this.Controls.Add(this.textBox_in_video_path);
            this.Controls.Add(this.button_in_video);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GifGen";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_duration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_framerate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_subtitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_font_size)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog_in_video;
        private System.Windows.Forms.Button button_in_video;
        private System.Windows.Forms.TextBox textBox_in_video_path;
        private System.Windows.Forms.TextBox textBox_save_path;
        private System.Windows.Forms.DateTimePicker dateTimePicker_start_time;
        private System.Windows.Forms.NumericUpDown numericUpDown_duration;
        private System.Windows.Forms.Button button_gen;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_out;
        private System.Windows.Forms.Button button_save_path;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown_framerate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox_subtitle;
        private System.Windows.Forms.DataGridView dataGridView_subtitle;
        private System.Windows.Forms.Button button_add_row;
        private System.Windows.Forms.NumericUpDown numericUpDown_font_size;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColorDialog colorDialog_font_color;
        private System.Windows.Forms.Button button_font_color;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_start_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_end_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_content;
        private System.Windows.Forms.TextBox textBox_resolution;
        private System.Windows.Forms.Label label10;
    }
}

