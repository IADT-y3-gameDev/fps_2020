
using UnityEngine;
public class BulletHit : MonoBehaviour
{
 //When we touch something the bulletmesh will be disabled.
 //the parent empty object continues until it is destroyed
 //set by ttl variable.
 void OnCollisionEnter()
 {
    Debug.Log(gameObject);
    gameObject.SetActive(false);
 }


}
