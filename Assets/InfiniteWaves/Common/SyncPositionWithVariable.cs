﻿using UnityEngine;
using UnityAtoms;

namespace UnityAtoms.Examples
{
    /// <summary>
    /// Script to sync the Vector3 Variable with this GameObject's current position.
    /// </summary>
    public class SyncPositionWithVariable : MonoBehaviour
    {
        [SerializeField]
        private AtomReference<Vector3> _reference;

        void LateUpdate()
        {
            _reference.Value = transform.position;
        }
    }
}

