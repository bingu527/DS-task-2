using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Valve.VR.InteractionSystem.Sample
{
    public class buton : MonoBehaviour
    {
        public Transform teleport;
        private Transform Player;
        private GameObject gamePlayer;

        void Start()
        {
            gamePlayer = GameObject.Find("Player");
            if (gamePlayer != null)
            {
                Player = gamePlayer.transform;
            }
        }

        public void OnButtonDown(Hand fromHand)
        {
            ColorSelf(Color.green);
            TeleportPlayer();
        }
        public void OnButtonUp(Hand fromHand)
        {
            ColorSelf(Color.red);
        }
        private void ColorSelf(Color newColor)
        {
            Renderer[] renderers = this.GetComponentsInChildren<Renderer>();
            for (int rendererIndex = 0; rendererIndex < renderers.Length; rendererIndex++)
            {
                renderers[rendererIndex].material.color = newColor;
            }
        }
        private void TeleportPlayer()
        {
            Player.position = teleport.position;
        }
    }
}
