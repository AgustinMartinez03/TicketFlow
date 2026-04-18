namespace TicketFlow.Application.DTOs.Response
{
    public class EventCatalogResponse
    {
        public IEnumerable<EventResponse> Events { get; set; } = new List<EventResponse>();
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalRecords { get; set; }
        public int TotalPages => (int)Math.Ceiling((double)TotalRecords / PageSize);
    }
}
