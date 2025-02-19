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

namespace MonoGame.Aseprite.AsepriteTypes;

/// <summary>
///     Defines a  <see cref="AsepriteLayer"/> of an aseprite image.
/// </summary>
public class AsepriteLayer
{
    //  Used for serialization when writing to file with AsepriteFileWriter
    internal int SerializationID { get; set; }

    /// <summary>
    ///     Gets the flags set for this  <see cref="AsepriteLayer"/>.
    /// </summary>
    public AsepriteLayerFlags Flags { get; }

    /// <summary>
    ///     Gets a value that indicates whether this  <see cref="AsepriteLayer"/> is visible.
    /// </summary>
    public bool IsVisible => Flags.HasFlag(AsepriteLayerFlags.Visible);

    /// <summary>
    ///     Gets a value that indicates whether this  <see cref="AsepriteLayer"/> was set as the background  
    ///     layer in aseprite.
    /// </summary>
    public bool IsBackground => Flags.HasFlag(AsepriteLayerFlags.Background);

    /// <summary>
    ///     Gets a value that indicates whether this  <see cref="AsepriteLayer"/> is a reference layer.
    /// </summary>
    public bool IsReference => Flags.HasFlag(AsepriteLayerFlags.ReferenceLayer);

    /// <summary>
    ///     Gets a the <see cref="AsepriteBlendMode"/> used by this  <see cref="AsepriteLayer"/>.
    /// </summary>
    public AsepriteBlendMode BlendMode { get; }

    /// <summary>
    ///     Gets the opacity level of this  <see cref="AsepriteLayer"/>.
    /// </summary>
    public int Opacity { get; }

    /// <summary>
    ///     Gets the name assigned to this  <see cref="AsepriteLayer"/>.
    /// </summary>
    public string Name { get; }

    /// <summary>
    ///     Gets the <see cref="AsepriteUserData"/> that was set for this  <see cref="AsepriteLayer"/> in aseprite.
    /// </summary>
    public AsepriteUserData UserData { get; } = new();

    internal AsepriteLayer(AsepriteLayerFlags flags, AsepriteBlendMode blendMode, int opacity, string name) =>
        (Flags, BlendMode, Opacity, Name) = (flags, blendMode, opacity, name);
}
