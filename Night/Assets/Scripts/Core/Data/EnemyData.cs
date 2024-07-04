using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Night.Core
{
    public class EnemyData
    {
        public EnemyTemplate template;
        public int NormalATK { get; private set; }
        public int NormalDEF { get; private set; }
        public float NormalAttackTerm { get; private set; }
        public float NormalAttackRange { get; private set; }
        
        public EnemyData(EnemyTemplate template)
        {
            this.template = template;
            NormalATK = template.ATK;
            NormalDEF = template.DEF;
            NormalAttackTerm = template.attackTerm;
            NormalAttackRange = template.attackRange;
        }
    }
}
