using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 8f;
    public float boostSpeed = 11f;
    public float boostDuration = 2f;
    public int maxBoosts = 2;

    public float currentSpeed; // Aktuelle Geschwindigkeit des Spielers
    public bool isBoosted = false; // Status, ob der Boost aktiv ist
    public int boostCount = 0; // Zähler für die Anzahl der Boosts

    void Start()
    {
        currentSpeed = speed; // Setze die aktuelle Geschwindigkeit auf die normale Geschwindigkeit
    }

    void Update()
    {
        MovePlayer();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ActivateSpeedBoost();
        }
    }

    void MovePlayer()
    {
        transform.position += Vector3.forward * currentSpeed * Time.deltaTime;

        float horizontalInput = Input.GetAxis("Horizontal");
        float newX = transform.position.x + horizontalInput * currentSpeed * Time.deltaTime;

        // Begrenzung der Bewegung
        // (Hier kannst du deine Grenzen hinzufügen)

        transform.position = new Vector3(newX, transform.position.y, transform.position.z);
    }

    public void ActivateSpeedBoost()
    {
        if (!isBoosted && boostCount < maxBoosts)
        {
            isBoosted = true;
            currentSpeed = boostSpeed;
            boostCount++;
            StartCoroutine(EndSpeedBoost());
        }
    }

    private IEnumerator EndSpeedBoost()
    {
        yield return new WaitForSeconds(boostDuration);
        currentSpeed = speed;
        isBoosted = false;
    }

    public void ResetBoosts()
    {
        boostCount = 0;
    }
}