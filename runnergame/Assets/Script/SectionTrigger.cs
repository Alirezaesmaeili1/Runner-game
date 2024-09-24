using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SectionTrigger : MonoBehaviour
{
    [SerializeField]
    GameObject sectionChunk;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ChunkTrigger"))
        {
            Instantiate(sectionChunk,new Vector3(-10, 0, 0),Quaternion.identity);
        }
    }
}
