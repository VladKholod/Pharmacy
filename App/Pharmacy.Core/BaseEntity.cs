using Pharmacy.Contracts.Entities;

namespace Pharmacy.Core
{
    public class BaseEntity : IDbEntity
    {
        public int Id { get; private set; }
    }
}
