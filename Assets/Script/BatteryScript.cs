using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BatteryScript : MonoBehaviour
{
    public GameObject[] Bullet; // ’e

    public GameObject effect;
    AudioSource sound;

    public float x = 5;
    public float y = 5;

    // Start is called before the first frame update
    void Start()
    {
        sound = GetComponent<AudioSource>();
       InvokeRepeating("Shot", x, y); // 1•bŒã‚É1•b‚²‚Æ‚ÉShot‚ğŒJ‚è•Ô‚· 
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Shot() // ’e‚ğ”­Ë‚·‚éˆ—
    {
        
        int randomIndex = Random.Range(0, Bullet.Length); // ƒ‰ƒ“ƒ_ƒ€‚ÈƒCƒ“ƒfƒbƒNƒX‚ğ¶¬

        GameObject selectedBullet = Bullet[randomIndex]; // ƒ‰ƒ“ƒ_ƒ€‚É‘I‘ğ‚³‚ê‚½GameObject‚ğæ“¾

        GameObject instantiatedBullet = Instantiate(selectedBullet, transform.position, transform.rotation); // ’e‚ğ¶¬‚·‚é
        Vector3 force = transform.forward * 400; // ’e‚É‚©‚¯‚é—Í‚ğ–C‘ä‚Ì‘O•ûŒü‚É‚·‚é
        instantiatedBullet.GetComponent<Rigidbody>().AddForce(force); // ’e‚É—Í‚ğ‚©‚¯‚é
        Instantiate(effect); // ‘å–C‚ª‘Å‚Á‚½Effect‚ğo‚·
        sound.Play(); // ‘å–C‚ª‘Å‚Á‚½‚É‰¹‚ğ–Â‚ç‚¹‚é
        Destroy(instantiatedBullet, 2); // ’e‚ğ2•bŒã‚ÉÁ‚·
    }
}
