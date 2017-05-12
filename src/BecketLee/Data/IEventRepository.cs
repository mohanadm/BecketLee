using System.Collections.Generic;
using BecketLee.ViewModels;

namespace BecketLee.Data
{

    public interface IEventRepository
    {
        IEnumerable<EventViewModel> GetEvents();
        IEnumerable<EventViewModel> GetNews();
        IEnumerable<EventViewModel> GetPubs();
    }
}