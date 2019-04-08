namespace Login
{
    partial class testing
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxParityBits = new System.Windows.Forms.ComboBox();
            this.cBoxStopBits = new System.Windows.Forms.ComboBox();
            this.cBoxDataBits = new System.Windows.Forms.ComboBox();
            this.cBoxBuildRate = new System.Windows.Forms.ComboBox();
            this.cBoxCOMPORT = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSendData = new System.Windows.Forms.Button();
            this.txtBoxDataOut = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblDataInlength = new System.Windows.Forms.Label();
            this.chBoxAddtoOldData = new System.Windows.Forms.CheckBox();
            this.chBoxAlwaysUpdate = new System.Windows.Forms.CheckBox();
            this.btnClearDataIn = new System.Windows.Forms.Button();
            this.txtBoxdataIn = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cBoxParityBits);
            this.groupBox1.Controls.Add(this.cBoxStopBits);
            this.groupBox1.Controls.Add(this.cBoxDataBits);
            this.groupBox1.Controls.Add(this.cBoxBuildRate);
            this.groupBox1.Controls.Add(this.cBoxCOMPORT);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 186);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Com Port Control";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Parity  Bits";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Stop Bits";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data Bits";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Build Rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Com Port";
            // 
            // cBoxParityBits
            // 
            this.cBoxParityBits.FormattingEnabled = true;
            this.cBoxParityBits.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cBoxParityBits.Location = new System.Drawing.Point(74, 136);
            this.cBoxParityBits.Name = "cBoxParityBits";
            this.cBoxParityBits.Size = new System.Drawing.Size(121, 21);
            this.cBoxParityBits.TabIndex = 4;
            this.cBoxParityBits.Text = "None";
            // 
            // cBoxStopBits
            // 
            this.cBoxStopBits.FormattingEnabled = true;
            this.cBoxStopBits.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cBoxStopBits.Location = new System.Drawing.Point(74, 109);
            this.cBoxStopBits.Name = "cBoxStopBits";
            this.cBoxStopBits.Size = new System.Drawing.Size(121, 21);
            this.cBoxStopBits.TabIndex = 3;
            this.cBoxStopBits.Text = "One";
            // 
            // cBoxDataBits
            // 
            this.cBoxDataBits.FormattingEnabled = true;
            this.cBoxDataBits.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.cBoxDataBits.Location = new System.Drawing.Point(74, 82);
            this.cBoxDataBits.Name = "cBoxDataBits";
            this.cBoxDataBits.Size = new System.Drawing.Size(121, 21);
            this.cBoxDataBits.TabIndex = 2;
            this.cBoxDataBits.Text = "8";
            // 
            // cBoxBuildRate
            // 
            this.cBoxBuildRate.FormattingEnabled = true;
            this.cBoxBuildRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600"});
            this.cBoxBuildRate.Location = new System.Drawing.Point(74, 55);
            this.cBoxBuildRate.Name = "cBoxBuildRate";
            this.cBoxBuildRate.Size = new System.Drawing.Size(121, 21);
            this.cBoxBuildRate.TabIndex = 1;
            this.cBoxBuildRate.Text = "9600";
            // 
            // cBoxCOMPORT
            // 
            this.cBoxCOMPORT.FormattingEnabled = true;
            this.cBoxCOMPORT.Location = new System.Drawing.Point(74, 19);
            this.cBoxCOMPORT.Name = "cBoxCOMPORT";
            this.cBoxCOMPORT.Size = new System.Drawing.Size(121, 21);
            this.cBoxCOMPORT.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.btnOpen);
            this.groupBox2.Location = new System.Drawing.Point(12, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(195, 91);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(9, 48);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(166, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(100, 19);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "CLose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(9, 19);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSendData
            // 
            this.btnSendData.Location = new System.Drawing.Point(223, 215);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(77, 91);
            this.btnSendData.TabIndex = 3;
            this.btnSendData.Text = "Send Data";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // txtBoxDataOut
            // 
            this.txtBoxDataOut.Location = new System.Drawing.Point(329, 34);
            this.txtBoxDataOut.Multiline = true;
            this.txtBoxDataOut.Name = "txtBoxDataOut";
            this.txtBoxDataOut.Size = new System.Drawing.Size(345, 112);
            this.txtBoxDataOut.TabIndex = 4;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblDataInlength);
            this.groupBox3.Controls.Add(this.chBoxAddtoOldData);
            this.groupBox3.Controls.Add(this.chBoxAlwaysUpdate);
            this.groupBox3.Controls.Add(this.btnClearDataIn);
            this.groupBox3.Controls.Add(this.txtBoxdataIn);
            this.groupBox3.Location = new System.Drawing.Point(329, 173);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(345, 209);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "receivercontrol";
            // 
            // lblDataInlength
            // 
            this.lblDataInlength.AutoSize = true;
            this.lblDataInlength.Location = new System.Drawing.Point(37, 193);
            this.lblDataInlength.Name = "lblDataInlength";
            this.lblDataInlength.Size = new System.Drawing.Size(83, 13);
            this.lblDataInlength.TabIndex = 9;
            this.lblDataInlength.Text = "Data In length : ";
            // 
            // chBoxAddtoOldData
            // 
            this.chBoxAddtoOldData.AutoSize = true;
            this.chBoxAddtoOldData.Location = new System.Drawing.Point(141, 165);
            this.chBoxAddtoOldData.Name = "chBoxAddtoOldData";
            this.chBoxAddtoOldData.Size = new System.Drawing.Size(102, 17);
            this.chBoxAddtoOldData.TabIndex = 8;
            this.chBoxAddtoOldData.Text = "Add to Old Data";
            this.chBoxAddtoOldData.UseVisualStyleBackColor = true;
            // 
            // chBoxAlwaysUpdate
            // 
            this.chBoxAlwaysUpdate.AutoSize = true;
            this.chBoxAlwaysUpdate.Location = new System.Drawing.Point(141, 138);
            this.chBoxAlwaysUpdate.Name = "chBoxAlwaysUpdate";
            this.chBoxAlwaysUpdate.Size = new System.Drawing.Size(97, 17);
            this.chBoxAlwaysUpdate.TabIndex = 7;
            this.chBoxAlwaysUpdate.Text = "Always Update";
            this.chBoxAlwaysUpdate.UseVisualStyleBackColor = true;
            // 
            // btnClearDataIn
            // 
            this.btnClearDataIn.Location = new System.Drawing.Point(17, 133);
            this.btnClearDataIn.Name = "btnClearDataIn";
            this.btnClearDataIn.Size = new System.Drawing.Size(97, 23);
            this.btnClearDataIn.TabIndex = 6;
            this.btnClearDataIn.Text = "Clear Data In";
            this.btnClearDataIn.UseVisualStyleBackColor = true;
            // 
            // txtBoxdataIn
            // 
            this.txtBoxdataIn.Location = new System.Drawing.Point(6, 19);
            this.txtBoxdataIn.Name = "txtBoxdataIn";
            this.txtBoxdataIn.Size = new System.Drawing.Size(333, 108);
            this.txtBoxdataIn.TabIndex = 0;
            this.txtBoxdataIn.Text = "";
            // 
            // testing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 409);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtBoxDataOut);
            this.Controls.Add(this.btnSendData);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "testing";
            this.Text = "C# Com Port Serial ";
            this.Load += new System.EventHandler(this.testing_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxParityBits;
        private System.Windows.Forms.ComboBox cBoxStopBits;
        private System.Windows.Forms.ComboBox cBoxDataBits;
        private System.Windows.Forms.ComboBox cBoxBuildRate;
        private System.Windows.Forms.ComboBox cBoxCOMPORT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.TextBox txtBoxDataOut;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblDataInlength;
        private System.Windows.Forms.CheckBox chBoxAddtoOldData;
        private System.Windows.Forms.CheckBox chBoxAlwaysUpdate;
        private System.Windows.Forms.Button btnClearDataIn;
        private System.Windows.Forms.RichTextBox txtBoxdataIn;
    }
}