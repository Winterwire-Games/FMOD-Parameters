using UnityEngine;

namespace WinterwireGames.FMODParameters
{
	[AddComponentMenu("FMOD Parameters/Emitter FMOD Parameters/Labeled Emitter FMOD Parameter")]
	public sealed class LabeledEmitterFMODParameter : EmitterFMODParameter<string, LabelConverter> {}
}
