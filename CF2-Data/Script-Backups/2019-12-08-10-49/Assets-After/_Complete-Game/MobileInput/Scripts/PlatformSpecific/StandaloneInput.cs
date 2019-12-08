﻿using System;
using UnityEngine;

namespace UnitySampleAssets.CrossPlatformInput.PlatformSpecific
{
    public class StandaloneInput : VirtualInput
    {
        public override float GetAxis(string name, bool raw)
        {
            return raw ? ControlFreak2.CF2Input.GetAxisRaw(name) : ControlFreak2.CF2Input.GetAxis(name);
        }


        public override bool GetButton(string name)
        {
            return ControlFreak2.CF2Input.GetButton(name);
        }


        public override bool GetButtonDown(string name)
        {
            return ControlFreak2.CF2Input.GetButtonDown(name);
        }


        public override bool GetButtonUp(string name)
        {
            return ControlFreak2.CF2Input.GetButtonUp(name);
        }


        public override void SetButtonDown(string name)
        {
            throw new Exception(
                " This is not possible to be called for standalone input. Please check your platform and code where this is called");
        }


        public override void SetButtonUp(string name)
        {
            throw new Exception(
                " This is not possible to be called for standalone input. Please check your platform and code where this is called");
        }


        public override void SetAxisPositive(string name)
        {
            throw new Exception(
                " This is not possible to be called for standalone input. Please check your platform and code where this is called");
        }


        public override void SetAxisNegative(string name)
        {
            throw new Exception(
                " This is not possible to be called for standalone input. Please check your platform and code where this is called");
        }


        public override void SetAxisZero(string name)
        {
            throw new Exception(
                " This is not possible to be called for standalone input. Please check your platform and code where this is called");
        }


        public override void SetAxis(string name, float value)
        {
            throw new Exception(
                " This is not possible to be called for standalone input. Please check your platform and code where this is called");
        }


        public override Vector3 MousePosition()
        {
            return ControlFreak2.CF2Input.mousePosition;
        }
    }
}