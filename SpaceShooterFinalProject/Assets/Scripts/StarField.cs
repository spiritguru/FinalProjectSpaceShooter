using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarField : MonoBehaviour
{
    private ParticleSystem ps;
    public float StarWin = 1.0F;

    public GameController gameController;

    void Start()
    {
        ps = GetComponent<ParticleSystem>();
    }

    void Update()
    {
        if (gameController.score>=100)
        { 
        var main = ps.main;
        main.simulationSpeed = StarWin;
    }
}
}
