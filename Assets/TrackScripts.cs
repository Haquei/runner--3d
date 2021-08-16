using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackScripts : MonoBehaviour
{
    public GameObject[] Tracks;
    public GameObject Main;
    public GameObject Temp;
    // Start is called before the first frame update
    void Start()
    {
        Main = Instantiate(Tracks[0], new Vector3(0, 0, 0), Quaternion.identity);
    }
    private void Update()
    {
        Debug.Log(Mathf.Round(this.transform.position.z));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            int Index = Random.Range(0, Tracks.Length);
            Temp = Main;
            Main = Instantiate(Tracks[Index], new Vector3(0,0,Main.transform.position.z + 107), Quaternion.identity);
            Destroy(Temp, 12);
        }
    }


}
