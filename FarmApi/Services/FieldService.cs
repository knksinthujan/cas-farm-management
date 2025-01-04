
namespace FarmApi
{
    public class FieldService : IFieldService
    {
        private FarmDbContext _context;
        public FieldService(FarmDbContext context)
        {
            _context = context;
        }
        public List<FieldsDataModel> GetAll()
        {
            return _context.Fields.OrderBy(x => x.FieldName).ToList();
        }

        public FieldsDataModel GetByName(string fieldName)
        {
            return _context.Fields.FirstOrDefault(x => x.FieldName == fieldName);
        }

        public FieldsDataModel Save(FieldsDataModel item)
        {
            item.Id = Guid.NewGuid();
            item.CreatedBy = Guid.Empty; //This need to be get from auth token,
            item.CreatedDate = DateTime.Now;
            
            _context.Fields.Add(item);
            _context.SaveChanges();
            return item;
        }
    }
}
