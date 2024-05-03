using UnityEngine;

public interface IOrk: IRace
{
    public void UpArmor()
    {
        Debug.Log("Повышаем на 30с. броню");
    }
    
}
