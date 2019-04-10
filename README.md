# Information
This repository contains my random stuff.
* **Cyrano Text**: TrueType Unicode font based on [Cyrano Nouveau](http://www.typophile.com/node/64838) (2009) from the Typophile forums by MrMoto with revised glyphs and support for more glyphs. Created using FontCreator 5.6. Both fonts are named after the 1998 movie Cyrano de Bergerac.
* **Generic Menu**: TrueType Unicode font based on the font used in WarioWare GBA and NDS games. Thanks to Jackster from [The Spriters Resource](https://www.spriters-resource.com) for ripping the font.
* **LTROL Font**: TrueType Unicode font used in the American version of Lufia: The Ruins of Lore. Created using CrystalTile2 and FontCreator 5.6. This font is not licensed or endorsed by ATLUS U.S.A., Inc., SQUARE ENIX, Inc. or SQUARE ENIX Ltd.
* **names.csv**: Names for adding to [Mozilla credits list](https://www.mozilla.org/credits). We know there are many Mozillians, past and present, who do not have Mozillians or Mozilla Bugzilla profiles. This includes former staff who have not updated their email address on Mozillians and Mozilla Bugzilla. This list only accepts everyone added using the form at the bottom of this page.
* **PSF Contributor Signatories.htm**: People who received the Python Software Foundation Contributor Agreement (partial list only).
* **Readable Fonts**: Self-loading fonts based on “System VIO” from OS/2. They cover many languages written in Latin, Greek, Cyrillic, Armenian, Georgian, Hebrew or Cherokee scripts. Created using utilities by [Iván Llanas](http://www.geocities.ws/ivan_llanas/software/index.html) and Michael J. Mefford (see Contributors.md for authors of programs, copyright notices and licenses).
* **SitePal Forum Drug Words.htm**: Toothpastes, drugs and medicine used to spam the old SitePal forum.
* **Ubunteros.htm**: Launchpad users who signed the Ubuntu Code of Conduct (partial list only).
* **Ubuntu Member Home Pages.htm**: Websites for Ubuntu members who have explicitly signed the Ubuntu Code of Conduct (partial list only).
* **ZOE TFOM**: TrueType Unicode font used in western versions of Zone of the Enders: The Fist of Mars, excluding CJK Unified Ideographs. Created using CrystalTile2 and FontCreator 5.6. This font is not licensed or endorsed by Konami Digital Entertainment, Inc. or Konami Digital Entertainment B.V.

## Bulk adding names to Mozilla credits list via command line
1. Clone the **mozilla/community-data** repository via `git clone`.
2. Copy names of contributors from Mozilla-related websites such as translation projects.
3. Save the file as .csv (csv stands for comma separated value).
4. Add the contents to names.csv file: `echo file.csv >> ../names.csv` (replace **file.csv** with whatever name you want, e.g. czilla.csv contains the names of all contributors for the old Mozilla Czech speaking community)
5. Commit the new file with the added names: `git commit ../names.csv -m 'message'` (replace **message** with whatever message you want).
6. Push the master branch via git push. (Make sure that your GitHub account has write access for the **mozilla/community-data** repository.)

## Bulk adding names to Mozilla credits list via web user interface (logged in as @gurumukhi)
1. Go over to the credits directory, click the names.csv file then click the pencil at the top-right corner to edit names.csv.
2. Copy names of contributors from Mozilla-related websites such as translation projects.
3. Enter whatever commit message you want but do not use the default commit message: Update **filename**.
4. Commit directly to the master branch but do not create a pull request.

## Adding one name to Mozilla credits list via command line
1. Clone the **mozilla/community-data** repository via `git clone`.
2. Edit the names.csv file to add your name at the end.
3. Commit the new file using `git commit ../names.csv -m 'name <email>: "citation"'` (replace these strings with your name, email and citation).
4. Push the master branch via `git push`. (Make sure that your GitHub account has write access for the **mozilla/community-data** repository.)

## Adding one name to Mozilla credits list via web user interface (logged in as @gurumukhi)
1. Go over to the credits directory, click the names.csv file then click the pencil at the top-right corner to edit names.csv.
2. Add your name at the end.
3. Use the name &lt;email&gt;: "citation" format for the commit message.
4. Commit directly to the master branch but do not create a pull request.

## Pan-European fonts version 6.0
This font family will be used as a full-featured OpenType font by users of an OpenType-savvy word processor (e.g. Word 2016). The font can only be used as an ordinary Unicode font by users of a non-OpenType-savvy word processor (e.g. Haansoft Hangul NEO).

Pan-European Serif comes in four styles - Roman, Italic, Bold and Bold Italic.

Pan-European Sans comes in two styles - Regular and Bold.

This font family covers the following diacritics:
1. All characters of the six Windows Code Pages, i.e. 1252 (Western Europe), 1250 (Central and Eastern Europe), 1257 (Baltic), 1254 (Turkish), 1253 (Greek), 1258 (Vietnamese) and also all characters of eleven macOS Code Pages (US Roman, Celtic, Central Europe, Croatian, Greek, Icelandic, Irish Gaelic, Lappish, Romanian, Southern Europe and Turkish).
2. All diacritics required for ISO 15919 ("Transliteration of Devanāgarī and related Indic Scripts into Latin characters": Vedic, Sanskrit, Hindi, Marathi, Bengali, Gujarati, Kannada, Telugu, Tamil, etc. etc. etc.) and many other non-ISO 15919, e.g. the additional diacritics used in the Sanskrit TITUS files, e.g. the additional diacritics needed by Buddhologists (Pali, Tibetan, Chinese, etc.), e.g. additional metrics symbols, e.g. additional diacritics used in the ALA-LC scheme (Kashmiri, Sumerian, Prakrit, Akkadian, Burmese, Divehi, etc. etc. etc.), e.g. additional diacritics for Iranian languages (Avestan, Bráhuí, Ishkashimi, Oroshor, Shughni, Wakhi, etc. etc. etc.), etc. etc. etc.
3. All diacritics required for ISO 9 ("Transliteration of Cyrillic languages into Latin characters": Russian, Ukrainian, Belorussian, Bulgarian, Macedonian, Serbian, Bosnian, Mongolian, Tajik, Yakut, Bashkir, Chechen, Kazakh, Abkhazian, Komi, Tatar, etc. etc. etc.)
4. All special letters and diacritics required for Pan-African languages with Latin script (Yoruba, Hausa, Edo-Bini, Fulfulde, Lingala, Krio, Chichewa, Baule, Igbo, Twi, etc. etc. etc. - see Conrad Taylor's Typesetting African languages)
5. All special letters and diacritics required for Native American languages with Latin script (Navajo, Hän, Haisla, Dogrib, Tutchone, Lakota, Dakota, Cayuga, etc. etc. etc.)

## Other fonts
Created with FontCreator 5.6 (2007) - This version can only create ordinary Unicode fonts for non-OpenType-savvy word processors. Use FontCreator 7.0 or higher to create OpenType fonts. Some fonts should be renamed to avoid clashes with names on which Apple and The Font Bureau holds a trademark.
* **Chicago Mega** is for indigenous languages in Central and South America. The font is best viewed at 9 or 18 points. This font comes in one style only - Regular.
* **Flareserif International** is based on Albertus. This font comes in one style only - Regular.
* **Geneva Mega** is for Native American languages with Latin script (Navajo, Hän, Tutchone, etc.). This font comes in one style only - Regular.
* **New York Plus** is for Native American languages with Latin script (Navajo, Hän, Tutchone, etc.). This font comes in one style only - Roman.

## FontCreator Data Files and Registry Keys (Markdown file)
This file includes data files and registry keys for all FontCreator versions.

## Protest pages
These pages are available in four versions. Thanks to [Norman De Forest](http://www.chebucto.ns.ca/~af380/Profile.html) for inspiring me to create the pages (see his index page for the descriptions). His own protest page is the index page and are available in seven versions.

* **Web page not available** (Old Android browser) - The original page has the Android logo at the top. The link refers to a page at the **@Macarlo Networks, Incorporated** site (using http protocol, i.e. for use with nonsecure websites) however the company closed its business and the domain expired on July 2013.
* **Cannot find server** (Internet Explorer 6 - Windows XP RTM, SP1 and SP2) - This page uses javascript links. Default encoding tag and HTML color setting removed.
* **Internet Explorer cannot display the webpage** (Internet Explorer 8 and 9 - Windows XP and Vista) - In this page is a button labeled **Diagnose Connection Problems**, when pressed it will do nothing (the original page opens up the network diagnostic program for each Windows version). Default encoding tag removed. The user has to run these versions at the beginning of this entry for this to work.
* **DNS error** (Wii Internet Channel) - The links for the list entries use https (i.e. secure) for the Opera website.
* **Mozilla credits page** (translated to French) - Instead of the contributor list from the original page it shows a translated message.

## Translations of EasyPaint into multiple languages
* Danish (da_DK)
* Dutch (nl_NL)
* Finnish (fi_FI)
* German (de_DE)
* Hungarian (hu_HU)
* Italian (it_IT)
* Korean (ko_KR)
* Polish (pl_PL)
* Portuguese, as spoken in Brazil (pt_BR)
* Romanian (ro_RO) - Contributed by Nicolae Oprea
* Spanish, as spoken in Spain (es_ES)
* Swedish, as spoken in Sweden (sv_SE)
* Turkish (tr_TR)
