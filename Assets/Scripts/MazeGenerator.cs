using UnityEngine;

public class MazeGenerator : MonoBehaviour
{
    public int width = 10;
    public int height = 10;
    public GameObject wallPrefab;

    void Start()
    {
        for (int x = 0; x < width; x++)
            for (int z = 0; z < height; z++)
                if (Random.value > 0.7f)
                    Instantiate(wallPrefab, new Vector3(x, 1, z), Quaternion.identity);
    }
}
