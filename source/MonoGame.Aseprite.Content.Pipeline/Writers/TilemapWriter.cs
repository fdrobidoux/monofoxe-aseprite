/* ----------------------------------------------------------------------------
MIT License

Copyright (c) 2018-2023 Christopher Whitley

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
---------------------------------------------------------------------------- */

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content.Pipeline;
using Microsoft.Xna.Framework.Content.Pipeline.Serialization.Compiler;
using MonoGame.Aseprite.Content.Pipeline.AsepriteTypes;
using MonoGame.Aseprite.Content.Pipeline.Processors;

namespace MonoGame.Aseprite.Content.Pipeline.Writers;

[ContentTypeWriter]
public sealed class TilemapWriter : ContentTypeWriter<TilemapProcessorResult>
{
    protected override void Write(ContentWriter writer, TilemapProcessorResult content)
    {
        //  Tileset content
        writer.Write(content.Tilesets.Count);
        for (int i = 0; i < content.Tilesets.Count; i++)
        {
            TilesetContent tileset = content.Tilesets[i];
            writer.Write(tileset.Name);
            writer.Write(tileset.TileCount);
            writer.Write(tileset.TileWidth);
            writer.Write(tileset.TileHeight);

            //  Texture Content
            writer.WriteTextureContent(tileset.TextureContent);
            // writer.Write(tileset.TextureContent.Width);
            // writer.Write(tileset.TextureContent.Height);
            // writer.Write(tileset.TextureContent.Pixels.Length);
            // for (int j = 0; j < tileset.TextureContent.Pixels.Length; j++)
            // {
            //     writer.Write(tileset.TextureContent.Pixels[j]);
            // }
        }

        //  Layer Content
        writer.Write(content.Layers.Count);
        for (int i = 0; i < content.Layers.Count; i++)
        {
            TilemapLayerContent layer = content.Layers[i];
            writer.Write(layer.TilesetID);
            writer.Write(layer.Name);
            writer.Write(layer.Columns);
            writer.Write(layer.Rows);
            writer.Write(layer.Offset.X);
            writer.Write(layer.Offset.Y);

            //  Tile content
            writer.Write(layer.Tiles.Length);
            for (int j = 0; j < layer.Tiles.Length; j++)
            {
                TileContent tile = layer.Tiles[j];
                writer.Write(tile.FlipFlag);
                writer.Write(tile.Rotation);
                writer.Write(tile.TilesetTileID);
            }

        }
    }

    public override string GetRuntimeReader(TargetPlatform targetPlatform)
    {
        return "MonoGame.Aseprite.Content.Pipeline.Readers.TilemapReader, MonoGame.Aseprite";
    }
}
