using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform point1;
    public Transform point2;
    public Vector3 spawnPosition;
    public GameObject enemy;
    void OnGUI()
    {
        float scrW = Screen.width / 16;
        float scrH = Screen.height / 9;
        if (GUI.Button(new Rect(6 * scrW, 6 * scrH, 4 * scrW, 1 * scrH), "Spawn bois"))
        {
            Spawn();
        }

    }
    void Spawn()
    {
        Vector3 pos = Vector3.Lerp(point1.position, point2.position, Random.value);
        Vector3 separation = point2.position - point1.position;
        //rotation facing from v1 to v2
        
        //spawn
        GameObject copy = Instantiate(enemy, pos, Quaternion.identity);
    }
}