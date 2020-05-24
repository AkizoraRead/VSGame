using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    AsyncOperation asncy;
    GameObject  loadCanvas;     //ロードする際に変化するオブジェクト
    Slider      loadGage;       //ロード具合のわかるゲージ

    private void Start()
    {

        this.loadCanvas = GameObject.Find("LoadCanvas");
        this.loadGage = this.loadCanvas.transform.Find("LoadGage").GetComponent<Slider>();

        this.loadCanvas.SetActive(false);
    }


    //シーンを変える際の処理
    public void NextScene(string name)
    {
        //ロード表示
        this.loadCanvas.SetActive(true);

        StartCoroutine(LoadScene(name));
    }

    //シーンをロード、完了したら切り替わる
    //引数（次のシーンの名前）
    IEnumerator LoadScene(string name)
    {
        //開始処理
        this.loadGage.value = 0.0f;
        yield return new WaitForSeconds(0.1f);
        this.asncy = SceneManager.LoadSceneAsync(name);
        this.asncy.allowSceneActivation = false;

        //ロード処理
        while(this.asncy.progress < 0.9f)               
        {
            //ロード具合によってゲージが変動
            this.loadGage.value = this.asncy.progress;
            yield return null;
        }

        //完了処理
        this.loadGage.value = 1.0f;
        yield return new WaitForSeconds(0.5f);
        this.asncy.allowSceneActivation = true;

    }
}
