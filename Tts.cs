using System;

namespace t1
{
	
	public class Tts
	{
	public int[][] matriz;
	public Figura act;
	public int prox;
	public NivelYLineas marca;

		public Tts()
		{
		marca=new NivelYLineas();
		act=this.GeneraFigura(new Random().Next(0,6));
		prox=new Random().Next(0,6);
		matriz=new int[20][];
			for(int i=0;i<20;i++)
			
					matriz[i]=new int[10];
			
		}
	
		public bool EsPosibleRotar(){
		if(Tts.NoSeSale(act.posicion,act.ProximoLargoD,act.ProximoLargoI) && (act.posicion.y+act.ProximaAltura)<=19){
			if(!this.ChocaAlRotar(act.posicion,act.ProximoEstado()))
				return true;}
		return false;
		}
		
		public Figura GeneraFigura(int n){
		switch(n){
			case 0:return new Cuadrado();
			case 1:return new PaloLargo();
			case 2:return new LDerecha();
			case 3:return new LIzquierda();
			case 4:return new SDerecha();
			case 5:return new SIzquierda();
			default:throw new Exception("Error creando la pieza");
		}
		}
		
		public bool Juega(){
			if (act.posicion.y+act.Alto==19 || Choca()) {return false;};
			return true;
		
		}
		public bool ChocaAlRotar(Punto p,int[,] a){
		for(int i=0;i<4;i++)
				try
			{
				if(matriz[p.y+a[i,0]][p.x+a[i,1]]!=0)return true;
			}
			catch (IndexOutOfRangeException){return false;}
			return false;
		
		}
		
		
		public bool Choca(){
		for(int i=0;i<4;i++)
			try {if (matriz[act.posicion.y+act.estado[i,0]+1][act.posicion.x+act.estado[i,1]]!=0) return true;}
			catch (IndexOutOfRangeException){return false;}
			return false;}

		
		public bool ChocaporalLado(int n){
			for (int i=0;i<4;i++)
			{
				try{
					if (matriz[act.posicion.y+act.estado[i,0]][act.posicion.x+act.estado[i,1]+n]!=0) return true;
				} 
				catch(IndexOutOfRangeException){return false;}
				
				
				}
				return false;
			}

		public bool Actualiza(){
			for (int i=0;i<4;i++)
			{
				try
				{
					matriz[act.posicion.y+act.estado[i,0]][act.posicion.x+act.estado[i,1]]=act.Clasificacion;
				}			
				catch(IndexOutOfRangeException){return false;}	
			}
		return true;
		}
		
		
		
		public void QuitaFila(int n){
		for (int i=n;i>0;i--)
			matriz[i]=(int[]) matriz[i-1].Clone();
			matriz[0]=new int[10];
		}

		public int DiezEnLinea(int n){
		int i=0;int c=0;
			for(;i<10;i++) try {if (matriz[n][i]!=0) c++;}
						   catch(IndexOutOfRangeException){continue;}
			return c;
		}

		public int DiezEnLinea1(int n){
		
		return DiezEnLinea1(0,0);
		
		}
		
		private int DiezEnLinea1(int n,int pos){
		if (pos==9) {if (matriz[n][pos]!=0) return 1;else return 0;}
		if (matriz[n][pos]!=0) return 1+this.DiezEnLinea1(n,pos+1);
		else return 0+this.DiezEnLinea1(n,pos+1);
		}
		
		public void QuitaLineas(){
		int num;
			for(int i=act.posicion.y+act.Alto;i>=act.posicion.y+act.Alto-4;i--)
			{
				num=this.DiezEnLinea(i);
				if (num==10) {this.QuitaFila(i);i++;marca.AumentaLineas();}							
			}	
		}

		public void NuevaFigura(){
		
        act=this.GeneraFigura(prox);
		prox=new Random().Next(0,6);
	        	
		}
		
		public bool IncrementaPosLat(int movi)
		{
			if (NoSeSale(new Punto(act.posicion.x+movi,act.posicion.y),act.ld,act.liz)) {act.posicion.x+=movi;return true;}
			else return false;
		}
	
		public void BajaFigura()
		{
			act.posicion.y++;
		}

		public static bool NoSeSale(Punto p,int ld,int li)
		{
			return (p.x-li)>=0 && (p.x+ld)<=9;
		}
		
	
	
	}
	}

