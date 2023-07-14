using System.Text;
using Frank.Libraries.Gaming.Engines.MonoEngine.Collisions;
using Frank.Libraries.Gaming.Engines.MonoGameEngine.Ai;
using Frank.Libraries.Gaming.Engines.MonoGameEngine.Extensions;
using Frank.Libraries.Gaming.Engines.MonoGameEngine.GameObjects;
using Frank.Libraries.Gaming.Engines.MonoGameEngine.Physics;
using Frank.Libraries.Gaming.Engines.MonoGameEngine.Premades;
using Frank.Libraries.Gaming.Engines.MonoGameEngine.Rendering;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Frank.Libraries.Gaming.Engines.MonoGameEngine;

public class PongGame : Game
{
    private readonly IGraphicsDeviceContext _graphicsDeviceContext;
    private readonly GameObjectCollection _gameObjects = new();
    private readonly IPhysicsEngine _physicsEngine = new PhysicsEngine();
    private readonly Camera _camera;
    private readonly KeyboardHandler _keyboardHandler = new();
    private readonly Dictionary<string, TextBox> _textBoxes = new();
    private readonly PointCounter _pointCounter = new();
    private PongAi _pongAi;
    private IRenderer _renderer;
    private OuterBounds _outerBounds;
    private bool _showDebug = false;

    private GameObjectCollider _ballCollider;

    public PongGame()
    {
        WorldState.Bounds = new Rectangle(0, 0, 1920, 1080);
        _graphicsDeviceContext = new GraphicsDeviceContext(new GraphicsDeviceManager(this));
        _graphicsDeviceContext.Initialize();

        _camera = new Camera();

        Content.RootDirectory = "Content";

        IsMouseVisible = true;
    }

    protected override void LoadContent()
    {
        var spriteFont = Content.Load<SpriteFont>("Text");
        _renderer = new Renderer(_graphicsDeviceContext, _camera, spriteFont);

        RegisterGameObjects();
        RegisterKeyboardActions();

        WorldState.PlayArea = _outerBounds.GetBounds();
        CenterCameraOnBounds();

        base.LoadContent();
    }

    protected override void Update(GameTime gameTime)
    {
        _physicsEngine.Update(_gameObjects, gameTime);
        _pointCounter.Update(_gameObjects);
        _keyboardHandler.HandleKeyInput();

        _pongAi.Update();

        if (_showDebug)
        {
            _textBoxes["CameraDebug"] = new TextBox()
            {
                Text = CreateDebugText(),
                Color = Color.Pink,
                Scale = 12,
                Position = Vector2.Zero,
                ShowBorder = true,
                Rotation = 0f
            };
        }

        var points = new TextBox()
        {
            Text = $"{WorldState.PlayerPoints:0000} | {WorldState.AiPoints:0000}",
            Color = Color.Aquamarine,
            Scale = 25,
            Position = _outerBounds.GetBounds()
                                   .GetCenter()
                       + new Vector2(-25, 0),
            ShowBorder = true,
            Rotation = 0f
        };

        _textBoxes["Points"] = points;

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.Black);
        foreach (var gameObject in _gameObjects)
            _renderer.Draw(gameObject);
        foreach (var textBox in _textBoxes)
            _renderer.Draw(textBox.Value);
    }

    protected override void OnExiting(object sender, EventArgs args)
    {
        base.OnExiting(sender, args);
        Environment.Exit(0);
    }

    private void RegisterGameObjects()
    {
        _outerBounds = new OuterBounds(12.5f)
        {
            PhysicalProperties =
            {
                IsStatic = true
            },
            Transform = { Position = WorldState.Bounds.GetCenter() }
        };

        var playerPaddle = new Paddle()
        {
            Name = "Player",
            Transform = { Position = WorldState.Bounds.GetLeftCenter() + new Vector2(25, 0) },
            PhysicalProperties = { IsCollider = true }
        };

        var aiPaddle = new Paddle()
        {
            Name = "AiPaddle",
            Transform = { Position = WorldState.Bounds.GetRightCenter() + new Vector2(-25, 0) },
            PhysicalProperties = { IsCollider = true }
        };

        var ball = new Ball(10, Color.RoyalBlue)
        {
            Transform = { Position = WorldState.Bounds.GetCenter() },
            PhysicalProperties =
            {
                Velocity = new Vector2(WorldState.BallSpeed, WorldState.BallSpeed),
                IsBouncy = true
            }
        };

        _pongAi = new PongAi(aiPaddle, ball);

        _gameObjects.Add(playerPaddle);
        _gameObjects.Add(aiPaddle);
        _gameObjects.Add(ball);
        _gameObjects.Add(_outerBounds);
    }

    private void RegisterKeyboardActions()
    {
        // Game Actions
        _keyboardHandler.RegisterKeyAction(Keys.Escape, Exit);
        _keyboardHandler.RegisterKeyAction(Keys.Space, () => { _showDebug = true; });

        // Camera Movement
        _keyboardHandler.RegisterKeyAction(Keys.LeftShift, () => UpdateCameraPositionAndTarget(Vector3.Forward * 2));
        _keyboardHandler.RegisterKeyAction(Keys.LeftControl, () => UpdateCameraPositionAndTarget(Vector3.Backward * 2));
        _keyboardHandler.RegisterKeyAction(Keys.Left, () => UpdateCameraPositionAndTarget(Vector3.Left * 2));
        _keyboardHandler.RegisterKeyAction(Keys.Right, () => UpdateCameraPositionAndTarget(Vector3.Right * 2));
        _keyboardHandler.RegisterKeyAction(Keys.Up, () => UpdateCameraPositionAndTarget(Vector3.Up * 2));
        _keyboardHandler.RegisterKeyAction(Keys.Down, () => UpdateCameraPositionAndTarget(Vector3.Down * 2));
        _keyboardHandler.RegisterKeyAction(Keys.F, CenterCameraOnBounds);

        // Paddle Movement
        var paddle = _gameObjects.FirstOrDefault(x => x.Name == "Player");
        if (paddle != null)
        {
            _keyboardHandler.RegisterKeyAction(Keys.W, () => paddle.Transform.Position += (Vector2.UnitY * WorldState.PaddleSpeed));
            _keyboardHandler.RegisterKeyAction(Keys.S, () => paddle.Transform.Position -= (Vector2.UnitY * WorldState.PaddleSpeed));
        }
    }

    private void CenterCameraOnBounds()
    {
        _camera.Position = _outerBounds.Transform.Position.ToVector3(WorldState.DefaultCameraDistance);
        _camera.Target = _outerBounds.GetBounds()
                                     .GetCenter()
                                     .ToVector3();
    }

    private string CreateDebugText()
    {
        var stringBuilder = new StringBuilder();
        stringBuilder.AppendLine(_camera.ToString());

        foreach (var gameObject in _gameObjects)
        {
            stringBuilder.AppendLine(gameObject.ToString());
        }

        return stringBuilder.ToString();
    }

    private void UpdateCameraPositionAndTarget(Vector3 direction)
    {
        _camera.Position += direction;
        // _camera.Target += direction.ToVector2().ToVector3();
    }
}