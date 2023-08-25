using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowAndHide : MonoBehaviour
{
    public GameObject ObjectToTonggle;
    public Button tonggleButton;
    public GameObject ObjectHiede;
    private bool isObjectVisible;
    // Start is called before the first frame update
    void Start()
    {
        tonggleButton.onClick.AddListener(tonggleObjectVisibility);

        isObjectVisible = true;
        
    }

    void tonggleObjectVisibility()
    {
        isObjectVisible = !isObjectVisible;

        ObjectToTonggle.SetActive(isObjectVisible);
    }


   public void HideObject()
   {
    
    ObjectHiede.SetActive(false);

   } 

}
