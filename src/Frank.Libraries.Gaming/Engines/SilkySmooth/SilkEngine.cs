using System.Drawing;
using Frank.Libraries.Gaming.Engines.SilkySmooth.Shaders;
using Frank.Libraries.Gaming.Engines.SilkySmooth.Types;
using Silk.NET.Input;
using Silk.NET.Maths;
using Silk.NET.OpenGL;
using Silk.NET.Windowing;

namespace Frank.Libraries.Gaming.Engines.SilkySmooth;

public class SilkEngine
{
    private readonly IWindow _window;
    private InputHandler _input;
    private readonly IShaderSource _vertexShaderSource;
    private readonly IShaderSource _fragmentShaderSource;

    private GL _gl;

    private uint _shaderProgram;
    private uint _vbo;
    private uint _ebo;
    private uint _vertexArrayObject;

    private float[] _vertices;
    private uint[] _indices;

    public SilkEngine(IShaderSource vertexShaderSource, IShaderSource fragmentShaderSource)
    {
        _vertexShaderSource = vertexShaderSource;
        _fragmentShaderSource = fragmentShaderSource;

        // Window options
        var windowOptions = WindowOptions.Default;
        windowOptions.Size = new Vector2D<int>(1024, 1024);
        windowOptions.Title = "Silky Smooth";
        windowOptions.VSync = false;
        windowOptions.WindowState = WindowState.Normal;

        // Create window
        _window = Window.Create(windowOptions);

        // Window event handling
        _window.Load += OnLoad;
        _window.Update += OnUpdate;
        _window.Render += OnRender;
        _window.Resize += OnResize;
        _window.Closing += OnClose;
    }

    public void Run()
    {
        _window.Run();
    }

    private void OnClose()
    {
        //Remember to delete the buffers.
        _gl.DeleteBuffer(_vertexArrayObject);
        _gl.DeleteBuffer(_ebo);
        _gl.DeleteVertexArray(_vertexArrayObject);
        _gl.DeleteProgram(_shaderProgram);
    }

    private void OnResize(Vector2D<int> obj)
    {
    }

    private unsafe void OnRender(double obj)
    {
        //Clear the color channel.
        _gl.Clear((uint) ClearBufferMask.ColorBufferBit);

        //Bind the geometry and shader.
        _gl.BindVertexArray(_vertexArrayObject);
        _gl.UseProgram(_shaderProgram);

        //Draw the geometry.
        _gl.DrawElements(PrimitiveType.Triangles, (uint) _indices.Length, DrawElementsType.UnsignedInt, null);
    }

    private void OnUpdate(double obj)
    {

    }

    private unsafe void OnLoad()
    {
        // Keyboard handling
        _input = _window.CreateInputHandler();
        InitializeInput();

        _gl = GL.GetApi(_window);
        var square = PolygonTemplates.Square(new Vertex2D(0, 0), 10, Color.DarkGray);

        _vertices = square.ToArray();
        _indices = square.GetIndices();

        // _shaderProgram = ShaderHelper.LoadShader(_gl, _vertexShaderSource, _fragmentShaderSource);

            //Creating a vertex array.
            _vertexArrayObject = _gl.GenVertexArray();
            _gl.BindVertexArray(_vertexArrayObject);

            //Initializing a vertex buffer that holds the vertex data.
            _vbo = _gl.GenBuffer(); //Creating the buffer.
            _gl.BindBuffer(BufferTargetARB.ArrayBuffer, _vbo); //Binding the buffer.
            fixed (void* v = &_vertices[0])
            {
                _gl.BufferData(BufferTargetARB.ArrayBuffer, (nuint) (_vertices.Length * sizeof(uint)), v, BufferUsageARB.StaticDraw); //Setting buffer data.
            }

            //Initializing a element buffer that holds the index data.
            _ebo = _gl.GenBuffer(); //Creating the buffer.
            _gl.BindBuffer(BufferTargetARB.ElementArrayBuffer, _ebo); //Binding the buffer.
            fixed (void* i = &_indices[0])
            {
                _gl.BufferData(BufferTargetARB.ElementArrayBuffer, (nuint) (_indices.Length * sizeof(uint)), i, BufferUsageARB.StaticDraw); //Setting buffer data.
            }

            //Creating a vertex shader.
            uint vertexShader = _gl.CreateShader(ShaderType.VertexShader);
            _gl.ShaderSource(vertexShader, _vertexShaderSource.SourceCode);
            _gl.CompileShader(vertexShader);

            //Checking the shader for compilation errors.
            string infoLog = _gl.GetShaderInfoLog(vertexShader);
            if (!string.IsNullOrWhiteSpace(infoLog))
            {
                Console.WriteLine($"Error compiling vertex shader {infoLog}");
            }

            //Creating a fragment shader.
            uint fragmentShader = _gl.CreateShader(ShaderType.FragmentShader);
            _gl.ShaderSource(fragmentShader, _fragmentShaderSource.SourceCode);
            _gl.CompileShader(fragmentShader);

            //Checking the shader for compilation errors.
            infoLog = _gl.GetShaderInfoLog(fragmentShader);
            if (!string.IsNullOrWhiteSpace(infoLog))
            {
                Console.WriteLine($"Error compiling fragment shader {infoLog}");
            }

            //Combining the shaders under one shader program.
            _shaderProgram = _gl.CreateProgram();
            _gl.AttachShader(_shaderProgram, vertexShader);
            _gl.AttachShader(_shaderProgram, fragmentShader);
            _gl.LinkProgram(_shaderProgram);

            //Checking the linking for errors.
            _gl.GetProgram(_shaderProgram, GLEnum.LinkStatus, out var status);
            if (status == 0)
            {
                Console.WriteLine($"Error linking shader {_gl.GetProgramInfoLog(_shaderProgram)}");
            }

            //Delete the no longer useful individual shaders;
            _gl.DetachShader(_shaderProgram, vertexShader);
            _gl.DetachShader(_shaderProgram, fragmentShader);
            _gl.DeleteShader(vertexShader);
            _gl.DeleteShader(fragmentShader);

            //Tell opengl how to give the data to the shaders.
            _gl.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, 3 * sizeof(float), null);
            _gl.EnableVertexAttribArray(0);
    }

    private void InitializeInput()
    {
        _input.AddKeyDownAction(Key.Escape, () => _window.Close());
    }

    private static class DemoResources
    {
        //Vertex shaders are run on each vertex.
        public static readonly string VertexShaderSource = @"
        #version 330 core //Using version GLSL version 3.3
        layout (location = 0) in vec4 vPos;

        void main()
        {
            gl_Position = vec4(vPos.x, vPos.y, vPos.z, 1.0);
        }
        ";

        //Fragment shaders are run on each fragment/pixel of the geometry.
        public static readonly string FragmentShaderSource = @"
        #version 330 core
        out vec4 FragColor;

        void main()
        {
            FragColor = vec4(1.0f, 0.5f, 0.2f, 1.0f);
        }
        ";

        //Vertex data, uploaded to the VBO.
        public static readonly float[] Vertices =
        {
            //X    Y      Z
            0.5f,  0.5f, 0.0f,
            0.5f, -0.5f, 0.0f,
            -0.5f, -0.5f, 0.0f,
            -0.5f,  0.5f, 0.5f
        };

        //Index data, uploaded to the EBO.
        public static readonly uint[] Indices =
        {
            0, 1, 3,
            1, 2, 3
        };
    }
}