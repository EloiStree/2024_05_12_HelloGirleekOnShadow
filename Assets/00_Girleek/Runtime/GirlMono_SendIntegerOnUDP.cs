using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public class GirlMono_SendIntegerOnUDP : MonoBehaviour
{
    
    public static GirlMono_SendIntegerOnUDP instance;

    public string m_ipAddress = "127.0.0.1";
    public int m_port = 3614;

    // Create UDP client
    private UdpClient m_udpClient;

    void Start()
    {
        if (instance == null)
            instance = this;

        // Initialize UDP client
        m_udpClient = new UdpClient();
    }


    public void SendInt(string valueSend) { 
    
        if(int.TryParse(valueSend, out int valueParsedAsInteger))
        {
            SendInt(valueParsedAsInteger);

        }
    }

    public void SendInt(int valueToSend)
    {
        try
        {
            // Convert integer to bytes
            byte[] data = BitConverter.GetBytes(valueToSend);

            // Send the data
            m_udpClient.Send(data, data.Length, m_ipAddress, m_port);
            Debug.Log("Sent integer: " + valueToSend);
        }
        catch (System.Exception e)
        {
            Debug.LogError("Error sending UDP message: " + e.Message);
        }
    }

    void OnDestroy()
    {
        // Close the UDP client when the GameObject is destroyed
        if (m_udpClient != null)
        {
            m_udpClient.Close();
        }
    }
}
