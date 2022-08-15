using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraManager : MonoBehaviour
{
    public CinemachineVirtualCamera VC_Main;
    public CinemachineVirtualCamera VC_TrackBall;

    public void FollowBall(Transform ballTrans)
    {
        VC_TrackBall.LookAt = ballTrans;
        SwitchBallCam(true);
    }

    public void SwitchBallCam(bool yes)
    {
        //switching priority
        //higher the number, higher the priority
        if (yes)
        {
            VC_TrackBall.Priority = 1;
            VC_Main.Priority = 0;
        }
        else
        {
            VC_TrackBall.Priority = 0;
            VC_Main.Priority = 1;
        }
    }
}
