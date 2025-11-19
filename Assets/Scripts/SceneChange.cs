using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChange : MonoBehaviour
{
    [SerializeField]
    string nextScene;
    [SerializeField]
    TMP_InputField inputField;

    static string inputText;


    public void OnClick()
    {
        SceneManager.LoadScene(nextScene);

        inputText = inputField.text;
        SceneManager.LoadScene(nextScene);
    }
    void Start()
    {
        inputField.text= inputText;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
