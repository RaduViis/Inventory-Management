
namespace StockManagement
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.polyfloralButton = new System.Windows.Forms.Button();
            this.sunflowerButton = new System.Windows.Forms.Button();
            this.LimeButton = new System.Windows.Forms.Button();
            this.AcaciaButton = new System.Windows.Forms.Button();
            this.honeyButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.insertButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataView
            // 
            this.dataView.AllowUserToAddRows = false;
            this.dataView.AllowUserToDeleteRows = false;
            this.dataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID});
            this.dataView.Location = new System.Drawing.Point(288, 49);
            this.dataView.Name = "dataView";
            this.dataView.ReadOnly = true;
            this.dataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataView.Size = new System.Drawing.Size(630, 509);
            this.dataView.TabIndex = 0;
            this.dataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataView_CellContentClick);
            this.dataView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataView_RowPostPaint);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.honeyButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 600);
            this.panel1.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(77)))), ((int)(((byte)(88)))));
            this.panel3.Controls.Add(this.polyfloralButton);
            this.panel3.Controls.Add(this.sunflowerButton);
            this.panel3.Controls.Add(this.LimeButton);
            this.panel3.Controls.Add(this.AcaciaButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 145);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 162);
            this.panel3.TabIndex = 9;
            // 
            // polyfloralButton
            // 
            this.polyfloralButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.polyfloralButton.FlatAppearance.BorderSize = 0;
            this.polyfloralButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.polyfloralButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.polyfloralButton.ForeColor = System.Drawing.Color.LightGray;
            this.polyfloralButton.Location = new System.Drawing.Point(0, 120);
            this.polyfloralButton.Name = "polyfloralButton";
            this.polyfloralButton.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.polyfloralButton.Size = new System.Drawing.Size(250, 40);
            this.polyfloralButton.TabIndex = 12;
            this.polyfloralButton.Text = "Polyfloral";
            this.polyfloralButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.polyfloralButton.UseVisualStyleBackColor = true;
            this.polyfloralButton.Click += new System.EventHandler(this.polyfloralButton_Click);
            // 
            // sunflowerButton
            // 
            this.sunflowerButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.sunflowerButton.FlatAppearance.BorderSize = 0;
            this.sunflowerButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.sunflowerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sunflowerButton.ForeColor = System.Drawing.Color.LightGray;
            this.sunflowerButton.Location = new System.Drawing.Point(0, 80);
            this.sunflowerButton.Name = "sunflowerButton";
            this.sunflowerButton.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.sunflowerButton.Size = new System.Drawing.Size(250, 40);
            this.sunflowerButton.TabIndex = 11;
            this.sunflowerButton.Text = "Sunflower";
            this.sunflowerButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sunflowerButton.UseVisualStyleBackColor = true;
            this.sunflowerButton.Click += new System.EventHandler(this.sunflowerButton_Click);
            // 
            // LimeButton
            // 
            this.LimeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.LimeButton.FlatAppearance.BorderSize = 0;
            this.LimeButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.LimeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LimeButton.ForeColor = System.Drawing.Color.LightGray;
            this.LimeButton.Location = new System.Drawing.Point(0, 40);
            this.LimeButton.Name = "LimeButton";
            this.LimeButton.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.LimeButton.Size = new System.Drawing.Size(250, 40);
            this.LimeButton.TabIndex = 10;
            this.LimeButton.Text = "Lime";
            this.LimeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LimeButton.UseVisualStyleBackColor = true;
            this.LimeButton.Click += new System.EventHandler(this.LimeButton_Click);
            // 
            // AcaciaButton
            // 
            this.AcaciaButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AcaciaButton.FlatAppearance.BorderSize = 0;
            this.AcaciaButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.AcaciaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AcaciaButton.ForeColor = System.Drawing.Color.LightGray;
            this.AcaciaButton.Location = new System.Drawing.Point(0, 0);
            this.AcaciaButton.Name = "AcaciaButton";
            this.AcaciaButton.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.AcaciaButton.Size = new System.Drawing.Size(250, 40);
            this.AcaciaButton.TabIndex = 9;
            this.AcaciaButton.Text = "Acacia";
            this.AcaciaButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AcaciaButton.UseVisualStyleBackColor = true;
            this.AcaciaButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // honeyButton
            // 
            this.honeyButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.honeyButton.FlatAppearance.BorderSize = 0;
            this.honeyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.honeyButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.honeyButton.Location = new System.Drawing.Point(0, 100);
            this.honeyButton.Name = "honeyButton";
            this.honeyButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.honeyButton.Size = new System.Drawing.Size(250, 45);
            this.honeyButton.TabIndex = 1;
            this.honeyButton.Text = "Honey";
            this.honeyButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.honeyButton.UseVisualStyleBackColor = true;
            this.honeyButton.Click += new System.EventHandler(this.honeyButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 100);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(89, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // insertButton
            // 
            this.insertButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertButton.Location = new System.Drawing.Point(288, 12);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(88, 31);
            this.insertButton.TabIndex = 18;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(830, 12);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(88, 31);
            this.deleteButton.TabIndex = 29;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click_1);
            // 
            // ID
            // 
            this.ID.HeaderText = "*";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataView);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button polyfloralButton;
        private System.Windows.Forms.Button sunflowerButton;
        private System.Windows.Forms.Button LimeButton;
        private System.Windows.Forms.Button AcaciaButton;
        private System.Windows.Forms.Button honeyButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}

