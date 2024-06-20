using UnityEngine;
using FMODUnity;
using System.Collections.Generic;

namespace dGameBoy101b.FMODParameters
{
	public abstract class EmitterFMODParameter<ValueType, ConverterType> : FMODParameter<ValueType, ConverterType>
		where ConverterType : IConverter<ValueType>, new()
	{
		[SerializeField]
		[Tooltip("The event emitter whose parameters should be accessed")]
		private StudioEventEmitter _emitter;
		public virtual StudioEventEmitter FindEmitter() => this.GetComponentInParent<StudioEventEmitter>();
		public StudioEventEmitter Emitter
		{
			get
			{
				if (this._emitter == null)
					this._emitter = this.FindEmitter();
				return this._emitter;
			}
			set => this._emitter = value;
		}

		public override float GetFMODValue()
		{
			foreach (var param in this.Emitter.Params)
			{
				if (param.Name == this.ParameterName)
					return param.Value;
			}
			throw new KeyNotFoundException($"FMOD parameter {this.ParameterName} not found");
		}

		public override void SetFMODValue(float value)
		{
			this.Emitter.SetParameter(this.ParameterName, value);
		}
	}
}
