using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 5;
    GameObject player;
    Vector3 dir;
    public GameObject explosionFactory;
    private void Start()
    {
        int randValue = UnityEngine.Random.Range(0, 10);
        if (randValue < 3)
        {
            GameObject target = GameObject.Find("Player");
            dir = target.transform.position - transform.position;
            dir.Normalize();
        }
        else
        {
            dir = Vector3.down;
        }
    }
    void Update()
    {
        transform.position += dir * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject smObject = GameObject.Find("ScoreManager");
        ScoreManager sm = smObject.GetComponent<ScoreManager>();
        sm.currentScore++;

        sm.currentScoreUI.text = "Current Score(Sehee Lee): " + sm.currentScore;
        if (sm.currentScore > sm.bestScore)
        {
            sm.bestScore = sm.currentScore;
            sm.bestScoreUI.text = "Best Score(Sehee Lee): " + sm.bestScore;
            PlayerPrefs.SetInt("Best Score", sm.bestScore);
        }

        GameObject explosion = Instantiate(explosionFactory);
        explosion.transform.position = transform.position;
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}
