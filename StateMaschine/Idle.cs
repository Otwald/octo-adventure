using Godot;
using System;

public class Idle : PlayerState
{
    public override string UpdateProcess(StateMaschine stateMaschine, float delta)
    {
        this.GetInput();
        if (velocity != new Vector2(0, 0))
        {
            return "walk";
        }
        return null;
    }

    //  // Called every frame. 'delta' is the elapsed time since the previous frame.
    //  public override void _Process(float delta)
    //  {
    //      
    //  }
}
