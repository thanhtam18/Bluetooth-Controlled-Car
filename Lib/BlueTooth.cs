using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Threading;

using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using InTheHand.Net;


namespace FrmConnectBluetooth.Lib
{
    public class BlueTooth
    {
        private List<BluetoothDeviceInfo> devices = new List<BluetoothDeviceInfo>();
        private BluetoothClient bluetoothClient = new BluetoothClient();

        private BluetoothAddress adressDeviceSelected = null;

        public List<BluetoothDeviceInfo> scan()
        {
            this.devices.Clear();
            using (BluetoothClient bluetoothConnectClient = new BluetoothClient())
            {
                this.devices.AddRange(bluetoothConnectClient.DiscoverDevices());
                bluetoothConnectClient.Close();
                return this.devices;
            }
        }

        public bool isConnected()
        {
            if (this.bluetoothClient != null && this.bluetoothClient.Connected)
                return true;
            return false;
        }

        public void connect()
        {
            try
            {
                if (this.bluetoothClient == null || !this.bluetoothClient.Connected)
                {
                    this.bluetoothClient = new BluetoothClient();
                    this.bluetoothClient.Connect(adressDeviceSelected, BluetoothService.SerialPort);
                    //MessageBox.Show("Kết nối thành công!");
                }
                else
                {
                    //MessageBox.Show("Thiết bị đã được kết nối.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối thất bại");
            }
        }

        public void disconnect()
        {
            if (this.bluetoothClient != null && this.bluetoothClient.Connected)
            {
                this.bluetoothClient.Close();
                //MessageBox.Show("Đã ngắt kết nối.");
            }
            else
            {
                //MessageBox.Show("Chưa có thiết bị nào được kết nối.");
            }
        }

        public string getData()
        {
            string receivedData = null;
            if (bluetoothClient != null && bluetoothClient.Connected)
            {
                try
                {
                    NetworkStream stream = bluetoothClient.GetStream();
                    if (stream != null && stream.DataAvailable)
                    {
                        byte[] buffer = new byte[100];
                        int bytesRead = stream.Read(buffer, 0, buffer.Length);
                        receivedData = System.Text.Encoding.ASCII.GetString(buffer, 0, bytesRead);
                    }
                }
                catch (Exception ex)
                {
                    return null;
                
                }
            }
            return receivedData;
        }

        public void sendData(string str)
        {
            if (bluetoothClient != null && bluetoothClient.Connected)
            {
                try
                {
                    string dataToSend = str;
                    NetworkStream stream = bluetoothClient.GetStream();
                    if (stream != null)
                    {
                        byte[] data = System.Text.Encoding.ASCII.GetBytes(dataToSend);
                        stream.Write(data, 0, data.Length);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gửi dữ liệu thất bại: " + ex.Message);
                }
            }
            else
            {
                //MessageBox.Show("Chưa kết nối với thiết bị Bluetooth.");
            }
        }

        public void setAdressDeviceSelected(BluetoothAddress address)
        {
            this.adressDeviceSelected = address;
        }

        public BluetoothAddress getAdressDeviceSelected()
        {
            return this.adressDeviceSelected;
        }
    }
}
