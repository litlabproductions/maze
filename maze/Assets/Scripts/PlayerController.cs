using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class PlayerController : MonoBehaviour
{
   // PlayGamesScript.ShowAchievementsUI();

    private bool move;
    private float t;

    Vector2 startPos;
    Vector2 finalPosition;

    GameObject particleObject;
    public ParticleSystem particles;
    public ParticleSystem particles2;
    public ParticleSystem particles3;
    public ParticleSystem particles4;

    public ParticleSystem pickupParticles;

    public float rotationSpeed;
    private float angle;

    private bool isDead;

    public int score = 0;
    public float scoreDistanceIncrement;
    public Text scoreText;

    public Text highScoreText;
    public Text countDownText;
    private float countDown = 5.0f;

    public Text popUpText;

    public Button tryAgainButton;
    public Button menuButton;

    public int pickupPointsToGive;

    public AudioSource pickupSound;
    public AudioSource killBoxSound;
    public AudioSource killSound;

    private int adTicker;

    public Color pickupParticleColor1;
    public Color pickupParticleColor2;
    public Color pickupParticleColor3;
    public Color pickupParticleColor4;
    public Color pickupParticleColor5;
    public Color pickupParticleColor6;
    public Color pickupParticleColor7;

    public GameObject playerParticle;

    public int advDeathCountTracker;

    void Start()
    {
        isDead = false;

        particles.gameObject.SetActive(false);
        particles2.gameObject.SetActive(false);
        particles3.gameObject.SetActive(false);
        particles4.gameObject.SetActive(false);

        pickupParticles.gameObject.SetActive(false);

        tryAgainButton.gameObject.SetActive(false);
        menuButton.gameObject.SetActive(false);
        popUpText.gameObject.SetActive(false);
        

        highScoreText.text = PlayerPrefs.GetInt("HighScore").ToString();
        countDownText.text = ((int) countDown).ToString();
}

    void FixedUpdate()
    {
        countDown -= Time.deltaTime;

        if (countDown >= 2.0f)
            countDownText.text = ((int)countDown - 1).ToString();

        else if (countDown > 0.0f)
            countDownText.text = "GO";
        else
            countDownText.gameObject.SetActive(false);

        if (Input.touchCount > 0 && !isDead) // insert condition to begin movement
        {
            move = true;
            t = 0; // reset timer
            startPos = transform.position; // store current position for lerp
            finalPosition = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
        }
        if (move && !isDead)
        {
            MovePlayer();
            HandleScoring();
        }

        //enable particles so when crash occurs we can take care of it.
        particles.gameObject.SetActive(true);
        particles2.gameObject.SetActive(true);
        particles3.gameObject.SetActive(true);
        particles4.gameObject.SetActive(true);
        pickupParticles.gameObject.SetActive(true);

        PickupParticleSwitch();

        advDeathCountTracker = PlayerPrefs.GetInt("AdvDeathCount");
    }

    public void PickupParticleSwitch()
    {
        var mainParticleColor = pickupParticles.main;
        mainParticleColor.startColor = pickupParticleColor1;

        if (score > 9)
            mainParticleColor.startColor = pickupParticleColor2;
        
        if (score > 19)
            mainParticleColor.startColor = pickupParticleColor3;

        if (score > 29)
            mainParticleColor.startColor = pickupParticleColor4;

        if (score > 39)
            mainParticleColor.startColor = pickupParticleColor5;

        if (score > 49)
            mainParticleColor.startColor = pickupParticleColor6;

        if (score > 59)
            mainParticleColor.startColor = pickupParticleColor6;

    }

    void MovePlayer()
    {
        t += Time.deltaTime / 0.3f;   // (.3) Time in seconds taken to move from original position to touch
        transform.position = Vector2.Lerp(startPos, finalPosition, t);

        Vector3 direction = startPos - (Vector2) this.transform.position;
        angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg + 90.0f;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotationSpeed * Time.deltaTime);

        if (t > 0.3f)
            move = false; // exit function
    }

    public bool IsPlayerDead()
    {
        return isDead;
    }

    public void Die()
    {
        isDead = true;

        particles4.Play();
        particles.Play();
        particles2.Play();
        particles3.Play();

        playerParticle.SetActive(false);

        if (!killSound.isPlaying)
            killSound.Play();

        PlayerPrefs.SetInt("AdvDeathCount", PlayerPrefs.GetInt("AdvDeathCount") + 1);

        StartCoroutine(HandlePostDeath());
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Collision");

        if (other.gameObject.layer == 10)
        {
            pickupParticles.Play();
            pickupSound.Play();
            HandlePickup();
        }
        else
            Die(); 
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "MainCamera")
            Die();
    }

    public void HandlePickup()
    {
        StartCoroutine(StopParticles());

        score += pickupPointsToGive;
            //+ ((int) Time.fixedTime);
        scoreText.text = score.ToString() ;
      }

    IEnumerator StopParticles()
    {
        yield return new WaitForSeconds(2.0f);
        pickupParticles.Stop();
    }

    IEnumerator HandlePostDeath()
    {
        yield return new WaitForSeconds(2.0f);
         particles.Stop();
         particles2.Stop();
         particles3.Stop();
         particles4.Stop();
        //SceneManager.LoadScene("MenuScene");
        //countDownText.text = "GG";
       // countDownText.gameObject.SetActive(true);
        
        tryAgainButton.gameObject.SetActive(true);
        menuButton.gameObject.SetActive(true);
        popUpText.text = score.ToString();
        popUpText.gameObject.SetActive(true);

        Destroy(gameObject);

        if (PlayerPrefs.GetInt("AdvDeathCount") > 2)
            PlayAdvertisment();
    }

    public void PlayAdvertisment()
    {
        if (Advertisement.IsReady("video") && !Advertisement.isShowing)
        {
            Advertisement.Show("video", new ShowOptions() { resultCallback = HandleAdResult });

            PlayerPrefs.SetInt("AdvDeathCount", 0);
        }
    }

    private void HandleAdResult(ShowResult result)
    {
        switch (result)
        {
            case ShowResult.Finished:
                Debug.Log("User Finished AD");
                break;

            case ShowResult.Skipped:
                Debug.Log("User Skipped AD");
                break;

            case ShowResult.Failed:
                Debug.Log("AD Failed");
                break;
        }
    }

    public void HandleScoring()
    {
        if (transform.position.y > scoreDistanceIncrement)
        {
            ++score;
            scoreText.text = score.ToString();
            scoreDistanceIncrement += 11.0f;
        }

        if (score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", score);
            highScoreText.text = PlayerPrefs.GetInt("HighScore").ToString();
        }
    }
}
    
