using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LongClickButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
	public int direction = -1;
	public bool pointerDown = false;
	public moveWorld world;

	public void OnPointerDown(PointerEventData eventData)
	{
		pointerDown = true;
	}

	public void OnPointerUp(PointerEventData eventData)
	{
		pointerDown = false;
	}

	private void Update()
	{
		if (pointerDown)
		{
			world.MoveWorld(direction);		
		}
	}

	

}
