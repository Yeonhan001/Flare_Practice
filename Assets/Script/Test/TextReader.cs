using System.Collections.Generic;
using UnityEngine;

public class TextReader : MonoBehaviour
{
    public TextAsset textFile;

    private void Start()
    {
        List<CharacterData> data = ReadTextFile(textFile);
        foreach (CharacterData character in data)
        {
            Debug.Log($"ID: {character.characterID}, Power: {character.power}, Health: {character.health}, Speed: {character.speed}");
        }
    }

    public List<CharacterData> ReadTextFile(TextAsset data)
    {
        List<CharacterData> characters = new List<CharacterData>();

        string[] table = data.text.Split('\n');
        for (int i = 1; i < table.Length; i++)
        {
            string[] entryData = table[i].Split('\t');
            CharacterData characterData = new CharacterData();
            characterData.characterID = entryData[0];
            characterData.power = int.Parse(entryData[1]);
            characterData.health = int.Parse(entryData[2]);
            characterData.speed = float.Parse(entryData[3]);
            characters.Add(characterData);
        }

        return characters;
    }
}

public class CharacterData
{
    public string characterID;
    public int power;
    public int health;
    public float speed;
}