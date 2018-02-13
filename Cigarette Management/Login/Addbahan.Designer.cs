namespace Login
{
    partial class Addbahan
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
            this.txt_namabahan = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.btn_addbahan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID_Bahan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama_Bahan";
            // 
            // txt_namabahan
            // 
            this.txt_namabahan.Location = new System.Drawing.Point(91, 57);
            this.txt_namabahan.Name = "txt_namabahan";
            this.txt_namabahan.Size = new System.Drawing.Size(100, 20);
            this.txt_namabahan.TabIndex = 2;
            this.txt_namabahan.TextChanged += new System.EventHandler(this.txt_namabahan_TextChanged);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(88, 23);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(85, 13);
            this.lbl_id.TabIndex = 3;
            this.lbl_id.Text = "Auto_Generated";
            // 
            // btn_addbahan
            // 
            this.btn_addbahan.Location = new System.Drawing.Point(16, 98);
            this.btn_addbahan.Name = "btn_addbahan";
            this.btn_addbahan.Size = new System.Drawing.Size(175, 23);
            this.btn_addbahan.TabIndex = 4;
            this.btn_addbahan.Text = "Insert Bahan";
            this.btn_addbahan.UseVisualStyleBackColor = true;
            this.btn_addbahan.Click += new System.EventHandler(this.btn_addbahan_Click);
            // 
            // Addbahan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 149);
            this.Controls.Add(this.btn_addbahan);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.txt_namabahan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Addbahan";
            this.Text = "Addbahan";
            this.Load += new System.EventHandler(this.Addbahan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_namabahan;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Button btn_addbahan;
    }
}