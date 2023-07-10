using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BigBomb2 : MonoBehaviour
{
    [SerializeField]
    private float _speed = 8f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //translate bomb down
        transform.Translate(Vector3.down * _speed * Time.deltaTime);
        if (transform.position.y <= -.28f)
        {
            Destroy(gameObject);
        }
    }
}
