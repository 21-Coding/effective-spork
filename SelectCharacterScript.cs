using System.Collections;
using.System.Collections.Generic;
using UnityEngine;

public class SelectCharacterScript : MonoBehaviour
{
    GameObject[] Characters;
    int CharacterIndex;

    void Start()
    {
         InstantiateCharacter();

    }


    public void InstantiateCharacter()
    {
        Instantiate(Characters[CharacterIndex],transform.position, transform.rotation, transform);
    }

}