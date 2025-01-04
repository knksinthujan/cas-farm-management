namespace FarmApi;

public static class EndPoints
{

    public static void MapEndPoints(this WebApplication app)
    {
        app.MapGet("/connection-check", (IFieldService fieldService) =>
        {
            try
            {
                var fields = fieldService.GetAll();
            }
            catch (Exception ex)
            {
                return Results.Ok(new ResponseModel
                {
                    data = ex.Message,
                    message = "Something wrong with db connection please check db exist! OR check connection string!"
                });
            }
            return Results.Ok(new ResponseModel
            {
                data = "DB connected successfully!",
                message = "Api is ready to use!!!"
            });
        });

        app.MapGet("/get-all-fields", (IFieldService fieldService) =>
        {
            var fields = fieldService.GetAll();
            return Results.Ok(new ResponseModel
            {
                data = fields,
            });
        });

        app.MapGet("/get-by-field-name/{fieldName}", (IFieldService fieldService, string fieldName) =>
        {
            var item = fieldService.GetByName(fieldName);
            return Results.Ok(item);
        });

        _ = app.MapPost("/save", async (IFieldService fieldService, FieldsDataModel input) =>
         {
             var item = fieldService.GetByName(input.FieldName);
             if (item != null)
             {
                 return Results.Ok(new ResponseModel
                 {
                     status = false,
                     message = "The field name is already exist!",
                     data = input
                 });
             }
             var savedItem = fieldService.Save(input);
             return Results.Ok(new ResponseModel
             {
                 data = savedItem,
                 message = "Successfully added!"
             }); ;
         });
    }
}

public class ResponseModel
{
    public int statusCode { get; set; } = 200;
    public bool status { get; set; } = true;
    public object data { get; set; }
    public string message { get; set; } = "success!";
}
