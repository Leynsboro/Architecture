public class WorkingState : DoingState
{
    public WorkingState(IStateSwitcher stateSwitcher, StateMachineData data, NPC character) : base(stateSwitcher, data, character)
    { }

    public override void Enter()
    {
        base.Enter();

        DoingTimer = _config.WorkingTime;

        View.StartWorking();
    }

    public override void Exit()
    {
        View.StopWorking();

        Data.CurrentTargetPlace = Data.RestPlace;
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
