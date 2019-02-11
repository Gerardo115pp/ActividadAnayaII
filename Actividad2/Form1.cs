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
            List<vertice> ListBrute = new List<vertice>();
            this.Cfind((Bitmap)this.PictureDivide.Image);
            Thread Brute = new Thread(new ParameterizedThreadStart(UnirBrute));
            Thread Divide = new Thread(new ParameterizedThreadStart(UnirBrute));
            //Brute.Start(this.PictureBrute.Image);
            this.Circs[1].Bresenham_Line((Bitmap)this.PictureDivide.Image, Circs[4]);
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


            this.AddCrosses(bitmap);
            PictureDivide.Image = bitmap;
            PictureBrute.Image = (Bitmap)bitmap.Clone();
        }

        #endregion </Centroides>

        #region <Fuerza Bruta>


        private void UnirBrute(object biimap)
        {
            List<vertice> ListBrute = this.Circs.Select( x => x.Clone()).ToList();
            Bitmap bitmap = (Bitmap)biimap;
            Thread.CurrentThread.Abort();

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

    internal class grafo
    {
        int len;
        vertice root;

        public grafo(vertice root = null)
        {
            this.len = 0;
            this.root = root;
        }

        public int Count()
        {
            return this.len;
        }


    }

    internal class vertice
    {
        int[] cords;
        int radio;
        string name;
        bool visited;
        List<vertice> vecinos;

        public vertice(string name,int x, int y,int radio)
        {
            this.cords = new int[] { x, y };
            this.name = name;
            this.visited = false;
            vecinos = new List<vertice>();
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

        public bool Bresenham_Line(Bitmap bitmap, vertice other)
        {
            Color color = Color.FromArgb(149, 9, 200);
            if(cords[0] == other.getX() && cords[1] == other.getY())
            {
                bitmap.SetPixel(cords[0], cords[1], color);
                return true;
            }

            int x0 = cords[0], y0 = cords[1];
            int x1 = other.getX(), y1 = other.getY();

            int dx = x1 - x0;
            int sx = (dx < 0) ? -1 : 1;
            int dy = y1 - y0;
            int sy = (dy < 0) ? -1 : 1; 

            if(Math.Abs(dy) < Math.Abs(dx))
            {
                int m = dy / dx;
                int b = y0 - m * x0;
                int my = dx / dy;
                int by = x0 - m * y0;
                while (x0 != x1 && y0 != y1)
                {
                    bitmap.SetPixel((int)Math.Round(Convert.ToDouble(m * y0 + b)), (int)Math.Round(Convert.ToDouble(m * x0 + b)), color);
                    x0 += sx;
                    if(y0 != y1)
                    {
                        bitmap.SetPixel((int)Math.Round(Convert.ToDouble(m * y0 + b)), (int)Math.Round(Convert.ToDouble(m * x0 + b)), color);
                        y0 += sy;
                    }
                }
            }
            bitmap.SetPixel(x1, y1, color);
            return true;
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
