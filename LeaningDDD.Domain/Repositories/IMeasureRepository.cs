using LeaningDDD.Domain.Entities;
using System.Collections.Generic;

namespace LeaningDDD.Domain.Repositories
{
    public interface IMeasureRepository
    {
        MeasureEntity GetLatest();
        IReadOnlyList<MeasureEntity> GetLatests();
    }
}
