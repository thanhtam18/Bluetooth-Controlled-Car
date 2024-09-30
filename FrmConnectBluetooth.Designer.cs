namespace FrmConnectBluetooth
{
    partial class FrmConnectBluetooth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConnectBluetooth));
            this.label1 = new System.Windows.Forms.Label();
            this.flowDevicesName = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.scanButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.nameSelected = new System.Windows.Forms.Label();
            this.escButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(105, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "BLUETOOTH SETTING";
            // 
            // flowDevicesName
            // 
            this.flowDevicesName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowDevicesName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.flowDevicesName.Location = new System.Drawing.Point(220, 66);
            this.flowDevicesName.Name = "flowDevicesName";
            this.flowDevicesName.Size = new System.Drawing.Size(164, 266);
            this.flowDevicesName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(217, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Devices";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Selection:";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.BackColor = System.Drawing.Color.Transparent;
            this.status.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.Color.Red;
            this.status.Location = new System.Drawing.Point(82, 80);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(96, 19);
            this.status.TabIndex = 8;
            this.status.Text = "Disconnect";
            // 
            // scanButton
            // 
            this.scanButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("scanButton.BackgroundImage")));
            this.scanButton.FlatAppearance.BorderSize = 0;
            this.scanButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scanButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.scanButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.scanButton.Location = new System.Drawing.Point(26, 182);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(164, 65);
            this.scanButton.TabIndex = 9;
            this.scanButton.Text = "Scan Bluetooth";
            this.scanButton.UseVisualStyleBackColor = true;
            this.scanButton.Click += new System.EventHandler(this.scanButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("connectButton.BackgroundImage")));
            this.connectButton.FlatAppearance.BorderSize = 0;
            this.connectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.connectButton.ForeColor = System.Drawing.Color.Lime;
            this.connectButton.Location = new System.Drawing.Point(26, 268);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(164, 64);
            this.connectButton.TabIndex = 10;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // nameSelected
            // 
            this.nameSelected.AutoSize = true;
            this.nameSelected.BackColor = System.Drawing.Color.Transparent;
            this.nameSelected.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameSelected.ForeColor = System.Drawing.Color.Cyan;
            this.nameSelected.Location = new System.Drawing.Point(12, 146);
            this.nameSelected.Name = "nameSelected";
            this.nameSelected.Size = new System.Drawing.Size(109, 19);
            this.nameSelected.TabIndex = 11;
            this.nameSelected.Text = "Name Device";
            // 
            // escButton
            // 
            this.escButton.BackColor = System.Drawing.Color.Red;
            this.escButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.escButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.escButton.Location = new System.Drawing.Point(364, 8);
            this.escButton.Name = "escButton";
            this.escButton.Size = new System.Drawing.Size(25, 25);
            this.escButton.TabIndex = 12;
            this.escButton.Text = "X";
            this.escButton.UseVisualStyleBackColor = false;
            this.escButton.Click += new System.EventHandler(this.escButton_Click);
            // 
            // FrmConnectBluetooth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(43)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(399, 363);
            this.ControlBox = false;
            this.Controls.Add(this.escButton);
            this.Controls.Add(this.nameSelected);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.scanButton);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowDevicesName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConnectBluetooth";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowDevicesName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Button scanButton;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label nameSelected;
        private System.Windows.Forms.Button escButton;
    }
}

