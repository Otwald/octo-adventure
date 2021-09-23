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
        this.initInteract(talkDist.GetCollider());
        return null;
    }
    public override void Exit(StateMaschine sM)
    {
        talkDist.Enabled = false;
    }

    ///<summary>Checks first with what the Player is interacting and then emits Signal to init Dialog System</summary>
    private void initInteract(Godot.Object body)
    {
        if (body is StaticBody2D)
        {
        }
        else if (body is KinematicBody2D)
        {
        }
    }
}
