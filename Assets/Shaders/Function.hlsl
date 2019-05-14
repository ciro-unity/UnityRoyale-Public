void LWRPLightingFunction_float (float3 ObjPos, out float3 Direction, out float3 Color, out float ShadowAttenuation)
{
#ifdef SHADERGRAPH_PREVIEW
    Direction = float3(-0.5, 0.5, -0.5);
    Color = float3(1, 1, 1);
    ShadowAttenuation = 0.4;
#else
    Light light = GetMainLight(GetShadowCoord(GetVertexPositionInputs(ObjPos)));
    Direction = light.direction;
    Color = light.color;
    ShadowAttenuation = light.shadowAttenuation;
#endif
}