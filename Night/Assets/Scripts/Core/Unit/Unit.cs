using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Night.Core
{
    [RequireComponent(typeof(AnimationController))]
    public abstract class Unit : MonoBehaviour
    {
        [SerializeField] private Transform _projectilePoint;
        
        private AnimationController _animationController;
        
        public Transform ProjectilePoint => _projectilePoint;
        
        public AnimationController AnimationController => _animationController;
        
        protected virtual void Awake()
        {
            _animationController = GetComponent<AnimationController>();
        }
    }
}

