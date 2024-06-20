using UnityEngine;

namespace dGameBoy101b.FMODParameters
{
	[AddComponentMenu("FMOD Parameters/Global FMOD Parameters/Labeled Global FMOD Parameter")]
	public sealed class LabeledGlobalFMODParameter : GlobalFMODParameter<string, LabelConverter> {}
}
