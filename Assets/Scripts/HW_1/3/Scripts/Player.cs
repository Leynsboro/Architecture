using System;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private Button _increaseReputationButton;

    public event Action<int> ReputationChanged; //Не совсем понимаю важности event. Без работает так же, нет?
    //Если не сложно)

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
