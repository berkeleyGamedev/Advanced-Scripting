using UnityEngine;
using UnityEngine.UI;

[DisallowMultipleComponent]
public class ScoreCounter : MonoBehaviour
{
    #region Singleton Creation
    public static ScoreCounter Instance { get; private set; }
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
            return;
        }

        Instance = this;
    }
    #endregion

    #region Editor Variables
    [SerializeField]
    [Tooltip("The text component that is displaying the score. The text value " +
        "of this component will change with the score.")]
    private Text m_UIText;
    #endregion

    #region Non-Editor Variables
    private int m_Score;
    #endregion

    #region First Time Initialization and Set Up

    public void Start()
    {
        m_Score = 0;
        AddScore(0);
    }
    #endregion

    #region Score Modification Methods
    public void AddScore(int add)
    {
        m_Score += add;
        m_UIText.text = "" + m_Score;
    }
    #endregion
}
