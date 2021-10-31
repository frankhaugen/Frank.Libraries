using System;
using System.Drawing;
using OpenTK.Graphics.OpenGL4;
using OpenTK.Mathematics;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;
using OpenTK.Windowing.GraphicsLibraryFramework;

namespace Frank.Libraries.Gaming.Engine
{
    public class ViewScreen : GameWindow
    {
        public ViewScreen(GameWindowSettings gameWindowSettings, NativeWindowSettings nativeWindowSettings) : base(gameWindowSettings, nativeWindowSettings)
        {
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            KeyboardState input = KeyboardState.GetSnapshot();

            if (input.IsKeyDown(Keys.Space))
            {
                this.Title = "Oh yeah";
            }

            if (input.IsKeyDown(Keys.Escape))
            {
                this.Close();
            }

            base.OnUpdateFrame(e);
        }
        protected override void OnRenderFrame(FrameEventArgs e)
        {
            Title = $"(Vsync: {VSync}) FPS: {1f / e.Time:0}";

            Color4 backColor;
            backColor.A = 1.0f;
            backColor.R = 0.1f;
            backColor.G = 0.1f;
            backColor.B = 0.3f;
            GL.ClearColor(backColor);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            float[] vertices = {
                -0.5f, -0.5f, 0.0f, //Bottom-left vertex
                0.5f, -0.5f, 0.0f,  //Bottom-right vertex
                0.0f,  0.5f, 0.0f   //Top vertex
            };

            SwapBuffers();
        }
    }
}