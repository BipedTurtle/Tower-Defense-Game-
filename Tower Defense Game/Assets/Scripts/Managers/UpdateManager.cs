using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CustomScripts.Managers
{
    public class UpdateManager : MonoBehaviour
    {
        public static UpdateManager Instance { get; private set; }
        private void Awake()
        {
            if (Instance != null) {
                Destroy(gameObject);
                return;
            }

            Instance = this;
        }


        public event Action GlobalUpdate;
        private void Update()
        {
            this.GlobalUpdate?.Invoke();
        }

        public event Action GlobalFixedUpdate;
        private void FixedUpdate()
        {
            this.GlobalFixedUpdate?.Invoke();
        }

        public event Action GlobalLateUpdate;
        private void LateUpdate()
        {
            this.GlobalLateUpdate?.Invoke();
        }
    }
}