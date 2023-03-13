using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public static Spawner Instance { get; private set; }

    public GameObject redPlane;
    private Vector3 turretPosition;

    private void Awake()
    {
        if(Instance!= null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }
    public void setTurrePosition(Vector3 p_turretPosition)
    {
        turretPosition = p_turretPosition;
    }
    public void spawnPlane(GameObject plane)
    {
        GameObject planeSpawnPoint = new GameObject();

        float extraHeight = Random.Range(0.5f, 1.5f);

        float extraDepth = Random.Range(0.5f, 1.5f);

        Vector3 planeSpawnPosition = new Vector3(0.0f, this.turretPosition.y + extraHeight, this.turretPosition.z + extraDepth);

        planeSpawnPoint.transform.position = planeSpawnPosition;

        Instantiate(plane, planeSpawnPoint.transform);


    }

    public void spawnRedPlane()
    {
        spawnPlane(redPlane);
    }



}
