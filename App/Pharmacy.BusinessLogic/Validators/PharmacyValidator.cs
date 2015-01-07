using System;
using System.Linq;
using Pharmacy.Contracts.Repositories;
using Pharmacy.Contracts.Validations;

namespace Pharmacy.BusinessLogic.Validators
{
    public class PharmacyValidator : IValidate<Core.Pharmacy>
    {
        private readonly IRepository<Core.Pharmacy> _repository;

        public PharmacyValidator(IRepository<Core.Pharmacy> repository)
        {
            _repository = repository;
        }

        public bool IsValidEntity(Core.Pharmacy entity)
        {
            if (_repository.GetAll().ToList().Count == 0) 
                return true;

            var flag = true;
            foreach (var pharmacy in _repository.GetAll())
            {
                if (string.Compare(pharmacy.Address, entity.Address, StringComparison.Ordinal) == 0)
                    flag = false;
            }

            return flag;
        }

        public bool IsEntityExist(params object[] keys)
        {
            if (keys.Length != 1)
                return false;

            return _repository.GetByPrimaryKey(keys) != null;
        }
    }
}
