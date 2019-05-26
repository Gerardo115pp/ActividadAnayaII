using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using System.Diagnostics;

namespace Actividad2
{
    public partial class MainWindow : Form
    {

        static public vertice randChoice(List<vertice> arr)
        {
            return arr[new Random().Next(arr.Count)];
        }

        static public vertice randChoice(List<vertice> arr, List<vertice> compare) 
        {
            vertice v;
            do
            {
                v = randChoice(arr);
            } while (compare.Contains(v));

            return v;
        }

        private bool dragging = false,
                     IsJoined = false,
                     AgentsFinish = false,
                     done_prim = false,
                     done_kruskal = false,
                     done_dijkstra = false,
                     done_BFS = false,
                     done_DIVDE = false,
                     done_Brute = false;

        long divide_time,
             brute_time;

        int pesoBrute,
            pesoDivide;

        private int cant_agentes = -1,
                    path_maker = 0;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private List<vertice> Circs;
        private Bitmap Original;
        private List<Agente> Agentes = new List<Agente>();
        private List<Thread> threads = new List<Thread>();
        private object R1, R2;

        private System.Timers.Timer Update_agentes;

        public MainWindow()
        {
            InitializeComponent();
            this.Circs = new List<vertice>();
            Thread.CurrentThread.Name = "Proceso principal";
        }

        #region <Frontend>

        private void MainCloseBTN_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MainResizeBTN_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.Location = new Point(0, 0);
                this.ClientSize = new System.Drawing.Size(Screen.PrimaryScreen.WorkingArea.Width,Screen.PrimaryScreen.WorkingArea.Height);
                this.MainResizeBTN.BackgroundImage = new Bitmap(@"C:\Users\Usuario\Documents\Programas C#\Actividades Anaya\Actividad2\Actividad2\imgs\AnayaControlReduze.png"); 
                this.MainResizeBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.MainResizeBTN.BackgroundImage = new Bitmap(@"C:\Users\Usuario\Documents\Programas C#\Actividades Anaya\Actividad2\Actividad2\imgs\Anaya.png");
                this.MainResizeBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            }
        }

        private void MainMinBTN_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void ControlPanel_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void ControlPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void ControlPanel_MouseUp(object sender, MouseEventArgs e)
        {
            this.dragging = false;
        }

        private void ArbolLbl_MouseEnter(object sender, EventArgs e)
        {
            this.ArbolLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(239)))), ((int)(((byte)(28)))));
        }

        private void ArbolLbl_MouseLeave(object sender, EventArgs e)
        {
            this.ArbolLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(219)))), ((int)(((byte)(8)))));
        }

        private void FolderLabel_MouseEnter(object sender, EventArgs e)
        {
            this.FolderLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(40)))), ((int)(((byte)(0)))));
        }

        private void FolderLabel_MouseLeave(object sender, EventArgs e)
        {
            this.FolderLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
        }

        private void SaveTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region <Script>

        #region <Comportamiento>

        private void AnalizarBTN_Click(object sender, EventArgs e)
        {
            if (!IsJoined)
            {
                this.Cfind((Bitmap)this.PictureDivide.Image);
                this.Unir((Bitmap)this.PictureBrute.Image);
                this.BrutaStatus.ForeColor = Color.Green;
                this.DivideStatus.ForeColor = Color.Green;
            }
        }

        private void ArbolLbl_Click(object sender, EventArgs e)
        {
            if(this.Circs.Count > 0)
            {
                Arbol_From arbol = new Arbol_From(this.Circs);
                arbol.Show();
            }

        }

        private void FolderLabel_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                this.RESET();
                this.PictureDivide.Image = new Bitmap(fileDialog.FileName);
                this.PictureBrute.Image = (Bitmap)this.PictureDivide.Image.Clone();
                this.PictureDivide.BackgroundImage = this.PictureDivide.Image;
                this.PictureBrute.BackgroundImage = this.PictureBrute.Image;
                this.Circs.Clear();
                this.CirculosListBox.Items.Clear();
                this.IsJoined = false;
                vertice.RESET();
                Arista.RESET();
            }
        }

        internal void RESET()
        {
            if (this.Original != null)
            {
                this.PictureDivide.Image = (Bitmap)this.Original.Clone();
                this.PictureBrute.Image = (Bitmap)this.Original.Clone();
            }
            this.BrutaStatus.ForeColor = Color.Red;
            this.DivideStatus.ForeColor = Color.Red;
            this.Agentes.Clear();
            this.threads.Clear();
            Agente.Reset();
            this.cant_agentes = -1;


            this.BruteLabel.Text = "Fuerza Bruta";
            this.DivdeLabel.Text = "Divide";
            this.done_prim = false;
            this.done_kruskal = false;
            this.done_BFS = false;
            this.done_dijkstra = false;
            this.done_DIVDE = false;
            this.done_Brute = false;
        }

        private void SaveBTN_Click(object sender, EventArgs e)
        {
            this.PictureBrute.Image.Save(this.SaveTextBox.Text);
        }

        #endregion </Comportamiento>

        #region <Centroides>

        private void drawCROSS(int x, int y, Bitmap bitmap)
        {


            int temp_x = ((x - 10) >= 0) ? (x - 10) : 0, temp_y = ((y - 10) >= 0) ? (y - 10) : 0;

            for (int h = 0; h <= 20; h++)
            {
                try
                {
                    bitmap.SetPixel(x, temp_y + h, Color.Red);

                }
                catch
                {

                }
                try
                {
                    bitmap.SetPixel(temp_x + h, y, Color.Red);

                }
                catch
                {

                }

            }
        }

        private void AddCrosses(Bitmap bitmap)
        {
            int size = Convert.ToInt32(bitmap.Width * 0.02);
            Graphics g = Graphics.FromImage(bitmap);
            foreach (vertice C in this.Circs)
            {
                this.CirculosListBox.Items.Add(C);
                g.DrawString(C.getName(), new Font("Arial", size), new SolidBrush(Color.Red), C.getX(), C.getY());
                this.drawCROSS(C.getX(), C.getY(),bitmap);
            }
        }

        private bool CheckVexs(int x, int y)
        {
            if (this.Circs.Count == 0)
            {
                return false;
            }
            foreach(vertice v in this.Circs)
            {
                if (((Math.Pow((x - v.GetPos()[0]), 2) + (Math.Pow((y - v.GetPos()[1]), 2))) - Math.Pow(v.GetRadio()+5,2)) <= 0)
                {
                    return true;
                }
            }
            return false;
        }

        private void FindCenter(int x, int y, Bitmap bitmap)
        {
            int[] Center = new int[2];
            int ny = y, nx = x, radio;
            while(bitmap.GetPixel(nx,ny+1).B == 0)
            {
                ny++;
            }
            Center[1] = (ny - (ny - y) / 2);// se encuentra el centro vertical
            radio = (ny - y) / 2;
            ny = Center[1];
            while (bitmap.GetPixel(nx+1, ny).B == 0)
            {
                nx++;
            }
            Center[0] = nx;// se guarda la distancia hacia la derecha
            nx = x;
            while (bitmap.GetPixel(nx - 1, ny).B == 0)
            {
                nx--;
            }
            Center[0] -= (Center[0] - nx) / 2;
            this.Circs.Add(new vertice($"{this.Circs.Count}", Center[0], Center[1], radio));
        }

        private void Cfind(Bitmap bitmap)
        {
            bool insidec = false;
            ColorRGB color;
            for(int y = 0; y < this.PictureDivide.Image.Height; y++)
            {
                for(int x = 0; x < this.PictureDivide.Image.Width; x++)
                {
                    #region <Binary>
                    color = new ColorRGB(bitmap.GetPixel(x, y));
                    if (!color.IsBlackWhite())
                    {
                        bitmap.SetPixel(x, y, Color.Blue);
                        if(x > 1 && y > 1 && x < (bitmap.Width-1) && y < (bitmap.Height-1))
                        {
                            if ((new ColorRGB(bitmap.GetPixel(x + 1, y)).Get_RGB() == "255,255,255" && new ColorRGB(bitmap.GetPixel(x - 1, y)).Get_RGB() == "255,255,255") && (new ColorRGB(bitmap.GetPixel(x, y + 1)).Get_RGB() == "255,255,255" && new ColorRGB(bitmap.GetPixel(x, y - 1)).Get_RGB() == "255,255,255"))
                            {
                                bitmap.SetPixel(x + 1, y, Color.Blue);
                                bitmap.SetPixel(x, y + 1, Color.Blue);
                            }
                        }
                    }
                    else if (color.Greaterthen(178))
                    {
                        bitmap.SetPixel(x, y, Color.White);
                    }
                    else
                    {
                        bitmap.SetPixel(x, y, Color.Black);
                    }
                    #endregion

                    color = new ColorRGB(bitmap.GetPixel(x, y));
                    if (color.Get_RGB() == "0,0,0")
                    {
                        if(!insidec)
                        {
                            insidec = true;
                            if (!this.CheckVexs(x, y))
                            {
                                this.FindCenter(x, y, bitmap);
                            }
                        }
                    }
                    else
                    {
                        insidec = false;
                    }//\".+\"$
                }
            }
            PictureDivide.Image = bitmap;
            PictureBrute.Image = (Bitmap)bitmap.Clone();
        }

        #endregion </Centroides>

        #region <Fuerza Bruta>

        private ArrayList get_min(vertice p1, vertice p2)
        {
            ArrayList arista = new ArrayList();
            arista.Add(p1);
            arista.Add(p2);
            int dx = p2.getX() - p1.getX(),
                dy = p2.getY() - p1.getY();
            if (dx != 0 && dy != 0)
            {
                arista.Add(Math.Sqrt(Math.Pow(dx, 2) + Math.Pow(dy, 2)));
            }
            else if ( dx == 0)
            {
                arista.Add(Math.Abs(dy));
            }
            else
            {
                arista.Add(Math.Abs(dx));
            }

            return arista;
        }

        private void Unir(Bitmap bitmap)
        {


            foreach(vertice v in this.Circs)
            {
                foreach(vertice other in this.Circs)
                {
                    if (v != other)
                    {                       
                        v.Bresenham(bitmap, other);
                    }                        
                }
            }
            foreach(vertice v in this.Circs)
            {
                v.PaintLines(bitmap, Color.LimeGreen);
            }

            this.AddCrosses(bitmap);
            this.Original = (Bitmap)this.PictureBrute.Image.Clone();
            this.PictureDivide.Image = (Bitmap)this.Original.Clone();
            this.IsJoined = true;

        }

        #endregion </Fuerza Bruta>

        #region <Actividad 3>

        private void maximoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cant_agentes = -1;
        }

        private void BTN_Agentes_ButtonClick(object sender, EventArgs e)
        {
            if (this.IsJoined)
            {
                if (this.path_maker == 0)
                {
                    this.RESET();
                    cant_agentes = (cant_agentes == -1) ? Circs.Count : cant_agentes;
                    List<int> usados = new List<int>();
                    int k;
                    Random selector = new Random();
                    for (int h = 0; h < Circs.Count; h++)
                    {
                        usados.Add(h);
                    }
                    Agente.mapa = (Bitmap)this.PictureDivide.Image;
                    Agente.mapa_limpio = this.Original;
                    Agente.Box = this.PictureDivide;
                    for (int h = 0; h < cant_agentes; h++)
                    {
                        Point cords = this.Circs[h].GetPoint();
                        k = usados[selector.Next(0, usados.Count)];
                        usados.Remove(k);
                        this.Agentes.Add(new Agente(this.Circs[k]));
                        threads.Add(new Thread(new ThreadStart(Agentes[h].Elegir_Camino)));
                        threads[h].Name = $"Thread {h}";
                        threads[h].Start();
                    }
                    SetTimer();
                }
                else if (done_kruskal && done_prim)
                {
                    this.RESET();
                }
                else if (this.path_maker == 1 && !done_kruskal)
                {
                    /*
                     * KRUSKAL
                     */ 

                    HashSet<Arista> conjunto_aristas = new HashSet<Arista>();
                    Pqueue<Arista> aristas = new Pqueue<Arista>();
                    Dictionary<vertice, Arista> vecinos;
                    foreach (vertice v in this.Circs)
                    {
                        vecinos = v.GetVecinos();
                        foreach (vertice vk in vecinos.Keys)
                        {
                            if (!conjunto_aristas.Contains(vecinos[vk]))
                            {
                                aristas.Enqueue(vecinos[vk], vecinos[vk].GetDist());
                                conjunto_aristas.Add(vecinos[vk]);
                            }                 
                        }                    
                    }
                    if (aristas.Count == 0)
                    {
                        MessageBox.Show("No hay caminos posibles");
                        return;
                    }
                    UnionFindSet<vertice> unionFind = new UnionFindSet<vertice>();// 1 operacion
                    Dictionary<string, vertice> Clones = new Dictionary<string, vertice>();// 1 operacion
                    Arista this_ar = aristas.Dequeue().Data;// 2 operacion
                    List<Arista> Aceptadas = new List<Arista>();// 1 operacion
                    Aceptadas.Add(this_ar);// 1 operacion
                    vertice ARM_root = this_ar.A.Clone(),this_v = this_ar.B.Clone(),pA,pB;// 2 operacion
                    ARM_root.Add_Vecino(this_ar.Clone(ARM_root, this_v), this_v);// 2 operacion
                    Clones.Add(ARM_root.getName(), ARM_root);// 1 operacion
                    Clones.Add(this_v.getName(), this_v);// 1 operacion
                    unionFind.MakeSet(ARM_root).Add(this_v);// 2 operacion

                    bool a_in, b_in;
                    int arm_ideal = this.Circs.Count - 1,// 2 operacion
                        cant_aristas = 1;// 1 operacion

                    while (aristas.Count > 0)// 1 operacion
                    {
                        this_ar = aristas.Dequeue().Data;// 1 operacion
                        a_in = Clones.ContainsKey(this_ar.A.Name);// 1 operacion
                        b_in = Clones.ContainsKey(this_ar.B.Name);// 1 operacion
                        if ((!a_in) && (!b_in))// 3 operacion
                        {
                            pA = this_ar.A.Clone();// 2 operacion
                            pB = this_ar.B.Clone();// 2 operacion
                            Clones.Add(this_ar.B.Name, pB);// 1 operacion
                            Clones.Add(this_ar.A.Name,pA);// 1 operacion
                            Clones[this_ar.B.Name].Add_Vecino(this_ar.Clone(pA,pB), pA);// 3 operacion
                            cant_aristas++;// 1 operacion
                            Aceptadas.Add(this_ar);// 1 operacion
                            unionFind.MakeSet(pA).Add(pB);// 1 operacion
                        }
                        else if (!b_in)
                        {
                            pA = Clones[this_ar.A.Name];
                            pB = this_ar.B.Clone();
                            Clones.Add(this_ar.B.Name, pB);
                            Clones[this_ar.B.Name].Add_Vecino(this_ar.Clone(pA, pB), pA);
                            cant_aristas++;
                            Aceptadas.Add(this_ar);
                            unionFind.AddTo(pB, pA);
                        }
                        else if (!a_in)
                        {
                            pA = this_ar.A.Clone();
                            pB = Clones[this_ar.B.Name];
                            Clones.Add(this_ar.A.Name, pA);
                            Clones[this_ar.A.Name].Add_Vecino(this_ar.Clone(pA, pB), pB);
                            cant_aristas++;
                            Aceptadas.Add(this_ar);
                            unionFind.AddTo(pA, pB);
                        }
                        else
                        {
                            pA = Clones[this_ar.A.Name];
                            pB = Clones[this_ar.B.Name];
                            if (!unionFind.Joined(pA, pB))
                            {
                                Clones[this_ar.A.Name].Add_Vecino(this_ar.Clone(pA, pB), pB);
                                cant_aristas++;
                                Aceptadas.Add(this_ar);
                                unionFind.Union(pA, pB);
                            }
                        }
                        if (Clones.Count >= this.Circs.Count && cant_aristas >= arm_ideal)// 5 operacion
                        {
                            break;
                        }
                    }
                    Bitmap Arm_bitmap = (Bitmap)Original.Clone();
                    foreach(vertice v in Clones.Values)
                    {
                        v.PaintLines(Arm_bitmap, Color.Red);
                    }
                    DivdeLabel.Text = "Kruskal";
                    this.Kruskal_walk(ARM_root,Arm_bitmap,unionFind.Find(ARM_root));
                    this.done_kruskal = true;
                    ArrayList Result = new ArrayList();
                    Result.Add(Aceptadas);
                    Result.Add(Arm_bitmap);
                    R1 = Aceptadas;
                }
                else if (this.path_maker == 2 && !done_prim)
                {
                    /*
                     * PRIM
                     */
                    
                    Cant_change input_max = new Cant_change(this.Circs.Count - 1,"Inicio",0);

                    if(input_max.ShowDialog() == DialogResult.OK)
                    {
                        UnionFindSet<vertice> unionFind = new UnionFindSet<vertice>();
                        Pqueue<Arista> visibles = new Pqueue<Arista>();
                        Dictionary<string,vertice> Clones = new Dictionary<string, vertice>();
                        List<Arista> Aceptadas = new List<Arista>();
                        vertice s = this.Circs[input_max.cantidad].Clone(),pA,pB,Missing;
                        Clones.Add(s.Name, s);
                        unionFind.MakeSet(s);
                        this.EnqueueVecinos(this.Circs[input_max.cantidad], visibles);
                        bool a_in, b_in;
                        Arista this_ar;

                        while(Clones.Count < this.Circs.Count)
                        {
                            if (visibles.Count > 0)
                            {
                                this_ar = visibles.Dequeue().Data;
                                a_in = Clones.ContainsKey(this_ar.A.Name);
                                b_in = Clones.ContainsKey(this_ar.B.Name);
                            }
                            else
                            {
                                /*
                                 * Esto se hace con el proposito de que llegue hasta la ultima condicion
                                 * que es la de salto a otro arbol.
                                 */
                                this_ar = null;
                                a_in = false;
                                b_in = false;
                            }


                            if(a_in && b_in)
                            {
                                continue;
                            }
                            if (a_in)
                            {
                                pA = Clones[this_ar.A.Name];
                                pB = this_ar.B.Clone();
                                pA.Add_Vecino(this_ar.Clone(pA, pB), pB);
                                Aceptadas.Add(this_ar);
                                unionFind.AddTo(pB, pA);
                                Clones.Add(pB.Name, pB);
                                this.EnqueueVecinos(this_ar.B, visibles,this_ar);
                            }
                            else if (b_in)
                            {
                                pB = Clones[this_ar.B.Name];
                                pA = this_ar.A.Clone();
                                pB.Add_Vecino(this_ar.Clone(pA, pB), pA);
                                Aceptadas.Add(this_ar);
                                unionFind.AddTo(pA, pB);
                                Clones.Add(pA.Name, pA);
                                this.EnqueueVecinos(this_ar.A, visibles, this_ar);
                            }
                            if (visibles.Count == 0 && (Clones.Count < this.Circs.Count))
                            {
                                Missing = this.GetAMissingOne(Clones.Keys.ToList());
                                s = Missing.Clone();
                                unionFind.MakeSet(s);
                                Clones.Add(s.Name, s);
                                this.EnqueueVecinos(Missing, visibles);
                            }
                        }
                        Bitmap Prim_Bitmap = (Bitmap)this.PictureBrute.Image.Clone();
                        foreach (vertice v in Clones.Values)
                        {
                            v.PaintLines(Prim_Bitmap, Color.Red);
                        }
                        this.PictureBrute.Image = Prim_Bitmap;
                        s = Clones[Circs[input_max.cantidad].Name];
                        BruteLabel.Text = "Prim";
                        this.Kruskal_walk(s, Prim_Bitmap, unionFind.Find(s),"b");
                        done_prim = true;
                        R2 = Aceptadas;

                    }
                }
                else if (this.path_maker == 3 && !done_dijkstra)
                {
                    /*
                     * DIJKSTRA
                     */
                    DijkstraOptions configs = new DijkstraOptions(this.Circs.Count-1);
                    if (configs.ShowDialog() == DialogResult.OK)
                    {
                        this.RESET();
                        int nacimiento = configs.Born,
                            Predators = configs.Predators,
                            destiny = configs.Destiny;
                        Agente.mapa = (Bitmap)this.PictureDivide.Image.Clone();
                        Agente.mapa_limpio = (Bitmap)Agente.mapa.Clone();
                        Agente.Box = this.PictureDivide;
                        this.Agentes.Add(new Agente(this.Circs[nacimiento]));
                        this.Agentes[0].dieEvent += new Agente.Finish(this.killEvilAgents);
                        this.threads.Add(new Thread(new ParameterizedThreadStart(Agentes[0].Dijkstra)));
                        this.threads[0].Name = "Jon Snow";

                        List<vertice> seleccionados = new List<vertice>();
                        seleccionados.Add(this.Circs[nacimiento]);
                        for(int h=1;h <= Predators;h++)//Aqui se agregan las depredadoras
                        {
                            seleccionados.Add(MainWindow.randChoice(this.Circs,seleccionados));
                            this.Agentes.Add(new Agente(seleccionados[h],true));
                            this.Agentes[h].Killagente += new Agente.KillAgent(this.killTheGoodAgent);
                            this.threads.Add(new Thread(new ParameterizedThreadStart(Agentes[h].DFS)));
                            this.threads[h].Name = $"WhiteWalker {seleccionados[h].Name}";
                        }
                        this.threads[0].Start(this.Circs[destiny]);
                        List<Agente> contrato = new List<Agente>();
                        contrato.Add(null);
                        contrato.Add(this.Agentes[0]);
                        for(int h=1;h < this.threads.Count; h++)
                        {
                            this.threads[h].Start(contrato);
                        }
                        SetTimer();

                    }
                }
                else if (this.path_maker == 4 && !done_BFS)
                {
                    this.RESET();
                    List<Arista> mapa = null;
                    bool found = false;
                    foreach(vertice v in this.Circs)
                    {
                        mapa = v.breadth(this.Circs.Count);
                        if (mapa != null)
                        {
                            this.paintAristaList(mapa);
                            this.paintNiveles();
                            found = true;
                            break;
                        }
                        this.Circs.ForEach((c) => { c.ResetVisit(); });
                    }
                    if (!found)
                    {
                        MessageBox.Show("No se puede crear el arbol");
                    }
                }
                else if (this.path_maker == 5)
                {
                    DijkstraMultOptions options = new DijkstraMultOptions(this.Circs.Count);
                    if (options.ShowDialog() == DialogResult.OK)
                    {
                        this.RESET();
                        Agente.mapa = (Bitmap)this.PictureDivide.Image.Clone();
                        Agente.mapa_limpio = (Bitmap)Agente.mapa.Clone();
                        Agente.Box = this.PictureDivide;
                        List<Dictionary<string, int>> presas = options.Presas;
                        int Depredadoras = options.Depredadoras,
                            h = 0;
                                    
                        List<Agente> contrato = new List<Agente>();
                        List<vertice> opciones_depredadoras = new List<vertice>();
                        this.Circs.ForEach((v) =>
                        {
                            if (presas.All((p) => { return p["origen"] != Convert.ToInt32(v.Name); }))
                            {
                                opciones_depredadoras.Add(v);
                            }
                        }); //Aqui se añaden Los vertices que no pertenecen actualmente a una presa
                        Agente agente;
                        foreach(Dictionary<string,int> dic in presas)
                        { 
                            agente = new Agente(this.Circs[dic["origen"]]);
                            contrato.Add(agente);
                            agente.dieEvent += new Agente.Finish(tryToKillAllAgente);
                            this.Agentes.Add(agente);
                            this.threads.Add(new Thread(new ParameterizedThreadStart(agente.Dijkstra)));
                            this.threads[h].Start(this.Circs[dic["destino"]]);
                            this.threads[h].Name = $"Presa {dic["origen"]}";
                            h++;
                        }
                        Thread thread;
                        for (h=0; h < Depredadoras; h++)
                        {
                            agente = new Agente(opciones_depredadoras[h], true);
                            this.Agentes.Add(agente);
                            thread = new Thread(new ParameterizedThreadStart(agente.DFS));
                            this.threads.Add(thread);
                            thread.Start(contrato);
                        }

                        SetTimer();


                    }
                }
            }
        }

        private void SetTimer()
        {
            Update_agentes = new System.Timers.Timer(35);
            Update_agentes.Elapsed += Move_Agentes;
            Update_agentes.AutoReset = true;
            Update_agentes.Enabled = true;
        }

        private void Move_Agentes(object sender, ElapsedEventArgs e)
        {
            Update_agentes.Enabled = false;
            Agente.Update_Box(this.Agentes, Update_agentes);

            if (threads.All((t) => !t.IsAlive))
            {
                Update_agentes.AutoReset = false;
                Update_agentes.Stop();
                Update_agentes.Dispose();
                Update_agentes.Close();
                this.AgentsFinish = true;
                this.Agentes.ForEach((x) => x.calc_recorrido());
            }
        }

        private void elegirCantidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsJoined)
            {
                Cant_change cant = new Cant_change(Circs.Count);
                if (cant.ShowDialog() == DialogResult.OK)
                {
                    cant_agentes = cant.cantidad;
                }
            }
        }

        private void CaminosDeAgenteMenuItem_Click(object sender, EventArgs e)
        {
            if (AgentsFinish)
            { 
                CaminosForm caminosf = new CaminosForm((Bitmap)this.PictureBrute.Image, this.Agentes);
                caminosf.ShowDialog();
            }
        }

        #endregion </Actividad 3>

        #region <Actividad 4>

        private void algoritmosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
             * Aqui se seleciona el algoritmo con el que se generara el recorrido del
             * agente
             */
            Rutas rutas = new Rutas(this.path_maker);
            if (rutas.ShowDialog() == DialogResult.OK)
            {
                this.path_maker = rutas.Selected;
            }

        }

        private void Kruskal_walk(vertice arm_root,Bitmap bmp_arm, HashSet<vertice> camino,string w="d")
        {
            Agente.Reset();
            Agente.mapa = bmp_arm;
            Agente.mapa_limpio = (Bitmap)bmp_arm.Clone();
            Agente.Box = (w=="d") ? this.PictureDivide : this.PictureBrute;
            this.Agentes.Clear();
            this.threads.Clear();

            this.Agentes.Add(new Agente(arm_root));
            this.Agentes[0].dieEvent += new Agente.Finish(() => {
                if(done_kruskal && done_prim)
                {
                    DescribePK pK = new DescribePK((List<Arista>)R2, (List<Arista>)R1);
                    pK.ShowDialog();
                }
            });
            this.threads.Add(new Thread(new ParameterizedThreadStart(Agentes[0].Cover_All)));
            this.threads[0].Name = "Kruskal worker";
            this.threads[0].Start(camino);
            SetTimer();
        }

        private void EnqueueVecinos(vertice v,Pqueue<Arista> aristas,Arista repetida=null)

        {
            /*
             * Esta funcion se utiliza en ARM, agrega todas las aristas que conectan 
             * al vertice 'v' en la Cola de prioridad 'aristas'.
             */
             foreach(Arista a in v.GetVecinos().Values)
            {
                if(a != repetida)
                {
                    aristas.Enqueue(a, a.GetDist());
                }
            }

        }

        private vertice GetAMissingOne(List<string> gotten)
        {
            /*
             * Devuelve un vertice que no este incluido en 'gotten',
             * esto se usa para saltar de arbol en el algoritmo de prim
             */
            foreach(vertice v in this.Circs)
            {
                if (!gotten.Contains(v.Name))
                {
                    return v;
                }
            }
            return null;
        }


        #endregion </Actividad 4>

        #region <Actividad 5>

        private void killEvilAgents()
        {
            for (int h=1;h< this.threads.Count; h++)
            {
                if (threads[h] != Thread.CurrentThread)
                {
                    this.threads[h].Abort();
                }
            }
        }

        private void killTheGoodAgent()
        {
            this.threads[0].Abort();
            this.killEvilAgents();
        }

        #endregion </Actividad 5>

        #region <Actividad 6>
        
        private void paintAristaList(List<Arista> aristas)
        {
            Bitmap bitmap = (Bitmap)this.PictureDivide.Image.Clone();
            foreach(Arista a in aristas)
            {
                a.SetColors(Color.DarkRed, bitmap, true);
            }
            this.PictureDivide.Image = bitmap;
        }

        private void paintNiveles()
        {
            Bitmap bitmap = (Bitmap)this.PictureDivide.Image.Clone();
            int size = Convert.ToInt32(bitmap.Width * 0.05);
            SolidBrush brush = new SolidBrush(Color.Cyan);
            Graphics graphics = Graphics.FromImage(bitmap);
            Font font = new Font("Arial", size);
            foreach(vertice v in this.Circs)
            {
                graphics.DrawString(v.Nivel.ToString(), font, brush, (v.getX() - size), (v.getY() - size));
            }
            this.PictureDivide.Image = bitmap;
        }

        private void DivideStatus_Click(object sender, EventArgs e)
        {
                
            if (this.Circs.Count > 1)
            {
                Bitmap bitmap = (Bitmap)this.PictureDivide.Image.Clone();
                List<vertice>  closest_pairX, closest_pairY,closest_pair, verticesSortedX = new List<vertice>(), verticesSortedY = new List<vertice>();

                this.Circs.ForEach((v) => { verticesSortedX.Add(v); });
                this.Circs.ForEach((v) => { verticesSortedY.Add(v); });

                verticesSortedX.Sort(delegate (vertice a, vertice b) {
                    if (a.getX() == b.getX())
                    {
                        return 0;
                    }
                    else if (a.getX() > b.getX())
                    {
                        return 1;
                    }
                    else
                    {
                        return -1;
                    }
                });
                verticesSortedY.Sort(delegate (vertice a, vertice b) {
                    if (a.getY() == b.getY())
                    {
                        return 0;
                    }
                    else if (a.getY() > b.getY())
                    {
                        return 1;
                    }
                    else
                    {
                        return -1;
                    }
                });

                Stopwatch watch = Stopwatch.StartNew();
                closest_pairX =  this.divideyVenceras(verticesSortedX);
                closest_pairY = this.divideyVenceras(verticesSortedY);

                if ((closest_pairX[0].calcDistBetween(closest_pairX[1])) < (closest_pairY[0].calcDistBetween(closest_pairY[1])))
                {
                    closest_pair = closest_pairX;
                }
                else
                {
                    closest_pair = closest_pairY;
                }

                Graphics graphics = Graphics.FromImage(bitmap);
                graphics.DrawLine(new Pen(Color.FromArgb(255,138,219,8), 4), closest_pair[0].GetPoint(), closest_pair[1].GetPoint());
                this.PictureDivide.Image = bitmap;
                done_DIVDE = true;
                watch.Stop();
                divide_time = watch.ElapsedMilliseconds;
                pesoDivide = (int)closest_pair[0].calcDistBetween(closest_pair[1]);
                if (done_Brute)
                {
                    MessageBox.Show($"Tiempo de divide y venceras: {divide_time}ms; Peso de Arista: {pesoDivide}\nTiempo de fuerza bruta: {brute_time}ms; Peso de Arista: {pesoBrute}");
                }
            }
        }
        
        private List<List<vertice>> DividirLista(List<vertice> original)
        {
            List<List<vertice>> result = new List<List<vertice>>();
            if(original.Count > 1)
            {
                List<vertice> partI = new List<vertice>(),
                              partII = new List<vertice>();
                int middle = (int)Math.Round((double)original.Count / 2),
                    h = 0;
                for(; h < middle; h++)
                {
                    partI.Add(original[h]); 
                }
                result.Add(partI);
                for(;h<original.Count; h++)
                {
                    partII.Add(original[h]);
                }
                result.Add(partII);
                return result;
            }
            else
            {
                result.Add(original);
                return result;
            }
        }

        private bool checkAdyacentes(List<vertice> puntos_a, List<vertice> puntos_b, List<List<vertice>> listas,double distI,double distII)
        {
            vertice remplazoA, remplazoB;
            double newDistI, newDistII;
            bool result = false;
            remplazoA = puntos_a[0].checkCricsinRange(distI,listas[1]);
            if (remplazoA == null)
            {
                remplazoA = puntos_a[1].checkCricsinRange(distI,listas[1]);
                if (remplazoA != null)
                {
                    puntos_a[0] = remplazoA;
                    result = true;
                }
            }
            else
            {
                puntos_a[1] = remplazoA;
                result = true;
            }
            remplazoB = puntos_b[0].checkCricsinRange(distII, listas[0]);
            if (remplazoB == null)
            {
                 remplazoB = puntos_b[1].checkCricsinRange(distII, listas[1]);
                if (remplazoB != null)
                {
                    puntos_b[0] = remplazoB;
                    result = true;
                }
            }
            else
            {
                puntos_b[1] = remplazoB;
                result = true;
            }
            newDistI = puntos_a[0].calcDistBetween(puntos_a[1]);
            newDistII = puntos_b[0].calcDistBetween(puntos_b[1]);
            if (newDistI == distI && newDistII == distII)
            {
                return false;
            }
            return result;
        }

        private List<vertice> divideyVenceras(List<vertice> lista)
        {

            lista = (lista == null) ? this.Circs : lista;
            if(lista.Count > 5)
            {
                List<List<vertice>> listas = new List<List<vertice>>();
                List<vertice> puntos_a = new List<vertice>(),
                              puntos_b = new List<vertice>();
                double distI, distII;
                listas = this.DividirLista(lista);
                puntos_a = this.divideyVenceras(listas[0]);
                puntos_b = this.divideyVenceras(listas[1]);
                do
                {
                    distI = puntos_a[0].calcDistBetween(puntos_a[1]);
                    distII = puntos_b[0].calcDistBetween(puntos_b[1]);
                } while (checkAdyacentes(puntos_a,puntos_b,listas,distI,distII));
                return (distI < distII) ? puntos_a : puntos_b;
            }
            else
            {
                double minimo_actual = this.PictureBrute.Image.Width * 20,
                    distancia_actual;
                List<vertice> resultado = new List<vertice>();
                vertice a, b;
                for(int h = 0; h < lista.Count; h++)
                {
                    a = lista[h];
                    for (int k =0; k < lista.Count; k++)
                    {
                        b = lista[k];
                        if(b != a)
                        {
                            distancia_actual = a.calcDistBetween(b);
                            if (distancia_actual < minimo_actual)
                            {
                                minimo_actual = distancia_actual;
                                resultado.Clear();
                                resultado.Add(a);
                                resultado.Add(b);
                            }
                        }
                    }
                }
                return resultado;
            }
        }

        private void fuerzaBrutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Circs.Count > 1)
            {
                //this.RESET();

                Stopwatch watch = Stopwatch.StartNew();
                double minimo_actual = this.PictureBrute.Image.Width * 20;
                vertice vertice_a=null, vertice_b=null;
                foreach(vertice v1 in this.Circs)
                {
                    foreach(vertice v2 in this.Circs)
                    {
                        if(v1 != v2)
                        {
                            if (v1.calcDistBetween(v2) < minimo_actual)
                            {
                                minimo_actual = v1.calcDistBetween(v2);
                                vertice_a = v1;
                                vertice_b = v2;
                            }
                        }
                    }
                }
                if (vertice_a != null)
                {
                    Bitmap bitmap = (Bitmap)this.PictureBrute.Image.Clone();
                    Graphics graphics = Graphics.FromImage(bitmap);
                    graphics.DrawLine(new Pen(Color.FromArgb(255, 138, 219, 8), 4), vertice_a.GetPoint(), vertice_b.GetPoint());
                    this.PictureBrute.Image = bitmap;
                }
                done_Brute = true;
                watch.Stop();
                brute_time = watch.ElapsedMilliseconds;
                pesoBrute = (int)minimo_actual;
                if (done_DIVDE)
                {
                    MessageBox.Show($"Tiempo de divide y venceras: {divide_time}ms; Peso de Arista: {pesoDivide}\nTiempo de fuerza bruta: {brute_time}ms; Peso de Arista: {pesoBrute}");
                }
            }
        }

        #endregion </Actividad 6>

        #region <Proyecto>

        private void tryToKillAllAgente()
        {
            if(Agente.GoodAgentes.All((a) => { return !a.IsAlive; }))
            {
                this.killEvilAgents();
            }
        }

        #endregion </Proyecto>

        #endregion </Script>

    }

    public class ColorRGB
    {
        public string nombre;
        public int A, R, G, B;
        public ColorRGB(Color color)
        {
            this.nombre = color.Name;
            this.A = color.A;
            this.R = color.R;
            this.G = color.G;
            this.B = color.B;
        }


        public string Get_RGB()
        {
            return $"{this.R},{this.G},{this.B}";
        }

        public bool Lowerthen(int n)
        {
            return (R <= n && B <= n && G <= n);
        }

        public bool Greaterthen(int n)
        {
            return (R >= n && B >= n && G >= n);
        }

        public bool IsBlackWhite()
        {
            return (this.R == this.G && this.G == this.B);
        }

    }

    public class Arista
    {
        static Dictionary<string, Arista> aristas = new Dictionary<string, Arista>();

        static public Dictionary<string,Arista> Aristas
        {
            get { return Arista.aristas; }
        } 

        static public void RESET()
        {
            Arista.aristas.Clear();
        }

        List<int[]> points;
        vertice pA, pB;
        string name;
        bool painted;
        double distancia;

        public Arista(List<int[]> points,vertice pA,vertice pB)
        {
            this.points = points;
            this.pA = pA;
            this.pB = pB;
            this.name = $"({pA.getName()} Entre {pB.getName()})";
            this.painted = false;
            this.distancia = calc_distancia();
            if (!Arista.Aristas.ContainsKey(this.name))
            {
                Arista.Aristas.Add(this.name, this);
            }
        }

        public override string ToString()
        {
            return $"{this.name}Peso:{this.distancia}";
        }

        public Arista Clone()
        {
            return new Arista(this.points, pA.Clone(), pB.Clone());
        }

        public Arista Clone(vertice a, vertice b)
        {
            /*
             * Clona la arista permitiendo re asignar los punto A y B
             */
            return new Arista(this.points, a, b);
        }
  
        /*public int Len()
        {
            return this.points.Count;
        }*/

        public double GetDist()
        {
            return this.distancia;
        }

        private double calc_distancia()
        {
            int distancia;
            int dx = pA.getX() - pB.getX(),
                dy = pA.getY() - pB.getY();
            if (dx != 0 && dy != 0)
            {
                distancia = (Int32)(Math.Sqrt(Math.Pow(dx, 2) + Math.Pow(dy, 2)));
            }
            else if (dx == 0)
            {
                distancia = (Math.Abs(dy));
            }
            else
            {
                distancia = (Math.Abs(dx));
            }
            return distancia;
        }

        public vertice Get_Destino(vertice actual)
        {
            return (actual == pA) ? pB : pA;
        }

        public List<int[]> GetPoints()
        {
            return this.points;
        }

        public void SetColors(Color color,Bitmap bitmap, bool force = false)
        {
            for(int h = 0;h < this.points.Count; h++)
            {
                if(painted && !force)
                {
                    //TODO: preguntarle a anaya por este error MessageBox.Show("Funciono!");
                    return;
                }

                bitmap.SetPixel(this.points[h][0], this.points[h][1], color);
            }
            this.painted = true;
        }

        public vertice A
        {
            get { return this.pA; }
        }

        public vertice B
        {
            get { return this.pB; }
        }
    }

    public class vertice
    {
        static List<vertice> Vertices = new List<vertice>();

        static public bool isAny(int x, int y)
        {
            foreach(vertice v in vertice.Vertices)
            {
                if (v.iSelf(x, y))
                {
                    return true;
                }
            }
            return false;
        }

        static public void RESET()
        {
            vertice.Vertices.Clear();
        }

        static public int Count
        {
            get { return Vertices.Count; }
        }

        static public vertice getVex(int pos)
        {
            return vertice.Vertices[pos];
        }

        int[] cords;
        int radio;
        string name;
        bool visited;
        int nivel;
        Dictionary<vertice,Arista> aristas;

        public vertice(string name,int x, int y,int radio)
        {
            this.cords = new int[] { x, y };
            this.name = name;
            this.visited = false;
            aristas = new Dictionary<vertice,Arista>();
            this.radio = radio;
            vertice.Vertices.Add(this);
        }

        public override string ToString()
        {
            return $"Circulo {this.name}: (x:{cords[0]}, y:{cords[1]}, radio:{this.radio})";
        }

        public int Nivel
        {
            get
            {
                return this.nivel;
            }
            set
            {
                this.nivel = value;
            }
        }

        public vertice Clone()
        {
            return new vertice(this.name, this.cords[0], this.cords[1], this.radio);
        }

        public Dictionary<vertice, Arista> GetVecinos()
        {
            return this.aristas;
        }

        public void Add_Vecino(Arista arista, vertice other)
        {
            if (!aristas.ContainsKey(other))
            {
                this.aristas.Add(other, arista);
                other.Add_Vecino(arista, this);
            }
        }

        public bool iSelf(int x, int y)
        {
            if (((Math.Pow((this.cords[0] - x), 2) + (Math.Pow((this.cords[1] - y), 2))) - Math.Pow(this.GetRadio() + 5, 2)) <= 0)
            {
                return true;
            }
            return false;
        }

        public double calcDistBetween(vertice other)
        {
            /*
             * Calcula la distancia entre un vertice y otro
             */
            double dist;
            int dx = other.getX() - this.getX(),
                dy = other.getY() - this.getY();
            if (dx != 0 && dy != 0)
            {
                dist = (double)(Math.Sqrt(Math.Pow(dx, 2) + Math.Pow(dy, 2)));
            }
            else if (dx == 0)
            {
                dist = (double)(Math.Abs(dy));
            }
            else
            {
                dist = (double)(Math.Abs(dx));
            }
            return dist;
        }

        public vertice checkCricsinRange(double dist, List<vertice> circulos=null)
        {
            circulos = (circulos == null) ? vertice.Vertices : circulos;
            vertice actual = null;
            foreach (vertice v in circulos)
            {
                if((((Math.Pow((this.cords[0] - v.getX()), 2) + (Math.Pow((this.cords[1] - v.getY()), 2))) - Math.Pow(dist + 5, 2)) <= 0))
                {
                    if(dist > this.calcDistBetween(v) && v != this)
                    {
                        dist = this.calcDistBetween(v);
                        actual = v;
                    }
                }
            }
            return actual;

        }

        public bool Bresenham(Bitmap bitmap, vertice other, bool force = false)
        {

            if (this.aristas.ContainsKey(other))
            {
                  return false;
            }
            List<int[]> arista_points = new List<int[]>();
            int x0 = cords[0], y0 = cords[1], x1 = other.getX(), y1 = other.getY();

            int dx = Math.Abs(x1 - x0),
                dy = Math.Abs(y1 - y0);

            bool ok;

            if (dx >= dy)
            {
                ok = BresenhamX(x0, y0, x1, y1, dy, dx,bitmap, arista_points,other,force);
            }
            else
            {
                ok = BresenhamY(x0, y0, x1, y1, dy, dx, bitmap, arista_points, other,force);
            }

            if (!ok)
            {
                return false;//nuevo
            }
            Arista arista = new Arista(arista_points, other, this);
            this.aristas.Add(other, arista);
            other.aristas.Add(this,arista);
            return true;//nuevo
        }

        private bool BresenhamX(int x0, int y0, int x1, int y1, int dy, int dx, Bitmap bitmap, List<int[]> arista, vertice other, bool force = false)
        {
            int error = 2 * dy - dx,
                j = 2 * dy,
                k = 2 * (dy - dx);

            if (x0 >= x1)
            {
                int temp = x1;
                x1 = x0;
                x0 = temp;

                temp = y1;
                y1 = y0;
                y0 = temp;
            }
            arista.Add(new int[] { x0, y0 });
            while(x0 < x1)
            {
                if (error < 0)
                {
                    error += j;
                }
                else
                {
                    if (y0 < y1)
                    {
                        y0++;
                    }
                    else
                    {
                        y0--;
                    }
                    error += k;
                }
                x0++;
                if (new ColorRGB(bitmap.GetPixel(x0, y0)).Get_RGB() != "255,255,255" && !this.iSelf(x0, y0) && !(other.iSelf(x0, y0)) && !force)
                {
                    return false;
                }
                arista.Add(new int[] { x0, y0 });
            }
            return true;
        }

        private bool BresenhamY(int x0, int y0, int x1, int y1, int dy, int dx, Bitmap bitmap, List<int[]> arista, vertice other, bool force = false)
        {
            int error = 2 * dx - dy,
                j = 2 * dx,
                k = 2 * (dx - dy);

            if (y0 >= y1)
            {
                int temp = x1;
                x1 = x0;
                x0 = temp;

                temp = y1;
                y1 = y0;
                y0 = temp;
            }
            arista.Add(new int[] { x0, y0 });
            while (y0 < y1)
            {
                if (error < 0)
                {
                    error += j;
                }
                else
                {
                    if (x0 < x1)
                    {
                        x0++;
                    }
                    else
                    {
                        x0--;
                    }
                    error += k;
                }
                y0++;
                if (new ColorRGB(bitmap.GetPixel(x0, y0)).Get_RGB() != "255,255,255" && !this.iSelf(x0, y0) && !(other.iSelf(x0, y0)) && !force)
                {
                    return false;
                }
                arista.Add(new int[] { x0, y0 });
            }
            return true;
        }

        public void PaintLines(Bitmap bitmap,Color color)
        {
      
            foreach (vertice line in this.aristas.Keys)
            {
                this.aristas[line].SetColors(color,bitmap);
            }
        }

        public void Map(Action<vertice> func,vertice vex = null)
        {
            if (vex == null)
            {
                vex = this;
            }
            Queue<vertice> cola = new Queue<vertice>();
            cola.Enqueue(vex);
            while (cola.Count == 0)
            {
                vertice actual = cola.Dequeue();
                foreach (vertice v in actual.GetVecinos().Keys)
                {

                    if (!v.IsVisited())
                    {
                        v.Visit();
                        func(v);
                        cola.Enqueue(v);
                    }
                }

            }
        }

        public List<Arista> breadth(int lenVexs)

        {

            vertice vex = this;
            vertice actual;
            Dictionary<vertice, Arista> vecinos;
            Queue<vertice> cola = new Queue<vertice>();
            List<Arista> visitadas = new List<Arista>();
            cola.Enqueue(vex);
            vex.Nivel = 0;
            int? maxLevel = null;
            int vexs_found = 1;
            bool isLeaf;

            while (cola.Count != 0)
            {
                isLeaf = true;
                actual = cola.Dequeue();
                vecinos = actual.GetVecinos();
                actual.Visit();
                foreach (vertice v in vecinos.Keys)
                {
                    if (!v.IsVisited())
                    {
                        vexs_found++;
                        v.Nivel = actual.Nivel + 1;
                        isLeaf = false;
                        visitadas.Add(vecinos[v]);
                        v.Visit();
                        cola.Enqueue(v);
                    }
                }
                if (isLeaf)
                {
                    if (maxLevel == null)
                    {
                        maxLevel = actual.Nivel;
                    }
                    else if(maxLevel != actual.Nivel)
                    {
                        return null;
                    }
                }
            }
            if (vexs_found != lenVexs)
            {
                return null;
            }
            return visitadas;
        }

        public void depth(vertice vex = null)
        {
            if (vex == null)
            {
                vex = this;
            }
            vex.Visit();
            foreach (vertice v in vex.GetVecinos().Keys)
            {
                if (!v.IsVisited())
                {
                    this.depth(v);
                }
            }
        }
        
        public Point GetPoint()
        {
            return new Point(this.cords[0], this.cords[1]);
        }

        public bool IsVisited()
        {
            return this.visited;
        }

        public void Visit()
        {
            this.visited = true;
        }

        public void ResetVisit()
        {
            this.visited = false;
        }

        public int[] GetPos()
        {
            return new int[] { cords[0], cords[1] };
        }

        public string getName()
        {
            /*
             * Deprecado
             */
            return this.name;
        }

        public string Name
        {
            get { return this.name; }
        }

        public int getX()
        {
            return this.cords[0];
        }

        public int getY()
        {
            return this.cords[1];
        }

        public int GetRadio()
        {
            return this.radio;
        }


    }

    public class Agente
    {
        static Bitmap EvilSprite = new Bitmap(Image.FromFile(@"C:\Users\Usuario\Documents\Programas C#\Actividades Anaya\Actividad2\Actividad2\imgs\AgentesEvil.png"), new Size(40, 40));
        static Bitmap sprite = new Bitmap(Image.FromFile(@"C:\Users\Usuario\Documents\Programas C#\Actividades Anaya\Actividad2\Actividad2\imgs\Agentes.png"),new Size(40,40));
        static public Bitmap mapa, mapa_limpio;
        static public PictureBox Box;
        static Dictionary<string, Point> posiciones = new Dictionary<string, Point>();
        static HashSet<Agente> evilAgents = new HashSet<Agente>();
        static HashSet<Agente> goodAgents = new HashSet<Agente>();

        static public HashSet<Agente> GoodAgentes
        {
            get { return Agente.goodAgents;  }
        }

        List<Arista> Historial = new List<Arista>();
        Arista aristaActiva;
        List<vertice> Visitados = new List<vertice>();
        vertice Estacion;
        Point Ubicacion;
        Bitmap SelfSprite;
        string name;
        bool isEvil,
             isAlive;
        double? distancia = null;

        public Agente( vertice estacion, bool isEvil=false )
        {
            this.Estacion = estacion;
            Visitados.Add(estacion);
            this.Ubicacion = estacion.GetPoint();
            this.name = estacion.getName();
            Agente.posiciones.Add(estacion.getName(), new Point(this.Ubicacion.X,this.Ubicacion.Y));
            this.isEvil = isEvil;
            if (isEvil)
            {
                Agente.evilAgents.Add(this);
            }
            else
            {
                this.isAlive = true;
                Agente.goodAgents.Add(this);
            }
            this.SelfSprite = this.DrawSelf(); 
            this.Nacer();
        }

        #region <Actividad 3>

        public double? Distancia
        {
            get { return distancia; }
        }

        public int visitados
        {
            get
            {
                return Visitados.Count;
            }
        }

        public List<vertice> GetVisitados()
        {
            return this.Visitados;
        }

        public override string ToString()
        {
            return $"Agente {this.name}";
        }

        public List<Arista> GetHistorial()
        {
            return this.Historial;
        }

        private Bitmap DrawSelf()
        {
            Bitmap self = (!isEvil) ? (Bitmap)Agente.sprite.Clone() : (Bitmap)Agente.EvilSprite.Clone();
            Graphics graphics = Graphics.FromImage(self);
            graphics.DrawString(this.name, new Font("Arial", 20), new SolidBrush(Color.FromArgb(255, 200, 40, 40)), 5, 5);
            return self;
        }

        private void Nacer()
        {
            Graphics graphics = Graphics.FromImage(mapa);
            graphics.DrawImage(this.SelfSprite, (Ubicacion.X - 20), (Ubicacion.Y - 20));
        }

        public void chose_one()
        {
            this.name += "(Ruta mas eficiente)";
        }

        public void Elegir_Camino()
        {
            Dictionary<vertice, Arista> opciones = new Dictionary<vertice, Arista>(this.Estacion.GetVecinos());// 2 operaciones elementales
            if (opciones.Count == 0 || opciones.Values.All((op) => this.Historial.Contains(op)))
            {
                Thread.CurrentThread.Abort();
                return;
            }
            vertice origen = Estacion;// una operacion elemental
            do
            {
                int eleccion = new Random().Next(opciones.Count);//2 operaciones elementales
                this.Estacion = opciones.Keys.ToList<vertice>()[eleccion];// 2 operaciones elementales
                opciones.Remove(Estacion);// una operacion elemental
            } while (Historial.Contains(origen.GetVecinos()[Estacion]));
            if (!Visitados.Contains(Estacion))// una operacion elemental
            {
                Visitados.Add(Estacion);// una operacion elemental
            }
            Recorrer(origen.GetVecinos()[Estacion]);//1 operacion elemtal (la llamada a la funcion, no la funcion en si)
        }

        private void Recorrer(Arista Camino, bool recurs = true, bool agreg = true)
        {
            if (agreg)
            {
                this.Historial.Add(Camino);
            }
            List<int[]> pasos = Camino.GetPoints();
            if (Ubicacion == new Point(pasos[0][0], pasos[0][1]))
            {
                for (int h = 0; h < (pasos.Count - 11); h += 10)
                {
                    Dar_Paso(pasos[h]);
                }
                Dar_Paso(Estacion.GetPos());
            }
            else if (Ubicacion == new Point(pasos[(pasos.Count - 1)][0], pasos[(pasos.Count - 1)][1]))
            {
                for (int h = (pasos.Count - 1); h >= 20; h -= 10)
                {
                    Dar_Paso(pasos[h]);
                }
                Dar_Paso(Estacion.GetPos());
            }
            else
            {
                MessageBox.Show("Yo no deberia aparecer... que extraño 0.o");
            }
            if (recurs)
            {
                Elegir_Camino();
            }

        }

        private void Dar_Paso(int[] pos)
        {
            Ubicacion = new Point(pos[0], pos[1]);
            Thread.Sleep(20);
        }

        public void calc_recorrido()
        {
            if ((distancia == null))
            {
                double r = 0;
                foreach (Arista a in Historial)
                {
                    r += a.GetDist();
                }
                this.distancia = r;
            }
        }

        #endregion </Actividad 3>

        #region <Actividad 4 Recorrer todo>

        public delegate void Finish();

        public event Finish dieEvent;

        public void Cover_All(object datos)
        {
            HashSet<vertice> arm_set = (HashSet<vertice>)datos;
            Stack<Arista> Recorrido = new Stack<Arista>();
            Stack<vertice> check_points = new Stack<vertice>();
            if(this.Estacion.GetVecinos().Values.ToList().Count > 1)
            {
                check_points.Push(this.Estacion);
            }
            List<Arista> opciones;
            Arista elegida;
            int Nuevas_Visitas = 1;
            while (Nuevas_Visitas < arm_set.Count)
            {
                opciones = this.Estacion.GetVecinos().Values.ToList();
                if (opciones.Count == 1)
                {
                    if (!this.Historial.Contains(opciones[0]))
                    {
                        Recorrido.Push(opciones[0]);
                        this.Estacion = (opciones[0].B != this.Estacion) ? opciones[0].B : opciones[0].A;
                        this.Recorrer(Recorrido.Peek(),false);
                        Nuevas_Visitas++;
                    }
                    else if(check_points.Count > 0)
                    {
                        this.Regresar(Recorrido, check_points);
                    }
                    else
                    {
                        break;
                    }
                }
                else if (opciones.Count == 2)
                {
                    if(Recorrido.Count > 0)
                    {
                        elegida = (Recorrido.Peek() != opciones[0]) ? opciones[0] : opciones[1];
                        Recorrido.Push(elegida);
                        this.Estacion = (elegida.B != this.Estacion) ? elegida.B : elegida.A;
                        this.Recorrer(elegida, false);
                        Nuevas_Visitas++;
                    }
                    else
                    {
                        elegida = (this.Historial.Contains(opciones[0])) ? opciones[1] : opciones[0];
                        Recorrido.Push(elegida);
                        check_points.Push(this.Estacion);
                        this.Estacion = (elegida.B != this.Estacion) ? elegida.B : elegida.A;
                        this.Recorrer(elegida, false);
                        Nuevas_Visitas++;
                    }
                }
                else if(opciones.Count > 2)
                {
                    int h = 0;
                    do
                    {
                        if (h >= opciones.Count)
                        {
                            if(check_points.Count > 0)
                            {
                                this.Regresar(Recorrido, check_points);
                                elegida = null;
                                break;
                            }
                        }
                        elegida = opciones[h++];
                    }
                    while (Historial.Contains(elegida));

                    if(elegida == null)
                    {
                        continue;
                    }

                    check_points.Push(this.Estacion);
                    Recorrido.Push(elegida);
                    this.Estacion = (elegida.B != this.Estacion) ? elegida.B : elegida.A;
                    this.Recorrer(elegida, false);
                    Nuevas_Visitas++;
                }

            }
            dieEvent();
            Thread.CurrentThread.Abort();
            return;
        }

        private void Regresar(Stack<Arista> Recorrido,Stack<vertice> check_points)
        {
            Arista elegida;
            /*
             * Aqui regresamos hacia un punto de desicion
             */
            do
            {
                elegida = Recorrido.Pop();
                this.Estacion = (elegida.B != this.Estacion) ? elegida.B : elegida.A;
                this.Recorrer(elegida, false,false);
            } while (this.Estacion != check_points.Peek());
            check_points.Pop();
            return;
        }

        #endregion </Actividad 4 Recorrer todo>

        #region <Actividad 5 Dijkstra>

        public void Dijkstra(object datos)
        {
            vertice destino = (vertice)datos,
                    verticieActual;
            /*
             * El formato de las etiquetas sera vertice:[a donde lleva,peso,prosedencia]
             */
            if (destino == Estacion)
            {
                Die();
            }
            Dictionary<vertice, ArrayList> Etiquetas = new Dictionary<vertice, ArrayList>();
            /*
             * Etiquetas es donde se guadaran los datos de todos los vertices
             */
            ArrayList Etiqueta;
            Pqueue<ArrayList> opciones = new Pqueue<ArrayList>();// Aqui solo guardare las opciones actuales 
            verticieActual = Estacion;
            Etiqueta = hacerEtiqueta(verticieActual, 0, null);
            Etiquetas.Add(verticieActual,Etiqueta);
            opciones.Enqueue(Etiqueta,0);
            while (Etiqueta[0] != destino && opciones.Count > 0)
            {
                Etiqueta = opciones.Dequeue().Data;
                verticieActual = (vertice)Etiqueta[0];
                this.enqueueVecionos(verticieActual, opciones, (double)Etiqueta[1],Etiquetas);

            }
            if (Etiqueta[0] != destino && opciones.Count <= 0)
            {
                this.Die();
            }
            opciones.Clear();
            opciones.Enqueue(Etiqueta, (double)Etiqueta[1]);
            while (true)
            {
                Etiqueta = Etiquetas[(vertice)Etiqueta[2]];
                if (Etiqueta[2] != null)
                {
                    opciones.Enqueue(Etiqueta, (double)Etiqueta[1]);
                }
                else
                {
                    break;
                }
            }
            this.recorrerDijkstra(opciones);
            this.Die();

        }

        private void recorrerDijkstra(Pqueue<ArrayList> Camino)
        {
            vertice destino;
            Arista Elegida;
            ArrayList etiqueta;

            while(Camino.Count > 0)
            {
                etiqueta = Camino.Dequeue().Data;
                destino = (vertice)etiqueta[0];
                Elegida = this.Estacion.GetVecinos()[destino];
                try
                {
                    while (!Agente.evilAgents.All((agente => { return this.isSafe(agente, destino, Elegida); })))
                    {
                        //MessageBox.Show("Es peligroso!!!!!!!");
                        Thread.Sleep(300);
                    }
                }
                catch (InvalidOperationException)
                {

                    Thread.Sleep(300);
                }
                this.Estacion = destino;
                this.Recorrer(Elegida, false);
            }
        }

        private void RecorrerconMaldad(Arista Camino,Agente prey, bool agreg = true)
        {
            if (agreg)
            {
                this.Historial.Add(Camino);
            }
            this.aristaActiva = Camino;
            List<int[]> pasos = Camino.GetPoints();
            if (Ubicacion == new Point(pasos[0][0], pasos[0][1]))
            {
                for (int h = 0; h < (pasos.Count - 11); h += 10)
                {
                    Dar_Paso(pasos[h]);
                    SearchNdDestroy(prey, pasos, h);
                }
                Dar_Paso(Estacion.GetPos());
            }
            else if (Ubicacion == new Point(pasos[(pasos.Count - 1)][0], pasos[(pasos.Count - 1)][1]))
            {
                for (int h = (pasos.Count - 1); h >= 20; h -= 10)
                {
                    Dar_Paso(pasos[h]);
                    SearchNdDestroy(prey, pasos, h, false);
                }
                Dar_Paso(Estacion.GetPos());
            }
            else
            {
                MessageBox.Show("Yo no deberia aparecer... que extraño 0.o");
            }


        }

        private void SearchNdDestroy(Agente prey,List<int[]> pasos,int h, bool aumento=true)
        {
            while(h < 20 || h == (pasos.Count - 1))
            {
                if ((prey.Ubicacion.X == pasos[h][0]) && prey.Ubicacion.Y == pasos[h][1])
                {
                    if (!vertice.isAny(pasos[h][0],pasos[h][1]))
                    {
                        MessageBox.Show("Jon snow has died T_T");
                        Killagente();
                    }
                }
                h = (aumento) ? (h + 1) : (h - 1);
            }
        }

        private bool isSafe(Agente agente, vertice destino, Arista Ruta)
        {
            if ((agente.Estacion == destino) && agente.isEvil)
            {
                return false;
            }
            else if (agente.Estacion == this.Estacion && agente.aristaActiva == Ruta)
            {
                return false;
            }
            return true;
        }

        private void enqueueVecionos(vertice v,Pqueue<ArrayList> cola,double acumulado, Dictionary<vertice, ArrayList> Etiquetas)
        {
            Dictionary<vertice, Arista> Vecinos = v.GetVecinos();
            ArrayList Etiqueta;
            foreach(vertice vecino in Vecinos.Keys)
            {
                Etiqueta = hacerEtiqueta(vecino, (Vecinos[vecino].GetDist() + acumulado), v);
                if (Etiquetas.ContainsKey(vecino))
                {
                    if ((double)Etiquetas[vecino][1] > (double)Etiqueta[1])
                    {
                        Etiquetas[vecino][1] = Etiqueta[1];
                        Etiquetas[vecino][2] = Etiqueta[2];
                    }
                }
                else
                {
                    cola.Enqueue(Etiqueta, (double)Etiqueta[1]);
                    Etiquetas[vecino] = Etiqueta;
                }
            }
        }

        private ArrayList hacerEtiqueta(vertice v,double peso,vertice prosedencia)
        {
            ArrayList etiqueta = new ArrayList();
            etiqueta.Add(v);
            etiqueta.Add(peso);
            etiqueta.Add(prosedencia);
            return etiqueta;
        }

        private void Die()
        {
            if (!this.isEvil)
            {
                STDselector nextselector = new STDselector($"PRESA {this.name}", vertice.Count);
                if (nextselector.ShowDialog() == DialogResult.OK)
                {
                    this.Dijkstra(vertice.getVex(nextselector.Valor));
                    return;
                }
                this.isAlive = false;
            }
            dieEvent();
            Thread.CurrentThread.Abort();
        }

        public void DFS(object datos)
        {
            List<Agente> preys = (List<Agente>)datos;
            vertice vengoDe = this.Estacion;
            Agente prey = preys[1];
            vengoDe.Visit();
            Dictionary<vertice, Arista> vecinos = vengoDe.GetVecinos();
            while (!preys.All(p => { return !p.isAlive; }))
            {
                foreach (vertice v in vecinos.Keys)
                {
                    if (!Visitados.Contains(v))
                    {
                        vengoDe = this.Estacion;
                        this.Estacion = v;
                        this.RecorrerconMaldad(vecinos[this.Estacion],prey);
                        this.Visitados.Add(v);
                        this.DFS(v,prey);
                        this.Estacion = vengoDe;
                        this.RecorrerconMaldad(vecinos[v],prey);
                    }
                }
                this.Visitados.Clear();
            }
            //this.Die();
        }

        public void DFS(vertice vengoDe,Agente prey)
        {

            vengoDe.Visit();
            Dictionary<vertice, Arista> vecinos = vengoDe.GetVecinos();
            foreach (vertice v in vecinos.Keys)
            {
                if (!Visitados.Contains(v))
                {
                    vengoDe = this.Estacion;
                    this.Estacion = v;
                    this.RecorrerconMaldad(vecinos[this.Estacion],prey);
                    this.Visitados.Add(v);
                    this.DFS(v,prey);
                    this.Estacion = vengoDe;
                    this.RecorrerconMaldad(vecinos[v],prey, false);
                }
            }
        }

        public delegate void KillAgent();

        public event KillAgent Killagente;


        #endregion </Actividad 5 Dijkstra>

        #region <Proyecto>

        public bool IsAlive
        {
            get
            {
                if (!this.isEvil)
                {
                    return isAlive;
                }
                return false;
            }
        }

        #endregion </Proyecto>

        #region <metodos para update>

        static private void Del_Step(Point ubicacion)
        {
            for (int y = 0; y < 40; y++)
            {
                for (int x = 0; x < 40; x++)
                {
                    Color color = Agente.mapa_limpio.GetPixel((ubicacion.X - 20) + x, (ubicacion.Y - 20) + y);
                    Agente.mapa.SetPixel((ubicacion.X - 20) + x, (ubicacion.Y - 20) + y, color);                }
            }
        }

        static public void Update_Box(List<Agente> agentes, System.Timers.Timer timer)
        {
            foreach(Agente agent in agentes)
            {
                try
                {
                    Agente.Del_Step(posiciones[agent.name]);
                }
                catch (InvalidOperationException)
                {
                    Thread.Sleep(10);
                    Agente.Del_Step(posiciones[agent.name]);
                }
                posiciones[agent.name] = agent.Ubicacion;
                agent.Nacer();
            }
            Agente.Box.Invoke(new Action(() => Agente.Box.Image = (Bitmap)Agente.mapa));
            timer.Enabled = true;
        }

        static public void Reset()
        {
            mapa = null;
            mapa_limpio = null;
            Box = null;
            posiciones = new Dictionary<string, Point>();
            evilAgents.Clear();

        }

        #endregion
    }
}
