﻿using Microsoft.AspNetCore.Identity;

namespace bmarketomvc.Models.Entities;

public class UserEntity : IdentityUser
{
    public string? FirstName { get; set; }

    public string? LastName { get; set;}

    public ICollection<UserAddressEntity> UserAddresses { get; set; } = new HashSet<UserAddressEntity>();
}
