# Index
* **FontCreator Data Files and Registry Keys.md**: Contains the data files, fun facts, registry keys and RC data (including unused content) for the pay shareware font editor *FontCreator*.
* **names.csv**: Names for inclusion in the [Mozilla credits list](https://www.mozilla.org/credits/). We know there are many Mozillians, past and present, who may have Mozilla Bugzilla profiles. This includes legacy contributors who have not created their account or updated their email address on Mozilla Bugzilla. It does not include the Mozilla Bugzilla email addresses.
* **SitePal Forum Drug Words.htm**: Shows a list of medicine brand names excluding song artists used to spam the old SitePal forum. **Fun fact:** This page is based on the [Mozilla credits list](https://www.mozilla.org/credits/).

## Index of fonts
Created with CrystalTile2 and edited with old versions of FontCreator. All except LTROL Font and ZOE TFOM are released under the terms of the WTFPL license (see the license agreement field in the fonts).
* **Cyrano Text**: Based on [Cyrano Nouveau](https://www.typophile.com/node/64838) (2009) by Tim Mott (MrMoto) with revised glyphs and support for more glyphs. Both fonts are named after the French dramatist/movie Cyrano de Bergerac.
* **Generic Menu**: Font adapted and converted from the GBA/DS versions of *WarioWare* (small font). Thanks to Jackster from [The Spriters Resource](https://www.spriters-resource.com) for ripping the font. Windows Vista and above fakes the font preview as Japanese.
* **LTROL Font**: Font adapted and converted from the US version of *Lufia: The Ruins of Lore*.
* **Readable Fonts**: Based on “System VIO” from OS/2 and the 16 pixel font in the IBM ThinkPad Power Series 820 terminal or PC-DOS 2000 Traditional Chinese version (with different glyph designs).
* **ZOE TFOM**: Font adapted and converted from the US and EU versions of *Zone of the Enders: The Fist of Mars* (Kanji letters omitted). The original font in the game itself reverses two rows for all characters.

## Doing manual additions in the Mozilla credits list
It will be useful if you want to modify the `names.csv` file without filling in the form, so it could be worth doing manual updates if you have no knowledge with or intent on Google Forms.

### Bulk addition
**Command line** - They won't receive emails when everyone is added - this will see the message in the log.
1. Clone the `mozilla/community-data` repository.
2. Copy names from Mozilla-related websites such as translation projects.
3. Save the file as .csv (the file extension means comma separated value).
4. Add the contents to `names.csv` via `echo file.csv >> ../names.csv` with the second word replaced with your actual file having a list.
5. Commit changes via `git commit -a -m "message"` replaced with your own message.
6. Login as the current owner (see module info below) to push changes.
7. View the Mozilla credits list to change the last updated date (American style) and add the entries.

**GitHub web interface** - Do this only when logged in as the current owner in the module info below. They won't receive emails when everyone is added - this will see the message in the log.
1. In the `mozilla/community-data` repository, go to the `credits` directory, click the `names.csv` file and click the pencil at the top-right corner to edit it.
2. Copy names from Mozilla-related websites such as translation projects.
3. Enter any commit message or use the default message.
4. Use the default option which commits directly to `master`.
5. View the Mozilla credits list to change the last updated date (American style) and add the entries.

### One name
**Command line** - You won't receive any emails when your name is added - this will see your name, email and citation in the log.
1. Clone the `mozilla/community-data` repository.
2. Edit `names.csv` to add your name at the end or use `echo name,sortkey >> names.csv` and replace the second word with your name and sort key.
3. Commit changes with `-a -m 'name <email>: \"citation\"'` replaced with your name, email and citation.
4. Login as the current owner (see module info below) to push changes.
5. View the Mozilla credits list to change the last updated date (American style) and add your entry.

**GitHub web interface** - Do this only when logged in as the current owner in the module info below. You won't receive any emails when your name is added - this will see your name, email and citation in the log.
1. In the `mozilla/community-data` repository, go to the `credits` directory, click the `names.csv` file and click the pencil at the top-right corner to edit it.
2. Add your name at the end.
3. Use name &lt;email&gt;: "citation" as the commit message replaced with your name, email and citation.
4. Use the default option which commits directly to `master`.
5. View the Mozilla credits list to change the last updated date (American style) and add your entry.

## Edit or remove yourself in the Mozilla credits list
**Command line**
1. Clone the `mozilla/community-data` repository.
2. Rebase the repository with a large number to display all commits in the log.
3. Edit the `names.csv` file to change or remove your entry.
4. **Reword** the message to edit the name, email, citation or all strings or **drop** the message to remove the commit.
5. Save it, login as the current owner (see module info below) and force the changes to push.
6. View the Mozilla credits list to change the last updated date and edit/remove your entry.

**GitHub web interface**
1. Go to the `credits` directory in the `mozilla/community-data` repository, click the `names.csv` file and edit it with the pencil at the top-right corner.
2. Edit or remove your entry.
3. Enter any commit message or leave the default message as is.
4. Use the default option which commits directly to `master`.
5. View the Mozilla credits list to change the last updated date and edit/remove your entry.

## Mozilla credits list module info
* **Description:** Shows a list of all those who contributed to Mozilla. (Source: about URI scheme, Wikipedia)
* **Owner:** Mohammad Shahbaz Alam (2019-present – write access only)
* **Owners Emeritus:** Dawn Endico (1999-2003 – CVS), Gervase Markham (2003-2017 – CVS, GIT and SVN), Ram Dayal Vaishnav (2017-2019 – write access only)
* **Source Dir:** GitHub Repository `mozilla/community-data/credits` (`names.csv` file)
* **URL:** See second file entry in the index above (in Mozilla apps it also links to `about:credits`).
* **Note:** Pull requests for additions without filling the form or modifications without replying to application acceptance messages are closed with a comment. This will result in unmerged commits!

## Index of protest pages (requires JavaScript; available in five versions as a zipped archive)
Thanks to [Norman L. De Forest](http://www.chebucto.ns.ca/~af380/) (1942-2006) for using the same content in his pages (main page used). In this archive is an unsupported browser page which many websites have it (e.g. iCloud, PayPal or Kroger).
* **Web page not available** (Android) – The link refers to a page in the **@Macarlo, Inc** website (defunct since 2013/07/01).
* **Cannot find server** (Internet Explorer 6 – Windows XP SP3) – **Fun fact:** Many Internet Explorer versions use different text strings for some steps in the original page.
* **Internet Explorer cannot display the webpage** (Internet Explorer 7-10 – Windows XP SP2 & above) – In this page is a button labeled **Diagnose Connection Problems** (pressing when accessed as `res://shdocvw.dll/dnserror.htm` or `res://shdocvw.dll/dnserrordiagoff.htm` opens the network diagnostic tool).
* **This page can't be displayed** (Internet Explorer 11) – The domain refers to a page in the **@Macarlo, Inc** website (defunct since 2013/07/01). In this page is a button labeled **Fix connection problems** (pressing when accessed as `res://ieframe.dll/dnserror.htm` or `res://ieframe.dll/dnserrordiagoff.htm` opens the network diagnostic tool and enables the option from the **Tools** menu).
* **Page Load Error** (Firefox and other Mozilla browsers) – The **Address Not Found** text is taken from the Splashtop Browser.

## Translations of EasyPaint in multiple languages
All translations are in ts format. Generated translations are found in [CMakeLists.txt](https://github.com/Gr1N/EasyPaint/blob/master/CMakeLists.txt#L109). Nikita Grishko stopped developing this program in 2018-02-08.
* Danish (da_DK)
* Esperanto (eo)
* Finnish (fi_FI)
* German (de_DE) – **Note:** Unmerged pull request created for inclusion
* Hungarian (hu_HU)
* Korean (ko_KR)
* Polish (pl_PL) – **Note:** Unmerged pull request created for inclusion
* Portuguese, as spoken in Brazil (pt_BR)
* Romanian (ro_RO) – Contributed by Nicolae Oprea
* Spanish (es_ES)
* Swedish (sv_SE)
