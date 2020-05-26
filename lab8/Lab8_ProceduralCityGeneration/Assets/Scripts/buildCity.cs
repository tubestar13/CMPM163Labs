using System.Collections;
using UnityEngine;

public class buildCity : MonoBehaviour
{
    public GameObject[] buildings;
    public int mapWidth = 20;
    public int mapHeight = 20;
    int buildingFootprint = 4;
    //I like this seed
    float seed = 6;
    // Start is called before the first frame update
    void Start()
    {
        //for random seeding
        //float seed = Random.Range(0, 100);
        //Debug.Log("seed: " + seed);
        for(int h = 0; h < mapHeight; h++)
        {
            for(int w = 0; w < mapWidth; w++)
            {
                int result = (int)(Mathf.PerlinNoise(w/10.0f + seed, h/10.0f + seed) * 10);
                Vector3 pos = new Vector3(w * buildingFootprint, 0, h * buildingFootprint);
                Quaternion rotation = Quaternion.Euler(0, -60, 0);
                

                if (result < 2)
                    Instantiate(buildings[0], pos, rotation);
                else if (result < 4)
                    Instantiate(buildings[1], pos, rotation);
                else if (result < 5)
                    Instantiate(buildings[2], pos, rotation);
                else if (result < 6)
                    Instantiate(buildings[3], pos, rotation);
                else if (result < 7)
                    Instantiate(buildings[4], pos, rotation);
                else if (result < 10)
                    Instantiate(buildings[5], pos, rotation);
            }
        }
    }
}
