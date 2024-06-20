using UnityEngine;

namespace dGameBoy101b.FMODParameters
{
	[AddComponentMenu("FMOD Parameters/Emitter FMOD Parameters/Labeled Emitter FMOD Parameter")]
	public sealed class LabeledEmitterFMODParameter : EmitterFMODParameter<string, LabelConverter> {}
}
