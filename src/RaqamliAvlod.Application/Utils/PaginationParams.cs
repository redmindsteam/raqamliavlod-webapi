using Newtonsoft.Json;

namespace RaqamliAvlod.Application.Utils
{
    public class PaginationParams
    {
        private const int maxPageSize = 50;
        private int pageSize = 10;

        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; } = 1;

        [JsonProperty("pageSize")]
        public int PageSize
        {
            get { return pageSize; }
            set { pageSize = (value > maxPageSize) ? maxPageSize : value; }
        }

        public PaginationParams(int pageNumber, int pageSize)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
        }

        public PaginationParams()
        {
        }
    }
}