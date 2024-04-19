using UnityEngine;

public class NoTrade : ITrader
{
    public void OfferProduct()
    {
        Debug.Log("Я не буду с тобой торговать");
    }
}
