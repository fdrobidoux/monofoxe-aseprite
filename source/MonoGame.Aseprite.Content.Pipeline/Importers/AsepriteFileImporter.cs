﻿/* ----------------------------------------------------------------------------
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

using Microsoft.Xna.Framework.Content.Pipeline;
using MonoGame.Aseprite.Content.Pipeline.Processors;

namespace MonoGame.Aseprite.Content.Pipeline.Importers;

/// <summary>
/// Defines a content pipeline importer for importing the contents of an aseprite file.
/// </summary>
[ContentImporter(".ase", ".aseprite", DisplayName = "Aseprite File Importer - MonoGame.Aseprite", DefaultProcessor = nameof(SpriteSheetContentProcessor))]
public class AsepriteFileImporter : ContentImporter<AsepriteFile>
{
    /// <summary>
    /// Imports the aseprite file at the specified path.
    /// </summary>
    /// <param name="path">The path and file name of the aseprite file to import.</param>
    /// <param name="context">
    /// The content importer context that provides contextual information about the importer.
    /// </param>
    /// <returns>The aseprite file that was imported. </returns>
    public override AsepriteFile Import(string path, ContentImporterContext context) =>
        AsepriteFile.Load(path);
}
