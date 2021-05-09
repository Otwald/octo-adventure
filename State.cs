using Godot;
using System;

public abstract class State : Node
{
    public void Enter(StateMaschine sM)
    {
    }

    public abstract string UpdateProcess(StateMaschine sM, float delta);
    public void Exit(StateMaschine sM)
    {
    }
}
