namespace RaqamliAvlod.Application.Utils
{
    public class PaginationMetaData
    {
        public uint CurrentPage { get; private set; }
        public uint TotalPages { get; private set; }
        public uint PageSize { get; private set; }
        public uint TotalCount { get; private set; }
        public bool IsFirstPage { get; private set; }
        public bool IsLastPage { get; private set; }
        public bool HasPrevious { get; private set; }
        public bool HasNext { get; private set; }

        public PaginationMetaData(int totalCount, PaginationParams @params)
        {
            CurrentPage = (uint)@params.PageNumber;
            PageSize = (uint)@params.PageSize;
            TotalPages = (uint)Math.Ceiling((double)totalCount / @params.PageSize);
            IsFirstPage = @params.PageNumber == 1;
            IsLastPage = @params.PageNumber == TotalPages;
            HasPrevious = @params.PageNumber > 1;
            HasNext = @params.PageNumber < TotalPages;
        }

        public PaginationMetaData(int totalCount, int pageIndex, int pageSize)
        {
            CurrentPage = (uint)pageIndex;
            PageSize = (uint)pageSize;
            TotalPages = (uint)Math.Ceiling((double)totalCount / pageSize);
            IsFirstPage = pageIndex == 1;
            IsLastPage = pageIndex == TotalPages;
            HasPrevious = pageIndex > 1;
            HasNext = pageIndex < TotalPages;
        }
    }
}