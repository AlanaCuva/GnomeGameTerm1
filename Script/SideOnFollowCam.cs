using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideOnFollowCam : MonoBehaviour
{
    public MyCharacter _Character;
    public float _Lag=1.0f; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 NewCamPos = transform.position;
        NewCamPos.x=_Character.transform.position.x;
        transform.position = Vector3.Lerp(transform.position,NewCamPos, _Lag);
    }
}
