using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Night.Core
{
    public class AgentData
    {
        public CharacterTemplate template;
        public int normalATK { get; private set; }
        public int normalDEF { get; private set; }
        public float normalAttackTerm { get; private set; }
        public float normalTPRecoverPersec { get; private set; }
        public float normalAttackRange { get; private set; }
        
        public AgentData(CharacterTemplate template)
        {
            this.template = template;
            normalATK = template.ATK;
            normalDEF = template.DEF;
            normalAttackTerm = template.attackTerm;
            normalTPRecoverPersec = template.TPRecoverPersec;
            normalAttackRange = template.attackRange;
        }
    }
}
