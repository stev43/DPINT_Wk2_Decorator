using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPINT_Wk2_Decorator.Model
{
    public abstract class BaseFighterDecorator : IFighter
    {
        public BaseFighterDecorator(IFighter fighter)
        {
            Fighter = fighter;
        }

        private IFighter _fighter;

        public IFighter Fighter
        {
            get { return _fighter; }
            private set { _fighter = value; }
        }

        public virtual int Lives
        {
            get { return Fighter.Lives; }
            set { Fighter.Lives = value; }
        }

        public virtual int AttackValue
        {
            get { return Fighter.AttackValue; }
            set { Fighter.AttackValue = value; }
        }

        public virtual int DefenseValue
        {
            get { return Fighter.DefenseValue; }
            set { Fighter.DefenseValue = value; }
        }
        public virtual void Defend(Attack attack)
        {
            Fighter.Defend(attack);
        }

        public virtual Attack Attack()
        {
            return Fighter.Attack();
        }
    }
}
