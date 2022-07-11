using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pitcher
{
    public enum BallDir { SLOW, CENTER, LEFT, LOWERLEFT, DOWN, LOWERRIGHT, RIGHT };
    /*
     * ‹…Ží
     * ScriptableObject that generates necessary data for ball type pitcher are able to use
     */
    [CreateAssetMenu(fileName = "New Pitch Type Data", menuName = "ScriptableObjects/ThrowTypeData", order = 1)]
    public class PitchTypeSO : ScriptableObject
    {
        public string Name = "Ball Type";

        [Range( 60, 180)] public int MaxSpeed = 140;  //km/h
        [Range(-10,  10)] public int CurveOffset = 0;
        [Range(  0,  10)] public int DropOffset = 0;

        public Vector2 DirVec { get; }
        public BallDir Dir;

        public PitchTypeSO(BallDir name)
        {
            switch (name)
            {
                case BallDir.LEFT:
                    DirVec = new Vector2(-1, 0);
                    break;
                case BallDir.RIGHT:
                    DirVec = new Vector2(1, 0);
                    break;
                case BallDir.DOWN:
                    DirVec = new Vector2(0, -1);
                    break;
                case BallDir.LOWERLEFT:
                    DirVec = new Vector2(-1, -1);
                    break;
                case BallDir.LOWERRIGHT:
                    DirVec = new Vector2(1, -1);
                    break;
                case BallDir.CENTER:
                    DirVec = new Vector2(0, 1);
                    break;
                default:
                    DirVec = new Vector2(0, 0); //default will return a slow ball; TODO maybe a custom breakball?
                    name = BallDir.SLOW;
                    break;
            }
            Dir = name;
        }
        public static BallDir WhatBallType(Vector2 vec)
        {
            //left curve ball
            if (vec.x < 0)
            {
                if (vec.y == 0) return BallDir.LEFT;
                if (vec.y < 0) return BallDir.LOWERLEFT;
            }
            else if (vec.x > 0)
            {
                if (vec.y == 0) return BallDir.RIGHT;
                if (vec.y < 0) return BallDir.LOWERRIGHT;

            }
            else//vec.x == 0
            {
                if (vec.y > 0) return BallDir.CENTER;
                if (vec.y < 0) return BallDir.DOWN;
            }

            return BallDir.SLOW;
        }
    }

}
