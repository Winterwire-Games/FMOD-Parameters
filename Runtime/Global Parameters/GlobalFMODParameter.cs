using FMODUnity;

namespace WinterwireGames.FMODParameters
{
	public abstract class GlobalFMODParameter<ValueType, ConverterType> : FMODParameter<ValueType, ConverterType>
		where ConverterType : IConverter<ValueType>, new()
	{
		public override float GetFMODValue()
		{
			float value;
			var result = RuntimeManager.StudioSystem.getParameterByName(this.ParameterName, out value);
			if (result != FMOD.RESULT.OK)
				throw new System.Exception($"Failed to retreive {this.ParameterName} FMOD parameter: {result}");
			return value;
		}

		public override void SetFMODValue(float value)
		{
			var result = RuntimeManager.StudioSystem.setParameterByName(this.ParameterName, value);
			if (result != FMOD.RESULT.OK)
				throw new System.Exception($"Failed to set {this.ParameterName} FMOD parameter to {value}: {result}");
		}
	}
}
