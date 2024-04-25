using System.Threading.Tasks;

public class WorkingState : DoingState
{
    private DoingStateConfig _config;
    private const int SecondsModifier = 1000;
    private bool _isStartedWorking = false;

    public WorkingState(IStateSwitcher stateSwitcher, StateMachineData data, NPC character) : base(stateSwitcher, data, character)
        => _config = character.Config.DoingStateConfig;

    public override void Enter()
    {
        base.Enter();

        _isStartedWorking = true;
        Data.Speed = 0; //магическое?)

        View.StartWorking();
    }

    public override void Exit()
    {
        View.StopWorking();

        Data.CurrentTargetPlace = Data.RestPlace;
    }

    public override void Update()
    {
        if (_isStartedWorking)
        {
            _isStartedWorking = false;

            EndWork(); //Не могу понять, почему не вызывается с await 
        }
    }

    private async Task EndWork()
    {
        int delayTime = (int)(_config.WorkingTime * SecondsModifier);

        await Task.Delay(delayTime);

        StateSwitcher.SwitchState<MovingState>();
    }
 
    
}
