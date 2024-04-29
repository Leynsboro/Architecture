using System;
using UnityEngine;

[Serializable]
public class DoingStateConfig
{
    [field: SerializeField, Range(0, 10)] public float WorkingTime { get; private set; }

    [field: SerializeField, Range(0, 10)] public float RestingTime { get; private set; }
}