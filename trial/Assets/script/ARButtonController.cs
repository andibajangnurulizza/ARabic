using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class ARButtonController : MonoBehaviour
{
    public GameObject objectToToggle;
    public GameObject buttonObject;
    private bool isMarkerDetected;

    void Start()
    {
        // Menyembunyikan tombol saat memulai
        //buttonObject.SetActive(false);
    }

    void Update()
    {
        if (isMarkerDetected)
        {
            // Mendapatkan posisi objek AR dalam dunia
            Vector3 objectPosition = transform.position;

            // Mendapatkan posisi layar (posisi tombol dalam tampilan kamera)
            Vector3 screenPosition = Camera.main.WorldToScreenPoint(objectPosition);

            // Memperbarui posisi tombol sesuai dengan posisi layar
            RectTransform buttonRectTransform = buttonObject.GetComponent<RectTransform>();
            buttonRectTransform.position = screenPosition;
        }
    }

    public void OnButtonPressed()
    {
        // Tombol virtual ditekan, sembunyikan objek 3D
        objectToToggle.SetActive(false);
    }

    public void OnButtonReleased()
    {
        // Tombol virtual dilepas, tampilkan kembali objek 3D
        objectToToggle.SetActive(true);
    }

    public void OnMarkerDetected()
    {
        // Marker terdeteksi, tampilkan tombol
        isMarkerDetected = true;
        buttonObject.SetActive(true);
    }

    public void OnMarkerLost()
    {
        // Marker hilang, sembunyikan tombol
        isMarkerDetected = false;
        buttonObject.SetActive(false);
    }
}
