using UnityEngine;
using Steamworks;

public class GetPlayerCode : MonoBehaviour
{
    CSteamID GetSteamID()
    {
        // Steam API �ʱ�ȭ Ȯ��
        if (!SteamManager.Initialized)
        {
            Debug.LogError("Steam Manager is not initialized!");
            return new CSteamID(0); // ��ȿ���� ���� SteamID ��ȯ
        }

        // ���� ������� SteamID�� ������
        CSteamID mySteamID = SteamUser.GetSteamID();

        // 64��Ʈ ���������� ��ȯ�Ͽ� ���
        ulong steamID64 = mySteamID.m_SteamID;

        Debug.Log("My SteamID64: " + steamID64);

        return mySteamID;
    }

    private void Start()
    {
        GetSteamID();
    }
}
