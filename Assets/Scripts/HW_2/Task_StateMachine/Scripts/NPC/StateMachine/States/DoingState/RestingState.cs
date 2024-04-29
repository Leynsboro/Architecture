public class RestingState : DoingState
{
    public RestingState(IStateSwitcher stateSwitcher, StateMachineData data, NPC character) : base(stateSwitcher, data, character)
    { }

    public override void Enter()
    {
        base.Enter();

        DoingTimer = _config.RestingTime;

        View.StartResting();
    }

    public override void Exit()
    {
        View.StopResting();

        Data.CurrentTargetPlace = Data.WorkPlace;
    }

    public override void Update()
    {
        base.Update();
    }

    protected override void EndOfDoing()
    {
        StateSwitcher.SwitchState<MovingState>();
    }
}
