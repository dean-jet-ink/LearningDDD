using LeaningDDD.Domain.Entities;
using LeaningDDD.Domain.Repositories;
using LeaningDDD.Domain.ValueObjects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_DDD.WinForm.StaticValues
{
    public static class Measures
    {
        private static List<MeasureEntity> _entities = new List<MeasureEntity>();

        public static void Create(IMeasureRepository repository)
        {
            lock (((ICollection)_entities).SyncRoot)
            {
                _entities.Clear();
                _entities.AddRange(repository.GetLatests());
            }
        }

        public static MeasureEntity GetLatest(AreaId areaId)
        {
            lock (((ICollection)_entities).SyncRoot){
                return _entities.Find(x => x.AreaId == areaId);
            }
        }
    }
}
