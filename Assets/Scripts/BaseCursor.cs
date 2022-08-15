using UnityEngine;

/*
 * A base cursor class that helps navigate the cursor around the rectangle UI
    with two outline boundry
 */
public class BaseCursor : MonoBehaviour
{
    //how much cursor can go outside the boudry
    public float OutBoundLimit = 0f;
    public RectTransform BorderRectT;
    
    public float Speed = 500f;

    protected RectTransform m_Cursor;
    protected Vector2 m_Dir;
    protected Vector3 m_CenterPosition;

    //boundry inside the yellow border (ie.strike zone)
    private Vector2 m_xBoundry;
    private Vector2 m_yBoundry;
    //boundry limit how far cursor can go outside the strike zone
    private Vector2 m_xOutBoundry;
    private Vector2 m_yOutBoundry;

    //cursor speed - TODO it should be mutable

    // This will get the rect transform of cursor and calculate the corner pts of the border and outside 
    public void Awake()
    {
        m_Cursor = GetComponent<RectTransform>();

        m_CenterPosition = m_Cursor.localPosition;

        //calculate boundary of the rectangle
        Vector2 halfsize = BorderRectT.sizeDelta / 2;
        m_xBoundry = new Vector2(BorderRectT.transform.localPosition.x - halfsize.x, BorderRectT.transform.localPosition.x + halfsize.x);
        m_yBoundry = new Vector2(BorderRectT.transform.localPosition.y - halfsize.y, BorderRectT.transform.localPosition.y + halfsize.y);

        //Find out how far cursor can go outside the boundary
        m_xOutBoundry = new Vector2(m_xBoundry.x - OutBoundLimit, m_xBoundry.y + OutBoundLimit);
        m_yOutBoundry = new Vector2(m_yBoundry.x - OutBoundLimit, m_yBoundry.y + OutBoundLimit);
    }

    public void Update()
    {
        m_Cursor.localPosition += new Vector3(m_Dir.x, m_Dir.y) * Speed * Time.deltaTime;
        Vector2 local = m_Cursor.localPosition;
        local.x = Mathf.Clamp(local.x, m_xOutBoundry.x, m_xOutBoundry.y);
        local.y = Mathf.Clamp(local.y, m_yOutBoundry.x, m_yOutBoundry.y);
        m_Cursor.localPosition = local;
    }

    protected void MoveCursor(Vector2 dir)
    {
        m_Dir = dir;
    }

    protected bool InsideTheBound()
    {
        Vector2 pos = m_Cursor.localPosition;
        return (pos.x >= m_xBoundry.x && pos.x <= m_xBoundry.y && pos.y >= m_yBoundry.x && pos.y <= m_yBoundry.y);
    }
}
