namespace Mediator
{
    public class CharacterLevel
    {
        public int Value { get; private set; }

        public CharacterLevel(int value) => Value = value;

        public void IncreaseLevel() => Value++;
    }
}

