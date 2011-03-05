using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Communication;
using Game.Game;

namespace Mapeditor
{
    public partial class Network : Form
    {
        Form1 main;

        bool load = true;

        public Network(Form1 main, bool load = true)
        {
            InitializeComponent();
            this.main = main;
            this.load = load;

            if (!load)
            {
                button1.Text = "Speichern";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NetworkRequest request = null;
          //  try
          //  {
                button1.Text = "Please Wait ... ";

                request = new NetworkRequest(main);

                int port = int.Parse(textBox2.Text);

                
                request.connect(textBox1.Text, port);

                System.Threading.Thread.Sleep(2500);

                if (request.Connected)
                {
                    if (load)
                    {
                        Command com = new Command();
                        com.command = "SELECT map";

                        Command response = request.request(com);

                        request.Disconnect();

                        Map map = (Map)response.Arguments[1];

                        main.loadMap(map);
                    }
                    else
                    {
                        Command com = new Command();
                        com.command = "UPDATE map";
                        com.Arguments.Add(main.getMap());

                        request.request(com);

                        request.Disconnect();

                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Verbindung wurde nicht in der erwarteten Zeit hergestellt");
                }



           // }
          //  catch (Exception ex)
          //  {
          //      MessageBox.Show("Fehler: " + ex.Message);

         //   }
          //  finally
         //   {
                if (request != null)
                {
                   // request.Disconnect();
                }

                button1.Text = "Laden";
          //  }
        }
    }
}
