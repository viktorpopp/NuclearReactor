using UnityEngine;

public class Cell : MonoBehaviour
{
    public GameObject uranium;

    private void Update()
    {
        if (transform.Find("Uranium-235") == null)
        {
            if (Random.value < 0.1f * Time.deltaTime)
            {
                GameObject newChild = Instantiate(uranium, transform);
                newChild.name = "Uranium-235";
            }
        }
    }
}
