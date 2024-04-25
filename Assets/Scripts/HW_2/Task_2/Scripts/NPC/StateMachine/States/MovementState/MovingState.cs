using UnityEngine;

public class MovingState : MovementState
{
    private MovementStateConfig _config;

    public MovingState(IStateSwitcher stateSwitcher, StateMachineData data, NPC character) : base(stateSwitcher, data, character)
        => _config = character.Config.MovementStateConfig;

    public override void Enter()
    {
        base.Enter();

        Data.Speed = _config.Speed;

        View.StartRunning();
    }

    public override void Exit()
    {
        View.StopRunning();
    }

    public override void Update()
    {
        Vector3 offset = Data.CurrentTargetPlace - CharacterController.transform.position;
        if (offset.magnitude > .1f)
        {
            offset = offset.normalized * Data.Speed;
            CharacterController.Move(offset * Time.deltaTime);

            Vector3 look = new Vector3(Data.CurrentTargetPlace.x, 
                CharacterController.transform.position.y, 
                Data.CurrentTargetPlace.z);

            CharacterController.transform.LookAt(look);
        } else
        {
            if (Data.CurrentTargetPlace == Data.WorkPlace)
                StateSwitcher.SwitchState<WorkingState>();
            else
                StateSwitcher.SwitchState<RestingState>();
        }
        //Мусорка
    }
 
   
}
