using Godot;
using System;

namespace NPC
{

    public class Npc : KinematicBody2D
    {
        [Signal] public delegate void NpcTalk();

        public Vector2 target;

        public const int MAX_SPEED = 50;

        // Called when the node enters the scene tree for the first time.
        public override void _Ready()
        {
        }
    }
}