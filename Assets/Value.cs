using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Value : MonoBehaviour 
{
	// Use this for initialization
    Dropdown dropdown;
    float value;
    void Start()
    {
       GameObject dropdownItem = GameObject.Find("Dropdown");
       dropdown = dropdownItem.GetComponent<Dropdown>();
     //  rotate=GameObject.Find("vehicle_rcFlyer_clean").transform.rotation.y;
       
    }
    void Update()
    { 
        rotation();
        

        //Debug.Log(rotate);
    }
  
 public void top_end()
 {
     value = GetComponentInChildren<Scrollbar>().value;
       if (value <= 0.5)
        {
           GetComponentInChildren<Scrollbar>().value = 1;
        }
        if (dropdown.value > 0.5)
        {
            GetComponentInChildren<Scrollbar>().value = 0;
        }
  }
 public void rotation()
 {

     value = GetComponentInChildren<Scrollbar>().value;
     float y = value * 360;
     GameObject.Find("vehicle_rcFlyer_clean").transform.rotation= Quaternion.Euler(0, y, 0);
 }
 
}