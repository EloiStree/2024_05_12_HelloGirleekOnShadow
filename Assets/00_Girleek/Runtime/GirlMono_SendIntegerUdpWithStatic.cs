using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirlMono_SendIntegerUdpWithStatic : MonoBehaviour
{



    [ContextMenu("Push random value integer")]
    public void PushIntegerToUdpWithRandomValue() {


        PushIntegerToUdp(UnityEngine.Random.Range(int.MinValue, int.MaxValue));
    }

    public void PushIntegerToUdp(int valeur)
    {

        if (GirlMono_SendIntegerOnUDP.instance != null)
            GirlMono_SendIntegerOnUDP.instance.SendInt(valeur);
    }
    public void PushIntegerToUdp(string valeur)
    {

        if (GirlMono_SendIntegerOnUDP.instance != null)
            GirlMono_SendIntegerOnUDP.instance.SendInt(valeur);
    }



}
