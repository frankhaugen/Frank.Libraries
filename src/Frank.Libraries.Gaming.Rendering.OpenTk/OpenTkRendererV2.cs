using System.Globalization;
using Frank.Libraries.Gaming.Primitives;
using Frank.Libraries.Gaming.Rendering.OpenTk.Assets;
using OpenTK.Graphics.OpenGL;
using OpenTK.Mathematics;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;
using PrimitiveType = OpenTK.Graphics.OpenGL.PrimitiveType;

namespace Frank.Libraries.Gaming.Rendering.OpenTk;

public class OpenTkRendererV2 : IRenderer, IDisposable
{
    private GameWindow _gameWindow;
    private readonly ShaderProgramInfo _shaderProgramInfo;
    private int _vbo;
    private Shader _shader; // Ensure you have a Shader class to work with
    private readonly Scene _scene;


    public OpenTkRendererV2(Scene scene)
    {
        _scene = scene;
        _shaderProgramInfo = ShaderAssetsHelper.GetShaderProgramInfo("Default");
        _gameWindow = new(GameWindowSettings.Default, NativeWindowSettings.Default);

        _gameWindow.Load += OnLoad;
        _gameWindow.RenderFrame += OnRenderFrame;
        _gameWindow.Unload += OnUnload;

        _gameWindow.Run();
    }

    public void Render(Scene scene)
    {
        // Clear buffer to background color
        var backgroundColor = _scene.BackgroundColor;
        GL.ClearColor(backgroundColor.R / 255f, backgroundColor.G / 255f, backgroundColor.B / 255f, backgroundColor.A / 255f);
        GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

        // Set up projection matrix
        Matrix4 projection = Matrix4.CreatePerspectiveFieldOfView(MathHelper.DegreesToRadians(_scene.Camera.FieldOfView), _scene.Camera.AspectRatio, _scene.Camera.NearPlaneDistance, _scene.Camera.FarPlaneDistance);
        _shader.SetMatrix4("projection", projection);

        // Set up view matrix
        Matrix4 view = Matrix4.LookAt(Vector3Converter.ToVector3(_scene.Camera.Position), Vector3Converter.ToVector3(_scene.Camera.Target), Vector3Converter.ToVector3(_scene.Camera.Up));
        _shader.SetMatrix4("view", view);

        // Bind the VBO
        GL.BindBuffer(BufferTarget.ArrayBuffer, _vbo);

        // Draw the scene
        _shader.Use();
        GL.DrawArrays(PrimitiveType.Polygon, 0, _scene.GameObjects.Count * 8); // assuming 8 vertices per GameObject

        _gameWindow.SwapBuffers();
    }

    public void Render(Scene scene, Action<string> callback)
    {
        Render(scene);
        callback?.Invoke("Rendering Complete");
    }

    private void OnLoad()
    {
        // Load Shader
        _shader = new Shader(_shaderProgramInfo.VertexShader.Source, _shaderProgramInfo.FragmentShader.Source);

        // Initialize and fill VBO
        _vbo = GL.GenBuffer();
        GL.BindBuffer(BufferTarget.ArrayBuffer, _vbo);

        var vertices = new List<float>();
        foreach (var gameObject in _scene.GameObjects)
        {

            if (!gameObject.IsActive) continue;
            System.Console.WriteLine(gameObject.ToString());

            foreach (var point in gameObject.Shape.Polygon)
            {
                vertices.Add(point.X);
                vertices.Add(point.Y);
                vertices.Add(point.Z);
            }
        }

        GL.BufferData(BufferTarget.ArrayBuffer, vertices.Count * sizeof(float), vertices.ToArray(), BufferUsageHint.StaticDraw);

        System.Console.WriteLine(string.Join(", ", vertices.ToArray().Select(x => x.ToString(CultureInfo.InvariantCulture))));
    }

    private void OnRenderFrame(FrameEventArgs obj)
    {
        Render(_scene);
    }

    private void OnUnload()
    {
        GL.BindBuffer(BufferTarget.ArrayBuffer, 0);
        GL.DeleteBuffer(_vbo);
        _shader.Dispose();
    }

    public void Dispose()
    {
        _gameWindow.Dispose();
    }
}