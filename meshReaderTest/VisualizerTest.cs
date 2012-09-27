﻿using System.Drawing.Imaging;
using meshDatabase;
using meshPather;
using meshPathVisualizer;
using SlimDX;
using NUnit.Framework;
using RecastLayer;

namespace meshReaderTest
{
    
    [TestFixture]
    public class VisualizerTest : MeshTest
    {

        [TestFixtureSetUp]
        public void Initialize()
        {
            MpqManager.Initialize("S:\\World of Warcraft");
            Initialize("S:\\meshReader\\Meshes\\Kalimdor");
            //Pather.LoadAllTiles();
        }

        [Test]
        public void TestMinimapImage()
        {
            float x, y;
            Pather.GetTileByLocation(new[] {-8020, 1515, -1.5f}.ToRecast(), out x, out y);

            var image = new MinimapImage("Azeroth", 256, 256, (int)x, (int)x, (int)y, (int)y);
            image.Generate();
            image.Result.Save("S:\\meshReader\\MinimapImageTest.png", ImageFormat.Png);
        }

        [Test]
        public void TestPathImage()
        {
            System.Collections.Generic.List<Hop> path;
            //TryPath(new Vector3(-8949.918f, -133.572f, 83.589f), new Vector3(-8957.4f, 517.3f, 96.3f), out path, true);
            //TryPath(new Vector3(-8020f, 1515f, -1.5f), new Vector3(-8015f, 1515f, -1.5f), out path, true);
            //TryPath(new Vector3(-8957.4f, 517.3f, 96.3f), new Vector3(-8476.375f, 1257.56f, 5.238828f), out path, true);
            TryPath(new Vector3(1209.394f, -3645.967f, 97.30154f), new Vector3(-448.6f, -2641.4f, 95.5f), out path, true);
            Assert.NotNull(path);

            var image = new PathImage(Pather.Continent, 256 * 3, 256 * 4, path);
            image.Generate();
            image.Result.Save("S:\\meshReader\\PathImageTest.png", ImageFormat.Png);
        }
    }

}