using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;

namespace t1
{
	
	public class Lista
	{
		Ganador[] g;
		
		public Lista()
		{
			
		}
		public void CargaLista(){
		FileStream s=new FileStream("HighScores.tet",FileMode.Open);
		BinaryFormatter b=new BinaryFormatter();
		g=(Ganador[]) b.Deserialize(s);
        s.Close();
		}
	
		public void EscribeLista(){
			FileStream s=new FileStream("HighScores.tet",FileMode.Create);
			BinaryFormatter b=new BinaryFormatter();
			b.Serialize(s,g);
			s.Close();
		
		}
	
	}
}
