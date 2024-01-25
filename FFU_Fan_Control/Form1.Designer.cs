namespace FFU_Fan_Control
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tbpMonitor = new TabPage();
            tbpFanSetting = new TabPage();
            tbpComSetting = new TabPage();
            groupBox2 = new GroupBox();
            textBox1 = new TextBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            label3 = new Label();
            label4 = new Label();
            picComStatus = new PictureBox();
            picPLCStatus = new PictureBox();
            dataGridView1 = new DataGridView();
            dtgvhdSTT = new DataGridViewTextBoxColumn();
            dtgvhdName = new DataGridViewTextBoxColumn();
            dtgvhdCurSpeed = new DataGridViewTextBoxColumn();
            dtgvhdSetSpeed = new DataGridViewTextBoxColumn();
            dtgvhdStatus = new DataGridViewTextBoxColumn();
            tabControl1.SuspendLayout();
            tbpMonitor.SuspendLayout();
            tbpComSetting.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picComStatus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPLCStatus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Alignment = TabAlignment.Bottom;
            tabControl1.Controls.Add(tbpMonitor);
            tabControl1.Controls.Add(tbpFanSetting);
            tabControl1.Controls.Add(tbpComSetting);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.ItemSize = new Size(75, 25);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(702, 450);
            tabControl1.TabIndex = 0;
            // 
            // tbpMonitor
            // 
            tbpMonitor.BorderStyle = BorderStyle.FixedSingle;
            tbpMonitor.Controls.Add(groupBox4);
            tbpMonitor.Controls.Add(groupBox3);
            tbpMonitor.Location = new Point(4, 4);
            tbpMonitor.Name = "tbpMonitor";
            tbpMonitor.Padding = new Padding(3);
            tbpMonitor.Size = new Size(694, 417);
            tbpMonitor.TabIndex = 0;
            tbpMonitor.Text = "Monitor";
            tbpMonitor.UseVisualStyleBackColor = true;
            // 
            // tbpFanSetting
            // 
            tbpFanSetting.BorderStyle = BorderStyle.FixedSingle;
            tbpFanSetting.Location = new Point(4, 4);
            tbpFanSetting.Name = "tbpFanSetting";
            tbpFanSetting.Padding = new Padding(3);
            tbpFanSetting.Size = new Size(694, 417);
            tbpFanSetting.TabIndex = 1;
            tbpFanSetting.Text = "Fan Setting";
            tbpFanSetting.UseVisualStyleBackColor = true;
            // 
            // tbpComSetting
            // 
            tbpComSetting.BorderStyle = BorderStyle.FixedSingle;
            tbpComSetting.Controls.Add(groupBox2);
            tbpComSetting.Controls.Add(groupBox1);
            tbpComSetting.Location = new Point(4, 4);
            tbpComSetting.Name = "tbpComSetting";
            tbpComSetting.Size = new Size(694, 417);
            tbpComSetting.TabIndex = 2;
            tbpComSetting.Text = "Com Setting";
            tbpComSetting.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(347, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(340, 405);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "PLC Setting";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(66, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 27);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 69);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 2;
            label2.Text = "Device";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(66, 29);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(94, 28);
            comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 32);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 0;
            label1.Text = "Type";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(3, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(340, 405);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Serial Setting";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(picPLCStatus);
            groupBox3.Controls.Add(picComStatus);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Location = new Point(6, 7);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 402);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Status";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Location = new Point(212, 7);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(473, 402);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Data Monitoring";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 33);
            label3.Name = "label3";
            label3.Size = new Size(132, 20);
            label3.TabIndex = 0;
            label3.Text = "Serial Connection: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 61);
            label4.Name = "label4";
            label4.Size = new Size(118, 20);
            label4.TabIndex = 1;
            label4.Text = "PLC Connection: ";
            // 
            // picComStatus
            // 
            picComStatus.Location = new Point(146, 33);
            picComStatus.Name = "picComStatus";
            picComStatus.Size = new Size(20, 20);
            picComStatus.TabIndex = 2;
            picComStatus.TabStop = false;
            // 
            // picPLCStatus
            // 
            picPLCStatus.Location = new Point(146, 61);
            picPLCStatus.Name = "picPLCStatus";
            picPLCStatus.Size = new Size(20, 20);
            picPLCStatus.TabIndex = 3;
            picPLCStatus.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dtgvhdSTT, dtgvhdName, dtgvhdCurSpeed, dtgvhdSetSpeed, dtgvhdStatus });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Enabled = false;
            dataGridView1.Location = new Point(3, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(467, 376);
            dataGridView1.TabIndex = 0;
            // 
            // dtgvhdSTT
            // 
            dtgvhdSTT.HeaderText = "STT";
            dtgvhdSTT.Name = "dtgvhdSTT";
            dtgvhdSTT.ReadOnly = true;
            dtgvhdSTT.Width = 40;
            // 
            // dtgvhdName
            // 
            dtgvhdName.HeaderText = "Name";
            dtgvhdName.Name = "dtgvhdName";
            dtgvhdName.ReadOnly = true;
            dtgvhdName.Width = 80;
            // 
            // dtgvhdCurSpeed
            // 
            dtgvhdCurSpeed.HeaderText = "Current Speed";
            dtgvhdCurSpeed.Name = "dtgvhdCurSpeed";
            dtgvhdCurSpeed.ReadOnly = true;
            dtgvhdCurSpeed.Width = 130;
            // 
            // dtgvhdSetSpeed
            // 
            dtgvhdSetSpeed.HeaderText = "Set Speed";
            dtgvhdSetSpeed.Name = "dtgvhdSetSpeed";
            dtgvhdSetSpeed.ReadOnly = true;
            dtgvhdSetSpeed.Width = 130;
            // 
            // dtgvhdStatus
            // 
            dtgvhdStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvhdStatus.HeaderText = "Status";
            dtgvhdStatus.Name = "dtgvhdStatus";
            dtgvhdStatus.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tbpMonitor.ResumeLayout(false);
            tbpComSetting.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picComStatus).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPLCStatus).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tbpMonitor;
        private TabPage tbpFanSetting;
        private TabPage tbpComSetting;
        private GroupBox groupBox2;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label2;
        private ComboBox comboBox1;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private PictureBox picPLCStatus;
        private PictureBox picComStatus;
        private Label label4;
        private Label label3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dtgvhdSTT;
        private DataGridViewTextBoxColumn dtgvhdName;
        private DataGridViewTextBoxColumn dtgvhdCurSpeed;
        private DataGridViewTextBoxColumn dtgvhdSetSpeed;
        private DataGridViewTextBoxColumn dtgvhdStatus;
    }
}