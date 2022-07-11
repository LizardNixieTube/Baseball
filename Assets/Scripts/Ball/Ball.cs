using System.Collections.Generic;
using System.Linq;
using UnityEngine;


public class Ball : MonoBehaviour
{
    public VoidEvent BallTravelEvent; //TODO - vector3 might be better since we have to send the info the batter?
    public VoidEvent BallFinishEvent; 

    public float SPEED_CONSTANT = 100000f;
    public int PointCounts = 100;

    private Bezier m_BallPath;

    private float m_Time     = 0f;
    private int   m_Index    = 0;
    private float m_Speed    = 0.0f; //TODO - change name to more appropriate (it's interval of ball travel)
    private bool  m_Start    = false;

    private const int NUM_CTRL_PTS = 4;

    //multiplier for curve and drop offset for breaking balls
    private const float VERT_MULTIPLIER = 0.015f;
    private const float HORI_MULTIPLIER = 0.015f;

    //DEBUG
    LineRenderer line;

    public void Awake()
    {
        m_Start = false;
    }

    public void Update()
    {
        if (!m_Start) return;

        m_Time += Time.deltaTime;

        if (m_Index < m_BallPath.PathPoints.Count && m_Time > m_Speed)
        {
            transform.position = m_BallPath.PathPoints[m_Index++];
            BallTravelEvent.Raise();
            m_Time = 0.0f; //reset the timer
        }
        else if(m_Index >= m_BallPath.PathPoints.Count)
        {
            //Raise the Finish event to the channel
            //Destroy(gameObject);
            BallFinishEvent.Raise();
            m_Start = false;
        }
    }
    public void StartMove()
    {
        m_Start = true;
    }

    public Vector3 InstantiateBallPath(Pitcher.PitchTypeSO selectedType, Vector3 releasePt, Vector3 targetPt)
    {
        m_BallPath = CreatePath(selectedType, releasePt, targetPt);
     
        PointCounts = m_BallPath.PathPoints.Count;

        //Speed
        //total distance / number of bezier path pts / speed of ball in m/s
        //TODO - Const is placeholder. Find best fit constant
        m_Speed = selectedType.MaxSpeed * ((targetPt - releasePt).magnitude / m_BallPath.PathPoints.Count) * SPEED_CONSTANT;
        Debug.Log(m_Speed);

        //DEBUG: Visualization of line
        line = gameObject.AddComponent<LineRenderer>();
        line.positionCount = m_BallPath.PathPoints.Count;
        line.SetPositions(m_BallPath.PathPoints.ToArray());
        line.startWidth = 0.1f;
        line.endWidth = 0.1f;

        //return position ball will arrived
        return m_BallPath.PathPoints.Last();
    }

    public static Bezier CreatePath(Pitcher.PitchTypeSO type, Vector3 releasePt, Vector3 targetPt)
    {
        //for calculating the drop and curve of the ball
        Vector2 delta = new Vector2(-type.CurveOffset * HORI_MULTIPLIER, -type.DropOffset * VERT_MULTIPLIER);

        /*
         * Calculate the control points based on two points and delta (ie. curve changes in ball path)
         */
        Vector3 dir = targetPt - releasePt;

        List<Vector3> ctrlPts = new List<Vector3> { releasePt };

        //interval between the control pts
        float interval = dir.magnitude / (NUM_CTRL_PTS - 1);

        for (int i = 1; i < NUM_CTRL_PTS; ++i)
        {
            Vector3 previousPts = ctrlPts[i - 1];

            Vector3 point = previousPts + (dir.normalized * interval);
            point.y += delta.y * i;
            if (i > NUM_CTRL_PTS - 2)
                point.x += delta.x * i;
            if (i == NUM_CTRL_PTS - 1)
            {
                point.x += delta.x * 10;
            }
            ctrlPts.Add(point);
        }

        //Create bezier path
        return new Bezier(ctrlPts);
    }
}

