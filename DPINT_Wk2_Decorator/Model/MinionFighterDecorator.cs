﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPINT_Wk2_Decorator.Model
{
    class MinionFighterDecorator : BaseFighterDecorator
    {
        private int MinionLives { get; set; }
        private int MinionAttackValue { get; set; }

        public override void Defend(Attack attack)
        {
            if (MinionLives > 0)
            {
                int tmpLives = MinionLives;
                MinionLives -= Math.Max(0, attack.Value);
                attack.Value -= Math.Max(0, tmpLives - MinionLives);
                attack.Messages.Add("Minion defended from the attack: -" + attack.Value);
            }
        }

        public override Attack Attack()
        {
            var attack = base.Attack();
            if (MinionLives > 0)
            {
                attack.Messages.Add("Minion helping the attack: " + MinionAttackValue);
                attack.Value += MinionAttackValue;
            }
            return attack;
        }

        public MinionFighterDecorator(IFighter fighter, int minionLives, int minionAttackValue) : base(fighter)
        {
            MinionLives = minionLives;
            MinionAttackValue = minionAttackValue;
        }
    }
}
