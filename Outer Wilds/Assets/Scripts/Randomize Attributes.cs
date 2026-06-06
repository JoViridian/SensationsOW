using UnityEngine;

public class RandomizeAttributes : MonoBehaviour
{
    public QuizObject quiz;
    public float primaryOffsetX;
    public float primaryOffsetY;
    public float secondaryOffsetX;
    public float secondaryOffsetY;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (!quiz.complex)
        {
            Material mat = gameObject.GetComponent<Renderer>().material;
            mat.SetColor("_Primary_Color", DoColorConversion(mat.GetColor("_Primary_Color"), primaryOffsetX, primaryOffsetY));
            mat.SetColor("_Secondary_Color", DoColorConversion(mat.GetColor("_Secondary_Color"), secondaryOffsetX, secondaryOffsetY));
            mat.SetFloat("_Slide_Speed", mat.GetFloat("_Slide_Speed") + Random.Range(-0.2f, 0.2f));
            mat.SetFloat("_Slide_Strength", mat.GetFloat("_Slide_Strength") + Random.Range(-0.1f, 0.1f));
            mat.SetFloat("_Pulse_Speed", mat.GetFloat("_Pulse_Speed") + Random.Range(-0.1f, 0.1f));
            mat.SetFloat("_Delay_Offset", Random.Range(0, Mathf.PI));
                Debug.Log(mat.GetFloat("_Delay_Offset"));
        }
    }

    private Color DoColorConversion(Color c, float offsetX, float offsetY)
    {
        float h, s, v;
        Color.RGBToHSV(c, out h, out s, out v);
        Debug.Log(h + "/" + s + "/" + v);
        Color r = Color.HSVToRGB(h + (Random.Range(-offsetX, offsetY)/360), s, v);
        return r;
    }
}
