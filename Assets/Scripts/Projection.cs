using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Projection : MonoBehaviour
{
    [SerializeField] private Renderer _renderer;
    [SerializeField] private Text _text;
    [SerializeField] private Transform _visualtransform;

    // Start is called before the first frame update
    public void Setup(Material material, string numberText, float radius)
    {
        _renderer.material = material;
        _text.text = numberText;
        _visualtransform.localScale = Vector3.one * radius*2f;
    }

    // Update is called once per frame
    public void Show()
    {
        gameObject.SetActive(true);

    }
    public void Hide()
    {
        gameObject.SetActive(false);

    }
    public void SetPosition(Vector3 position)
    {
        transform.position = position;

    }


}
