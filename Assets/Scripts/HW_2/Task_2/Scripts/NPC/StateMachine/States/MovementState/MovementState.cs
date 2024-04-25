public class MovementState : CalmState
{
    public MovementState(IStateSwitcher stateSwitcher, StateMachineData data, NPC character) : base(stateSwitcher, data, character)
    {
        Data.CurrentTargetPlace = Data.WorkPlace;
    }

    public override void Enter()
    {
        base.Enter();
    }
    public override void Exit()
    {
        
    }

    public override void Update()
    {
        
    }
}
