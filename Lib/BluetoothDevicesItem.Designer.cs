namespace FrmConnectBluetooth.Lib
{
    partial class BluetoothDevicesItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNameDevice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNameDevice
            // 
            this.labelNameDevice.AutoSize = true;
            this.labelNameDevice.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 12F, System.Drawing.FontStyle.Bold);
            this.labelNameDevice.ForeColor = System.Drawing.Color.White;
            this.labelNameDevice.Location = new System.Drawing.Point(3, 12);
            this.labelNameDevice.Name = "labelNameDevice";
            this.labelNameDevice.Size = new System.Drawing.Size(113, 18);
            this.labelNameDevice.TabIndex = 0;
            this.labelNameDevice.Text = "Device Name";
            // 
            // BluetoothDevicesItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.labelNameDevice);
            this.Name = "BluetoothDevicesItem";
            this.Size = new System.Drawing.Size(185, 42);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNameDevice;
    }
}
