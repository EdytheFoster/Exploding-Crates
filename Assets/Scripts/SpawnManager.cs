using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _solidCratePrefab;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //spawn game objects every 5 seconds
    IEnumerator SpawnRoutine()
    {
        while (true) 
        {
            Vector3 posToSpawn = new Vector3(Random.Range(-20f,20f), 11, Random.Range(-9f, 9f));
            Instantiate(_solidCratePrefab, posToSpawn, Quaternion.identity);
            yield return new WaitForSeconds(5.0f);
        }
        //while loop infinite
            //instantiate solid crate prefab
            //yield wait for 5 seconds

    }
}
