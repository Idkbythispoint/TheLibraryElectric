using BoneLib;
using System;
using UnityEngine;

namespace TheLibraryElectric.Misc
{
    public class BootlegPlayerRig : MonoBehaviour
    {
        public Transform leftHand;
        public Transform rightHand;
        public Transform head;

        private Vector3 initialHeadOffset;
        private Vector3 initialRightHandOffset;
        private Vector3 initialLeftHandOffset;
        //quaternions??!!?#?13?!@# luma client leak?!?!
        private Quaternion initialHeadRotation;
        private Quaternion initialRightHandRotation;
        private Quaternion initialLeftHandRotation;

        private bool bootingtheleg = false;

        public void BoottheLeg()
        {
            if (Player.playerHead == null || Player.rightHand == null || Player.leftHand == null)
            {
                return;
            }
            initialHeadOffset = Player.playerHead.gameObject.transform.position - this.transform.position;
            initialRightHandOffset = Player.rightHand.gameObject.transform.position - Player.playerHead.gameObject.transform.position;
            initialLeftHandOffset = Player.leftHand.gameObject.transform.position - Player.playerHead.gameObject.transform.position;

            initialHeadRotation = Quaternion.Inverse(this.transform.rotation) * Player.playerHead.gameObject.transform.rotation;
            initialRightHandRotation = Quaternion.Inverse(Player.playerHead.gameObject.transform.rotation) * Player.rightHand.gameObject.transform.rotation;
            initialLeftHandRotation = Quaternion.Inverse(Player.playerHead.gameObject.transform.rotation) * Player.leftHand.gameObject.transform.rotation;

            bootingtheleg = true;
        }

        void Update()
        {
            if (!bootingtheleg)
            {
                return;
            }

            Vector3 currentRightHandOffset = Player.rightHand.gameObject.transform.position - Player.playerHead.gameObject.transform.position;
            Vector3 currentLeftHandOffset = Player.leftHand.gameObject.transform.position - Player.playerHead.gameObject.transform.position;

            Quaternion currentRightHandRotation = Quaternion.Inverse(Player.playerHead.gameObject.transform.rotation) * Player.rightHand.gameObject.transform.rotation;
            Quaternion currentLeftHandRotation = Quaternion.Inverse(Player.playerHead.gameObject.transform.rotation) * Player.leftHand.gameObject.transform.rotation;

            head.position = this.transform.position + initialHeadOffset;
            rightHand.position = this.transform.position + currentRightHandOffset + initialRightHandOffset;
            leftHand.position = this.transform.position + currentLeftHandOffset + initialLeftHandOffset;

            head.rotation = this.transform.rotation * initialHeadRotation;
            rightHand.rotation = Player.playerHead.gameObject.transform.rotation * currentRightHandRotation * initialRightHandRotation;
            leftHand.rotation = Player.playerHead.gameObject.transform.rotation * currentLeftHandRotation * initialLeftHandRotation;
        }
    }
}
