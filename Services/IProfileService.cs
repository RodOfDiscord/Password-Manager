﻿using Domain;

namespace Services
{
    public interface IProfileService
    {
        IEnumerable<Profile> GetProfiles();
        Profile? FindByName(string name);
    }
}