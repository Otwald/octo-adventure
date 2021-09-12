using Godot;
using System;

public class Player : KinematicBody2D
{

    public const int MAX_SPEED = 100;
    // Called when the node enters the scene tree for the first time.
    // public override void _Ready()
    // {

    // }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    // public override void _Process(float delta)
    // {
    //     this.GetInput();
    //     velocity = MoveAndSlide(velocity);
    // }

    public void NpcReach(Node node, float distance)
    {
        // GD.Print(node.Talk());
    }

}
