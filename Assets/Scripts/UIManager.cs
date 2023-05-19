using UnityEngine;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{
    public Text gemsText;
    public Text worldText;
    public Text stageText;
    public Text livesText;
    // Start is called before the first frame update
    void Update()
    {
        UpdateGems();
        UpdateWorld();
        UpdateLives();
    }

    public void UpdateGems()
    {
        gemsText.text ="X " + GameManager.Instance.gems.ToString();
    }

    public void UpdateWorld()
    {
        worldText.text = GameManager.Instance.world.ToString();
        stageText.text = "- " + GameManager.Instance.stage.ToString();
    }

    public void UpdateLives()
    {
        livesText.text = "X " + GameManager.Instance.lives.ToString();
    }
}
