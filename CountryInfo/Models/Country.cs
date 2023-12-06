namespace CountryInfo.Models
{
    /// <summary>
    /// Model for a country
    /// </summary>
    public class Country
    {
        #region Properties

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string name { get; set; }

        /// <summary>
        /// Gets or sets the top level domain.
        /// </summary>
        /// <value>
        /// The top level domain.
        /// </value>
        public string[] topLevelDomain { get; set; }

        /// <summary>
        /// Gets or sets the alpha2 code.
        /// </summary>
        /// <value>
        /// The alpha2 code.
        /// </value>
        public string alpha2Code { get; set; }

        /// <summary>
        /// Gets or sets the alpha3 code.
        /// </summary>
        /// <value>
        /// The alpha3 code.
        /// </value>
        public string alpha3Code { get; set; }

        /// <summary>
        /// Gets or sets the calling codes.
        /// </summary>
        /// <value>
        /// The calling codes.
        /// </value>
        public string[] callingCodes { get; set; }

        /// <summary>
        /// Gets or sets the capital.
        /// </summary>
        /// <value>
        /// The capital.
        /// </value>
        public string capital { get; set; }

        /// <summary>
        /// Gets or sets the alt spellings.
        /// </summary>
        /// <value>
        /// The alt spellings.
        /// </value>
        public string[] altSpellings { get; set; }

        /// <summary>
        /// Gets or sets the subregion.
        /// </summary>
        /// <value>
        /// The subregion.
        /// </value>
        public string subregion { get; set; }

        /// <summary>
        /// Gets or sets the region.
        /// </summary>
        /// <value>
        /// The region.
        /// </value>
        public string region { get; set; }

        /// <summary>
        /// Gets or sets the population.
        /// </summary>
        /// <value>
        /// The population.
        /// </value>
        public int population { get; set; }

        /// <summary>
        /// Gets or sets the latlng.
        /// </summary>
        /// <value>
        /// The latlng.
        /// </value>
        public float[] latlng { get; set; }

        /// <summary>
        /// Gets or sets the demonym.
        /// </summary>
        /// <value>
        /// The demonym.
        /// </value>
        public string demonym { get; set; }

        /// <summary>
        /// Gets or sets the area.
        /// </summary>
        /// <value>
        /// The area.
        /// </value>
        public float area { get; set; }

        /// <summary>
        /// Gets or sets the gini.
        /// </summary>
        /// <value>
        /// The gini.
        /// </value>
        public float gini { get; set; }

        /// <summary>
        /// Gets or sets the timezones.
        /// </summary>
        /// <value>
        /// The timezones.
        /// </value>
        public string[] timezones { get; set; }

        /// <summary>
        /// Gets or sets the borders.
        /// </summary>
        /// <value>
        /// The borders.
        /// </value>
        public string[] borders { get; set; }

        /// <summary>
        /// Gets or sets the name of the native.
        /// </summary>
        /// <value>
        /// The name of the native.
        /// </value>
        public string nativeName { get; set; }

        /// <summary>
        /// Gets or sets the numeric code.
        /// </summary>
        /// <value>
        /// The numeric code.
        /// </value>
        public string numericCode { get; set; }

        /// <summary>
        /// Gets or sets the flags.
        /// </summary>
        /// <value>
        /// The flags.
        /// </value>
        public Flags flags { get; set; }

        /// <summary>
        /// Gets or sets the currencies.
        /// </summary>
        /// <value>
        /// The currencies.
        /// </value>
        public Currency[] currencies { get; set; }

        /// <summary>
        /// Gets or sets the languages.
        /// </summary>
        /// <value>
        /// The languages.
        /// </value>
        public Language[] languages { get; set; }

        /// <summary>
        /// Gets or sets the translations.
        /// </summary>
        /// <value>
        /// The translations.
        /// </value>
        public Translations translations { get; set; }

        /// <summary>
        /// Gets or sets the flag.
        /// </summary>
        /// <value>
        /// The flag.
        /// </value>
        public string flag { get; set; }

        /// <summary>
        /// Gets or sets the regional blocs.
        /// </summary>
        /// <value>
        /// The regional blocs.
        /// </value>
        public Regionalbloc[] regionalBlocs { get; set; }

        /// <summary>
        /// Gets or sets the cioc.
        /// </summary>
        /// <value>
        /// The cioc.
        /// </value>
        public string cioc { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Country"/> is independent.
        /// </summary>
        /// <value>
        ///   <c>true</c> if independent; otherwise, <c>false</c>.
        /// </value>
        public bool independent { get; set; }

        #endregion Properties
    }

    /// <summary>
    /// Model for a flag
    /// </summary>
    public class Flags
    {
        #region Properties

        /// <summary>
        /// Gets or sets the SVG.
        /// </summary>
        /// <value>
        /// The SVG.
        /// </value>
        public string svg { get; set; }

        /// <summary>
        /// Gets or sets the PNG.
        /// </summary>
        /// <value>
        /// The PNG.
        /// </value>
        public string png { get; set; }

        #endregion Properties
    }

    /// <summary>
    /// Model for a translation
    /// </summary>
    public class Translations
    {
        #region Properties

        /// <summary>
        /// Gets or sets the br.
        /// </summary>
        /// <value>
        /// The br.
        /// </value>
        public string br { get; set; }

        /// <summary>
        /// Gets or sets the pt.
        /// </summary>
        /// <value>
        /// The pt.
        /// </value>
        public string pt { get; set; }

        /// <summary>
        /// Gets or sets the nl.
        /// </summary>
        /// <value>
        /// The nl.
        /// </value>
        public string nl { get; set; }

        /// <summary>
        /// Gets or sets the hr.
        /// </summary>
        /// <value>
        /// The hr.
        /// </value>
        public string hr { get; set; }

        /// <summary>
        /// Gets or sets the fa.
        /// </summary>
        /// <value>
        /// The fa.
        /// </value>
        public string fa { get; set; }

        /// <summary>
        /// Gets or sets the de.
        /// </summary>
        /// <value>
        /// The de.
        /// </value>
        public string de { get; set; }

        /// <summary>
        /// Gets or sets the es.
        /// </summary>
        /// <value>
        /// The es.
        /// </value>
        public string es { get; set; }

        /// <summary>
        /// Gets or sets the fr.
        /// </summary>
        /// <value>
        /// The fr.
        /// </value>
        public string fr { get; set; }

        /// <summary>
        /// Gets or sets the ja.
        /// </summary>
        /// <value>
        /// The ja.
        /// </value>
        public string ja { get; set; }

        /// <summary>
        /// Gets or sets it.
        /// </summary>
        /// <value>
        /// It.
        /// </value>
        public string it { get; set; }

        /// <summary>
        /// Gets or sets the hu.
        /// </summary>
        /// <value>
        /// The hu.
        /// </value>
        public string hu { get; set; }

        #endregion Properties
    }

    /// <summary>
    /// Model for a currency
    /// </summary>
    public class Currency
    {
        #region Properties

        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        /// <value>
        /// The code.
        /// </value>
        public string code { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string name { get; set; }

        /// <summary>
        /// Gets or sets the symbol.
        /// </summary>
        /// <value>
        /// The symbol.
        /// </value>
        public string symbol { get; set; }

        #endregion Properties
    }

    /// <summary>
    /// Model for a language
    /// </summary>
    public class Language
    {
        #region Properties

        /// <summary>
        /// Gets or sets the iso639 1.
        /// </summary>
        /// <value>
        /// The iso639 1.
        /// </value>
        public string iso639_1 { get; set; }

        /// <summary>
        /// Gets or sets the iso639 2.
        /// </summary>
        /// <value>
        /// The iso639 2.
        /// </value>
        public string iso639_2 { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string name { get; set; }

        /// <summary>
        /// Gets or sets the name of the native.
        /// </summary>
        /// <value>
        /// The name of the native.
        /// </value>
        public string nativeName { get; set; }

        #endregion Properties
    }

    /// <summary>
    /// Model for a regional bloc
    /// </summary>
    public class Regionalbloc
    {
        #region Properties

        /// <summary>
        /// Gets or sets the acronym.
        /// </summary>
        /// <value>
        /// The acronym.
        /// </value>
        public string acronym { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string name { get; set; }

        #endregion Properties
    }
}