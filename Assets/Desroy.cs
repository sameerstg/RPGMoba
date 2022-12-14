using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desroy : MonoBehaviour
{
    public float time;
    IEnumerator Start()
    {
        yield return new WaitForSeconds(time);
        Destroy(this.gameObject);
    }
}
