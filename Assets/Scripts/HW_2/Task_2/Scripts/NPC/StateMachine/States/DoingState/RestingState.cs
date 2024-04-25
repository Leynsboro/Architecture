using System.Threading.Tasks;

public class RestingState : DoingState
{
    private DoingStateConfig _config;
    private const int SecondsModifier = 1000;
    private bool _isStartedResting = false;

    public RestingState(IStateSwitcher stateSwitcher, StateMachineData data, NPC character) : base(stateSwitcher, data, character)
        => _config = character.Config.DoingStateConfig;

    public override void Enter()
    {
        base.Enter();

        _isStartedResting = true;

        View.StartResting();
    }

    public override void Exit()
    {
        View.StopResting();

        Data.CurrentTargetPlace = Data.WorkPlace;
    }

    public override void Update()
    {
        if (_isStartedResting)
        {
            _isStartedResting = false;

            EndRest(); //�� ���� ������, ������ �� ���������� � await 
        }
    }

    private async Task EndRest()
    {
        //�������� ���� ����� ����� ���������� � �������� � DoingState. � update ����. ��.
        int delayTime = (int)(_config.RestingTime * SecondsModifier);

        await Task.Delay(delayTime);

        StateSwitcher.SwitchState<MovingState>();
    }
}
