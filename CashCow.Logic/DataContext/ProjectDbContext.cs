using CashCow.Logic.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CashCow.Logic.DataContext
{
    internal partial class ProjectDbContext : DbContext, IContext
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
