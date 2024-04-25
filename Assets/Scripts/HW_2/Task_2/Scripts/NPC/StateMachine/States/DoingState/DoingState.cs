public class DoingState : CalmState
{
    public DoingState(IStateSwitcher stateSwitcher, StateMachineData data, NPC character) : base(stateSwitcher, data, character)
    {
    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit()
    {
        throw new System.NotImplementedException();
    }

    public override void Update()
    {
        throw new System.NotImplementedException();
    }
}
