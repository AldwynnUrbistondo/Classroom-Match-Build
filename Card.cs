using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    #region Variables

    public Button button;
    public static bool isCouro = false;
    public int cardIdentification;

    private GameManager gameManager;

    #endregion

    void Start()
    {

        button = GetComponentInChildren<Button>();
        gameManager = FindObjectOfType<GameManager>();

        for (int i = 0; i < 20; i++)
        {
            if (ArrayCard.cardId[i] == -1)
            {
                ArrayCard.cardId[i] = i;
                cardIdentification = ArrayCard.cardId[i];
                break;
            }
        }
    }

    private void Update()
    {
        if (!isCouro)
        {
            if (gameManager.chosenCard1 != -1 && gameManager.chosenCard2 != -1)
            {
                isCouro = true;

                StartCoroutine(DelaySeconds());
                
            }
        }
    }

    IEnumerator DelaySeconds()
    {
        if (gameManager.chosenCard1 != gameManager.chosenCard2)
        {
            gameManager.timeIsRunning = false;

            yield return new WaitForSeconds(1f);

            gameManager.NotMatch();

        }
        else
        {
            gameManager.timeIsRunning = false;

            yield return new WaitForSeconds(1f);

            gameManager.Match(); 

        }

        //isCouro = false;
    }
}
