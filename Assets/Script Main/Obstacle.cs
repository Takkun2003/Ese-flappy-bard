using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float destroyXPosition = -20f; // ‰æ–ÊŠO‚Éo‚½‚Æ”»’f‚·‚éˆÊ’u

    void Update()
    {
        transform.Translate(Vector2.left * 2f * Time.deltaTime);

        if (transform.position.x < destroyXPosition)
        {
            Destroy(gameObject);
        }
    }
}
