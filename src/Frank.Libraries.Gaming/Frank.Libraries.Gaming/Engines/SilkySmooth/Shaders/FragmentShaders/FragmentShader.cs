namespace Frank.Libraries.Gaming.Engines.SilkySmooth.Shaders.FragmentShaders;

public class FragmentShader : IShaderSource
{
    public string SourceCode { get; } = """
                                        
                                            #version 330 core
                                            out vec4 FragColor;
                                            void main()
                                            {
                                                FragColor = vec4(1.0f, 1.0f, 1.0f, 1.0f);
                                            }
                                        """;
}