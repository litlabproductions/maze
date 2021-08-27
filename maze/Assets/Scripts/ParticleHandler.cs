using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParticleHandler : MonoBehaviour
{
    public ParticleSystem cellOne;
    public ParticleSystem cellTwo;
    public ParticleSystem cellThree;
    public ParticleSystem cellFour;
    public ParticleSystem cellFive;
    public ParticleSystem cellSix;
    public ParticleSystem cellSeven;

    public TrailRenderer playerTrail;

    public Material trailMaterialOne;
    public Material trailMaterialTwo;
    public Material trailMaterialThree;
    public Material trailMaterialFour;
    public Material trailMaterialFive;
    public Material trailMaterialSix;
    public Material trailMaterialSeven;

    public Image scoreImage;



    // Use this for initialization
    void Start ()
    {
        cellTwo.gameObject.SetActive(false);
        cellThree.gameObject.SetActive(false);
        cellFour.gameObject.SetActive(false);
        cellFive.gameObject.SetActive(false);
        cellSix.gameObject.SetActive(false);
        cellSeven.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update ()
    {
        ParticleSwitch();
	}

    public void ParticleSwitch()
    {
        if (GetComponent<PlayerController>().score > 9)
        {
            cellThree.gameObject.SetActive(true);
            playerTrail.material = trailMaterialThree;
            scoreImage.material = trailMaterialThree;
        }
        if (GetComponent<PlayerController>().score > 10)
        {
            cellOne.gameObject.SetActive(false);
        }
        if (GetComponent<PlayerController>().score > 19)
        {
            cellFour.gameObject.SetActive(true);
            playerTrail.material = trailMaterialFour;
            scoreImage.material = trailMaterialFour;
        }
        if (GetComponent<PlayerController>().score > 20)
        {
            cellThree.gameObject.SetActive(false);
        }
        if (GetComponent<PlayerController>().score > 29)
        {
            cellFive.gameObject.SetActive(true);
            playerTrail.material = trailMaterialFive;
            scoreImage.material = trailMaterialFive;
        }
        if (GetComponent<PlayerController>().score > 30)
        {
            cellFour.gameObject.SetActive(false);
        }
        if (GetComponent<PlayerController>().score > 39)
        {
            cellSix.gameObject.SetActive(true);
            playerTrail.material = trailMaterialSix;
            scoreImage.material = trailMaterialSix;
        }
        if (GetComponent<PlayerController>().score > 40)
        {
            cellFive.gameObject.SetActive(false);
        }
        if (GetComponent<PlayerController>().score > 49)
        {
            cellSeven.gameObject.SetActive(true);
            playerTrail.material = trailMaterialSeven;
            scoreImage.material = trailMaterialSeven;
        }
        if(GetComponent<PlayerController>().score > 50)
        {
            cellSix.gameObject.SetActive(false);
        }
    }
}
