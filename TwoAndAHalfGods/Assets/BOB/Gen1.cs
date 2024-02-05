using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


public class Gen1 : MonoBehaviour
{
    public GameObject x;
    


    List<GameObject> landpoints = new List<GameObject>();
  GameObject hold = null;
    private GameObject a;





    // Start is called before the first frame update
    void Start()
    {
        float y = 0;
        int i= 0;
        while (i < 3600)
            {
            
                hold = (Instantiate(x, new Vector3((i / 60) * 10f, 0 , (i % 60) * 10f),Quaternion.identity)) as GameObject;
                landpoints.Add(hold);
                print(hold.transform.position);
                i++;
        }




            //transform.position = new Vector3(-300, 0, 0);
            
            //Instantiate(X, this.transform);
            //transform.position = new Vector3(-200, 0, 0);
            //Instantiate(X, this.transform);
            //transform.position = new Vector3(-100, 0, 0);
            //Instantiate(X, this.transform);
            //transform.position = new Vector3(-000, 0, 0);
            //Instantiate(X,this.transform);
          
    }

    // Update is called once per frame
    void Update()
    {
  


    }
}
