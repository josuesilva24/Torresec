using System.Data.Objects;
using System.Linq;
using Entity;

namespace DAL
{
    public class DataAccessLogicBase
    {
        private SilesEntities _dataContext;

        protected SilesEntities DataContext
        {
            get
            {
                if (_dataContext == null)
                    _dataContext = new SilesEntities();
                return _dataContext;
            }
            set { _dataContext = value; }
        }

        public void SaveChanges()
        {
            DataContext.SaveChanges();
        }

        public virtual void DeleteObject(object objectToDelete)
        {
            DataContext.DeleteObject(objectToDelete);

        }


        public ObjectQuery<T> Includes<T>(ObjectQuery<T> source, params string[] includes)
        {
            return includes.Where(t => !string.IsNullOrEmpty(t)).Aggregate(source, (current, t) => current.Include(t));
        }

    }
}
