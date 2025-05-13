using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerDistance : MonoBehaviour
{
    public TextMeshProUGUI distanceText;  
    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;  
    }

    void Update()
    {
        float distance = Vector3.Distance(startPosition, transform.position); 
        distanceText.text = "Distance: " + distance.ToString("F2") + " m"; 
    }
}
