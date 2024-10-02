using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationManager : MonoBehaviour
{
    public Dictionary<KeyCode, Vector3> Direction = new Dictionary<KeyCode, Vector3>() {
        { KeyCode.W, new Vector3(0, 0, 0)},
        { KeyCode.A, new Vector3(0, 1, 0)},
        { KeyCode.S, new Vector3(1, 0, 0)},
        { KeyCode.D, new Vector3(1, 1, 0)},
    };
    
    public float speed = 5f;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.anyKeyDown && Direction.TryGetValue(KeyTracker.GetLastKeyPressed(), out Vector3 direction))
        {
            //transform.localPosition = Direction[KeyTracker.GetLastKeyPressed()];
            transform.localPosition = direction;
        }

        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f);
        transform.parent.Translate(movement * speed * Time.deltaTime);
    }
}
