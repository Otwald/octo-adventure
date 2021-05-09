using Godot;
using System;

public class Walk : PlayerState
{
    public override string UpdateProcess(StateMaschine stateMaschine, float delta)
    {
        this.GetInput();
        if (velocity == new Vector2(0, 0))
        {
            return "previous";
        }
        velocity = stateMaschine.parent.MoveAndSlide(velocity);
        return null;
    }
}
