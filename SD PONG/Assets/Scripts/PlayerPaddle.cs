using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerPaddle : MonoBehaviour {

    public CharacterController controllPlayer;
    public float moveSpeed =5f;
    private float dirX;

    // Start is called before the first frame update
    void Start()
    {
        controllPlayer = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mov = new Vector3(CrossPlatformInputManager.GetAxis("Horizontal") * moveSpeed,0,0);
        //dirX = CrossPlatformInputManager.GetAxis("Horizontal") * moveSpeed;

        controllPlayer.Move(mov * Time.deltaTime);
    }
}
