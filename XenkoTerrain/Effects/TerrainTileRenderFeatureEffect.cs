﻿// <auto-generated>
// Do not edit this file yourself!
//
// This code was generated by Xenko Shader Mixin Code Generator.
// To generate it yourself, please install Xenko.VisualStudio.Package .vsix
// and re-save the associated .xkfx.
// </auto-generated>

using System;
using Xenko.Core;
using Xenko.Rendering;
using Xenko.Graphics;
using Xenko.Shaders;
using Xenko.Core.Mathematics;
using Buffer = Xenko.Graphics.Buffer;

namespace Xenko.Rendering
{
    public static partial class TerrainTileRenderFeatureEffectKeys
    {
        public static readonly ValueParameterKey<Vector3> LightColor = ParameterKeys.NewValue<Vector3>();
        public static readonly ValueParameterKey<Vector3> LightPosition = ParameterKeys.NewValue<Vector3>();
        public static readonly ValueParameterKey<float> LightIntensity = ParameterKeys.NewValue<float>();
        public static readonly ValueParameterKey<float> TextureScale = ParameterKeys.NewValue<float>();
        public static readonly ValueParameterKey<float> HeightScale = ParameterKeys.NewValue<float>();
        public static readonly ValueParameterKey<float> SpecularReflectivity = ParameterKeys.NewValue<float>();
        public static readonly ValueParameterKey<float> SpecularDamping = ParameterKeys.NewValue<float>();
        public static readonly ObjectParameterKey<Texture> BlendMap = ParameterKeys.NewObject<Texture>();
        public static readonly ObjectParameterKey<Texture> SandTexture = ParameterKeys.NewObject<Texture>();
        public static readonly ObjectParameterKey<Texture> DirtTexture = ParameterKeys.NewObject<Texture>();
        public static readonly ObjectParameterKey<Texture> GrassTexture = ParameterKeys.NewObject<Texture>();
        public static readonly ObjectParameterKey<Texture> RockTexture = ParameterKeys.NewObject<Texture>();
    }
}
