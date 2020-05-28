using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectDirector : MonoBehaviour
{
    SceneChange sceneClass; //シーン移動のクラス


    // Start is called before the first frame update
    void Start()
    {
        this.sceneClass = transform.GetComponent<SceneChange>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown) { this.sceneClass.NextScene("SelectScene"); }
    }
}
