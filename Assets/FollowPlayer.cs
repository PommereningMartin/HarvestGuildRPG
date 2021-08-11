using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


/// <summary>
/// Follows a GameObject in a Smooth way and with various settings
/// Author: Manuel Otheo (@Lootheo) with guidance from Hasan Bayat (EmpireWorld)
/// 
/// https://www.reddit.com/r/Unity3D/comments/6iskah/movetowards_vs_lerp_vs_slerp_vs_smoothdamp/
/// How to use: Attach it to a GameObject and then assign the target to follow and the variables like offset and speed
/// If it's not moving check the speed
/// 
/// TODO: Make more efficient usage of the vector3 to vector2;
/// </summary>
/// 
namespace UnityLibrary
{
    public class FollowPlayer : MonoBehaviour
    {

public Transform playerTransform;
     public int depth = -20;
 
     // Update is called once per frame
     void Update()
     {
         if(playerTransform != null)
         {
             transform.position = playerTransform.position + new Vector3(0,10,depth);
         }
     }
 
     public void setTarget(Transform target)
     {
         playerTransform = target;
     }
    }
}