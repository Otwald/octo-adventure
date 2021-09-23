using Godot;
using System;

namespace NPC
{
    public abstract class NPCState : State
    {
        public Vector2 velocity = new Vector2();

        protected Npc self;
        public override void _Ready()
        {
            self = GetParent().GetParent<Npc>();
        }
    }
}
