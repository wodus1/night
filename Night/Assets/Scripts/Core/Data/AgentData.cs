using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Night.Core
{
    public class AgentData
    {
        public AgentTemplate template;
        public int NormalATK { get; private set; }
        public int NormalDEF { get; private set; }
        public float NormalAttackTerm { get; private set; }
        public float NormalTPRecoverPersec { get; private set; }
        public float NormalAttackRange { get; private set; }
        
        public AgentData(AgentTemplate template)
        {
            this.template = template;
            NormalATK = template.ATK;
            NormalDEF = template.DEF;
            NormalAttackTerm = template.attackTerm;
            NormalTPRecoverPersec = template.TPRecoverPersec;
            NormalAttackRange = template.attackRange;
        }
    }
}
