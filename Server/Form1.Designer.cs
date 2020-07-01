namespace Server
{
    partial class Server
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
            this.tbMess = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSend = new System.Windows.Forms.TextBox();
            this.tbDecode = new System.Windows.Forms.TextBox();
            this.tbKeySend = new System.Windows.Forms.TextBox();
            this.tbKeyDecode = new System.Windows.Forms.TextBox();
            this.butSend = new System.Windows.Forms.Button();
            this.butDecode = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.butStart = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbMess
            // 
            this.tbMess.Location = new System.Drawing.Point(12, 39);
            this.tbMess.Multiline = true;
            this.tbMess.Name = "tbMess";
            this.tbMess.ReadOnly = true;
            this.tbMess.Size = new System.Drawing.Size(310, 260);
            this.tbMess.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Message list";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(319, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(342, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Encrypt and decode data";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbSend
            // 
            this.tbSend.Location = new System.Drawing.Point(343, 113);
            this.tbSend.Multiline = true;
            this.tbSend.Name = "tbSend";
            this.tbSend.Size = new System.Drawing.Size(170, 50);
            this.tbSend.TabIndex = 3;
            // 
            // tbDecode
            // 
            this.tbDecode.Location = new System.Drawing.Point(343, 222);
            this.tbDecode.Multiline = true;
            this.tbDecode.Name = "tbDecode";
            this.tbDecode.ReadOnly = true;
            this.tbDecode.Size = new System.Drawing.Size(170, 50);
            this.tbDecode.TabIndex = 4;
            // 
            // tbKeySend
            // 
            this.tbKeySend.Location = new System.Drawing.Point(519, 128);
            this.tbKeySend.Name = "tbKeySend";
            this.tbKeySend.Size = new System.Drawing.Size(80, 20);
            this.tbKeySend.TabIndex = 5;
            // 
            // tbKeyDecode
            // 
            this.tbKeyDecode.Location = new System.Drawing.Point(519, 236);
            this.tbKeyDecode.Name = "tbKeyDecode";
            this.tbKeyDecode.Size = new System.Drawing.Size(80, 20);
            this.tbKeyDecode.TabIndex = 6;
            // 
            // butSend
            // 
            this.butSend.Location = new System.Drawing.Point(605, 128);
            this.butSend.Name = "butSend";
            this.butSend.Size = new System.Drawing.Size(55, 20);
            this.butSend.TabIndex = 7;
            this.butSend.Text = "Send";
            this.butSend.UseVisualStyleBackColor = true;
            this.butSend.Click += new System.EventHandler(this.butSend_Click);
            // 
            // butDecode
            // 
            this.butDecode.Location = new System.Drawing.Point(605, 236);
            this.butDecode.Name = "butDecode";
            this.butDecode.Size = new System.Drawing.Size(55, 20);
            this.butDecode.TabIndex = 8;
            this.butDecode.Text = "Decode";
            this.butDecode.UseVisualStyleBackColor = true;
            this.butDecode.Click += new System.EventHandler(this.butDecode_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(340, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Encrypt and send data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(340, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Receive and decode data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(548, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Key";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(548, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Key";
            // 
            // butStart
            // 
            this.butStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butStart.Location = new System.Drawing.Point(401, 49);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(228, 23);
            this.butStart.TabIndex = 13;
            this.butStart.Text = "Start server";
            this.butStart.UseVisualStyleBackColor = true;
            this.butStart.Click += new System.EventHandler(this.butStart_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(340, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Status :";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.Color.Red;
            this.labelStatus.Location = new System.Drawing.Point(388, 283);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(79, 16);
            this.labelStatus.TabIndex = 15;
            this.labelStatus.Text = "Not connect";
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 311);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.butStart);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.butDecode);
            this.Controls.Add(this.butSend);
            this.Controls.Add(this.tbKeyDecode);
            this.Controls.Add(this.tbKeySend);
            this.Controls.Add(this.tbDecode);
            this.Controls.Add(this.tbSend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMess);
            this.Name = "Server";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSend;
        private System.Windows.Forms.TextBox tbDecode;
        private System.Windows.Forms.TextBox tbKeySend;
        private System.Windows.Forms.TextBox tbKeyDecode;
        private System.Windows.Forms.Button butSend;
        private System.Windows.Forms.Button butDecode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button butStart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelStatus;
    }
}

