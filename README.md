﻿# Index
* **names.csv**: Contributor names to add to the [Mozilla credits list](https://www.mozilla.org/credits/). We know there are many Mozillians, past and present, who do not have Mozilla Bugzilla or Mozilla Pontoon profiles. This includes legacy contributors and translators who have not updated their email address on Mozilla Bugzilla and Mozilla Pontoon. The list is sorted by Unicode codepoint.
* **SitePal Forum Drug Words.htm**: Shows a list of medicine brand names excluding song artists used to spam the old SitePal forum. **Fun fact:** This page is based on the [Mozilla credits list](https://www.mozilla.org/credits/).
* (Not present in this repository) [Font test pages with game dialogues](https://drive.google.com/uc?id=11DeLAaXrlsdL4rtde386v5TFi0_b8zsd&export=download). It uses the `lang` HTML attribute to repeat the text over and over again for each language. Only languages with Latin, Greek and Cyrillic script are included. See the comments for each paragraph in the font-specific HTML pages to determine what game uses the dialogue and who wrote or translated the text in each language. Swearing is everywhere in the font-specific pages so readers should be 12 or older.
* (Not present in this repository) User agents for Otter Browser for [Mac browsers](https://drive.google.com/uc?id=1-AkleGvhHpgbLkLnhYKpaoo1fKqIjjv-&export=download), [mobile platforms](https://drive.google.com/uc?id=1VRSVtj_AxrrD-jaKYhk5xZ1S-g_MauvJ&export=download) and [game consoles](https://drive.google.com/uc?id=1JJZ9qHIFXxyQTBJTFfX120Z3rIS5pBbb&export=download)

## Data Files and Registry Keys in Software
* **FontCreator Data Files and Registry Keys.md**: Contains the data files, fun facts, registry keys and RC data (including unused content) for *FontCreator* (pay shareware font editor).
* **PurgeIE Data Files and Registry Keys.md**: Contains the data files, fun facts and RC data (including unused content) for *PurgeIE* (pay shareware utility to remove Internet Explorer browsing data such as history).

## Fonts
Created with CrystalTile2 and edited with old versions of FontCreator. All except LTROL Font and ZOE TFOM are released under the terms of the WTFPL license (see the license agreement field in the fonts).
* **Cyrano Text** (named after Cyrano de Bergerac): Based on [Cyrano Nouveau](https://www.typophile.com/node/64838) (2009) by Tim Mott (MrMoto) with revised glyphs and support for more glyphs.
* **Generic Menu**: Font adapted and converted from the GBA/DS versions of *WarioWare* (small font). Thanks to Jackster from [The Spriters Resource](https://www.spriters-resource.com/) for ripping the font. Windows Vista and above fakes the font preview as Japanese.
* **LTROL Font**: Font adapted and converted from the US version of *Lufia: The Ruins of Lore*.
* **Readable Fonts**: Based on the System VIO font from OS/2 with revised glyphs and support for more glyphs.
* **ZOE TFOM**: Font adapted and converted from the US/EU versions of *Zone of the Enders: The Fist of Mars* (Kanji letters omitted). The original font in the game's ROM reverses two rows for all characters.

## Manually adding to the Mozilla credits list
It's useful if you want to modify the `names.csv` file without filling in the form if you have no knowledge with or intent on using Google Forms.

### Bulk addition
**Command line** - They won't receive emails when everyone is added - this will see the message in the log.
1. Clone the `mozilla/community-data` repository.
2. Copy names from Mozilla-related websites such as translation projects.
3. Save the file as comma separated values (file extension `.csv`).
4. Add the contents to `names.csv` via `echo file.csv >> ../names.csv` with the second word replaced with your actual file having a list.
5. Commit changes with `-a -m "message"` replaced with your own message.
6. Login as the current owner (see module info below) to push changes.
7. View the Mozilla credits list to change the last updated date and add the entries.

**GitHub web interface** - Do this only when logged in as the current owner in the module info below. They won't receive emails when everyone is added - this will see the message in the log.
1. Look for `names.csv` in the `credits` directory of `mozilla/community-data` repository and edit it with the pencil at the top-right corner.
2. Copy names from Mozilla-related websites such as translation projects.
3. Enter any commit message or use the default message.
4. Use the default option which commits directly to `master`.
5. View the Mozilla credits list to change the last updated date and add the entries.

### One name
**Command line** - You won't receive any emails when your name is added - this will see your name, email and citation in the log.
1. Clone the `mozilla/community-data` repository.
2. Edit `names.csv` to add your name at the end or use `echo name,sortkey >> names.csv` and replace the second word with your name and sort key. Example: `echo Michael James Hardy,Hardy >> names.csv`
3. Commit changes with `-a -m 'name <email>: \"citation\"'` replaced with your name, email and citation. Example: `git commit -a -m 'Michael James Hardy <email address hidden>: \"For stealing old versions of Firefox and renaming the program\"`
4. Login as the current owner (see module info below) to push changes.
5. View the Mozilla credits list to change the last updated date and add your entry.

**GitHub web interface** - Do this only when logged in as the current owner in the module info below. You won't receive any emails when your name is added - this will see your name, email and citation in the log.
1. Look for `names.csv` in the `credits` directory of `mozilla/community-data` repository and edit it with the pencil at the top-right corner.
2. Add your name at the end. Example: **Michael James Hardy,Hardy**
3. Use **name &lt;email&gt;: "citation"** as the commit message replaced with your name, email and citation. Example: **Michael James Hardy &lt;email address hidden&gt;: "For stealing old versions of Firefox and renaming the program"**
4. Use the default option which commits directly to `master`.
5. View the Mozilla credits list to change the last updated date and add your entry.

## Edit or remove yourself in the Mozilla credits list
**Command line**
1. Clone the `mozilla/community-data` repository.
2. Edit the `names.csv` file to change or remove your entry.
3. Save it, login as the current owner (see module info below) and force the changes to push.
4. View the Mozilla credits list to change the last updated date and edit/remove your entry.

**GitHub web interface**
1. Look for `names.csv` in the `credits` directory of `mozilla/community-data` repository and edit it with the pencil at the top-right corner.
2. Edit or remove your entry.
3. Enter any commit message or leave the default message as is.
4. Use the default option which commits directly to `master`.
5. View the Mozilla credits list to change the last updated date and edit/remove your entry.

### Modify the script to add entries with unqualified notes in the Mozilla credits list
The script is **check-names** located in `credits` in the `mozilla/community-data` repository.
* To modify the Perl script (file extension `.pl`), you see **next if $notes ne "Y";** in the 70th line. Change it to **Email Not Found**, **Evidence not public**, **N**, **Non Qual** or **Not enough evidence** yourself.
* To modify the Python script (file extension `.py`), you see **if row[-2] == 'Y':** in the 14th line. Change it to **Email Not Found**, **Evidence not public**, **N**, **Non Qual** or **Not enough evidence** yourself.

## Mozilla credits list module info
* **Description:** Shows a list of all those who contributed to Mozilla. The original list was created in August 1999.
* **Owner:** Mohammad Shahbaz Alam (2019-present – GIT)
* **Owners Emeritus:** Dawn Endico (1999-2003 – CVS), Gervase Markham (2003-2017 – CVS, GIT and SVN), Ram Dayal Vaishnav (2017-2019 – GIT)
* **Source Dir:** GitHub Repository `mozilla/community-data/credits` (`names.csv` file)
* **URL:** See second file entry in the index above.
* **Note:** Pull requests for additions not done via the form linked to the credits page or changes not done via replies to the form's application acceptance messages are closed by the module's owner with a comment. The pull request will result in unmerged commits!
* **Fun fact:** The form linked to the credits page and its responses spreadsheet was created in November 2013 by Gervase Markham (the guy with access privileges) to remove its request email address.

## Index of protest pages (requires JavaScript)
Thanks to [Norman L. De Forest](http://www.chebucto.ns.ca/~af380/Profile.html) (1942-2006) for creating the original protest pages derived from his profile page and the protest images for graphical browsers.
* **Web page not available** (Android) – The link refers to a page in the **@Macarlo, Inc** website (defunct since 2013/07/01).
* **Cannot find server** (Internet Explorer 6 – Windows XP SP3) – **Fun fact:** Many Internet Explorer versions use different text strings for some steps in the original page. The original page is available as an HTML resource in `shdoclc.dll` (Windows 98 & above), `xpsp2res.dll` (Windows XP Service Pack 2) and `xpsp3res.dll` (Windows XP Service Pack 3).
* **Internet Explorer cannot display the webpage** (Internet Explorer 7-10 – Windows XP SP2 & above) – In this page is a button labeled **Diagnose Connection Problems** (pressing when accessed as `res://shdocvw.dll/dnserror.htm` or `res://shdocvw.dll/dnserrordiagoff.htm` opens the network diagnostic tool if it is installed and present).
* **This page can't be displayed** (Internet Explorer 11) – The domain refers to a page in the **@Macarlo, Inc** website (defunct since 2013/07/01). In this page is a button labeled **Fix connection problems** (pressing when accessed as `res://ieframe.dll/dnserror.htm` or `res://ieframe.dll/dnserrordiagoff.htm` opens the network diagnostic tool if it is installed and present and enables the option from the **Tools** menu).
* **Page Load Error** (Firefox and other Mozilla browsers) – The **Address Not Found** text is taken from the Splashtop Browser.
* **Error** (Otter Browser) – The text used in this page is same as the Presto version of Opera (the Blink version does not).

The protest pages are as follows:
* **protest.htm** replaces HTML link tags with LINK in square brackets.
* **protest2.htm** replaces everything with IMAGE and INLINE in square brackets.
* **protest3.htm** protests against sites that use JavaScript URLs.
* **protest4.htm** protests against sites that use HTML external links so the links do nothing when selected.
* **protest5.htm** redirects to an "Unsupported Browser" page (see the page itself in the zipped archive for a partial list).

## Translations of EasyPaint in multiple languages
All translations are in `ts` format and can be edited with e.g. Qt Linguist. Generated translations are found in [CMakeLists.txt](https://github.com/Gr1N/EasyPaint/blob/master/CMakeLists.txt#L109). Nikita Grishko stopped developing the program in 2018/02/08.
* Danish (`da_DK`)
* Esperanto (`eo`)
* Finnish (`fi_FI`)
* German (`de_DE`) – Contributed by freddii. **Note:** Unmerged pull request created
* Hungarian (`hu_HU`)
* Korean (`ko_KR`)
* Polish (`pl_PL`) – **Note:** Unmerged pull request created
* Portuguese, as spoken in Brazil (`pt_BR`)
* Romanian (`ro_RO`) – Contributed by Nicolae Oprea
* Spanish (`es_ES`)
* Swedish (`sv_SE`)
