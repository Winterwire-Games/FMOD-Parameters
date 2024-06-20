using UnityEngine;

namespace WinterwireGames.FMODParameters
{
	[AddComponentMenu("FMOD Parameters/Global FMOD Parameters/Discrete Global FMOD Parameter")]
	public sealed class DiscreteGlobalFMODParameter : GlobalFMODParameter<int, IntegerConverter> {}
}
