using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace t1
{
	
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Timer timer1;
		private System.ComponentModel.IContainer components;
		private Tts tetris;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.MenuItem menuItem4;
		private bool arriba;
		private bool paradoporfin;
				
		public Form1()
		{
			
			tetris=new Tts();
			arriba=true;
			InitializeComponent();
			this.Focus();
			
			
		}

	
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Black;
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox1.Location = new System.Drawing.Point(232, 8);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(300, 500);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem2,
																					  this.menuItem4,
																					  this.menuItem3});
			this.menuItem1.Text = "&Archivo";
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.Shortcut = System.Windows.Forms.Shortcut.F2;
			this.menuItem2.Text = "&Nuevo";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 1;
			this.menuItem4.Shortcut = System.Windows.Forms.Shortcut.F3;
			this.menuItem4.Text = "&Pausa";
			this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 2;
			this.menuItem3.Text = "&Salir";
			this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.pictureBox2,
																					this.label6,
																					this.label4,
																					this.label3,
																					this.label1});
			this.groupBox1.Font = new System.Drawing.Font("Lithograph", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.Color.Blue;
			this.groupBox1.Location = new System.Drawing.Point(592, 120);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(120, 256);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Resultado";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(16, 176);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(80, 60);
			this.pictureBox2.TabIndex = 6;
			this.pictureBox2.TabStop = false;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(8, 128);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(56, 16);
			this.label6.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 56);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 16);
			this.label4.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 96);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Lineas";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nivel";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(802, 555);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.groupBox1,
																		  this.pictureBox1});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		
		static void Main() 
		{
			Application.Run(new Form1());
		}

		

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			this.Focus();
			if(arriba==false) 
			{
				tetris.NuevaFigura();
				arriba=true;}	
			pictureBox1.Refresh();
			if (tetris.Juega()) tetris.BajaFigura();
			else 
			{
				arriba=false;
				if(!tetris.Actualiza()) {paradoporfin=true;timer1.Enabled=false; return;}
				tetris.QuitaLineas();
				this.ActualizaEtiquetas();
			}
			
		
		}
	
		
		

		private void PintaTetris(Graphics k)
		{
			bool existe=true;
			SolidBrush b;
			for (int i=19;existe;i--)
			{
				existe=false;
				for(int j=0;j<10;j++)
				{
					try
					{
						if (tetris.matriz[i][j]!=0)
					
						{
							existe=true;
							b=new SolidBrush(Figura.DaColor(tetris.matriz[i][j]));
							k.FillRectangle(b,j*30,i*25,29,24);
						}
						}
					catch(IndexOutOfRangeException){continue;}
			
				}
		
			}
		
		}

		

		private void pictureBox1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			Graphics k=e.Graphics;
			SolidBrush b=new SolidBrush(tetris.act.DColor);
			for(int i=0;i<4;i++)
				k.FillRectangle(b,(tetris.act.posicion.x+tetris.act.estado[i,1])*30,(tetris.act.posicion.y+tetris.act.estado[i,0])*25,29,24);
			this.PintaTetris(k);
		}

		
		private void Form1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar=='w') {if(tetris.EsPosibleRotar()) {tetris.act.Rota();pictureBox1.Refresh();}}
			else if(e.KeyChar=='a') {if (!(tetris.ChocaporalLado(-1)) && tetris.IncrementaPosLat(-1)) pictureBox1.Refresh();}
			else if(e.KeyChar=='d') {if (!(tetris.ChocaporalLado(1)) && tetris.IncrementaPosLat(1)) pictureBox1.Refresh();}
			else if(e.KeyChar=='s') while (tetris.Juega()) {tetris.BajaFigura();
										pictureBox1.Refresh();}
			
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			Environment.Exit(0);
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			paradoporfin=false;
			timer1.Enabled=true;
			tetris=new Tts();
			arriba=true;

		}

		private void ActualizaEtiquetas(){
		int niv=tetris.marca.Nivel;
		label4.Text=niv.ToString();
		label6.Text=tetris.marca.Lineas.ToString();
		timer1.Interval=1000-100*(niv-1);
		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			if(!paradoporfin)
			timer1.Enabled=!timer1.Enabled;
		}	
	}
}