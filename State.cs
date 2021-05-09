using Godot;
using System;

public abstract class State : Node
{
    public void Enter()
    {

    }

    public abstract string UpdateProcess(float delta);
    public void Exit()
    {

    }
}
