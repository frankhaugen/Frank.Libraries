using Frank.Libraries.Gaming.Core;
using Frank.Libraries.Gaming.Primitives;
using Microsoft.Xna.Framework;
using Color = System.Drawing.Color;
using Vector3 = System.Numerics.Vector3;

namespace Frank.Libraries.Gaming.Rendering.MonoGame;

public class MonogameEngine : Game
{
    private readonly GameEngine _gameEngine;
    private readonly IGraphicsDeviceContext _graphicsDeviceContext;
    private readonly IRenderer _renderer;

    public MonogameEngine(GameEngine gameEngine)
    {
        _gameEngine = gameEngine;
        _graphicsDeviceContext = new GraphicsDeviceContext(new GraphicsDeviceManager(this));
        _renderer = new MonoGameRenderer(_graphicsDeviceContext);
    }

    protected override void Initialize()
    {
        base.Initialize();
    }

    protected override void LoadContent()
    {
        base.LoadContent();

        var shape = ShapeFactory.CreateCube(Color.Chartreuse, 5f);
        var transform = TransformFactory.CreateTransform();
        var gameObject = GameObjectFactory.CreateGameObject(transform, shape, "Test Object");
        var camera = new Camera();
        var scene = new Scene("Test Scene");
        scene.GameObjects.Add(gameObject);
        scene.Camera = camera;

        _gameEngine.SceneManager.GameScenes.Add(scene);
        _gameEngine.SceneManager.SelectScene(scene.Id);
        _gameEngine.Initialize(_renderer);
    }

    protected override void Update(GameTime gameTime)
    {
        base.Update(gameTime);
        // _gameEngine.Update(new UpdateArgs(gameTime.ElapsedGameTime, gameTime.TotalGameTime));
    }

    protected override void Draw(GameTime gameTime)
    {
        base.Draw(gameTime);
        _gameEngine.Draw();
    }

    protected override void Dispose(bool disposing)
    {
        base.Dispose(disposing);
        Exit();
        Environment.Exit(0);
    }
}