using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LongClickMove : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
	public float direction = -1f;
	public float moveSpeed = 50f;
	public bool pointerDown = false;
	public GameObject movableObj;
	public float maxBound = 60f;
	private float change = 0f;
	private float bound = 0f;
	private Transform imageTran;

	private void Start()
	{
		imageTran = this.gameObject.GetComponent<Image>().transform;
	}
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
			change = 1 * moveSpeed * direction * Time.deltaTime;
			bound += change;
			movableObj.transform.Translate(Vector3.right * change);

			if ((bound > maxBound) || (bound < -maxBound))
			{
				direction *= -1;

				Vector3 theScale = imageTran.localScale;
				theScale.x *= -1;
				transform.localScale = theScale;
				
				//movableObj.transform.Translate(Vector3.up * change);
			}
		}
		
	}



}