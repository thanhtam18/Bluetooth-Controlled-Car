using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

using InTheHand.Net.Sockets;
using InTheHand.Net.Bluetooth;
using FrmConnectBluetooth.Lib;


namespace FrmConnectBluetooth
{
    public partial class FrmConnectBluetooth : Form
    {
        private BlueTooth myBlueTooth = new BlueTooth();
        private List<BluetoothDeviceInfo> devices = new List<BluetoothDeviceInfo>();
        bool _isSearchingForDevices;
        public bool IsSearchingForDevices
        {
            get => _isSearchingForDevices;
            set
            {
                _isSearchingForDevices = value;
                scanButton.Enabled = !_isSearchingForDevices;
            }
        }

        public FrmConnectBluetooth()
        {
            InitializeComponent();
            nameSelected.Text = null;
        }

        private void scanButton_Click(object sender, EventArgs e)
        {
            Thread blueToothScanThread = new Thread(new ThreadStart(threadScanning));
            blueToothScanThread.Start();
        }

        private void threadScanning()
        {
            this.Invoke((MethodInvoker)delegate
            {
                IsSearchingForDevices = true;
            });

            devices.Clear();
            devices = myBlueTooth.scan();
            if (devices.Count > 0)
            {
                DisplayFlpItems();
            }
            this.Invoke((MethodInvoker)delegate
            {
                IsSearchingForDevices = false;
            });

        }

        private void DisplayFlpItems()
        {
            foreach (var device in devices)
            {
                var bluetoothDeviceItem = new BluetoothDevicesItem(device);
                bluetoothDeviceItem.Click += BluetoothDeviceItem_Click;
                this.Invoke((MethodInvoker)delegate
                {
                    flowDevicesName.Controls.Add(bluetoothDeviceItem);
                });
            }
        }

        private void BluetoothDeviceItem_Click(object sender, EventArgs e)
        {
            var deviceItem = sender as BluetoothDevicesItem;
            if (deviceItem != null)
            {
                var device = deviceItem.Device;
                //MessageBox.Show($"You clicked on device: " + device.DeviceName);
                myBlueTooth.setAdressDeviceSelected(device.DeviceAddress);
                this.Invoke((MethodInvoker)delegate
                {
                    nameSelected.Text = device.DeviceName;
                });
            }
        }

        private void threadConnecting()
        {
            if(!myBlueTooth.isConnected())
            {
                myBlueTooth.connect();
                if (myBlueTooth.isConnected())
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        status.Text = "Connected";
                        status.ForeColor = Color.Green;
                        connectButton.Text = "Disconnect";
                        connectButton.ForeColor = Color.Red;
                    });
                }
            }
            else
            {
                myBlueTooth.disconnect();
                this.Invoke((MethodInvoker)delegate
                {
                    status.Text = "Disconnected";
                    status.ForeColor = Color.Red;
                    connectButton.Text = "Connect";
                    connectButton.ForeColor = Color.Green;
                });
            }

        }

        private void connectButton_Click(object sender, EventArgs e)
        {
                if (myBlueTooth.getAdressDeviceSelected() == null)
                {
                    MessageBox.Show("Vui lòng chọn thiết bị để kết nối.");
                    return;
                }
                Thread blueToothConnectThread = new Thread(new ThreadStart(threadConnecting));
                blueToothConnectThread.Start();
        }

        private void escButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
