using Godot;
using System;

namespace NPC
{
    public class Walk : NPCState
    {
        public override void _Ready()
        {
            base._Ready();
        }
        public override string UpdateProcess(StateMaschine sM, float delta)
        {
            if (self.GlobalPosition.DistanceTo(self.target) < 5) { return "previous"; }
            Vector2 distance = (self.target - self.GlobalPosition).Normalized();
            this.velocity = distance * Npc.MAX_SPEED;
            this.velocity = self.MoveAndSlide(this.velocity);
            return "";
        }
    }
}
