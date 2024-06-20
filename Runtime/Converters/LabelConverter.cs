using System;
using System.Collections.Generic;
using UnityEngine;

namespace WinterwireGames.FMODParameters
{
	[Serializable]
	public sealed class LabelConverter : IConverter<string>
	{
		[SerializeField]
		[Tooltip("The labels in the labeled FMOD parameter")]
		private List<string> _labels = new();
		public List<string> Labels => this._labels;

		public static IConverter<int> IndexConverter = new IntegerConverter();

		public float ToFMOD(string value)
		{
			int index = this.Labels.IndexOf(value);
			if (index < 0)
				throw new KeyNotFoundException($"Label \"{value}\" not found");
			return IndexConverter.ToFMOD(index);
		}

		public string ToValue(float value)
		{
			int index = IndexConverter.ToValue(value);
			if (index < 0 || index >= this.Labels.Count)
				throw new IndexOutOfRangeException($"Label index {index} is out of range");
			return this.Labels[index];
		}
	}
}
