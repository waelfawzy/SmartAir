namespace SmartAir_Api.StatusCodes
{
    public class CustomeStatusCodes
    {
        public static readonly Dictionary<int, string> ErrorCodes
           = new Dictionary<int, string>
             {
                { 200, "Success" },
                { 400, "Bad Requset" },
                {401,"check your password and try again" },
                {402,"invalid User name" },
                {500,"internal server error" }
              };
    }
}
