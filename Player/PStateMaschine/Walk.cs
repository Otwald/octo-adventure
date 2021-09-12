using Godot;
using System;

public class Walk : PlayerState
{
    public override string UpdateProcess(StateMaschine sM, float delta)
    {
        if (this.GetInteractInput()) { return "interact"; }
        this.velocity = this.GetInput();
        if (this.velocity == new Vector2(0, 0)) { return "previous"; }
        Node2D rotHelp = this.Player.GetNode("RationHelper") as Node2D;
        rotHelp.Rotation = this.velocity.Angle();
        this.velocity = this.velocity * Player.MAX_SPEED;
        this.velocity = Player.MoveAndSlide(this.velocity);
        return null;
    }
}
