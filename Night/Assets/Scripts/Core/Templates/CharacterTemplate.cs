using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Night.Core
{
    [CreateAssetMenu(menuName = "Nights/Templates/Agent", fileName = "Agent", order = 0)]
    public class CharacterTemplate : ScriptableObject
    {
        public int id;

        [Header("기본정보")]
        public string displayName;
        [Header("직업")]
        public JobTemplate jobTemplate;
        [Header("전투")]
        public int maxHP;
        public int ATK;
        public int DEF;
        public float attackTerm;
        public float TPRecoverPersec;
        [Range(0, 10)]
        public float attackRange;

    }
}

