using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Night.Core
{
    [CreateAssetMenu(menuName = "Nights/Templates/Agent", fileName = "Agent", order = 0)]
    public class CharacterTemplate : ScriptableObject
    {
        public int id;

        [Header("�⺻����")]
        public string displayName;
        [Header("����")]
        public JobTemplate jobTemplate;
        [Header("����")]
        public int maxHP;
        public int ATK;
        public int DEF;
        public float attackTerm;
        public float TPRecoverPersec;
        [Range(0, 10)]
        public float attackRange;

    }
}

