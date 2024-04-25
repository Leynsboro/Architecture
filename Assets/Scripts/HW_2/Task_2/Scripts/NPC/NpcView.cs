using UnityEngine;

[RequireComponent(typeof(Animator))]
public class NpcView : MonoBehaviour
{
    private const string IsRunning = "IsRunning";
    private const string IsWorking = "IsWorking";
    private const string IsResting = "IsResting";

    private Animator _animator;

    public void Initialize() => _animator = GetComponent<Animator>();

    public void StartRunning() => _animator.SetBool(IsRunning, true);
    public void StopRunning() => _animator.SetBool(IsRunning, false);

    public void StartWorking() => _animator.SetBool(IsWorking, true);
    public void StopWorking() => _animator.SetBool(IsWorking, false);

    public void StartResting() => _animator.SetBool(IsResting, true);
    public void StopResting() => _animator.SetBool(IsResting, false);
}
