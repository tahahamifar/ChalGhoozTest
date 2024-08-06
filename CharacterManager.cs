using System;
using System.Collections.Generic;

using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    public List<AllCharacters> CharactersList;
    public GameObject Prefab;
    public Transform GridCard;


    void Start()
    {

        MakeCharacter();

    }
    public void MakeCharacter()
    {
        for (int i = 0; i < CharactersList.Count; i++)
        {
            GameObject Card = Instantiate(Prefab, Vector3.zero, Quaternion.identity, GridCard);
            Card.GetComponent<Character>().Name.text = CharactersList[i].Name;
            Card.GetComponent<Character>().Level.text = CharactersList[i].Level.ToString();
            Card.GetComponent<Character>().Image.sprite = CharactersList[i].avatar;
            Card.GetComponent<Character>().Type.text = CharactersList[i].type.ToString();

            if (CharactersList[i].type.ToString() == "Shovel")
            {
                Card.GetComponent<Character>().Type.text = "S";

            }
            else
            {
                Card.GetComponent<Character>().Type.text = "V";
            }
        }

    }

}


[Serializable]
public class AllCharacters

{
    public string Name;
    public int Level;
    public Sprite avatar;

    public enum Type { Shovel, Soldier }
    public Type type;


}


