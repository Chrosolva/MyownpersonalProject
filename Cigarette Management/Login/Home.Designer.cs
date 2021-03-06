﻿namespace Login
{
    partial class Home
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
            this.showdrawer = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_checkdrawer = new System.Windows.Forms.Button();
            this.btn_sendlocation = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.lbl_user = new System.Windows.Forms.Label();
            this.btn_receipt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_srch = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.showdrawer)).BeginInit();
            this.SuspendLayout();
            // 
            // showdrawer
            // 
            this.showdrawer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showdrawer.Location = new System.Drawing.Point(12, 65);
            this.showdrawer.Name = "showdrawer";
            this.showdrawer.Size = new System.Drawing.Size(416, 237);
            this.showdrawer.TabIndex = 0;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(435, 65);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 39);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Add item";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(435, 119);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 36);
            this.btn_edit.TabIndex = 2;
            this.btn_edit.Text = "Edit Item";
            this.btn_edit.UseVisualStyleBackColor = true;
            // 
            // btn_checkdrawer
            // 
            this.btn_checkdrawer.Location = new System.Drawing.Point(516, 119);
            this.btn_checkdrawer.Name = "btn_checkdrawer";
            this.btn_checkdrawer.Size = new System.Drawing.Size(75, 36);
            this.btn_checkdrawer.TabIndex = 3;
            this.btn_checkdrawer.Text = "Check Drawer";
            this.btn_checkdrawer.UseVisualStyleBackColor = true;
            // 
            // btn_sendlocation
            // 
            this.btn_sendlocation.Location = new System.Drawing.Point(434, 260);
            this.btn_sendlocation.Name = "btn_sendlocation";
            this.btn_sendlocation.Size = new System.Drawing.Size(157, 39);
            this.btn_sendlocation.TabIndex = 4;
            this.btn_sendlocation.Text = "Send Location";
            this.btn_sendlocation.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(516, 66);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 39);
            this.btn_delete.TabIndex = 6;
            this.btn_delete.Text = "Delete Item";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Location = new System.Drawing.Point(12, 13);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(29, 13);
            this.lbl_user.TabIndex = 7;
            this.lbl_user.Text = "User";
            // 
            // btn_receipt
            // 
            this.btn_receipt.Location = new System.Drawing.Point(435, 204);
            this.btn_receipt.Name = "btn_receipt";
            this.btn_receipt.Size = new System.Drawing.Size(156, 39);
            this.btn_receipt.TabIndex = 8;
            this.btn_receipt.Text = "Make receipt";
            this.btn_receipt.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Drawer List";
            // 
            // txt_srch
            // 
            this.txt_srch.Location = new System.Drawing.Point(90, 39);
            this.txt_srch.Name = "txt_srch";
            this.txt_srch.Size = new System.Drawing.Size(338, 20);
            this.txt_srch.TabIndex = 10;
            this.txt_srch.Text = " Search Drawer";
            this.txt_srch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_srch_MouseClick);
            this.txt_srch.TextChanged += new System.EventHandler(this.txt_srch_TextChanged);
            this.txt_srch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_srch_KeyUp);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(435, 37);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(156, 23);
            this.btn_search.TabIndex = 11;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 314);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_srch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_receipt);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_sendlocation);
            this.Controls.Add(this.btn_checkdrawer);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.showdrawer);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showdrawer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView showdrawer;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_checkdrawer;
        private System.Windows.Forms.Button btn_sendlocation;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Button btn_receipt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_srch;
        private System.Windows.Forms.Button btn_search;
    }
}