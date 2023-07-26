using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BatteryScript : MonoBehaviour
{
    public GameObject[] Bullet; // �e

    public GameObject effect;
    AudioSource sound;

    public float x = 5;
    public float y = 5;

    // Start is called before the first frame update
    void Start()
    {
        sound = GetComponent<AudioSource>();
       InvokeRepeating("Shot", x, y); // 1�b���1�b���Ƃ�Shot���J��Ԃ� 
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Shot() // �e�𔭎˂��鏈��
    {
        
        int randomIndex = Random.Range(0, Bullet.Length); // �����_���ȃC���f�b�N�X�𐶐�

        GameObject selectedBullet = Bullet[randomIndex]; // �����_���ɑI�����ꂽGameObject���擾

        GameObject instantiatedBullet = Instantiate(selectedBullet, transform.position, transform.rotation); // �e�𐶐�����
        Vector3 force = transform.forward * 400; // �e�ɂ�����͂�C��̑O�����ɂ���
        instantiatedBullet.GetComponent<Rigidbody>().AddForce(force); // �e�ɗ͂�������
        Instantiate(effect); // ��C���ł�����Effect���o��
        sound.Play(); // ��C���ł������ɉ���点��
        Destroy(instantiatedBullet, 2); // �e��2�b��ɏ���
    }
}
