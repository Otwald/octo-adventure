using Godot;
using System;

public abstract class State : Node
{
    public virtual void Enter(StateMaschine sM)
    {
    }

    public abstract string UpdateProcess(StateMaschine sM, float delta);
    public virtual void Exit(StateMaschine sM)
    {
    }
}
