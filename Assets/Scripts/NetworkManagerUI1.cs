using UnityEngine;
using UnityEngine.UI;
using Unity.Netcode;

public class NetworkManagerUI1 : MonoBehaviour
{
    [SerializeField] private Button serverBtn;
    [SerializeField] private Button hostBtn;
    [SerializeField] private Button clientBtn;


    private void Awake()
    {
        serverBtn.onClick.AddListener(() => 
        {
            NetworkManager.Singleton.StartServer();
        });

        hostBtn.onClick.AddListener(() =>
        {
            NetworkManager.Singleton.StartHost();
        });

        clientBtn.onClick.AddListener(() =>
        {
            NetworkManager.Singleton.StartClient();
        });
    }

}
