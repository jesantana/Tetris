using System;
using System.Drawing;

namespace t1
{
	public class SDerecha:Figura
	{
		public SDerecha()
		{
			this.c=Color.Blue;
			this.clasif=5;
			this.CANTMAX=2;
		}
		public override void TomaEstado()
		{
		
			switch(tipo)
			{
				case 1:this.estado=new int[,]{{-1,1},{-1,0},{0,0},{0,-1}};this.ld=1;this.liz=1;this.alto=0;break;
				case 0:this.estado=new int[,]{{-1,-1},{0,-1},{0,0},{1,0}};this.ld=0;this.liz=1;this.alto=1;break;
				default:throw new Exception("Error en toma estado");							
			
			}		
		}
		public override int[,] ProximoEstado()
		{
			switch(tipo)
			{
				case 1:return new int[,]{{-1,-1},{0,-1},{0,0},{1,0}};
				case 0:return new int[,]{{-1,1},{-1,0},{0,0},{0,-1}};
				default:throw new Exception("Error en toma estado");							
			}
		}
		public override int ProximoLargoD
		{
			get
			{
				switch(tipo)
				{
					case 1:return 0;
					case 0:return 1;
					default:throw new Exception("error en proximo largo");
				}		
			}
		}	
		public override int ProximoLargoI
		{
			get
			{
				switch(tipo)
				{
					case 1:return 1;
					case 0:return 1;
					default:throw new Exception("error en proximo largo");
				}		
			}
		}	
	
		public override int ProximaAltura
		{
			get
			{
				switch(tipo)
				{
					case 1:return 1;
					case 0:return 0;
					default:throw new Exception("error en proximo largo");
				}		
			}
		}	
	
	}
}

