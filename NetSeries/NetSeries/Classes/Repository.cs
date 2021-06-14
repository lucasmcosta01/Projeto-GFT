using System;
using System.Collections.Generic;

namespace NetSeries
{
    public class Repository : IRepository<Series>
	{
        public List<Series> listSerie = new List<Series>();

		public void Update(int id, Series objeto)
		{
			listSerie[id] = objeto;
		}

		public void Delete(int id)
		{
			listSerie[id].Deleted();
		}

		public void Insert(Series objeto)
		{
			listSerie.Add(objeto);
		}

		public List<Series> Lista()
		{
			return listSerie;
		}

		public int NextId()
		{
			return listSerie.Count;
		}

		public Series ReturnId(int id)
		{
			return listSerie[id];
		}



	}
}
