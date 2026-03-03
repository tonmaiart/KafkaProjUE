// Fill out your copyright notice in the Description page of Project Settings.


#include "UkoreToolkitSettings.h"

UUkoreToolkitSettings::UUkoreToolkitSettings()
{
    // Default values for TArray
    ShotRootPaths.Add(TEXT("G:/My Drive/Projects/KafkaProj/publish/Shot"));

    // Default values for TMap
    namingTypes.Add(TEXT("*_anim.abc"), TEXT("AlembicAnim"));
    namingTypes.Add(TEXT("*_camera.fbx"), TEXT("Camera"));
}