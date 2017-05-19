using System.Collections.Generic;
using BecketLee.Models;
using BecketLee.ViewModels;

namespace BecketLee.Data
{

    public interface IEventRepository
    {
        IEnumerable<EventViewModel> GetEvents();
        IEnumerable<EventViewModel> GetNews();
        IEnumerable<EventViewModel> GetPubs();
        IEnumerable<EventViewModel> Events();
        List<EventType> GetEventTypes();
        EventViewModel GetEventById( string eventId );
    }
}