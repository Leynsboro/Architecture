using System;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private Button _increaseReputationButton;

    public event Action<int> ReputationChanged; //�� ������ ������� �������� event. ��� �������� ��� ��, ���?
    //���� �� ������)

    private int reputation = 0;

    private void Awake()
    {
        _increaseReputationButton.onClick.AddListener(IncreaseReputation);
    }

    private void IncreaseReputation()
    {
        reputation++;

        ReputationChanged?.Invoke(reputation);
    }
}
