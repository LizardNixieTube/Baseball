using UnityEngine;

namespace Util
{
    public static class CameraTranform 
    {
        //https://baba-s.hatenablog.com/entry/2019/10/03/090000
        //Convert from world position to screenposition inside the canvas
        public static Vector3 WorldToScreenSpaceCamera(Camera worldCamera, Camera canvasCamera, RectTransform canvasRectTransform, Vector3 worldPosition)
        {
            var screenPoint = RectTransformUtility.WorldToScreenPoint(cam: worldCamera, worldPoint: worldPosition);
            RectTransformUtility.ScreenPointToLocalPointInRectangle(rect: canvasRectTransform, screenPoint: screenPoint, cam: canvasCamera, localPoint: out var localPoint);

            return localPoint;
        }

        //http://alien-program.hatenablog.com/entry/2017/08/06/164258
        //Conver the screen position to world position
        public static Vector3 ScreenToWorldPointCamera(Camera canvasCamera, RectTransform rect)
        {
            Vector2 screenPos = RectTransformUtility.WorldToScreenPoint(canvasCamera, rect.position);

            //Conver the screen position to world position
            RectTransformUtility.ScreenPointToWorldPointInRectangle(rect, screenPos, canvasCamera, out var result);

            return result;
        }
    }
}
