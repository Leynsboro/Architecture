using System;
using UnityEngine;

namespace HW4.Mediator
{
    public class Level
    {
        public event Action Defeat;

        public Level()
        {
            Start();
        }

        public void Start()
        {
            //логика старта
            Debug.Log("StartLevel");
        }

        public void Restart()
        {
            //логика очистка уровня
            Start();
        }

        public void OnDefeat()
        {
            //логика остановки игры
            Defeat?.Invoke();
        }
    }

}
