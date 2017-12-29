using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class option : MonoBehaviour {

    bool optionA;
    bool optionB;
    bool optionC;
    GameObject gameobject;
    void Update()
    {
        optionchoose();
    }
    public void optionchoose()
    {
        Toggle[] toggle = GetComponent<ToggleGroup>().GetComponentsInChildren<Toggle>();
        for (int i = 0; i < toggle.Length;i++ )
        {//遍历这个存放Toggle的按钮组IEnumerable，此乃C#的一个枚举集合，一般直接用foreach遍历    
            if (toggle[0].isOn)
            {
                GameObject.Find("InputArea").GetComponentInChildren<Text>().text = "你选择了OptionA";
            }
            else if (toggle[1].isOn)
            {
                GameObject.Find("InputArea").GetComponentInChildren<Text>().text = "你选择了OptionB";
            }
            else if (toggle[2].isOn)
            {
                GameObject.Find("InputArea").GetComponentInChildren<Text>().text = "你选择了OptionC";
            }
            else
            {
                GameObject.Find("InputArea").GetComponentInChildren<Text>().text = "选一个吧，客官QaQ";
            }
        }     
      }


}
