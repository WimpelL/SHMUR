using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_1 : Enemy
{
    [Header("Set in Inspector: Enemy_1")]
    public float waveFrequency = 2;
    public float waveWidth = 4;
    public float waveRotY = 45;

    private float xO;
    private float birthTime;
    
    
    void Start()
    {
        xO = pos.x;
        birthTime = Time.time;
    }

    public override void Move() 
    {
        Vector3 temPos = pos;
        float age = Time.time - birthTime;
        float theta = Mathf.PI * 2 * age / waveFrequency;
        float sin = Mathf.Sin(theta);
        temPos.x = xO + waveWidth * sin;
        pos = temPos;
        Vector3 rot = new Vector3(0, sin*waveRotY, 0);
        this.transform.rotation = Quaternion.Euler(rot);
        base.Move();
        // print (bndCheck.isOnScreen);
    }
}
