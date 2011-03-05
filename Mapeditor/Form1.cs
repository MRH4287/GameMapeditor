using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using GraphicLibary;
using Game.Game;
using Communication;

namespace Mapeditor
{


    public partial class Form1 : Form
    {

        bool move = false;
        Control toMove = null;

        List<Solarsystem> solarsystemMap = new List<Solarsystem>();
        Dictionary<PictureBox, Solarsystem> refferenzTable = new Dictionary<PictureBox, Solarsystem>();
        Dictionary<Solarsystem, PictureBox> refferenzTable2 = new Dictionary<Solarsystem, PictureBox>();

        PictureBox selected = null;

        Area randomArea = null;
        bool randomAreaReady = false;

        GameData data = null;


        public Form1()
        {
            InitializeComponent();
            ImageSetup();
        }


        private void printConnections(MouseEventArgs e = null)
        {
            GraphicHelper graphic = new GraphicHelper(panel1.Width, panel1.Height);
            List<Node> allreadydrawn = new List<Node>();


            foreach (Solarsystem system in solarsystemMap)
            {
                foreach (Node node in system.nodes)
                {
                    if (!allreadydrawn.Contains(node))
                    {
                        allreadydrawn.Add(node);

                        graphic.drawLine(Color.Black, node.pointa.x, node.pointa.y, node.pointb.x, node.pointb.y);

                    }
                }

            }


            if ((randomAreaReady) && (randomArea != null))
            {
                graphic.drawLine(Color.Orange, randomArea.x1, randomArea.y1, randomArea.x1, randomArea.y2);
                graphic.drawLine(Color.Orange, randomArea.x1, randomArea.y1, randomArea.x2, randomArea.y1);

                graphic.drawLine(Color.Orange, randomArea.x2, randomArea.y2, randomArea.x1, randomArea.y2);
                graphic.drawLine(Color.Orange, randomArea.x2, randomArea.y2, randomArea.x2, randomArea.y1);

            }

            if ((randomArea != null) && (e != null) && !randomAreaReady)
            {
                graphic.drawLine(Color.Orange, randomArea.x1, randomArea.y1, randomArea.x1, e.Y);
                graphic.drawLine(Color.Orange, randomArea.x1, randomArea.y1, e.X, randomArea.y1);

                graphic.drawLine(Color.Orange, e.X, e.Y, randomArea.x1, e.Y);
                graphic.drawLine(Color.Orange, e.X, e.Y, e.X, randomArea.y1);
            }

            panel1.BackgroundImage = graphic.flush();

        }


        private void panel1_MouseCaptureChanged(object sender, EventArgs e)
        {

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {

            if (tool_systemAdd.Checked)
            {
                PictureBox picture = new PictureBox();
                panel1.Controls.Add(picture);
                picture.Image = getImage("sun");
                picture.Left = e.X;
                picture.Top = e.Y;
                picture.Width = picture.Image.Width;
                picture.Height = picture.Image.Height;
                picture.Visible = true;

                picture.MouseClick += new MouseEventHandler(picture_Click);


                Solarsystem system = new Solarsystem();
                system.x = e.X;
                system.y = e.Y;

                solarsystemMap.Add(system);

                refferenzTable.Add(picture, system);
                refferenzTable2.Add(system, picture);
            }
            else if (tool_randomArea.Checked)
            {
                if (!randomAreaReady)
                {
                    if (randomArea == null)
                    {
                        randomArea = new Area();
                        randomArea.x1 = e.X;
                        randomArea.y1 = e.Y;

                    }
                    else
                    {
                        randomArea.x2 = e.X;
                        randomArea.y2 = e.Y;
                        randomAreaReady = true;
                    }

                }
                else
                {
                    randomArea = null;
                    randomAreaReady = false;
                }


            }
            else if (tool_delRandomArea.Checked)
            {
                randomArea = null;
                randomAreaReady = false;
            }

            printConnections();
        }


        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            int offsetX = 0;
            int offsetY = 0;

            //   PictureBox me = (PictureBox)sender;

            Position.Text = (e.X - offsetX) + ":" + (e.Y - offsetY);
            if (tool_move.Checked)
            {

                if ((move) && (toMove != null))
                {
                    toMove.Left = e.X - offsetX;
                    toMove.Top = e.Y - offsetY;

                    try
                    {
                        Solarsystem system = refferenzTable[(PictureBox)toMove];
                        system.x = e.X;
                        system.y = e.Y;


                    }
                    catch { }

                }

            }
            printConnections(e);
        }

        private void picture_Click(object sender, EventArgs e)
        {
            MouseEventArgs ev = (MouseEventArgs)e;

            PictureBox me = (PictureBox)sender;

            if (tool_move.Checked)
            {

                if (move)
                {
                    toMove = null;
                    move = false;
                }
                else
                {
                    toMove = (PictureBox)sender;
                    move = true;

                }
                checkNodes();
            }
            else if (tool_NodeAdd.Checked)
            {
                if (selected == null)
                {
                    selected = me;
                    selected.BorderStyle = BorderStyle.FixedSingle;
                }
                else
                {
                    Node node = new Node();
                    node.pointa = refferenzTable[selected];
                    node.pointb = refferenzTable[me];

                    int x1 = selected.Left;
                    int y1 = selected.Top;
                    int x2 = me.Left;
                    int y2 = me.Left;

                    int xtmp = x1 - x2;
                    int ytmp = y1 - y2;

                    double distance = Math.Sqrt(Math.Pow(xtmp, 2) + Math.Pow(ytmp, 2));

                    node.distance = distance;

                    node.pointa.nodes.Add(node);
                    node.pointb.nodes.Add(node);

                    selected.BorderStyle = BorderStyle.None;
                    selected = null;

                    printConnections();

                }
            }
            else if (tool_NodeDell.Checked)
            {
                if (selected == null)
                {
                    selected = me;
                    selected.BorderStyle = BorderStyle.FixedSingle;
                }
                else
                {
                    Solarsystem other = refferenzTable[selected];
                    Solarsystem system = refferenzTable[me];

                    Node node = null;

                    foreach (Node n in system.nodes)
                    {
                        if (((n.pointa == system) && (n.pointb == other)) || ((n.pointb == system) && (n.pointa == other)))
                        {
                            node = n;
                        }
                    }

                    if (node != null)
                    {
                        system.nodes.Remove(node);
                        other.nodes.Remove(node);


                    }


                    selected.BorderStyle = BorderStyle.None;
                    selected = null;

                    printConnections();

                }


            }
            else if (tool_systemDell.Checked)
            {
                // Lösche System
                Solarsystem system = refferenzTable[me];
                refferenzTable.Remove(me);
                refferenzTable2.Remove(system);

                Node[] array = new Node[system.nodes.Count];
                system.nodes.CopyTo(array);

                foreach (Node node in array)
                {
                    node.pointa.nodes.Remove(node);
                    node.pointb.nodes.Remove(node);
                }

                solarsystemMap.Remove(system);

                panel1.Controls.Remove(me);



            }
            else if (tool_Info.Checked)
            {
                try
                {
                    SystemInfo info = new SystemInfo(refferenzTable[me], data);
                    info.Show();
                }
                catch
                {
                }


            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }



        System.Collections.Hashtable tabl = new System.Collections.Hashtable();


        private void ImageSetup()
        {
            tabl.Add("sun", global::Mapeditor.Properties.Resources.Sun);
        }

        /// <summary>
        /// Liefert ein bestimmtes Bild zurück
        /// </summary>
        /// <param name="name">Dateiname</param>
        /// <returns>BildDatei</returns>
        public Image getImage(string name)
        {
            return (Image)(tabl[name]);


        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void checkNodes()
        {
            foreach (Solarsystem system in solarsystemMap)
            {
                foreach (Node node in system.nodes)
                {

                    int xtmp = node.pointa.x - node.pointb.x;
                    int ytmp = node.pointa.y - node.pointb.y;

                    double distance = Math.Sqrt(Math.Pow(xtmp, 2) + Math.Pow(ytmp, 2));

                    node.distance = distance;

                }
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void speichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Map-File | *.map";
                if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Translator tr = new Translator();
                    List<ClassContainer> list = new List<ClassContainer>();
                    Map map = new Map();
                    map.solarsystems = solarsystemMap;
                    map.randomArea = randomArea;

                    map.systemcount = int.Parse(Systemcount.Text);
                    map.min_distance = int.Parse(Min_distance.Text);

                    ClassContainer container = new ClassContainer();
                    container.objekt = map;
                    container.type = ClassType.Map;
                    list.Add(container);


                    tr.writeData(list, save.FileName);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler: " + ex.Message);
            }

        }

        private void ladenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Map-File | *.map";
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Translator tr = new Translator();
                List<ClassContainer> list = tr.readData(open.FileName);

                ClassContainer container = list[0];
                try
                {
                    Map map = (Map)container.objekt;

                    loadMap(map);

                }
                catch
                {
                    MessageBox.Show("Fehler beim Parsen der Map-Datei");
                }

            }

        }


        public void loadMap(Map map)
        {
            panel1.Controls.Clear();
            GraphicHelper gr = new GraphicHelper(panel1.Width, panel1.Height);
            panel1.BackgroundImage = gr.flush();

            solarsystemMap.Clear();
            refferenzTable.Clear();
            refferenzTable2.Clear();
            randomArea = null;
            randomArea = map.randomArea;
            randomAreaReady = true;


            Systemcount.Text = map.systemcount.ToString();
            Min_distance.Text = map.min_distance.ToString();

            List<Solarsystem> systems = map.solarsystems;

            foreach (Solarsystem system in systems)
            {

                PictureBox picture = new PictureBox();
                panel1.Controls.Add(picture);
                picture.Image = getImage("sun");
                picture.Left = system.x;
                picture.Top = system.y;
                picture.Width = picture.Image.Width;
                picture.Height = picture.Image.Height;
                picture.Visible = true;

                picture.MouseClick += new MouseEventHandler(picture_Click);


                solarsystemMap.Add(system);

                refferenzTable.Add(picture, system);
                refferenzTable2.Add(system, picture);


            }

            checkNodes();
            printConnections();
        }


        private void tool_move_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tool_systemAdd_Click(object sender, EventArgs e)
        {
            ToolStripButton me = (ToolStripButton)sender;

            tool_Info.Checked = false;
            tool_move.Checked = false;
            tool_NodeAdd.Checked = false;
            tool_NodeDell.Checked = false;
            tool_systemAdd.Checked = false;
            tool_systemDell.Checked = false;
            tool_randomArea.Checked = false;
            tool_delRandomArea.Checked = false;


            me.Checked = true;


            if (selected != null)
            {
                selected.BorderStyle = BorderStyle.None;
                selected = null;

            }
            if (toMove != null)
            {
                move = false;
                toMove = null;

            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void gameDataDateiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "GameData Datei | GameData.dat";

            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    data = new GameData(open.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler: " + ex.Message);
                }
            }
        }

        private void neuToolStripMenuItem_Click(object sender, EventArgs e)
        {

            panel1.Controls.Clear();
            GraphicHelper gr = new GraphicHelper(panel1.Width, panel1.Height);
            panel1.BackgroundImage = gr.flush();

            solarsystemMap.Clear();
            refferenzTable.Clear();
            refferenzTable2.Clear();
            randomArea = null;
            randomAreaReady = false;
        }

        private void vonNetzwerkLadenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Network net = new Network(this);
            net.Show();

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            printConnections();
        }


        public Map getMap()
        {
            Map map = new Map();
            map.solarsystems = solarsystemMap;
            map.randomArea = randomArea;

            map.systemcount = int.Parse(Systemcount.Text);
            map.min_distance = int.Parse(Min_distance.Text);
            return map;
        }

        private void insNetzwerkSpeichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Network net = new Network(this, false);
            net.Show();
        }

    }
}
