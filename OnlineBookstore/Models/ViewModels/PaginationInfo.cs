namespace OnlineBookstore.Models.ViewModels
{
    public class PaginationInfo
    {
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }

        public int TotalNumPages => (int) (Math.Ceiling((Decimal) TotalItems / ItemsPerPage));
    }
}
