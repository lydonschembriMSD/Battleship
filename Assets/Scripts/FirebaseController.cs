using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase.Database;
using Firebase.Extensions;
using Firebase.Storage;

public class FirebaseController : MonoBehaviour
{
    private static DatabaseReference dbRef;

    private void Start()
    {
        dbRef = FirebaseDatabase.DefaultInstance.RootReference;
    }

    public static IEnumerator CreateInstance()
    {
        yield return dbRef.Child("Games").Push();
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
