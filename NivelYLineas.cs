using System;

namespace t1
{
	
	public class NivelYLineas
	{
		int nivel;
		int lineas;		
		
		public NivelYLineas()
		{
		nivel=1;
		}
	
		
		public void AumentaLineas(){
		nivel=(++lineas)/10+1;		
		}
	
		public int Nivel{
			get{return nivel;}		
		}
		
		public int Lineas{
			get{return lineas;}
		
		}

	}
}
