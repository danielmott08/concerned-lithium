using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ConcernedLithium
{
    /// <summary>
    /// Marks the GameObject as Do Not Destroy On Load.
    /// </summary>
    public class DDOL : MonoBehaviour
    {
        private void Awake()
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}