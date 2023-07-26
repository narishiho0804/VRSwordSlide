using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BatteryScript : MonoBehaviour
{
    public GameObject[] Bullet; // 弾

    public GameObject effect;
    AudioSource sound;

    public float x = 5;
    public float y = 5;

    // Start is called before the first frame update
    void Start()
    {
        sound = GetComponent<AudioSource>();
       InvokeRepeating("Shot", x, y); // 1秒後に1秒ごとにShotを繰り返す 
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Shot() // 弾を発射する処理
    {
        
        int randomIndex = Random.Range(0, Bullet.Length); // ランダムなインデックスを生成

        GameObject selectedBullet = Bullet[randomIndex]; // ランダムに選択されたGameObjectを取得

        GameObject instantiatedBullet = Instantiate(selectedBullet, transform.position, transform.rotation); // 弾を生成する
        Vector3 force = transform.forward * 400; // 弾にかける力を砲台の前方向にする
        instantiatedBullet.GetComponent<Rigidbody>().AddForce(force); // 弾に力をかける
        Instantiate(effect); // 大砲が打った時Effectを出す
        sound.Play(); // 大砲が打った時に音を鳴らせる
        Destroy(instantiatedBullet, 2); // 弾を2秒後に消す
    }
}
