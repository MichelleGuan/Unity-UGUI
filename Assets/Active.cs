using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Active : MonoBehaviour {

    public void ActiveScroll()
    {
        gameObject.SetActive(!gameObject.activeSelf);
    }
	
	
}
