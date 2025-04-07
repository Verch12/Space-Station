using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    public Dictionary<KeyCode, Vector3> Direction = new Dictionary<KeyCode, Vector3>() {
        { KeyCode.W, new Vector3(0, 0, 0)},
        { KeyCode.A, new Vector3(0, 1, 0)},
        { KeyCode.S, new Vector3(1, 0, 0)},
        { KeyCode.D, new Vector3(1, 1, 0)},
    };

    void Update()
    {
        if (Input.anyKeyDown && Direction.TryGetValue(KeyTracker.GetLastKeyPressed(), out Vector3 direction))
        {
            transform.localPosition = direction;
        }
    }
}
