using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase.Database;
using Firebase.Extensions;
using Firebase.Storage;
using System;

[Serializable]
public class GameLobby
{
    public string _player1, _player2;

    public GameLobby(string player1, string player2)
    {
        this._player1 = player1;
        this._player2 = player2;
    }

    public Dictionary<string, System.Object> ToDictionary()
    {
        Dictionary<string, System.Object> result = new Dictionary<string, System.Object>();
        result["player1"] = _player1;
        result["player2"] = _player2;
        result["Dog"] = "Not a human being";

        return result;
    }
}

public class FirebaseController : MonoBehaviour
{
    private static DatabaseReference dbRef;

    private void Start()
    {
        dbRef = FirebaseDatabase.DefaultInstance.RootReference;
    }

    //public static IEnumerator CreateInstance()
    //{
    //    //create a unique identifier
    //    string key = dbRef.Child("GameLobbies").Push().Key;

    //    //instantiate game lobby
    //    GameLobby lobby = new GameLobby("Lydon", "Edrica");
    //    Dictionary<string, System.Object> data = lobby.ToDictionary();

    //    //saving into firebase
    //    Dictionary<string, System.Object> childUpdates = new Dictionary<string, System.Object>();
    //    childUpdates["/GameLobbies" + key] = data;

    //    yield return dbRef.UpdateChildrenAsync(childUpdates);
    //}

    public static IEnumerator CreateInstance2()
    {
        //create a unique identifier
        string key = dbRef.Child("GameLobbies").Push().Key;

        //instantiate game lobby
        GameLobby lobby = new GameLobby("Lydon", "Edrica");
        yield return dbRef.Child("GameLobbies").Child(key).SetRawJsonValueAsync(JsonUtility.ToJson(lobby));
    }

    public static IEnumerator SaveFirebase()
    {
        yield return null;
    }

    public static IEnumerator GetFirebase()
    {
        yield return null;
    }

    public static IEnumerator DownloadAssets()
    {
        yield return null;
    }

    public static IEnumerator UploadAssets()
    {
        yield return null;
    }
}
