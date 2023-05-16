using System.Collections;
using UnityEngine;

public class FlagPole : MonoBehaviour
{
    public int nextWorld = 1;
    public int nextStage = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(LevelCompleteSequence(other.transform));
        }
    }

    private IEnumerator LevelCompleteSequence(Transform player)
    {
        player.GetComponent<PlayerMovement>().enabled = false;

        player.gameObject.SetActive(false);

        yield return new WaitForSeconds(2f);

        GameManager.Instance.LoadLevel(nextWorld, nextStage);
    }
}
