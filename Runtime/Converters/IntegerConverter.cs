using System;

namespace WinterwireGames.FMODParameters
{
	[Serializable]
	public sealed class IntegerConverter : IConverter<int>
	{
		public float ToFMOD(int value) => value;
		public int ToValue(float value) => (int)value;
	}
}
