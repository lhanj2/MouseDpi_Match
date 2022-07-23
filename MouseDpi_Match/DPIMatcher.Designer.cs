namespace MouseDpi_Match
{
    partial class DPIMatcher
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DPIMatcher));
            this.button1 = new System.Windows.Forms.Button();
            this.btnChangeMouseSpeed = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column_Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Speed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(375, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "ShowMouseSpeed";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnShowMouseSpeed_Click);
            // 
            // btnChangeMouseSpeed
            // 
            this.btnChangeMouseSpeed.Location = new System.Drawing.Point(375, 63);
            this.btnChangeMouseSpeed.Name = "btnChangeMouseSpeed";
            this.btnChangeMouseSpeed.Size = new System.Drawing.Size(197, 34);
            this.btnChangeMouseSpeed.TabIndex = 0;
            this.btnChangeMouseSpeed.Text = "ChangeSpeed";
            this.btnChangeMouseSpeed.UseVisualStyleBackColor = true;
            this.btnChangeMouseSpeed.Click += new System.EventHandler(this.btnChangeMouseSpeed_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.종료ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(121, 36);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(120, 32);
            this.종료ToolStripMenuItem.Text = "종료";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Num,
            this.Column_Speed,
            this.Column_Key});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(343, 426);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // Column_Num
            // 
            this.Column_Num.HeaderText = "Num";
            this.Column_Num.MinimumWidth = 8;
            this.Column_Num.Name = "Column_Num";
            this.Column_Num.Width = 88;
            // 
            // Column_Speed
            // 
            this.Column_Speed.HeaderText = "Speed";
            this.Column_Speed.MinimumWidth = 8;
            this.Column_Speed.Name = "Column_Speed";
            // 
            // Column_Key
            // 
            this.Column_Key.HeaderText = "Key";
            this.Column_Key.MinimumWidth = 8;
            this.Column_Key.Name = "Column_Key";
            this.Column_Key.Width = 78;
            // 
            // DPIMatcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnChangeMouseSpeed);
            this.Controls.Add(this.button1);
            this.KeyPreview = true;
            this.Name = "DPIMatcher";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DPIMatcher_FormClosing);
            this.Load += new System.EventHandler(this.DPIMatcher_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DPIMatcher_KeyDown);
            this.Resize += new System.EventHandler(this.DPIMatcher_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private Button btnChangeMouseSpeed;
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem 종료ToolStripMenuItem;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column_Num;
        private DataGridViewTextBoxColumn Column_Speed;
        private DataGridViewTextBoxColumn Column_Key;
    }
}