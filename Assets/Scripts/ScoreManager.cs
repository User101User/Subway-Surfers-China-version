using TMPro;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI scoreText;
    public static int score = 0;
    
    void Awake()
    {
        instance = this;
    }

    void Update()
    {
        
        scoreText.text= score.ToString();
    }


    

}
