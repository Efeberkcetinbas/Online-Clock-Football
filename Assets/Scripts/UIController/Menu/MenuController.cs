using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MenuController : MonoBehaviour
{
    [Header("VERSION")]
    [SerializeField] private string VersionName = "0.1";

    [Header("MENU'S")]
    [SerializeField] private GameObject UsernameMenu;
    [SerializeField] private GameObject ConnectionPanel;
    [SerializeField] private GameObject StartButton;

    [Header("CONNECTION")]
    [SerializeField] private TMP_InputField UserNameInput;
    [SerializeField] private TMP_InputField CreateGameInput;
    [SerializeField] private TMP_InputField JoinGameInput;

    void Awake()
    {
        PhotonNetwork.ConnectUsingSettings(VersionName);
    }

    void Start()
    {
        UsernameMenu.SetActive(true);
    }

    private void OnConnectedToMaster()
    {
        //Lobiye katılım
        PhotonNetwork.JoinLobby(TypedLobby.Default);
        Debug.Log("CONNECTED");
    }

    public void ChangeUserNameInput()
    {
        if (UserNameInput.text.Length >= 3)
        {
            if (UserNameInput.text.Length <= 12)
            {
                StartButton.SetActive(true);
            }

            else
            {
                StartButton.SetActive(false);
            }
        }
        else
        {
            StartButton.SetActive(false);
        }
    }

    public void SetUserName()
    {
        UsernameMenu.SetActive(false);
        PhotonNetwork.playerName = UserNameInput.text;
    }

    //Default max players
    public void CreateGame()
    {
        PhotonNetwork.CreateRoom(CreateGameInput.text, new RoomOptions() { maxPlayers = 2 }, null);
    }

    /*
     DoTween Kill Al.
         */
    public void JoinGame()
    {
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.maxPlayers = 2;
        PhotonNetwork.JoinOrCreateRoom(JoinGameInput.text, roomOptions, TypedLobby.Default);
    }

    private void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("GameScene");
    }

}
