using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPINT_Wk2_Decorator.Model
{
    class StrengthenFighterDecorator : BaseFighterDecorator
    {
        public override int AttackValue
        {
            get { return base.AttackValue; }
            set { base.AttackValue = (int)(value * 1.1); }
        }

        public override int DefenseValue
        {
            get { return base.DefenseValue; }
            set { base.DefenseValue = (int)(value * 1.1); }
        }

        public StrengthenFighterDecorator(IFighter fighter) : base(fighter)
        {
            base.Fighter.AttackValue = (int)(fighter.AttackValue * 1.1);
            base.Fighter.DefenseValue = (int)(fighter.DefenseValue * 1.1);
        }
    }
}
