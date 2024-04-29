using System.Collections.Generic;
using System.Linq;

public class NpcStateMachine : IStateSwitcher
{
    private List<IState> _states;
    private IState _currentState;

    public NpcStateMachine(NPC character, NpcPoints npcPoints)
    {
        StateMachineData data = new StateMachineData(npcPoints);

        _states = new List<IState>()
        {
            new MovingState(this, data, character),
            new WorkingState(this, data, character),
            new RestingState(this, data, character)
        };

        _currentState = _states[0];
        _currentState.Enter();
    }

    public void SwitchState<T>() where T : IState
    {
        IState state = _states.FirstOrDefault(state => state is T);

        _currentState.Exit();
        _currentState = state;
        _currentState.Enter();
    }

    public void Update() => _currentState.Update();
}