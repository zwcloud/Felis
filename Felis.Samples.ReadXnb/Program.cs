#region Using

using System;
using Felis.Xnb;

#endregion

namespace Felis.Samples.ReadXnb
{
    class Program
    {
        #region GraphicsDeviceService

        sealed class GraphicsDeviceService : IGraphicsDeviceService
        {
            public GraphicsDevice GraphicsDevice { get; private set; }

            public GraphicsDeviceService()
            {
                GraphicsDevice = new GraphicsDevice();
            }
        }

        #endregion

        #region ServiceProvider

        sealed class ServiceProvider : IServiceProvider
        {
            GraphicsDeviceService graphicsDeviceService;

            public ServiceProvider()
            {
                graphicsDeviceService = new GraphicsDeviceService();
            }

            public object GetService(Type serviceType)
            {
                if (serviceType == typeof(IGraphicsDeviceService))
                    return graphicsDeviceService;

                throw new ArgumentException("Unknown service type: " + serviceType, "serviceType");
            }
        }

        #endregion

        static void Main(string[] args)
        {
            var contentManager = new ContentManager(new ServiceProvider());

            // ビルドインの TypeReader を一括登録。
            contentManager.TypeReaderManager.RegisterStandardTypeReaders();

            // デシリアライズのための TypeBuilder を登録。
            // アセットは模造実装 (Mock 実装) へデシリアライズする想定であり、
            // 各 TypeBuilder は TypeReader からのコールバックにより、
            // 模造実装へデータを設定してアセットをインスタンス化。
            contentManager.TypeReaderManager.RegisterTypeBuilder<Vector3Builder>();
            contentManager.TypeReaderManager.RegisterTypeBuilder<RectangleBuilder>();
            contentManager.TypeReaderManager.RegisterTypeBuilder<MatrixBuilder>();
            contentManager.TypeReaderManager.RegisterTypeBuilder<BoundingSphereBuilder>();
            contentManager.TypeReaderManager.RegisterTypeBuilder<VertexBufferBuilder>();
            contentManager.TypeReaderManager.RegisterTypeBuilder<VertexDeclarationBuilder>();
            contentManager.TypeReaderManager.RegisterTypeBuilder<IndexBufferBuilder>();
            contentManager.TypeReaderManager.RegisterTypeBuilder<BasicEffectBuilder>();
            contentManager.TypeReaderManager.RegisterTypeBuilder<ModelBuilder>();
            contentManager.TypeReaderManager.RegisterTypeBuilder<Texture2DBuilder>();
            contentManager.TypeReaderManager.RegisterTypeBuilder<SpriteFontBuilder>();

            // .xnb を含むディレクトリを指定。
            contentManager.RootDirectory = "Content";

            // XNA Shadow Mapping サンプルの "dude" アセット。
            var dudeModel = contentManager.Load<Model>("dude");
            Console.WriteLine("Model loaded.");

            // スプライト フォント。
            var spriteFont = contentManager.Load<SpriteFont>("SpriteFont");
            Console.WriteLine("SpriteFont loaded.");

            Console.WriteLine("Press enter key to exit...");
            Console.ReadLine();
        }
    }
}
