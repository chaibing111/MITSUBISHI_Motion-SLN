namespace _01_MITS_Dev
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
            this.Btn_ConnectMSPLC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_IP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Port = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSName = new System.Windows.Forms.TextBox();
            this.txt_Number = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.rad_Open = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Btn_ConnectMSPLC
            // 
            this.Btn_ConnectMSPLC.Location = new System.Drawing.Point(510, 63);
            this.Btn_ConnectMSPLC.Name = "Btn_ConnectMSPLC";
            this.Btn_ConnectMSPLC.Size = new System.Drawing.Size(136, 40);
            this.Btn_ConnectMSPLC.TabIndex = 0;
            this.Btn_ConnectMSPLC.Text = "连接三菱FX5U";
            this.Btn_ConnectMSPLC.UseVisualStyleBackColor = true;
            this.Btn_ConnectMSPLC.Click += new System.EventHandler(this.Btn_ConnectMSPLC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP地址：";
            // 
            // txt_IP
            // 
            this.txt_IP.Location = new System.Drawing.Point(103, 72);
            this.txt_IP.Name = "txt_IP";
            this.txt_IP.Size = new System.Drawing.Size(125, 27);
            this.txt_IP.TabIndex = 2;
            this.txt_IP.Text = "192.168.12.200";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "端口：";
            // 
            // txt_Port
            // 
            this.txt_Port.Location = new System.Drawing.Point(330, 70);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(125, 27);
            this.txt_Port.TabIndex = 2;
            this.txt_Port.Text = "7000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "软元件名称：";
            // 
            // txtSName
            // 
            this.txtSName.Location = new System.Drawing.Point(146, 126);
            this.txtSName.Name = "txtSName";
            this.txtSName.Size = new System.Drawing.Size(59, 27);
            this.txtSName.TabIndex = 2;
            this.txtSName.Text = "M";
            // 
            // txt_Number
            // 
            this.txt_Number.Location = new System.Drawing.Point(328, 126);
            this.txt_Number.Name = "txt_Number";
            this.txt_Number.Size = new System.Drawing.Size(59, 27);
            this.txt_Number.TabIndex = 2;
            this.txt_Number.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "软元件地址：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(549, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "写入点位";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rad_Open
            // 
            this.rad_Open.AutoSize = true;
            this.rad_Open.Checked = true;
            this.rad_Open.Location = new System.Drawing.Point(413, 127);
            this.rad_Open.Name = "rad_Open";
            this.rad_Open.Size = new System.Drawing.Size(45, 24);
            this.rad_Open.TabIndex = 4;
            this.rad_Open.TabStop = true;
            this.rad_Open.Text = "开";
            this.rad_Open.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(475, 127);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(45, 24);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "关";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.rad_Open);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Port);
            this.Controls.Add(this.txt_Number);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSName);
            this.Controls.Add(this.txt_IP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_ConnectMSPLC);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Btn_ConnectMSPLC;
        private Label label1;
        private TextBox txt_IP;
        private Label label2;
        private TextBox txt_Port;
        private Label label3;
        private TextBox txtSName;
        private TextBox txt_Number;
        private Label label4;
        private Button button1;
        private RadioButton rad_Open;
        private RadioButton radioButton2;
    }
}