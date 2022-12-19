using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public GameObject enemigo;
    public int tiempo;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawn", tiempo,tiempo);
    }

    
    public void spawn()
    {
        Instantiate(enemigo, gameObject.transform.position, gameObject.transform.rotation);
    }
}
