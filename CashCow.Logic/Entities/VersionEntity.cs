using CashCow.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CashCow.Logic.Entities
{
    internal abstract partial class VersionEntity : IdentityEntity, IVersionable
    {
        public byte[] RowVersion { get; set; }
    }
}
