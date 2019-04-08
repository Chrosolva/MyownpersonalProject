namespace Login
{
    partial class Recipes
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
            this.Dgvforrecipelist = new System.Windows.Forms.DataGridView();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgvforrecipelist)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgvforrecipelist
            // 
            this.Dgvforrecipelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgvforrecipelist.Location = new System.Drawing.Point(12, 47);
            this.Dgvforrecipelist.Name = "Dgvforrecipelist";
            this.Dgvforrecipelist.Size = new System.Drawing.Size(294, 185);
            this.Dgvforrecipelist.TabIndex = 0;
            this.Dgvforrecipelist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(312, 47);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(107, 23);
            this.btn_create.TabIndex = 4;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(312, 209);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(107, 23);
            this.btn_back.TabIndex = 5;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Recipe Information";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btn_update
            // 
            this.btn_update.Enabled = false;
            this.btn_update.Location = new System.Drawing.Point(312, 76);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(107, 23);
            this.btn_update.TabIndex = 10;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Enabled = false;
            this.btn_delete.Location = new System.Drawing.Point(312, 105);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(107, 23);
            this.btn_delete.TabIndex = 11;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(312, 12);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(107, 23);
            this.btn_refresh.TabIndex = 12;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // Recipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 261);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.Dgvforrecipelist);
            this.Name = "Recipes";
            this.Text = "MakeRecipe";
            this.Load += new System.EventHandler(this.MakeRecipe_Load);
            this.Click += new System.EventHandler(this.Recipes_Click);
            ((System.ComponentModel.ISupportInitialize)(this.Dgvforrecipelist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgvforrecipelist;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_refresh;
    }
}