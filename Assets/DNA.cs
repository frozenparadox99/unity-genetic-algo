﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DNA : MonoBehaviour
{
    // gene for color
    public float r;
    public float g;
    public float b;

    public float s;

    bool dead = false;
    public float timeToDie = 0;

    SpriteRenderer sRenderer;
    Collider2D sCollider;

    private void OnMouseDown()
    {
        dead = true;
        timeToDie = PopulationManager.elapsed;
        Debug.Log("Dead at : " + timeToDie);
        sRenderer.enabled = false;
        sCollider.enabled = false;
    }


    void Start()
    {
        sRenderer = GetComponent<SpriteRenderer>();
        sCollider = GetComponent<Collider2D>();
        sRenderer.color = new Color(r, g, b);
        this.transform.localScale = new Vector3(s, s, s);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
