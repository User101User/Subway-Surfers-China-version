using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BoostUIManager : MonoBehaviour
{
    public PlayerMovement playerMovement; 
    public TMP_Text boostCountText; 

    void Start()
    {
        UpdateBoostCountText();
    }

    void Update()
    {
        UpdateBoostCountText(); 
    }

    private void UpdateBoostCountText()
    {
     
        boostCountText.text = "Boosts: " + (playerMovement.maxBoosts - playerMovement.boostCount).ToString();
    }
}