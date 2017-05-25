using System.Collections.Generic;

namespace BecketLee.ViewModels
{
    public class EventsViewModel
    {
        public IEnumerable<EventViewModel> Events { get; set; }
        
        public string SelectedTitle { get; set; }
        public string SelectedEventHtml { get; set; }
        public string ListCaption { get; set; }
        public string ItemAction { get; set; }
    }
}