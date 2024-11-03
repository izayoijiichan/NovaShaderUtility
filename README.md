# NOVA Shader Utility

This package is a utility script to get/set NOVA Shader property values.

___

## Shaders

|shader name|
|:---|
|Nova/Particles/Distortion|
|Nova/Particles/UberLit|
|Nova/Particles/UberUnlit|
|Nova/UIParticles/UberLit|
|Nova/UIParticles/UberUnlit|

## Package name

com.izayoi.nova.shader.utility

## Assembly name

NovaShader.Utility

## Assembly file

NovaShader.Utility.dll

## Namespace

Izayoi.NovaShader

## Unity

|unity version|
|:---|
|Unity 2022.3|
|Unity 2023.1|
|Unity 2023.2|
|Unity 6000.0|

|render pipeline|description|
|:---|:---|
|URP|Universal render pipeline|

## Install

### Package Manager

{UnityProject}/Packages/manifest.json

```json
{
  "dependencies": {
    "com.izayoi.nova.shader.utility": "https://github.com/izayoijiichan/NovaShaderUtility.git#v2.4.0",
    "jp.co.cyberagent.nova": "https://github.com/CyberAgentGameEntertainment/NovaShader.git?path=Assets/Nova#2.4.0",
    // --- other packages ---
  }
}

```

## Usage

```csharp
using Izayoi.NovaShader;
using Izayoi.NovaShader.v2.0.0;
using UnityEngine;

public void Method()
{
    var novaUtility = new NovaUtility();

    // Get all property values.
    NovaPropertyContainer property = novaUtility.GetPropertyValuesFromMaterial(material);

    if (property.PropertyEntityType == NovaPropertyEntityType.UberLit)
    {
        property.UberLitProperty.Emission.EmissionColor = Color.white;
    }
    else if (property.PropertyEntityType == NovaPropertyEntityType.UberUnlit)
    {
        property.UberUnlitProperty.Emission.EmissionColor = Color.white;
    }

    // Set all property values.
    novaUtility.SetPropertyValuesToMaterial(material, property);
}

public void BlockMethod()
{
    var novaUtility = new NovaUtility();

    // Get property block values.
    NovaUberEmission emission = novaUtility.MaterialGetter.GetNovaUberEmissionPropertyValues(material);

    emission.EmissionColor = Color.white;

    // Set property block values.
    novaUtility.MaterialSetter.SetNovaUberPropertyValues(material, emission);
}

public void OneMethod()
{
    var emissionProxy = new NovaEmissionMaterialProxy(material);

    // Get property value.
    Color emissionColor = emissionProxy.EmissionColor;

    // Set property value.
    emissionProxy.EmissionColor = Color.white;
}

```

## Link

[NOVA Shader](https://github.com/CyberAgentGameEntertainment/NovaShader)

___
Last updated: 4 Nov, 2024  
Editor: Izayoi Jiichan

*Copyright (C) 2024 Izayoi Jiichan. All Rights Reserved.*
