using UnityEngine;
using System.Collections;
using System.Text.RegularExpressions;
[ExecuteInEditMode]
public class ObjectNameView : MonoBehaviour
{
	public string text = "<b>Укажите</b> <color=#ffea00>имя</color> объекта";
	public int textSize = 14;
	public Font textFont;
	public Color textColor = Color.white;
	public float textHeight = 1.15f;
	public bool showShadow = true;
	public Color shadowColor = new Color(0, 0, 0, 0.5f);
	public Vector2 shadowOffset = new Vector2(1, 1);
	private string textShadow;
	GameObject cam;
	Camera camera1;
	Collider objCollider;
	//Plane[] planes;
	void Awake()
	{
		//enabled = false;
		TextShadowReady();
		cam = GameObject.Find("Main Camera");
	}
	void Start()
	{
		camera1 = Camera.main;
		//planes = GeometryUtility.CalculateFrustumPlanes(camera1);
		objCollider = GetComponent<Collider>();
	}
	void TextShadowReady()
	{
		//textShadow = Regex.Replace(text, "<color[^>]+>|</color>", string.Empty);
		textShadow = Regex.Replace(gameObject.name, "<color[^>]+>|</color>", string.Empty);
	}
	void OnGUI()
	{
		GUI.depth = 9999;
		GUIStyle style = new GUIStyle();
		style.fontSize = textSize;
		style.richText = true;
		if (textFont) style.font = textFont;
		style.normal.textColor = textColor;
		style.alignment = TextAnchor.MiddleCenter;
		GUIStyle shadow = new GUIStyle();
		shadow.fontSize = textSize;
		shadow.richText = true;
		if (textFont) shadow.font = textFont;
		shadow.normal.textColor = shadowColor;
		shadow.alignment = TextAnchor.MiddleCenter;
		Vector3 worldPosition = new Vector3(transform.position.x, transform.position.y + textHeight, transform.position.z);
		Vector3 screenPosition = Camera.main.WorldToScreenPoint(worldPosition);
		screenPosition.y = Screen.height - screenPosition.y;
		//if (showShadow) GUI.Label(new Rect(screenPosition.x + shadowOffset.x, screenPosition.y + shadowOffset.y, 0, 0), textShadow, shadow);
		//GUI.Label(new Rect(screenPosition.x, screenPosition.y, 0, 0), text, style);
		float dist = Vector3.Distance(cam.transform.position, gameObject.transform.position);
		//if (dist < 8f && GeometryUtility.TestPlanesAABB(planes, objCollider.bounds))
		if (dist < 8f)
		{
			string gameObjName = "<color=#ffea00>" + gameObject.name + "</color>";
			GUI.Label(new Rect(screenPosition.x, screenPosition.y, 0, 0), gameObjName, style);
			GUI.Label(new Rect(screenPosition.x + shadowOffset.x, screenPosition.y + shadowOffset.y, 0, 0), textShadow, shadow);
		}
		else
		{
			GUI.Label(new Rect(screenPosition.x, screenPosition.y, 0, 0), "", style);
			GUI.Label(new Rect(screenPosition.x + shadowOffset.x, screenPosition.y + shadowOffset.y, 0, 0), "", shadow);
		}
	}
	/*void OnBecameVisible()
	{
		enabled = true;
	}

	void OnBecameInvisible()
	{
		enabled = false;
	}*/
}