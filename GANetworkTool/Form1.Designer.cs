namespace GANetworkTool
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
            this.lstSystemMessage = new System.Windows.Forms.ListBox();
            this.btnShowNICS = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtSubnet = new System.Windows.Forms.TextBox();
            this.txtGateway = new System.Windows.Forms.TextBox();
            this.btnSetAdapter = new System.Windows.Forms.Button();
            this.btnEnable = new System.Windows.Forms.Button();
            this.btnDisable = new System.Windows.Forms.Button();
            this.btnDHCP = new System.Windows.Forms.Button();
            this.btnShowInterfaces2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstSystemMessage
            // 
            this.lstSystemMessage.FormattingEnabled = true;
            this.lstSystemMessage.Location = new System.Drawing.Point(39, 129);
            this.lstSystemMessage.Name = "lstSystemMessage";
            this.lstSystemMessage.Size = new System.Drawing.Size(375, 147);
            this.lstSystemMessage.TabIndex = 1;
            // 
            // btnShowNICS
            // 
            this.btnShowNICS.Location = new System.Drawing.Point(39, 57);
            this.btnShowNICS.Name = "btnShowNICS";
            this.btnShowNICS.Size = new System.Drawing.Size(110, 52);
            this.btnShowNICS.TabIndex = 2;
            this.btnShowNICS.Text = "Show Network Interfaces";
            this.btnShowNICS.UseVisualStyleBackColor = true;
            this.btnShowNICS.Click += new System.EventHandler(this.btnShowNICS_Click);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(462, 57);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(100, 20);
            this.txtIP.TabIndex = 3;
            // 
            // txtSubnet
            // 
            this.txtSubnet.Location = new System.Drawing.Point(462, 83);
            this.txtSubnet.Name = "txtSubnet";
            this.txtSubnet.Size = new System.Drawing.Size(100, 20);
            this.txtSubnet.TabIndex = 4;
            // 
            // txtGateway
            // 
            this.txtGateway.Location = new System.Drawing.Point(462, 109);
            this.txtGateway.Name = "txtGateway";
            this.txtGateway.Size = new System.Drawing.Size(100, 20);
            this.txtGateway.TabIndex = 5;
            // 
            // btnSetAdapter
            // 
            this.btnSetAdapter.Location = new System.Drawing.Point(477, 135);
            this.btnSetAdapter.Name = "btnSetAdapter";
            this.btnSetAdapter.Size = new System.Drawing.Size(75, 23);
            this.btnSetAdapter.TabIndex = 6;
            this.btnSetAdapter.Text = "Set Adapter";
            this.btnSetAdapter.UseVisualStyleBackColor = true;
            this.btnSetAdapter.Click += new System.EventHandler(this.btnSetAdapter_Click);
            // 
            // btnEnable
            // 
            this.btnEnable.Location = new System.Drawing.Point(462, 183);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(103, 23);
            this.btnEnable.TabIndex = 7;
            this.btnEnable.Text = "Enable Interface";
            this.btnEnable.UseVisualStyleBackColor = true;
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // btnDisable
            // 
            this.btnDisable.Location = new System.Drawing.Point(462, 213);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(103, 23);
            this.btnDisable.TabIndex = 8;
            this.btnDisable.Text = "Disable Interface";
            this.btnDisable.UseVisualStyleBackColor = true;
            this.btnDisable.Click += new System.EventHandler(this.btnDisable_Click);
            // 
            // btnDHCP
            // 
            this.btnDHCP.Location = new System.Drawing.Point(298, 57);
            this.btnDHCP.Name = "btnDHCP";
            this.btnDHCP.Size = new System.Drawing.Size(109, 51);
            this.btnDHCP.TabIndex = 9;
            this.btnDHCP.Text = "Enable DHCP";
            this.btnDHCP.UseVisualStyleBackColor = true;
            this.btnDHCP.Click += new System.EventHandler(this.btnDHCP_Click);
            // 
            // btnShowInterfaces2
            // 
            this.btnShowInterfaces2.Location = new System.Drawing.Point(174, 57);
            this.btnShowInterfaces2.Name = "btnShowInterfaces2";
            this.btnShowInterfaces2.Size = new System.Drawing.Size(103, 51);
            this.btnShowInterfaces2.TabIndex = 10;
            this.btnShowInterfaces2.Text = "Show Interfaces 2";
            this.btnShowInterfaces2.UseVisualStyleBackColor = true;
            this.btnShowInterfaces2.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 288);
            this.Controls.Add(this.btnShowInterfaces2);
            this.Controls.Add(this.btnDHCP);
            this.Controls.Add(this.btnDisable);
            this.Controls.Add(this.btnEnable);
            this.Controls.Add(this.btnSetAdapter);
            this.Controls.Add(this.txtGateway);
            this.Controls.Add(this.txtSubnet);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.btnShowNICS);
            this.Controls.Add(this.lstSystemMessage);
            this.Name = "Form1";
            this.Text = "GA Network Tools";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSystemMessage;
        private System.Windows.Forms.Button btnShowNICS;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtSubnet;
        private System.Windows.Forms.TextBox txtGateway;
        private System.Windows.Forms.Button btnSetAdapter;
        private System.Windows.Forms.Button btnEnable;
        private System.Windows.Forms.Button btnDisable;
        private System.Windows.Forms.Button btnDHCP;
        private System.Windows.Forms.Button btnShowInterfaces2;
    }
}

