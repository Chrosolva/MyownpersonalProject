namespace Login
{
    partial class Createrecipe
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DGVforIngredientsList = new System.Windows.Forms.DataGridView();
            this.txt_recipename = new System.Windows.Forms.TextBox();
            this.btn_create = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_namarokok = new System.Windows.Forms.TextBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.lbl_foridrokok = new System.Windows.Forms.Label();
            this.cbxRokok = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVforIngredientsList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recipe Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingredients List";
            // 
            // DGVforIngredientsList
            // 
            this.DGVforIngredientsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVforIngredientsList.Location = new System.Drawing.Point(15, 122);
            this.DGVforIngredientsList.Name = "DGVforIngredientsList";
            this.DGVforIngredientsList.Size = new System.Drawing.Size(351, 190);
            this.DGVforIngredientsList.TabIndex = 2;
            // 
            // txt_recipename
            // 
            this.txt_recipename.Location = new System.Drawing.Point(102, 6);
            this.txt_recipename.Name = "txt_recipename";
            this.txt_recipename.Size = new System.Drawing.Size(264, 20);
            this.txt_recipename.TabIndex = 3;
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(291, 318);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(75, 23);
            this.btn_create.TabIndex = 4;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Id Rokok";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nama Rokok";
            // 
            // txt_namarokok
            // 
            this.txt_namarokok.Location = new System.Drawing.Point(102, 66);
            this.txt_namarokok.Name = "txt_namarokok";
            this.txt_namarokok.Size = new System.Drawing.Size(109, 20);
            this.txt_namarokok.TabIndex = 7;
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(309, 64);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(57, 23);
            this.btn_browse.TabIndex = 8;
            this.btn_browse.Text = "New";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // lbl_foridrokok
            // 
            this.lbl_foridrokok.AutoSize = true;
            this.lbl_foridrokok.Location = new System.Drawing.Point(99, 42);
            this.lbl_foridrokok.Name = "lbl_foridrokok";
            this.lbl_foridrokok.Size = new System.Drawing.Size(0, 13);
            this.lbl_foridrokok.TabIndex = 9;
            // 
            // cbxRokok
            // 
            this.cbxRokok.FormattingEnabled = true;
            this.cbxRokok.Location = new System.Drawing.Point(217, 66);
            this.cbxRokok.Name = "cbxRokok";
            this.cbxRokok.Size = new System.Drawing.Size(86, 21);
            this.cbxRokok.TabIndex = 10;
            this.cbxRokok.SelectedIndexChanged += new System.EventHandler(this.cbxRokok_SelectedIndexChanged);
            // 
            // Createrecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 353);
            this.Controls.Add(this.cbxRokok);
            this.Controls.Add(this.lbl_foridrokok);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.txt_namarokok);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.txt_recipename);
            this.Controls.Add(this.DGVforIngredientsList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Createrecipe";
            this.Text = "Createrecipe";
            ((System.ComponentModel.ISupportInitialize)(this.DGVforIngredientsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGVforIngredientsList;
        private System.Windows.Forms.TextBox txt_recipename;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_namarokok;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.Label lbl_foridrokok;
        private System.Windows.Forms.ComboBox cbxRokok;
    }
}