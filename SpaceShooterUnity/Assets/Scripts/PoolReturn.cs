/****
 * Created by: Haley Kelly
 * Last Edited: April 11, 2022
 *
 * Last Edited by: Haley Kelly
 * Last Edited: April 11, 2022
 *
 * Description: return to object pool
****/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolReturn : MonoBehaviour
{
  private ObjectPool pool;


    // Start is called before the first frame update
    void Start()
    {
      pool = ObjectPool.POOL;

    }

    void OnDisable(){
      if (pool != null){
        pool.ReturnObject(this.gameObject);
      }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
