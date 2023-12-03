using LeaningDDD.Domain.Entities;
using LeaningDDD.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaningDDD.Domain.Repositories
{
    public sealed class MeasureRepository
    {
        private IMeasureRepository _repository;

        public MeasureRepository(IMeasureRepository repository)
        {
            _repository = repository;
        }

        public MeasureEntity GetLatest()
        {
            var measure = _repository.GetLatest();
            if (measure == null)
            {
                throw new DataNotExistsException();
            }

            return measure;
        }
    }
}
