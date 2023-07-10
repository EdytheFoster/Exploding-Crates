using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Crate : MonoBehaviour
{
    [SerializeField]
    private GameObject _fracturedCratePrefab;
    [SerializeField]
    private float _speed = 50f;
    [SerializeField]
    private GameObject _explosionPrefab;

    


    // Start is called before the first frame update
    void Start()
    {
             
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * _speed * Time.deltaTime);

        if (transform.position.y <= -.28f)
        {
            transform.position = new Vector3(transform.position.x, -.28f, transform.position.z);
        }
    }
    void OnTriggerEnter(Collider other) 
    { 
        if (other.CompareTag("BigBomb2"))
        {
            Instantiate(_fracturedCratePrefab, transform.position, Quaternion.identity);
            Instantiate(_explosionPrefab, transform.position, Quaternion.identity);
            

            Destroy(this.gameObject);
            

        }             
    }
  
}
