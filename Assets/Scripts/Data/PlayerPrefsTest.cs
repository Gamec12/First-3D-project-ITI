using UnityEngine;

public class PlayerPrefsTest : MonoBehaviour
{
    [SerializeField]string test = "Hello";
    [SerializeField] string setTest = "NO";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnEnable()
    {
        test = PlayerPrefs.GetString("Name");
    }

    private void Start()
    {
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnApplicationQuit()
    {
        test = setTest;
        PlayerPrefs.SetString("Name", test);
    }


}
