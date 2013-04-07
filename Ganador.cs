using System;

namespace t1
{
	[Serializable]
	public class Ganador
	{
		public string nombre;
		public int lineas;
		
		public Ganador(int lin)
		{
			this.lineas=lin;
			HighS h=new HighS();
			h.ShowDialog();
			nombre=h.Nombre;
		}
	
	
	}
}
