using Godot;
using System;

public class Idle : PlayerState
{
    public override string UpdateProcess(StateMaschine sM, float delta)
    {
        if (this.GetInteractInput()) { return "interact"; }
        this.velocity = this.GetInput();
        if (this.velocity != new Vector2(0, 0)) { return "walk"; }
        return null;
    }

    //  // Called every frame. 'delta' is the elapsed time since the previous frame.
    //  public override void _Process(float delta)
    //  {
    //      
    //  }
}
