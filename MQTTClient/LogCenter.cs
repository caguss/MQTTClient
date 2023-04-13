using MQTTnet.Client;
using MQTTnet;
using MQTTnet.Extensions.ManagedClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MQTTnet.Packets;
using MQTTnet.Protocol;
using System.Text.Json;
using MQTTnet.Server;

namespace MQTTClient
{
    public partial class LogCenter : Form
    {
        public static ListBox LOGLIST;
        IManagedMqttClient _mqttClient;
        bool isOpened;
        public LogCenter()
        {
            InitializeComponent();
            LOGLIST = lb_LOG;

        }

        private async void btn_Open_Click(object sender, EventArgs e)
        {
            try
            {
                isOpened = true;
                btn_Open.Enabled = false;
                btn_Close.Enabled= true;
                await OpenClient();

            }
            catch (Exception ex)
            {
                LOGLIST.Items.Insert(0, ex.Message);
                btn_Open.Enabled = true;
                btn_Close.Enabled = false;
            }

        }

        private async Task OpenClient()
        {
            _mqttClient = new MqttFactory().CreateManagedMqttClient();

            // Create client options object
            MqttClientOptionsBuilder builder = new MqttClientOptionsBuilder()
                                                    .WithClientId("behroozbc")
                                                    .WithTcpServer("192.168.10.130");
            ManagedMqttClientOptions options = new ManagedMqttClientOptionsBuilder()
                                    .WithAutoReconnectDelay(TimeSpan.FromSeconds(60))
                                    .WithClientOptions(builder.Build())
                                    .Build();



            // Set up handlers
            _mqttClient.ConnectedAsync += _mqttClient_ConnectedAsync;


            _mqttClient.DisconnectedAsync += _mqttClient_DisconnectedAsync;


            _mqttClient.ConnectingFailedAsync += _mqttClient_ConnectingFailedAsync;


            // Connect to the broker
            await _mqttClient.StartAsync(options);
            // Send a new message to the broker every second
            while (true)
            {
                string json = JsonSerializer.Serialize(new { message = "Hi Mqtt", sent = DateTime.UtcNow });
                await _mqttClient.EnqueueAsync("behroozbc.ir/topic/json", json);
                LOGLIST.Invoke(new MethodInvoker(delegate ()
                {
                    LOGLIST.Items.Insert(0, string.Format("TimeStamp: {0} -- {1}", DateTime.Now, json));
                }));


                await Task.Delay(TimeSpan.FromMilliseconds(10));
                if (!isOpened)
                {
                    break;
                }
            }
            Task _mqttClient_ConnectedAsync(MqttClientConnectedEventArgs arg)
            {

                LOGLIST.Invoke(new MethodInvoker(delegate ()
                {
                    LOGLIST.Items.Insert(0, "Connected");
                }));


                return Task.CompletedTask;
            };
            Task _mqttClient_DisconnectedAsync(MqttClientDisconnectedEventArgs arg)
            {
                LOGLIST.Invoke(new MethodInvoker(delegate ()
                {
                    LOGLIST.Items.Insert(0, "Disconnected");
                }));
                return Task.CompletedTask;
            };
            Task _mqttClient_ConnectingFailedAsync(ConnectingFailedEventArgs arg)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    LOGLIST.Items.Insert(0, "Connection failed check network or broker!");
                    btn_Open.Enabled = true;
                    btn_Close.Enabled = false;
                }));
                return Task.CompletedTask;
            }
        }

        private async void btn_Close_Click(object sender, EventArgs e)
        {
            try
            {
                isOpened = false;
                btn_Open.Enabled = true;
                btn_Close.Enabled = false;

                 await _mqttClient.StopAsync();

            }
            catch (Exception ex)
            {
                LOGLIST.Items.Insert(0, ex.Message);
                btn_Open.Enabled = false;
                btn_Close.Enabled = true;
            }
        }

        private void btn_LOGClear_Click(object sender, EventArgs e)
        {
            LOGLIST.Items.Clear();
        }
    }
}
