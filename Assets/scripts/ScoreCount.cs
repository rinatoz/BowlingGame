using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour
{
    [SerializeField] string tag;
    [SerializeField] Vector3 cuurrenPosition;
    [SerializeField] Quaternion originalRotation;
    [SerializeField] int score;
    [SerializeField] Text scoreText;
    [SerializeField] bool flag = true;

    public void Start()
    {
        cuurrenPosition = transform.position;
        originalRotation = transform.rotation;
    }
    public void Update()
    {
      if (HasMoved()&&flag)
        {
            int result = Int32.Parse(scoreText.text);
            score = result+1;
            scoreText.text = score.ToString();
            this.gameObject.tag = tag;
            flag = false;
        }
    }
    private bool HasMoved()
    {
        return  transform.rotation != originalRotation;
    }

 


}
