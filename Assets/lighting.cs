using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lighting : MonoBehaviour {

    private Light thislight;
    public void LightA()
    {
        thislight = GetComponent<Light>();
        thislight.enabled = !thislight.enabled;
        Debug.Log(thislight);
    }
}
