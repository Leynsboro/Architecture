using UnityEngine;

public class TraderBehaviourSwitcher : MonoBehaviour
{
    private Player _player;
    private Trader _trader;

    private const int NoTradeReputation = 0;
    private const int FruitTradeRepuation = 1;
    private const int ArmorTradeReputation = 2;

    private void OnEnable() => _player.ReputationChanged += CheckReputation;

    private void OnDisable() => _player.ReputationChanged -= CheckReputation;

    public void Initialize(Player player, Trader trader)
    {
        _player = player;
        _trader = trader;
    }

    private void CheckReputation(int playerReputation)
    {
        switch (playerReputation)
        {
            case NoTradeReputation:
                _trader.SetTrade(new NoTrade());
                break;
            case FruitTradeRepuation:
                _trader.SetTrade(new FruitTrade());
                break;
            case ArmorTradeReputation:
                _trader.SetTrade(new ArmorTrade());
                break;
        }
    }
}
