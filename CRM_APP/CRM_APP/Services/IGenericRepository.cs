namespace CRM_APP.Services
{
    public interface IGenericRepository<TEntities> where TEntities : class, new()
    {
        void Add(TEntities entities);
        void Update(TEntities entities);
        void Delete(TEntities entities);
        public List<TEntities> Get();
        public TEntities GetId(int id);

    }
}
