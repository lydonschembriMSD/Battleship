using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public void CreateNewGameInstance()
    {
        StartCoroutine(FirebaseController.CreateInstance2());
    }
}
