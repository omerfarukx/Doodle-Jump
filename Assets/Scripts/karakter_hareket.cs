using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class karakter_hareket : MonoBehaviour
{
    public float hiz;
    public Rigidbody2D doodle;
    private float hareketInput;
    public TextMeshProUGUI bitisYazisi;
    public int skor,altinsayisi;
    public TextMeshProUGUI highScore, altinYazisi;
    public GameObject Panel;
    public AudioSource ziplama, altin;
    


    void Start()
    {
        Time.timeScale = 1;

    }

    void Update()
    {

        hareketInput = Input.GetAxis("Horizontal");
        doodle.velocity = new Vector2(hiz * hareketInput, doodle.velocity.y);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -3, 3f), transform.position.y, transform.position.z);
        bitisYazisi.text = "Puan : " + skor.ToString();

        highScore.text = PlayerPrefs.GetInt("HighScore").ToString();

        if (skor > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", skor);
            highScore.text =skor.ToString();
        }

        PlayerPrefs.SetInt("Coins", altinsayisi);
        altinYazisi.text = altinsayisi.ToString();
    }

    private void OnCollisionEnter2D(Collision2D temas)
    {
        float rastgeleX = Random.Range(-3f, 3f);

        if (temas.gameObject.tag == "bitis")
        {
            Time.timeScale = 0;
            Panel.SetActive(true);
        }
        if (temas.gameObject.tag == "Platform")
        {
            skor += Random.Range(15, 45);
            ziplama.Play();

        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        float rastgeleX = Random.Range(-3f, 3f);
        if (collision.gameObject.tag == "Altin")
        {
            collision.transform.position = new Vector3(rastgeleX, collision.transform.position.y + Random.Range(12f, 14f), transform.position.z);
            altin.Play();
            altinsayisi++;
        }
    }



}
