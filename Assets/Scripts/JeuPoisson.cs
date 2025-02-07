using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JeuPoisson : MonoBehaviour
{
    public float poidsSaumon = 10.5f;
    [SerializeField] private float _poidsSardine = 100f;

    [SerializeReference] private GameObject _sardine;
    [SerializeReference] private GameObject _saumon;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(poidsSaumon);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(poidsSaumon);

    }

    public void ComparerPoissons()
    {
        if (poidsSaumon > _poidsSardine)
        {
            Debug.Log("Bon appetit!");
            _sardine.SetActive(false);
            //Destroy(_sardine);
        }
        else
        {
            Debug.Log("Non!");
        }
    }

}
