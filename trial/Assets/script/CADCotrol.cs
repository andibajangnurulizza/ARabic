using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CADCotrol : MonoBehaviour
{
    private const int V = 6;
    public GameObject[] item;
    public GameObject[] itemDrop;

    public int jarak;
    public Vector2[] itemPos;
    public AudioClip[] audioClips; //array audio

    private AudioSource audioSource; //komponen AudioSource

    // Jumlah drop yang diperlukan untuk mengaktifkan child
    public int targetDropCount = 5; // Jumlah drop yang diperlukan untuk mengaktifkan child
    public int targetDropCount2 = 10; // Jumlah drop yang diperlukan untuk mengaktifkan child
    public int targetDropCount3 = 15; // Jumlah drop yang diperlukan untuk mengaktifkan child
    public int targetDropCount4 = 20; // Jumlah drop yang diperlukan untuk mengaktifkan child
    public int targetDropCount5 = 25; // Jumlah drop yang diperlukan untuk mengaktifkan child
    public int targetDropCount6 = 30; 
    
    // Jumlah drop saat ini
    private int currentDropCount = 0; 
    private int currentDropCount2 = 0;
    private int currentDropCount3 = 0;
    private int currentDropCount4 = 0;
    private int currentDropCount5 = 0;
    private int currentDropCount6 = 0;
   
   
    public GameObject childObjectToActivate1;
    public GameObject childObjectToDeactivate1;
    public GameObject childObjectToActivate2;
    public GameObject childObjectToDeactivate2;
    public GameObject childObjectToActivate3;
    public GameObject childObjectToDeactivate3;
    public GameObject childObjectToActivate4;
    public GameObject childObjectToDeactivate4;
    public GameObject childObjectToActivate5;
    public GameObject childObjectToDeactivate5;
    public GameObject childObjectToActivate6;
    public GameObject childObjectToDeactivate6;

    public GameObject PopUP, PopUP2, PopUP3, PopUP4, PopUP5, PopUP6, PopUP7;
    private int totalChildObjects = 6; // Jumlah total child objects
    public GameObject Selesai;


    public void Start()
    {
        itemPos = new Vector2[item.Length];
        audioSource = GetComponent<AudioSource>(); //Mendapatkan komponen AudioSource

        for (int i = 0; i < item.Length; i++)
        {
            itemPos[i] = item[i].transform.localPosition;            
        }    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ItemDrag(int number)
    {
        item[number].transform.position = Input.mousePosition;
    }

    public void ItemEndDrag(int number)
    {
        float distance = Vector3.Distance(item[number].transform.localPosition, itemDrop[number].transform.localPosition);
        if (distance < jarak)
        {
            item[number].transform.localPosition = itemDrop[number].transform.localPosition;
            if(number < audioClips.Length)
            {
                audioSource.PlayOneShot(audioClips[number]);
            }    
            currentDropCount++;
            currentDropCount2++;
            currentDropCount3++;
            currentDropCount4++;
            currentDropCount5++;
            currentDropCount6++;
            
        // Cek jika mencapai jumlah drop yang diperlukan
        if (currentDropCount >= targetDropCount)
        {
            StartCoroutine(ActivateChildWithDelay2(PopUP, 1f));
            StartCoroutine(ActivateChildWithDelay(childObjectToActivate1, childObjectToDeactivate1, 2f));
            //StartCoroutine(ActivateChildWithDelay3(PopUp,2f));
        }

        if (currentDropCount2 >= targetDropCount2)
        {
            StartCoroutine(ActivateChildWithDelay3(PopUP2,1f));
            StartCoroutine(ActivateChildWithDelay(childObjectToActivate2, childObjectToDeactivate2, 2f));
            //StartCoroutine(ActivateChildWithDelay3(PopUp,2f));
        }
        if (currentDropCount3 >= targetDropCount3)
        {
            StartCoroutine(ActivateChildWithDelay5(PopUP3,1f));
            StartCoroutine(ActivateChildWithDelay0(childObjectToActivate3, childObjectToDeactivate3, 2f));
            //StartCoroutine(ActivateChildWithDelay3(PopUp,2f));
        }
        if (currentDropCount4 >= targetDropCount4)
        {
            //childObjectToDeactivate3.SetActive(false);
            StartCoroutine(ActivateChildWithDelay6(PopUP4,1f));
            StartCoroutine(ActivateChildWithDelay0(childObjectToActivate4, childObjectToDeactivate4, 2f));
            //StartCoroutine(ActivateChildWithDelay3(PopUp,2f));
        }
        if (currentDropCount5 >= targetDropCount5)
        {
           StartCoroutine(ActivateChildWithDelay7(PopUP5,1f));
            StartCoroutine(ActivateChildWithDelay0(childObjectToActivate5, childObjectToDeactivate5, 2f));
            //StartCoroutine(ActivateChildWithDelay3(PopUp,2f));
        }
        if (currentDropCount6 >= targetDropCount6)
        {
            StartCoroutine(ActivateChildWithDelay7(PopUP6,1f));
            StartCoroutine(ActivateChildWithDelay0(Selesai, childObjectToDeactivate6, 2f));
            //Memuat ulang scene setelah mencapai targetDropCount6
            //float resetDelay = 0f; // Jeda waktu sebelum mereset scene (dalam detik)
            //ResetSceneWithDelay(delay);
            //Invoke("ResetSceneWithDelay", resetDelay);
        }
        


            

            // // Cek jika mencapai jumlah drop yang diperlukan
            // if (currentDropCount >= targetDropCount)
            // {
            //     PopUp.SetActive(true);
            //     // Aktifkan child setelah mencapai jumlah drop yang diperlukan
            //     childObjectToActivate1.SetActive(true);
            //     childObjectToDeactivate1.SetActive(false);
            // }     

            // if (currentDropCount2 >= targetDropCount2)
            // {
            //     childObjectToActivate2.SetActive(true);
            //     childObjectToDeactivate2.SetActive(false);
            // }
            //     if (currentDropCount3 >= targetDropCount3)
            // {
            //     childObjectToActivate3.SetActive(true);
            //     childObjectToDeactivate3.SetActive(false);
            // }
            //     if (currentDropCount4 >= targetDropCount4)
            // {
            //     childObjectToActivate4.SetActive(true);
            //     childObjectToDeactivate4.SetActive(false);
            // }
            //     if (currentDropCount5 >= targetDropCount5)
            // {
            //     childObjectToActivate5.SetActive(true);
            //     childObjectToDeactivate5.SetActive(false);
            // }
            //     if (currentDropCount6 >= targetDropCount6)
            // {
            //     //childObjectToActivate6.SetActive(true);      
            //     childObjectToDeactivate6.SetActive(false);

            //     // Memuat ulang scene setelah mencapai targetDropCount6
            //     float resetDelay = 0f; // Jeda waktu sebelum mereset scene (dalam detik)
            //     //ResetSceneWithDelay(delay);
            //     Invoke("ResetSceneWithDelay", resetDelay);
            // }
        }
        else
        {
            item[number].transform.localPosition = itemPos[number];
        }
    }

   private IEnumerator ActivateChildWithDelay(GameObject activateObj, GameObject deactivateObj, float delay)
{
    yield return new WaitForSeconds(delay);

    activateObj.SetActive(true);
    deactivateObj.SetActive(false);

   // PopUP2.SetActive(false);
}
   private IEnumerator ActivateChildWithDelay0(GameObject activateObj2, GameObject deactivateObj2, float delay)
{
    yield return new WaitForSeconds(delay);

    activateObj2.SetActive(true);
    deactivateObj2.SetActive(false);

   // PopUP2.SetActive(false);
}


private IEnumerator ActivateChildWithDelay2(GameObject PopUP, float delay)
{
    yield return new WaitForSeconds(delay);

    PopUP.SetActive(true);
   //PopUP2.SetActive(true);
   // PopUP3.SetActive(true);
   // PopUP4.SetActive(true);
   // PopUP5.SetActive(true);
   // PopUP6.SetActive(true);
}
private IEnumerator ActivateChildWithDelay3(GameObject PopUP2, float delay)
{
    yield return new WaitForSeconds(delay);

    //PopUP.SetActive(true);
   PopUP2.SetActive(true);
   // PopUP3.SetActive(true);
   // PopUP4.SetActive(true);
   // PopUP5.SetActive(true);
   // PopUP6.SetActive(true);
}
private IEnumerator ActivateChildWithDelay5(GameObject PopUP3, float delay)
{
    yield return new WaitForSeconds(delay);

    //PopUP.SetActive(true);
   //PopUP2.SetActive(true);
   PopUP3.SetActive(true);
   // PopUP4.SetActive(true);
   // PopUP5.SetActive(true);
   // PopUP6.SetActive(true);
}
private IEnumerator ActivateChildWithDelay6(GameObject PopUP4, float delay)
{
    yield return new WaitForSeconds(delay);

    //PopUP.SetActive(true);
   //PopUP2.SetActive(true);
   //PopUP3.SetActive(false);
   PopUP4.SetActive(true);
   // PopUP5.SetActive(true);
   // PopUP6.SetActive(true);
}
private IEnumerator ActivateChildWithDelay7(GameObject PopUP5, float delay)
{
    yield return new WaitForSeconds(delay);

    //PopUP.SetActive(true);
   //PopUP2.SetActive(true);
   //PopUP3.SetActive(true);
   // PopUP4.SetActive(true);
   PopUP5.SetActive(true);
   // PopUP6.SetActive(true);
}
private IEnumerator ActivateChildWithDelay8(GameObject PopUP6, float delay)
{
    yield return new WaitForSeconds(delay);

    //PopUP.SetActive(true);
   //PopUP2.SetActive(true);
   //PopUP3.SetActive(true);
   // PopUP4.SetActive(true);
   // PopUP5.SetActive(true);
   PopUP6.SetActive(true);
}

private IEnumerator SelesaiDelay(GameObject PopUP7, float delay)
{
    yield return new WaitForSeconds(delay);

    PopUP7.SetActive(true);
}

    private void ResetSceneWithDelay()
    {
        float resetDelay = 2f; // Jeda waktu sebelum mereset scene (dalam detik)
        Invoke("ResetScene", resetDelay);
    }

    private void ResetScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
}