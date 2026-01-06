using UnityEngine;

public class ReadFromText : MonoBehaviour
{
    [SerializeField] TextAsset jsonFile;
    [SerializeField] CharactersData charactersData;
    void Start()
    {
        charactersData = JsonUtility.FromJson<CharactersData>(jsonFile.ToString());
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
