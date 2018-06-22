# Information
This repository contains my random stuff.
* **Cyrano Text**: TrueType Unicode font based on Cyrano Nouveau (2009) from the Typophile forums by MrMoto with some glyphs modified. Created using FontCreator 5.6 (2007). **Moderator's note:** Both fonts are named after Cyrano de Bergerac.
* **Generic Menu**: TrueType Unicode font based on the font used in WarioWare GBA and NDS games. Thanks goes to the user Jackster from Spriters Resource for ripping the font.
* **Icons.zip**: Icons based on the [bob's game font](http://www.bobcorporation.com/fonts/bobsgame.ttf) lowercase alphabet for use with OS/2 programs of the past and present. Requires OS/2 2.0 or higher under a file system that supports long filenames, e.g. HPFS or FAT32. Created with OS/2 Icon Editor. See Third-Party Notices.md for commercial and unsupported freeware credits. See [Extras page on the bobsgame Wikia portal](http://bobsgame.wikia.com/wiki/Extras) for non-commercial software credits.
* **LTROL Font**: TrueType Unicode font based on the font in the American version of Lufia: The Ruins of Lore (2003), excluding random glyphs which replaces portions of the Hiragana subset. Created using CrystalTile2 (2010) and FontCreator 5.6 (2007). This font is not licensed or endorsed by ATLUS U.S.A., Inc. or SQUARE ENIX, Inc.
* **names.csv**: Names for adding in the [Mozilla credits list](https://www.mozilla.org/credits). In the early days, Dawn Endico was responsible for updating the list through CVS. **Moderator's note:** We know there are many Mozillians, past and present, who do not have Mozillians or Mozilla Bugzilla profiles. This includes former staff who have not updated their email address on Mozillians and Mozilla Bugzilla. The message used in the names.csv file when someone or your name is added to this list is **name &lt;email&gt;: "comment (citation)"**.
* **PSF Contributor Signatories.htm**: People who received the Python Software Foundation Contributor Agreement (partial list only).
* **Readable Fonts**: Self-loading font family based on the “System VIO” font from OS/2. Some characters modified. They cover many languages written in Latin, Greek, Cyrillic, Armenian, Hebrew or Cherokee scripts. Created using utilities by Iván Llanas and Michael J. Mefford (PC Magazine). See Contributors.md for a list of people contributing to old packages.
* **SitePal Forum Drug Words.htm**: Toothpastes, drugs and medicine – these words were used to spam the old SitePal forums which no longer exists since March 2011.
* **Ubunteros.htm**: Launchpad users who signed the Ubuntu Code of Conduct (partial list only).
* **Ubuntu Member Home Pages.htm**: Websites for Ubuntu members who have explicitly signed the Ubuntu Code of Conduct (partial list only). The beginning paragraph is based on the old Netscape people page.
* **ZOE TFOM**: TrueType Unicode font based on the font in the American and European versions of Zone of the Enders: The Fist of Mars (2002), excluding CJK Unified Ideographs. Created using CrystalTile2 (2010) and FontCreator 5.6 (2007). A Japanese subset for this font was planned but was cancelled. This font is not licensed or endorsed by Konami Digital Entertainment, Inc.

## Steps useful to bulk import names to Mozilla's credits list
Follow these steps only if you don't need to fill in the Google Docs form or if Google Docs does not work.

1. Clone the mozilla/community-data repository with any Git client
2. Copy names of contributors from Mozilla-related websites such as translation projects
3. Save the file with csv as the extension in Unicode encoding
4. Add the contents to names.csv file: `echo file.csv >> ../names.csv` (replace **file.csv** with the filename, e.g. czilla.csv is a list of contributors for the old Mozilla Czech community)
5. Commit the new file with the added names: `git commit ../names.csv -m 'message'` (replace **message** with the commit message)

## Vector font: Pan-European fonts version 6.0
This font family will be used as a full-featured OpenType font by users of an OpenType-savvy word processor (e.g. Word 2016). The font can only be used as an ordinary Unicode font by users of a non-OpenType-savvy word processor (e.g. Haansoft Hangul NEO).

Pan-European Serif comes in four styles - Roman, Italic, Bold and Bold Italic.

Pan-European Sans comes in two styles - Regular and Bold.

This font family covers the following diacritics:
1. All characters of the six Windows Code Pages, i.e. 1252 (Western Europe), 1250 (Central and Eastern Europe), 1257 (Baltic), 1254 (Turkish), 1253 (Greek), 1258 (Vietnamese) and also all characters of eleven macOS Code Pages (US Roman, Celtic, Central Europe, Croatian, Greek, Icelandic, Irish Gaelic, Lappish, Romanian, Southern Europe and Turkish).
2. All diacritics required for ISO 15919 ("Transliteration of Devanāgarī and related Indic Scripts into Latin characters": Vedic, Sanskrit, Hindi, Marathi, Bengali, Gujarati, Kannada, Telugu, Tamil, etc. etc. etc. - see [Dr. Anthony Stone's ISO 15919 website](http://homepage.ntlworld.com/stone-catend/translit.htm)) and many other non-ISO 15919, e.g. the additional diacritics used in the Sanskrit TITUS files, e.g. the additional diacritics needed by Buddhologists (Pali, Tibetan, Chinese, etc.), e.g. additional metrics symbols, e.g. additional diacritics used in the ALA-LC scheme (Kashmiri, Sumerian, Prakrit, Akkadian, Burmese, Divehi, etc. etc. etc.), e.g. additional diacritics for Iranian languages (Avestan, Bráhuí, Ishkashimi, Oroshor, Shughni, Wakhi, etc. etc. etc.), etc. etc. etc.
3. All diacritics required for ISO 9 ("Transliteration of Cyrillic languages into Latin characters": Russian, Ukrainian, Belorussian, Bulgarian, Macedonian, Serbian, Bosnian, Mongolian, Tajik, Yakut, Bashkir, Chechen, Kazakh, Abkhazian, Komi, Tatar, etc. etc. etc.)

## Other vector fonts
Originally created with FontCreator 5.6 (2007) - This version can only create ordinary Unicode fonts for non-OpenType-savvy word processors. All fonts should be renamed to avoid clashes with names on which Apple and The Font Bureau holds a trademark.
* **Chicago Mega** - Indigenous languages in Central and South America. The font is best viewed at 9 or 18 points. This font comes in one style only - Regular.
* **Geneva Mega** - Native American languages using the Latin orthography. This font comes in one style only - Regular.
* **New York Plus** - Native American languages using the Latin orthography. This font comes in one style only - Roman.

## FontCreator Data Files and Registry Keys (HTM file)
This file includes data files and registry keys for all versions of FontCreator.

## Protest pages
These pages are available in four versions in htm format. Thanks to Norman De Forest for inspiring me to create the pages. His own protest page uses the index page.

* **Web page not available** (Android browser) - This page is missing the Android logo at the top. The link refers to a page at Macarlo's site which the company closed its business and expired the domain on July 2013.
* **Cannot find server** (Internet Explorer 6.0 - **Note:** for Windows 98 & above only) - This page uses resources from shdoclc.dll.

## Open source program translations
**Moderator's note:** Most translations were done with Bing Translator.
* **EasyPaint** – Danish, Dutch, Finnish, German, Hungarian, Italian, Korean, Polish, Portuguese (Brazil), Romanian, Spanish, Swedish and Turkish (UTF-8). Only Chinese (Simplified), Czech, French and Russian translations are included.
* **SPFig** – Dutch (CP850). Only English and French translations are included.
* **Tinke** – Czech, Dutch, Korean, Portuguese (Brazil) and Russian (UTF-8). Only English, French, Italian and Spanish translations for user interface and English, French and Spanish translations for plugins are included.
