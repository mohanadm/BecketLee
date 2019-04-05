using System.Collections.Generic;
using BecketLee.Data;

namespace BecketLee.ViewModels
{
    public class PartnerMenuViewModel
    {
        private readonly IPartnerRepository _repository;

        private IEnumerable<string> _partnerNames;

        public PartnerMenuViewModel(IPartnerRepository repository)
        {
            _repository = repository;
            _partnerNames = _repository.GetPartnerNames();
        }

        public IEnumerable<string> PartnerNames
        {
            get { return _partnerNames; }
        } 
    }
}
