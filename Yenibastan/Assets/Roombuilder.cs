using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roombuilder : MonoBehaviour
{
    public int width;
     public int length;
     public int random1;
     public Transform prefab;
    // Start is called before the first frame update
    void Start()
    {
        int maxx = width;
        int minx = -1*width;
        int maxz = length;
        int minz = -1*length;
        int random = Random.Range(1, 3);
         Debug.Log(random);
        for (int x = 0; x < maxx; x++)
        {
            Instantiate(prefab, new Vector3(x, 0, maxz), Quaternion.identity);
        }
        for (int x = 0; x < maxx; x++)
        {
            Instantiate(prefab, new Vector3(-1*x, 0, maxz), Quaternion.identity);
        }
        for (int x = 0; x < maxx; x++)
        {
            Instantiate(prefab, new Vector3(x, 0, minz), Quaternion.identity);
        }
        for (int x = 0; x < maxx; x++)
        {
            Instantiate(prefab, new Vector3(-1*x, 0, minz), Quaternion.identity);
        }
        for (int z = 0; z < maxz; z++)
        {
            Instantiate(prefab, new Vector3(maxx, 0, z), Quaternion.identity);
        }
        for (int z = 0; z < maxz; z++)
        {
            Instantiate(prefab, new Vector3(maxx, 0, -1*z), Quaternion.identity);
        }
        for (int z = 0; z < maxz; z++)
        {
            Instantiate(prefab, new Vector3(minx, 0, z), Quaternion.identity);
        }
        for (int z = 0; z < maxz; z++)
        {
            Instantiate(prefab, new Vector3(minx, 0, -1*z), Quaternion.identity);
        }


        for (int i=0;i<5;i++)
        {




        if (random==1)
        {
           random1 = Random.Range(minx+15, maxx-15);
           for (int z = minz; z < maxz; z++)
            {
            Instantiate(prefab, new Vector3(random1, 0, z), Quaternion.identity);
             }
            if(random1<0)
            {
                minx=random1;
            }
            if(random1>0)
            {
                maxx=random1;
            }

          

        }


        if (random==2)
        {
           random1 = Random.Range(minz+15, maxz-15);
           for (int x = minx; x < maxx; x++)
            {
            Instantiate(prefab, new Vector3(x, 0, random1), Quaternion.identity);
             }
              if (random1<0)
              {
              minz = random1;

              }
              if (random1>0)
              {
              maxz = random1;
              }
         
        }

        if (random==1)
        {
            random=2;
        }
        else
        {
            random=1;
        }




        }





    }
}

