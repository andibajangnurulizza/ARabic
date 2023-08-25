using UnityEngine;

public class ParticleSpawner : MonoBehaviour
{
    public GameObject particlePrefab;  // Partikel prefab
    private int childCount = 0;  // Jumlah child yang sudah muncul

    void SpawnParticlePrefab()
    {
        if (childCount == 5)
        {
            Instantiate(particlePrefab, transform.position, Quaternion.identity);
            // Ubah posisi dan rotasi sesuai kebutuhan Anda
        }
    }

    public void IncreaseChildCount()
    {
        childCount++;
        SpawnParticlePrefab();
    }
}
