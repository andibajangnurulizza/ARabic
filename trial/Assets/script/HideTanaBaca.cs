using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HideTanaBaca : MonoBehaviour
{
    public GameObject HideBaca1;
    public GameObject HideBaca2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HideBacaTanda()
    {
        HideBaca1.SetActive(false);
        HideBaca2.SetActive(false);

    }

}
