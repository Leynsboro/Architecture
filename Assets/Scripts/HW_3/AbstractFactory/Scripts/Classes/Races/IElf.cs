using UnityEngine;

public interface IElf: IRace
{
    public void AddElementalDamage()
    {
        Debug.Log("Увеличиваем стихийный урон");
    }
    
}
