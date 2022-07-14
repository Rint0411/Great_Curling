using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dash : MonoBehaviour
{
    public GameObject main,fx,btn;
    int Power =0,up = 1;
    public Text t;
    public void speedUp()
    {
        Time.timeScale = 0.1f;
        StartCoroutine("Ne");
        Destroy(btn);
        SoundMng.instance.PlaySe(0);

    }

    IEnumerator Ne()
    {
        while(true)
        {
            if (Power >= 100)
            {
                up = -1;
            }
            if (Power <= 0)
            {
                up = 1;
            }
            Power += up;

            t.text = Power + "%";

            if (Input.GetMouseButtonUp(0))
            {
                SoundMng.instance.PlaySe(7);
                main.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, 0, Power/30), ForceMode.Impulse);
                GameObject set = Instantiate(fx);
                Destroy(set, 1);
                set.transform.position = main.transform.position;
                Time.timeScale = 0.7F;
                Destroy(this.gameObject);
                break;
            }

            yield return new WaitForSeconds(0.001f);
        }
    }
}
