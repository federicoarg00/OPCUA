using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hylasoft.Opc.Ua;
using System.Net.NetworkInformation;

namespace opc_ua
{
    public partial class Form1 : Form
    {
        private UaClient clientTCP;
        public static string localIP = "";

        public Form1()
        {
            InitializeComponent();

            connectStatus.Text = "Not connected";
            string localIP = "";
            nodeToRead.Text = "Simulation.Random1";
            nodeToWrite.Text = "Simulation.Random1";

            // GET IP Address
            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 || ni.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {

                    if (ni.Name == "Wi-Fi")
                    {
                        foreach (UnicastIPAddressInformation ip in ni.GetIPProperties().UnicastAddresses)
                        {
                            if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                            {
                                localIP = ip.Address.ToString();
                                serverAddress.Text = "opc.tcp://" + ip.Address.ToString() + ":53530/OPCUA/SimulationServer";
                            }
                        }
                    }
                }
            }
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            clientTCP = new UaClient(new Uri(serverAddress.Text));
            clientTCP.Connect();
            connectStatus.Text = "Connected";
        }


        private void readButton_Click(object sender, EventArgs e)
        {
            string node = nodeToRead.Text;
            string nodeType = clientTCP.GetDataType(node).ToString();
            string myValue = "";
            switch (nodeType)
            {
                case "System.Double":
                    myValue = clientTCP.Read<double>(node).Value.ToString();
                    break;
                case "System.Float":
                    myValue = clientTCP.Read<float>(node).Value.ToString();
                    break;
                case "System.Int32":
                    myValue = clientTCP.Read<Int32>(node).Value.ToString();
                    break;
            }

            valueOfRead.Text = myValue.ToString();
        }



        private void writeButton_Click(object sender, EventArgs e)
        {
            int flag=0;
            var node = nodeToWrite.Text;
            string nodeType = clientTCP.GetDataType(node).ToString();
            float floatMyValue=0;double doubleMyValue=0;Int32 int32MyValue=0;
            switch (nodeType)
            {
                case "System.Double":
                    doubleMyValue = Convert.ToDouble(valueToWrite.Text);
                    flag = 1;
                    break;
                case "System.Float":
                    floatMyValue = (float)Convert.ToDouble(valueToWrite.Text);
                    flag = 2;
                    break;
                case "System.Int32":
                    int32MyValue = Convert.ToInt32(valueToWrite.Text);
                    flag = 3;
                    break;
            }
            if (flag == 1) { clientTCP.Write(node.ToString(), doubleMyValue); valueAfterWrite.Text = doubleMyValue.ToString(); }
            else if (flag == 2) { clientTCP.Write(node.ToString(), floatMyValue); valueAfterWrite.Text = floatMyValue.ToString(); }
            else if (flag == 3) { clientTCP.Write(node.ToString(), int32MyValue); valueAfterWrite.Text = int32MyValue.ToString(); }
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nodeToRead_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
