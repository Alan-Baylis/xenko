﻿// Copyright (c) Xenko contributors (https://xenko.com) and Silicon Studio Corp. (https://www.siliconstudio.co.jp)
// Distributed under the MIT license. See the LICENSE.md file in the project root for more information.

using Xenko.Shaders;

namespace Xenko.Rendering.Materials
{
    /// <summary>
    /// Common interface for calculating the light attenuation for the hair shading model.
    /// </summary>
    public interface IMaterialHairLightAttenuationFunction
    {
        /// <summary>
        /// Generates the shader class source used for the shader composition.
        /// </summary>
        /// <returns>ShaderSource.</returns>
        ShaderSource Generate(MaterialGeneratorContext context);
    }
}
