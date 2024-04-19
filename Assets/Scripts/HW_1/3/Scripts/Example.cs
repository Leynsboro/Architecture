using UnityEngine;

public class Example : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private TraderBehaviourSwitcher _traderBeh;
    [SerializeField] private Trader _trader;

    private void Awake()
    {
        _traderBeh.Initialize(_player, _trader);

        _trader.SetTrade(new NoTrade());
    }
}
