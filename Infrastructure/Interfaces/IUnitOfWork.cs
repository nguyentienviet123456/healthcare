using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Interfaces
{
    public interface IUnitOfWork: IDisposable
    {
        /// <summary>
        /// Call save change form db context
        /// </summary>
        void Commit();
    }
}
