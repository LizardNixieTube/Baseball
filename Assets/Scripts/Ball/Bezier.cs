using System.Collections.Generic;
using UnityEngine;

//Credit to Wasiim
/**
 * Bezier Curve with 4 control points
 *	maybe it will fun to have more control points to have variety of curve ball
 */
public class Bezier
{
	public List<Vector3> PathPoints;
	private int m_Segments;
	private const int m_TotalPoints = 100;

	//Constructor
	public Bezier(List<Vector3> controlPoints)
	{
		//define the list of vector3
		PathPoints = new List<Vector3>();
		CreateCurve(controlPoints);
	}

	//Calculate Points of Curbe based on Given Control Points
	private void CreateCurve(List<Vector3> controlPoints)
	{
		//divide the points into 4 pts for each m_Segments
		m_Segments = controlPoints.Count / 3;

		//iterate through each m_Segments
		for (int s = 0; s < controlPoints.Count - 3; s += 3)
		{
			Vector3 p0 = controlPoints[s];
			Vector3 p1 = controlPoints[s + 1];
			Vector3 p2 = controlPoints[s + 2];
			Vector3 p3 = controlPoints[s + 3];

			if (s == 0)
			{
				PathPoints.Add(BezierPathCalculation(p0, p1, p2, p3, 0.0f));
			}

			float total_interval = m_TotalPoints / m_Segments;
			for (int p = 0; p < total_interval; p++)
			{
				PathPoints.Add(BezierPathCalculation(p0, p1, p2, p3, 1.0f / total_interval * p));
			}
		}
	}

	/*
	 * Find the points on the curve at time t with given control points
	 * 
	 */ 
	private Vector3 BezierPathCalculation(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
	{
		float tt = t * t;   // t^2
		float ttt = t * tt; // t^3
		float u = 1.0f - t; // 1-t
		float uu = u * u;   // (1-t)^2
		float uuu = u * uu; // (1-t)^3

		//From https://en.wikipedia.org/wiki/Bézier_curve#Cubic_Bézier_curves
		//B =[(1-t)^3 * p0] + [3*(1-t)^2 * t * p1] + [3*(1-t) * t^2 * p2] + [(1-t)^3 * p3]
		Vector3 B = uuu * p0;
		B += 3.0f * uu * t * p1;    //3*(1-t)^2 * t * p1
		B += 3.0f * u * tt * p2;    //3*(1-t) * t^2 * p2
		B += ttt * p3;              //(1-t)^3 * p3

		return B;
	}
}
