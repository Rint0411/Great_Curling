using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackFrame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Die", 1.2f);
    }

    private void Die()
    {
        this.gameObject.SetActive(false);
    }
}
