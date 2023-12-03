using LeaningDDD.Domain;
using LeaningDDD.Domain.Repositories;
using LearningDDD.Infrastructure.Fake;
using LearningDDD.Infrastructure.SQLServer;

namespace LearningDDD.Infrastructure
{
    public static class Factories
    {
        public static IMeasureRepository CreateMeasure()
        {
#if DEBUG
            if (Shared.IsFake())
            {
                return new MeasureFake();
            }
#endif

            return new MeasureSQLServer();
        }
    }
}
