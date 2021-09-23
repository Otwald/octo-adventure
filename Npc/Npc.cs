using Godot;
using System;

public class Npc : KinematicBody2D
{

    [Export] public float talkDistance = 100;
    [Signal] public delegate void NpcTalk();
    Player.Player player = null;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        player = GetParent().GetNode<Player.Player>("Player");
        Connect(nameof(NpcTalk), player, nameof(player.NpcReach));

    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(float delta)
    {
        float disctance = this.GlobalPosition.DistanceTo(player.GlobalPosition);
        if (disctance < talkDistance)
        {
            EmitSignal(nameof(NpcTalk), this, disctance);
        }

    }

    public void Talk()
    {

    }
}
