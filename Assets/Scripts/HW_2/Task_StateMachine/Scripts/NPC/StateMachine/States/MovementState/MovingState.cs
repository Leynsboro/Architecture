using System;
using UnityEngine;
using UnityEngine.XR;

public class MovingState : IState
{  
    protected StateMachineData Data; 
    protected readonly IStateSwitcher StateSwitcher;

    private readonly NPC _character;

    private MovementStateConfig _config;

    public MovingState(IStateSwitcher stateSwitcher, StateMachineData data, NPC character)
    {
        StateSwitcher = stateSwitcher;
        Data = data;
        _character = character;
        _config = character.Config.MovementStateConfig;
    }

    protected NpcView View => _character.View;
    protected CharacterController CharacterController => _character.CharacterController;

    public void Enter()
    {
        Debug.Log(GetType());
        Data.Speed = _config.Speed;

        View.StartRunning();
    }

    public void Exit()
    {
        View.StopRunning();
    }

    public void Update()
    {
        Move();
    }

    private void Move()
    {
        Vector3 offset = Data.CurrentTargetPlace - CharacterController.transform.position;

        if (offset.magnitude > .1f)
        {
            offset = offset.normalized * Data.Speed;
            CharacterController.Move(offset * Time.deltaTime);

            Vector3 targetLook = new Vector3(Data.CurrentTargetPlace.x,
                CharacterController.transform.position.y,
                Data.CurrentTargetPlace.z);

            CharacterController.transform.LookAt(targetLook);
        } else
        {
            ChangeState();
        }
    }

    private void ChangeState()
    {
        if (Data.CurrentTargetPlace == Data.WorkPlace)
            StateSwitcher.SwitchState<WorkingState>();
        else
            StateSwitcher.SwitchState<RestingState>();
    }
}
