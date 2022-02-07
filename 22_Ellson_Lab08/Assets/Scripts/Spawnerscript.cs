using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnerscript : MonoBehaviour
{
    //public GameObject SpawnObject;

    float PositionY;

    [SerializeField] GameObject[] RandObjects;

    [SerializeField] float seconSpawn = 0.5f;

    [SerializeField] float minTrans;

    [SerializeField] float maxTrans;

    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("SpawnObjects", 1, 1);

        StartCoroutine(ObjectSpawner());

    }

    // Update is called once per frame
    void Update()
    {
       


    }

    IEnumerator ObjectSpawner()
    {
        while(true)
        {
            var wanted = Random.Range(minTrans, maxTrans);
            var position = new Vector3(wanted, transform.position.y);
            this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);
            PositionY = Random.Range(4, -4f);

            GameObject gameObject = Instantiate(RandObjects[Random.Range(0, RandObjects.Length)], position, Quaternion.identity);
            yield return new WaitForSeconds(seconSpawn);
            Destroy(gameObject, 4f);
        }
    }

    /*void SpawnObjects()
    {
        PositionY = Random.Range(4, -4f);
        this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);
        Instantiate(SpawnObject, transform.position, transform.rotation);
    }*/

}
