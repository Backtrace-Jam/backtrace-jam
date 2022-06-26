using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    GameObject goCreate;

    [SerializeField]
    float fTimeIntervals;

    [SerializeField]
    Vector3 v3SpawnPosition;

    float fTimer = 0;

    void Start()
    {
        fTimer = fTimeIntervals;
    }

    void Update()
    {
        fTimer -= Time.deltaTime;
        if (fTimer <= 0)
        {
            fTimer = fTimeIntervals;

            Vector3 v3SpawnPos = transform.position;
            v3SpawnPos += Vector3.right * v3SpawnPosition.x * (Random.value - 0.5f);
            v3SpawnPos += Vector3.forward * v3SpawnPosition.z * (Random.value - 0.5f);
            v3SpawnPos += Vector3.up * v3SpawnPosition.y * (Random.value - 0.5f);

            Instantiate(goCreate, v3SpawnPos, Quaternion.identity);
        }
    }
}
