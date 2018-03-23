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

namespace Client
{
    public partial class Form1 : Form
    {
        byte[] data = new byte[1024];
        string input, output;
        IPEndPoint ipep;
        IPEndPoint sender;
        Socket server;
        EndPoint Remote;
        int recv;
        public Form1()
        {
            InitializeComponent();
        }



        private void btnkeo_Click(object sender, EventArgs e)
        {
            textBoxyourselec.Text = "";
            textBoxyourselec.Text = "Kéo";
            input = btnkeo.Text;
            data = Encoding.UTF8.GetBytes(input);
            server.SendTo(data, data.Length, SocketFlags.None, ipep);
            data = new byte[1024];
            recv = server.ReceiveFrom(data, ref Remote);
            textBox1.Text = Encoding.UTF8.GetString(data, 0, recv);
        }

        private void btnbao_Click(object sender, EventArgs e)
        {
            textBoxyourselec.Text = "";
            textBoxyourselec.Text = "Bao";
            input = btnbao.Text;
            data = Encoding.UTF8.GetBytes(input);
            server.SendTo(data, data.Length, SocketFlags.None, ipep);
            data = new byte[1024];
            recv = server.ReceiveFrom(data, ref Remote);
            textBox1.Text = Encoding.UTF8.GetString(data, 0, recv);
        }

       
        private void btnbua_Click(object sender, EventArgs e)
        {
            textBoxyourselec.Text = "";
            textBoxyourselec.Text = "Búa";
            input = btnbua.Text;
            data = Encoding.UTF8.GetBytes(input);
            server.SendTo(data, data.Length, SocketFlags.None, ipep);
            data = new byte[1024];
            recv = server.ReceiveFrom(data, ref Remote);
            textBox1.Text = Encoding.UTF8.GetString(data, 0, recv);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ipep = new IPEndPoint(IPAddress.Parse("192.168.1.113"), 9090);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sender = new IPEndPoint(IPAddress.Any, 0);
            Remote = (EndPoint)sender;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            server.Close();
        }

    }
}
