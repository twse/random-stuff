# Index
* **FontCreator Data Files and Registry Keys** (Markdown file): Shows a list of data files, registry keys and RC data for the pay shareware font editor FontCreator.
* **names.csv**: Names for adding to [Mozilla credits list](https://www.mozilla.org/credits). We know there are many Mozillians, past and present, who do not have Mozillians or Mozilla Bugzilla profiles. This includes former staff who have not updated their email address on Mozillians and Mozilla Bugzilla. This list only accepts names via the form as through the policy and mentioned in the [FAQ](https://www.mozilla.org/credits/faq).
* **SitePal Forum Drug Words** (HTM file): Shows a list of medicine product brand names used to spam the legacy SitePal forum, which includes but are not limited to antibiotics, pharmaceutics, decongestants, chemotherapeutics, organic acids, progestogens, analgesics, topical products, modulators, triptans, carbohydrates et al.

## Fonts
Created with FontCreator 5.6 (2007) - FontCreator 7.0 or higher can create OpenType fonts.
* **Cyrano Text**: Based on [Cyrano Nouveau](http://www.typophile.com/node/64838) (2009) from the Typophile forums by MrMoto, Canada with revised glyphs and support for more glyphs. Both fonts are named after the 1998 movie Cyrano de Bergerac.
* **Generic Menu**: Based on the font used in *WarioWare* GBA and NDS games. Thanks goes to Jackster from [The Spriters Resource](https://www.spriters-resource.com) for ripping the font. Windows Vista and above fakes the font preview as Japanese (a subset of Kanji letters are included in the font).
* **LTROL Font**: Based on the font used in the American version of *Lufia: The Ruins of Lore*. Created using CrystalTile2. This font is not licensed or endorsed by ATLUS U.S.A., Inc., SEGA of America, Inc., SEGA Europe Ltd., SQUARE ENIX, Inc. or SQUARE ENIX Ltd.
* **Readable Fonts**: Based on “System VIO” from OS/2 and the 16 pixel font used in the IBM ThinkPad Power Series 820 command line (with different glyph designs).
* **ZOE TFOM**: Based on the font used in western versions of *Zone of the Enders: The Fist of Mars*, excluding CJK Unified Ideographs. Created using CrystalTile2 and FontCreator 5.6. This font is not licensed or endorsed by Konami Digital Entertainment, Inc. or Konami Digital Entertainment B.V.

## Manually bulk-adding names to Mozilla credits list via command line
You won't receive any emails when your name is added - this will only see the message in the log.
1. Clone the `mozilla/community-data` repository via `git clone`.
2. Copy names of contributors from Mozilla-related websites such as translation projects or local communities and remove the summaries of each member's contributions.
3. Save the file as .csv (comma separated value).
4. Add the contents to names.csv: `echo file.csv >> ../names.csv` and replace the filename with whatever you want, e.g. czilla.csv has the names of all contributors for CZilla - old name of Mozilla's community for Czech.
5. Commit the new file with the added names: `git commit -a -m 'message'` and replace it with whatever message you want.
6. Push your changes with `git push` using `gurumukhi` as the username and enter the user's password.
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
1. Clone the `mozilla/community-data` repository via `git clone`.
2. Edit `names.csv` to add your name at the end or use `echo name,sortkey >> names.csv` replaced with your name and sort key.
3. Commit the new file using `git commit -a -m 'name <email>: \"citation\"'` replaced with your name, email and citation.
4. Push your changes with `git push` using `gurumukhi` as the username and enter the user's password.
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

| Name               | Nickname  | GH Account? | Years active | Collaborator? |
|--------------------|-----------|-------------|--------------|---------------|
| Dawn Endico        | endico    | NO          | 1999-2003    | NO            |
| Gervase Markham    | gerv      | YES         | 2004-2017    | YES           |
| Ram Dayal Vaishnav | gurumukhi | YES         | 2017-present | YES           |

**Historical note:** The first entry created this page (in rough alphabetical order by last name) via CVS in 1999/08/29 with a message posted to the Mozilla internationalization and SeaMonkey newsgroups.

**P.S.** The second entry wrote management tools in 2011/03 after he added many previous localizers via SVN and committed directly via GIT using two commands (commit and push). The last entry forked the above repository, uses pull requests and closes pull requests for additions not done via the form (e.g. bulk additions) or modifications not done via replies to the application message with a comment using the above mentioned paragraph in the second entry of this index.

## Protest pages (available in five versions)
Thanks goes to [Norman L. De Forest](http://www.chebucto.ns.ca/~af380), Canada (1942-2006) for his protest pages.

* **Web page not available** (Old Android browser) – The link refers to a page at the **@Macarlo, Inc** website (currently down since 2013/07/01).
* **Cannot find server** (Internet Explorer 6 – Windows XP RTM, SP1 and SP2) – Windows XP SP3 added network diagnostics stuff (not included in this page).
* **Internet Explorer cannot display the webpage** (Internet Explorer 7-10 – Windows XP SP2 & above) – In this page is a button labeled **Diagnose Connection Problems** (pressing in the browser itself when the original page is accessed as `res://shdocvw.dll/dnserror.htm` opens the network diagnostic tool).
* **This page can't be displayed** (Internet Explorer 11) – In this page is a button labeled **Fix connection problems** (pressing in the browser itself when the original page is accessed as `res://ieframe.dll/dnserror.htm` opens the network diagnostic tool). Remove the style in `notConnectedTasks`, add the style to `cantDisplayTasks` and change the heading/title to **You're not connected to the internet** to make this page resemble computers not connected to the internet.

## Translations of EasyPaint into multiple languages
All translations are in ts format (edited using Qt Linguist or other program). Generated translations can be found in [CMakeLists.txt](https://github.com/Gr1N/EasyPaint/CMakeLists.txt) (line 109).

* Danish (da_DK)
* Dutch (nl_NL)
* Finnish (fi_FI)
* German (de_DE)
* Hungarian (hu_HU)
* Korean (ko_KR)
* Polish (pl_PL)
* Portuguese, as spoken in Brazil (pt_BR)
* Romanian (ro_RO) – Contributed by Nicolae Oprea
* Spanish, as spoken in Spain (es_ES)
* Swedish, as spoken in Sweden (sv_SE)
