using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionIdentity.Core.Entities.Models
{
    public class ApplicationUserClaim<TKey> : IdentityUserClaim<TKey> where TKey : IEquatable<TKey>
    {
    }
}
