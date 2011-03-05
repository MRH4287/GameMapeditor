using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Game.Game;

namespace Mapeditor
{
    public partial class SystemInfo : Form
    {
        private Solarsystem system;
        private GameData data;
        private bool saved = false;

        public SystemInfo(Solarsystem system, GameData data)
        {
            if (data == null)
            {
                MessageBox.Show("Nur möglich, wenn eine GameData Datei eigelesen wurde!");
                Close();
            }
            this.system = system;
            this.data = data;
            InitializeComponent();
        }

        private void SystemInfo_Load(object sender, EventArgs e)
        {
            foreach (Node node in system.nodes)
            {
                nodelist.AppendText(node.pointa.name + " -> " + node.pointb.name + " (" + Math.Round(node.distance) + ")" + Environment.NewLine);
            }


            planetList.Clear();
            foreach (Planet pl in system.planets)
            {
                planetList.AppendText(pl.type.Name + " - " + pl.Name + Environment.NewLine);

            }

            PlanetTypes.Items.Clear();

            foreach (PlanetClass planetClass in data.getPlanetTypes())
            {
                PlanetTypes.Items.Add(planetClass);
            }



            name.Text = system.name;
            checkBox1.Checked = system.userstart;

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            save();
            saved = true;
            Close();
        }

        private void save()
        {
            system.name = name.Text;
            system.userstart = checkBox1.Checked;
        }

        private void SystemInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!saved)
            {
                if (MessageBox.Show("Möchten Sie speichern?", "Speichern?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    save();
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            List<PlanetClass> planetTypes = data.getPlanetTypes();

            try
            {
                int count = int.Parse(textBox1.Text);


                for (int i = 0; i < count; i++)
                {

                    Planet planet = new Planet(Game.Game.Data.Names.PlanetNames[random.Next(Game.Game.Data.Names.PlanetNames.Length - 1)]);
                    planet.type = planetTypes[random.Next(planetTypes.Count - 1)];

                    if (system.planets == null)
                    {
                        system.planets = new List<Planet>();
                    }
                    system.planets.Add(planet);
                    planet.Solarsystem = system;
                }


                planetList.Clear();
                foreach (Planet pl in system.planets)
                {
                    planetList.AppendText(pl.type.Name + " - " + pl.Name + Environment.NewLine);

                }

            }
            catch
            {
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (PlanetTypes.SelectedItem != null)
            {
                Random random = new Random();


                Planet planet = new Planet(Game.Game.Data.Names.PlanetNames[random.Next(Game.Game.Data.Names.PlanetNames.Length - 1)]);
                planet.type = (PlanetClass)PlanetTypes.SelectedItem; 

                if (system.planets == null)
                {
                    system.planets = new List<Planet>();
                }
                system.planets.Add(planet);
                planet.Solarsystem = system;
         
            }


            planetList.Clear();
            foreach (Planet pl in system.planets)
            {
                planetList.AppendText(pl.type.Name + " - " + pl.Name + Environment.NewLine);

            }

        }
    }
}
