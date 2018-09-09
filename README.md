# Information
This repository contains my random stuff.
* **Cyrano Text**: TrueType Unicode font based on Cyrano Nouveau (2009) from the Typophile forums by MrMoto with some glyphs modified. Created using FontCreator 5.6 (2007). **Moderator's note:** Both fonts are named after Cyrano de Bergerac.
* **Generic Menu**: TrueType Unicode font based on the font used in WarioWare GBA and NDS games. Thanks to Jackster from Spriters Resource for ripping the font.
* **Icons.zip**: Icons using the lowercase letters of [bob's game font](http://www.bobcorporation.com/fonts/bobsgame.ttf) for OS/2 programs (created with OS/2 Icon Editor). Requires OS/2 2.0 or higher on a file system that supports long filenames, e.g. HPFS or FAT32. See Third-Party Notices.md for commercial and unsupported freeware credits. See [Extras page on the unofficial bobsgame Wikia portal](http://bobsgame.wikia.com/wiki/Extras) for non-commercial software credits.
* **LTROL Font**: TrueType Unicode font used in the American version of Lufia: The Ruins of Lore (2003). Created using CrystalTile2 (2010) and FontCreator 5.6 (2007). This font is not licensed or endorsed by ATLUS U.S.A., Inc., SQUARE ENIX, Inc. or SQUARE ENIX Ltd.
* **names.csv**: Names for adding to [Mozilla credits list](https://www.mozilla.org/credits). We know there are many Mozillians, past and present, who do not have Mozillians or Mozilla Bugzilla profiles. This includes former staff who have not updated their email address on Mozillians and Mozilla Bugzilla. The commit message used when someone or you gets added is **name &lt;email&gt;: "comment (citation)"** excluding the IRC (ircuser) or Mozilla Wiki username (wikiuser). (The usernames can be fetched in various profiles at Mozillians.)
* **PSF Contributor Signatories.htm**: People who received the Python Software Foundation Contributor Agreement (partial list only).
* **Readable Fonts**: Self-loading fonts based on “System VIO” from OS/2. They cover many languages written in Latin, Greek, Cyrillic, Armenian, Georgian, Hebrew or Cherokee scripts. Created using utilities by [Iván Llanas](http://www.geocities.ws/ivan_llanas/software/index.html) and Michael J. Mefford (see Contributors.md for the original authors of many old programs, copyright notices and licenses).
* **SitePal Forum Drug Words.htm**: Toothpastes, drugs and medicine used to spam the old SitePal forum.
* **Ubunteros.htm**: Launchpad users who signed the Ubuntu Code of Conduct (partial list only).
* **Ubuntu Member Home Pages.htm**: Websites for Ubuntu members who have explicitly signed the Ubuntu Code of Conduct (partial list only).
* **ZOE TFOM**: TrueType Unicode font used in western versions of Zone of the Enders: The Fist of Mars (2002), excluding CJK Unified Ideographs. Created using CrystalTile2 (2010) and FontCreator 5.6 (2007). This font is not licensed or endorsed by Konami Digital Entertainment, Inc. or Konami Digital Entertainment B.V.

## Steps useful to bulk import names to Mozilla's credits list
Follow these steps if you don't need to fill in the Google Docs form or if Google Docs does not work.

1. Clone the **mozilla/community-data** repository with any Git client.
2. Copy names of contributors from Mozilla-related websites such as translation projects.
3. Save the file as .csv (csv stands for comma separated value).
4. Add the contents to names.csv file: `echo file.csv >> ../names.csv` (replace **file.csv** with whatever name you want, e.g. czilla.csv is a list of contributors for the old Mozilla Czech community)
5. Commit the new file with the added names: `git commit ../names.csv -m 'message'` (replace **message** with the commit message)

## Pan-European fonts version 6.0
This font family will be used as a full-featured OpenType font by users of an OpenType-savvy word processor (e.g. Word 2016). The font can only be used as an ordinary Unicode font by users of a non-OpenType-savvy word processor (e.g. Haansoft Hangul NEO).

Pan-European Serif comes in four styles - Roman, Italic, Bold and Bold Italic.

Pan-European Sans comes in two styles - Regular and Bold.

This font family covers the following diacritics:
1. All characters of the six Windows Code Pages, i.e. 1252 (Western Europe), 1250 (Central and Eastern Europe), 1257 (Baltic), 1254 (Turkish), 1253 (Greek), 1258 (Vietnamese) and also all characters of eleven macOS Code Pages (US Roman, Celtic, Central Europe, Croatian, Greek, Icelandic, Irish Gaelic, Lappish, Romanian, Southern Europe and Turkish).
2. All diacritics required for ISO 15919 ("Transliteration of Devanāgarī and related Indic Scripts into Latin characters": Vedic, Sanskrit, Hindi, Marathi, Bengali, Gujarati, Kannada, Telugu, Tamil, etc. etc. etc. - see [Dr. Anthony Stone's ISO 15919 website](http://homepage.ntlworld.com/stone-catend/translit.htm)) and many other non-ISO 15919, e.g. the additional diacritics used in the Sanskrit TITUS files, e.g. the additional diacritics needed by Buddhologists (Pali, Tibetan, Chinese, etc.), e.g. additional metrics symbols, e.g. additional diacritics used in the ALA-LC scheme (Kashmiri, Sumerian, Prakrit, Akkadian, Burmese, Divehi, etc. etc. etc.), e.g. additional diacritics for Iranian languages (Avestan, Bráhuí, Ishkashimi, Oroshor, Shughni, Wakhi, etc. etc. etc.), etc. etc. etc.
3. All diacritics required for ISO 9 ("Transliteration of Cyrillic languages into Latin characters": Russian, Ukrainian, Belorussian, Bulgarian, Macedonian, Serbian, Bosnian, Mongolian, Tajik, Yakut, Bashkir, Chechen, Kazakh, Abkhazian, Komi, Tatar, etc. etc. etc.)

## Other fonts
Created with FontCreator 5.6 (2007) - This version can only create ordinary Unicode fonts for non-OpenType-savvy word processors. Use FontCreator 7.0 or higher to create OpenType fonts. Some fonts should be renamed to avoid clashes with names on which Apple and The Font Bureau holds a trademark. I cancelled several font projects such as **Albertus Mega** (flare serif font).
* **Chicago Mega** is for indigenous languages in Central and South America. The font is best viewed at 9 or 18 points. This font comes in one style only - Regular.
* **Flareserif International** is based on Albertus. This font comes in one style only - Regular.
* **Geneva Mega** is for Native American languages using the Latin orthography. This font comes in one style only - Regular.
* **New York Plus** is for Native American languages using the Latin orthography. This font comes in one style only - Roman.

## FontCreator Data Files and Registry Keys (HTM file)
This file includes data files and registry keys for all FontCreator versions.

## Protest pages (HTM files)
These pages are available in four versions. Thanks to Norman De Forest for inspiring me to create the pages (see his index page for the descriptions). His own protest page uses the index page and are available in seven versions.

* **Web page not available** (Old Android browser) - The page is missing the Android logo at the top. This page uses http links. The link refers to a page at the **@Macarlo Networks, Incorporated** site however the company closed its business and the domain expired on July 2013.
* **Cannot find server** (Internet Explorer 6.0 - Windows XP RTM, SP1 and SP2) - This page uses javascript links and resources from shdoclc.dll (the res:// protocol is used). Default encoding tag and HTML color setting removed.

## Translations
* **Dual Module Player** - Czech (CP852) and German (CP850). Only Finnish and French translations are included.
* **EasyPaint** – Danish, Dutch, Finnish, German, Hungarian, Italian, Korean, Polish, Portuguese (Brazil), Romanian, Spanish, Swedish and Turkish (UTF-8). Only Chinese (Simplified), Czech, French and Russian translations are included.
* **SPFig** – Dutch (CP850). Only English and French translations are included.
* **Tinke** – Czech, Dutch, Korean, Portuguese (Brazil) and Russian (UTF-8). Only English, French, Italian and Spanish translations for user interface and English, French and Spanish translations for plugins are included.

## Palm OS Emulator skin for bob's game
This skin can be used with the emulators listed below. Robert Pelloni is not the original author of the Third Party Code. The original copyright notice and the license under which Robert Pelloni received such Third Party Code, are set forth below. Such licenses and notices are provided for informational purposes only. Robert Pelloni, not the third party, licenses the Third Party Code to you under the terms set forth in the EULA for bob's game. Robert Pelloni reserves all rights not expressly granted under this agreement, whether by implication, estoppel or otherwise.

### CoPilot/2
See Extras page on the unofficial bobsgame Wikia portal at the beginning above.

### Palm Hardware Emulator
Program available as expensive in the Google Play Store

Source code copyright: Portions of this software are Palm Hardware Emulator Copyright (C) 2013-2014 Perpendox Software LLC used under the terms of the GNU General Public License as published by the Free Software Foundation, Version 2.0. All rights reserved.

### Palm OS Emulator
Provided for Informational Purposes Only

Portions of this software are Palm OS Emulator Copyright (C) 1998-2002 Palm, Inc. used under the terms of the GNU General Public License as published by the Free Software Foundation, Version 2.0. All rights reserved.

#### Contributors
* Adam Dingle
* Adam Hampson
* Adam Liss
* Akhil Arora
* Alan Finke
* Alex Robinson
* Alexandre Parenteau
* Andreas Linke
* Andrew Ball
* Andy Ihlenfeldt
* Anthony Fishbeck
* Art Dahm
* Arturo Tena
* AvantGo
* B. Cameron Lesiuk
* Ben Combee
* Ben Darnell - Debian packaging
* Ben Sessoms
* Ben Thomas
* Ben Williamson
* Bernd Schmidt - Amiga port
* Bert Driehuis
* Bill Kirby
* Bill Pittore
* Bill Spitzak
* Bob Ebert
* Bob Marcum
* Bob Petersen
* Brian Estes
* Brian Mathis
* Bruce Ashley Photography - Skin creator
* Carlton Craighead
* Catherine White
* Chad House
* Chris Antos
* Chris Ridd
* Christian Falch
* Christopher Hunt
* Chunk Bazil
* Cooperative Computers, Inc.
* Craig Schofield - macOS port
* Dan Fahrion
* Dan Poirier
* Dan Rowley
* Dan Smith
* Daniel McCarthy
* Darren Kropp
* Dave Johnson
* David A. Desrosiers
* David A. Jablonski
* David Creemer
* David Fedor
* David Kendall
* David Slotter
* David Vaportrails
* Derek Johnson
* Doitchinov Ivan
* Doug Morrison
* Douglas R. Shefsky
* Easy Software
* Eric House
* Eskil Heyn Olsen
* Eugene Chin
* Flash Sheridan
* Florent Pillet
* Frank Yellin
* Frederic Paolucci
* Gary Gorsline
* Gavin Peacock
* Greg Hewgill - Original author
* Greg Simon
* Gregory Allen Gaub
* Guilherme C. Hazan
* Hal Mueller
* Handspring
* Harini Bharadvaj
* Harry Dolan
* Hiroyuki Okamoto
* Holger Klawitter
* Horace Ho
* International Business Machines
* James Phillips
* Jameson Quinn
* Jason Simpkins
* Jean-loup Gailly
* Jeff Prosise
* Jeff Yasuda
* Jerry Kirk
* Jerry Lin
* Jesse Donaldson
* John C. Daub
* John Duhart
* John Kinast
* John Ludwig - FreeBSD packaging
* John Marshall
* Jon Aslund
* Jon Fo
* Jonathan Cox
* Justin Clark
* Keith Rollin
* Keith Wolcott
* Kelly Maher
* Ken Hancock
* Ken Krugler
* Kenneth Albanowski
* Llamagraphics, Inc.
* Mahendra Tailor
* Mark Baysinger
* Mark Corry
* Mark Lussier
* Mark Ordal
* Mark Peters
* Markus Schmid
* Martin Kobold
* Matt Disher
* Matthias Ulrich Neeracher
* Maurizio Moretti
* Michael Glickman
* Michael Hado
* Michael Kedl
* Michael Nordstrom
* Michael S. Davis
* Mike Chen
* Mike McCollister
* Mike Nagy
* Mike Puckett
* Mike Turcotte
* Mike Walter
* Neil Rhodes
* Oliver King-Smith
* Patrick Porlan
* Paul Dugas
* Paul Nevai
* Paul Silagi
* Pedro Alves
* Peter Burka
* Peter N Lewis
* Phil Shoemaker
* Quinn "The Eskimo"
* Radu Cornea
* Red Dutta
* Regis Nicolas
* Richard Ziegelmaier
* Rick Richardson
* Rick Wagner
* Rob Leslie
* Roger Flores
* Ron Flax
* Ron Kupke
* Ron Marianetti
* Ryan Robertson
* Scott Gruby - Carbon port
* Scott Johnson
* Scott Maxwell
* Stefan Hoffmeister
* Stephen Best
* Stephen P. Hill
* Steve Achelis
* Steve Haneman
* Steve Lemke
* Stuart Eichert
* Stuart Malone
* Sushama Dharmadhikari
* Thomas Hagen Johansen
* Tilo Christ
* Tim Wiegman
* Tom Bulatewicz
* Toshi Clark
* Vitaly Kruglikov
* Vladimir Amarante
* Waddah Kudaimi
* William F. Weiher III
* Yoshiyuki Kubo
