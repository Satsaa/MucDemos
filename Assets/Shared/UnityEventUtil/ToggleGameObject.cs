using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Demo.Shared {
    
    [AddComponentMenu("Demo/Shared/ToggleGameObject")]
    public class ToggleGameObject : MonoBehaviour {
        
        public void DoToggle(GameObject gameObject) {
            gameObject.SetActive(!gameObject.activeSelf);
        }

    }

}
