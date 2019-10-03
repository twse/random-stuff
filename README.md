# Index
* **FontCreator Data Files and Registry Keys** (Markdown file): Contains the data files and registry keys used by FontCreator.
* **names.csv**: Names for adding to [Mozilla credits list](https://www.mozilla.org/credits). We know there are many Mozillians, past and present, who do not have Mozillians or Mozilla Bugzilla profiles. This includes former staff who have not updated their email address on Mozillians and Mozilla Bugzilla. This list only accepts names via the form as through the policy and mentioned in the [FAQ](https://www.mozilla.org/credits/faq).
* **SitePal Forum Drug Words** (HTM file): Shows a list of medicine product brand names that are used to spam the legacy SitePal forum, which includes but are not limited to antibiotics, pharmaceutics, vaccine, decongestants, chemotherapeutics, organic acids, progestogens et al.

## Pan-European fonts version 6.0
This font family will be used as a full-featured OpenType font by users of an OpenType-savvy word processor (e.g. Word 2019). The font can only be used as an ordinary Unicode font by users of a non-OpenType-savvy word processor (e.g. Hancom Word NEO).

Pan-European Serif comes in four styles - Roman, Italic, Bold and Bold Italic.

Pan-European Sans comes in two styles - Regular and Bold.

This font family covers the following diacritics:
1. **All** characters of the six Windows Code Pages, i.e. 1252 (Western Europe), 1250 (Central and Eastern Europe), 1257 (Baltic), 1254 (Turkish), 1253 (Greek), 1258 (Vietnamese) and also all characters of eleven macOS Code Pages (US Roman, Celtic, Central Europe, Croatian, Greek, Icelandic, Irish Gaelic, Lappish, Romanian, Southern Europe and Turkish).
2. **All** diacritics required for ISO 15919 ("Transliteration of Devanāgarī and related Indic Scripts into Latin characters": Vedic, Sanskrit, Hindi, Marathi, Bengali, Gujarati, Kannada, Telugu, Tamil, etc. etc. etc.) and many other non-ISO 15919, e.g. the additional diacritics used in the Sanskrit TITUS files, e.g. the additional diacritics needed by Buddhologists (Pali, Tibetan, Chinese, etc.), e.g. additional metrics symbols, e.g. additional diacritics used in the ALA-LC scheme (Kashmiri, Sumerian, Prakrit, Akkadian, Burmese, Divehi, etc. etc. etc.), e.g. additional diacritics for Proto-Indo-European etc. etc. etc.
3. **All** diacritics required for ISO 9 ("Transliteration of Cyrillic characters into Latin characters - Slavic and non-Slavic languages": Russian, Ukrainian, Belorussian, Bulgarian, Macedonian, Tajik, Mongolian, Kazakh, Tatar, etc. etc. etc.)
4. **All** diacritics of all five Adobe Latin character sets.

## Other fonts
Created with FontCreator 5.6 (2007) - FontCreator 7.0 or higher can create OpenType fonts.
* **Cyrano Text**: Based on [Cyrano Nouveau](http://www.typophile.com/node/64838) (2009) from the Typophile forums by MrMoto, Canada with revised glyphs and support for more glyphs. Both fonts are named after the 1998 movie Cyrano de Bergerac.
* **Flareserif International** is based on Albertus. This font comes in one style only - Regular.
* **Generic Menu**: Based on the font used in WarioWare GBA and NDS games. Thanks goes to Jackster from [The Spriters Resource](https://www.spriters-resource.com) for ripping the font.
* **Geneva Mega** is for use with Native American languages with Latin script (Navajo, Hän, Tutchone, Kaska, Tagish, Dogrib, Gwich'in, Cayuga, Haisla, etc. etc. etc.). This font comes in one style only - Regular. **TODO:** Rename this font to avoid clashes with names on which Apple holds a trademark.
* **LTROL Font**: Based on the font used in the American version of Lufia: The Ruins of Lore. Created using CrystalTile2. This font is not licensed or endorsed by ATLUS U.S.A., Inc., SQUARE ENIX, Inc. or SQUARE ENIX Ltd.
* **Readable Fonts**: Based on “System VIO” from OS/2 and the 16 pixel font used in the IBM ThinkPad Power Series 820 command line (with different glyph designs).
* **ZOE TFOM**: Based on the font used in western versions of Zone of the Enders: The Fist of Mars, excluding CJK Unified Ideographs. Created using CrystalTile2 and FontCreator 5.6. This font is not licensed or endorsed by Konami Digital Entertainment, Inc. or Konami Digital Entertainment B.V.

## Manually bulk-adding names to Mozilla credits list using command line
You won't receive any emails when your name is added - this will only see the message in the log.
1. Clone the `mozilla/community-data` repository via `git clone`.
2. Copy names of contributors from Mozilla-related websites such as translation projects or local communities and remove the summaries of each member's contributions.
3. Save the file as .csv (comma separated value).
4. Add the contents to names.csv: `echo file.csv >> ../names.csv` and replace the filename with whatever you want, e.g. czilla.csv has the names of all contributors for CZilla - old name of Mozilla's community for Czech.
5. Commit the new file with the added names: `git commit -a -m 'message'` and replace it with whatever message you want.
6. Push your changes with `git push` using `gurumukhi` as the username and enter the user's password.
7. Visit the credits page via `about:credits` (Mozilla browser) or click the link at the beginning and the entries will appear or removed with the last updated date being changed.

## Manually bulk-adding names to Mozilla credits list using GitHub's web user interface
Direct modifications can only be done when you're committing and logged in as the last entry in the below owner list. Alternatively, the user can be added to the repository's collaborator list. You won't receive any emails when your name is added - this will only see the message in the log.
1. Go to the `credits` directory of `community-data` repository, click the `names.csv` file and the pencil at the top-right corner to edit it.
2. Copy names of contributors from Mozilla-related websites such as translation projects.
3. Enter any commit message you want.
4. Use the default option which will commit directly to the `master` branch.
5. Visit the credits page via `about:credits` (Mozilla browser) or click the link at the beginning and the entries will appear with the last updated date being changed.

## Manually adding a name to Mozilla credits list using command line
You won't receive any emails when your name is added - this will only see your name, email and citation in the log.
1. Clone the `mozilla/community-data` repository via `git clone`.
2. Edit `names.csv` to add your name at the end or use `echo name,sortkey >> names.csv` replaced with your name and sort key.
3. Commit the new file using `git commit -a -m 'name <email>: \"citation\"'` replaced with your name, email and citation.
4. Push your changes with `git push` using `gurumukhi` as the username and enter the user's password.
5. Visit the credits page via `about:credits` (Mozilla browser) or click the link at the beginning and the entry will appear with the last updated date being changed.

## Manually adding a name to Mozilla credits list using GitHub's web user interface
Direct modifications can only be done when you're committing and logged in as last entry in the below owner list. Alternatively, the user can be added to the repository's collaborator list. You won't receive any emails when your name is added - this will only see your name, email and citation in the log.
1. Go to the `credits` directory in the `mozilla/community-data` repository, click the `names.csv` file and the pencil at the top-right corner to edit it.
2. Add your name at the end.
3. Use the name &lt;email&gt;: "citation" format for the commit message replaced with your name, email and citation.
4. Use the default option which will commit directly to the `master` branch.
5. Visit the credits page via `about:credits` (Mozilla browser) or click the link at the beginning and the entry will appear with the last updated date being changed.

## Mozilla credits list owners
The `names.csv` file is located in the credits directory in the `mozilla/community-data` repository.

| Name               | Nickname  | Nationality | Years active | Collaborator? |
|--------------------|-----------|-------------|--------------|---------------|
| Dawn Endico        | endico    | American    | 1999-2003    | NO            |
| Gervase Markham    | gerv      | British     | 2004-2017    | YES           |
| Ram Dayal Vaishnav | gurumukhi | Indian      | 2017-present | YES           |

**Historical note:** The first entry created this page (in rough alphabetical order by last name) via CVS in 1999/08/29 and posted it to the Mozilla internationalization and SeaMonkey newsgroups.

**P.S.** The second entry wrote management tools in 2011/03 when he added previous localizers without a citation via SVN. The last entry forked the above repository, is using pull requests and will close pull requests for modifications not done via the form (e.g. bulk additions) or replying the application message with a comment using the above mentioned paragraph in the second entry of this index.

## Protest pages (available in four versions)
Thanks goes to [Norman L. De Forest](http://www.chebucto.ns.ca/~af380), Canada (1942-2006) for his protest pages.

* **Web page not available** (Old Android browser) – The link refers to a page at the **@Macarlo, Inc** website (currently down).
* **Cannot find server** (Internet Explorer 6 – Windows XP RTM, SP1 and SP2) – Windows XP SP3 added network diagnostics stuff which is not included in this page. Internet Explorer 6.0 SP1 and 6.05 are the only versions to not use ActiveX content and script blocking.
* **Internet Explorer cannot display the webpage** (Internet Explorer 7 & above – Windows XP and Vista) – In this page is a button labeled **Diagnose Connection Problems** (pressing it in the browser itself will open the network diagnostic tool). Includes scripts which only works in the browser itself.
* **This page can't be displayed** (Internet Explorer 11) – In this page is a button labeled **Fix connection problems** (pressing it in the browser itself will open the network diagnostic tool). The original page uses curly quotes. This browser removed the option to change the connectivity in the file menu. To make the page look like computers not connected to the internet, remove the style in `notConnectedTasks`, add the style to `cantDisplayTasks` and change the heading/title to **You're not connected to the internet**. Includes scripts which only works in the browser itself.
* **DNS error** (Wii Internet Channel) – The links refers to pages in the Opera help website.

## Translations of EasyPaint into multiple languages
All translations are in ts format (these can be edited with Qt Linguist or other program). Generated translations can be found in [CMakeLists.txt](https://github.com/Gr1N/EasyPaint/CMakeLists.txt) (line 109).

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
* Romanian (ro_RO) – Contributed by Nicolae Oprea
* Spanish, as spoken in Spain (es_ES)
* Swedish, as spoken in Sweden (sv_SE)
* Turkish (tr_TR)
