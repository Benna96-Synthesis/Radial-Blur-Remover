using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Synthesis.Settings;

namespace Radial_Blur_Remover
{
	public record Settings
	{
		[SynthesisOrder]
		[SynthesisTooltip("List of image space adapters to not remove radial blur from, such as drunk effects.")]
		public HashSet<IFormLinkGetter<IImageSpaceAdapterGetter>> blacklist = new();
	}
}
