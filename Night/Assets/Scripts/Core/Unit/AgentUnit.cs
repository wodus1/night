using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Night.Core
{
    public class AgentUnit : Unit
    {
        private AgentData _agent;

        public AgentData Agent => _agent;
        protected override void Awake()
        {
            base.Awake();
        }

        internal void Initialize(AgentData agent)
        {
            _agent = agent;
            _moveAbility.Initialize(this);
        }
    }
}

