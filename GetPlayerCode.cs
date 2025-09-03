using UnityEngine;
using Steamworks;

public class GetPlayerCode : MonoBehaviour
{
    CSteamID GetSteamID()
    {
        // Steam API 초기화 확인
        if (!SteamManager.Initialized)
        {
            Debug.LogError("Steam Manager is not initialized!");
            return new CSteamID(0); // 유효하지 않은 SteamID 반환
        }

        // 현재 사용자의 SteamID를 가져옴
        CSteamID mySteamID = SteamUser.GetSteamID();

        // 64비트 정수형으로 변환하여 사용
        ulong steamID64 = mySteamID.m_SteamID;

        Debug.Log("My SteamID64: " + steamID64);

        return mySteamID;
    }

    private void Start()
    {
        GetSteamID();
    }
}
