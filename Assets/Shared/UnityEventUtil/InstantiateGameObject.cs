using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Demo.Shared {
    
    [AddComponentMenu("Demo/Shared/InstantiateGameObject")]
    public class InstantiateGameObject : MonoBehaviour {
        
        public void DoInstantiate(GameObject gameObject) {
            GameObject.Instantiate(gameObject, gameObject.transform.position, gameObject.transform.rotation, gameObject.transform.parent);
        }

        public void DoInstantiateAndEnable(GameObject gameObject) {
            GameObject.Instantiate(gameObject, gameObject.transform.position, gameObject.transform.rotation, gameObject.transform.parent).SetActive(true);
        }

    }

}
