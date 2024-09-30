using InTheHand.Net.Sockets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmConnectBluetooth.Lib
{
    public partial class BluetoothDevicesItem : UserControl
    {
        public BluetoothDeviceInfo Device { get; set; }
        public BluetoothDevicesItem(BluetoothDeviceInfo bluetoothDeviceInfo)
        {
            Device = bluetoothDeviceInfo;
            InitializeComponent();
            labelNameDevice.Text = Device.DeviceName;
        }
    }
}
