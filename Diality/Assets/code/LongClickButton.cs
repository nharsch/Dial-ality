using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LongClickButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
	public int direction = -1;
	public bool pointerDown = false;
	//private float pointerDownTimer;

	//[SerializeField]
	//private float requiredHoldTime;

	//public UnityEvent onLongClick;

	//[SerializeField]
	//private Image fillImage;
	public moveWorld world;

	public void OnPointerDown(PointerEventData eventData)
	{
		pointerDown = true;
		//Debug.Log("OnPointerDown");
	}

	public void OnPointerUp(PointerEventData eventData)
	{
		pointerDown = false;
		//Reset();
		//Debug.Log("OnPointerUp");
	}

	private void Update()
	{
		if (pointerDown)
		{
			//pointerDownTimer += Time.deltaTime;
			//if (pointerDownTimer >= requiredHoldTime)
			//{
			//	if (onLongClick != null)
			//		onLongClick.Invoke();

			//	Reset();
			//}
			world.MoveWorld(direction);
			//fillImage.fillAmount = pointerDownTimer / requiredHoldTime;
		}
	}

	//private void Reset()
	//{
	//	pointerDown = false;
	//	pointerDownTimer = 0;
		//fillImage.fillAmount = pointerDownTimer / requiredHoldTime;
	//}

}
