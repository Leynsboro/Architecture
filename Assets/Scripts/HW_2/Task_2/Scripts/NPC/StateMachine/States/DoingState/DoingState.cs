using UnityEngine;

public abstract class DoingState : IState
{
    protected StateMachineData Data;
    protected readonly IStateSwitcher StateSwitcher;

    private readonly NPC _character;

    protected readonly DoingStateConfig _config;

    protected float DoingTimer;

    public DoingState(IStateSwitcher stateSwitcher, StateMachineData data, NPC character)
    {
        StateSwitcher = stateSwitcher;
        Data = data;
        _character = character;
        _config = character.Config.DoingStateConfig;
    }

    protected NpcView View => _character.View;
    protected CharacterController CharacterController => _character.CharacterController;

    public virtual void Enter()
    {
        Debug.Log(GetType());
    }

    public virtual void Exit()
    {
        
    }

    public virtual void Update()
    {
        DoingTimer -= Time.deltaTime;

        if (DoingTimer <= 0)
        {
            EndOfDoing();
        }
    }

    protected abstract void EndOfDoing();
}
