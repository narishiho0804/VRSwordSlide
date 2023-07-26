using EzySlice;
using Oculus.Interaction.Throw;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SliceObject : MonoBehaviour
{
    public Transform startSlicePoint;
    public Transform endSlicePoint;
    public VelocityEstimator velocityEstimator;
    public LayerMask sliceableLayer;

    public Material crossSectionMaterial;
    public float cutForce = 2000;

    public Text ScoreText;
    private int score = 1;

    AudioSource sound;

    // Start is called before the first frame update
    void Start()
    {
        sound = GetComponent<AudioSource>();
        score = 1;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        bool hasHit = Physics.Linecast(startSlicePoint.position, endSlicePoint.position, out RaycastHit hit, sliceableLayer);
        if (hasHit)
        {
            GameObject target = hit.transform.gameObject;
            Slice(target);
        }
    }
    public void Slice(GameObject taget)
    {
        Vector3 velocity = velocityEstimator.GetVelocityEstimate();
        Vector3 planeNormal = Vector3.Cross(endSlicePoint.position - startSlicePoint.position, velocity);
        planeNormal.Normalize();

        SlicedHull hull = taget.Slice(endSlicePoint.position ,planeNormal);

        if(hull != null)
        {
            GameObject upperHull = hull.CreateUpperHull(taget, crossSectionMaterial);
            SetupSliedComponnt(upperHull);

            GameObject loverHull = hull.CreateLowerHull(taget, crossSectionMaterial);
            SetupSliedComponnt(loverHull);

            Destroy(taget);

            // 切った効果音をつける
            sound.Play();
            // スコア表示
            Text Score = ScoreText.GetComponent<Text>();
            Score.text = "Score : " + score;
            score += 1;
            
            // スコアが10ポイントになったらシーン切り替える
            if(score >= 11)
            {
                SceneManager.LoadScene("GameClear");
            }



            Destroy(loverHull, 3f);
            Destroy(upperHull, 3f);

            
        }
    }
    public void SetupSliedComponnt(GameObject slicedObject)
    {
        Rigidbody rb = slicedObject.AddComponent<Rigidbody>();
        MeshCollider collider = slicedObject.AddComponent<MeshCollider>();
        collider.convex = true;
        rb.AddExplosionForce(cutForce, slicedObject.transform.position, 1);
    }
}
