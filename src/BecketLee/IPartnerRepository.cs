using System.Collections.Generic;
using BecketLee.Models;

namespace BecketLee.Data
{
    public interface IPartnerRepository
    {
        List<PartnerBiography> GetBiographies();
    }
}