using DDD.Domain.ValueObjects;
using LeaningDDD.Domain.Helpers;
using System;

namespace LeaningDDD.Domain.ValueObjects
{
    public sealed class MeasureValue: ValueObject<MeasureValue>

    {
        public MeasureValue(float value)
        {
            Value = value;
        }

        public float Value { get; }

        public string DisplayValue => Value.RoundString(6) + "℃";

        protected override bool EqualsCore(MeasureValue other)
        {
            return this.Value == other.Value;
        }
    }
}
