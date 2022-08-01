using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateBase
{
    public virtual void onStateEnter(object o = null)
    {
    }
    public virtual void onStateStay()
    {
    }
    public virtual void onStateExit()
    {
    }
}
public class StatePlaying:StateBase
{
    public override void onStateEnter(object o = null)
    {
        base.onStateEnter(o);
        //BallBase b = (BallBase)o;

        GameManager.Instance.StartGame();
    }
}
public class StateResetPosition : StateBase
{
    public override void onStateEnter(object o = null)
    {
        base.onStateEnter(o);
        GameManager.Instance.ResetBall();
    }
}

public class StateEndGame : StateBase
{
    public override void onStateEnter(object o = null)
    {
        base.onStateEnter(o);
        GameManager.Instance.ResetPlayers();
        GameManager.Instance.ShowMainMenu();
    }
}