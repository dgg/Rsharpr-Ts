using System.Collections.Generic;
using JetBrains.DocumentModel;
using JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots;
using JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros;

namespace Rsharpr_Ts
{
	[MacroDefinition("tstamp", LongDescription = "Generates a new time stamp in a numeric format.", ShortDescription = "New time stamp")]
	public class TsMacroDef : SimpleMacroDefinition
	{
		public override string GetPlaceholder(IDocument document, IEnumerable<IMacroParameterValue> parameters)
		{
			return "TSTAMP";
		}
	}
	[MacroImplementation(Definition = typeof(TsMacroDef))]
	public class TsMacroImpl : SimpleMacroImplementation
	{
		public override HotspotItems GetLookupItems(IHotspotContext context)
		{
			return MacroUtil.SimpleEvaluateResult("my timestamp");
		}
	}
}