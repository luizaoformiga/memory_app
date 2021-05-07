using System.Collections.Generic;
using memory_app.Interfaces;

namespace memory_app.classes
{
    public class SerieRepository : IRepository<Series>
    {
        private List<Series> ListSeries = new List<Series>();
        public void Delete(int id)
        {
            ListSeries[id].ExcludesId();
            // envio de email exemplo
        }

        public void Insert(Series entity)
        {
            ListSeries.Add(entity);
        }

        public List<Series> List()
        {
            return ListSeries;
        }

        public int NextId()
        {
            return ListSeries.Count;
        }

        public Series ReturnForId(int id)
        {
            return ListSeries[id];
        }

        public void Update(int id, Series entity)
        {
            ListSeries[id] = entity;
        }
    }
}