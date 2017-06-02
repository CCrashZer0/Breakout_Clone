using UnityEngine;
using System.Collections;

public class TimeDestory : MonoBehaviour
{

    public float destoryTime = 1f;

	// Use this for initialization
	void Start ()
    {
        Destroy(gameObject, destoryTime);
	}
}
