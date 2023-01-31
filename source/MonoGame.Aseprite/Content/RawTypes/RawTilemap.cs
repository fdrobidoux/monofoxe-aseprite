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

using System.Collections.ObjectModel;

namespace MonoGame.Aseprite.Content.RawTypes;

/// <summary>
/// Defines a class that represents the raw values of a tilemap.
/// </summary>
public sealed class RawTilemap : IEquatable<RawTilemap>
{
    private RawTileset[] _rawTilesets;
    private RawTilemapLayer[] _rawLayers;

    /// <summary>
    /// Gets the name assigned to the tilemap represented by this raw tilemap record.
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// Gets a read-only span of the raw tileset records that represent the tilesets used by the tilemap layers in the
    /// tilemap represented by this raw tilemap record.
    /// </summary>
    public ReadOnlySpan<RawTileset> RawTilesets => _rawTilesets;

    /// <summary>
    /// Gets a read-only span of the raw tilemap layer records that represent the tilemap layers for the tilemap
    /// represented by this raw tilemap record.
    /// </summary>
    public ReadOnlySpan<RawTilemapLayer> RawLayers => _rawLayers;

    internal RawTilemap(string name, RawTilemapLayer[] rawLayers, RawTileset[] rawTilesets) =>
        (Name, _rawTilesets, _rawLayers) = (name, rawTilesets, rawLayers);

    public bool Equals(RawTilemap? other) => other is not null
                                             && Name == other.Name
                                             && RawTilesets.SequenceEqual(other.RawTilesets)
                                             && RawLayers.SequenceEqual(other.RawLayers);
}
