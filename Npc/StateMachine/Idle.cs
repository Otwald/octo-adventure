using Godot;
using System;

namespace NPC
{
    public class Idle : NPCState
    {
        private Node2D a;
        private Node2D b;

        public override void _Ready()
        {
            base._Ready();
            a = GetNode("/root/_Root").GetNode("A") as Node2D;
            b = GetNode("/root/_Root").GetNode("B") as Node2D;
        }
        public override string UpdateProcess(StateMaschine sM, float delta)
        {
            if (a.GlobalPosition.DistanceTo(self.GlobalPosition) > 5)
            {
                self.target = a.GlobalPosition;
            }
            else
            {
                self.target = b.GlobalPosition;
            }
            return "walk";

        }
    }
}