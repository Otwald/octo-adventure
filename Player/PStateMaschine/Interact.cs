using Godot;
using System;

public class Interact : PlayerState
{
    RayCast2D talkDist;
    public override void _Ready()
    {
        base._Ready();
        talkDist = this.player.GetNode("RotationHelper").GetNode("TalkDist") as RayCast2D;
    }

    public override void Enter(StateMaschine sM)
    {
        talkDist.Enabled = true;
    }
    public override string UpdateProcess(StateMaschine sM, float delta)
    {
        if (!talkDist.IsColliding()) { return "previous"; }
        PhysicsBody2D body = talkDist.GetCollider() as PhysicsBody2D;
        GD.Print(body);
        return null;
    }
    public override void Exit(StateMaschine sM)
    {
        talkDist.Enabled = false;
    }
}
