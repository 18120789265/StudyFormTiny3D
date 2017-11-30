﻿using MyTiny3D.Math;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyTiny3D.RenderData
{
    /// <summary>
    /// 颜色（0-1）
    /// </summary>
    class Color
    {
        float _r, _g, _b;

        public float r {
            get { return MathUntil.Range(_r, 0, 1); }
            set { _r = MathUntil.Range(value, 0, 1); }
        }

        public float g
        {
            get { return MathUntil.Range(_g, 0, 1); }
            set { _r = MathUntil.Range(value, 0, 1); }
        }

        public float b
        {
            get { return MathUntil.Range(_b, 0, 1); }
            set { _r = MathUntil.Range(value, 0, 1); }
        }

        public Color() { }

        public Color(float r, float g, float b) {
            this.r = r;
            this.g = g;
            this.b = b;
        }

        public Color(System.Drawing.Color c) {
            this.r = c.R / 255;
            this.g = c.G / 255;
            this.b = c.B / 255;
        }

        /// <summary>
        /// 转换成系统颜色
        /// </summary>
        /// <returns></returns>
        public System.Drawing.Color TransFormToSystemColor() {
            float r = this.r * 255;
            float g = this.g * 255;
            float b = this.b * 255;
            return System.Drawing.Color.FromArgb((int)r, (int)g, (int)b);
        }

        /// <summary>
        /// 颜色乘法，调制
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Color operator *(Color a, Color b) {
            Color c = new Color();
            c.r = a.r * b.r;
            c.g = a.g * b.g;
            c.b = a.b * b.b;
            return c;
        }

        public static Color operator *(float a, Color b)
        {
            Color c = new Color();
            c.r = a * b.r;
            c.g = a * b.g;
            c.b = a * b.b;
            return c;
        }
        public static Color operator *(Color a, float b)
        {
            Color c = new Color();
            c.r = a.r * b;
            c.g = a.g * b;
            c.b = a.b * b;
            return c;
        }

        public static Color operator +(Color a, Color b)
        {
            Color c = new Color();
            c.r = a.r + b.r;
            c.g = a.g + b.g;
            c.b = a.b + b.b;
            return c;
        }

    }
}
