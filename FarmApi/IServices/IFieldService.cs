namespace FarmApi;

public interface IFieldService
{
    List<FieldsDataModel> GetAll();
    FieldsDataModel GetByName(string fieldName);
    FieldsDataModel Save(FieldsDataModel item);
}
