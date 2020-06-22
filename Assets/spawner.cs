using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject theobject;
    public GameObject[] myObjects;
    public float positionY;
    public float positionZ;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //int randomIndex = Random.Range(0, myObjects.Length);
        //positionY = Random.Range(4, -4f);
        // this.transform.position = new Vector3(transform.position.x, positionY, transform.position.z);
        // Instantiate(myObjects[randomIndex], transform.position, transform.rotation);


        int randomIndex = Random.Range(0, myObjects.Length);
        positionZ = Random.Range(15, 50);
        this.transform.position = new Vector3(transform.position.x,transform.position.y, positionZ);
        Instantiate(myObjects[randomIndex], transform.position, transform.rotation);

    }
}
