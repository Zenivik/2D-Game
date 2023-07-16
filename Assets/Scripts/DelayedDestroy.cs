using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedDestroy : MonoBehaviour
{
    public float destroyEffectTimer = 0.03f;

    void Update()
    {
        if (destroyEffectTimer <= 0)
        {
            Destroy(gameObject);
        }

        destroyEffectTimer -= 0.1f * Time.deltaTime;
    }
}
