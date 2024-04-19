using UnityEngine;

public class TraderBehaviourSwitcher : MonoBehaviour
{
    private Player _player;
    private Trader _trader;

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
            case 0:
                _trader.SetTrade(new NoTrade());
                break;
            case 1:
                _trader.SetTrade(new FruitTrade());
                break;
            default:
                _trader.SetTrade(new ArmorTrade());
                break;
        }
    }
}
