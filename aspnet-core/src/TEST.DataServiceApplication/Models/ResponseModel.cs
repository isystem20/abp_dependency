using Newtonsoft.Json.Linq;

namespace TEST.DataServiceApplication.Models
{
    public class ResponseModel
    {
        public int code { get; set; }
        public DataModel data { get; set; }

    }

    public class DataModel
    {
        public JObject data { get; set; }
    }
}
