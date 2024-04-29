using UnityEngine;

public class NpcPoints : MonoBehaviour
{
    [SerializeField] private Transform _workPlace;
    [SerializeField] private Transform _restPlace;

    public Transform WorkPlace => _workPlace;
    public Transform RestPlace => _restPlace;
}
