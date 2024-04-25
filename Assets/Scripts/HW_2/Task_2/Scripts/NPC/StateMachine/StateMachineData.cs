using UnityEngine;

public class StateMachineData
{
    public Vector3 WorkPlace { get; private set; }
    public Vector3 RestPlace { get; private set; }

    public Vector3 CurrentTargetPlace;

    public float Speed;

    public float WorkTime;
    public float RestTime;

    public StateMachineData(NpcPoints points)
    {
        WorkPlace = points.WorkPlace.position;
        RestPlace = points.RestPlace.position;
    }
}
