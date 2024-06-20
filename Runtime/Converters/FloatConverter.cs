using System;

namespace WinterwireGames.FMODParameters
{
	[Serializable]
	public sealed class FloatConverter : IConverter<float>
	{
		public float ToFMOD(float value) => value;
		public float ToValue(float value) => value;
	}
}
