using System.Text.RegularExpressions;
using Pharmacy.Contracts.Repositories;
using Pharmacy.Contracts.Validations;
using Pharmacy.Core;

namespace Pharmacy.BusinessLogic.Validators
{
    public class MedicamentValidator : IValidate<Medicament>
    {
        private readonly IRepository<Medicament> _repository;

        public MedicamentValidator(IRepository<Medicament> repository)
        {
            _repository = repository;
        }

        public bool IsValidEntity(Medicament entity)
        {
            return entity.SerialNumber.Length == 10
                   && Regex.IsMatch(entity.SerialNumber, @"...-...-..")
                   && entity.Price > 0;
        }

        public bool IsEntityExist(params object[] keys)
        {
            if (keys.Length != 1)
                return false;

            return _repository.GetByPrimaryKey(keys) != null;
        }
    }
}
