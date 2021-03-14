using System.Collections.Generic;

namespace API.Errors
{
    public class ApiValiodationErrorResponse : ApiResponse
    {
        public ApiValiodationErrorResponse() : base(400)
        {

        }

        public IEnumerable<string>  Errors { get; set; }
    }
}