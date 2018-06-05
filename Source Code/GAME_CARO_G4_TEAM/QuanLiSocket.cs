using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAME_CARO_G4_TEAM
{
    class QuanLiSocket
    {
        #region Client

        //TcpClient client;

        Socket Client;

        private bool isConnected = false;

        public bool IsConnected { get => isConnected; set => isConnected = value; }

        public bool ConnectServer()
        {
            
            try
            {

                IPEndPoint iep = new IPEndPoint(IP, PORT);
                Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                
                Client.Connect(iep);
                this.IsServer = false;
                this.isConnected = true;
                MessageBox.Show("Kết nối thành công !");
                return true;
            }
            catch
            {
               // MessageBox.Show("Kết nối đến server không thành công!\nVui lòng kiểm tra lại!");
                return false;
            }
        }

        #endregion

        #region Server

        Socket Server;

        public void CreateServer()
        {
            IP = IPAddress.Parse(GetLocalIPv4(NetworkInterfaceType.Wireless80211));
            IPEndPoint iep = new IPEndPoint(IP,PORT);
            Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            Server.Bind(iep);
            Server.Listen(10);

            // Tạo luồng xử lý riêng

            Thread listener = new Thread(() =>
            {
                Client = Server.Accept();
            });

            listener.IsBackground = true;
            listener.Start();
           
            // xét thuộc tính để khi chương trình tắt, Thread cũng sẽ ngừng hoạt động

            MessageBox.Show("Tạo server thành công");
            MessageBox.Show("Thông tin Server: \n\tIP: " + IP + "\n\tPORT: " + PORT);
        }
        #endregion

        #region Both
        public IPAddress IP = IPAddress.Parse("127.0.0.1");
        private const int PORT = 100;
        private bool isServer = true; // server sẽ mặc định là dấu o, client mặc định dấu x
        public bool IsServer { get => isServer; set => isServer = value; }
        private string _playerName = "Player";// tên người chơi
        public string PlayerName { get => _playerName; set => _playerName = value; }
        public Socket Server1 { get => Server; set => Server = value; }


        // đóng gói gửi và nhận
        public bool Send(object data)
        {
            byte[] sendData = SerializeData(data);

            return SendData(Client, sendData);
            
        }
        public object Receive()
        {
            byte[] receiveData = new byte[1024];
            bool isReceived = ReceiveData(Client, ref receiveData);
            DataTransfer temp = (DataTransfer)(DeserializeData(receiveData));
            return temp;
        }
        // gửi và nhận
        private bool SendData(Socket target, byte[] data)
        {
            return target.Send(data) == 1 ? true : false;

        }
        private bool ReceiveData(Socket target, ref byte[] data)
        {
            return target.Receive(data) == 1 ? true : false;
        }
        // Hàm nén đối tượng thành mảng byte
        public byte[] SerializeData(object data ) {
            // tạo luồng lưu trữ data để phân tích thành byte[]
            MemoryStream ms = new MemoryStream();
            // tạo bộ định dạng
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            // sử dụng bộ định dạng để chuyển đổi dữ liệu
            binaryFormatter.Serialize(ms, data);
            // trả về kiểu mảng byte từ stream đã lưu data của chúng ta
            return ms.ToArray();
        }
        // Hàm giải nén mảng byte[] thành đối tượng
        public object DeserializeData(byte[] byteArray)
        {
            // tạo luồng để lưu trữ mảng byte đưa vào
            MemoryStream ms = new MemoryStream(byteArray);
            // Tạo bộ định dạng
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            // đưa vị trí của stream về 0 ->> đếu hiểu :))) 
            ms.Position = 0;
            //trả về object đã giải nén
            return binaryFormatter.Deserialize(ms);
        }

        public string GetLocalIPv4(NetworkInterfaceType _type)
        {
            string output = "";
            foreach (NetworkInterface item in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (item.NetworkInterfaceType == _type && item.OperationalStatus == OperationalStatus.Up)
                {
                    foreach (UnicastIPAddressInformation ip in item.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            output = ip.Address.ToString();
                        }
                    }
                }
            }
            return output;
        }



        #endregion
    }
}
