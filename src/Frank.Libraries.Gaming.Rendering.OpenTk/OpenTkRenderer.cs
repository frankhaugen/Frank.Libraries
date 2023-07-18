using Frank.Libraries.Gaming.Primitives;
using OpenTK.Graphics.OpenGL;
using OpenTK.Mathematics;
using OpenTK.Windowing.Desktop;
using PrimitiveType = OpenTK.Graphics.OpenGL.PrimitiveType;

namespace Frank.Libraries.Gaming.Rendering.OpenTk;

public class OpenTkRenderer : IRenderer
{
    private readonly GameWindow _gameWindow;

    // private ShaderHandle _shader;
    // private ProgramHandle _program;
    // private ShaderProgram _shaderProgram;
    // private BufferHandle _vbo;

    public OpenTkRenderer()
    {
        _gameWindow = new GameWindow(GameWindowSettings.Default, NativeWindowSettings.Default);
        // _shaderProgram = ShaderAssetsHelper.GetShaderProgram("Default");
        // GL.ClearColor(Color4.Papayawhip);
        GL.Enable(EnableCap.DepthTest);
    }

    public void Render(Scene scene)
    {
        // Initialize and fill VBO
        // _vbo = GL.GenBuffer();
        // GL.BindBuffer(BufferTargetARB.ArrayBuffer, _vbo);

        var vertices = new List<float>();
        foreach (var gameObject in scene.GameObjects)
        {
            if (!gameObject.IsActive) continue;
            foreach (var point in gameObject.Shape.Polygon)
            {
                vertices.Add(point.X);
                vertices.Add(point.Y);
                vertices.Add(point.Z);
            }
        }

        foreach (var f in vertices.ToArray())
        {
            // GL.BufferData<float>(BufferTargetARB.ArrayBuffer, vertices.Count * sizeof(float), f, BufferUsageARB.DynamicDraw);
        }

        // Clear buffer to background color
        var backgroundColor = scene.BackgroundColor;
        GL.ClearColor(backgroundColor.R / 255f, backgroundColor.G / 255f, backgroundColor.B / 255f, backgroundColor.A / 255f);
        GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

        SetShaders();

        // Set up projection matrix
        Matrix4 projection = Matrix4.CreatePerspectiveFieldOfView(MathHelper.DegreesToRadians(scene.Camera.FieldOfView), scene.Camera.AspectRatio, scene.Camera.NearPlaneDistance, scene.Camera.FarPlaneDistance);
        // var projectionLocation = GL.GetUniformLocation(_program, "projection");
        // GL.UniformMatrix4f(projectionLocation, false, in projection);

        // Set up view matrix
        Matrix4 view = Matrix4.LookAt(Vector3Converter.ToVector3(scene.Camera.Position), Vector3Converter.ToVector3(scene.Camera.Target), Vector3Converter.ToVector3(scene.Camera.Up));
        // var viewLocation = GL.GetUniformLocation(_program, "view");
        // GL.UniformMatrix4f(viewLocation, false, in view);

        // Bind the VBO
        // GL.BindBuffer(BufferTargetARB.ArrayBuffer, _vbo);

        // Draw the scene
        // GL.UseProgram(_program);
        GL.DrawArrays(PrimitiveType.Polygon, 0, scene.GameObjects.Count * 8); // assuming 8 vertices per GameObject

        // Swap the front/back buffers so what we just rendered to the back buffer is displayed in the window
        GL.Flush();
    }

    private void SetShaders()
    {
        var vertexShader = GL.CreateShader(ShaderType.VertexShader);
        // var vertexShaderSource = _shaderProgram.VertexShader.Source;
        // GL.ShaderSource(vertexShader, vertexShaderSource);

        // var fragmentShaderSource = _shaderProgram.FragmentShader.Source;
        var fragShader = GL.CreateShader(ShaderType.FragmentShader);
        // GL.ShaderSource(fragShader, fragmentShaderSource);

        // _program = GL.CreateProgram();
        // GL.AttachShader(_program, vertexShader);
        // GL.AttachShader(_program, fragShader);
    }

    // private ShaderHandle CompileShader(string shaderSource, ShaderType shaderType)
    // {
    //     ShaderHandle shader = GL.CreateShader(shaderType);
    //     GL.ShaderSource(shader, shaderSource);
    //     GL.CompileShader(shader);
    //
    //     GL.CompileShader(shader);
    //
    //     return shader;
    // }

    // private ProgramHandle LinkShaders(ShaderHandle vertexShader, ShaderHandle fragmentShader)
    // {
    //     var program = GL.CreateProgram();
    //     GL.AttachShader(program, vertexShader);
    //     GL.AttachShader(program, fragmentShader);
    //     GL.LinkProgram(program);
    //
    //     return program;
    // }

    public void Render(Scene scene, Action<string> callback) => throw new NotImplementedException();
}