using UnityEngine;
using Zenject;

namespace HW4.Mediator
{
    public class Example: ITickable
    {
        private Level _level;

        public Example(Level level)
        {
            _level = level;
        }

        public void Tick()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
                _level.OnDefeat();
        }
    }
}
