using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionIdentity.Core.Entities.Models
{
    public class ApplicationUserRole<TKey> : IdentityUserRole<TKey> where TKey : IEquatable<TKey>
    {
    }
}
