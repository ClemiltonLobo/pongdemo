using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    public enum States
    {
        MENU,
        PLAYING,
        RESET_POSITION,
        END_GAME
    }
    public Dictionary<States, StateBase> dictionaryState;
    public AudioSource ballJumping;

    private StateBase _CurrentState;
    //public Player player;
    public float timeToStartGame = 1f;

    public static StateMachine Instance;


    private void Awake()
    {
        Instance = this;

        dictionaryState = new Dictionary<States, StateBase>();
        dictionaryState.Add(States.MENU, new StateBase());
        dictionaryState.Add(States.PLAYING, new StatePlaying());
        dictionaryState.Add(States.RESET_POSITION, new StateResetPosition());
        dictionaryState.Add(States.END_GAME, new StateEndGame());

        SwitchState(States.MENU);
    }
    public void SwitchState(States states)
    {
        if (_CurrentState != null) _CurrentState.onStateExit();

        _CurrentState = dictionaryState[states];

        if (_CurrentState != null) _CurrentState.onStateEnter();
    }

    private void Update()
    {
        if (_CurrentState != null) _CurrentState.onStateStay();
    }
    public void ResetPosition()
    {
        SwitchState(States.RESET_POSITION);
    }
    private void Start()
    {
        ballJumping = GetComponent<AudioSource>();
    }

}
