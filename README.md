# Information
This repository contains my random stuff.
* **names.csv**: Names for adding to [Mozilla credits list](https://www.mozilla.org/credits). We know there are many Mozillians, past and present, who do not have Mozillians or Mozilla Bugzilla profiles. This includes former staff who have not updated their email address on Mozillians and Mozilla Bugzilla. This list only accepts everyone added with the form as through the policy and mentioned in the [FAQ](https://www.mozilla.org/credits/faq).
* **PSF Contributor Signatories.htm**: People who received the Python Software Foundation Contributor Agreement (partial list only).
* **Readable Fonts**: Self-loading fonts based on “System VIO” from OS/2. Can be used for languages not supported by OS/2 Unified Glyph List, including Armenian and Cherokee. Created with [FontEdit II by Iván Llanas](http://www.geocities.ws/ivan_llanas/software/fontedit2.html) and FONTEDIT by Michael J. Mefford for PC Magazine (see Contributors.md for authors of programs, copyright notices and licenses). The TrueType version is not from VileR's [Ultimate Oldschool PC Font Pack](https://int10h.org/oldschool-pc-fonts/) which is licensed under a Creative Commons style license.
* **SitePal Forum Drug Words.htm**: Words of toothpastes, drugs and medicine products used to spam the old SitePal forum.
* **Ubunteros.htm**: Launchpad users who signed the Ubuntu Code of Conduct (partial list only).

## Bulk adding names to Mozilla credits list using command line
You won't receive any emails when your name is added - this will only see the message in the logs.
1. Clone the **mozilla/community-data** repository via `git clone`.
2. Copy names of contributors from Mozilla-related websites such as translation projects or local communities.
3. Save the file as .csv (csv stands for comma separated value).
4. Add the contents to names.csv: `echo file.csv >> ../names.csv` and replace the filename with whatever you want, e.g. czilla.csv has the names of all contributors for CZilla - old name of Mozilla's community for Czech.
5. Commit the new file with the added names: `git commit -a -m 'message'` and replace it with whatever message you want.
6. Push your changes with `git push` using `gurumukhi` as the username and enter the user's password.
7. Visit the credits page via `about:credits` (Mozilla browser) or click the link at the beginning and the entries will appear or removed with the last updated date being changed.

## Bulk adding names to Mozilla credits list using GitHub's web user interface
Direct modifications can only be done when you're committing and logged in as @gurumukhi. You won't receive any emails when your name is added - this will only see the message in the logs.
1. Go over to the credits directory, click the names.csv file then click the pencil at the top-right corner to edit names.csv.
2. Copy names of contributors from Mozilla-related websites such as translation projects.
3. Enter whatever commit message you want but not the default commit message: Update **filename**.
4. Commit directly to the master branch but do not create a pull request.
5. Visit the credits page via `about:credits` (Mozilla browser) or click the link at the beginning and the entries will appear straight away with the last updated date being changed.

## Adding one name to Mozilla credits list using command line
You won't receive any emails when your name is added - this will only see your name, email and citation in the log.
1. Clone the `mozilla/community-data` repository.
2. Edit the names.csv file to add your name at the end or use `echo name,sortkey >> names.csv`.
3. Commit the new file using `git commit -a -m 'name <email>: "citation"'` replaced with your name, email and citation.
4. Push your changes with `git push` using `gurumukhi` as the username and enter the user's password.
5. Visit the credits page via `about:credits` (Mozilla browser) or click the link at the beginning and the entry will appear straight away with the last updated date being changed.

## Adding one name to Mozilla credits list using GitHub's web user interface
Direct modifications can only be done when you're committing and logged in as @gurumukhi. You won't receive any emails when your name is added - this will only see your name, email and citation in the log.
1. Go to the `credits` directory of `community-data` repository, click the names.csv file and the pencil at the top-right corner to edit it.
2. Add your name at the end or use `echo name >> names.csv`.
3. Use the name &lt;email&gt;: "citation" format for the commit message.
4. Commit directly to the master branch but do not create a pull request.
5. Visit the credits page via `about:credits` (Mozilla browser) or click the link at the beginning and the entry will appear straight away with the last updated date being changed.

## Pan-European fonts version 6.0
This font family will be used as a full-featured OpenType font by users of an OpenType-savvy word processor (e.g. Word 2019). The font can only be used as an ordinary Unicode font by users of a non-OpenType-savvy word processor (e.g. Hancom Word NEO).

Pan-European Serif comes in four styles - Roman, Italic, Bold and Bold Italic.

Pan-European Sans comes in two styles - Regular and Bold.

This font family covers the following diacritics:
1. **All** characters of the six Windows Code Pages, i.e. 1252 (Western Europe), 1250 (Central and Eastern Europe), 1257 (Baltic), 1254 (Turkish), 1253 (Greek), 1258 (Vietnamese) and also all characters of eleven macOS Code Pages (US Roman, Celtic, Central Europe, Croatian, Greek, Icelandic, Irish Gaelic, Lappish, Romanian, Southern Europe and Turkish).
2. **All** diacritics required for ISO 15919 ("Transliteration of Devanāgarī and related Indic Scripts into Latin characters": Vedic, Sanskrit, Hindi, Marathi, Bengali, Gujarati, Kannada, Telugu, Tamil, etc. etc. etc.) and many other non-ISO 15919, e.g. the additional diacritics used in the Sanskrit TITUS files, e.g. the additional diacritics needed by Buddhologists (Pali, Tibetan, Chinese, etc.), e.g. additional metrics symbols, e.g. additional diacritics used in the ALA-LC scheme (Kashmiri, Sumerian, Prakrit, Akkadian, Burmese, Divehi, etc. etc. etc.), e.g. additional diacritics for Iranian languages (Avestan, Bráhuí, Ishkashimi, Oroshor, Shughni, Wakhi, etc. etc. etc.), etc. etc. etc.
3. **All** diacritics required for ISO 9 ("Transliteration of Cyrillic characters into Latin characters - Slavic and non-Slavic languages": Russian, Ukrainian, Belorussian, Bulgarian, Macedonian, Serbian, Bosnian, Mongolian, Tajik, Yakut, Bashkir, Chechen, Kazakh, Abkhazian, Komi, Tatar, etc. etc. etc.)
4. **All** diacritics of all five Adobe Latin character sets.

## Other vector fonts (ordinary Unicode)
Created with FontCreator 5.6 (2007) - FontCreator 7.0 or higher can create OpenType fonts.
* **Flareserif International** is based on Albertus. This font comes in one style only - Regular.
* **Geneva Mega** is for Native American languages with Latin script (Navajo, Hän, Tutchone, Kaska, etc.). This font comes in one style only - Regular. This font should be renamed to avoid clashes with names on which Apple Computer and The Font Bureau holds a trademark.

## Pixel fonts (ordinary Unicode)
* **Cyrano Text**: TrueType Unicode font based on [Cyrano Nouveau](http://www.typophile.com/node/64838) (2009) from the Typophile forums by MrMoto with revised glyphs and support for more glyphs. Created using FontCreator 5.6. Both fonts are named after the 1998 movie Cyrano de Bergerac.
* **Generic Menu**: Based on the font used in WarioWare GBA and NDS games. Thanks to Jackster from [The Spriters Resource](https://www.spriters-resource.com) for ripping the font.
* **LTROL Font**: Based on the font used in the American version of Lufia: The Ruins of Lore. Created using CrystalTile2 and FontCreator 5.6. This font is not licensed or endorsed by ATLUS U.S.A., Inc., SQUARE ENIX, Inc. or SQUARE ENIX Ltd.
* **ZOE TFOM**: Based on the font used in western versions of Zone of the Enders: The Fist of Mars, excluding CJK Unified Ideographs. Created using CrystalTile2 and FontCreator 5.6. This font is not licensed or endorsed by Konami Digital Entertainment, Inc. or Konami Digital Entertainment B.V.

## FontCreator Data Files and Registry Keys
This file includes data files and registry keys for all FontCreator versions.

## Protest pages
These pages are available in four versions. Thanks to Norman De Forest, Canada for inspiring me to create the pages.

* **Web page not available** (Old Android browser) - The original page has the Android logo at the top. The link refers to a page at the **@Macarlo Networks, Incorporated** site however the domain expired on July 2013.
* **Cannot find server** (Internet Explorer 6 - Windows XP RTM, SP1 and SP2) - This page uses javascript links. Default encoding tag and HTML color setting removed.
* **Internet Explorer cannot display the webpage** (Internet Explorer 7 & above - Windows XP and Vista) - In this page is a button labeled **Diagnose Connection Problems**, when pressed it will do nothing (the original page opens up the network diagnostic tool). Default encoding tag removed. Requires Internet Explorer 7 & above for proper display.
* **This page can't be displayed** (Internet Explorer 11) - In this page is a button labeled **Fix connection problems**, when pressed it will do nothing (the original page opens up the network diagnostic tool). Default encoding tag removed. Removing the style parameter in the not connected tasks will display it and changing the title also does it.
* **DNS error** (Wii Internet Channel)
* **Mozilla credits page in French** - Instead of the contributor list from the original page (see the link at the beginning) it shows a translated message.

## Translations of EasyPaint into multiple languages
All translations are in ts format meaning that it can be edited with Qt Linguist. The list of generated translations can be found in [CMakeLists.txt](https://github.com/Gr1N/EasyPaint/CMakeLists.txt) in line 109.

* Danish (da_DK)
* Dutch (nl_NL)
* Finnish (fi_FI)
* German (de_DE)
* Hungarian (hu_HU)
* Italian (it_IT)
* Korean (ko_KR)
* Norwegian Bokmål (nb_NO)
* Norwegian Nynorsk (nn_NO)
* Polish (pl_PL)
* Portuguese, as spoken in Brazil (pt_BR)
* Romanian (ro_RO) - Contributed by Nicolae Oprea
* Spanish, as spoken in Spain (es_ES)
* Swedish, as spoken in Sweden (sv_SE)
* Turkish (tr_TR)
