using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float _speed = 5f;
    [SerializeField]
    private float _turnSpeed = 3f;
    [SerializeField]
    private GameObject _bigBomb2Prefab;
    [SerializeField]
    private float _fireRate = 0.3f;
    [SerializeField]
    private float _canFire = -1f;
     
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 3.0f, 0);
    }

   
   

    // Update is called once per frame
    void Update()
    {
        CalculateMovement();

        //if I hit e key 
        //spawn bomb
        if (Input.GetKeyDown(KeyCode.E) && Time.time > _canFire) 
        {
            FireBomb();
        }
    }

    void CalculateMovement()

    {
        float horizonal = Input.GetAxis("Mouse X");
        transform.Rotate(horizonal * _turnSpeed * Vector3.up, Space.World);

        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(Vector3.right * Time.deltaTime * _speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(Vector3.left * Time.deltaTime * _speed);
        }
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(Vector3.forward * Time.deltaTime * _speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(Vector3.back * Time.deltaTime * _speed);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            this.transform.Translate(Vector3.down * Time.deltaTime * _speed);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            this.transform.Translate(Vector3.up * Time.deltaTime * _speed);            
        }
       

        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, .9f, 5f), transform.position.z);
      
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -20f, 20f), transform.position.y, transform.position.z);

        transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.Clamp(transform.position.z, -9, 9));
    
    }

    void FireBomb()
    {
        //if I hit e key 
        //spawn bomb
        if (Input.GetKeyDown(KeyCode.E) && Time.time > _canFire)
        {
            _canFire = Time.time + _fireRate;
            Instantiate(_bigBomb2Prefab, transform.position + new Vector3(0, 2f, 0), Quaternion.identity);
        }
    }
        
}
