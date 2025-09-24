using UnityEngine;
using LitJson;

public class JsonTester : MonoBehaviour
{
    public void Start()
    {
        CharacterData data = new CharacterData();
        // data.characterName = "Warrior";
        data.health = 150;
        data.speed = 1.5f;
        // data.goldAmount = 340;

        string jfonString = ConvertToJson(data);
        Debug.Log(jfonString);
    }

    public string ConvertToJson(CharacterData data)
    {
        // string jsonString = JsonUtility.ToJson(data);
        string jsonString = JsonMapper.ToJson(data);
        return jsonString;
    }

    public CharacterData ReadFromJson(string jsonString)
    {
        // CharacterData data = JsonUtility.FromJson<CharacterData>(jsonString);
        CharacterData data = JsonMapper.ToObject<CharacterData>(jsonString);
        return data;
    }
}
