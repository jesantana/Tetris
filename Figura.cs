using System;
using System.Drawing;

namespace t1
{
	

	public abstract class Figura
	{
		public Punto posicion;
		public int[,] estado;
		protected Color c;
		protected int tipo;
		protected int alto;
		protected int clasif;
		public int ld;
		public int liz;
		protected int CANTMAX;
		public int lineas;

		
		public Figura()
		{
		posicion=new Punto(4,0);
		tipo=1;
		this.TomaEstado();
		}
		
		public Color DColor{
			get{return c;}
		}
	
		public virtual void Rota(){
			this.CambiaTipo();
			this.TomaEstado();		
		}
		
		protected virtual void CambiaTipo(){
		tipo=(tipo+1)%this.CANTMAX;		
		}

		public abstract void TomaEstado();
		public abstract int[,] ProximoEstado();
		public abstract int ProximoLargoD{
		get;
		}
		public abstract int ProximoLargoI{
		get;
		} 
		public abstract int ProximaAltura{
		get;
		}

		public int Alto{
			get{return this.alto;}		
		}	
	
		public int Clasificacion{
			get{return this.clasif;}
		
		}
		public static Color DaColor(int n)
		{
			switch (n)
			{
				case 1:return Color.Aquamarine;
				case 2:return Color.Red;
				case 3:return Color.Purple;
				case 4:return Color.Yellow;
				case 5:return Color.Blue;
				case 6:return Color.LightGreen;
				case 7:return Color.Gray; 
				default:throw new Exception("Error");}
		
		
		}

	
	}
}
