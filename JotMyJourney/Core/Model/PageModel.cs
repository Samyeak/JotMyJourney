using System.Collections.Generic;

namespace JotMyJourney.Core.Model
{
    public class PageModel<T>
    {
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
        public IEnumerable<T> PageData { get; set; }
    }
}
