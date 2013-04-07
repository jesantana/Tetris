using System;
using System.Drawing;

namespace t1
{
	
	public class LDerecha:Figura
	{
		public LDerecha()
		{
			this.c=Color.Purple;
			this.clasif=3;
			this.CANTMAX=4;
			
		}
	
		public override void TomaEstado(){
			switch(tipo){
				case 1:this.estado=new int[,]{{0,-1},{0,0},{0,1},{1,1}};this.alto=1;this.ld=this.liz=1;break;
				case 2:this.estado=new int[,]{{-1,1},{-1,0},{0,0},{1,0}};this.alto=1;this.ld=1;this.liz=0;break;
				case 3:this.estado=new int[,]{{-1,-1},{0,-1},{0,0},{0,1}};this.alto=0;this.ld=this.liz=1;break;			
				case 0:this.estado=new int[,]{{-1,0},{0,0},{1,0},{1,-1}};this.alto=1;this.ld=0;this.liz=1;break;			
				default:throw new Exception("Error al tomar estado");
             }
		}
	
		public override int[,] ProximoEstado(){
			switch(tipo){
				case 1:return new int[,]{{-1,0},{0,0},{1,0},{1,-1}};
				case 2:return new int[,]{{0,-1},{0,0},{0,1},{1,1}};//return new int[,]{{-1,-1},{0,-1},{0,0},{0,1}};
				case 3:return new int[,]{{-1,1},{-1,0},{0,0},{1,0}};
				case 0:return new int[,]{{-1,-1},{0,-1},{0,0},{0,1}};
				default:throw new Exception("Error en proxEst");			
			}
		
		}
	
		public override int ProximoLargoD
		{
			get
			{
				switch(tipo)
				{
					case 1:return 0;
					case 2:return 1;
					case 3:return 1;
					case 0:return 1;
					default:throw new Exception("problemas con el proximo largo");
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
					case 2:return 1;
					case 3:return 0;
					case 0:return 1;
					default:throw new Exception("problemas con el proximo largo");
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
					case 2:return 1;
					case 3:return 1;
					case 0:return 0;
					default:throw new Exception("problemas con el proximo largo");
				}
			}
		
		}
	
	
	}

}
