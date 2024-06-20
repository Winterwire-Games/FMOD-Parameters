namespace WinterwireGames.FMODParameters
{
	public interface IConverter<ValueType>
	{
		public float ToFMOD(ValueType value);
		public ValueType ToValue(float value);
	}
}
