using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;
    public  float spawny;
    void Start()
    {
        //spawncolumn();
    }

   
      void spawncolumn()
    {
        spawny = Random.Range(-1.54f, 3.42f);
        Instantiate(prefab, new Vector2(4f, spawny), Quaternion.identity);
    }

    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Columns>() != null)
        {
            spawncolumn();
        }
    }*/
}
