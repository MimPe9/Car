using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarLight : MonoBehaviour
{
    public GameObject light;
    //public GameObject gameObject;

    /*void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            light.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            light.SetActive(false);
        }
    }*/
    /*void Start()
    {
        light = GetComponent<GameObject>();
    }*/

 
    public void Activelight()
    {
        light.SetActive(true);
    }

    public void inActivelight()
    {
        light.SetActive(false);
    }

    public void ActiveColor(Material material)
    {
        gameObject.GetComponent<Renderer>().material = material;
    }

    public void inActiveColor(Material material)
    {
        gameObject.GetComponent<Renderer>().material = material;
    }



}
