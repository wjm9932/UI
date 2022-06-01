using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour
{
    public UnityEvent onPlayerDead;

    public void Dead()
    {
        onPlayerDead.Invoke();
        Debug.Log("ав╬З╢ы");
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        Dead();
    }


}
