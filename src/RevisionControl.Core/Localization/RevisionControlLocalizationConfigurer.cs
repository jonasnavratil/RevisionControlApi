using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace RevisionControl.Localization
{
    public static class RevisionControlLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(RevisionControlConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(RevisionControlLocalizationConfigurer).GetAssembly(),
                        "RevisionControl.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
