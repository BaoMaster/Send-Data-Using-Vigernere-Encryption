namespace Client
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
            this.labelStatusClient = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.butConnect = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.butDecodeClient = new System.Windows.Forms.Button();
            this.butSendClient = new System.Windows.Forms.Button();
            this.tbKeyDecodeCLient = new System.Windows.Forms.TextBox();
            this.tbKeySendClient = new System.Windows.Forms.TextBox();
            this.tbDecodeClient = new System.Windows.Forms.TextBox();
            this.tbSendClient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMessClient = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelStatusClient
            // 
            this.labelStatusClient.AutoSize = true;
            this.labelStatusClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatusClient.ForeColor = System.Drawing.Color.Red;
            this.labelStatusClient.Location = new System.Drawing.Point(394, 284);
            this.labelStatusClient.Name = "labelStatusClient";
            this.labelStatusClient.Size = new System.Drawing.Size(79, 16);
            this.labelStatusClient.TabIndex = 31;
            this.labelStatusClient.Text = "Not connect";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(346, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "Status :";
            // 
            // butConnect
            // 
            this.butConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butConnect.Location = new System.Drawing.Point(407, 50);
            this.butConnect.Name = "butConnect";
            this.butConnect.Size = new System.Drawing.Size(228, 23);
            this.butConnect.TabIndex = 29;
            this.butConnect.Text = "Connect with server";
            this.butConnect.UseVisualStyleBackColor = true;
            this.butConnect.Click += new System.EventHandler(this.butConnect_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(554, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Key";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(554, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Key";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(346, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Receive and decode data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(346, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Encrypt and send data";
            // 
            // butDecodeClient
            // 
            this.butDecodeClient.Location = new System.Drawing.Point(611, 237);
            this.butDecodeClient.Name = "butDecodeClient";
            this.butDecodeClient.Size = new System.Drawing.Size(55, 20);
            this.butDecodeClient.TabIndex = 24;
            this.butDecodeClient.Text = "Decode";
            this.butDecodeClient.UseVisualStyleBackColor = true;
            this.butDecodeClient.Click += new System.EventHandler(this.butDecodeClient_Click);
            // 
            // butSendClient
            // 
            this.butSendClient.Location = new System.Drawing.Point(611, 129);
            this.butSendClient.Name = "butSendClient";
            this.butSendClient.Size = new System.Drawing.Size(55, 20);
            this.butSendClient.TabIndex = 23;
            this.butSendClient.Text = "Send";
            this.butSendClient.UseVisualStyleBackColor = true;
            this.butSendClient.Click += new System.EventHandler(this.butSendClient_Click);
            // 
            // tbKeyDecodeCLient
            // 
            this.tbKeyDecodeCLient.Location = new System.Drawing.Point(525, 237);
            this.tbKeyDecodeCLient.Name = "tbKeyDecodeCLient";
            this.tbKeyDecodeCLient.Size = new System.Drawing.Size(80, 20);
            this.tbKeyDecodeCLient.TabIndex = 22;
            // 
            // tbKeySendClient
            // 
            this.tbKeySendClient.Location = new System.Drawing.Point(525, 129);
            this.tbKeySendClient.Name = "tbKeySendClient";
            this.tbKeySendClient.Size = new System.Drawing.Size(80, 20);
            this.tbKeySendClient.TabIndex = 21;
            // 
            // tbDecodeClient
            // 
            this.tbDecodeClient.Location = new System.Drawing.Point(349, 223);
            this.tbDecodeClient.Multiline = true;
            this.tbDecodeClient.Name = "tbDecodeClient";
            this.tbDecodeClient.ReadOnly = true;
            this.tbDecodeClient.Size = new System.Drawing.Size(170, 50);
            this.tbDecodeClient.TabIndex = 20;
            // 
            // tbSendClient
            // 
            this.tbSendClient.Location = new System.Drawing.Point(349, 114);
            this.tbSendClient.Multiline = true;
            this.tbSendClient.Name = "tbSendClient";
            this.tbSendClient.Size = new System.Drawing.Size(170, 50);
            this.tbSendClient.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(325, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(342, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Encrypt and decode data";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Message list";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbMessClient
            // 
            this.tbMessClient.Location = new System.Drawing.Point(18, 40);
            this.tbMessClient.Multiline = true;
            this.tbMessClient.Name = "tbMessClient";
            this.tbMessClient.ReadOnly = true;
            this.tbMessClient.Size = new System.Drawing.Size(310, 260);
            this.tbMessClient.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 311);
            this.Controls.Add(this.labelStatusClient);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.butConnect);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.butDecodeClient);
            this.Controls.Add(this.butSendClient);
            this.Controls.Add(this.tbKeyDecodeCLient);
            this.Controls.Add(this.tbKeySendClient);
            this.Controls.Add(this.tbDecodeClient);
            this.Controls.Add(this.tbSendClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMessClient);
            this.Name = "Form1";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStatusClient;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button butConnect;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butDecodeClient;
        private System.Windows.Forms.Button butSendClient;
        private System.Windows.Forms.TextBox tbKeyDecodeCLient;
        private System.Windows.Forms.TextBox tbKeySendClient;
        private System.Windows.Forms.TextBox tbDecodeClient;
        private System.Windows.Forms.TextBox tbSendClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMessClient;
    }
}

