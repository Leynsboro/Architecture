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
            //������ ������
            Debug.Log("StartLevel");
        }

        public void Restart()
        {
            //������ ������� ������
            Start();
        }

        public void OnDefeat()
        {
            //������ ��������� ����
            Defeat?.Invoke();
        }
    }

}
