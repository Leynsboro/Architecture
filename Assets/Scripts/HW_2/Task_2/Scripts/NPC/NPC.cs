using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
public class NPC : MonoBehaviour
{
    [SerializeField] private NpcConfig _config;
    [SerializeField] private NpcView _view;
    [SerializeField] private NpcPoints _npcPoints;

    private NpcStateMachine _stateMachine;
    private CharacterController _characterController;

    public CharacterController CharacterController => _characterController;
    public NpcConfig Config => _config;
    public NpcView View => _view;

    private void Awake()
    {
        _view.Initialize();
        _characterController = GetComponent<CharacterController>();
        _stateMachine = new NpcStateMachine(this, _npcPoints);
    }

    private void Update()
    {
        _stateMachine.Update();
    }

}
