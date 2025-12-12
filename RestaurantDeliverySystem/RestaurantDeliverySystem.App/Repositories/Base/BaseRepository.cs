using System.Collections.Generic;
using System.Linq;

namespace RestaurantDeliverySystem.App.Repositories.Base
{
    public class BaseRepository<T> where T : class
    {
        protected List<T> items = new List<T>();
        protected int nextId = 1;

        // CREATE
        public virtual T Create(T item)
        {
            var prop = item.GetType().GetProperty("Id");
            if (prop != null)
                prop.SetValue(item, nextId++);

            items.Add(item);
            return item;
        }

        // READ ALL
        public virtual List<T> GetAll()
        {
            return items;
        }

        // READ BY ID
        public virtual T GetById(int id)
        {
            return items.FirstOrDefault(i =>
                (int)i.GetType().GetProperty("Id").GetValue(i) == id
            );
        }

        // UPDATE
        public virtual bool Update(T updated)
        {
            var idProp = updated.GetType().GetProperty("Id");
            int id = (int)idProp.GetValue(updated);

            T existing = GetById(id);
            if (existing == null) return false;

            int index = items.IndexOf(existing);
            items[index] = updated;

            return true;
        }

        // DELETE
        public virtual bool Delete(int id)
        {
            T existing = GetById(id);
            if (existing == null) return false;

            items.Remove(existing);
            return true;
        }
    }
}
