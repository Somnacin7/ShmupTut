using UnityEngine;
using System.Collections;

public class ExplodeOnTrigger : MonoBehaviour
{
    public GameObject explode = null;

    // Use this for initialization
    void Start()
    {

    }

    void OnTriggerEnter()
    {
        if (explode != null)
        {
            Instantiate(explode, transform.position, explode.transform.rotation);
        }
        Destroy(gameObject);
    }
}
