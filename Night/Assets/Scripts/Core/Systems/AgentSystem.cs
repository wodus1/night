using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Night.Core
{
    public class AgentSystem : MonoBehaviour, ISubSystem
    {
        private List<AgentUnit> _agents = new List<AgentUnit>();
        public void Initialize()    
        {
            _agents.Clear();
        }

        public void Deinitialize()
        {
            _agents.Clear();
        }

        internal void AddAgent(AgentUnit agent)
        {
            _agents.Add(agent);
        }

        internal void RemoveAgent(AgentUnit agent)
        {
            _agents.Remove(agent);
        }

        internal AgentUnit GetMainAgent()
        {
            AgentUnit rangeOrMagicDealer = null;
            AgentUnit healer = null;

            for (int i = 0; i < _agents.Count; i++)
            {
                var jobId = _agents[i].Agent.template.jobTemplate.id;

                if (jobId == EJob.MeleeDealer)
                {
                    return _agents[i];
                }
                else if (jobId == EJob.RangedDealer || jobId == EJob.MagicDealer)
                {
                    if (rangeOrMagicDealer == null)
                        rangeOrMagicDealer = _agents[i];
                }
                else if (jobId == EJob.RangedDealer || jobId == EJob.MagicDealer)
                {
                    if (healer == null)
                        healer = _agents[i];
                }
            }

            if (rangeOrMagicDealer != null)
            {
                return rangeOrMagicDealer;
            }

            if (healer != null)
            {
                return healer;
            }

            return _agents.Count > 0 ? _agents[0] : null;
        }

        internal int AgentsCount()
        {
            return _agents.Count;
        }
    }
}
