﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPINT_Wk2_Decorator.Model
{
    class PoisonFighterDecorator : BaseFighterDecorator
    {
        private int PoisonStrength { get; set; }

        public override Attack Attack()
        {
            var attack = base.Attack();
            if (PoisonStrength > 0)
            {
                attack.Messages.Add("Poison weakening, current value: " + PoisonStrength);
                attack.Value += PoisonStrength;
                PoisonStrength -= 2;
            }
            else
            {
                attack.Messages.Add("Poison ran out.");
            }
            return attack;
        }

        public PoisonFighterDecorator(IFighter fighter, int poisonStrength) : base(fighter)
        {
            PoisonStrength = poisonStrength;
        }
    }
}
