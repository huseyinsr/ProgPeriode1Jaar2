/*using UnityEngine;
using TMPro;
using System;
public class Scoreboard : MonoBehaviour
{
     private int score = 0;
     public TextMeshProUGUI scoreText;
     void Start()
     {
         UpdateScore();
         Pickup.OnPickupCollected += Pickupp;
     }

     void Update()
     {

     }
     void Pickupp()
     {
         score += 50;
         UpdateScore();
     }
     void UpdateScore()
     {
          scoreText.text = "Score: " + score;
     }
     void OnDestroy()
     {
         Pickup.OnPickupCollected -= Pickupp;
     }

 }
*/
