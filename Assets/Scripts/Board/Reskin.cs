using System;
using UnityEngine;

public class Reskin : MonoBehaviour
{
        public ReskinData data;

        public SpriteRenderer spriteRenderer;
        
        private void Start()
        {
                if (this.data != null)
                {
                        this.spriteRenderer.sprite = this.data.sprite;
                }          
        }
}