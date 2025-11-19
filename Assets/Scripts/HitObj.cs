using UnityEngine;
using UnityEngine.EventSystems;
public class HItObj : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    Material material;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        material = GetComponent<Renderer>().material;
    }
    public void MouseOn()
    {
        material.color = Color.blue;
    }
    public void MouseOff()
    {
        material.color = Color.white;
    }
    // Update is called once per fram




    public void OnPointerEnter(PointerEventData eventData)
    {
        MouseOn();
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        MouseOff();
    }
    void Update()
    {

    }
}