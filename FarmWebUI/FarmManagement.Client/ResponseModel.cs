namespace FarmManagement.Client
{
    public class ResponseModel
    {
        public int statusCode { get; set; }
        public bool status { get; set; }
        public object data { get; set; }
        public string message { get; set; }
    }
}
