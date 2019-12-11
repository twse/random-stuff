# Index
* **FontCreator Data Files and Registry Keys** (Markdown file): Shows a list of data files, registry keys and RC data (including unused content) for the pay shareware font editor *FontCreator*.
* **names.csv**: Names for inclusion in the [Mozilla credits list](https://www.mozilla.org/credits/). We know there are many Mozillians, past and present, who do not have Mozillians or Mozilla Bugzilla profiles. This includes former staff who have not updated their email address on Mozillians and Mozilla Bugzilla. **Fun fact:** This list only accepts names via the form as through the policy and in the [FAQ](https://www.mozilla.org/credits/faq).
* **SitePal Forum Drug Words** (HTM file): Shows a list of medicine product brand names used to spam the legacy SitePal forum, which includes but are not limited to antibiotics, carbohydrates, pharmaceutics etc. etc. etc. **Fun fact:** This page is based on the [Mozilla credits list](https://www.mozilla.org/credits/).

## Fonts
Created with FontCreator 5.6 (2007) - FontCreator 6.5 is the last version to support creating only ordinary Unicode fonts.
* **Cyrano Text**: Based on [Cyrano Nouveau](http://www.typophile.com/node/64838) (2009) from the Typophile forums by MrMoto with revised glyphs and support for more glyphs. Both fonts are named after the 1998 movie Cyrano de Bergerac.
* **Generic Menu**: Based on the font in *WarioWare* GBA and NDS games. Thanks goes to Jackster from [The Spriters Resource](https://www.spriters-resource.com) for ripping the font. Windows Vista and above fakes the font preview as Japanese.
* **LTROL Font**: Based on the font in the American version of *Lufia: The Ruins of Lore*. Created using CrystalTile2. This font is not licensed or endorsed by ATLUS U.S.A., Inc., Natsume Inc., SEGA of America, Inc., SEGA Europe Ltd., SQUARE ENIX, Inc. or SQUARE ENIX Ltd.
* **Readable Fonts**: Based on “System VIO” from OS/2 and the 16 pixel font used in the IBM ThinkPad Power Series 820 command line (with different glyph designs).
* **ZOE TFOM**: Based on the font in western versions of *Zone of the Enders: The Fist of Mars* (Kanji letters omitted). Created using CrystalTile2 and FontCreator 5.6. This font is not licensed or endorsed by Konami Digital Entertainment, Inc. or Konami Digital Entertainment B.V.

## Bulk-add names to Mozilla credits list via command line
You won't receive any emails when your name is added - this will see the message in the log.
1. Clone the `mozilla/community-data` repository.
2. Copy names from Mozilla-related websites such as translation projects.
3. Save the file as .csv (comma separated value).
4. Add the contents to `names.csv` via `echo file.csv >> ../names.csv` with the second word replaced with your actual file having a list.
5. Commit the new file via `-a -m "message"` replaced with your own message.
6. Login as `gurumukhi` to push changes.
7. View the Mozilla credits list to change the last updated date and add the entries.

## Bulk-add names to Mozilla credits list via GitHub web interface
Only works when logged in as the last entry in the below owner list. You won't receive any emails when your name is added - this will see the message in the log.
1. In the `mozilla/community-data` repository, go to the `credits` directory, click the `names.csv` file and click the pencil at the top-right corner to edit it.
2. Copy names from Mozilla-related websites such as translation projects.
3. Enter any commit message or leave the default message as is.
4. Use the default option which commits directly to `master`.
5. View the Mozilla credits list to change the last updated date and add the entries.

## Add yourself to Mozilla credits list via command line
You won't receive any emails when your name is added - this will see your name, email and citation in the log.
1. Clone the `mozilla/community-data` repository.
2. Edit `names.csv` to add your name at the end or use `echo name,sortkey >> names.csv` with the second word replaced with your name and sort key.
3. Commit the new file with `-a -m 'name <email>: \"citation\"'` replaced with your name, email and citation.
4. Login as `gurumukhi` to push changes.
5. View the Mozilla credits list to change the last updated date and add your entry.

## Add yourself to Mozilla credits list via GitHub web interface
Only works when logged in as the last entry in the below owner list. You won't receive any emails when your name is added - this will see your name, email and citation in the log.
1. Go to the `credits` directory in the `mozilla/community-data` repository, click the `names.csv` file and click the pencil at the top-right corner to edit it.
2. Add your name at the end.
3. Use the name &lt;email&gt;: "citation" format for the commit message replaced with your name, email and citation.
4. Use the default option which commits directly to `master`.
5. View the Mozilla credits list to change the last updated date and add your entry.

## Edit or remove yourself in Mozilla credits list via command line
1. Clone the `mozilla/community-data` repository.
2. Rebase the repository with a higher number to edit all revisions (i.e. display the entire log).
3. Edit the `names.csv` file to change or remove your entry.
4. Replace the first word with **reword** to edit the name, email, citation or all strings in the message or **drop** to remove the commit message in the log.
5. Save it, login as `gurumukhi` and force push the changes.
6. View the Mozilla credits list to change the last updated date and remove your entry.

## Mozilla credits list owners
`names.csv` is located in `credits` directory from the `mozilla/community-data` repository.

| Name and Nickname              | GH Account? | Active    | Commit Access?  |
|--------------------------------|-------------|-----------|-----------------|
| Dawn Endico (endico)           | NO          | 1999-2003 | CVS             |
| Gervase Markham (gerv)         | YES         | 2004-2017 | CVS, GIT, SVN   |
| Ram Dayal Vaishnav (gurumukhi) | YES         | 2017-     | GH Collaborator |

**Fun fact:** The first entry created this list in 1999/08/29 and posted it to the Mozilla mailing list/newsgroup. The third entry forked the above repository, commits with pull requests and closes pull requests for additions not from the form (e.g. bulk additions) or modifications not from replies to the application acceptance mail with a comment via the second file entry's last paragraph in the above index.

## Protest pages (requires JavaScript; available in five versions)
Thanks goes to [Norman L. De Forest](http://www.chebucto.ns.ca/~af380/) (1942-2006) for the inspiration of creating these pages (his protest pages is based on his main page).

* **Web page not available** (Android) – The link refers to a page at the **@Macarlo, Inc** website (currently down since 2013/07/01).
* **Cannot find server** (Internet Explorer 6 – Windows XP RTM, SP1 and SP2) – Windows XP SP3 added network diagnostics stuff (not included in this page).
* **Internet Explorer cannot display the webpage** (Internet Explorer 7-10 – Windows XP SP2 & above) – In this page is a button labeled **Diagnose Connection Problems** (pressing in the browser itself when the original page is accessed as `res://shdocvw.dll/dnserror.htm` opens the network diagnostic tool).
* **This page can't be displayed** (Internet Explorer 11) – The domain refers to a page at the **@Macarlo, Inc** website (currently down since 2013/07/01). In this page is a button labeled **Fix connection problems** (pressing in the browser itself when the original page is accessed as `res://ieframe.dll/dnserror.htm` opens the network diagnostic tool and enables the option from the **Tools** menu). **Fun fact:** The page title changes to **You're not connected to the internet** for computers with network problems.

## Translations of EasyPaint into multiple languages
All translations are in ts format (edited using Qt Linguist or other program). Generated translations are found in [CMakeLists.txt](https://github.com/Gr1N/EasyPaint/CMakeLists.txt) (line 109). Nikita Grishko stopped developing this program last year in January – he is committing via other repositories.

* Danish (da_DK)
* Esperanto (eo)
* Finnish (fi_FI)
* German (de_DE)
* Hungarian (hu_HU)
* Korean (ko_KR)
* Polish (pl_PL)
* Portuguese, as spoken in Brazil (pt_BR)
* Romanian (ro_RO) – Contributed by Nicolae Oprea
* Spanish (es_ES)
* Swedish (sv_SE)
