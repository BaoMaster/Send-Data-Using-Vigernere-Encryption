using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text.RegularExpressions;

namespace Server
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        public static Socket server;
        public static Socket client;
        public byte[] datasend = new byte[1024];
        public byte[] datarecv = new byte[1024];
        private void butStart_Click(object sender, EventArgs e)
        {
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ip = new IPEndPoint(IPAddress.Any, 1999);
            server.Bind(ip);
            server.Listen(5);
            labelStatus.Text = "Waiting for connect. . .";
            labelStatus.ForeColor = Color.YellowGreen;
            server.BeginAccept(new AsyncCallback(xuLyKetNoi), null);
            butStart.Enabled = false;
        }

        private void xuLyKetNoi(IAsyncResult ar)
        {
            client = server.EndAccept(ar);
            labelStatus.Text = "Connect";
            labelStatus.ForeColor = Color.Green;
            client.BeginReceive(datarecv, 0, datarecv.Length, SocketFlags.None, new AsyncCallback(XuLyDuLieu), null);
        }
        private void XuLyDuLieu(IAsyncResult ar)
        {
            try
            {
                int recv = client.EndReceive(ar);
                string s = Encoding.ASCII.GetString(datarecv, 0, recv);
                tbDecode.Text = s;
                client.BeginReceive(datarecv, 0, datarecv.Length, SocketFlags.None, new AsyncCallback(XuLyDuLieu), null);
            }
            catch { }
        }
        private void butSend_Click(object sender, EventArgs e)
        {

            if (labelStatus.Text == "Connect")
            {
                if (tbSend.Text == "")
                {
                    MessageBox.Show("Messbox is empty", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbSend.Focus();
                }
                else
                {
                    try
                    {
                        string a = tbSend.Text;
                        if (System.Text.RegularExpressions.Regex.IsMatch(tbKeySend.Text, "[0-9]"))
                            MessageBox.Show("Key cannot be a number","ERRO",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        else
                        {
                            string aa = Encode(tbKeySend.Text, a);

                            datasend = Encoding.ASCII.GetBytes(aa);
                            client.Send(datasend, datasend.Length, SocketFlags.None);
                            tbMess.Text += "Server: " + a + "\r\n";
                            tbSend.Text = "";
                        }
                    }
                    catch
                    {     
                            MessageBox.Show("The encryption key is empty", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tbKeySend.Focus();
                    }
                }
            }
            else { MessageBox.Show("Server not connect", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public static string decode(string key, string str)
        {
            key = key.ToUpper();
            str = str.ToUpper();
            string r = "";
            int c = 0;
            foreach (var s in str)
            {
                if ((int)s < (int)'A' || (int)s > (int)'Z')
                {
                    r += s;
                    continue;
                }
                r += (char)(((int)s - (int)key[c] + (2 * (int)'A')) % 26 + (int)'A');
                c = (c + 1) % key.Length;
            }
            return r;
        }
        public static string Encode(string key, string str)
        {
            key = key.ToUpper();
            str = str.ToUpper();
            string r = "";
            int c = 0;
            foreach (var s in str)
            {
                if ((int)s < (int)'A' || (int)s > (int)'Z')
                {
                    r += s;
                    continue;
                }
                r += (char)(((int)s + (int)key[c] - (2 * (int)'A')) % 26 + (int)'A');
                c = (c + 1) % key.Length;
            }
            return r;
        }

        private void butDecode_Click(object sender, EventArgs e)
        {
            if (labelStatus.Text == "Connect")
            {
                if (tbDecode.Text == "")
                {
                    MessageBox.Show("Messbox is empty", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbDecode.Focus();
                }
                try
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(tbKeyDecode.Text, "[0-9]"))
                        MessageBox.Show("Key cannot be a number", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        string a = decode(tbKeyDecode.Text, tbDecode.Text);
                        tbMess.Text += "Client: " + a + "\r\n";
                        tbDecode.Text = "";
                    }
                }
                catch
                {
                    
                        MessageBox.Show("The key to decode is empty", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbKeyDecode.Focus();
                    
                   
                }
            }
            else { MessageBox.Show("Server not connect", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
