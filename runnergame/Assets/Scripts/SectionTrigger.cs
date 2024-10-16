using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SectionTrigger : MonoBehaviour
{
    [SerializeField]
    List<GameObject> sectionChunks;

    GameObject sectionChunk;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ChunkTrigger"))
        {
            sectionChunk = sectionChunks.OrderBy(x => System.Guid.NewGuid()).FirstOrDefault();
            Instantiate(sectionChunk,new Vector3(-10, 0, 0),Quaternion.identity);
        }
    }

}
