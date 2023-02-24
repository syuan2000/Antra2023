using System;

namespace O4Generic
{
	public class GenericRepository<T> : IRepository<Entity>
	{
        private List<Entity> entities = new List<Entity>();

        public void Add(Entity obj)
        {
            if (GetById(obj.Id) == null)
            {
                entities.Add(obj);
            }
        }

        public IEnumerable<Entity> GetAll()
        {
            return entities;
        }

        public Entity GetById(int id)
        {
            for (int i = 0; i < entities.Count; i++)
            {
                if (entities[i].Id == id)
                {
                    return entities[i];
                }
            }
            return null;
        }

        public void Remove(Entity obj)
        {
            Entity e = GetById(obj.Id);
            if (e != null)
            {
                entities.Remove(e);
            }
        }

        public void Save(int id)
        {
            Entity e = GetById(id);
            if (e != null)
            {
                e.Id = id;
            }
        }
    }
}

