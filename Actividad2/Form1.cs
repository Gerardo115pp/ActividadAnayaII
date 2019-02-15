using System;
using System.Collections.Generic;
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
            this.PictureDivide.Image.Save(this.SaveTextBox.Text);
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
                    }
                }
            }
            PictureDivide.Image = bitmap;
            PictureBrute.Image = (Bitmap)bitmap.Clone();
        }

        #endregion </Centroides>

        #region <Fuerza Bruta>


        private void Unir(Bitmap bitmap)
        {
            foreach(vertice v in this.Circs)
            {
                foreach(vertice other in this.Circs)
                {
                    if (v != other)
                    {
                        v.Bresenham_Line(bitmap, other);
                    }
                        
                }
            }
            foreach(vertice v in this.Circs)
            {
                v.PaintLines(bitmap, Color.LimeGreen);
            }
            this.Original = (Bitmap)this.PictureBrute.Image.Clone();
            this.PictureDivide.Image = (Bitmap)this.Original.Clone();
            this.AddCrosses(bitmap);


        }


        #endregion </Fuerza Bruta>

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


    internal class vertice
    {
        int[] cords;
        int radio;
        string name;
        bool visited;
        List<vertice> vecinos;
        List<List<int[]>> aristas;

        public vertice(string name,int x, int y,int radio)
        {
            this.cords = new int[] { x, y };
            this.name = name;
            this.visited = false;
            vecinos = new List<vertice>();
            aristas = new List<List<int[]>>();
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

        public List<vertice> GetVecinos()
        {
            return this.vecinos;
        }

        public bool iSelf(int x, int y)
        {

            if (((Math.Pow((this.cords[0] - x), 2) + (Math.Pow((this.cords[1] - y), 2))) - Math.Pow(this.GetRadio() + 5, 2)) <= 0)
            {
                return true;
            }
            return false;
        }

        public void Bresenham_Line(Bitmap bitmap, vertice other)
        {

            if (this.vecinos.Any(x => x == other))
            {
                  return;
            }
            Color color = Color.FromArgb(148, 9, 200);
            List<int[]> Arista = new List<int[]>();
            int x0 = cords[0], y0 = cords[1], x1 = other.getX(), y1 = other.getY();
            float dx, dy, m;
            int kx = 0, ky = 0;
            float d1, d2, d3;

            dx = x1 - x0;
            dy = y1 - y0;

            if(dx == 0)
            {
                if(dy > 0)
                {
                    for(int k = y0; k <= y1; k++)
                    {
                        if((new ColorRGB(bitmap.GetPixel(x0, k)).Get_RGB() != "255,255,255") && !this.iSelf(x0,k) && !other.iSelf(x0,k))
                        {
                            return;
                        }
                        Arista.Add(new int[] { x0, k });
                    }
                }
            }
            if (dy == 0)
            {
                if(dx > 0)
                {
                    for (int k = x0; k <= x1; k++)
                    {
                        if (new ColorRGB(bitmap.GetPixel(k, y0)).Get_RGB() != "255,255,255" && !this.iSelf(k, y0) && !other.iSelf(k, y0))
                        {
                            return;
                        }
                        Arista.Add(new int[]{k, y0});
                    }
                }
            }
            if (dx < 0 && dy < 0 || dx > 0 && dy < 0)
            {
                float inx = x0, iny = y0;
                x0 = x1;
                x1 = (int)inx;

                y0 = y1;
                y1 = (int)iny;
            }
            if(Math.Abs(dx) > Math.Abs(dy))
            {
                m = dy / dx;

                if(m > 0)
                {
                    for(kx = 1; kx < dx; kx++)
                    {
                        d1 = m * kx - ky;
                        d2 = (ky + 1) - m * kx;
                        d3 = d1 - d2;
                        if(d3 > 0)
                        {
                            ky++;
                        }
                        if (new ColorRGB(bitmap.GetPixel(x0 + kx,y0 + ky)).Get_RGB() != "255,255,255" && !this.iSelf(x0 + kx, y0 + ky) && !other.iSelf(x0 + kx, y0 + ky))
                        {
                            return;
                        }
                        Arista.Add(new int[] {x0 + kx, y0 + ky}); 
                    }
                }
                else
                {
                    for(kx = -1; kx > dx; kx--)
                    {
                        d1 = m * kx - ky;
                        d2 = (ky + 1) - m * kx;
                        d3 = d1 - d2;

                        if(d3 > 0)
                        {

                            ky++;
                        }
                        if (new ColorRGB(bitmap.GetPixel(x0 + kx, y0 + ky)).Get_RGB() != "255,255,255" && !this.iSelf(x0 + kx, y0 + ky) && !other.iSelf(x0 + kx, y0 + ky))
                        {
                            return;
                        }
                        Arista.Add(new int[] { x0 + kx, y0 + ky });
                    }
                }
            }
            else if(Math.Abs(dy) > Math.Abs(dx))
            {
                m = dx / dy;
                
                if (m > 0)
                {
                    for(ky = 1; ky < dy; ky++)
                    {
                        d1 = m * ky - kx;
                        d2 = (kx + 1) - m * ky;
                        d3 = d1 - d2;
                        if (d3 > 0)
                        {
                            kx++;
                        }
                        if (new ColorRGB(bitmap.GetPixel(x0 + kx, y0 + ky)).Get_RGB() != "255,255,255" && !this.iSelf(x0 + kx, y0 + ky) && !other.iSelf(x0 + kx, y0 + ky))
                        {
                            return;
                        }

                        Arista.Add(new int[] { x0 + kx, y0 + ky });
                    }
                }

                if (m < 0)
                {
                    m = Math.Abs(m);
                    for (ky = 1; ky < dy; ky++)
                    {
                        d1 = m * ky - kx;
                        d2 = (kx + 1) - m * ky;
                        d3 = d1 - d2;
                        if(d3 > 0)
                        {
                            kx++;
                        }
                        if (new ColorRGB(bitmap.GetPixel(x0 - kx, y0 + ky)).Get_RGB() != "255,255,255" && !this.iSelf(x0 - kx, y0 + ky) && !other.iSelf(x0 - kx, y0 + ky))
                        {
                            return;
                        }
                        Arista.Add(new int[] { x0 - kx, y0 + ky });
                    }
                }
            }
            this.vecinos.Add(other);
            other.vecinos.Add(this);

            this.aristas.Add(Arista);
            other.aristas.Add(Arista);
        }

        public void PaintLines(Bitmap bitmap,Color color)
        {
      
            foreach (List<int[]> line in this.aristas)
            {
                foreach(int[] vector in line)
                {
                    bitmap.SetPixel(vector[0], vector[1], color);
                }
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
                foreach (vertice v in actual.GetVecinos())
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
            foreach (vertice v in vex.GetVecinos())
            {
                if (!v.IsVisited())
                {
                    this.depth(v);
                }
            }
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
