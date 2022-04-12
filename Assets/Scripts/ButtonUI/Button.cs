using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(SpriteRenderer))]
public class Button : MonoBehaviour, IPointerEnterHandler
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private Image _button;

    [SerializeField] private Color _targetColor;


    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void ChangeColor()
    {
        _button.color = _targetColor;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        _audioSource.Play();
        ChangeColor();
    }
}
