using UnityEngine;

public class Trader : MonoBehaviour
{
    private ITrader _trader;

    public void SetTrade(ITrader trader)
    {
        _trader = trader;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out IBuyer buyer))
            _trader.OfferProduct();
    }
}
