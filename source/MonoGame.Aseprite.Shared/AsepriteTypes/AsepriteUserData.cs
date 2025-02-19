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

using System.Diagnostics.CodeAnalysis;
using Microsoft.Xna.Framework;

namespace MonoGame.Aseprite.AsepriteTypes;

/// <summary>
///     Represents the custom userdata that can be set for a <see cref="AsepriteFile"/>, <see cref="AsepriteCel"/>, 
///     <see cref="AsepriteLayer"/>, <see cref="AsepriteSlice"/>, or <see cref="AsepriteTag"/> element in aseprite.
/// </summary>
public sealed class AsepriteUserData
{
    /// <summary>
    ///     Gets a value that indicates if this <see cref="AsepriteUserData"/> contains a text value.  When this is 
    ///     <see langword="true"/>, guarantees that the <see cref="Text"/> value is not <see langword="null"/>.
    /// </summary>
    [MemberNotNullWhen(true, nameof(Text))]
    public bool HasText => Text is not null;

    /// <summary>
    ///     Gets the custom text that was set for this <see cref="AsepriteUserData"/>, if any was set in aseprite; 
    ///     otherwise, <see langword="null"/>.
    /// </summary>
    public string? Text { get; internal set; } = default;

    /// <summary>
    ///     Gets a value that indicates whether this <see cref="AsepriteUserData"/> contains a color value.  When 
    ///     <see langword="true"/>, guarantees that the <see cref="AsepriteUserData.Color"/> value is not 
    ///     <see langword="null"/>.
    /// </summary>
    [MemberNotNullWhen(true, nameof(Color))]
    public bool HasColor => Color is not null;

    /// <summary>
    ///     Gets the custom color that was set for this <see cref="AsepriteUserData"/>, if any was set in aseprite; 
    ///     otherwise, <see langword="null"/>.
    /// </summary>
    public Color? Color { get; internal set; } = default;

    internal AsepriteUserData() { }
}
