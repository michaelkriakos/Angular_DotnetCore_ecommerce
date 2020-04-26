using System.Collections.Generic;

namespace API.Helpers
{
    public class Pagination<T> where T:class
    {
        public Pagination(int pageIndex, int pageSize, int count, IReadOnlyList<T> myProperty)
        {
            PageIndex = pageIndex;
            PageSize = pageSize;
            Count = count;
            MyProperty = myProperty;
        }

        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int Count { get; set; }  
        public IReadOnlyList<T> MyProperty { get; set; }
    }
}