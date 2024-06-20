using UnityEngine;

namespace WinterwireGames.FMODParameters
{
	public abstract class FMODParameter<ValueType, ConverterType> : MonoBehaviour
		where ConverterType : IConverter<ValueType>, new()
	{
		[SerializeField]
		[Tooltip("The name of the parameter to access")]
		private string _parameterName;
		public string ParameterName
		{
			get => this._parameterName; 
			set => this._parameterName = value;
		}

		[SerializeField]
		[Tooltip("The settings used to convert values")]
		private ConverterType _converter = new();
		public ConverterType Converter => this._converter;

		public abstract float GetFMODValue();
		public abstract void SetFMODValue(float value);

		public ValueType Value
		{
			get => this.Converter.ToValue(this.GetFMODValue());
			set => this.SetFMODValue(this.Converter.ToFMOD(value));
		}
	}
}
