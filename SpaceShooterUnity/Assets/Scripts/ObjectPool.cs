/****
 * Created by: Akram Taghavi-Burris
 * Date Created: March 16, 2022
 *
 * Last Edited by: Haley Kelly
 * Last Edited: April 6, 2022
 *
 * Description: pool of prefab objects
****/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{

  static public ObjectPool POOL;

  #region POOL Singleton

  void CheckPoolIsInScene(){
    if(POOL == null){
      POOL = this;
    } else{
      Debug.LogError("NEED LESS POOL PLS");
    }
  }
  #endregion

  private Queue<GameObject> projectiles = new Queue<GameObject>();

  [Header("Pool Settings")]
  public GameObject projectilePrefab;
  public int poolStartSize = 5;

  private void Awake(){
    CheckPoolIsInScene();
  }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
