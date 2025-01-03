using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Ball")]
        public GameObject ball;

        [Header("Player 1")]
        public GameObject player1Paddle;
        public GameObject player1Goal;
        
        [Header("Player 2")]
        public GameObject player2Paddle;
        public GameObject player2Goal;
        
        [Header("Score UI")]
        public GameObject Player1Text;
        public GameObject Player2Text;


        private int Player1Score;
        private int Player2Score;

        public void Player1Scored()
        {
            Player1Score++;
            Player1Text.GetComponent<TextMeshProUGUI>().text = Player1Score.ToString();
        }
        
        public void Player2Scored()
        {
            Player2Score++;
            Player2Text.GetComponent<TextMeshProUGUI>().text = Player2Score.ToString();
        }

        private void ResetPosition()
        {
            //ball.GetComponent<balls>().ResetBall();
            //player1Paddle.GetComponent<pongMove>();
            //player2Paddle.GetComponent<pongMove>();

        }
        
}
