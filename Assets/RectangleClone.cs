using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RectangleClone : MonoBehaviour
{
    public GameObject objectPrefab;
    public static GameObject cloneObject;
    public float timee = 0;
    public Text timeText;

    void Start()
    {
        Vector2 randomSpawnPosition = new Vector2(-6, Random.Range(-2.25f, 0.25f));
        cloneObject = Instantiate(objectPrefab, randomSpawnPosition, Quaternion.identity);
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (cloneObject.GetComponent<Transform>().position.x > -1.5f)
        {
            Vector2 randomSpawnPosition = new Vector2(-4, Random.Range(-2.25f, 0.25f));
            cloneObject = Instantiate(objectPrefab, randomSpawnPosition,Quaternion.identity);
        }
        timeText.text = timee.ToString();
        timee = Time.time;

    }
}
