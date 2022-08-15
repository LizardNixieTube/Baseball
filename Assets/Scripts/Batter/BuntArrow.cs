using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuntArrow : MonoBehaviour
{
    public Transform FollowT;

    public void Update()
    {
        transform.position = new Vector3(transform.position.x, FollowT.position.y, transform.position.z);

        //TODO - duplicate (except the axis) from BatCursor
        /*
         * top view
         * 
         *   bottom of arrow 
         *         /|
         *        / |
         *       /  |
         *      /   | dz
         *     /    |
         *    /_____|
         *  É∆   dx
         *  (É∆ point is where follow/cursor locate)
         *  
         */
        float dz = transform.position.z - FollowT.position.z;
        float dx = transform.position.x - FollowT.position.x;
        float angle = Mathf.Rad2Deg * Mathf.Atan(dx / dz);
        transform.rotation = new Quaternion
        {
            eulerAngles = new Vector3(68f, angle - 180, 0)
        };

    }
}
