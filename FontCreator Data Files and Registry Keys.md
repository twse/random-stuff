FontCreator is a font editor and High-Logic's first product created since its foundation on 1997.

## Notes
* The cursor will remain **Busy** if the user does other stuff when saving fonts in the background.
* All versions can save all unaltered opened fonts from the File menu. Windows 2000 & above shows a critical error saying **List index out of bounds** if done repeatedly.
* Exiting when saving fonts may create invalid font(s) and play the Critical Stop sound from the PC speakers.
* The program shows a critical error saying **access violation** when exiting while during some operations – the font(s) may be invalid.
* Glyphs in the clipboard (version 1.0 until 6.0) will say **Glyph Contours** (contours) or **Glyph Data** (glyphs). Version 7.0 & above stores just the PostScript glyph name(s) as text (glyphs) or **Font Data** (contours).
* **Edit: Delete** is not dimmed on startup or when closing other dialogs in old versions.
* **Complete Composites** (when generated from `CompositeData.xml` but not auto or anchor based) slows down the first time when used in simple and composite glyphs.
* **Complete Composites** is dimmed when editing empty glyphs in version 5.0 until 6.5.
* The program shows a critical error when using **Complete Composites** in some glyphs in the Private Use Area (old versions only). After that, these glyphs cannot be recovered.
* Version 1.0 (1998-04-11) until 7.0 (2013-04-25) only adds glyphs with Unicode BMP mapping to the preview area.
* Version 5.6 (2007-07-19) uses a non-standard resource layout which prevents [UPX](https://upx.github.io/) from packing the executable file (`NotPackedException`).
* In new fonts (version 5.0 until 6.5), the international currency sign (¤) is mapped to the Macintosh Roman platform but not the euro (€) which maps to the same codepoint (219).
* Version 1.0 (1998-04-11) until 6.5 (2011-11-18) used ISO Latin-1 as the output encoding for the program and exported kerning pairs while version 7.0 (2013-04-25) & above uses Unicode.
* The PostScript names modified when opening fonts in Font Creator Program 3.0 and 4.0 are as follows: the full stop at **.notdef** is removed, **nonmarkingreturn** changes to **CR** and **exclamdown** changes to **exclamationdown**.
* High-Logic mirrored the installer in its own domain derived from the program name up to version 6.1.

## Unregistered version limitations
If the program detects it is an unregistered copy or if registration is not performed during or within the grace period or fails because of an illegal or invalid registration key, the following restrictions will be imposed on the version number:
* All versions – `TSPLASHFORM` is shown on startup. `TMAINFORMFONTCREATOR` will display a word in the title bar (version 5.0 & above) and the registration information in `TABOUTDIALOG` or `TABSTRACTABOUTDIALOG` states that the program is unregistered. After a grace period of 30 days, the message shown in `TSPLASHFORM` is replaced with messages stating that the grace period is exceeded and encourages the user to uninstall or buy the program. In version 6.0 & above there is a menu to register or buy the program in `TMAINFORMFONTCREATOR`.
* 3.0β1 (2000-07-30) until 3.1.3 (2002-12-09) – After a grace period of 30 days, `TSHAREWAREFORM` is shown when pressing **Start** in `TSPLASHFORM`. However, the program otherwise functions normally.
* 4.0 (2003-05-16) until 5.0 (2005-01-12) – After a grace period of 30 days, the program cannot be used at all unless it is registered.
* 5.5 (2006-05-30) and 5.6 (2007-07-19) – After a grace period of 30 days and opening the program 5 times, the program will enter a reduced functionality mode, where fonts cannot be saved, tested or installed and TrueType collections cannot be extracted.
* 6.0 (2009-06-17) until 6.5 (2011-11-18) and 8.0 (2014-06-05) until 12.0.0.2539 (2019-06-04) – The program will enter a reduced functionality mode. The reduced functionality varies based on whether the program is in the grace period or not. In this case, fonts cannot be tested (version 6.0), installed or exported, OpenType collections cannot be extracted and tested fonts won't be automatically hinted.
* 7.0 (2013-04-25) until 11.5.0.2430 (2018-12-05) – The program will create subsetted versions when testing, installing or exporting fonts. After a grace period of 30 days, the program will enter a reduced functionality mode, where font projects cannot be saved, fonts cannot be tested, installed or exported and OpenType collections cannot be extracted. This corresponds to the `CheckLicenseNotGood` function used by `OnShowDisabledMessage`.
* 12.0.0.2543 (2019-07-10) until 13.0.0.2643 (2020-05-19) – The program will replace `.notdef` and many glyphs with the company's logo in generated fonts. After a grace period of 30 days, the program will enter a reduced functionality mode, where font projects cannot be saved, fonts cannot be tested, installed or exported and OpenType collections cannot be extracted. This corresponds to the `CheckLicenseNotGood` function used by `OnShowDisabledMessage`.

## Windows version compatibility
| Operating system              | Latest version |
|-------------------------------|----------------|
| Windows Vista and later       | 13.0.0.2656    |
| Windows XP                    | 10.0           |
| Windows 2000                  | 7.0            |
| Windows 95, 98, ME and NT 4.0 | 6.0.1          |

## User data
“FontCreator uses several data files for advanced settings and customizations. Normally most files are stored in a system folder where they cannot be changed.” In order to edit most files directly it must have administrator permissions.
* **bookmarks.txt** (version 4.5 until 6.5) – Includes bookmarks used in `TFONTOVERVIEWFORM`. Created automatically after exiting the program.
* **CompositeData.xml** (version 5.0 & above) – Located in the `Composite` folder as used by **Complete Composites**. The feature will do nothing if there are syntax errors or this file is removed. [Bhikkhu Pesala](http://www.softerviews.org/Fonts.html) had assigned code points in the Private Use Area for different glyphs in this file and his fonts (he removed them), notably for use with OpenType features like small capitals or old style numbers. Updated versions are available in the company's forum.
* **CurrentTransformProgram.xml** (version 4.5 & above) – Transform Program used by `TTRANSFORMFORM`. The window will appear empty if removed.
* **default.otlfd** (version 7.0 until 11.5) – Default OpenType feature definitions used when adding common OpenType features. Replaced with `TFEATURESETTINGSFORM` in version 12 & above.
* **Denissen.ttf** (version 4.5 until 5.5 – located in the fonts folder) – This handwriting font covers only Basic Latin characters (the font is named after the company's president family name, dates from about 2000 and was dropped after 5.6).
* **FC#####.otf/ttf** – Temporary font used by `TFONTTESTFORM` (the last five characters in the filename are numeric). Version 3.0 until 6.5 names the font as **FC Test Font ######** and recent versions names the font as up to 25 characters preceded by 5 numbers.
* **FC#####.woff** – Temporary font used when testing web fonts.
* **fc12.cfg** (version 12.0) – Configuration file located in the user's directory.
* **FCOutDrw.dll** – Dynamic link library located in the system root directory used for advanced outlines (version 10 & above).
* **fcp5.cfg** (version 5.0 until 5.6) – Configuration file located in the system root directory.
* **fcppreview.txt** (version 3.0 until 4.5) – Text used in `TFONTTESTFORM`. The text is restored to factory defaults if removed.
* **FCPSHL.dll** (version 3.0 until 6.5) – Adds the **Open with FontCreator** menu item to all fonts. In version 7.0 & above it adds the program itself to the **Open with** context menu.
* **fntXX.tmp** or **fntXXX.tmp** – Temporary font used when saving (the last two or three characters in the filename is a letter and/or number combo).
* **FontCreatorSetup.exe** – Install the Win32 version.
* **FontCreatorSetup-x64.exe** (version 11.0 & above) – Install the Win64 version.
* **FontCreator.tip** (version 2.0 until 6.5) – Contains the tips and tricks used by `TTIPOFTHEDAYFORM`. The window will appear empty if removed.
* **FontCreator YYYYMMDD HHMMSS ###.dat/prd** (version 12.0) – Contains crash info (located in `ProgramData\High-Logic\Errors` – YYYYMMDD HHMMSS ### is the timestamp and random numbers). Prior to FontCreator 12.0.0.2561 it includes the Call Stack Information.
* **FontInstaller.dll** (version 2.0 until 6.5) and **FontInstaller2.dll** (version 7.0 & above) – Dynamic link libraries used by `TFONTINSTALLFORM` to install fonts.
* **glyphlist.dat** – Contains the Adobe glyph list. Old versions have the same list located in `TMAINFORMFONTCREATOR` but **xi** is duplicated as U+0000.
* **glyphnames.dat** (version 7.0 until 11.5) and **glyphnamesnew.dat** (version 12.0 & above) – Contains the default glyph names when opening fonts and when generating glyph names on `TGLYPHPROPERTIESFORM`.
* **guidelines.dat** – Contains the guidelines used by `TGLYPHEDITFORM` and `TGUIDELINESFORM`. Created automatically after exiting the program.
* **kern_font.txt** – For old versions of FontCreator, stores the old `KERN` table data in each font whereas `font` is the font name. Opening fonts with the old `KERN` table in recent versions will create the GPOS table named `KerningFromKernTable` from the OpenType kerning feature.
* **previewtext.dat** (version 5.0 & above) – Contains text used in `TFONTTESTFORM`. The text is restored to factory defaults if removed.
* **preview.txt** (version 4.5 & above) – Contains text strings used by the Preview toolbar in `TMAINFORMFONTCREATOR`. The dropdown list will appear empty if removed.
* **SubFamily.dat** or **SubFamily2.dat** – Contains naming fields in multiple languages.
* **TableOffsetOrderCFF.txt** – Contains supported tables in fonts with CFF Postscript outlines or Cubic Bézier curves.
* **TableOffsetOrder.dat** (old versions) or **TableOffsetOrder.txt** – Contains supported tables in fonts with quadratic curves. All tables are moved to **Unsupported Tables** (`TFONTPROPERTIESFORM` in version 7.0 & above) or **Unsupported** (`TFONTTABLESFORM` in version 3.0 until 6.5) if the file is removed, resulting in invalid fonts.
* **tags.txt** (version 7.0 & above) – Controls the names of the five tags that can be assigned to each glyph. Defaults are **Important**, **Incomplete**, **Completed**, **Review** and **Workspace**.

In **Options: Advanced: Data Files** are two buttons labeled **Copy Data Files to User Data Folder** and **Open User Data Folder** (version 8.0 & above) when pressed the program will either copy most files in the above list to the user data folder or open it.

## Registry Keys
The registry keys are located in `HKCU\Software\High-Logic\FontCreator\version` or `HKCU\Software\High-Logic\Font Creator Program\version` whereas `version` is the version number.

**Fun fact:** Hold down **Ctrl** in version 7.0 & above during startup to restore the program to factory settings.

### AddCharacters (version 4.0 & above, used in `TADDCHARACTERSFORM`)
* **SelectedCharacter** – Select the character in this dialog. Default is 0 (null).
* **SelectedFont** – Select the font to display characters at the top and bottom left corners. Default is **Arial Unicode MS** (shipped with Microsoft Office up to version 2013).

### Background (version 3.1 & above, used in Background Image on `TMAINFORMFONTCREATOR`)
* **BackgroundInitColor** – Set the background color. Default is white.
* **BackgroundInitScale** – Set the background scale factor.

### Columns (used in `TINSTALLEDFONTSFORM`)
* **Open Installed Fonts** – This numerical value changes the width.

### Edit (version 8.0 & above, used in `TPASTESPECIALFORM`)
* **PasteSpecialAnchors** – This will paste anchors. Default is on.
* **PasteSpecialCodepoints** – This will paste codepoints. Default is on.
* **PasteSpecialCodepointsOption** – Choose whether to paste codepoints. Default is 0 (Keep same code-points).
* **PasteSpecialGlyphNames** – This will paste glyph names. Default is off.
* **PasteSpecialMetrics** – This will paste metrics. Default is on.
* **PasteSpecialMetricsOption** – Choose whether to paste metrics. Default is 0 (Side bearings).
* **PasteSpecialOutlineData** – This will paste outline data. Default is on.

### Exchange (version 13.0, used in the Exchange tab in `TOPTIONSFORM`)
* **OutlineFormat** – Used with **Exchange Glyph Outlines: Preferred outline format**. Default is Don't change it, but use quadratic with new contours.

### Externals (used in Tools: Launch Externals; added in version 4.5)
There are three built-in external programs: **MainType** (version 5.6 & above, it hides if not installed), **Fonts Folder** (not linked to the same folder in Control Panel) and **Character Map** (removable in Windows 95, 98, ME and XP via **Control Panel: Add/Remove Programs: Add/Remove Windows Features: Components: Accessories and Utilities: Accessories: Character Map** or in Windows 2000 as administrator by deleting `charmap.exe` – executable file and `charmap.chm` or `charmap.hlp` – help documentation or in Windows Vista & above by taking ownership and deleting `charmap.exe` – executable file and `charmap.exe.mui` – translated strings for use with language packs).
* **Location#** – The last character has three values. Default is empty.
* **Title#** – The last character has three values. Default is **External #** whereas # is a number.

### Find (version 3.0 until 6.5, used in `TFINDFORM`)
* **FindLanguageID** – Select language identifier.
* **PlatformID** – Select **Platform** identifier in the Mapping tab.
* **PlatformSpecificEncodingID** – Select **Platform** specific encoding identifier in the Mapping tab.
* **TabIndex** – Changes tab in this form. Default is 0.

### FontOverview (used in `TFONTOVERVIEWFORM`)
* **CategoryWidth** – Select the category splitter width.

### Fonts (used in the Font tab in `TOPTIONSFORM`)
* **ExportDecomposeScaled** (version 12.0.0.2521 & above) – Used with **Export Font: Decompose composite glyphs with scaled components**. Default is on.
* **ExportExcludeLegacy** and **ExportExcludeLegacy2** – Used with **Export Font: Exclude legacy data**. Default is on.
* **FontEnableOpenContours** (version 11.5.0.2421 & above) – Used with **Special Features: Enable open contours**. Default is on.
* **OpenFriendlyGlyphNames** – Used with **Open Font: Generate friendly glyph names**. Default is on.

### FreeDraw (version 6.5 & above)
* **BrushWidth** – Changes the **Brush width**. Default is 64.

### Glyph Edit Window
* **FilledOutline** – Used with **Fill Outline** in the Grid toolbar. Default is on. See `GlyphFillAlpha` in **Interface Settings** below in newer versions.
* **ShowConnectionsBetweenPoints** – Show connection lines between points (**Show Connection** in the Grid toolbar). Default is on.
* **ShowFirstAndLastPointIndicators** – Show first and last point indicators (**Show First and Last** in the Grid toolbar). Default is on.
* **ShowToolbarWindowBackground** – Show or hide the Background Image toolbar. Default is off.
* **ShowToolbarWindowKerning** – Show or hide the preview window. Default is off.
* **ShowToolbarWindowMembers** (version 7.5 & above) – Show or hide members when creating or editing colored glyphs. Default is off.
* **ShowToolbarWindowPalette** (version 7.5 & above) – Show or hide the palette when creating or editing colored glyphs. Default is off.
* **ShowToolbarWindowTransformation** – Show or hide the transformation toolbar. Default is on.
* **ShowToolbarWindowValidation** (version 5.5 & above) – Show or hide the validation report (**Show Report** in the Glyph toolbar). Default is off.

### Grid
* **FixedGridColor** – Set the fixed grid color in `TGRIDFORM`. Default is white.
* **FixedGridLineStyle** – Set the fixed grid line style in `TGRIDFORM`. Default is solid.
* **GridColor** – Set the grid color in `TGRIDFORM`. Default is sky blue.
* **GridDistance** – Used with **Minimum distance between grid points in units** in `TGRIDFORM`.
* **GridDistancePixels** – Used with **Mininum distance between grid points in pixels** in `TGRIDFORM`.
* **GridLineStyle** – Set the line style in `TGRIDFORM`. Default is solid.
* **IncludeBaseline** (version 3.0 until 6.0) – Used with **Baseline** in `TMETRICSFORM`. Default is on (in version 7.0 & above, it is always enabled for any opened font).
* **IncludeLeftSideBearing** (version 3.0 until 6.0) – Used with **Left side bearing** in `TMETRICSFORM`. Default is on (in version 7.0 & above, it is always enabled for any opened font).
* **IncludeRightSideBearing** (version 3.0 until 6.0) – Used with **Right side bearing** in `TMETRICSFORM`. Default is on (in version 7.0 & above, it is always enabled for any opened font).
* **IncludeTypoAscender** (version 3.0 until 6.0) – Used with **TypoAscender** in `TMETRICSFORM`. Default is off (in version 7.0 & above, it is always disabled for any opened font).
* **IncludeTypoDescender** (version 3.0 until 6.0) – Used with **TypoDescender** in `TMETRICSFORM`. Default is off (in version 7.0 & above, it is always disabled for any opened font).
* **IncludeWinAscent** (version 3.0 until 6.0) – Used with **Win Ascent** in `TMETRICSFORM`. Default is on (in version 7.0 & above, it is always enabled for any opened font).
* **IncludeWinDescent** (version 3.0 until 6.0) – Used with **Win Descent** in `TMETRICSFORM`. Default is on (in version 7.0 & above, it is always enabled for any opened font).
* **IncludexHeight** (version 3.0 until 6.0) – Used with **x-Height** in `TMETRICSFORM`. Default is on (in version 7.0 & above, it is always enabled for any opened font).
* **IncludeYAxis** (version 3.0 until 6.0) – Used with **Y-Axis** in `TMETRICSFORM`. Default is on (in version 7.0 & above, it is always enabled for any opened font).
* **LockUserDefinedGuidelines** (version 4.5 & above) – Used with **Lock Guidelines** in the Grid toolbar. Default is off.
* **ShowBearings** (version 5.6 & above) – Used with **Show Metrics** in the Grid toolbar. Default is on.
* **ShowFixedGridLines** (version 5.6 & above) – Used with **Show reference lines at x = 0, y = 0** in `TGRIDFORM`.
* **ShowGrid** – Used with **Show Grid** in `TGRIDFORM` or the Grid toolbar. Default is on.
* **ShowUserDefinedGuidelines** – Used with **Show Guidelines** in `TGUIDELINESFORM` or the Grid toolbar. Default is on.
* **SnapToGrid** (version 1.1.3 & above) – Used with **Snap to Grid** in the Grid toolbar. Default is off.
* **SnapToUserDefinedGuidelines** (version 4.0 & above) – Used with **Snap to Guidelines** in the Grid toolbar. Default is off.

### GUI
* **UpdateCheckInterval** – Set this value in **Startup: Check for updates** in the General tab in `TOPTIONSFORM` to 000 (never), 001 (every day), 007 (once a week), 030 (once a month), 182 (twice a year) or 365 (once a year). Default is 007 (once a week).

### GuideLines (version 3.0 until 6.5, used in `TGUIDELINESFORM`)
* **Color** – Set the color. Default is black.
* **LineStyle** – Set the line style. Default is solid.

### ImportImage (used in `TCONVERTBITMAPTOCONTOURSFORM`)
* **BitmapPositionOrigin** – Used with radio buttons of all corners in **Glyph: Position**. Default is centered.
* **BitmapPositionType** – Set the **Bitmap Position Type**.
* **Erode** – Used with **Erode – Dilate** in the Image tab. Default is No filter.
* **GlyphPositionX** – Used with **Position: X position** in the Glyph tab.
* **GlyphPositionY** – Used with **Position: Y position** in the Glyph tab.
* **ImportMode** – Used with **Import Mode** in the Glyph tab. Default is Trace.
* **InvertBitmap** – Used with **Negative** in the Image tab. Default is off.
* **MinimumPointsInContour** – Set the number of **Minimum Points** in the contour.
* **Multiplier** – Used with **Size: Multiplier** in the Image tab.
* **SmoothFilter** – Used with **Smooth Filter** in the Image tab. Default is Smooth.
* **Threshold** – Used with **Threshold** in the Image tab. Default is 150.

### Install (version 3.0 until 6.5, used in `TFONTINSTALLWIZARDFORM`)
* **InstallFontsInFontsFolder** – **Install the font in Windows Fonts folder**. Default is on. If the program is detected to be running on Windows Vista & above, the UAC shield is added to the bottom.

### InstalledFonts (used in `TINSTALLEDFONTSFORM`)
* **PreviewHeight** – Set the height in the font preview area (version 5.5 & above) at the bottom. Default is 124.

### Interface (used in the toolbar context menu or View: Toolbars in `TMAINFORMFONTCREATOR`)
* **LockToolbars** (version 11.0 & above) – Used with **Lock Docked Toolbars**. Default is off.
* **ShowUserNotes** – Used with **Show User Notes**. Default is off.

### Interface Settings
* **ChildWindowState** – Contains the child window state.
* **CompleteCompositesAction** – Set to 1 (auto), 2 (anchor based), 3 (anchor based reposition) or 4 (composite data) to **Complete Composites**. Default is 1 (auto).
* **CustomNamingShowOutputContent** – Used by **Custom: Additional Naming Fields: Show Output Content** in `TFONTPROPERTIESFORM`. Default is on.
* **ExportSettingsPage** – Select page in `TEXPORTSETTINGSFORM` and `TEXPORTSETTINGSFRAME`. Default is 0 (Desktop Font (ttf/otf)).
* **GlyphCaptionAuto** – Used with **Glyph Caption: Automatic** (Glyph Index) in the context menu in `TFONTOVERVIEWFORM`.
* **GlyphCaptionType** (old versions) or **GlyphCaptionType2** (recent versions) – Used with the Captions options in the context menu in `TFONTOVERVIEWFORM`. Default is Auto.
* **GlyphDrawMode** – Set to 2 (auto), 0 (monochrome) or 1 (color). Default is 2 (auto).
* **GlyphFillAlpha** (version 11.0.0.2365 & above) – Used with **View: Fill Outline**. Default is solid.
* **GlyphNamesHistoryReplace** (version 11.0.0.2365 & above) – Contains the replaced PostScript name history in `TGLYPHNAMEFORM`. Default is blank.
* **GlyphNamesHistorySearch** (version 11.0.0.2365 & above) – Contains the found PostScript name history in `TGLYPHNAMEFORM`. Default is blank.
* **GlyphNamesOptionsCS** – Used with **Options: Case sensitive** in `TGLYPHNAMEFORM`. Default is on.
* **GlyphNamesOptionsRE** – Used with **Options: Regular expressions** in `TGLYPHNAMEFORM`. Default is off.
* **GlyphOutlineFillMode** – Used with **Glyph outline fill mode** in Options: General. Default is 0 (Winding).
* **GlyphPropsExpanded** – Expand glyph properties via the **More** button at the bottom left corner. Default is on.
* **GroupManagerSorted** – Sorts the group manager.
* **InsertGlyphsCB1** and **InsertGlyphsCB2** (version 12.0 & above) – Used by `TINSERTGLYPHFORM` to insert glyphs at the top (0), after the last glyph (1), before (2) or after selected glyphs (3). Default is 3 (after selected glyphs).
* **InsertGlyphsPage** (version 12.0 & above) – Select the tab in `TINSERTGLYPHFORM`.
* **InsertGlyphsRanges** – Used by `TINSERTGLYPHFORM` to insert glyph ranges.
* **KerningFolderExport** – Select the directory to export the old `KERN` table.
* **KerningFolderImport** – Select the directory to import the old `KERN` table.
* **NewFontIncludeOutlines** (version 5.6 & above) – Used with **Predefined outlines: Include outlines** in `TNEWTRUETYPEFONTFORM` (the outlines are from Garava). Default is on.
* **OpenDialogInitialDir2** – Contains the directory in the Open dialog from `TMAINFORMFONTCREATOR`. Default is user's font folder.
* **OpenDialogInitialDirAutoKerning** (version 2.0 until 6.5) – Contains the directory in the Open dialog from `TAUTOKERNEXFORM`.
* **OpenDialogInitialDirImportImage2** – Contains the directory in the Open dialog from `TCONVERTBITMAPTOCONTOURSFORM`.
* **OpenDialogInitialDirNamingField2** – Contains the directory in the Open dialog from `TADDCUSTOMNAMINGFORM`. Default is desktop.
* **OpenDialogInitialDirTransform3** – Contains the directory in the Open dialog from `TPERFORMTRANSFORMATIONFORM`. Default is program's transform folder.
* **OptionsPage** – Select the tab in `TOPTIONSFORM`. Default is 0 (General).
* **OTLFDesignerCollapsedFeatures** – Contains features collapsed in `TOPENTYPEDESIGNERFORM`.
* **OTLFDesignerCollapsedLookups** – Contains lookups collapsed in `TOPENTYPEDESIGNERFORM`.
* **OTLFDesignerCollapsedScripts** – Contains scripts collapsed in `TOPENTYPEDESIGNERFORM`.
* **OTLFDesignerPairFilterFirst** – Contains the preceding character to filter kerning pairs.
* **OTLFDesignerPairFilterSecond** – Contains the succeeding character to filter kerning pairs.
* **OTLFDesignerPairKindFirst** – Filters the first kerning pair kind.
* **OTLFDesignerPairKindSecond** – Filters the last kerning pair kind.
* **OTLFDesignerPreviewLanguage** – Select language for `TOPENTYPEDESIGNERFORM` preview text. Default is **Auto**.
* **OTLFDesignerPreviewSampleText** – Contains preview sample text for `TOPENTYPEDESIGNERFORM`. Default is **The five boxing wizards jump quickly**.
* **OTLFDesignerPreviewScript** – Select script for `TOPENTYPEDESIGNERFORM` preview text. Default is **Auto**.
* **OTLFDesignerSingleFilter** – Used for single filter in `TOPENTYPEDESIGNERFORM`.
* **OTLFDesignerSingleKind** – Used for single kind in `TOPENTYPEDESIGNERFORM`.
* **OTLFEditor** – Contains settings used by `TCODEEDITORFORM` such as font setting, displaying line numbers or word wrapping.
* **OverviewColCat** – Contains the column categories used in `TFONTOVERVIEWFORM`.
* **OverviewFontZoom** – Zoom the glyphs in `TFONTOVERVIEWFORM`. Default is 35.
* **OverviewGridZoom** – Zoom the grid in `TFONTOVERVIEWFORM`.
* **OverviewSampleFont** (version 4.0 & above) – Used with **Font Overview: Font used in cells** in the View tab in `TOPTIONSFORM`. Default is **Arial**. Empty strings will show the characters in **MS Sans Serif**.
* **OverviewShowCaption** (version 3.0 until 6.5) – Used with **Font overview: Show caption** in the Overview tab in `TOPTIONSFORM`. Default is on.
* **OverviewShowSample** – Used with **Font Overview: Show sample in empty glyphs** in the Overview tab in `TOPTIONSFORM`. Default is on.
* **OverviewSingleHeight** (version 3.0 until 6.5) – Used with **Font overview: Glyph height** in the Overview tab in `TOPTIONSFORM`. Default is 48.
* **OverviewSingleWidth** (version 3.0 until 6.5) – Used with **Font overview: Glyph width** in the Overview tab in `TOPTIONSFORM`. Default is 70.
* **OverviewSmoothGlyphs** – Used with **Font overview: Smooth glyphs** in the Overview tab in `TOPTIONSFORM`. Default is off.
* **OverviewUndoLimitMaxCount** – Used with **Undo limits: Max. count** in the Edit tab in `TOPTIONSFORM`. Default is 1.
* **OverviewUndoLimitMaxSize** – Used with **Undo limits: Max. size [KB]** in the Edit tab in `TOPTIONSFORM`. Default is 1.
* **OverviewUseColor** (version 3.0 until 6.5) – Used with **Font overview: Use type color in glyph caption** in the Font tab in `TOPTIONSFORM`. Default is on.
* **SampleFileName** – Used with **Samples Toolbar Font: Filename** in Options: General. Default is empty (many glyphs are derived from regular styles of Garava and Times New Roman).
* **SampleSingleHeight** (version 3.0 until 6.5) – Used with **Samples Toolbar: Glyph height** in the Sample tab in `TOPTIONSFORM`. Default is 55.
* **SampleSingleWidth** (version 3.0 until 6.5) – Used with **Samples Toolbar: Glyph width** in the Sample tab in `TOPTIONSFORM`. Default is 62.
* **SaveDialogInitialDirNew2** – Select the directory in the save dialog.
* **SelectCompositeCaptionType** – Changes caption used in `TSELECTCOMPOSITEGLYPHMEMBERFORM`. Default is 0 (glyph name).
* **SelectCompositeFontZoom** – Zoom the glyphs in `TSELECTCOMPOSITEGLYPHMEMBERFORM`.
* **SelectCompositeGridZoom** – Zoom the grid in `TSELECTCOMPOSITEGLYPHMEMBERFORM`.
* **SettingsPage** – Changes tab in `TOPTIONSFORM`. Default is 0 (Identification).

### Kerning
* **AutoKerningAllowForPositiveKerningValues** – Used with **Additional Options: Allow for positive kerning values** in `TAUTOKERNFORM`.
* **AutoKerningExcludeLowerLower** (version 11.0 & above) – Used with **Exclude lowercase-lowercase pairs** in `TAUTOKERNFORM`.
* **AutoKerningExcludeLowerUpper** – Used with **Exclude lowercase-uppercase pairs** in `TAUTOKERNFORM`.
* **AutoKerningImportFilename** – Contains the file to import kerning pairs.
* **AutoKerningMinAbsKernValue** – This corresponds to numerical strings for the **Additional Options: Minimum absolute kerning value** in `TAUTOKERNFORM`.
* **AutoKerningReplaceKerning** – Used with **Additional Options: Replace existing kerning when** dropdown box in `TAUTOKERNFORM`.
* **AutoKerningReplacePercentage** – Used with **Additional Options: Replace existing kerning when** slider in `TAUTOKERNFORM`.
* **AutoKerningUseBaseMetrics** – Used with **Composite glyphs follow base glyphs (use this glyph's metrics)** in the `TAUTOKERNFORM`. Default is on.
* **AutoKerningWhiteSpace** – Used with **Additional Options: White space between characters** in `TAUTOKERNFORM`.
* **KerningColorBackground** – Set the background color. Default is white.
* **KerningColorBaseline** – Set the baseline color. Default is red.
* **KerningColorFirst** – Set the preceding glyph color. Default is dark blue.
* **KerningColorGridLines** – Set the grid lines color. Default is gray.
* **KerningColorSecond** – Set the succeeding glyph color. Default is dark green.
* **KerningShowBaseLine** – Displays baseline. Default is on.
* **KerningShowBearingLines** – Displays bearing lines. Default is on.
* **KerningShowGridLines** – Displays grid lines. Default is on.

### Last Time, Most Recently Used Files, Most Recently Used Projects
* **File_#** – Include fonts and/or projects opened from last time or recently used in the **File: Reopen** menu whereas # is a number. Old versions stores up to 7 files while recent versions stores up to 26 fonts and 10 projects. The menu will appear empty (recent versions) or dimmed (old versions) if the above keys are removed or if **Clear file list** is selected from the menu. When `OnStartupOpenFonts` is enabled, nothing is opened if removed. When opening a non-existing file before version 7.0 the file is removed (after version 7.0 it is kept).

### Metrics (used in `TAUTOMETRICSFORM`)
* **AutoMetricsExcludeEmptyGlyphs** – Used with **Additional Options: Exclude empty glyphs (recommended)**.
* **AutoMetricsFixedAW** – Used with **Fixed Width: Advance Width** spinner. Default is 2048.
* **AutoMetricsFixedChangeAW** – Used with **Fixed: Change Advance Width** option.
* **AutoMetricsFixedChangeLSB** – Used with **Fixed: Change Left Side Bearing** option.
* **AutoMetricsFixedLSB** – Used with **Fixed: Left Side Bearing** spinner.
* **AutoMetricsOpticalFactor** (version 7.0 & above) – Used with **Glyph spacing factor (usually between 20 and 30)** in Optical Metrics. Default is 27.
* **AutoMetricsOpticalFigures** (version 7.0 & above) – Select the option in **Set character width for digits as** to 0 (Tabular figures), 1 (Proportional figures) or 2 (No change). Default is 0 (Tabular figures).
* **AutoMetricsOpticalPreview** (version 7.0 & above) – Used with **Preview Text** in Optical Metrics. The string can be up to 21 characters. Default is **Preview Text**.
* **AutoMetricsOptionIndex2** – Set to 0 (Optical Metrics), 1 (Fixed Bearings), 2 (Fixed Width) or 3 (Fixed Height). Default is 0 (Optical Metrics).
* **AutoMetricsWhiteSpaceAfter** – Used with **Fixed Bearings: Space after**. Default is 100.
* **AutoMetricsWhiteSpaceBefore** – Used with **Fixed Bearings: Space before**. Default is 100.

### MetricsAndKerning (used in the Comparison toolbar in `TMAINFORMFONTCREATOR`)
* **MetricsAndKerningKerningEnabled** – Enable or disable the legacy `KERN` table (version 3.0 until 6.5) or OpenType features (version 7.0 & above). Default is off.
* **MetricsAndKerningTextEnabled** – Used with **Show text before and after glyph** (version 5.0 & above). Default is off.
* **MetricsAndKerningTextLeft** – Contains the preceding character in the **Before** text box (version 5.0 & above). Default is empty.
* **MetricsAndKerningTextRight** – Contains the succeeding character in the **After** text box (version 5.0 & above). Default is empty.

### OpenType Designer (version 7.0 & above, used in `TOPENTYPEDESIGNERFORM`)
* **FillGlyphOutlines** – Used with **Colors: Fill glyph outlines** in `TFORMOPENTYPEDESIGNERSETTINGS`. Default is on.
* **GlyphFillColor** – Used with **Colors: Glyph fill color** in `TFORMOPENTYPEDESIGNERSETTINGS`. Default is off.
* **LayoutMode** – Select the layout mode. Default is 0.
* **MarkWidth** – Set the mark width. Default is 240.
* **PairWidth** – Set the pair width. Default is 145.
* **PreviewHeight** – Set the preview text height. Default is 120.
* **PreviewSampleFontSize** – Scale the preview sample. Default is 32.
* **SimpleWidth** – Set the simple width. Default is 145.
* **SingleWidth** – Set the single width. Default is 145.
* **TreeWidth** – Set the tree width. Default is 320.
* **ZoomFactor** – Zooms the OpenType Designer. Default is 12.

### OpenType Generator (version 12.0.0.2521 & above, used in `TFEATURESETTINGSFORM`)
All keys beginning with Include are enabled by default. Other features (e.g. half forms or distances for Indic scripts) have no inclusion options; use the add button at the top left corner of `TOPENTYPEDESIGNERFORM` or via `TCODEEDITORFORM` to manually create the tables.
* **CPSPKind** – Used with the **Spacing and Positioning: Capital Spacing (cpsp)** dropdown box. Default is 0 (Percentage of advance width).
* **CPSPPerc** – Contains the percentage in the **Spacing and Positioning: Capital Spacing (cpsp)** spinner. Default is 5.00%.
* **IncludeAalt** – Used with **Other Forms and Variants: Access All Alternates (aalt)**.
* **IncludeAltFractions** – Used with **Numerals: Alternative Fractions (e.g. stacked) (afrc)**. This feature generates lookups for all pre-composed fractions in the *Latin-1 Supplement* and *Number Forms* blocks of Unicode as well as fractions not encoded in Unicode.
* **IncludeAnchorBased** – Used with **Spacing and Positioning: Anchor Based Positioning (ccmp, mark, mkmk)**. In order to include this feature, each letter should have anchors.
* **IncludeCapitalSpacing** – Used with **Spacing and Positioning: Capital Spacing (cpsp)**. This feature excludes fullwidth Latin characters. Only useful for proportional fonts, so including it in monospaced or pixelated fonts causes metrics issues.
* **IncludeCase** – Used with **Other Forms and Variants: Case-Sensitive Forms (case)**.
* **IncludeCharacterVariants** – Used with **Other Forms and Variants: Character Variants (cv01-cv99)**. [Bhikkhu Pesala](http://www.softerviews.org/Fonts.html) uses this feature in his fonts for ! * + @ © × † ‡ • ○ ● ☀.
* **IncludeCursive** – Used with **Spacing and Positioning: Cursive Positioning (curs)**. Only useful for connecting script fonts.
* **IncludeDlig** – Used with **Other Forms and Variants: Discretionary Ligatures (dlig)**.
* **IncludeFina** – Used with **Terminal Forms (fina, fin2, fin3)**. This feature uses terminal characters from the *Arabic* ranges of Unicode. The last two features are used only for Syriac.
* **IncludeFractions** – Used with **Numerals: Fractions (diagonal) (frac, dnom, numr)**. The `frac` feature uses precomposed vulgar fractions from the *Latin-1 Supplement* and *Number Forms* ranges of Unicode.
* **IncludeFractionsAdv** – Used with **Numerals: Fractions (diagonal) (frac, dnom, numr): Extended (smart math format)**.
* **IncludeHlig** – Used with **Other Forms and Variants: Historical Ligatures and Historical Forms (hlig, hist)**. The `hist` feature uses the last character from the *Latin Extended-A* range of Unicode. The `hlig` feature uses ſt from the *Alphabetic Presentation Forms* range of Unicode and ligatures that are made up of glyphs beginning with ſ.
* **IncludeInit** – Used with **Initial Forms (init)**. This feature uses initial characters from the *Arabic* ranges of Unicode.
* **IncludeIsol** – Used with **Isolated Forms (isol)**. This feature uses  isolated characters from the *Arabic* ranges of Unicode.
* **IncludeLiga** – Used with **Other Forms and Variants: Standard Ligatures (liga)**. This feature uses the first five Latin characters from the *Alphabetic Presentation Forms* range of Unicode. Including it in monospaced fonts causes bugs (e.g. Helvetica Monospaced).
* **IncludeLnum** – Used with **Numerals: Lining Figures (lnum)**.
* **IncludeLoclCommon** – Used with **Localized Forms (locl): Common Localized Forms (CAT, NLD, TRK, ROM)**. This feature is used for Catalan (CAT) to replace l· with the character from *Latin Extended-A*, Dutch (NLD) or Flemish (FLE) to replace ij and íj́ with its own ligatures, Turkish (TRK) to replace i for case sensitivity and Romanian or Moldavian (ROM or MOL) to replace ş and ţ (cedilla) with ș and ț (comma).
* **IncludeLoclCustom** – Used with **Localized Forms (locl): Custom Localized Forms (loclLANG)**. This feature supports only languages with Arabic, Greek, Hebrew or Latin scripts. This feature is useful for some languages, e.g. Hungarian (HUN) or Polish (POL) to reverse slant or rotate the acute in áéíóú (őű) or ćńóśź or French (FRA) to change thin space metrics.
* **IncludeMedi** – Used with **Medial Forms (medi, med2)**. This feature uses medial characters from the *Arabic* ranges of Unicode. The second feature is used only for Syriac.
* **IncludeNalt** – Used with **Other Forms and Variants: Alternate Annotation Forms (nalt)**. This feature uses circled letters and numbers from the *Enclosed Alphanumerics* block and initial, isolated, medial or terminal characters from the *Arabic* ranges of Unicode.
* **IncludeOnum** – Used with **Numerals: Oldstyle Figures (onum)**. In order to generate this feature, you have to add glyphs with `.onum` at the end of PostScript names.
* **IncludeOrdinals** – Used with **Other Forms and Variants: Ordinals (ordn)**. This feature creates a substitution for numero (capital N and small o with or without full stop) if the glyph exists in the *Letterlike Symbols* block of Unicode and substitutions for letters and numbers.
* **IncludeOrdinalsExt** – Used with **Other Forms and Variants: Ordinals (ordn): Extended (use .ordn or .sups for all letters)**. If no glyphs ending with `.ordn` or `.sups` are found it creates substitutions for a to ª and o to º.
* **IncludeOrnaments** – Used with **Other Forms and Variants: Ornaments (ornm)**. The first method uses the bullet. [Bhikkhu Pesala](http://www.softerviews.org/Fonts.html) uses this feature in his fonts to replace two letters with chess pieces.
* **IncludePetiteCapitals** – Used with **Other Forms and Variants: Petite Capitals (pcap, c2pc)**. [Bhikkhu Pesala](http://www.softerviews.org/Fonts.html) uses a subset for this feature in his fonts, including only common punctuation and the Latin, Greek and Cyrillic alphabets with diacritics for Classical Sanskrit.
* **IncludePnum** – Used with **Numerals: Proportional Figures (pnum)**. In order to generate this feature, PostScript names for each glyph should have `.pnum` at the end.
* **IncludeSalt** – Used with **Other Forms and Variants: Stylistic Alternates (uses ss01) (salt)**. [Bhikkhu Pesala](http://www.softerviews.org/Fonts.html) uses this feature in his fonts to replace Classical Sanskrit text using the Velthuis system.
* **IncludeSinf** – Used with **Numerals: Scientific Inferiors (sinf)**.
* **IncludeSmallCapitals** – Used with **Other Forms and Variants: Small Capitals (scap, c2sc)**. [Bhikkhu Pesala](http://www.softerviews.org/Fonts.html) uses a subset for this feature in his fonts, including only the Latin, Greek and Cyrillic alphabets and punctuation with diacritics for Classical Sanskrit. The [TITUS Cyberbit Basic font](http://titus.uni-frankfurt.de/unicode/unitest2.htm) includes only glyphs for the Latin alphabet, numbers and þḃḋḟġḣk̇l̇ṁṅṗṙṡṫḅḍg̣ḷṃṇṛṣṭ (without the OpenType feature).
* **IncludeStylisticSets** – Used with **Other Forms and Variants: Stylistic Sets (ss01-ss20)**. [Bhikkhu Pesala](http://www.softerviews.org/Fonts.html) uses this for decorative drop capitals in Cankama, Odana, Pali, and Talapanna (colored) as a contextual substitution.
* **IncludeSubs** – Used with **Other Forms and Variants: Subscript (subs)**. The [TITUS Cyberbit Basic font](http://titus.uni-frankfurt.de/unicode/unitest2.htm) uses a subset including only numbers, some letters in the Latin alphabet and punctuation and äīùú (without the OpenType feature).
* **IncludeSups** – Used with **Other Forms and Variants: Superscript (sups)**. [Bhikkhu Pesala](http://www.softerviews.org/Fonts.html) uses a subset in his fonts as either (1) the Latin alphabet, numbers, common punctuation and spacing accents, with Latin-1 and Classical Sanskrit diacritics (Garava) or (2) the Latin alphabet, numbers, è and ú (other fonts). The [TITUS Cyberbit Basic font](http://titus.uni-frankfurt.de/unicode/unitest2.htm) uses a subset including only numbers, some letters in the Latin alphabet and punctuation and äi̯ıu̯ü (without the OpenType feature).
* **IncludeSwsh** – Used with **Other Forms and Variants: Swash (swsh)**. [Bhikkhu Pesala](http://www.softerviews.org/Fonts.html) included this feature in the upright styles of his fonts.
* **IncludeTitl** – Used with **Other Forms and Variants: Titling (titl)**.
* **IncludeTnum** – Used with **Numerals: Tabular Figures (tnum)**. In order to generate this feature, you have to add glyphs with `.onum` at the end of PostScript names.
* **IncludeZero** – Used with **Numerals: Slashed Zero (zero)**.

### OpenType Proofing (version 13.0 & above, used in `TOPENTYPEDESIGNERPROOFINGFORM`)
* **Compact** – Used with **Compact**. Default is on.
* **Filter** – Used with **Filter**. Default is on.
* **FontSize** – Changes the font size. Default is 32.
* **PreviewHeight** – Changes height in the preview area. Default is 120.
* **SpecialFill** – Used with **Special Fill**. Default is on.

### Options
* **AlwaysCreateBackupCopy** (version 4.0 until 6.5) – Used with **Create backup copy (bck) on saving a font project** in the Advanced tab in `TOPTIONSFORM`. Default is off.
* **AutoFitGlyphInWindow** – Used with **Glyph Edit Window: Auto fit glyph in Window** in the Glyph tab in `TOPTIONSFORM`. Default is on.
* **AutoNamingUseFontRevision** (version 4.0 until 6.5) – Used with **Automatic Naming Wizard: Version String: use Font revision version from Font Settings → Header page** in the Naming tab in `TOPTIONSFORM`. Default is on.
* **CompressHmtxTable** (version 4.0 until 6.5) – Used with **When Saving Font Files: Compress hmtx table** in the Font tab in `TOPTIONSFORM`. Default is on.
* **CompressNameTable** (version 4.0 until 6.5) – Used with **When Saving Font Files: Optimize name table** in the Font tab in `TOPTIONSFORM`. Default is on.
* **DefaultNamingCopyrightIncluded** – Used with **Default Settings for New Fonts: Copyright Notice** in the Personalize tab in `TOPTIONSFORM`. Default is on.
* **DefaultNamingCopyrightText** – Used with **Default Settings for New Fonts: Copyright Notice** in the Personalize tab in `TOPTIONSFORM`. Default is **Typeface © (your company). &lt;year&gt;. All Rights Reserved.**
* **DefaultNamingFontDesignerIncluded** – Used with **Default Settings for New Fonts: Designer** in the Personalize tab in `TOPTIONSFORM`. Default is off.
* **DefaultNamingFontDesignerLinkIncluded** – Used with **Default Settings for New Fonts: Designer URL** in the Personalize tab in `TOPTIONSFORM`. Default is off.
* **DefaultNamingFontDesignerLinkText** – Used with **Default Settings for New Fonts: Designer URL** in the Personalize tab in `TOPTIONSFORM`. Default is file from a non-existing domain.
* **DefaultNamingFontDesignerText** – Used with **Default Settings for New Fonts: Designer** in the Personalize tab in `TOPTIONSFORM`. Default is empty.
* **DefaultNamingLicenseAgreementIncluded** – Used with **Default Settings for New Fonts: License Agreement** in the Personalize tab in `TOPTIONSFORM`. Default is off.
* **DefaultNamingLicenseAgreementLinkIncluded** – Used with **Default Settings for New Fonts: License URL** in the Personalize tab in `TOPTIONSFORM`. Default is off.
* **DefaultNamingLicenseAgreementLinkText** – Used with **Default Settings for New Fonts: License URL** in the Personalize tab in `TOPTIONSFORM`. Default is file from a non-existing domain.
* **DefaultNamingLicenseAgreementText** – Used with **Default Settings for New Fonts: License Agreement** in the Personalize tab in `TOPTIONSFORM`. Default is empty.
* **DefaultNamingTrademarkIncluded** – Used with **Default Settings for New Fonts: Trademark** in the Personalize tab in `TOPTIONSFORM`. Default is off.
* **DefaultNamingTrademarkText** – Used with **Default Settings for New Fonts: Trademark** in the Personalize tab in `TOPTIONSFORM`. Default is **&lt;font family&gt;® Trademark of (your company)**.
* **DefaultPersFontEmbeddingItemID** (version 8.0 & above) – Used with **Default Settings for New Fonts: Embedding Lic. Rights** in the Personalize tab in `TOPTIONSFORM`. Default is 0 (Installable (no embedding restrictions)).
* **DefaultPersVendorIDText** (version 8.0 & above) – Used with **Default Settings for New Fonts: Vendor ID** in the Personalize tab in `TOPTIONSFORM`. Default is **HL**.
* **DefaultPersVendorText** (version 8.0 & above) – Used with **Default Settings for New Fonts: Vendor** in the Personalize tab in `TOPTIONSFORM`. Default is **High-Logic / Made with FontCreator**.
* **DefaultPersVendorURLText** (version 8.0 & above) – Used with **Default Settings for New Fonts: Vendor URL** in the Personalize tab in `TOPTIONSFORM`. Default is empty.
* **DefaultVendorIDIncluded** (version 8.0 & above) – Used with **Default Settings for New Fonts: Vendor ID** in the Personalize tab in `TOPTIONSFORM`. Default is on.
* **DefaultVendorIncluded** (version 8.0 & above) – Used with **Default Settings for New Fonts: Vendor** in the Personalize tab in `TOPTIONSFORM`. Default is off.
* **DefaultVendorURLIncluded** (version 8.0 & above) – Used with **Default Settings for New Fonts: Vendor URL** in the Personalize tab in `TOPTIONSFORM`. Default is off.
* **DefaultZoomFactor** – Used with **Glyph Edit Window: Open with default zoom factor** in the View tab in `TOPTIONSFORM`.
* **ExcludeMonospacedFonts** – Used with **When Saving Font Files: Exclude monospaced fonts** in the Font tab in `TOPTIONSFORM`. Default is off.
* **IgnoreHintingData** – Used with **When Opening Font Files: Remove hinting data** in the Font tab in `TOPTIONSFORM`. Default is off. Recent versions of this program comes with a hinting program called ttfautohint.
* **IgnoreUnsupportedTables** – Used with **When Opening Font Files: Remove unsupported tables** in the Font tab in `TOPTIONSFORM`. Default is off.
* **LastUpdateReminderDate** (`LastUpdateCheck` in `HKCU\Updates` in recent versions) is the last update reminder date used when **Startup: Show update reminder** in the General tab in `TOPTIONSFORM` is enabled.
* **LeftSideBearingExcludeLargeFonts** (version 4.0 until 6.5) – Used with **When Saving Font Files: Set left side bearing point at x=0: Exclude large (1500+) fonts** in the Font tab in `TOPTIONSFORM`. Default is on.
* **LongAlignedLocalOffsets** – Used with **When Saving Font Files: Long-aligned local offsets** in the Font tab in `TOPTIONSFORM`. Default is on.
* **OnStartupOpenFonts** (version 5.6 & above) – Used with **Startup: On start open fonts from last time** in the General tab in `TOPTIONSFORM` to open fonts from the `Last Time` registry key. Default is on.
* **OnStartupShowUpdateReminder** (`UpdateCheckInterval` in `GUI` in recent versions) – Set this value in **Startup: Show update reminder** in the General tab in `TOPTIONSFORM` to 0 (Never), 1 (Once a year), 2 (Twice a year) or 3 (Once a month). Default is 1 (Once a year).
* **OnStartupShowWelcome** – Used with **Startup: On start show Welcome dialog** in the General tab in `TOPTIONSFORM`. Default is on.
* **PanoseValueHexadecimal** (version 5.6 & above) – Used with **PANOSE: Value: Show hexadecimal** in the Characteristics tab in `TFONTSETTINGSFORM`. Default is off.
* **RecalcAverageCharWidth** – Used with **When Saving Font Files: Recalc average char width** in the Font tab in `TOPTIONSFORM`. Default is on.
* **RecalcGlyphBoundingBoxes** – Used with **When Saving Font Files: Recalc glyph bounding boxes** in the Font tab in `TOPTIONSFORM`. Default is off.
* **RemoveDSIGTable** (version 4.0 until 6.5) – Used with **When Opening Font Files: Remove DSIG table** in the Font tab in `TOPTIONSFORM`. Default is off. **Fun fact:** Recent versions have an option to include this table when exporting fonts. FontForge ignores this table when opening fonts.
* **RemoveHdmxTable** (version 4.0 until 6.5) – Used with **When Opening Font Files: Remove hdmx table** in the Font tab in `TOPTIONSFORM`. Default is on. **Fun fact:** FontForge ignores this table when opening fonts.
* **RemoveLTSHTable** (version 4.0 until 6.5) – Used with **When Opening Font Files: Remove LTSH table** in the Font tab in `TOPTIONSFORM`. Default is on. **Fun fact:** FontForge ignores this table when opening fonts.
* **RemoveVDMXTable** (version 4.0 until 6.5) – Used with **When Opening Font Files: Remove VDMX table** in the Font tab in `TOPTIONSFORM`. Default is on. **Fun fact:** FontForge ignores this table when opening fonts.
* **SetLeftSideBearingPointAtX0** (version 4.5 & above) – Used with **When Saving Font Files: Set left side bearing point at x=0** in the Font tab in `TOPTIONSFORM`. Default is on.
* **UnicodeEnabledGUI** (version 5.5 until 6.5) – Used with **Unicode Support: Enable Unicode support for text display and user input** in the General tab in `TOPTIONSFORM`. Default is on. In Windows 9x/ME or in compatibility mode, the option will appear dimmed.
* **UpdateModifiedDateTimeField** (version 3.0 until 6.5) – Used with **Identification: Automatically update modified timestamp when exporting font** in the Identification tab in `TFONTSETTINGSFORM`. Default is on (since version 7.0 & above it is enabled for any opened font).
* **ValueHexadecimal** – Used with **View: Display Format: Values: Hexadecimal**. Default is on. **Fun fact:** Hexadecimal values in Delphi are usually given with a dollar sign ($).
* **VectorImageEPSForceRepositioning** (version 6.0 & above) – Used with **Vector Based Images (EPS, AI, PDF, SVG): Move imported outlines to origin (0,0)** in the Exchange tab in `TOPTIONSFORM`. Default is off.
* **VectorImageEPSOriginX** (version 6.0 & above) – Used with **Vector Based Images (EPS, AI, PDF, SVG): Origin X** in the Exchange tab in `TOPTIONSFORM`. Default is 100.00.
* **VectorImageEPSOriginY** (version 6.0 & above) – Used with **Vector Based Images (EPS, AI, PDF, SVG): Origin Y** in the Exchange tab in `TOPTIONSFORM`. Default is 600.00.
* **VectorImageEPSPixelsPerEm** (version 6.0 & above) – Used with **Vector Based Images (EPS, AI, PDF, SVG): Pixels per em** in the Exchange tab in `TOPTIONSFORM`. Default is 512.00.

### Preview
* **FeaturesWidth** (version 7.0 & above) – Changes width in the OpenType feature splitter.
* **FeatureTags** (version 7.0 & above) – Contains the tags used to enable or disable OpenType features. Default is empty.
* **PreviewFeatures** (version 7.0 & above) – Contains the feature codes to enable or disable OpenType in the preview text.
* **PreviewFontSize** – Select the size in `TFONTTESTFORM`.
* **PreviewPosHeight** (version 3.0 until 4.5) – Contains the height in the preview window.
* **PreviewPosLeft** (version 3.0 until 4.5) – Contains the left position in the preview window.
* **PreviewPosTop** (version 3.0 until 4.5) – Contains the top position in the preview window.
* **PreviewPosWidth** (version 3.0 until 4.5) – Contains the width in the preview window.
* **PreviewSampleFontSize** – Scale the font in the Preview window. Default is 24.
* **PreviewSampleText** – Contains sample text in the Preview window. Default is **High-Logic ©** (old versions) or **&lt;enter preview text here&gt;**.
* **PreviewSampleUseKerning** (version 3.0 until 6.5) – Set this value to on to kern text in the Preview window. Replaced with `PreviewFeatures` in version 7.0 & above.
* **ShowToolbarWindowPreview** – Show or hide the Preview window. Default is on.
* **StrikeThrough** – Strikes out text in `TFONTTESTFORM`. Default is off.
* **Underline** – Underlines text in `TFONTTESTFORM`. Default is off.

### Reg
Many people and companies provided registration keys to create cracked versions. The **Clr** button in `TABOUTDIALOG` (see **RC Data in the executable file** below) will remove the registration information.
* **V5D#** – The # at the end is a numerical string. After registering, it adds the user name to the title bar (version 6.0 & above), removes the **Register** button in `TTIPOFTHEDAYFORM` (version 1.0 until 6.5), hides the **Buy** menu and the **Help: Register** menu item and shows developer options (version 12.0 & above) if it's not hidden in the executable file.

### Themes (version 3.0 until 6.5)
* **ActiveTheme** – Contains the active theme.

### Tip of the Day (version 3.0 until 6.5, used in `TTIPOFTHEDAYFORM`)
* **CurrentTip** – Line number in `FontCreator.tip` (it increases one line when closed). Default is first line.
* **ShowTipOnStartup** – Set this option to off if you don't want to **Show this screen next time when you start FontCreator**. Default is on.

### Validation
* **DiagonalRedundantOffCurvePointsDetection** – Used with **Diagonal redundant points detection: Maximum off-curve distance** in the Validation tab in `TOPTIONSFORM`. Default is off.
* **DiagonalRedundantOnCurvePointsDetection** – Used with **Diagonal redundant points detection: Maximum on-curve distance** in the Validation tab in `TOPTIONSFORM`. Default is off.
* **EnableGlyphProblemDetection** – Used with **Enable Real-Time** in the Validation toolbar. Default is on.
* **LocalExtremeCoordinatesDetection** – Used with **Off-curve extreme coordinates: Local detection** in the Validation tab in `TOPTIONSFORM`. Default is on.
* **MaximumRedundantOffCurvePointsDistance** – Used with **Diagonal redundant points detection: Maximum off-curve distance** spinner in the Validation tab in `TOPTIONSFORM`. Default is 0.20.
* **MaximumRedundantOnCurvePointsDistance** – Used with **Diagonal redundant points detection: Maximum on-curve distance** spinner in the Validation tab in `TOPTIONSFORM`. Default is 0.80.
* **ShowIntersection** – Used with **Show Intersecting** in the Validation toolbar. Default is on. If the glyph is too complex, the button will appear dimmed.
* **ShowWarningPoints** – Used with **Show Warning Points** in the Validation toolbar. Default is on. If the glyph is too complex, the button will appear dimmed.
* **TestContoursWithIncorrectDirection** – Used with **Validation Tests: Contours with incorrect direction** in `TVALIDATIONWIZARDFORM`. Default is on.
* **TestContoursWithOneOrTwoPoints** – Used with **Validation Tests: Contours with one or two points** in `TVALIDATIONWIZARDFORM`. Default is on.
* **TestDuplicateComponents** – Used with **Validation Tests: Duplicate components** in `TVALIDATIONWIZARDFORM`. Default is on.
* **TestDuplicateContours** – Used with **Validation Tests: Duplicate contours** in `TVALIDATIONWIZARDFORM`. Default is on.
* **TestDuplicateKnots** – Used with **Validation Tests: Duplicate knots** in `TVALIDATIONWIZARDFORM`. Default is on.
* **TestEmptyComponents** – Used with **Validation Tests: Empty components** in `TVALIDATIONWIZARDFORM`. Default is on.
* **TestFixDetectedProblems** (version 4.1 & above) – Used with **Fix detected problems** in `TVALIDATIONWIZARDFORM`. Default is off.
* **TestIntersectingComponents** – Used with **Validation Tests: Intersecting components** in `TVALIDATIONWIZARDFORM`. Default is on.
* **TestIntersectingCoordinates** – Used with **Validation Tests: Intersecting coordinates** in `TVALIDATIONWIZARDFORM`. Default is on.
* **TestOffCurveExtremeCoordinates** – Used with **Validation Tests: Off-curve extreme coordinates** in `TVALIDATIONWIZARDFORM`. Default is on.
* **TestOverlappingComponents** – Used with **Validation Tests: Overlapping components** in `TVALIDATIONWIZARDFORM`. Default is on.
* **TestRedundantPoints** – Used with **Validation Tests: Redundant points** in `TVALIDATIONWIZARDFORM`. Default is on.
* **TestSuspiciousPoints** (version 11.0.0.2365 & above) – Used with **Validation Tests: Suspicious points** in `TVALIDATIONWIZARDFORM`. Default is on.
* **ValidationMaxNumberOfCompositeGlyphMembers** – Used with **Real-time glyph validation: Disable when number of members exceeds** in the Validation tab in `TOPTIONSFORM`. Default is 1000.
* **ValidationMaxNumberOfContours** – Used with **Real-time glyph validation: Disable when number of contours exceeds** in the Validation tab in `TOPTIONSFORM`. Default is 100.
* **ValidationMaxNumberOfPoints** – Used with **Real-time glyph validation: Disable when number of points exceeds** in the Validation tab in `TOPTIONSFORM`. Default is 25.

### Warn (used in Options: Advanced)
* **WarnBeforeActivatingFixFeature** (version 4.0 until 6.5) – Used with **Warn before activating the fix feature in the Font Validation Wizard**. Default is on.
* **WarnBeforeActivatingRemoveFeature** (version 4.0 until 6.5) – Used with **Warn before activating a remove feature from the Options → Font page**. Default is on.
* **WarnBeforeAddCharacters** (version 5.0 until 6.5) – Used with **Warn before adding characters**. Default is on.
* **WarnBeforeAnchorDelete** and **WarnBeforeAnchorDelete2** – Used with **Warn when deleting an anchor used by OpenType features**. Default is on.
* **WarnBeforeCloseOpenTypeDesigner** – Used with **Warn about losing changes when cancelling or closing OpenType Designer dialog**. Default is on.
* **WarnBeforeExecutingGlyphTransformProgram** (version 4.5 & above) – Used with **Warn before executing a glyph transformer script**. Default is on. The checkbox is hidden in recent versions and moved all the way down but it is documented.
* **WarnBeforeSortingGlyphs** (version 5.0 until 6.5) – Used with **Warn before sorting glyphs**. Default is on.
* **WarnImportSmallImage** – Used with **Warn when importing small image**. Default is on.
* **WarnWhenOpening10OrMoreFonts** – Used with **Warn when opening 10 or more fonts**. Default is on.
* **WarnWhenProcessingVOLTTable** (version 9.0 & above) – Used with **Warn when opening a font file which contains a VOLT table**. Default is on.

## Cursors in the executable file
* **HLADDCONTOUR** – Used when adding contours.
* **HLDUPLICATE** – Used when duplicating contours.
* **HLFREEDRAW** and **HLFREEDRAWBUSY** – Used by **Free Draw** (version 6.5 & above).
* **HLFREEHAND** – Used by **Freehand** (version 4.1 & above).
* **HLGUIDELINED** – Used by **Guideline**.
* **HLKNIFE** – Used by **Knife** (version 5.0 & above).
* **HLMEASURE** – Used by **Measure** (version 4.1 & above).
* **HLMOVECONTOUR** – Used when moving in glyphs edited in contour mode.
* **HLMOVEPOINT** – Used when moving in glyphs edited in point mode.
* **HLNEWELLIPSE** – Used when adding ellipses to empty glyphs (version 5.5 & above).
* **HLNEWRECTANGLE** – Used when adding rectangles to empty glyphs (version 5.5 & above).
* **HLPAINTBUCKET** – Used by **Paint Bucket** for colored fonts (version 7.5 & above).
* **HLROTATE** – Used by rotating contours (**Rotate**).
* **HLSEGMENT** – Used by **Paint Bucket** for colored fonts (version 7.5 & above).
* **HLSELECT** – Used when selecting anything in the glyph.
* **HLSELECTCONTOUR** – Used for selection in glyphs edited in contour mode.
* **HLSELECTPOINT** – Used for selection in glyphs edited in point mode.
* **HLZOOMIN** – Used by **Zoom In**.
* **HLZOOMOUT** – Used by **Zoom Out**.

## RC Data in the executable file
* **CHARTABLE** (version 10.0 until 10.1.0.2272) – Contains a list of characters.
* **CLOUDS** (unused) – Image of clouds with different colors.
* **DESCRIPTION**, **ELDATA** and **PLATFORMTARGETS** (unused) – These are binary resources.
* **DVCLAL** (unused) – Shows two paragraphs (valid license key/running C++ Builder Professional).
* **PACKAGEINFO** (unused) – Shows all functions and the Pascal log used to compile the program.
* **TABOUTDIALOG** and **TABSTRACTABOUTDIALOG** (**TABOUTFORM** and **THLCREGISTERABOUTBOXDLG** in old versions) – Displays copyright, program/operating system version number, physical memory, registration information and MPL Licensed Open Source Software (version 6.0 & above) (**Help: About...**).
* **TABSTRACTWELCOMEDIALOG** (**TWELCOMEFORM** in old versions) – Used by newcomers if `OnStartupShowWelcome` is enabled.
* **TADDCHARACTERSFORM** (version 4.0 & above) – Used when adding characters to the font. In version 4.0 the menu item is hidden and adds glyph data from another font and only adds one character. In version 5.0 & above it adds up to 65,535 characters using empty glyphs.
* **TADDCHARACTERTOGLYPHINDEXMAPPINGFORM** – Shown when pressing **Select** in `TCHARACTERTOGLYPHINDEXMAPPINGFORM` (old versions) or the Unicode button in the glyph properties (new versions) to assign Unicode character values for each glyph.
* **TADDCUSTOMNAMINGFORM** – Used by **Font Properties: Custom: Add...** to add custom naming fields for multiple languages.
* **TADDFPCVLTSFORM** – Adds labels, tooltips or samples to character variants in the OpenType layout tables.
* **TADDFPSIZENAMEFORM** – Adds subfamily names to the font.
* **TADDFPSTYLISTICSETNAMEFORM** – Adds or writes stylistic set names or descriptions in the OpenType layout tables.
* **TADDGASPFORM** – Adds gasp ranges to the font (**Add** in **Smoothing: Preferred rasterization techniques** in `TFONTSETTINGSFORM`).
* **TADDLOCALLANGUAGEDATAFORM** (version 2.0 until 6.5) – Shows a dialog to add naming fields for multiple languages to the font.
* **TADDPLATFORMFORM** (version 2.0 until 6.5) – Shows a dialog to add a platform to the font (**Add** in `TPLATFORMMANAGERFORM`).
* **TADDUVSFORM** – Used by fonts for East Asian languages to add Unicode variation sequences.
* **TADVANCEDEDITFORM** – Edit a naming field in the font.
* **TANCHORMANAGERFRAME** and **TANCHORMANAGERFRM** (version 7.0 & above) – Manages anchors in the font if positioning data exists in the OpenType layout tables.
* **TAUTOKERNEXFORM** (**TAUTOKERNINGFORM** in version 3.0.1 until 6.5) – Automatically add kerning pairs to the OpenType layout tables (version 7.0 & above) or legacy kerning tables (version 1.0 until 6.5) if you don't want to manually add kerning pairs to the font via the OpenType Designer.
* **TAUTOMETRICSFORM** (version 3.0.1 & above) – Automatically generate metrics for glyphs. Only useful for proportional fonts, so in general you don't have to use it in monospaced or pixelated fonts. **Fun fact:** High-Logic uses the same optical metrics adjustment user interface in their font generator *Scanahand*.
* **TAUTONAMEFORM** (version 3.1.2 until 6.5) – Automatically change the naming fields of a font.
* **TBASICEDITFORM** (**TADVANCEDNAMINGFORM** in version 3.0 until 6.5) – Edit a naming field or include additional naming fields in the font (replaced with `TFONTPROPERTIESFORM` in version 7.0 & above).
* **TCHANGETAGFORM** (version 7.0 & above) – Changes tags in the OpenType layout tables.
* **TCHARACTERTOGLYPHINDEXMAPPINGFORM** (version 2.0 until 6.5) – Shows a dialog to map characters to glyph indexes. The menu item was called **Tools: TODO! AutoCmap...** (invisible) in version 3.0 until 5.6 and dropped after version 6.0. This corresponds to the `cmap` table.
* **TCODEEDITORFORM** (version 7.0 & above) – Starts a utility to view or edit the OpenType feature code (**Code Editor** in `TOPENTYPEDESIGNERFORM`).
* **TCODEPAGERANGEFORM** – Includes or excludes code pages to support in the font. This corresponds to the `ulCodePageRange` fields which makes the font usable in some programs like Microsoft Office or Sublime Text. If the font has no code page ranges set (e.g. Noto Sans and its regional variants), then Windows will show the script selection as **Other**.
* **TCOLORFORM** (old versions) – It's not the standard Windows color selection dialog.
* **TCOMPOSITEGLYPHPROPERTIESFORM** – Views or modifies properties for members in composite glyphs.
* **TCONFIRMREPLACEDIALOG** (version 10.0 until 10.1.0.2272) – This confirmation dialog will ask you what to do when replacing.
* **TCONVERTBITMAPTOCONTOURSFORM** – Converts bitmap images to contours or imports raster images to any glyph in the font.
* **TDELETEFEATURELOOKUPFORM** (version 7.0 & above) – Removes features or lookups from the OpenType layout tables in the font.
* **TDELETEKERNGROUPFORM** (version 7.0 & above) – Removes kerning groups or classes from the OpenType layout tables in the font.
* **TDISABLEDFORM** (version 5.0 & above) and **TABSTRACTDISABLEDIALOG** (version 12.0.0.2565 & above) – Used in unregistered copies during (recent versions) or after a grace period of 30 days (old or recent versions). If this form is deleted, it will either show a message about non-existing form (old versions) or a message with only text (recent versions).
* **TDM** (version 4.0 & above) – Contains icons with no regard to `Glyph.Data` in old versions. Version 5.5 (2006-05-30) until 11.0.0.2365 (2017-05-10) uses Windows XP-style icons.
* **TDMGLOBAL** – Contains codepages, vendors, hinting and bidirectional mirroring data.
* **TEDITANCHORFORM** (version 7.0 & above) – Edits anchors in the font if any glyph has positioning data.
* **TEXPORTGLYPHDATAFORM** (version 4.0 until 6.5) – Exports glyph data in the font to fgd files (**Tools: Export Glyph Data...**). Recent versions limits this feature to only one glyph.
* **TEXPORTSETTINGSFORM** and **TEXPORTSETTINGSFRAME** – Configure settings to export fonts.
* **TEXTERNALSFORM** – Edits the external tools menu (**Tools: Launch Externals: Configure Externals...**).
* **TEXTRACTFROMTTCFORM** (version 4.0 & above) – Extracts OpenType font collections into separate font files (**Tools: Extract from OTC...**). If the unregistered copy detects it is running after a grace period of 30 days, **TDISABLEDFORM** (old versions) or the **Evaluation Period Expired** message (recent versions) is shown instead. This corresponds to the `MiToolsExtractFromTTCClick` function used by `CheckLicenseNotGood`.
* **TFEATURESETTINGSFORM** (version 12.0) – Used when generating or updating OpenType features in `TOPENTYPEDESIGNERFORM`.
* **TFINDFORM** – Searches parts of a font.
* **TFONTEMBEDDINGLICENSINGRIGHTSFORM** (version 2.0 until 6.5) – Shows a list of embedding or licensing rights to use in the font (replaced with **Legal: Embedding Licensing Rights** in `TFONTSETTINGSFORM` in version 7.0 & above).
* **TFONTHEADERFLAGSFORM** – Enables or disables header flags in the font.
* **TFONTINSTALLWIZARDFORM** – Installs the font to the computer. Before version 7.0 & above the program requires saving the font. **Fun fact:** The directory and filename in the first step is a dummy placeholder. The second step (font already installed) includes the Windows 98 directory (`win98`) preceding the fonts folder and Arial font filename. If the unregistered copy detects it is running after a grace period of 30 days, **TDISABLEDFORM** (old versions) or the **Evaluation Period Expired** message (recent versions) is shown instead. This corresponds to the `InstallFont` and `miFontInstallClick` functions used by `CheckLicenseNotGood`.
* **TFONTLOGFORM** – Displays the log for any font (**Developer Tools: Font Log**).
* **TFONTOVERVIEWFORM** – Shows all glyphs after opening any font.
* **TFONTPROPERTIESFORM** – Contains properties and unsupported tables (version 7.0 & above) in the font. If non-Unicode language is East Asian (e.g. Korean), in the **Unsupported Tables** tab it substitutes Latin-1 accented letters by ASCII versions, e.g. Wästman by Wastman (not Waestman) and some Latin-1 symbols by fullwidth versions, e.g. £ by ￡ or other symbols, e.g. « by ≪.
* **TFONTSETTINGSFORM** – Contains basic naming fields or metric settings, Unicode and code page ranges, gasp ranges and more.
* **TFONTTABLESFORM** (version 2.0 until 6.5) – Shows a list of supported and unsupported tables in the font (unsupported tables is a separate tab in `TFONTPROPERTIESFORM` in version 7.0 & above).
* **TFONTTESTFORM** – Test desktop fonts (not web fonts). The text in `mmFontTest` and `Memo1` (version 7.0 & above) in version 4.0 until 5.6 is the program name, uppercase, lowercase and numbers with all DOS/Windows Latin-1 and USA characters (version 6.0 & above removes the DOS/Windows Latin-1 and USA characters at the end). Version 1.1.1c until 5.0 allows the user to change the encoding (it was dropped with version 5.5 & above). If the unregistered copy detects it is running after a grace period of 30 days, **TDISABLEDFORM** (old versions) or the **Evaluation Period Expired** message (recent versions) is shown instead. This corresponds to the `TestFontTTFOTF` (`miFontTestTTFOTFClick`) and `TestFontWOFF` (`btnFontTestWoffClick`) functions used by `CheckLicenseNotGood`.
* **TFORMADDANCHOR** (version 7.0 & above) – Adds anchors to any glyph in the font if positioning data exists.
* **TFORMOPENTYPEDESIGNERSETTINGS** (version 7.0 & above) – Shows an interface for changing options in `TOPENTYPEDESIGNERFORM`.
* **TFORMULAFORM** (version 12.0) – Writes formulas to construct anchor based composite glyphs.
* **TFRAMECATEGORY** (version 7.0 & above) – Contains categories in the font overview (left side).
* **TFRAMEGLYPHMEMBER** (version 7.5 & above) – Used by `TGLYPHEDITFORM` when editing colored glyphs to display glyph members (automatically shown when switching glyphs to color mode).
* **TFRAMEPALETTE** (version 7.5 & above) – Shows the color palette when editing multicolored fonts (automatically shown when switching glyphs to color mode).
* **TGASPFORM** (version 2.0 until 6.5) – Manages gasps in the font (replaced with the Smoothing tab in `TFONTSETTINGSFORM` in version 7.0 & above). This corresponds to the `gasp` table.
* **TGENERATECONTOURSCANCELFORM** – Used when generating contours.
* **TGENERATEPROBLEMREPORTFORM** (version 3.0 until 11.5) – Used when pressing **Next** in `TVALIDATIONWIZARDFORM`.
* **TGLYPHALREADYMAPPEDFORM** (version 2.0 until 6.5) – For each platform a character to glyph index mapping can only exist once, so if you try to add a mapping that already exists this window will ask you what to do. In version 7.0 & above the message is text-only (i.e. the form is removed).
* **TGLYPHEDITFORM** – Used when opening any glyph from `TFONTOVERVIEWFORM`.
* **TGLYPHNAMEFORM** (version 7.0 & above) – Changes the PostScript names in the font (**Tools: Glyph Names**).
* **TGLYPHPROPERTIESFORM** (version 2.0 until 6.5) and **TGLYPHPROPERTIESFRAME** (version 7.0 & above) – Contains postscript name, glyph metrics/bearings and character mappings.
* **TGRIDFORM** – Shows an interface for viewing and setting grid options.
* **TGUIDELINEMODIFYFORM** – Shows a dialog to modify guidelines.
* **TGUIDELINESFORM** – Shows an interface for viewing and setting guidelines options.
* **TIMPORTGLYPHDATAFORM** (version 4.0 until 6.5) – Imports glyph data in the font to fgd files (**Tools: Import Glyph Data...**). Recent versions limits this feature to only one glyph.
* **TINSERTGLYPHFORM** – Shows a dialog to insert glyphs to the font.
* **TINSTALLEDFONTSFORM** – Shows a list of installed fonts. Version 10.1.0.2272 (2016-12-20) & below has a delay which is not present in recent versions.
* **TKERNFEATUREFRAME** – Used by `TKERNINGFORM`.
* **TKERNGROUPMANAGERFORM** (version 7.0 & above) – Manages kerning groups or classes in the font.
* **TKERNINGFORM** (version 3.0 until 8.0) – Views or edits the legacy `KERN` table (not the GPOS kerning tables) in the font (replaced with `TOPENTYPEDESIGNERFORM` in version 7.0 & above).
* **TKERNINGNEWPAIRFORM** (version 3.0 until 8.0) – Adds a kerning pair to the old `KERN` table or the GPOS kerning tables.
* **TKERNINGNEWSINGLEFORM** (version 7.0 & above) – Adds a single kerning adjustment to the font.
* **TMADEXCEPT**, **TMECONTACTFORM**, **TMEDETAILSFORM**, **TMESCRSHOTFORM** – The forms consist of crash report exceptions, contact info, details about the crash report and screenshots. Used to send crash reports.
* **TMAINFORMFONTCREATOR** (**TMAINFORMFCP3** in version 3.0 and **TMAINFORMFCP4** in version 4.0 until 5.0) – Contains a lot of things like the main window, glyph properties, user notes (version 7.0 & above), preview window (version 3.0.1 & above), anchors, glyph validation report and more.
* **TMETRICSFORM** – Shows an interface for viewing and setting metrics options.
* **TNAMINGFORM** (version 3.0 until 6.5) – Contains basic naming fields in the font (replaced with `TFONTPROPERTIESFORM` in version 7.0 & above). **Fun fact:** Fields with unknown numbers are not accessible.
* **TNEWSUBSINGLEFORM** (version 10.0 until 10.1.0.2272) – Adds a single substitution to the OpenType layout tables.
* **TNEWTRUETYPEFONTFORM** – Used when creating a new font.
* **TOPENTYPEDESIGNERFORM** (version 7.0 & above) – Shows an interface for viewing, editing or creating the OpenType layout tables. This corresponds to the `GDEF`, `GPOS` and `GSUB` tables.
* **TOPENTYPEDESIGNERPROOFINGFORM** (version 12.0.0.2560 & above) – Used for interactive feature proofing of OpenType layout tables. Before version 13 the form was blank.
* **TOPENTYPEITEMADDFRM** (version 7.0 & above) – Adds items to the OpenType layout tables.
* **TOPTIONSFORM** – Shows an interface for viewing and setting a wide variety of options.
* **TOTLFRENAMEFORM** (version 7.0 & above) – Rename lookup tables in the OpenType layout tables.
* **TPASTESPECIALFORM** – Paste any data for glyphs stored in the clipboard. In the Items list (version 5.5 until 6.5), **Glyph Outline Data** and **Glyph Metrics** (i.e. the first two items) are checked by default. **Glyph Outline Data** is dimmed in the third major version. In recent versions, the registry keys are stored in the `Edit` key.
* **TPCLTFORM** (version 3.0.1 until 6.5) – Views, edits or modifies the PCL5 data for use with old printers. This corresponds to the `PCLT` table.
* **TPERFORMTRANSFORMATIONFORM** (version 4.5 & above) – Used after transforming each glyph.
* **TPLATFORMMANAGERFORM** (version 2.0 until 6.5) – Choose which platform to support in the font (replaced with **Tools: Convert Font** in version 7.0 & above in `TMAINFORMFONTCREATOR`).
* **TPOSTSCRIPTNAMESFORM** (version 2.0 until 6.5) – Changes the PostScript names in the font (replaced with **Tools: Glyph Names** in version 7.0 & above in `TMAINFORMFONTCREATOR`). The menu item was called **Tools: TODO! AutoPost...** (invisible) in version 3.0 until 5.6 and dropped after version 6.0.
* **TPRINTABORTFORM** – Used after starting the font printing process.
* **TPRINTFONTFORM** – Used when printing anything in the font.
* **TPRINTGLYPHFORM** – Used when printing glyphs in the font.
* **TPROGRESSDIALOG** (**TPROGRESSFORM** in old versions) – The cursor for this form is **Busy**.
* **TREGISTERFORMEX** and **TREGISTERFORMFC** (version 1.0.6 & above, **TREGISTERFORM** in old versions) – Registers the program (**Help** or **Buy: Register...**). This removes `TSPLASHFORM` on startup, hides the **Buy** menu and the **Help: Register...** item and shows the **Developer Tools** menu (if enabled in version 12.0 & above). **Fun fact:** `TREGISTERFORMEX` has its own user agent.
* **TRESOURCEEDITORDLG** (unused, version 3.0) – It is a large resource.
* **TRESOURCEMODULE** – Contains styles in `rvStyleGlobal` and icons with no regard to `Glyph.Data` in old versions.
* **TRICHVIEWDIALOG** – Used during or after a grace period of 30 days for unregistered copies or when selecting the **Help: Upgrade** menu item. Styles are located in `RVStyle1`.
* **TRULEMGR** (version 7.0 & above) – Manages rules in the OpenType layout tables.
* **TSAMPLETEXTFORM** (version 6.5 & above) – Edit the list of sample text strings in `TFONTTESTFORM`.
* **TSELECTCOMPOSITEGLYPHMEMBERFORM** – Adds glyph members to any composite glyph.
* **TSELECTLOOKUPTABLEFORM** – Selects a lookup table in the OpenType layout tables.
* **TSHAREWAREFORM** (version 3.0 until 5.0) – For unregistered copies running after a grace period of 30 days, shows the shareware description when pressing **Start** in `TSPLASHFORM`. See the article about shareware in Wikipedia.
* **TSORTGLYPHSFORM** (version 5.6 until 6.5) – Changes the glyph order within a font (replaced with **Tools: Sort Glyphs** in version 7.0 & above). Prior to version 5.6 the glyphs are sorted in any font with the standard macOS ordering.
* **TSPLASHFORM** – Shows if the program is detected to be running an unregistered copy. The three buttons at the bottom (**Use Evaluation Version**, **Enter Registration Code** and **Buy Now**) are displayed randomly. **Fun fact:** The copyright in version 7.0 & above has a date of 2007-2010.
* **TSPTBXCOLORPICKERFORM** – Selects colors when editing colored glyphs.
* **TSUBLOOKUPMGR** (version 7.0 & above) – Manages subtables in the OpenType layout tables.
* **TTEXTREPLACEDIALOG** – Replaces text in `TCODEEDITORFORM`.
* **TTEXTSEARCHDIALOG** – Searches text in `TCODEEDITORFORM`.
* **TTIPOFTHEDAYFORM** (version 1.0 until 6.5) – Shows tips and tricks (**Help: Tip of the Day**). The dialog is shown for newcomers. The **Register** button is shown if the program is detected to be running an unregistered copy. See **Tip of the Day** in **FontCreator: Tutorials and Solutions** in the High-Logic forum for recent tips.
* **TTRANSFORMFORM** (version 4.5 & above) – Transforms the font to other weights (e.g. bold or black) or add character ranges (e.g. some characters in the *Letterlike Symbols* range of Unicode).
* **TTRIALNOTICEWINDOW** (version 7.0 until 10.1.0.2272) – If the program is detected to be running an unregistered copy, testing, installing or exporting fonts displays this message. The message has a checkbox to turn it off. The text includes a link to the registration page in the High-Logic website.
* **TTRIMFORM** – Used when trimming glyphs.
* **TUNICODERANGEFORM** – Includes or excludes Unicode blocks or ranges to support in the font. This corresponds to the `ulUnicodeRange` fields. **Fun fact:** The list belongs to OpenType 1.3.
* **TUPDATEFORM** and **TUPDATEFORMFC** (version 6.1 & above, **TUPDATEREMINDERFORM** in version 5.5 through 6.0) – Checks for updates (**Help: Check for Updates**) as if `OnStartupShowUpdateReminder` or `UpdateCheckInterval` is enabled. The program will terminate silently if `TUPDATEFORM` is removed or `mRestart` in `TUPDATEFORM` does not have three lines. The automatic update algorithm uses the High-Logic website to download the installer.
* **TUSEDBYFORM** – Displays an overview of all glyphs that use the selected glyph.
* **TUVSFORM** – Manage Unicode variation sequences used by fonts for East Asian languages.
* **TVALIDATIONWIZARDFORM** (version 4.0 & above) – Validates the font for errors or problems. The menu item was called **Font: TODO! Problem Report...** (invisible) in version 3.0.
* **TWIDEMESSAGEFORM** – Used for messages.
* **TWIDEWARNINGFORM** (**TEXTENDEDWARNINGFORM** and **TWARNINGFORM** in old versions) – Used for warnings.

## Unused Content
The company hid debugging and other options in the RC Data resources using `Visible = False`.

### Main Form (`TMAINFORMFONTCREATOR`)
**Menu Items**
* **Edit: Knife** – Does not work. Use the same option in the **Glyph** toolbar.
* **Edit: Join Contours** – Use the Union option in the **Glyph** toolbar.
* **Edit: Split Contours** – Use the Knife option in the **Glyph** toolbar.
* **View: Toolbars: Tab Bar** – Hides the tabs if version 6.1 until 11.5 is used. The feature summons no action when selected in the 12th and 13th major versions.
* **Tools: Export Glyph Outlines...** (version 4.0 until 5.6) – Does not work. See **miTestItem4 Save** in `TGLYPHEDITFORM` for glyphs edited in contour mode.
* **Tools: Import Glyph Data...** (version 4.0 until 5.6) – Imports glyph data from the font. Replaced with **miTestItem3 Load** in `TGLYPHEDITFORM` for glyphs edited in contour mode. This feature is undocumented in the manual.
* **Tools: Export Glyph Data...** (version 4.0 until 5.6) – Exports glyph data in the font to fgd files. Replaced with **miTestItem4 Save** in `TGLYPHEDITFORM` for glyphs edited in contour mode. This feature is undocumented in the manual.
* **Tools: TODO! Customize...** – Use Resource Hacker or other program to modify the menus or toolbars. If the toolbars detects that some icons are removed without using `Visible = False`, the first message shown in the status bar is replaced with access violation when opening fonts or doing other things.
* **Window: Minimize All** – Minimizes all other windows (restore each minimized window via the restore button).
* **Help: Upgrade** (version 13.0) – Shows a message with the text for standard version license.

**Hidden Shortcuts** – Menu's description from the form: These items are here so the shortcuts work.
* **Restore Overview Splitter** – Hide or show the overview splitter.
* **Close** – Close active window with the same command in the **File** menu.
* **Cut**, **Copy** and **Paste** – Uses the same commands in the **Edit** menu.
* **Show Font Properties** – Uses the same command in the **Font** menu.
* **Redo** – Uses the same command in the **Edit** menu.
* Tags from **tags.txt** and **Tagged** folder (`TFONTOVERVIEWFORM`) – These menu items are automatically shown and do nothing when selected in `TFONTOVERVIEWFORM` except when using the same items from the `TFONTOVERVIEWFORM` glyph context menu or editing glyphs in `TGLYPHEDITFORM`.

**Developer Tools** – Contains debugging functions and developer commands (the menu is hidden if FontCreator 12 or 13 is detected to be running an unregistered copy).
* **Screenshot macro 1** or **Screenshot macro 2 (website)** – Create screenshots from `C:\Program Files\help\screenshots\` (32-bit) or `C:\Program Files (x86)\help\screenshots\` (64-bit). Create the folder `help\screenshots\`, use anti-aliased smoothing (version 7.0 until 11.5) and register FontCreator to use these features.
* **Hide Developer Menu** – Hides the menu (i.e. adds `Visible = False` to the menu much like the original program).
* **AutohintMacro** – Uses the **Close All** command in the **File** menu.
* **Video mode** – Restores window to original size and registers program without a key.
* **A/B Testing** – Contains two options to set the variant.
* **Font Log** – Shows the font log (this item is hidden if FontCreator 12 or 13 is detected to be running an unregistered copy).
* **Disable garbage collector** – Does not work.
* **Increase Font Size** – Shows information about the font and size with two numerical strings.
* **Enable All Toolbar Icons** – Enables all icons in toolbars. Do other things to disable most icons.
* **Font Tester Action** – This menu item is intended to change the action used by `TFONTTESTFORM`.
* **Boink!** – Exit the program silently. In version 10.0 (2016-06-22) until 11.5.0.2430 (2018-12-05), the feature summons no action when selected and is located in the **Debug** menu. It may display a critical error which varies on closing, which contains an "OK" button.

**Toolbar Buttons** – The last four buttons are enabled when editing simple or composite glyphs.
* Second **Open** and **Print** options in the **Standard** toolbar – Only the second **Print** option uses the same command in the **File** menu or the first **Print** option. The second **Open** option icon is blank.
* **Next Glyph** in the **Validation** toolbar – Does not work.
* **Tools: Generate Glyph Names** – Save friendly glyph names to `C:\Users\EDenissen\AppData\Roaming\FontCreator12\generatednames.txt` or `C:\Users\EDenissen\AppData\Roaming\FontCreator13\generatednames.txt`. Create the user `EDenissen` to use this feature. The button is hidden if FontCreator 12 or 13 is detected to be running an unregistered copy. The icon in this button is textual.
* **Glyph: Smooth Curves** – Smooths all curves. The icon in this button is textual.
* **Glyph: Smooth and Align Curves** – Smooths and aligns curves. The icon in this button is textual.
* **Glyph: Harmonize** – Harmonizes all contours. The icon in this button is textual.
* **Glyph: Round XY Coordinates** – Round XY coordinates values. The icon in this button is textual.

### Glyph Edit (`TGLYPHEDITFORM`) Contour Mode Context Menu
* **Order** (version 3.0 until 5.0) – The features are implemented as **Align or Distribute** in version 5.5 & above.
* **Debug Single Stroke Twice** (**miTestItem** in version 10.0 until 10.1.0.2272) – Does not work.
* **miTestItem2** – Jumps to the next contour based on the number of selected contours.
* **miTestItem3 Save** and **miTestItem4 Load** – Save or load glyph data from `C:\hltemp\glyph.data` (see **Tools: Import/Export Glyph Data** in the menu for old versions above). Create the folder `hltemp` to use these features.

### Font Overview (`TFONTOVERVIEWFORM`)
Version 4.5 added support for bookmarking glyphs (the feature was discontinued since version 7.0 and the menu is hidden).

### Import Image (`TCONVERTBITMAPTOCONTOURSFORM`)
* Checkbox: **Include Diagonals** (version 3.0) – The checkbox was dropped after version 4.0.
* Checkbox: **Remove Knees** (version 3.0) – The checkbox was dropped after version 4.0.

### Glyph Properties (`TGLYPHPROPERTIESFORM`)
Version 4.0 until 5.0 includes a text box which was intended to show the number of contours (see the status bar in **TMAINFORMFONTCREATOR** at the bottom).

### Composite Glyph Properties (`TCOMPOSITEGLYPHPROPERTIESFORM`)
* Text box with glyph indexes (version 3.0 until 6.5) – It is located at the top right corner.
* Button: **Delete** (version 3.0 until 6.5) – It summons no action when pressed. Use `TGLYPHEDITFORM` to delete member(s) of a composite glyph.
* Checkbox: **ARGS_ARE_XY_VALUES** (version 3.0 until 6.5) – The checkbox was dropped after version 7.0.

### Automatic Metrics Wizard (`TAUTOMETRICSFORM`)
If the program detects it is running the Home Edition the Professional Edition note is shown (in the Professional Edition it is hidden). Version 10.0 includes three unused features (the features were dropped in version 11.0 & above).

The third panel changes the advance width with check boxes to center the glyph/set the left side bearing at x=0 and a radio button to use monospaced metrics (it is only active when the Fixed option is selected).

### OpenType Designer (`TOPENTYPEDESIGNERFORM`)
These buttons are shown when editing the GPOS kerning tables. The values at the beginning start with a capital D in square brackets.
* **Clear Values** – Set the value for all kerning pairs to 0. Useful for monospaced fonts that have a kerning table (e.g. *Monospaced Typewriter* by Manfred Klein).
* **Harmonize** – Harmonizes all kerning pairs in subtables.
* **Clean Up** – Removes all kerning pairs that have a kerning value of 0. Version 3.0 through 6.5 removes pairs that are made up with glyphs that are not connected to any Unicode character (except in version 7.0 & above).

### OpenType Layout Feature Editor (`TCODEEDITORFORM`)
* Checkbox: **VOLT.UseGlyphIds** – The checkbox is used for fonts with Microsoft VOLT projects only. The value at the beginning starts with Debug and a colon.

### Font Test Window (`TFONTTESTFORM`)
The context menu for `mmFontTest` has two paste options and a multiline text field at the bottom (`Memo1`) with the same text in Arial Bold (13 points). A double-click will change the font and size.

### Options Window (`TOPTIONSFORM`)
The **General** tab has a group to associate fonts with the program itself (it is in version 3.0 only and was dropped after version 4.0). The **Preview** tab includes three unused buttons to move strings up or down or to reset the list.

### About Dialog (`TABOUTDIALOG` and `TABSTRACTABOUTDIALOG`)
These are located in the corners of the program name, version number, copyright notice and the company's website.
* **Clr** (Clear) (version 4.5 & above, top left corner) – Removes registration information (see the `Reg` section in **Registry Keys** above). Before version 6.0 the text is white and is located in the registration information.
* **Crash** (top right corner) – Displays a critical error which reads "We hope you enjoyed clicking this crash button".
* **Trial** (bottom right corner, version 12.0 & above) – Reset the trial period for unregistered copies running after a grace period of 30 days.