using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeController : MonoBehaviour
{
    public float scrollSpeed;

    void Start()
    {
        var randomY = Random.Range(-2.25f, 2.25f);
        transform.position = new Vector2(transform.position.x, randomY);
    }

    void Update()
    {
        transform.position += transform.right * Time.deltaTime * -scrollSpeed;

        if (transform.position.x < -20)
        {
            var randomY = Random.Range(-2.25f, 2.25f);
            transform.position = new Vector2(18, randomY);
        }
    }
}
