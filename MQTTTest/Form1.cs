using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace Test
{
    public partial class Form1 : Form
    {
        //string MQTT_BROKER_ADDRESS = "127.0.0.1";
        MqttClient client;
        private string minhaMensagem = "";

        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                client = new MqttClient(IPAddress.Parse(txtEnderecoConexao.Text));
                // register to message received 
                client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;

                string clientId = Guid.NewGuid().ToString();
                client.Connect(clientId);

                lblStatus.Text = "Conectado";
                lblStatus.BackColor = Color.Green;

                btnConectar.Enabled = false;
                btnDesconectar.Enabled = true;
                gp1.Enabled = true;
                gp2.Enabled = true;
                gp3.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Houve um erro: " + ex.Message);
                return;
            }

            

        }
 
         void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            minhaMensagem = "";
            foreach (var item in e.Message)
            {
                minhaMensagem += Convert.ToChar(item).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // create client instance 
            string strValue = Convert.ToString(12);

            // publish a message on "/home/temperature" topic with QoS 2 
            client.Publish("/home/temperature", Encoding.UTF8.GetBytes(strValue), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, false);

        }

        private void btnLimparRecebido_Click(object sender, EventArgs e)
        {
            rtbRecebimento.Clear();
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            if (client == null)
                return;

            if (client.IsConnected)
            {
                try
                {
                    client.Disconnect();

                    btnConectar.Enabled = true;
                    btnDesconectar.Enabled = false;
                    lblStatus.Text = "Desconectado";
                    lblStatus.BackColor = Color.Red;
                    gp1.Enabled = false;
                    gp2.Enabled = false;
                    gp3.Enabled = false;

                    client.MqttMsgPublishReceived -= client_MqttMsgPublishReceived;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        private void btnIncrever_Click(object sender, EventArgs e)
        {
            if (txtEnderecoSubscribe.TextLength <= 0)
            {
                MessageBox.Show("Falta o endereco");
                return;
            }


            try
            {
                // subscribe to the topic "/home/temperature" with QoS 2 
                client.Subscribe(new string[] { txtEnderecoSubscribe.Text }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
                cbEnderecoEnvio.Items.Add(txtEnderecoSubscribe.Text);
                cbEnderecosDesinscrever.Items.Add(txtEnderecoSubscribe.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Houve um erro: " + ex.Message);
                return;
            }
        }

        private void btnDesinscrever_Click(object sender, EventArgs e)
        {
            if (cbEnderecosDesinscrever.SelectedIndex < 0)
                return;

            try
            {
                // subscribe to the topic "/home/temperature" with QoS 2 
                client.Unsubscribe(new string[] { txtEnderecoSubscribe.Text });
                cbEnderecoEnvio.Items.Remove(txtEnderecoSubscribe.Text);
                cbEnderecosDesinscrever.Items.Remove(txtEnderecoSubscribe.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um erro: " + ex.Message);
                return;
            }

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (cbEnderecoEnvio.SelectedIndex < 0)
                return;

            if (txtMensagemEnvio.TextLength <= 0)
            {
                MessageBox.Show("Falta a mensagem");
                return;
            }

            try
            {
                // create client instance 
                string strValue = Convert.ToString(12);

                // publish a message on "/home/temperature" topic with QoS 2 
                client.Publish(cbEnderecoEnvio.SelectedItem.ToString(), Encoding.UTF8.GetBytes(txtMensagemEnvio.Text), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um erro: " + ex.Message);
                return;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (minhaMensagem.Length > 0)
            {
                rtbRecebimento.AppendText(minhaMensagem + Environment.NewLine);
                minhaMensagem = "";
            }
        }

        private void txtEnderecoConexao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnConectar_Click(btnConectar, null);
            }
        }

        private void txtMensagemEnvio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnEnviar_Click(btnEnviar, null);
            }
        }
    }
}
