using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Demo.Shared {
    
    [AddComponentMenu("Demo/Shared/DestroyGameObject")]
    public class DestroyGameObject : MonoBehaviour {
        
        public void DoDestroy(GameObject gameObject) {
            Destroy(gameObject);
        }

    }

}
