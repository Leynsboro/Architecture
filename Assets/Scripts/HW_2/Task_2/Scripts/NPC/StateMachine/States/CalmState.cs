using UnityEngine;


public abstract class CalmState : IState
{
    //������ ����� ��������. ��� � �������� � ������. ���� ���������, ����� ��� �������� (������ ��� ������ ���-��)
    //� ���� ��������� �����, �� �������
    protected readonly IStateSwitcher StateSwitcher;
    protected readonly StateMachineData Data;
    protected readonly NPC _character;

    protected CharacterController CharacterController => _character.CharacterController;
    protected NpcView View => _character.View;

    protected CalmState(IStateSwitcher stateSwitcher, StateMachineData data, NPC character)
    {
        StateSwitcher = stateSwitcher;
        Data = data;
        _character = character;
    }

    public virtual void Enter()
    {
        Debug.Log(GetType());
    }

    public abstract void Exit();

    public abstract void Update();
}
