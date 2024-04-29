using System;

namespace Mediator
{
    public class Health
    {
        private const int HpModifier = 3;

        public event Action Died;

        public int Value { get; private set; }
        public int MaxValue { get; private set; }

        public Health(int value)
        {
            Value = MaxValue = value;
        }

        public void IncreaseMaxHealth()
        {
            Value = MaxValue += HpModifier;
        }

        public void Add(int value)
        {
            if (value < 0)
                return;

            Value += value;

            if (Value > MaxValue)
                Value = MaxValue;
        }

        public void Reduce(int value)
        {
            if (value < 0)
                return;

            Value -= value;

            if (Value <= 0)
            {
                Value = 0;
                Died?.Invoke();
            }
                
        }
    }
}

