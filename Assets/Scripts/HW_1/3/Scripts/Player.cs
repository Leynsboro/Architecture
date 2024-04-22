using System;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour, IBuyer
{
    [SerializeField] private Button _increaseReputationButton;

    public event Action<int> ReputationChanged;

    private int reputation = 0;

    private void Awake()
    {
        _increaseReputationButton.onClick.AddListener(IncreaseReputation);
    }

    private void IncreaseReputation()
    {
        reputation++;

        if (reputation > 0)
            ReputationChanged?.Invoke(reputation);
    }
}
