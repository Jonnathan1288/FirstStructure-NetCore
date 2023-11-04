using EFCommonCRUD.Interfaces;

namespace ProjectPractice.API.Handlers
{
    public static class ResponseHandler
    {
        public static Dictionary<string, object> BadRequest(string message = "bad-request")
        {
            return new() 
            {
                {"status", 400 },
                {"message", message }
            };
        }

        public static Dictionary<string, object> Conflict(string message)
        {
            return new()
            {
                { "status", 409},
                { "message", message }
            };
        }

        public static Dictionary<string, object> Error(int status, string message)
        {
            return new()
            {
                { "status", status },
                { "message", message}
            };
        }
        public static Dictionary<string, object?> Ok<T>(T data, string message = "successful")
        {
            return new()
            {
                { "status", 200},
                { "message", message},
                { "data", data}
            };
        }

        public static Dictionary<string, object> Ok<T>(IPage<T> page) where T : class
        { 
            return new()
            {
                {"status", 200 },
                {"message", "successful" },
                {"totalElements", page.GetTotalElements() },
                {"totalPages", page.GetTotalPages() },
                {"numberOfElements", page.GetNumberOfElements() },
                {"pageNumber", page.GetNumber() + 1 },
                {"last", page.IsLast()},
                {"first",page.IsFirst()},
                {"offset", page.GetPageable().GetOffset()},
                {"data", page.GetContent()},
            };
        }
    }
}
