namespace opc_ua
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
            this.connectButton = new System.Windows.Forms.Button();
            this.readButton = new System.Windows.Forms.Button();
            this.serverAddress = new System.Windows.Forms.TextBox();
            this.nodeToWrite = new System.Windows.Forms.TextBox();
            this.valueToWrite = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.connectStatus = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.valueOfRead = new System.Windows.Forms.Label();
            this.valueAfterWrite = new System.Windows.Forms.Label();
            this.nodeToRead = new System.Windows.Forms.TextBox();
            this.writeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(556, 61);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 0;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(556, 172);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(75, 23);
            this.readButton.TabIndex = 0;
            this.readButton.Text = "Read";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // serverAddress
            // 
            this.serverAddress.Location = new System.Drawing.Point(229, 61);
            this.serverAddress.Name = "serverAddress";
            this.serverAddress.Size = new System.Drawing.Size(282, 22);
            this.serverAddress.TabIndex = 1;
            // 
            // nodeToWrite
            // 
            this.nodeToWrite.Location = new System.Drawing.Point(229, 290);
            this.nodeToWrite.Name = "nodeToWrite";
            this.nodeToWrite.Size = new System.Drawing.Size(282, 22);
            this.nodeToWrite.TabIndex = 1;
            // 
            // valueToWrite
            // 
            this.valueToWrite.Location = new System.Drawing.Point(229, 341);
            this.valueToWrite.Name = "valueToWrite";
            this.valueToWrite.Size = new System.Drawing.Size(282, 22);
            this.valueToWrite.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Server Address : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Conection Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "label1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Node Value";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Node To Write ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Value To Write";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(89, 384);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "New Value";
            // 
            // connectStatus
            // 
            this.connectStatus.AutoSize = true;
            this.connectStatus.Location = new System.Drawing.Point(226, 102);
            this.connectStatus.Name = "connectStatus";
            this.connectStatus.Size = new System.Drawing.Size(32, 17);
            this.connectStatus.TabIndex = 2;
            this.connectStatus.Text = "???";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(89, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Node To Read";
            // 
            // valueOfRead
            // 
            this.valueOfRead.AutoSize = true;
            this.valueOfRead.Location = new System.Drawing.Point(226, 220);
            this.valueOfRead.Name = "valueOfRead";
            this.valueOfRead.Size = new System.Drawing.Size(32, 17);
            this.valueOfRead.TabIndex = 2;
            this.valueOfRead.Text = "???";
            // 
            // valueAfterWrite
            // 
            this.valueAfterWrite.AutoSize = true;
            this.valueAfterWrite.Location = new System.Drawing.Point(226, 384);
            this.valueAfterWrite.Name = "valueAfterWrite";
            this.valueAfterWrite.Size = new System.Drawing.Size(32, 17);
            this.valueAfterWrite.TabIndex = 2;
            this.valueAfterWrite.Text = "???";
            // 
            // nodeToRead
            // 
            this.nodeToRead.Location = new System.Drawing.Point(229, 169);
            this.nodeToRead.Name = "nodeToRead";
            this.nodeToRead.Size = new System.Drawing.Size(282, 22);
            this.nodeToRead.TabIndex = 1;
            this.nodeToRead.TextChanged += new System.EventHandler(this.nodeToRead_TextChanged);
            // 
            // writeButton
            // 
            this.writeButton.Location = new System.Drawing.Point(556, 290);
            this.writeButton.Name = "writeButton";
            this.writeButton.Size = new System.Drawing.Size(75, 23);
            this.writeButton.TabIndex = 3;
            this.writeButton.Text = "Write";
            this.writeButton.UseVisualStyleBackColor = true;
            this.writeButton.Click += new System.EventHandler(this.writeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.writeButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.valueAfterWrite);
            this.Controls.Add(this.valueOfRead);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.connectStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.valueToWrite);
            this.Controls.Add(this.nodeToWrite);
            this.Controls.Add(this.nodeToRead);
            this.Controls.Add(this.serverAddress);
            this.Controls.Add(this.readButton);
            this.Controls.Add(this.connectButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.TextBox serverAddress;
        private System.Windows.Forms.TextBox nodeToWrite;
        private System.Windows.Forms.TextBox valueToWrite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label connectStatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label valueOfRead;
        private System.Windows.Forms.Label valueAfterWrite;
        private System.Windows.Forms.TextBox nodeToRead;
        private System.Windows.Forms.Button writeButton;
    }
}

