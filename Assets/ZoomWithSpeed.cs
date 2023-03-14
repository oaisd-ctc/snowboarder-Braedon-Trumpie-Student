using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using System;
public class ZoomWithSpeed : MonoBehaviour
{
    [SerializeField] float decayFactor = 100f;
    [SerializeField] float zoomFactor = 500;
    [SerializeField] GameObject thingToFollow;
    Rigidbody2D rb2d;
    CinemachineVirtualCamera c;
    void Start() 
    {
        c = GetComponent<CinemachineVirtualCamera>();
        rb2d = thingToFollow.GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if(c.m_Lens.OrthographicSize > 15f)
        {
            c.m_Lens.OrthographicSize -= c.m_Lens.OrthographicSize / decayFactor;
            if(c.m_Lens.OrthographicSize < 15f)
            {
                c.m_Lens.OrthographicSize = 15f;
            }
        }
        c.m_Lens.OrthographicSize += ((Math.Abs(rb2d.velocity.x) + Math.Abs(rb2d.velocity.y)) / zoomFactor);
    }
}
