using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGenerator : MonoBehaviour
{
    public GameObject floorTile;
    public int width;
    public int height;

    // Start is called before the first frame update
    void Start()
    {
        for (int w = 0; w < width; w++) 
        {
            for (int h = 0; h < height; h++) 
            {
                Vector3 floorPosition = new Vector3(w * 4.7f, h * 4.02f, 0);
                Instantiate(floorTile, floorPosition, Quaternion.identity, transform);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
