using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Nakama;
public class NakamaTest : MonoBehaviour
{
    public bool runValidate;

    ISession session;
    IApiAccount account;
    void Start()
    {
        EstablishConnection();
    }

    private void OnValidate() {
        if(runValidate)
        {
            runValidate = false;
            session = null;
            PlayerPrefs.SetString("nakama.session", "");
            EstablishConnection();
        }
    }

    async void EstablishConnection()
    {
        var client = new Client("http", "127.0.0.1", 7350, "defaultkey");

        // Restore.
        var authtoken = PlayerPrefs.GetString("nakama.session");
        session = Session.Restore(authtoken);

        try
        {
            account = await client.GetAccountAsync(session);
        }
        catch (System.Exception e)
        {
            Debug.Log(e.Message);

            var deviceId = SystemInfo.deviceUniqueIdentifier;
            session = await client.AuthenticateDeviceAsync(deviceId);
            account = await client.GetAccountAsync(session);

            PlayerPrefs.SetString("nakama.session", session.AuthToken);
        }
        
        Debug.Log($"User ID = {session.UserId}");   // "ea1e7609-372a-4d67-a495-58f955f3328b"
        Debug.Log($"UserName = {session.Username}"); // "wRkuUTbKmY"
        Debug.Log($"Accout User ID = {account.User.Id}"); // "ea1e7609-372a-4d67-a495-58f955f3328b"
    }
}
