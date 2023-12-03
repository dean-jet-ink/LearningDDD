using LeaningDDD.Domain;
using LeaningDDD.Domain.Entities;
using LeaningDDD.Domain.Exceptions;
using LeaningDDD.Domain.Repositories;
using System;
using System.Collections.Generic;

namespace LearningDDD.Infrastructure.Fake
{
    internal sealed class MeasureFake : IMeasureRepository
    {
        public MeasureEntity GetLatest()
        {
            try
            {
                var fakeFileLines = System.IO.File.ReadAllLines(Shared.FakePath + "MeasureFake.csv");
                var values = fakeFileLines[0].Split(',');
                return new MeasureEntity(
                        Convert.ToInt32(values[0]),
                        Convert.ToDateTime(values[1]),
                        Convert.ToSingle(values[2])
                      );
            } catch(Exception ex)
            {
                throw new FakeException("データの取得に失敗しました", ex);
                //return new MeasureEntity(
                //            1,
                //            Convert.ToDateTime("2023/11/30 11:55:00"),
                //            12.345f
                //        );
            }

        }

        public IReadOnlyList<MeasureEntity> GetLatests()
        {
            var result = new List<MeasureEntity>
            {
                new MeasureEntity(
                            10,
                            Convert.ToDateTime("2023/12/3 18:21:00"),
                            123.45f
                        ),
                new MeasureEntity(
                            20,
                            Convert.ToDateTime("2023/12/3 18:21:00"),
                            123.45f
                        ),
                new MeasureEntity(
                            30,
                            Convert.ToDateTime("2023/12/3 18:21:00"),
                            123.45f
                        )
            };

            return result;
        }
    }
}
