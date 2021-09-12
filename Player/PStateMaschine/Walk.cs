using Godot;
using System;

public class Walk : PlayerState
{
    public override string UpdateProcess(StateMaschine stateMaschine, float delta)
    {
        this.velocity = this.GetInput();
        if (this.velocity == new Vector2(0, 0)) { return "previous"; }
        this.velocity = this.velocity * Player.MAX_SPEED;
        this.velocity = stateMaschine.player.MoveAndSlide(this.velocity);
        return null;
    }
}
