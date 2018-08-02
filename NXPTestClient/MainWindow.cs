using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NXPTestClient
{
    public partial class MainWindow : Form
    {
        private delegate void WriteTestLogDelegate(string msg, Color col);
        AsynchronousClient TestClient = null;
        bool bConnect = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Send_Click(object sender, EventArgs e)
        {
            if (bConnect)
            {
                string cmd = this.textBox_Cmd.Text;
                int hValue = (cmd.Length + 1) >> 8;
                int lValue = (cmd.Length + 1) & 0xFF;
                Byte[] arr = new Byte[] { (Byte)'\n', (Byte)hValue, (Byte)lValue };
                Byte[] SendBytes = Encoding.UTF8.GetBytes(cmd);
                Byte[] end = new byte[] { (Byte)'\0' };
                List<Byte> lTemp = new List<Byte>();
                lTemp.AddRange(arr);
                lTemp.AddRange(SendBytes);
                lTemp.AddRange(end);
                Byte[] sendBytes = new Byte[lTemp.Count];
                lTemp.CopyTo(sendBytes);

                TestClient.Send(sendBytes);
            }
        }

        void CreateClient()
        {
            TestClient = new AsynchronousClient();
            TestClient.ConnectEvent += new AsynchronousClient.SocketConnectResultEventHandler(ConnectResult);
            TestClient.DisconnectEvent += new AsynchronousClient.SocketDisconnectResultEventHandler(DisconnectResult);

            TestClient.SendDataEvent += new AsynchronousClient.SocketSendEventHandler(SendResult);
            TestClient.RecvDataEvent += new AsynchronousClient.SocketRecvEventHandler(RecvData);
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {
            CreateClient();
        }

        void ConnectResult(bool bConnectResult)
        {
            bConnect = bConnectResult;
            if(bConnect)
            {
                this.button_Connect.Text = "断开";
                WriteLog("连接成功", Color.Green);
            }
            else
            {
                this.button_Connect.Text = "连接";
                WriteLog("连接失败", Color.Red);
            }
        }

        void DisconnectResult(bool bDisConnect)
        {
            bConnect = false;
            CreateClient();
        }

        void SendResult(bool bSendResult)
        {
            if(bSendResult)
            {
                WriteLog("发送成功，开始接收", Color.Green);
                TestClient.Receive();
            }
            else
            {
                WriteLog("发送失败", Color.Green);
            }
        }

        void  RecvData(string strData)
        {
            WriteLog(strData, Color.Green);
        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(this.textBox_IP.Text) || string.IsNullOrEmpty(this.textBox_Port.Text))
            {
                MessageBox.Show("请输入正确的IP或端口");
                return;
            }
            if(this.button_Connect.Text == "断开")
            {
                TestClient.StartDisConnectClient();
            }
            else if (this.button_Connect.Text == "连接")
            {
                TestClient.StartConnectClient(this.textBox_IP.Text, this.textBox_Port.Text);
            }
                
        }

        private void WriteLog(string msg, Color col)
        {
            if (this.richTextBox_Resulst.InvokeRequired)
            {
                WriteTestLogDelegate d = new WriteTestLogDelegate(WriteLog);
                this.richTextBox_Resulst.Invoke(d, new object[] { msg, col });
            }
            else
            {
                this.richTextBox_Resulst.SelectionColor = col;

                this.richTextBox_Resulst.AppendText(string.Format("{0}\r\n", System.DateTime.Now));
                this.richTextBox_Resulst.AppendText(msg);
                this.richTextBox_Resulst.AppendText("\r\n");
                this.richTextBox_Resulst.ScrollToCaret();
            }
        }
    }
}
