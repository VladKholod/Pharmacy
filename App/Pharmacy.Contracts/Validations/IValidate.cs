using Pharmacy.Contracts.Entities;

namespace Pharmacy.Contracts.Validations
{
    public interface IValidate<in T> where T : class, IDbEntity
    {
        bool IsValidEntity(T entity);
        bool IsEntityExist(params object[] keys);
    }
}
