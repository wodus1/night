using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Night.Core
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance { get; private set; }
        
        [SerializeField ] private List<CharacterTemplate> _agentTemplates = new List<CharacterTemplate>();
        private List<AgentData> _agentDatas = new List<AgentData>();
        private Dictionary<Type, ISubSystem> _subSystems = new Dictionary<Type, ISubSystem>();

        public List<AgentData> AgentDatas => _agentDatas;
        
        private void Awake()
        {
            if(Instance == null)
            {
                Instance = this;

                DontDestroyOnLoad(this);
            }

            Initialize();
        }

        private void Initialize()
        {
            var systems = GetComponentsInChildren<ISubSystem>(true);

            foreach (var system in systems)
            {
                _subSystems.Add(system.GetType(), system);
            }

            foreach (var system in _subSystems.Values)
            {
                system.Initialize();
            }

            foreach (var data in _agentTemplates)
            {
                _agentDatas.Add(new AgentData(data));
            }

            UnitCreateSystem unitCreateSystem = GetSubSystem<UnitCreateSystem>();
            foreach(var data in _agentDatas)
            {
                unitCreateSystem.CreateAgent(data);
            }
        }

        public T GetSubSystem<T>() where T : ISubSystem
        {
            _subSystems.TryGetValue(typeof(T), out var subSystem);
            
            return (T)subSystem;
        }
    }
}

