using UnityEngine;

public class MissionStarter : MonoBehaviour
{
    public MissionMessage2 mission;

    void Start()
    {
        mission.ShowMessage(" Attention aux pièges ! Trouve le trésor final !");
    }
}
