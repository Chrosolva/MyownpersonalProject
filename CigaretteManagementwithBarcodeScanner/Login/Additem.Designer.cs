﻿namespace Login
{
    partial class Additem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Additem));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_scannedcode = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Grade = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DGVforRak = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.RDGVForRak = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVforRak)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RDGVForRak)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(156)))), ((int)(((byte)(183)))));
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Scanned Barcode";
            // 
            // txt_scannedcode
            // 
            this.txt_scannedcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_scannedcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_scannedcode.Location = new System.Drawing.Point(15, 134);
            this.txt_scannedcode.Name = "txt_scannedcode";
            this.txt_scannedcode.Size = new System.Drawing.Size(131, 20);
            this.txt_scannedcode.TabIndex = 1;
            this.txt_scannedcode.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txt_scannedcode.Enter += new System.EventHandler(this.txt_scannedcode_Enter);
            this.txt_scannedcode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_scannedcode_KeyUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(64)))), ((int)(((byte)(71)))));
            this.panel1.Controls.Add(this.label_Grade);
            this.panel1.Controls.Add(this.label_Name);
            this.panel1.Controls.Add(this.label_ID);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(181, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 77);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label_Grade
            // 
            this.label_Grade.AutoSize = true;
            this.label_Grade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(156)))), ((int)(((byte)(183)))));
            this.label_Grade.Location = new System.Drawing.Point(425, 43);
            this.label_Grade.Name = "label_Grade";
            this.label_Grade.Size = new System.Drawing.Size(28, 13);
            this.label_Grade.TabIndex = 11;
            this.label_Grade.Text = "SSS";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(156)))), ((int)(((byte)(183)))));
            this.label_Name.Location = new System.Drawing.Point(217, 43);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(28, 13);
            this.label_Name.TabIndex = 10;
            this.label_Name.Text = "SSS";
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(156)))), ((int)(((byte)(183)))));
            this.label_ID.Location = new System.Drawing.Point(27, 43);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(28, 13);
            this.label_ID.TabIndex = 9;
            this.label_ID.Text = "SSS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(156)))), ((int)(((byte)(183)))));
            this.label5.Location = new System.Drawing.Point(383, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Grade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(156)))), ((int)(((byte)(183)))));
            this.label4.Location = new System.Drawing.Point(3, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(156)))), ((int)(((byte)(183)))));
            this.label3.Location = new System.Drawing.Point(176, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(156)))), ((int)(((byte)(183)))));
            this.label2.Location = new System.Drawing.Point(3, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ingredients Info";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(156)))), ((int)(((byte)(183)))));
            this.label6.Location = new System.Drawing.Point(14, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Left Drawer Location ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // DGVforRak
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(156)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(142)))), ((int)(((byte)(76)))));
            this.DGVforRak.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVforRak.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(51)))));
            this.DGVforRak.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(156)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(147)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVforRak.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVforRak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(156)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(142)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVforRak.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVforRak.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(158)))), ((int)(((byte)(188)))));
            this.DGVforRak.Location = new System.Drawing.Point(15, 219);
            this.DGVforRak.Name = "DGVforRak";
            this.DGVforRak.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(158)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(142)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVforRak.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVforRak.RowHeadersWidth = 40;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(156)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(147)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.DGVforRak.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVforRak.Size = new System.Drawing.Size(308, 180);
            this.DGVforRak.TabIndex = 4;
            this.DGVforRak.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVforRak_CellContentClick);
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(156)))), ((int)(((byte)(193)))));
            this.button1.Location = new System.Drawing.Point(34, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add Item";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(108)))), ((int)(((byte)(178)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(146, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 32);
            this.button2.TabIndex = 7;
            this.button2.Text = "Send Item";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(1, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(670, 29);
            this.panel2.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(639, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(23, 23);
            this.button3.TabIndex = 9;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(156)))), ((int)(((byte)(183)))));
            this.label7.Location = new System.Drawing.Point(514, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Right Drawer Location ";
            // 
            // RDGVForRak
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(156)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(142)))), ((int)(((byte)(76)))));
            this.RDGVForRak.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.RDGVForRak.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(51)))));
            this.RDGVForRak.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(156)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(147)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RDGVForRak.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.RDGVForRak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(156)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(142)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RDGVForRak.DefaultCellStyle = dataGridViewCellStyle8;
            this.RDGVForRak.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(158)))), ((int)(((byte)(188)))));
            this.RDGVForRak.Location = new System.Drawing.Point(379, 219);
            this.RDGVForRak.Name = "RDGVForRak";
            this.RDGVForRak.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(158)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(142)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RDGVForRak.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.RDGVForRak.RowHeadersWidth = 40;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(156)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(147)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.RDGVForRak.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.RDGVForRak.Size = new System.Drawing.Size(292, 180);
            this.RDGVForRak.TabIndex = 11;
            this.RDGVForRak.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RDGVForRak_CellContentClick);
            // 
            // Additem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(696, 422);
            this.Controls.Add(this.RDGVForRak);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.DGVforRak);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_scannedcode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Additem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Additem";
            this.Load += new System.EventHandler(this.Additem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVforRak)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RDGVForRak)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_scannedcode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView DGVforRak;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_Grade;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView RDGVForRak;
    }
}