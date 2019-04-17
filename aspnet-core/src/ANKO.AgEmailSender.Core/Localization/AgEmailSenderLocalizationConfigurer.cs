using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace ANKO.AgEmailSender.Localization
{
    public static class AgEmailSenderLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(AgEmailSenderConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(AgEmailSenderLocalizationConfigurer).GetAssembly(),
                        "ANKO.AgEmailSender.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
