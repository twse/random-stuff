# Index
* **FontCreator Data Files and Registry Keys** (Markdown file): Shows a list of data files, registry keys and RC data for the pay shareware font editor FontCreator.
* **names.csv**: Names for adding to [Mozilla credits list](https://www.mozilla.org/credits/). We know there are many Mozillians, past and present, who do not have Mozillians or Mozilla Bugzilla profiles. This includes former staff who have not updated their email address on Mozillians and Mozilla Bugzilla. This list only accepts names via the form as through the policy and in the [FAQ](https://www.mozilla.org/credits/faq).
* **SitePal Forum Drug Words** (HTM file): Shows a list of medicine product brand names used to spam the legacy SitePal forum, which includes but are not limited to antibiotics, pharmaceutics, decongestants, chemotherapeutics, organic acids, progestogens, analgesics, topical products, modulators, triptans, carbohydrates et al.

## Fonts
Created with FontCreator 5.6 (2007) - FontCreator 7.0 or higher can create OpenType fonts.
* **Cyrano Text**: Based on [Cyrano Nouveau](http://www.typophile.com/node/64838) (2009) from the Typophile forums by MrMoto, Canada with revised glyphs and support for more glyphs. Both fonts are named after the 1998 movie Cyrano de Bergerac.
* **Generic Menu**: Based on the font in *WarioWare* GBA and NDS games. Thanks goes to Jackster from [The Spriters Resource](https://www.spriters-resource.com) for ripping the font. Windows Vista and above fakes the font icon as Japanese (only two Kanji letters are included in the font).
* **LTROL Font**: Based on the font in the American version of *Lufia: The Ruins of Lore*. Created using CrystalTile2. This font is not licensed or endorsed by ATLUS U.S.A., Inc., SEGA of America, Inc., SEGA Europe Ltd., SQUARE ENIX, Inc. or SQUARE ENIX Ltd.
* **Readable Fonts**: Based on “System VIO” from OS/2 and the 16 pixel font used in the IBM ThinkPad Power Series 820 command line (with different glyph designs).
* **ZOE TFOM**: Based on the font in western versions of *Zone of the Enders: The Fist of Mars* (Kanji letters omitted). Created using CrystalTile2 and FontCreator 5.6. This font is not licensed or endorsed by Konami Digital Entertainment, Inc. or Konami Digital Entertainment B.V.

## Manually bulk-adding names to Mozilla credits list via command line
You won't receive any emails when your name is added - this will only see the message in the log.
1. Clone the `mozilla/community-data` repository.
2. Copy names of contributors from Mozilla-related websites such as translation projects.
3. Save the file as .csv (comma separated value).
4. Add the contents to `names.csv` via `echo file.csv >> ../names.csv` and replace `file.csv` with whatever name you want.
5. Commit the new file via `-a -m 'message'` and replace it with whatever message you want.
6. Login as `gurumukhi` to push changes.
7. Enter `about:credits` (Mozilla browsers) in the address bar or visit the page directly for non-Mozilla browsers by clicking the link at the beginning and the entries will appear with the last updated date being changed.

## Manually bulk-adding names to Mozilla credits list via GitHub web interface
Only works when committed and logged in as the last entry in the below owner list. You won't receive any emails when your name is added - this will only see the message in the log.
1. Go to the `credits` directory of `community-data` repository, click the `names.csv` file and click the pencil at the top-right corner to edit it.
2. Copy names of contributors from Mozilla-related websites such as translation projects.
3. Enter any commit message you want.
4. Use the default option (commit directly to the `master` branch).
5. Enter `about:credits` (Mozilla browsers) in the address bar or visit the page directly for non-Mozilla browsers by clicking the link at the beginning and the entries will appear with the last updated date being changed.

## Manually adding a name to Mozilla credits list via command line
You won't receive any emails when your name is added - this will only see your name, email and citation in the log.
1. Clone the `mozilla/community-data` repository.
2. Edit `names.csv` to add your name at the end or use `echo name,sortkey >> names.csv` replaced with your name and sort key.
3. Commit the new file with `-a -m 'name <email>: \"citation\"'` replaced with your name, email and citation.
4. Login as `gurumukhi` to push changes.
5. Enter `about:credits` (Mozilla browsers) in the address bar or visit the page directly for non-Mozilla browsers by clicking the link at the beginning and the entry will appear with the last updated date being changed.

## Manually adding a name to Mozilla credits list via GitHub web interface
Only works when committed and logged in as the last entry in the below owner list. You won't receive any emails when your name is added - this will only see your name, email and citation in the log.
1. Go to the `credits` directory in the `mozilla/community-data` repository, click the `names.csv` file and click the pencil at the top-right corner to edit it.
2. Add your name at the end.
3. Use the name &lt;email&gt;: "citation" format for the commit message replaced with your name, email and citation.
4. Use the default option (commit directly to the `master` branch).
5. Enter `about:credits` (Mozilla browsers) in the address bar or visit the page directly for non-Mozilla browsers by clicking the link at the beginning and the entry will appear with the last updated date being changed.

## Mozilla credits list owners
The `names.csv` file is located in the credits directory in the `mozilla/community-data` repository.

| Name               | Nickname  | Years active | Collaborator? | Forked repository? |
|--------------------|-----------|--------------|---------------|--------------------|
| Dawn Endico        | endico    | 1999-2003    | NO            | NO                 |
| Gervase Markham    | gerv      | 2004-2017    | YES           | NO                 |
| Ram Dayal Vaishnav | gurumukhi | 2017-present | YES           | YES                |

**P.S.** The first entry created the page via CVS in 1999/08/29 and posted a message to the Mozilla internationalization and SeaMonkey newsgroups. The second entry wrote management tools in 2011/03 when he added many previous localizers via SVN and committed directly via GIT without using pull requests. The last entry is committing with pull requests to modify the credits list and closes them for additions not from the form (e.g. bulk additions) or modifications not from replies to the application message with a comment.

## Protest pages (requires JavaScript; available in five versions with default encoding removed)
Thanks goes to [Norman L. De Forest](http://www.chebucto.ns.ca/~af380/), Canada (1942-2006) for his protest pages.

* **Web page not available** (Android) – The link refers to a page at the **@Macarlo, Inc** website (currently down since 2013/07/01).
* **Cannot find server** (Internet Explorer 6 – Windows XP RTM, SP1 and SP2) – Windows XP SP3 added network diagnostics stuff (not included in this page).
* **Internet Explorer cannot display the webpage** (Internet Explorer 7-10 – Windows XP SP2 & above) – In this page is a button labeled **Diagnose Connection Problems** (pressing in the browser itself when the original page is accessed as `res://shdocvw.dll/dnserror.htm` opens the network diagnostic tool).
* **This page can't be displayed** (Internet Explorer 11) – In this page is a button labeled **Fix connection problems** (pressing in the browser itself when the original page is accessed as `res://ieframe.dll/dnserror.htm` opens the network diagnostic tool – the button is also in the **Tools** menu). Remove the style in `notConnectedTasks`, add the style to `cantDisplayTasks` and change the heading/title to **You're not connected to the internet** to make this page resemble computers not connected to the internet.

## Translations of EasyPaint into multiple languages
All translations are in ts format (edited using Qt Linguist or other program). Generated translations can be found in [CMakeLists.txt](https://github.com/Gr1N/EasyPaint/CMakeLists.txt) (line 109).

* Danish (da_DK)
* Finnish (fi_FI)
* German (de_DE)
* Hungarian (hu_HU)
* Korean (ko_KR)
* Polish (pl_PL)
* Portuguese, as spoken in Brazil (pt_BR)
* Romanian (ro_RO) – Contributed by Nicolae Oprea
* Spanish (es_ES)
* Swedish (sv_SE)
