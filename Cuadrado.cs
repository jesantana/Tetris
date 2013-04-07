using System;
using System.Drawing;

namespace t1
{
	
	public class Cuadrado:Figura
	{
		public Cuadrado()
		{
			this.c=Color.Aquamarine;
			this.alto=0;
			this.ld=1;
			this.liz=0;
			this.clasif=1;
			this.CANTMAX=1;
		}
	
		protected override void CambiaTipo(){;}
		public override void TomaEstado()
		{
			this.estado=new int[,]{{0,0},{-1,0},{-1,1},{0,1}};}
	
		public override int ProximoLargoD
		{
			get
			{
				return 1;
			}	
		}

		public override int[,] ProximoEstado(){
		return new int[,]{{0,0},{-1,0},{-1,1},{0,1}};
		
		}
		
		public override int ProximoLargoI
		{
			get
			{
				return 0;
			}
		}	
		
		
		public override int ProximaAltura
		{
			get
			{
				return 0;
			}
		
		}
	
	
	
	
	
	}
	
	
}


