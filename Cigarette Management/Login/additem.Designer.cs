namespace Login
{
    partial class additem
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
            this.showbahan = new System.Windows.Forms.DataGridView();
            this.txt_listbahan = new System.Windows.Forms.TextBox();
            this.btn_searchbahan = new System.Windows.Forms.Button();
            this.btn_addbahan = new System.Windows.Forms.Button();
            this.btn_editbahan = new System.Windows.Forms.Button();
            this.btn_deletebahan = new System.Windows.Forms.Button();
            this.btn_insertdrawer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.showbahan)).BeginInit();
            this.SuspendLayout();
            // 
            // showbahan
            // 
            this.showbahan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showbahan.Location = new System.Drawing.Point(12, 53);
            this.showbahan.Name = "showbahan";
            this.showbahan.Size = new System.Drawing.Size(378, 221);
            this.showbahan.TabIndex = 0;
            // 
            // txt_listbahan
            // 
            this.txt_listbahan.Location = new System.Drawing.Point(13, 27);
            this.txt_listbahan.Name = "txt_listbahan";
            this.txt_listbahan.Size = new System.Drawing.Size(377, 20);
            this.txt_listbahan.TabIndex = 1;
            this.txt_listbahan.Text = "Search List Bahan";
            this.txt_listbahan.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_listbahan_MouseClick);
            this.txt_listbahan.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txt_listbahan.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_listbahan_KeyUp);
            // 
            // btn_searchbahan
            // 
            this.btn_searchbahan.Location = new System.Drawing.Point(408, 27);
            this.btn_searchbahan.Name = "btn_searchbahan";
            this.btn_searchbahan.Size = new System.Drawing.Size(114, 20);
            this.btn_searchbahan.TabIndex = 2;
            this.btn_searchbahan.Text = "Search";
            this.btn_searchbahan.UseVisualStyleBackColor = true;
            this.btn_searchbahan.Click += new System.EventHandler(this.btn_searchbahan_Click);
            // 
            // btn_addbahan
            // 
            this.btn_addbahan.Location = new System.Drawing.Point(408, 53);
            this.btn_addbahan.Name = "btn_addbahan";
            this.btn_addbahan.Size = new System.Drawing.Size(114, 23);
            this.btn_addbahan.TabIndex = 3;
            this.btn_addbahan.Text = "add bahan";
            this.btn_addbahan.UseVisualStyleBackColor = true;
            this.btn_addbahan.Click += new System.EventHandler(this.btn_addbahan_Click);
            // 
            // btn_editbahan
            // 
            this.btn_editbahan.Location = new System.Drawing.Point(408, 82);
            this.btn_editbahan.Name = "btn_editbahan";
            this.btn_editbahan.Size = new System.Drawing.Size(114, 23);
            this.btn_editbahan.TabIndex = 4;
            this.btn_editbahan.Text = "edit bahan";
            this.btn_editbahan.UseVisualStyleBackColor = true;
            // 
            // btn_deletebahan
            // 
            this.btn_deletebahan.Location = new System.Drawing.Point(408, 111);
            this.btn_deletebahan.Name = "btn_deletebahan";
            this.btn_deletebahan.Size = new System.Drawing.Size(114, 23);
            this.btn_deletebahan.TabIndex = 5;
            this.btn_deletebahan.Text = "delete bahan";
            this.btn_deletebahan.UseVisualStyleBackColor = true;
            // 
            // btn_insertdrawer
            // 
            this.btn_insertdrawer.Location = new System.Drawing.Point(408, 211);
            this.btn_insertdrawer.Name = "btn_insertdrawer";
            this.btn_insertdrawer.Size = new System.Drawing.Size(114, 63);
            this.btn_insertdrawer.TabIndex = 6;
            this.btn_insertdrawer.Text = "Insert To Drawer";
            this.btn_insertdrawer.UseVisualStyleBackColor = true;
            // 
            // additem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 286);
            this.Controls.Add(this.btn_insertdrawer);
            this.Controls.Add(this.btn_deletebahan);
            this.Controls.Add(this.btn_editbahan);
            this.Controls.Add(this.btn_addbahan);
            this.Controls.Add(this.btn_searchbahan);
            this.Controls.Add(this.txt_listbahan);
            this.Controls.Add(this.showbahan);
            this.Name = "additem";
            this.Text = "Tambah Bahan";
            this.Load += new System.EventHandler(this.additem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showbahan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView showbahan;
        private System.Windows.Forms.TextBox txt_listbahan;
        private System.Windows.Forms.Button btn_searchbahan;
        private System.Windows.Forms.Button btn_addbahan;
        private System.Windows.Forms.Button btn_editbahan;
        private System.Windows.Forms.Button btn_deletebahan;
        private System.Windows.Forms.Button btn_insertdrawer;
    }
}