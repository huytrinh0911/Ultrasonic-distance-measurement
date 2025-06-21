namespace GiaoDien_HCSR04
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
            this.components = new System.ComponentModel.Container();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnEsc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTrangthai = new System.Windows.Forms.Label();
            this.cboCom = new System.Windows.Forms.ComboBox();
            this.cboBaurate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSendA = new System.Windows.Forms.Button();
            this.btnSendB = new System.Windows.Forms.Button();
            this.txtGtrA = new System.Windows.Forms.TextBox();
            this.txtGtrB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.txtDataReceive = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.Lime;
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ForeColor = System.Drawing.Color.Black;
            this.btnConnect.Location = new System.Drawing.Point(6, 70);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(115, 61);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Kết nối";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.BackColor = System.Drawing.Color.LightCoral;
            this.btnDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnect.ForeColor = System.Drawing.Color.Black;
            this.btnDisconnect.Location = new System.Drawing.Point(127, 70);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(121, 61);
            this.btnDisconnect.TabIndex = 6;
            this.btnDisconnect.Text = "Ngắt kết nối";
            this.btnDisconnect.UseVisualStyleBackColor = false;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnEsc
            // 
            this.btnEsc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEsc.ForeColor = System.Drawing.Color.Red;
            this.btnEsc.Location = new System.Drawing.Point(3, 3);
            this.btnEsc.Name = "btnEsc";
            this.btnEsc.Size = new System.Drawing.Size(75, 35);
            this.btnEsc.TabIndex = 7;
            this.btnEsc.Text = "Thoát";
            this.btnEsc.UseVisualStyleBackColor = false;
            this.btnEsc.Click += new System.EventHandler(this.btnEsc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Trạng thái: ";
            // 
            // lbTrangthai
            // 
            this.lbTrangthai.AutoSize = true;
            this.lbTrangthai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrangthai.Location = new System.Drawing.Point(114, 29);
            this.lbTrangthai.Name = "lbTrangthai";
            this.lbTrangthai.Size = new System.Drawing.Size(77, 22);
            this.lbTrangthai.TabIndex = 9;
            this.lbTrangthai.Text = "Chưa kn";
            // 
            // cboCom
            // 
            this.cboCom.FormattingEnabled = true;
            this.cboCom.Location = new System.Drawing.Point(145, 115);
            this.cboCom.Name = "cboCom";
            this.cboCom.Size = new System.Drawing.Size(121, 24);
            this.cboCom.TabIndex = 3;
            // 
            // cboBaurate
            // 
            this.cboBaurate.FormattingEnabled = true;
            this.cboBaurate.Location = new System.Drawing.Point(127, 73);
            this.cboBaurate.Name = "cboBaurate";
            this.cboBaurate.Size = new System.Drawing.Size(121, 24);
            this.cboBaurate.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Com:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Baudrate:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboBaurate);
            this.groupBox1.Location = new System.Drawing.Point(18, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 128);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Communication";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(139, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(466, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "ĐO VÀ HIỂN THỊ KHOẢNG CÁCH";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnConnect);
            this.groupBox2.Controls.Add(this.btnDisconnect);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lbTrangthai);
            this.groupBox2.Location = new System.Drawing.Point(18, 241);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 137);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connection";
            // 
            // btnSendA
            // 
            this.btnSendA.Location = new System.Drawing.Point(274, 26);
            this.btnSendA.Name = "btnSendA";
            this.btnSendA.Size = new System.Drawing.Size(72, 34);
            this.btnSendA.TabIndex = 15;
            this.btnSendA.Text = "Enter";
            this.btnSendA.UseVisualStyleBackColor = true;
            this.btnSendA.Click += new System.EventHandler(this.btnSendA_Click);
            // 
            // btnSendB
            // 
            this.btnSendB.Location = new System.Drawing.Point(274, 64);
            this.btnSendB.Name = "btnSendB";
            this.btnSendB.Size = new System.Drawing.Size(72, 35);
            this.btnSendB.TabIndex = 16;
            this.btnSendB.Text = "Enter";
            this.btnSendB.UseVisualStyleBackColor = true;
            this.btnSendB.Click += new System.EventHandler(this.btnSendB_Click);
            // 
            // txtGtrA
            // 
            this.txtGtrA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGtrA.Location = new System.Drawing.Point(466, 112);
            this.txtGtrA.Multiline = true;
            this.txtGtrA.Name = "txtGtrA";
            this.txtGtrA.Size = new System.Drawing.Size(102, 32);
            this.txtGtrA.TabIndex = 17;
            // 
            // txtGtrB
            // 
            this.txtGtrB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGtrB.Location = new System.Drawing.Point(115, 67);
            this.txtGtrB.Multiline = true;
            this.txtGtrB.Name = "txtGtrB";
            this.txtGtrB.Size = new System.Drawing.Size(102, 33);
            this.txtGtrB.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 22);
            this.label5.TabIndex = 19;
            this.label5.Text = "Giá trị đầu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 22);
            this.label6.TabIndex = 20;
            this.label6.Text = "Giá trị cuối:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtGtrB);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnSendA);
            this.groupBox3.Controls.Add(this.btnSendB);
            this.groupBox3.Location = new System.Drawing.Point(351, 84);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(356, 128);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Calibration";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // txtDataReceive
            // 
            this.txtDataReceive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataReceive.Location = new System.Drawing.Point(83, 76);
            this.txtDataReceive.Multiline = true;
            this.txtDataReceive.Name = "txtDataReceive";
            this.txtDataReceive.Size = new System.Drawing.Size(155, 32);
            this.txtDataReceive.TabIndex = 22;
            this.txtDataReceive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(372, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 22);
            this.label7.TabIndex = 23;
            this.label7.Text = "Khoảng cách:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(244, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 22);
            this.label8.TabIndex = 24;
            this.label8.Text = "Cm";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtDataReceive);
            this.groupBox4.Location = new System.Drawing.Point(351, 241);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(346, 126);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Display";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(223, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 22);
            this.label9.TabIndex = 25;
            this.label9.Text = "Cm";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(223, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 22);
            this.label10.TabIndex = 26;
            this.label10.Text = "Cm";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 420);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtGtrA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboCom);
            this.Controls.Add(this.btnEsc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnEsc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTrangthai;
        private System.Windows.Forms.ComboBox cboCom;
        private System.Windows.Forms.ComboBox cboBaurate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSendA;
        private System.Windows.Forms.Button btnSendB;
        private System.Windows.Forms.TextBox txtGtrA;
        private System.Windows.Forms.TextBox txtGtrB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox txtDataReceive;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

