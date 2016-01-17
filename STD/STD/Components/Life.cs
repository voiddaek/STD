using Otter;
using STD.Entities;
using STD.Entities.Interface;
using STD.Components;
using STD.Components.Interface;
using System;

namespace STD.Components
{
    public class Life : Component
    {
        public int MaxHealth;
        public int Health;
        public Action OnDeath = delegate { };
        public Action OnHurt = delegate { };

        public Life(int maxHealth)
        {
            MaxHealth = maxHealth;
            Health = maxHealth;
        }

        public void Hurt(int damage)
        {
            OnHurt();
            Health -= damage;
            if (Health <= 0)
                OnDeath();
        }
    }
}
