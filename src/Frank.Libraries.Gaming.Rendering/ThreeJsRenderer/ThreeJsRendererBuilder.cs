using System.Drawing;
using System.Numerics;
using System.Text;
using Frank.Libraries.Gaming.Primitives;

namespace Frank.Libraries.Gaming.Rendering.ThreeJsRenderer;

public class ThreeJsRendererBuilder
{
    private readonly StringBuilder _stringBuilder = new();

    public ThreeJsRendererBuilder WithCreateMeshesFunction(IEnumerable<Shape> shapes)
    {
        _stringBuilder.AppendLine(
            """
            function CreateMeshes() {
                var meshes = [];
            """);

        foreach (var shape in shapes) _stringBuilder.AppendLine(CreateJsPushMesh(shape));

        _stringBuilder.AppendLine("    return meshes;");
        _stringBuilder.AppendLine("}");
        return this;
    }

    public static string CreateJsPushMesh(Shape shape) => $"meshes.push(CreateMesh({CreateJsPolygon(shape.Polygon)}, {CreateJsColor(shape.Color)}));";
    public static string CreateJsColor(Color color) => $"0x{color.R:X2}{color.G:X2}{color.B:X2}";
    private static string CreateJsPolygon(IEnumerable<Vector3> polygon) => $"[{string.Join(", ", polygon.Select(CreateJsVector3))}]";
    private static string CreateJsVector3(Vector3 vector3) => $"new THREE.Vector3({vector3.X}, {vector3.Y}, {vector3.Z})";

    public ThreeJsRendererBuilder WithImports()
    {
        _stringBuilder.AppendLine(
            """
            import * as THREE from 'three';
            import { ConvexGeometry } from 'three/addons/geometries/ConvexGeometry.js';
            """);
        return this;
    }

    public ThreeJsRendererBuilder WithCreateRendererFunction()
    {
        _stringBuilder.AppendLine(
            """
            function CreateRenderer(width, height) {
                var renderer = new THREE.WebGLRenderer();
                renderer.setSize(width, height);
                document.body.appendChild(renderer.domElement);
                return renderer;
            }
            """);
        return this;
    }

    public ThreeJsRendererBuilder WithCreateMeshFunction(bool wireframe = true)
    {
        _stringBuilder.AppendLine(
            $$"""
            function CreateMesh(vertices, color) {
                var geometry = CreateGeometry(vertices);
                var material = new THREE.MeshBasicMaterial({
                    color: color,
                    wireframe: {{wireframe.ToString().ToLower()}} // Make it a wireframe
                });
                material.side = THREE.DoubleSide;
                return new THREE.Mesh(geometry, material);
            }
            """);
        return this;
    }


    public ThreeJsRendererBuilder WithCreateGeometryFunction()
    {
        _stringBuilder.AppendLine(
            """
            function CreateGeometry(vertices) {
                var geometry = new ConvexGeometry(vertices);
                return geometry;
            }
            """);
        return this;
    }

    public ThreeJsRendererBuilder WithCreateCameraFunction(Camera camera)
    {
        _stringBuilder.AppendLine(
              $$"""
              function CreateCamera() {
                var camera = new THREE.PerspectiveCamera({{camera.FieldOfView}}, {{camera.AspectRatio}}, {{camera.NearPlaneDistance}}, {{camera.FarPlaneDistance}});
                camera.position.x = {{camera.Position.X}};
                camera.position.y = {{camera.Position.Y}};
                camera.position.z = {{camera.Position.Z}};

                camera.lookAt({{CreateJsVector3(camera.Target)}});

                return camera;
              }
              """);
        return this;
    }

    public ThreeJsRendererBuilder WithCreateSceneFunction()
    {
        _stringBuilder.AppendLine(
            $$"""
            function CreateScene() {
                const width = window.innerWidth - 20;
                const height = window.innerHeight - 20;;

                var camera = CreateCamera();
                var renderer = CreateRenderer(width, height);
                var scene = new THREE.Scene();
                var meshes = CreateMeshes();

                for (var i = 0; i < meshes.length; i++) {
                    scene.add(meshes[i]);
                }

                renderer.render(scene, camera);
            }
            """);
        return this;
    }

    public ThreeJsRendererBuilder WithEntryCall()
    {
        _stringBuilder.AppendLine("CreateScene();");
        return this;
    }

    public string Build() => _stringBuilder.ToString();
}