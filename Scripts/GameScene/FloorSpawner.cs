using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorSpawner : MonoBehaviour
{
   public GameObject Floors;
    Transform tr;
   public int floorNumber;
   public float floorWidth;
   public float miny,maxy;
   private void Start()
   {
       tr=Floors.GetComponent<Transform>();
       Vector3 spawnLoc=new Vector3();
       //Vector2 newScale=new Vector2();

       for(int i=0;i<floorNumber;i++)
       {
         //  newScale.x=Random.Range(0.9f,1.1f);
           //newScale.y=Random.Range(0.9f,1.1f);
           //tr.localScale=newScale;
           spawnLoc.y+=Random.Range(miny,maxy);
           spawnLoc.x+=Random.Range(-floorWidth,floorWidth);

           Instantiate(Floors,spawnLoc,Quaternion.identity);


       }
   }
}
