﻿// <copyright file="IImageWebProcessor.cs" company="James Jackson-South">
// Copyright (c) James Jackson-South and contributors.
// Licensed under the Apache License, Version 2.0.
// </copyright>

namespace ImageSharp.Web.Processors
{
    using System.Collections.Generic;

    using ImageSharp.PixelFormats;

    using Microsoft.AspNetCore.Http;

    /// <summary>
    /// Specifies the contract for processing images using a querystring URI API.
    /// </summary>
    public interface IImageWebProcessor
    {
        /// <summary>
        /// Gets the collection of recognized querystring commands.
        /// </summary>
        IEnumerable<string> Commands { get; }

        /// <summary>
        /// Processes the image based on the querystring commands.
        /// </summary>
        /// <typeparam name="TPixel">The pixel format.</typeparam>
        /// <param name="commands">The querystring containing the processing commands.</param>
        /// <returns>The <see cref="Image{TPixel}"/></returns>
        Image<TPixel> Process<TPixel>(QueryString commands)
            where TPixel : struct, IPixel<TPixel>;
    }
}
