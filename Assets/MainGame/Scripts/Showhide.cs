using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Showhide : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public GameObject hiddenObject;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (hiddenObject.active)
            {
                hiddenObject.SetActive(false);
            }
            else
            {
                hiddenObject.SetActive(true);
            }
          // false to hide, true to show

        }
        
    }
}
