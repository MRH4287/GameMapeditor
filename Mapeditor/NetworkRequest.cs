using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Network;
using Communication;
using System.Windows.Forms;

namespace Mapeditor
{
    class NetworkRequest
    {

        private bool connected = false;
        public bool Connected
        {
            get
            {
                return connected;
            }
        }

        // private Game.Config config = new Game.Config();

        private volatile System.Collections.Generic.Dictionary<int, Command> response = new Dictionary<int, Command>();

        public TCPClient network;

        private Translator tr = new Translator();

        private Form1 main;

        public NetworkRequest(Form1 main)
        {
            // checkConfig();

            //  network = new TCPClient(this, config["Server/ip"], int.Parse(config["Server/port"]));
            //  network.TCP_Connect();

            this.main = main;

        }

        public void connect(string ip, int port)
        {
            network = new TCPClient(ip, port, "GamePW");
            network.OnTextRecieved += new TCPClient.TextRecievedEvent(network_OnTextRecieved);
            network.OnError += new TCPClient.TCPErrorEvent(network_OnError);
            network.OnConnect += new TCPClient.ConnectedEvent(network_OnConnect);
            network.TCP_Connect();
        }



        public Command request(Command request)
        {
            if (connected)
            {

                int UID = (new Random()).Next(int.MaxValue);

                Command send = new Command();
                send.command = request.command;
                send.Arguments.Add(UID);

                foreach (Object ob in request.Arguments)
                {
                    send.Arguments.Add(ob);
                }

                byte[] tmp = tr.writeCommand(send);

                network.TCP_SendByteStream(tmp);

                Command result = null;


                int count = 0;
                int count2 = 0;



                while (!response.ContainsKey(UID))
                {
                    count++;
                    System.Threading.Thread.Sleep(100);

                    if (count >= 5)
                    {
                        count2++;
                        network.TCP_SendByteStream(tr.writeCommand(send));
                        count = 0;
                    }
                    if (count2 >= 3)
                    {
                        break;
                    }

                }
                if (response.ContainsKey(UID))
                {
                    result = response[UID];
                    response.Remove(UID);
                }



                return result;
            }
            else
            {
                MessageBox.Show("Fehler: Keine Verbindung!");
                return new Command();
            }
        }


        #region TCP_Client Member

        void network_OnConnect(string server)
        {
            this.connected = true;
        }

        void network_OnError(NetworkException exception)
        {
               main.status.Text = "Fehler: " + exception.Message;
    
        }

        void network_OnTextRecieved(string input, byte[] byteInput, System.Net.Sockets.Socket client)
        {
            Translator tr = new Translator();
            Command com = tr.getCommand(byteInput);

            if (com.command == "response")
            {
                int UID = (int)com.Arguments[0];
                response.Add(UID, com);
            }
        }



        #endregion

        public void Disconnect()
        {
            if ((network != null) && (connected))
            {
                network.TCP_Disconnect();
            }
        }

    }
}
