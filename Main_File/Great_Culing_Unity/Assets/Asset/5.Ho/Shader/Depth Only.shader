Shader "Heat Wave/Depth Only" {
	Properties {}
	SubShader {
		Tags { "Queue" = "Geometry" }
		ColorMask 0
		ZWrite On 
		Pass {}
	}
	FallBack Off
}
