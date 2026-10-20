using UnityEngine;

public class Clone : MonoBehaviour
{
    float time = 0;
    public GameObject mother; //the GO to clone
    GameObject[] clones; // array of GOs to be cloned
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    int numberOfCollectibles = 30;
    void Start()
    {
        clones = new GameObject[numberOfCollectibles];

        for(int i = 0; i < numberOfCollectibles; i++)
        {
            clones[i] = GameObject.Instantiate(mother);
            clones[i].transform.position = new Vector3(0, 2, i); // x, y, z
        }
    }

    private void FixedUpdate()
    {
        time += Time.fixedDeltaTime;
        for(int i = 0; i < numberOfCollectibles; i++)
        {
            float x = 0.05f * Mathf.Sin(time + i);
            clones[i].transform.position += new Vector3(x, 0, 0.1f); // why does this syntax work??? += on classes? huh???
        }
    }
}
