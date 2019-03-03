using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Actividad2
{
    public partial class MainWindow : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private List<vertice> Circs;
        private Bitmap Original;


        public MainWindow()
        {
            InitializeComponent();
            this.Circs = new List<vertice>();
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
            this.Cfind((Bitmap)this.PictureDivide.Image);
            this.Unir((Bitmap)this.PictureBrute.Image);
            this.BrutaStatus.ForeColor = Color.Green;
            this.DivideStatus.ForeColor = Color.Green;






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
                this.PictureDivide.Image = new Bitmap(fileDialog.FileName);
                this.PictureBrute.Image = (Bitmap)this.PictureDivide.Image.Clone();
                this.BrutaStatus.ForeColor = Color.Red;
                this.DivideStatus.ForeColor = Color.Red;
                this.Circs.Clear();
                this.CirculosListBox.Items.Clear();
            }
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
            Graphics g = Graphics.FromImage(bitmap);
            foreach (vertice C in this.Circs)
            {
                this.CirculosListBox.Items.Add(C);
                g.DrawString(C.getName(), new Font("Arial", 16), new SolidBrush(Color.Red), C.getX(), C.getY());
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
            ArrayList min = null,
                      actual = new ArrayList(),
                      block_min = null,
                      block_act = new ArrayList();

            bool ok;
            foreach(vertice v in this.Circs)
            {
                foreach(vertice other in this.Circs)
                {
                    if (v != other)
                    {
                        
                        ok = v.Bresenham(bitmap, other);
                        actual = this.get_min(v, other);
                        if (min != null)
                        {
                            min = (Convert.ToInt32(actual[2]) < Convert.ToInt32(min[2])) ? actual : min;
                        }
                        else
                        {
                            min = actual;
                        }
                        if (ok)
                        {
                            block_act = this.get_min(v, other);
                            if(block_min != null)
                            {
                                block_min = (Convert.ToInt32(block_act[2]) < Convert.ToInt32(block_min[2])) ? block_act : block_min;
                            }
                            else
                            {
                                block_min = block_act;
                            }
                        }
                    }                        
                }
            }
            foreach(vertice v in this.Circs)
            {
                v.PaintLines(bitmap, Color.LimeGreen);
            }
            if (min != null)
            {
                Graphics.FromImage(bitmap).DrawLine(new Pen(new SolidBrush(Color.Orange)),((vertice)min[0]).GetPoint(),((vertice)min[1]).GetPoint());
                this.CirculosListBox.Items.Add($"Circulos mas crecanos sin bloqueo: {((vertice)min[0]).getName()} y {((vertice) min[1]).getName()}");

            }
            if (block_min != null)
            {
                Graphics.FromImage(bitmap).DrawLine(new Pen(new SolidBrush(Color.Purple)), ((vertice)block_min[0]).GetPoint(), ((vertice)block_min[1]).GetPoint());
                this.CirculosListBox.Items.Add($"Circulos mas crecanos con bloqueo: {((vertice)block_min[0]).getName()} y {((vertice)block_min[1]).getName()}");
            }

            this.Original = (Bitmap)this.PictureBrute.Image.Clone();
            this.PictureDivide.Image = (Bitmap)this.Original.Clone();
            this.AddCrosses(bitmap);


        }


        #endregion </Fuerza Bruta>

        #endregion </Script>

        private void PictureDivide_Click(object sender, EventArgs e)
        {

        }
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
        List<int[]> points;
        vertice pA, pB;
        string name;
        bool painted;

        public Arista(List<int[]> points,vertice pA,vertice pB)
        {
            this.points = points;
            this.pA = pA;
            this.pB = pB;
            this.name = $"({pA.getName()},{pB.getName()})";
            this.painted = false;
        }

        public override string ToString()
        {
            return this.name;
        }

        public int Len()
        {
            return this.points.Count;
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
    }

    public class vertice
    {
        int[] cords;
        int radio;
        string name;
        bool visited;
        Dictionary<vertice,Arista> aristas;

        public vertice(string name,int x, int y,int radio)
        {
            this.cords = new int[] { x, y };
            this.name = name;
            this.visited = false;
            aristas = new Dictionary<vertice,Arista>();
            this.radio = radio;
        }

        public override string ToString()
        {
            return $"Circulo {this.name}: (x:{cords[0]}, y:{cords[1]}, radio:{this.radio})";
        }

        public vertice Clone()
        {
            return new vertice(this.name, this.cords[0], this.cords[1], this.radio);
        }

        public Dictionary<vertice, Arista> GetVecinos()
        {
            return this.aristas;
        }

        public bool iSelf(int x, int y)
        {
            if (((Math.Pow((this.cords[0] - x), 2) + (Math.Pow((this.cords[1] - y), 2))) - Math.Pow(this.GetRadio() + 5, 2)) <= 0)
            {
                return true;
            }
            return false;
        }

        public bool Bresenham(Bitmap bitmap, vertice other)
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
                ok = BresenhamX(x0, y0, x1, y1, dy, dx,bitmap, arista_points,other);
            }
            else
            {
                ok = BresenhamY(x0, y0, x1, y1, dy, dx, bitmap, arista_points, other);
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

        private bool BresenhamX(int x0, int y0, int x1, int y1, int dy, int dx, Bitmap bitmap, List<int[]> arista, vertice other)
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
                if (new ColorRGB(bitmap.GetPixel(x0, y0)).Get_RGB() != "255,255,255" && !this.iSelf(x0, y0) && !(other.iSelf(x0, y0)))
                {
                    return false;
                }
                arista.Add(new int[] { x0, y0 });
            }
            return true;
        }

        private bool BresenhamY(int x0, int y0, int x1, int y1, int dy, int dx, Bitmap bitmap, List<int[]> arista, vertice other)
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
                if (new ColorRGB(bitmap.GetPixel(x0, y0)).Get_RGB() != "255,255,255" && !this.iSelf(x0, y0) && !(other.iSelf(x0, y0)))
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
                this.aristas[line].SetColors(Color.LimeGreen,bitmap);
            }
        }

        public void breadth(vertice vex = null)
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
                        cola.Enqueue(v);
                    }
                }

            }
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

        public int[] GetPos()
        {
            return new int[] { cords[0], cords[1] };
        }

        public string getName()
        {
            return this.name;
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
}
