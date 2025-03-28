using UnityEngine;
using UnityEngine.SceneManagement; 

public class SkyPlate : MonoBehaviour
{
    public int requiredCoins = 12; 
    public CoinCollection coinCollection; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            if (coinCollection.Coin >= requiredCoins) 
            {
                Debug.Log("Changing Scene: Coins Collected = " + coinCollection.Coin);
                ChangeScene(); 
            }
            else 
            {
                Debug.Log("Not enough coins: Coins Collected = " + coinCollection.Coin);
                RestartGame(); 
            }
        }
    }

    private void ChangeScene()
    {
        SceneManager.LoadScene("WinScenes"); 
    }

    private void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
    }
}