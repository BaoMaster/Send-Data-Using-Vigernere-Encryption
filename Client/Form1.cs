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

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        public byte[] datasend = new byte[1024];
        public byte[] datarecv = new byte[1024];
        public static Socket client; 
        private void butConnect_Click(object sender, EventArgs e)
        {
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ip = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1999);
            client.BeginConnect(ip, new AsyncCallback(XuLyKetNoi), null);
            client.BeginReceive(datarecv, 0, datarecv.Length, SocketFlags.None, new AsyncCallback(XuLyDuLieu), null);
            butConnect.Enabled = false;
        }

        private void XuLyDuLieu(IAsyncResult ar)
        {
            try
            {
                int recv = client.EndReceive(ar);
                string s = Encoding.ASCII.GetString(datarecv, 0, recv);
                tbDecodeClient.Text = s;
                //tbMessClient.Text += s + "\r\n";
                client.BeginReceive(datarecv, 0, datarecv.Length, SocketFlags.None, new AsyncCallback(XuLyDuLieu), null);
            }
            catch { }
        }

        private void XuLyKetNoi(IAsyncResult ar)
        {
            client.EndConnect(ar);
            labelStatusClient.Text = "Connect";
            labelStatusClient.ForeColor = Color.Green;
        }

        private void butSendClient_Click(object sender, EventArgs e)
        {
            if (labelStatusClient.Text == "Connect")
            {
                if (tbSendClient.Text == "")
                {
                    MessageBox.Show("Messbox is empty", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbSendClient.Focus();
                }
                try
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(tbKeySendClient.Text, "[0-9]"))
                        MessageBox.Show("Key cannot be a number", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        string a = tbSendClient.Text;

                        string aa = Encode(tbKeySendClient.Text, a);
                        datasend = Encoding.ASCII.GetBytes(aa);
                        client.Send(datasend, datasend.Length, SocketFlags.None);
                        tbMessClient.Text += "Client: " + a + "\r\n";
                        tbSendClient.Text = "";
                    }
                }
                catch
                {                
                        MessageBox.Show("The encryption key is empty", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbKeySendClient.Focus();
                }
            }
            else { MessageBox.Show("Client is not connect to server", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            
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

        private void butDecodeClient_Click(object sender, EventArgs e)
        {
            if (labelStatusClient.Text == "Connect")
            {
                if (tbDecodeClient.Text == "")
                {
                    MessageBox.Show("Mess box is empty", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbDecodeClient.Focus();
                }
                try
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(tbKeyDecodeCLient.Text, "[0-9]"))
                        MessageBox.Show("Key cannot be a number", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        string s = decode(tbKeyDecodeCLient.Text, tbDecodeClient.Text);
                        tbMessClient.Text += "Server: " + s + "\r\n";
                        tbDecodeClient.Text = "";
                    }
                }
                catch
                {
                    
                        MessageBox.Show("The key to decode is empty", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbKeyDecodeCLient.Focus();
                    

                }

            }
            else
            {
                MessageBox.Show("Client is not connect to server", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
