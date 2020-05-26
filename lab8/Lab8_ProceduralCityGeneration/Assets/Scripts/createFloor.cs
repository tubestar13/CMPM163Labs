using System.Collections;
using UnityEngine;

public class createFloor : MonoBehaviour
{
    public int mapWidth = 20;
    public int mapHeight = 20;
    public GameObject floor;
    public GameObject floorManager;
    int scale = 4;
    // Start is called before the first frame update
    void Start()
    {
        for(int h = 0; h < mapWidth; h++)
        {
            for(int w = 0; w < mapHeight; w++)
            {
                Vector3 pos = new Vector3(floorManager.transform.position.x + w * scale, 
                                          floorManager.transform.position.y, 
                                          floorManager.transform.position.z + h * scale);
                Instantiate(floor, pos, Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
