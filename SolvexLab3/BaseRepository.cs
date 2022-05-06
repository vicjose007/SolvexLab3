using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolvexLab3
{
    public class BaseRepository<TEntity> where TEntity : BaseEntity
    {
        public List<TEntity> People { get; set; }

        private int PersonCounter = 1;

        public TEntity Add(TEntity entity)
        {

            entity.Id = PersonCounter;
            People.Add(entity);

            PersonCounter++;
            return entity;
        }

        public TEntity Update(int id, TEntity newPerson)
        {
            if (id != newPerson.Id) throw new Exception("id and person id does not exist");
            People.Add(newPerson);
            return newPerson;
        }
        public TEntity Delete(int personid)
        {
            var exist = People.Any(entity => entity.Id == entity.Id);

            var entity = People.Where(entity => entity.Id == personid).FirstOrDefault();

            People.Remove(entity);

            if (entity is null) throw new Exception("Person does not exist");

            return entity;

        }



    }
}
