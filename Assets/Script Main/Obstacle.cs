using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float destroyXPosition = -20f; // ��ʊO�ɏo���Ɣ��f����ʒu

    void Update()
    {
        transform.Translate(Vector2.left * 2f * Time.deltaTime);

        if (transform.position.x < destroyXPosition)
        {
            Destroy(gameObject);
        }
    }
}
