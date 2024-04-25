using UnityEngine;

[CreateAssetMenu(fileName = "NpcConfig", menuName = "Configs/NpcConfig")]
public class NpcConfig : ScriptableObject
{
    [SerializeField] private DoingStateConfig _doingStateConfig;
    [SerializeField] private MovementStateConfig _movementStateConfig;

    public DoingStateConfig DoingStateConfig => _doingStateConfig;
    public MovementStateConfig MovementStateConfig => _movementStateConfig;
}
