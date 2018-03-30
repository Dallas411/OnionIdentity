using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionIdentity.Core.Entities.Models
{
    public class ApplicationUserLogin<TKey> : IdentityUserLogin<TKey> where TKey : IEquatable<TKey>
    {
    }
}
