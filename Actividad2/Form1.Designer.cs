
namespace Actividad2
{
    partial class MainWindow
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.MainCloseBTN = new System.Windows.Forms.Button();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.MainMinBTN = new System.Windows.Forms.Button();
            this.MainResizeBTN = new System.Windows.Forms.Button();
            this.PicturePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.DivdeLabel = new System.Windows.Forms.Label();
            this.PictureBrute = new System.Windows.Forms.PictureBox();
            this.PictureDivide = new System.Windows.Forms.PictureBox();
            this.AnalizarBTN = new System.Windows.Forms.Button();
            this.SaveGroupBox = new System.Windows.Forms.GroupBox();
            this.EnumCheckBox = new System.Windows.Forms.CheckBox();
            this.SaveBTN = new System.Windows.Forms.Button();
            this.SaveTextBox = new System.Windows.Forms.TextBox();
            this.CirculosListBox = new System.Windows.Forms.ListBox();
            this.CircLabelContainer = new System.Windows.Forms.Panel();
            this.TitleCirculos = new System.Windows.Forms.Label();
            this.ArbolLbl = new System.Windows.Forms.Label();
            this.UselessStatus = new System.Windows.Forms.StatusStrip();
            this.TooBien = new System.Windows.Forms.ToolStripStatusLabel();
            this.FolderLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.DivideStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.BrutaStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.ControlPanel.SuspendLayout();
            this.PicturePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBrute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureDivide)).BeginInit();
            this.SaveGroupBox.SuspendLayout();
            this.CircLabelContainer.SuspendLayout();
            this.UselessStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainCloseBTN
            // 
            this.MainCloseBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.MainCloseBTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.MainCloseBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(170)))), ((int)(((byte)(7)))));
            this.MainCloseBTN.FlatAppearance.BorderSize = 2;
            this.MainCloseBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(42)))));
            this.MainCloseBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(32)))));
            this.MainCloseBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainCloseBTN.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainCloseBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(143)))), ((int)(((byte)(7)))));
            this.MainCloseBTN.Location = new System.Drawing.Point(1302, 0);
            this.MainCloseBTN.Name = "MainCloseBTN";
            this.MainCloseBTN.Size = new System.Drawing.Size(68, 41);
            this.MainCloseBTN.TabIndex = 0;
            this.MainCloseBTN.Text = "X";
            this.MainCloseBTN.UseVisualStyleBackColor = false;
            this.MainCloseBTN.Click += new System.EventHandler(this.MainCloseBTN_Click);
            // 
            // ControlPanel
            // 
            this.ControlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ControlPanel.Controls.Add(this.Title);
            this.ControlPanel.Controls.Add(this.MainMinBTN);
            this.ControlPanel.Controls.Add(this.MainResizeBTN);
            this.ControlPanel.Controls.Add(this.MainCloseBTN);
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ControlPanel.Location = new System.Drawing.Point(0, 0);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(1370, 41);
            this.ControlPanel.TabIndex = 1;
            this.ControlPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ControlPanel_MouseDown);
            this.ControlPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ControlPanel_MouseMove);
            this.ControlPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ControlPanel_MouseUp);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Title.Font = new System.Drawing.Font("Russian", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(527, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(199, 27);
            this.Title.TabIndex = 3;
            this.Title.Text = "A c t i v i d a d   II";
            // 
            // MainMinBTN
            // 
            this.MainMinBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.MainMinBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainMinBTN.BackgroundImage")));
            this.MainMinBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MainMinBTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.MainMinBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(170)))), ((int)(((byte)(7)))));
            this.MainMinBTN.FlatAppearance.BorderSize = 0;
            this.MainMinBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.MainMinBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.MainMinBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainMinBTN.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMinBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.MainMinBTN.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.MainMinBTN.Location = new System.Drawing.Point(1166, 0);
            this.MainMinBTN.Name = "MainMinBTN";
            this.MainMinBTN.Size = new System.Drawing.Size(68, 41);
            this.MainMinBTN.TabIndex = 2;
            this.MainMinBTN.UseVisualStyleBackColor = false;
            this.MainMinBTN.Click += new System.EventHandler(this.MainMinBTN_Click);
            // 
            // MainResizeBTN
            // 
            this.MainResizeBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.MainResizeBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainResizeBTN.BackgroundImage")));
            this.MainResizeBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MainResizeBTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.MainResizeBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(170)))), ((int)(((byte)(7)))));
            this.MainResizeBTN.FlatAppearance.BorderSize = 0;
            this.MainResizeBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.MainResizeBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.MainResizeBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainResizeBTN.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainResizeBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.MainResizeBTN.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.MainResizeBTN.Location = new System.Drawing.Point(1234, 0);
            this.MainResizeBTN.Name = "MainResizeBTN";
            this.MainResizeBTN.Size = new System.Drawing.Size(68, 41);
            this.MainResizeBTN.TabIndex = 1;
            this.MainResizeBTN.UseVisualStyleBackColor = false;
            this.MainResizeBTN.Click += new System.EventHandler(this.MainResizeBTN_Click);
            // 
            // PicturePanel
            // 
            this.PicturePanel.AutoSize = true;
            this.PicturePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.PicturePanel.Controls.Add(this.label1);
            this.PicturePanel.Controls.Add(this.DivdeLabel);
            this.PicturePanel.Controls.Add(this.PictureBrute);
            this.PicturePanel.Controls.Add(this.PictureDivide);
            this.PicturePanel.Location = new System.Drawing.Point(16, 63);
            this.PicturePanel.Margin = new System.Windows.Forms.Padding(30);
            this.PicturePanel.Name = "PicturePanel";
            this.PicturePanel.Size = new System.Drawing.Size(1072, 629);
            this.PicturePanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label1.Font = new System.Drawing.Font("Russian Dollmaker", 43F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(668, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fuerza Bruta";
            // 
            // DivdeLabel
            // 
            this.DivdeLabel.AutoSize = true;
            this.DivdeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.DivdeLabel.Font = new System.Drawing.Font("Russian Dollmaker", 43F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivdeLabel.Location = new System.Drawing.Point(248, 53);
            this.DivdeLabel.Name = "DivdeLabel";
            this.DivdeLabel.Size = new System.Drawing.Size(107, 41);
            this.DivdeLabel.TabIndex = 2;
            this.DivdeLabel.Text = "Divide";
            // 
            // PictureBrute
            // 
            this.PictureBrute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.PictureBrute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBrute.ImageLocation = "C:\\Users\\Usuario\\Documents\\Programas C#\\Actividades Anaya\\Actividad2\\Actividad2\\b" +
    "in\\Debug\\2-2.png";
            this.PictureBrute.Location = new System.Drawing.Point(535, 0);
            this.PictureBrute.Name = "PictureBrute";
            this.PictureBrute.Size = new System.Drawing.Size(495, 626);
            this.PictureBrute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBrute.TabIndex = 0;
            this.PictureBrute.TabStop = false;
            // 
            // PictureDivide
            // 
            this.PictureDivide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.PictureDivide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureDivide.ImageLocation = "C:\\Users\\Usuario\\Documents\\Programas C#\\Actividades Anaya\\Actividad2\\Actividad2\\b" +
    "in\\Debug\\2-2.png";
            this.PictureDivide.Location = new System.Drawing.Point(39, 0);
            this.PictureDivide.Name = "PictureDivide";
            this.PictureDivide.Size = new System.Drawing.Size(496, 626);
            this.PictureDivide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureDivide.TabIndex = 1;
            this.PictureDivide.TabStop = false;
            this.PictureDivide.Click += new System.EventHandler(this.PictureDivide_Click);
            // 
            // AnalizarBTN
            // 
            this.AnalizarBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(179)))), ((int)(((byte)(8)))));
            this.AnalizarBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnalizarBTN.FlatAppearance.BorderSize = 3;
            this.AnalizarBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnalizarBTN.Font = new System.Drawing.Font("Russian", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnalizarBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.AnalizarBTN.Location = new System.Drawing.Point(1145, 104);
            this.AnalizarBTN.Name = "AnalizarBTN";
            this.AnalizarBTN.Size = new System.Drawing.Size(183, 75);
            this.AnalizarBTN.TabIndex = 3;
            this.AnalizarBTN.Text = "Analizar";
            this.AnalizarBTN.UseVisualStyleBackColor = false;
            this.AnalizarBTN.Click += new System.EventHandler(this.AnalizarBTN_Click);
            // 
            // SaveGroupBox
            // 
            this.SaveGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SaveGroupBox.Controls.Add(this.EnumCheckBox);
            this.SaveGroupBox.Controls.Add(this.SaveBTN);
            this.SaveGroupBox.Controls.Add(this.SaveTextBox);
            this.SaveGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveGroupBox.Font = new System.Drawing.Font("Russian Land", 22.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(179)))), ((int)(((byte)(8)))));
            this.SaveGroupBox.Location = new System.Drawing.Point(1138, 223);
            this.SaveGroupBox.Name = "SaveGroupBox";
            this.SaveGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SaveGroupBox.Size = new System.Drawing.Size(200, 154);
            this.SaveGroupBox.TabIndex = 4;
            this.SaveGroupBox.TabStop = false;
            this.SaveGroupBox.Text = "Guardar";
            // 
            // EnumCheckBox
            // 
            this.EnumCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.EnumCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EnumCheckBox.FlatAppearance.BorderSize = 2;
            this.EnumCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.EnumCheckBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(110)))), ((int)(((byte)(45)))));
            this.EnumCheckBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(35)))));
            this.EnumCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnumCheckBox.Font = new System.Drawing.Font("Russian Land", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnumCheckBox.Location = new System.Drawing.Point(147, 49);
            this.EnumCheckBox.Name = "EnumCheckBox";
            this.EnumCheckBox.Size = new System.Drawing.Size(47, 23);
            this.EnumCheckBox.TabIndex = 2;
            this.EnumCheckBox.Text = "Enum";
            this.EnumCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EnumCheckBox.UseVisualStyleBackColor = true;
            // 
            // SaveBTN
            // 
            this.SaveBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveBTN.BackgroundImage")));
            this.SaveBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SaveBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SaveBTN.FlatAppearance.BorderSize = 2;
            this.SaveBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBTN.Location = new System.Drawing.Point(78, 94);
            this.SaveBTN.Name = "SaveBTN";
            this.SaveBTN.Size = new System.Drawing.Size(51, 45);
            this.SaveBTN.TabIndex = 1;
            this.SaveBTN.UseVisualStyleBackColor = true;
            this.SaveBTN.Click += new System.EventHandler(this.SaveBTN_Click);
            // 
            // SaveTextBox
            // 
            this.SaveTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.SaveTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SaveTextBox.Font = new System.Drawing.Font("Open Sans", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.SaveTextBox.Location = new System.Drawing.Point(20, 49);
            this.SaveTextBox.MaxLength = 70;
            this.SaveTextBox.Name = "SaveTextBox";
            this.SaveTextBox.Size = new System.Drawing.Size(127, 28);
            this.SaveTextBox.TabIndex = 0;
            this.SaveTextBox.Text = "Test.png";
            this.SaveTextBox.TextChanged += new System.EventHandler(this.SaveTextBox_TextChanged);
            // 
            // CirculosListBox
            // 
            this.CirculosListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.CirculosListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CirculosListBox.ColumnWidth = 2;
            this.CirculosListBox.Font = new System.Drawing.Font("Open Sans", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CirculosListBox.ForeColor = System.Drawing.Color.LawnGreen;
            this.CirculosListBox.FormattingEnabled = true;
            this.CirculosListBox.HorizontalScrollbar = true;
            this.CirculosListBox.ItemHeight = 22;
            this.CirculosListBox.Location = new System.Drawing.Point(1138, 545);
            this.CirculosListBox.Name = "CirculosListBox";
            this.CirculosListBox.Size = new System.Drawing.Size(200, 132);
            this.CirculosListBox.TabIndex = 5;
            // 
            // CircLabelContainer
            // 
            this.CircLabelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.CircLabelContainer.Controls.Add(this.TitleCirculos);
            this.CircLabelContainer.Location = new System.Drawing.Point(1138, 516);
            this.CircLabelContainer.Name = "CircLabelContainer";
            this.CircLabelContainer.Size = new System.Drawing.Size(200, 28);
            this.CircLabelContainer.TabIndex = 6;
            // 
            // TitleCirculos
            // 
            this.TitleCirculos.AutoSize = true;
            this.TitleCirculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TitleCirculos.Font = new System.Drawing.Font("Russian Dollmaker", 22.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleCirculos.Location = new System.Drawing.Point(60, 4);
            this.TitleCirculos.Name = "TitleCirculos";
            this.TitleCirculos.Size = new System.Drawing.Size(76, 21);
            this.TitleCirculos.TabIndex = 0;
            this.TitleCirculos.Text = "Circulos";
            // 
            // ArbolLbl
            // 
            this.ArbolLbl.AutoSize = true;
            this.ArbolLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ArbolLbl.Font = new System.Drawing.Font("Russian", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArbolLbl.Location = new System.Drawing.Point(1161, 423);
            this.ArbolLbl.Name = "ArbolLbl";
            this.ArbolLbl.Size = new System.Drawing.Size(159, 40);
            this.ArbolLbl.TabIndex = 7;
            this.ArbolLbl.Text = "Ver Arbol";
            this.ArbolLbl.Click += new System.EventHandler(this.ArbolLbl_Click);
            this.ArbolLbl.MouseEnter += new System.EventHandler(this.ArbolLbl_MouseEnter);
            this.ArbolLbl.MouseLeave += new System.EventHandler(this.ArbolLbl_MouseLeave);
            // 
            // UselessStatus
            // 
            this.UselessStatus.AutoSize = false;
            this.UselessStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.UselessStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TooBien,
            this.FolderLabel,
            this.DivideStatus,
            this.BrutaStatus});
            this.UselessStatus.Location = new System.Drawing.Point(0, 705);
            this.UselessStatus.Name = "UselessStatus";
            this.UselessStatus.Size = new System.Drawing.Size(1370, 35);
            this.UselessStatus.TabIndex = 8;
            this.UselessStatus.Text = "statusStrip1";
            // 
            // TooBien
            // 
            this.TooBien.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.TooBien.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TooBien.Name = "TooBien";
            this.TooBien.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.TooBien.Size = new System.Drawing.Size(263, 30);
            this.TooBien.Text = "Todo Bien, Todo Correcto y yo que me alegro!";
            // 
            // FolderLabel
            // 
            this.FolderLabel.Name = "FolderLabel";
            this.FolderLabel.Size = new System.Drawing.Size(95, 30);
            this.FolderLabel.Text = "Cambiar Imagen";
            this.FolderLabel.Click += new System.EventHandler(this.FolderLabel_Click);
            this.FolderLabel.MouseEnter += new System.EventHandler(this.FolderLabel_MouseEnter);
            this.FolderLabel.MouseLeave += new System.EventHandler(this.FolderLabel_MouseLeave);
            // 
            // DivideStatus
            // 
            this.DivideStatus.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.DivideStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DivideStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivideStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DivideStatus.Name = "DivideStatus";
            this.DivideStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DivideStatus.Size = new System.Drawing.Size(131, 30);
            this.DivideStatus.Text = "Divide y venceras";
            this.DivideStatus.ToolTipText = "Status de la imagen";
            // 
            // BrutaStatus
            // 
            this.BrutaStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BrutaStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrutaStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BrutaStatus.Name = "BrutaStatus";
            this.BrutaStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BrutaStatus.Size = new System.Drawing.Size(93, 30);
            this.BrutaStatus.Text = "Fuerza Bruta";
            this.BrutaStatus.ToolTipText = "Status de la imagen";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1370, 740);
            this.Controls.Add(this.UselessStatus);
            this.Controls.Add(this.ArbolLbl);
            this.Controls.Add(this.CircLabelContainer);
            this.Controls.Add(this.CirculosListBox);
            this.Controls.Add(this.SaveGroupBox);
            this.Controls.Add(this.AnalizarBTN);
            this.Controls.Add(this.PicturePanel);
            this.Controls.Add(this.ControlPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(219)))), ((int)(((byte)(8)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ControlPanel.ResumeLayout(false);
            this.ControlPanel.PerformLayout();
            this.PicturePanel.ResumeLayout(false);
            this.PicturePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBrute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureDivide)).EndInit();
            this.SaveGroupBox.ResumeLayout(false);
            this.SaveGroupBox.PerformLayout();
            this.CircLabelContainer.ResumeLayout(false);
            this.CircLabelContainer.PerformLayout();
            this.UselessStatus.ResumeLayout(false);
            this.UselessStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainCloseBTN;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Button MainResizeBTN;
        private System.Windows.Forms.Button MainMinBTN;
        private System.Windows.Forms.Panel PicturePanel;
        private System.Windows.Forms.PictureBox PictureDivide;
        private System.Windows.Forms.PictureBox PictureBrute;
        private System.Windows.Forms.Button AnalizarBTN;
        private System.Windows.Forms.GroupBox SaveGroupBox;
        private System.Windows.Forms.TextBox SaveTextBox;
        private System.Windows.Forms.Button SaveBTN;
        private System.Windows.Forms.ListBox CirculosListBox;
        private System.Windows.Forms.Panel CircLabelContainer;
        private System.Windows.Forms.Label TitleCirculos;
        private System.Windows.Forms.Label ArbolLbl;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.StatusStrip UselessStatus;
        private System.Windows.Forms.ToolStripStatusLabel TooBien;
        private System.Windows.Forms.ToolStripStatusLabel FolderLabel;
        private System.Windows.Forms.Label DivdeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripStatusLabel DivideStatus;
        private System.Windows.Forms.ToolStripStatusLabel BrutaStatus;
        private System.Windows.Forms.CheckBox EnumCheckBox;
    }
}

