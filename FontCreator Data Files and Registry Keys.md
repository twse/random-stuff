﻿FontCreator is a shareware font editor for Windows and macOS which supports fonts in TrueType (TTF), OpenType (OTF, EOT), and Web Open Font Format (WOFF, WOFF2) and TrueType font collections (TTC). Developed by [High-Logic B.V.](https://www.high-logic.com/) in 1997.

## Notes
* The cursor will remain **Busy** if the user is doing other stuff while saving fonts in the background.
* Exiting when saving fonts may create invalid font(s) and play the Critical Stop sound from the PC speakers.
* The program shows a critical error saying "access violation" when exiting while during some operations – the font(s) may be invalid.
* Glyphs in the clipboard (version 1.0 until 6.0) use "**Glyph Contours**" for contours and "**Glyph Data**" for glyphs. Version 7.0 & above stores the PostScript glyph name(s) as text (glyphs) or **Font Data** (contours).
* **Edit: Delete** is not dimmed on startup or when closing other dialogs in old versions.
* **Complete Composites** (when generated from `CompositeData.xml`, not auto or anchor based) times out two seconds when used the first time in simple and composite glyphs.
* **Complete Composites** is dimmed when editing empty glyphs in version 5.0 until 6.5.
* The program shows a critical error when using **Complete Composites** for some glyphs assigned by [Bhikkhu Pesala](http://www.softerviews.org/Fonts.html) in the Private Use Area (old versions only).
* Version 1.0 (1998-04-11) until 7.0 (2013-04-25) only supports characters mapped to the Basic Multilingual Plane in Windows Unicode when adding to the preview window.
* Version 5.6 (2007-07-19) uses a non-standard layout for all resources.
* In new fonts (version 5.0 until 6.5), the international currency sign (¤) is mapped to the Macintosh Roman platform but not the euro (€) which has the same codepoint (219).
* Version 1.0 (1998-04-11) until 6.5 (2011-11-18) used ISO/IEC 8859-1 (Latin-1) as the program's output encoding (the same is used for exported kerning pairs) while version 7.0 (2013-04-25) & above uses Unicode.
* The PostScript names modified when opening fonts in version 3.0 until 4.0 are as follows: **.notdef** is **notdef**, **nonmarkingreturn** is **CR** and **exclamdown** is **exclamationdown**.
* The installer was mirrored in **fontcreator.com** up to version 6.1.

## Unregistered version limitations
If the program detects it is an unregistered copy or is running as a limited user or if registration is not performed during or within the grace period, the following restrictions will be imposed on the version number:
* All versions – `TSPLASHFORM` is shown in startup. The title bar will display "unregistered" (version 5.0 & above) and the registration information in the about dialog states the program is unregistered. After a grace period of 30 days, the message in `TSPLASHFORM` is replaced with messages stating that the grace period is exceeded and asks to uninstall or buy the program. In version 6.0 & above there is a menu to register or buy the program.
* 3.0β1 (2000-07-30) until 3.1.3 (2002-12-09) – After a grace period of 30 days, it explains about shareware when pressing **Start** in `TSPLASHFORM`. However, the program otherwise functions normally.
* 4.0 (2003-05-16) until 5.0 (2005-01-12) – After a grace period of 30 days, the program cannot be used at all unless it is registered.
* 5.5 (2006-05-30) and 5.6 (2007-07-19) – After a grace period of 30 days and opening the program 5 times, the program will enter a reduced functionality mode, where fonts cannot be saved, tested or installed and TrueType collections cannot be extracted.
* 6.0 (2009-06-17) until 6.5 (2011-11-18) and 8.0 (2014-06-05) until 12.0.0.2539 (2019-06-04) – The program will enter a reduced functionality mode. The reduced functionality varies based on whether the program is in the grace period or not. In this case, fonts cannot be tested (version 6.0), installed or exported, OpenType collections cannot be extracted and tested fonts won't be automatically hinted.
* 7.0 (2013-04-25) until 11.5.0.2430 (2018-12-05) – The program will create subsetted versions when testing, installing or exporting fonts. (The glyphs are as follows: ! , - . = ? @ / \\, numbers, letters, fi and fl. Other characters are replaced by rectangles.) After a grace period of 30 days, the program will enter a reduced functionality mode, where font projects cannot be saved, fonts cannot be tested, installed or exported and OpenType collections cannot be extracted (`CheckLicenseNotGood` function from `OnShowDisabledMessage`).
* 12.0.0.2543 (2019-07-10) until 14.0.0.2894 (2022-11-22) – The program will replace random characters with the High-Logic logo in generated fonts. After a grace period of 30 days (7 days for 15.0.0.3024), the program will enter a reduced functionality mode, where font projects cannot be saved, fonts cannot be tested, installed or exported and OpenType collections cannot be extracted (`CheckLicenseNotGood` function from `OnShowDisabledMessage`).

## Windows version compatibility
| Operating system              | Latest version |
|-------------------------------|----------------|
| Windows 7 and later           | 15.0.0.3024    |
| Windows Vista                 | 11.0           |
| Windows XP                    | 10.0           |
| Windows 2000                  | 7.0            |
| Windows 95, 98, ME and NT 4.0 | 6.0.1          |

## User data
“FontCreator uses several extra data files to read settings and other program specific information.” Most files can be edited directly with administrator privileges.
* **bookmarks.txt** (version 4.5 until 6.5) – Includes bookmarks used by the font overview. Created automatically after exiting the program.
* **CompositeData.xml** (version 5.0 & above) – Located in the `Composite` folder as used by **Complete Composites**. The feature will do nothing if the file has syntax errors or is missing. [Bhikkhu Pesala](http://www.softerviews.org/Fonts.html) had assigned code points in the Private Use Area for different glyphs in this file and his fonts (he removed them), notably for use with OpenType features like small capitals or old style numbers. This file is copied when pressing **Copy Data Files to User Data Folder** under **Options: Advanced: Data Files**.
* **CurrentTransformProgram.xml** (version 4.5 & above) – Transform Program used by `TTRANSFORMFORM`. The window will appear empty if removed.
* **default.otlfd** (version 7.0 until 11.5) – Default OpenType feature definitions used when adding common OpenType features (replaced with `TFEATURESETTINGSFORM` in version 12 & above).
* **Denissen.ttf** (version 4.5 until 5.5) – located in the fonts folder) – Sample font made from handwriting designed by Erwin Denissen (with only the Basic Latin Unicode block). Named after Erwin Denissen (the co-founder of High-Logic). León Fridsma (the other co-founder of High-Logic who joined in 2009) has not designed this font. It dates from the year 2000.
* **FC#####.otf/ttf** (desktop fonts in the test font window) or **FC#####.woff** (web fonts) – Temporary fonts whereas the last 5 characters in the filename are numbers. Version 3.0 until 6.5 named the font as **FC Test Font ######** while recent versions names the font up to 25 characters followed by 5 numbers.
* **fc12.cfg** (version 12.0) – Configuration file located in the user's directory.
* **FCOutDrw.dll** – Dynamic link library used by advanced outlines, located in the system root directory (version 10 & above).
* **fcp5.cfg** (version 5.0 until 5.6) – Configuration file located in the system root directory.
* **fcppreview.txt** (version 3.0 until 4.5) and **previewtext.dat** (version 5.0 & above) – Text used in the test font window. The default text will be used if the file is removed.
* **FCPSHL.dll** (version 3.0 until 6.5) – Adds the **Open with FontCreator** menu item to TrueType fonts (version 7.0 & above adds the program itself to the **Open with** menu).
* **fntXX/XXX.tmp** – Temporary font used by saving (the last two or three characters in the filename is a combo of letters and/or numbers).
* **FontCreatorSetup.exe** – Installs the Win32 version of the program. Use the `/DIR` switch to change the installation directory.
* **FontCreatorSetup-x64.exe** (version 11.0 & above) – Installs the Win64 version of the program. Use the `/DIR` switch to change the installation directory.
* **FontCreator.tip** (version 2.0 until 6.5) – Contains tips and tricks in the Tip of the Day. The window will appear empty if removed.
* **FontCreator YYYYMMDD HHMMSS ###.dat/prd** (version 12.0) – Contains crash and error info (located in `ProgramData\High-Logic\Errors` – **YYYYMMDD HHMMSS** is the computer's date and time and **###** is a number). The Call Stack Information was removed in version 12.0.0.2563 (2020-02-21).
* **FontInstaller.dll** (version 2.0 until 6.5) and **FontInstaller2.dll** (version 7.0 & above) – Dynamic link library for installing fonts.
* **glyphlist.dat** – List of PostScript names for glyphs in the Adobe glyph list. Old versions have the same list but it duplicates **xi** to the first Unicode codepoint. This file is copied when pressing **Copy Data Files to User Data Folder** under **Options: Advanced: Data Files**.
* **glyphnames.dat** (version 7.0 until 11.5) and **glyphnamesnew.dat** (version 12.0 & above) – “Contains overrides of the default friendly glyph names, as used when opening existing fonts (and fonts without PostScript names) and when you generate glyph names on the Glyph Properties dialog”. This file is copied when pressing **Copy Data Files to User Data Folder** under **Options: Advanced: Data Files**.
* **guidelines.dat** – Contains the guidelines used by the glyph edit and guideline options windows. Created automatically after exiting the program.
* **kern_font.txt** – For old versions of FontCreator, stores the old `KERN` table data in each font whereas `font` is the font name. Opening fonts with the old `KERN` table in recent versions will create the `GPOS` table named `KerningFromKernTable` from the OpenType kerning feature.
* **lang.language code** – Localized files.
* **preview.txt** (version 4.5 & above) – “Contains the standard preview texts for the Preview toolbar”. The dropdown list is empty if this file is missing. This file is copied when pressing **Copy Data Files to User Data Folder** under **Options: Advanced: Data Files**.
* **SubFamily.dat** or **SubFamily2.dat** – Contains multilanguage naming fields.
* **TableOffsetOrderCFF.txt** – Contains supported tables in fonts with CFF Postscript outlines or Cubic Bézier curves.
* **TableOffsetOrder.dat** (old versions) or **TableOffsetOrder.txt** – Contains supported tables in fonts with quadratic curves. All tables are moved to **Unsupported Tables** (Properties in version 7.0 & above) or **Unsupported** (Tables in version 3.0 until 6.5) if the file is missing. This may result in invalid fonts!
* **tags.txt** (version 7.0 & above) – Contains the five tags which can be assigned to each glyph. Defaults are **Important**, **Incomplete**, **Completed**, **Review** and **Workspace**. This file is copied when pressing **Copy Data Files to User Data Folder** under **Options: Advanced: Data Files**.

In **Options: Advanced: Data Files** are two buttons labeled **Copy Data Files to User Data Folder** and **Open User Data Folder** (version 8.0 & above). When pressed, the Transform, UnicodeData and WoffTest folders and some files in the above list will be copied to the user's data folder or the user's data folder will be opened.

## Default font export settings
* **WOFF Version** – Default is **version 1 and 2**.
* **Outline Format** – Default is **TrueType**.
* **Components** – Default is **Decompose scaled (recommended)**.
* **Glyph Names** – Default is **Use friendly glyph names** for new projects and **Regenerate for release** (i.e. use friendly glyph names) for TrueType and **No** for WOFF.
* **Color** – Default is **No**.
* **Hinting** – Default is **Auto hinting** for new projects or **Keep original** for opened fonts.
* **Output Folder** – Default is the **Fonts** folder from the user's documents folder, created during startup.
* **Existing Files** – Default is **Rename existing files**.

## Index of registry keys
Before FontCreator 15, the registry keys are located in `HKCU\Software\High-Logic\FontCreator\version` or `HKCU\Software\High-Logic\Font Creator Program\version` where `version` is the version number (the settings are stored as `settings.json` since FontCreator 15). Holding down **Ctrl** in version 7.0 & above during startup will restore the program to factory settings.

### AddCharacters (version 4.0 & above)
* **SelectedCharacter** – Select the character in this dialog. Default is 0 (null).
* **SelectedFont** – Select the font to display characters at the top and bottom left corners. Default is **Arial Unicode MS** (shipped with Microsoft Office up to 2013; also commercially available).

### Background (version 3.1 & above, used in Background Image)
* **BackgroundInitColor** – Select the background color. Default is white.
* **BackgroundInitScale** – Select the background scale factor.

### Columns (used in `TINSTALLEDFONTSFORM`)
* **Open Installed Fonts** – This numerical value changes the width.

### Edit (version 8.0 & above, used in Paste Special)
* **PasteSpecialAnchors** – This will paste anchors. Default is on.
* **PasteSpecialCodepoints** – This will paste codepoints. Default is on.
* **PasteSpecialCodepointsOption** – Choose whether to paste codepoints. Default is 0 (Keep same code-points).
* **PasteSpecialGlyphNames** – This will paste glyph names. Default is off.
* **PasteSpecialMetrics** – This will paste metrics. Default is on.
* **PasteSpecialMetricsOption** – Choose whether to paste metrics. Default is 0 (Side bearings).
* **PasteSpecialOutlineData** – This will paste outline data. Default is on.

### Exchange (version 13.0, used in Options: Exchange)
* **OutlineFormat** – Used with **Exchange Glyph Outlines: Preferred outline format**. Default is Don't change it, but use quadratic with new contours.

### Externals (version 7.0 & above, used in Tools: Launch Externals)
**MainType** (version 5.6 & above, if installed), **Fonts Folder** (not the same folder in Control Panel) and **Character Map** (can be removed in Windows 9x, ME and XP via **Control Panel: Add/Remove Programs: Add/Remove Windows Features: Components: Accessories and Utilities: Accessories: Character Map**, in Windows 2000 as administrator by deleting `charmap.exe` – executable file and `charmap.chm`/`charmap.hlp` – help documentation and in Windows Vista & above as administrator or `NT SERVICE\TrustedInstaller` by taking ownership, modifying the permission entries and deleting `charmap.exe`/`charmap.exe.mui` – executable file and localized resources) are built-in to the program's menu.
* **Location#** – The last character has three values. Default is empty.
* **Title#** – The last character has three values. Default is **External #** whereas # is a number.

### Find (version 3.0 until 6.5, used in `TFINDFORM`)
* **FindLanguageID** – Select language identifier.
* **PlatformID** – Select **Platform** identifier in the Mapping tab.
* **PlatformSpecificEncodingID** – Select **Platform** specific encoding identifier in the Mapping tab.
* **TabIndex** – Changes tab in this form. Default is 0.

### FontOverview
* **CategoryWidth** – Changes the category splitter width.

### Fonts (used in Options: Font)
* **ExportDecomposeScaled** (version 12.0.0.2521 & above) – Used with **Export Font: Decompose composite glyphs with scaled components**. Default is on.
* **ExportExcludeLegacy** and **ExportExcludeLegacy2** – Used with **Export Font: Exclude legacy data**. Default is on (store naming fields in the Windows platform).
* **FontEnableOpenContours** (version 11.5.0.2421 & above) – **Special Features: Enable open contours** will allow you to design single line fonts. Default is off.
* **OpenFriendlyGlyphNames** (version 12.0.0.2521 & above) – **Open Font: Generate friendly glyph names (recommended)** will generate friendly glyph names on opening a font file. Default is on.

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
* **ShowToolbarWindowTransformation** – Show or hide the transformation toolbar with positioning/moving, rotating/mirroring, scaling/resizing and skewing features. Default is on.
* **ShowToolbarWindowValidation** (version 5.5 & above) – Show or hide the validation report (**Show Report** in the Glyph toolbar). Default is off.

### Grid
* **FixedGridColor** – Select the fixed grid color in Grid Options. Default is white.
* **FixedGridLineStyle** – Select the fixed grid line style in Grid Options. Default is solid.
* **GridColor** – Select the grid color in Grid Options. Default is sky blue.
* **GridDistance** – Used with **Minimum distance between grid points in units** in Grid Options.
* **GridDistancePixels** – Used with **Mininum distance between grid points in pixels** in Grid Options.
* **GridLineStyle** – Select the line style in Grid Options. Default is solid.
* **IncludeBaseline** (version 3.0 until 6.0) – Used with **Baseline** in the Metrics Options window. Default is on (in version 7.0 & above, it is always enabled for opened fonts).
* **IncludeLeftSideBearing** (version 3.0 until 6.0) – Used with **Left side bearing** in the Metrics Options window. Default is on (in version 7.0 & above, it is always enabled for opened fonts).
* **IncludeRightSideBearing** (version 3.0 until 6.0) – Used with **Right side bearing** in the Metrics Options window. Default is on (in version 7.0 & above, it is always enabled for opened fonts).
* **IncludeTypoAscender** (version 3.0 until 6.0) – Used with **TypoAscender** in the Metrics Options window. Default is off (in version 7.0 & above, it is always disabled for opened fonts).
* **IncludeTypoDescender** (version 3.0 until 6.0) – Used with **TypoDescender** in the Metrics Options window. Default is off (in version 7.0 & above, it is always disabled for opened fonts).
* **IncludeWinAscent** (version 3.0 until 6.0) – Used with **Win Ascent** in the Metrics Options window. Default is on (in version 7.0 & above, it is always enabled for opened fonts).
* **IncludeWinDescent** (version 3.0 until 6.0) – Used with **Win Descent** in the Metrics Options window. Default is on (in version 7.0 & above, it is always enabled for opened fonts).
* **IncludexHeight** (version 3.0 until 6.0) – Used with **x-Height** in the Metrics Options window. Default is on (in version 7.0 & above, it is always enabled for opened fonts).
* **IncludeYAxis** (version 3.0 until 6.0) – Used with **Y-Axis** in the Metrics Options window. Default is on (in version 7.0 & above, it is always enabled for opened fonts).
* **LockUserDefinedGuidelines** (version 4.5 & above) – Used with **Lock Guidelines** in the Grid toolbar. Default is off.
* **ShowBearings** (version 5.6 & above) – Used with **Show Metrics** in the Grid toolbar. Default is on.
* **ShowFixedGridLines** (version 5.6 & above) – Used with **Show reference lines at x = 0, y = 0** in Grid Options.
* **ShowGrid** – Used with **Show Grid** in Grid Options or the Grid toolbar. Default is on.
* **ShowUserDefinedGuidelines** – Used with **Show Guidelines** in Guidelines Options or the Grid toolbar. Default is on.
* **SnapToGrid** (version 1.1.3 & above) – Used with **Snap to Grid** in the Grid toolbar. Default is off.
* **SnapToUserDefinedGuidelines** (version 4.0 & above) – Used with **Snap to Guidelines** in the Grid toolbar. Default is off.

### GUI (used in Options: General)
* **UpdateCheckInterval** – Set this value in **Startup: Check for updates** to 000 (never), 001 (every day), 007 (once a week), 030 (once a month), 182 (twice a year) or 365 (once a year) to check for updates. Default is 007 (once a week).

### GuideLines (version 3.0 until 6.5)
* **Color** – Select the color. Default is black.
* **LineStyle** – Select the line style. Default is solid.

### ImportImage (used in Import Image)
* **BitmapPositionOrigin** – Used with the corner radio buttons in **Glyph: Position**. Default is 6 (center).
* **BitmapPositionType** – Select the **Bitmap Position Type**: 0 (Image) or 1 (Contours). Default is 1 (Contours).
* **Erode** – Used with **Erode – Dilate** in the Image tab. Default is No filter.
* **GlyphPositionX** – Set the X glyph position (**Position: X position** in the Glyph tab). Default is 0.
* **GlyphPositionY** – Set the Y glyph position (**Position: Y position** in the Glyph tab). Default is 0.
* **ImportMode** – Used with **Import Mode** in the Glyph tab - 0 (Trace) or 1 (Pixels). Default is 0 (Trace).
* **InvertBitmap** – Used with **Negative** in the Image tab - 0 (disabled) or 1 (enabled). Default is off.
* **MinimumPointsInContour** – Select the number of **Minimum Points** in the contour. Default is 6.
* **Multiplier** – Used with **Size: Multiplier** in the Image tab.
* **SmoothFilter** – Used with **Smooth Filter** in the Image tab - 0 (None), 1 (Smooth) or 2 (Super). Default is 1 (Smooth).
* **Threshold** – Used with **Threshold** in the Image tab. Default is 63 or 150.

### Install (version 3.0 until 6.5)
* **InstallFontsInFontsFolder** – **Install the font in Windows Fonts folder**. Default is on. On Windows Vista & above, the User Account Control shield is displayed before the label.

### InstalledFonts
* **PreviewHeight** – Set the font preview text height (version 5.5 & above). Default is 124.

### Interface (used in the toolbar context menu or View: Toolbars)
* **LockToolbars** (version 11.0 & above) – **Lock Docked Toolbars**. Default is off.
* **ShowUserNotes** – **Show User Notes**. Default is off.

### Interface Settings
* **ChildWindowState** – Contains the child window state.
* **CompleteCompositesAction** – Set to 1 (auto), 2 (anchor based), 3 (anchor based reposition) or 4 (composite data) to **Complete Composites**. Default is 1 (auto).
* **CustomNamingShowOutputContent** – Used by **Custom: Additional Naming Fields: Show Output Content** in the font properties window. Default is on.
* **ExportSettingsPage** – Select page in `TEXPORTSETTINGSFORM` and `TEXPORTSETTINGSFRAME`. Default is 0 (Desktop Font (ttf/otf)).
* **GlyphCaptionAuto** – Used with **Glyph Caption: Automatic** (Glyph Index) in the font overview context menu.
* **GlyphCaptionType** (old versions) or **GlyphCaptionType2** (recent versions) – Used with the font overview context menu captions options. Default is Auto.
* **GlyphDrawMode** – Set to 0 (monochrome), 1 (color) or 2 (auto). Default is 2 (auto).
* **GlyphFillAlpha** (version 11.0.0.2365 & above) – Used with **View: Fill Outline**. Default is solid.
* **GlyphNamesHistoryReplace** (version 11.0.0.2365 & above) – Contains the history of replaced PostScript glyph names in `TGLYPHNAMEFORM`. Default is blank.
* **GlyphNamesHistorySearch** (version 11.0.0.2365 & above) – Contains the history of searched PostScript glyph names in `TGLYPHNAMEFORM`. Default is blank.
* **GlyphNamesOptionsCS** – Used with **Options: Case sensitive** in `TGLYPHNAMEFORM`. Default is on.
* **GlyphNamesOptionsRE** – Used with **Options: Regular expressions** in `TGLYPHNAMEFORM`. Default is off.
* **GlyphOutlineFillMode** – Used with **Interface: Glyph outline fill mode** in Options: General. Default is 0 (Winding).
* **GlyphPropsExpanded** – Expand glyph properties via the **More** button at the bottom left corner. Default is on.
* **GroupManagerSorted** – Sorts the group manager.
* **InsertGlyphsCB1** and **InsertGlyphsCB2** (version 12.0 & above) – Used by `TINSERTGLYPHFORM` to insert glyphs at the top (0), after the last glyph (1), before (2) or after selected glyphs (3). Default is 3 (after selected glyphs).
* **InsertGlyphsPage** (version 12.0 & above) – Select the tab in the insert glyph window. Default is insert by glyph name.
* **InsertGlyphsRanges** – Used to insert glyph ranges.
* **KerningFolderExport** – Select the directory to export the legacy `KERN` table.
* **KerningFolderImport** – Select the directory to import the legacy `KERN` table.
* **NewFontIncludeOutlines** (version 5.6 & above) – Used with **Predefined outlines: Include outlines** in the New Font window (the outlines are from Garava). Default is on.
* **OpenDialogInitialDir2** – Contains the directory in the Open dialog. Default is user's font folder.
* **OpenDialogInitialDirAutoKerning** (version 2.0 until 6.5) – Contains the directory in the Open dialog from the AutoKern Wizard.
* **OpenDialogInitialDirImportImage2** – Contains the directory in the Open dialog from Import Image.
* **OpenDialogInitialDirNamingField2** – Contains the directory in the Open dialog from `TADDCUSTOMNAMINGFORM`. Default is desktop.
* **OpenDialogInitialDirTransform3** – Contains the directory in the Open dialog from `TPERFORMTRANSFORMATIONFORM`. Default is the program's transform folder.
* **OptionsPage** – Select the tab in the options window. Default is 0 (General).
* **OTLFDesignerCollapsedFeatures** – Contains features collapsed in the OpenType Designer.
* **OTLFDesignerCollapsedLookups** – Contains lookups collapsed in the OpenType Designer.
* **OTLFDesignerCollapsedScripts** – Contains scripts collapsed in the OpenType Designer.
* **OTLFDesignerPairFilterFirst** – Contains the preceding character to filter kerning pairs.
* **OTLFDesignerPairFilterSecond** – Contains the succeeding character to filter kerning pairs.
* **OTLFDesignerPairKindFirst** – Filters the first kerning pair kind.
* **OTLFDesignerPairKindSecond** – Filters the last kerning pair kind.
* **OTLFDesignerPreviewLanguage** – Selects the language to use in the preview text. Default is **Auto**.
* **OTLFDesignerPreviewSampleText** – Contains sample text used in the preview text. Default is **The five boxing wizards jump quickly**.
* **OTLFDesignerPreviewScript** – Selects the script to use in the preview text. Default is **Auto**.
* **OTLFDesignerSingleFilter** – Used for single filter in the OpenType Designer.
* **OTLFDesignerSingleKind** – Used for single kind in the OpenType Designer.
* **OTLFEditor** – Changes the font, displays line numbers or wraps words in the OpenType Feature Code Editor.
* **OverviewColCat** – Contains the column categories used in the font overview.
* **OverviewFontZoom** – Zoom glyphs in the font overview. Default is 35.
* **OverviewGridZoom** – Zoom the grid in the font overview.
* **OverviewSampleFont** (version 4.0 & above) – Used with **Font Overview: Font used in cells** in Options: View. Default is **Arial**. Empty strings will show the characters in **MS Sans Serif**.
* **OverviewShowCaption** (version 3.0 until 6.5) – Used with **Font overview: Show caption** in Options: Overview. Default is on.
* **OverviewShowSample** – Used with **Font Overview: Show sample in empty glyphs** in Options: Overview. Default is on.
* **OverviewSingleHeight** (version 3.0 until 6.5) – Used with **Font overview: Glyph height** in Options: Overview. Default is 48.
* **OverviewSingleWidth** (version 3.0 until 6.5) – Used with **Font overview: Glyph width** in Options: Overview. Default is 70.
* **OverviewSmoothGlyphs** – Used with **Font overview: Smooth glyphs** in Options: Overview. Default is off.
* **OverviewUndoLimitMaxCount** – Used with **Undo limits: Max. count** in Options: Edit. Default is 1.
* **OverviewUndoLimitMaxSize** – Used with **Undo limits: Max. size [KB]** in Options: Edit. Default is 1.
* **OverviewUseColor** (version 3.0 until 6.5) – Used with **Font overview: Use type color in glyph caption** in Options: Font. Default is on.
* **SampleFileName** – Used with **Samples Toolbar Font: Filename** in Options: General. Default is empty. The sample glyphs are from Garava (Designed by Bhikkhu Pesala in 2003) and Times New Roman (Designed by Stanley Morison for Monotype Imaging Inc. in 19).
* **SampleSingleHeight** (version 3.0 until 6.5) – Used with **Samples Toolbar: Glyph height** in Options: Sample. Default is 55.
* **SampleSingleWidth** (version 3.0 until 6.5) – Used with **Samples Toolbar: Glyph width** in Options: Sample. Default is 62.
* **SaveDialogInitialDirNew2** – Select the directory in the save dialog.
* **SelectCompositeCaptionType** – Changes caption used in the select composite glyph member window. Default is 0 (glyph name).
* **SelectCompositeFontZoom** – Scale the glyphs in the select composite glyph member window.
* **SelectCompositeGridZoom** – Scale the grid in the select composite glyph member window.
* **SettingsPage** – Changes tab in the Options window. Default is 0 (Identification).

### Kerning
* **AutoKerningAllowForPositiveKerningValues** – Used with **Additional Options: Allow for positive kerning values** in the AutoKern Wizard.
* **AutoKerningExcludeLowerLower** (version 11.0 & above) – Used with **Exclude lowercase-lowercase pairs** in the AutoKern Wizard.
* **AutoKerningExcludeLowerUpper** – Used with **Exclude lowercase-uppercase pairs** in the AutoKern Wizard.
* **AutoKerningImportFilename** – Contains the file to import kerning pairs.
* **AutoKerningMinAbsKernValue** – This corresponds to numerical strings for the **Additional Options: Minimum absolute kerning value** in the AutoKern Wizard.
* **AutoKerningReplaceKerning** – Used with **Additional Options: Replace existing kerning when** dropdown box in the AutoKern Wizard.
* **AutoKerningReplacePercentage** – Used with **Additional Options: Replace existing kerning when** slider in the AutoKern Wizard.
* **AutoKerningUseBaseMetrics** – Used with **Composite glyphs follow base glyphs (use this glyph's metrics)** in the the AutoKern Wizard. Default is on.
* **AutoKerningWhiteSpace** – Used with **Additional Options: White space between characters** in the AutoKern Wizard.
* **KerningColorBackground** – Select the background color. Default is white.
* **KerningColorBaseline** – Select the baseline color. Default is red.
* **KerningColorFirst** – Select the preceding glyph color. Default is dark blue.
* **KerningColorGridLines** – Select the grid lines color. Default is gray.
* **KerningColorSecond** – Select the succeeding glyph color. Default is dark green.
* **KerningShowBaseLine** – Displays baseline. Default is on.
* **KerningShowBearingLines** – Displays bearing lines. Default is on.
* **KerningShowGridLines** – Displays grid lines. Default is on.

### Last Time, Most Recently Used Files, Most Recently Used Projects
* **File_#** – Include fonts and/or projects opened last time or recently used in the **File: Reopen** menu whereas # is a number. Old versions stores up to 7 files while recent versions stores up to 26 fonts and 10 projects. The menu will appear empty (new versions) or dimmed (old versions) if the above keys are removed or if **Clear file list** is selected from the menu. When opening a non-existing file prior to version 7.0 (not newer versions), the entry is removed.

### Metrics (used in the Automatic Metrics Wizard)
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

### MetricsAndKerning (used in the Comparison toolbar; replaced by the Text Editing tool in version 14)
* **MetricsAndKerningKerningEnabled** – Enable or disable the legacy `KERN` table (version 3.0 until 6.5) or OpenType features (version 7.0 & above). Default is off.
* **MetricsAndKerningTextEnabled** – Used with **Show text before and after glyph** (version 5.0 & above). Default is off.
* **MetricsAndKerningTextLeft** – Contains characters in the **Before** text box (version 5.0 & above). Default is empty.
* **MetricsAndKerningTextRight** – Contains characters in the **After** text box (version 5.0 & above). Default is empty.

### Most Recently Used Files, Most Recently Used Projects
* **File_#** – Lists the font and project file names in the **File: Reopen** menu (# is a number). The menu will appear dimmed if deleted or if **Clear recent file lists** is selected under this menu.

### OpenType Designer (version 7.0 & above)
* **FillGlyphOutlines** – Used with **Colors: Fill glyph outlines** in the settings window. Default is on.
* **GlyphFillColor** – Used with **Colors: Glyph fill color** in the settings window. Default is off.
* **LayoutMode** – Select the layout mode. Default is 0.
* **MarkWidth** – Set the mark width. Default is 240.
* **PairWidth** – Set the pair width. Default is 145.
* **PreviewHeight** – Set the preview text height. Default is 120.
* **PreviewSampleFontSize** – Scale the preview sample. Default is 32.
* **SimpleWidth** – Set the simple width. Default is 145.
* **SingleWidth** – Set the single width. Default is 145.
* **TreeWidth** – Set the tree width. Default is 320.
* **ZoomFactor** – Zooms the OpenType Designer. Default is 12.

### OpenType Generator (version 12.0.0.2521 & above, used in the feature settings window)
Default is on for all keys beginning with “Include”. Other features (e.g. half forms or distances for Indic scripts) have no inclusion options; use the add button at the top left corner of the OpenType Designer or the OpenType Layout Feature Editor to create the tables manually.
* **CPSPKind** – Used with the **Spacing and Positioning: Capital Spacing (cpsp)** dropdown box. Default is 0 (Percentage of advance width).
* **CPSPPerc** – Contains the percentage of advance width used by the **Spacing and Positioning: Capital Spacing (cpsp)** spinner. Default is 5%.
* **IncludeAalt** – Used with **Other Forms and Variants: Access All Alternates (aalt)**. It generates lookups for glyphs used by other OpenType features (e.g. Unicase - unic).
* **IncludeAltFractions** – Used with **Numerals: Alternative Fractions (e.g. stacked) (afrc)**. It generates lookups for pre-composed fractions in the *Latin-1 Supplement* and *Number Forms* blocks of Unicode and any unencoded fractions.
* **IncludeAnchorBased** – Used with **Spacing and Positioning: Anchor Based Positioning (ccmp, mark, mkmk)**. To generate this feature, each letter should have anchors. Example fonts including all three features are e.g. Arial (Windows Vista & above) and [Roboto](https://github.com/googlefonts/roboto-3-classic) (missing anchors for e.g. capital open O, capital M hook, etc. etc. etc.). The `mark` and `mkmk` features are used by e.g. many African (Yoruba, Lingala, Ewe, Wolof, Dagaare, Tammari, etc. etc. etc.) and Native American languages (Navajo, Kwakiutl, Choctaw, Dakota, Lakota, Heiltsuk, Kwakwala, Liqwala, etc. etc. etc.), phonetic transcription (IPA and UPA) and zalgo text.
* **IncludeCapitalSpacing** – Used with **Spacing and Positioning: Capital Spacing (cpsp)**. Fullwidth Latin characters are not included. Don't include this feature in monospaced or pixel fonts!
* **IncludeCase** – Used with **Other Forms and Variants: Case-Sensitive Forms (case)**. This feature moves the position of some punctuation marks, e.g. inverted exclamation point or question mark and brackets to the CapHeight position. Example font without the feature: System VIO from OS/2 (with the characters at the CapHeight position).
* **IncludeCharacterVariants** – Used with **Other Forms and Variants: Character Variants (cv01-cv99)**. [Bhikkhu Pesala](http://www.softerviews.org/Fonts.html) uses this feature in his fonts for ! * + @ © × † ‡ • ○ ● ☀.
* **IncludeCursive** – Used with **Spacing and Positioning: Cursive Positioning (curs)** for use with connecting script fonts (e.g. Brush Script MT, Script MT Bold, Bickham Script Pro, Lucida Handwriting, etc. etc. etc.).
* **IncludeDlig** – Used with **Other Forms and Variants: Discretionary Ligatures (dlig)**.
* **IncludeFina** – Used with **Terminal Forms (fina, fin2, fin3)**. This feature uses terminal characters from the *Arabic* ranges of Unicode if the glyphs exist. The last two features are used only for Syriac. [Bhikkhu Pesala](http://www.softerviews.org/Fonts.html) uses the feature in his fonts to replace the Greek sigma (σ) with a final sigma (ς) at the end of words, not stigma (Ϛϛ).
* **IncludeFractions** – Used with **Numerals: Fractions (diagonal) (frac, dnom, numr)**. The `frac` feature uses precomposed vulgar fractions from the *Latin-1 Supplement* and *Number Forms* ranges of Unicode as well as unencoded vulgar fractions if the glyphs exist. The Garava font was used for the feature in the preview as shown in the manual.
* **IncludeFractionsAdv** – Used with **Numerals: Fractions (diagonal) (frac, dnom, numr): Extended (smart math format)**.
* **IncludeHlig** – Used with **Other Forms and Variants: Historical Ligatures and Historical Forms (hlig, hist)**. The `hist` feature uses the long s from the *Latin Extended-A* range of Unicode. The `hlig` feature uses ſt from the *Alphabetic Presentation Forms* range of Unicode and ligatures that are made up of glyphs beginning with ſ if the PostScript names in each glyph have `longs` followed by the underscore. [Bhikkhu Pesala](http://www.softerviews.org/Fonts.html) uses this feature in his fonts to substitute Roman numerals.
* **IncludeInit** – Used with **Initial Forms (init)**. This feature uses initial characters from the *Arabic* ranges of Unicode if the glyphs exist.
* **IncludeIsol** – Used with **Isolated Forms (isol)**. This feature uses isolated characters from the *Arabic* ranges of Unicode if the glyphs exist.
* **IncludeLiga** – Used with **Other Forms and Variants: Standard Ligatures (liga)**. This feature uses the first five Latin characters from the *Alphabetic Presentation Forms* range of Unicode. The Mandala font was used for the feature as shown in the Enrich Your Fonts With OpenType Features tutorial. Don't include this feature in monospaced fonts without programming ligatures (e.g. Helvetica Monospaced, Nimbus Sans Mono, Harmonia Sans Mono, Prima Sans Mono, SST Typewriter, etc. etc. etc.) or with programming ligatures (e.g. Cascadia Code, Fira Code, etc. etc. etc.)! Example font without this feature: Agency FB from Microsoft products (the ff, ffi and ffl ligatures are unmapped)
* **IncludeLnum** – Used with **Numerals: Lining Figures (lnum)**. Glyphs with `.lnum` at the end of PostScript names should be present to generate this feature.
* **IncludeLoclCommon** – Used with **Localized Forms (locl): Common Localized Forms (CAT, NLD, TRK, ROM)**. This feature is used for Catalan (`CAT`) to replace l· with the character from *Latin Extended-A*, Dutch and Flemish (`NLD` and `FLE`) to replace ij and íj́ with its own ligatures, Turkish (`TRK`) and other Turkic languages to replace i for case sensitivity and Romanian or Moldavian (`ROM` or `MOL`) to replace ş and ţ (cedilla) with ș and ț (comma). [Bhikkhu Pesala](http://www.softerviews.org/Fonts.html) originally used this feature in his fonts to substitute Roman numerals. He used the `hlig`/`hist` feature instead in his fonts.
* **IncludeLoclCustom** – Used with **Localized Forms (locl): Custom Localized Forms (loclLANG)**. Used for some languages, e.g. to change the acute in áéíóú (őű) for Hungarian (`HUN`) or ćńóśź for Polish (`POL`), change letter designs in Bulgarian (`BGR`) or to use tighter thin space metrics in French (`FRA`). The Munson Roman font was used in the OpenType Designer using s acute for Polish localized forms, both uppercase and small caps as shown in the manual. [Bhikkhu Pesala](http://www.softerviews.org/Fonts.html) originally used this feature in his fonts to substitute Roman numerals.
* **IncludeMedi** – Used with **Medial Forms (medi, med2)**. This feature uses medial characters from the *Arabic* ranges of Unicode if the glyphs exist. The second feature is used only for Syriac if the glyphs exist.
* **IncludeNalt** – Used with **Other Forms and Variants: Alternate Annotation Forms (nalt)**. This feature uses either glyphs with a `.nalt` suffix or circled characters from the *Enclosed Alphanumerics* block and initial, isolated, medial or terminal characters from the *Arabic* ranges of Unicode if the glyphs exist. The Verajja font was used in the OpenType Designer using the number six as shown in the manual.
* **IncludeOnum** – Used with **Numerals: Oldstyle Figures (onum)**. Glyphs with `.onum` at the end of PostScript names should be present to generate this feature. The Mandala font was used for the feature as shown in the Enrich Your Fonts With OpenType Features tutorial.
* **IncludeOrdinals** – Used with **Other Forms and Variants: Ordinals (ordn)**. It creates a numero substitution (capital N and small o with or without full stop) if the glyph exists in the *Letterlike Symbols* block of Unicode and substitutions for letters and numbers.
* **IncludeOrdinalsExt** – Used with **Other Forms and Variants: Ordinals (ordn): Extended (use .ordn or .sups for all letters)**. If no glyphs that end with `.ordn` or `.sups` are found, it creates substitutions for a to ª and o to º if these glyphs exist.
* **IncludeOrnaments** – Used with **Other Forms and Variants: Ornaments (ornm)**. The first method uses the bullet. [Bhikkhu Pesala](http://www.softerviews.org/Fonts.html) uses this feature in his fonts to replace bb, bp, bq, wk and wr by chess pieces.
* **IncludePetiteCapitals** – Used with **Other Forms and Variants: Petite Capitals (pcap, c2pc)**. [Bhikkhu Pesala](http://www.softerviews.org/Fonts.html) uses a subset for this feature in his fonts, including only common punctuation and the Latin, Greek and Cyrillic alphabets with diacritics for Classical Sanskrit (not Vedic Sanskrit with additional diacritics like ā́ī́ḷ́l̃m̐ṝ́ū́).
* **IncludePnum** – Used with **Numerals: Proportional Figures (pnum)**. Glyphs with `.pnum` at the end of PostScript names should be present to generate this feature.
* **IncludeSalt** – Used with **Other Forms and Variants: Stylistic Alternates (uses ss01) (salt)**. [Bhikkhu Pesala](http://www.softerviews.org/Fonts.html) uses this feature as a contextual substitution to substitute only the first word's capital letter in Cankama, Garava, Jivita, Lekhana, Mandala, Odana, Pali, Sukhumala, Talapanna, and Verajja for decorative drop capitals. Example font without the feature using unencoded glyphs: Agency FB from Microsoft products.
* **IncludeSinf** – Used with **Numerals: Scientific Inferiors (sinf)**.
* **IncludeSmallCapitals** – Used with **Other Forms and Variants: Small Capitals (scap, c2sc)**. [Bhikkhu Pesala](http://www.softerviews.org/Fonts.html) uses a subset for this feature in his fonts, including only the Latin, Greek and Cyrillic alphabets and punctuation with diacritics for Classical Sanskrit (not Vedic Sanskrit with additional diacritics like ā́ī́ḷ́l̃m̐ṝ́ū́). The [TITUS Cyberbit Basic font](http://titus.uni-frankfurt.de/unicode/unitest2.htm) includes only glyphs for the Latin alphabet, numbers and þḃḋḟġḣk̇l̇ṁṅṗṙṡṫḅḍg̣ḷṃṇṛṣṭ (without this feature). Most fonts use their own glyphs (e.g. Letter Gothic Std, Lithos Pro, Trajan Pro, etc. etc. etc. from Adobe products).
* **IncludeStylisticSets** – Used with **Other Forms and Variants: Stylistic Sets (ss01-ss20)**. [Bhikkhu Pesala](http://www.softerviews.org/Fonts.html) uses a contextual substitution for decorative drop capitals in Cankama, Garava, Jivita, Lekhana, Mandala, Odana, Pali, Sukhumala, Talapanna and Verajja (colored). The IBM Plex Sans font was used for the feature as shown in the Enrich Your Fonts With OpenType Features tutorial.
* **IncludeSubs** – Used with **Other Forms and Variants: Subscript (subs)**. The [TITUS Cyberbit Basic font](http://titus.uni-frankfurt.de/unicode/unitest2.htm) includes only numbers, some Latin letters, punctuation and äīùú (without the OpenType feature).
* **IncludeSups** – Used with **Other Forms and Variants: Superscript (sups)**. [Bhikkhu Pesala](http://www.softerviews.org/Fonts.html) uses a subset in his fonts as either (1) the Latin alphabet, numbers, common punctuation/mathematical symbols and spacing accents, with Latin-1 and Classical Sanskrit (not Vedic Sanskrit with additional diacritics like ā́ī́ḷ́l̃m̐ṝ́ū́) diacritics (Garava) or (2) the Latin alphabet, numbers, è and ú (other fonts). The [TITUS Cyberbit Basic font](http://titus.uni-frankfurt.de/unicode/unitest2.htm) includes only numbers, some Latin letters and punctuation and äi̯ıu̯ü (without the OpenType feature).
* **IncludeSwsh** – Used with **Other Forms and Variants: Swash (swsh)**. [Bhikkhu Pesala](http://www.softerviews.org/Fonts.html) colorized the glyphs in his fonts. Most fonts include glyphs only for capital letters in italics (e.g. Times New Roman from Windows 8–11 or Minion Pro from Adobe products).
* **IncludeTitl** – Used with **Other Forms and Variants: Titling (titl)**. Most fonts uses its own glyphs (e.g. Perpetua Titling MT).
* **IncludeTnum** – Used with **Numerals: Tabular Figures (tnum)**. Glyphs with `.onum` at the end of PostScript names should be present to generate this feature.
* **IncludeZero** – Used with **Numerals: Slashed Zero (zero)**. Most fonts use the slashed zero by default (e.g. Roboto Mono, Sweden Sans, Menlo, PT Mono, Noto Sans Mono, etc. etc. etc.). The Mandala font was used for the feature as shown in the Enrich Your Fonts With OpenType Features tutorial.

### OpenType Proofing (version 13.0 & above, used in `TOPENTYPEDESIGNERPROOFINGFORM`)
* **Compact** – Default is on.
* **Filter** – Default is on.
* **FontSize** – Scale the font. Default is 32.
* **PreviewHeight** – Changes the preview area height. Default is 120.
* **SpecialFill** – **Special Fill**. Default is on.

### Options
* **AlwaysCreateBackupCopy** (version 4.0 until 6.5) – Used with **Create backup copy (bck) on saving a font project** in Advanced: Options. Default is off.
* **AutoFitGlyphInWindow** – Used with **Glyph Edit Window: Auto fit glyph in Window** in Options: Glyph. Default is on.
* **AutoNamingUseFontRevision** (version 4.0 until 6.5) – Used with **Automatic Naming Wizard: Version String: use Font revision version from Font Settings → Header page** in Options: Naming. Default is on.
* **CompressHmtxTable** (version 4.0 until 6.5) – Used with **When Saving Font Files: Compress hmtx table** in Options: Font. Default is on.
* **CompressNameTable** (version 4.0 until 6.5) – Used with **When Saving Font Files: Optimize name table** in Options: Font. Default is on.
* **DefaultNamingCopyrightIncluded** – Used with **Default Settings for New Fonts: Copyright Notice** in Options: Personalize. Default is on.
* **DefaultNamingCopyrightText** – Used with **Default Settings for New Fonts: Copyright Notice** in Options: Personalize. Default is **Typeface © (your company). &lt;year&gt;. All Rights Reserved.** The &lt;year&gt; placeholder in the default string is replaced with the current year from the computer's date.
* **DefaultNamingFontDesignerIncluded** – Used with **Default Settings for New Fonts: Designer** in Options: Personalize. Default is off.
* **DefaultNamingFontDesignerLinkIncluded** – Used with **Default Settings for New Fonts: Designer URL** in Options: Personalize. Default is off.
* **DefaultNamingFontDesignerLinkText** – Used with **Default Settings for New Fonts: Designer URL** in Options: Personalize. Default is http://www.yoursite.com/fontdesigner.html (the file is non-existent).
* **DefaultNamingFontDesignerText** – Used with **Default Settings for New Fonts: Designer** in Options: Personalize. Default is empty.
* **DefaultNamingLicenseAgreementIncluded** – Used with **Default Settings for New Fonts: License Agreement** in Options: Personalize. Default is off.
* **DefaultNamingLicenseAgreementLinkIncluded** – Used with **Default Settings for New Fonts: License URL** in Options: Personalize. Default is off.
* **DefaultNamingLicenseAgreementLinkText** – Used with **Default Settings for New Fonts: License URL** in Options: Personalize. Default is http://www.yoursite.com/licenseagreement.html (the file is non-existent).
* **DefaultNamingLicenseAgreementText** – Used with **Default Settings for New Fonts: License Agreement** in Options: Personalize. Default is empty.
* **DefaultNamingTrademarkIncluded** – Used with **Default Settings for New Fonts: Trademark** in Options: Personalize. Default is off.
* **DefaultNamingTrademarkText** – Used with **Default Settings for New Fonts: Trademark** in Options: Personalize. Default is **&lt;font family&gt;® Trademark of (your company)**. The &lt;font family&gt; placeholder in the default string is replaced with the actual font name.
* **DefaultPersFontEmbeddingItemID** (version 8.0 & above) – Used with **Default Settings for New Fonts: Embedding Licensing Rights** in Options: Personalize. Default is 1 (Editable (read-write)).
* **DefaultPersVendorIDText** (version 8.0 & above) – Used with **Default Settings for New Fonts: Vendor ID** in Options: Personalize. Default is **HL**.
* **DefaultPersVendorText** (version 8.0 & above) – Used with **Default Settings for New Fonts: Vendor** in Options: Personalize. Default is **High-Logic / Made with FontCreator**.
* **DefaultPersVendorURLText** (version 8.0 & above) – Used with **Default Settings for New Fonts: Vendor URL** in Options: Personalize. Default is empty.
* **DefaultVendorIDIncluded** (version 8.0 & above) – Used with **Default Settings for New Fonts: Vendor ID** in Options: Personalize. Default is off.
* **DefaultVendorIncluded** (version 8.0 & above) – Used with **Default Settings for New Fonts: Vendor** in Options: Personalize. Default is off.
* **DefaultVendorURLIncluded** (version 8.0 & above) – Used with **Default Settings for New Fonts: Vendor URL** in Options: Personalize. Default is off.
* **DefaultZoomFactor** – Used with **Glyph Edit Window: Open with default zoom factor** in Options: View.
* **ExcludeMonospacedFonts** – Used with **When Saving Font Files: Exclude monospaced fonts** in Options: Font. Default is off.
* **IgnoreHintingData** – Used with **When Opening Font Files: Remove hinting data** in Options: Font. Default is off. Recent versions use [ttfautohint](https://freetype.org/ttfautohint/) for automatic hinting (enabled by default when exporting font projects).
* **IgnoreUnsupportedTables** – Used with **When Opening Font Files: Remove unsupported tables** in Options: Font. Default is off.
* **LastUpdateReminderDate** (`LastUpdateCheck` in `HKCU\Updates` in recent versions) is the date used when **Startup: Show update reminder** in Options: General is enabled.
* **LeftSideBearingExcludeLargeFonts** (version 4.0 until 6.5) – Used with **When Saving Font Files: Set left side bearing point at x=0: Exclude large (1500+) fonts** in Options: Font. Default is on.
* **LongAlignedLocalOffsets** – Used with **When Saving Font Files: Long-aligned local offsets** in Options: Font. Default is on.
* **OnStartupOpenFonts** (version 5.6 & above) – Used with **Startup: On start open fonts from last time** in Options: General to open fonts from the `Last Time` registry key. Default is on.
* **OnStartupShowUpdateReminder** (`UpdateCheckInterval` in `GUI` in recent versions) – Set this value in **Startup: Show update reminder** in Options: General to 0 (never), 1 (once a year), 2 (twice a year) or 3 (once a month). Default is 1 (once a year).
* **OnStartupShowWelcome** – Used with **Startup: On start show Welcome dialog** in Options: General. Default is on.
* **PanoseValueHexadecimal** (version 5.6 & above) – Used with **PANOSE: Value: Show hexadecimal** in Font Settings: Characteristics. Default is off.
* **RecalcAverageCharWidth** – Used with **When Saving Font Files: Recalc average char width** in Options: Font. Default is on.
* **RecalcGlyphBoundingBoxes** – Used with **When Saving Font Files: Recalc glyph bounding boxes** in Options: Font. Default is off.
* **RemoveDSIGTable** (version 4.0 until 6.5) – Used with **When Opening Font Files: Remove DSIG table** in Options: Font (ignored by FontForge when opening fonts). Default is off. The table can be included when exporting fonts.
* **RemoveHdmxTable** (version 4.0 until 6.5) – Used with **When Opening Font Files: Remove hdmx table** in Options: Font (ignored by FontForge when opening fonts). Default is on.
* **RemoveLTSHTable** (version 4.0 until 6.5) – Used with **When Opening Font Files: Remove LTSH table** in Options: Font (ignored by FontForge when opening fonts). Default is on.
* **RemoveVDMXTable** (version 4.0 until 6.5) – Used with **When Opening Font Files: Remove VDMX table** in Options: Font (ignored by FontForge when opening fonts). Default is on.
* **SetLeftSideBearingPointAtX0** (version 4.5 & above) – Used with **When Saving Font Files: Set left side bearing point at x=0** in Options: Font. Default is on.
* **UnicodeEnabledGUI** (version 5.5 until 6.5) – Used with **Unicode Support: Enable Unicode support for text display and user input** in Options: General. Default is on. In Windows 9x/ME (ran natively or with compatibility filters applied), the option will appear dimmed.
* **UpdateModifiedDateTimeField** (version 3.0 until 6.5) – Used with **Identification: Automatically update modified timestamp when exporting font** in Font Settings: Identification. Default is on (since version 7.0 & above it is enabled for any opened font).
* **ValueHexadecimal** – Used with **View: Display Format: Values: Hexadecimal**. Default is on. **Fun fact:** Hexadecimal values in Delphi are usually given with a dollar sign ($).
* **VectorImageEPSForceRepositioning** (version 6.0 & above) – Used with **Vector Based Images (EPS, AI, PDF, SVG): Move imported outlines to origin (0,0)** in Options: Exchange. Default is off.
* **VectorImageEPSOriginX** (version 6.0 & above) – Used with **Vector Based Images (EPS, AI, PDF, SVG): Origin X** in Options: Exchange. Default is 100.00.
* **VectorImageEPSOriginY** (version 6.0 & above) – Used with **Vector Based Images (EPS, AI, PDF, SVG): Origin Y** in Options: Exchange. Default is 600.00.
* **VectorImageEPSPixelsPerEm** (version 6.0 & above) – Used with **Vector Based Images (EPS, AI, PDF, SVG): Pixels per em** in Options: Exchange. Default is 512.00.

### Preview
* **FeaturesWidth** (version 7.0 & above) – Changes width in the OpenType feature splitter.
* **FeatureTags** (version 7.0 & above) – Contains the tags to use OpenType features. Default is empty.
* **PreviewFeatures** (version 7.0 & above) – Enables or disables the OpenType features to use in the preview text.
* **PreviewFontSize** – Scale the font in the test font window.
* **PreviewPosHeight** (version 3.0 until 4.5) – Contains the height in the preview window.
* **PreviewPosLeft** (version 3.0 until 4.5) – Contains the left position in the preview window.
* **PreviewPosTop** (version 3.0 until 4.5) – Contains the top position in the preview window.
* **PreviewPosWidth** (version 3.0 until 4.5) – Contains the width in the preview window.
* **PreviewSampleFontSize** – Scale the font in the Preview window. Default is 24.
* **PreviewSampleText** – Contains sample text in the Preview window. Default is **High-Logic ©** (old versions) or **&lt;enter preview text here&gt;**.
* **PreviewSampleUseKerning** (version 3.0 until 6.5) – Use the legacy KERN table in the Preview window.
* **ShowToolbarWindowPreview** – Show or hide the Preview window. Default is on.
* **StrikeThrough** – Strikes out text in the test font window. Default is off.
* **Underline** – Underlines text in the test font window. Default is off.

### Reg
Many people and companies provided registration keys for cracked or illegal versions. The **Clr** button in the About dialog (see **RC Data in the executable file** below) will ask the user to remove the registration information.
* **V5D#** – The # at the end is a number. After registering, it adds your name to the title bar (version 6.0 & above), removes the **Register** button in the Tip of the Day (version 1.0 until 6.5), hides the **Buy** menu and the **Help: Register** menu item and shows the **Developer Tools** menu (version 12.0 & above) if it's not hidden in the executable file.

### Themes (version 3.0 until 6.5)
* **ActiveTheme** – Contains the active theme. In FontCreator 13 and higher, use the theme option from the view menu to choose either auto, the light or dark themes or the Windows theme. Default is auto.

### Tip of the Day (version 3.0 until 6.5)
* **CurrentTip** – Line number in `FontCreator.tip` (it goes to the next line when closed). Default is the first line.
* **ShowTipOnStartup** – Shows the dialog itself when starting FontCreator. Default is on.

### Validation
* **DiagonalRedundantOffCurvePointsDetection** – Used with **Diagonal redundant points detection: Maximum off-curve distance** in Options: Validation. Default is off.
* **DiagonalRedundantOnCurvePointsDetection** – Used with **Diagonal redundant points detection: Maximum on-curve distance** in Options: Validation. Default is off.
* **EnableGlyphProblemDetection** – Used with **Enable Real-Time** in the Validation toolbar. Default is on.
* **LocalExtremeCoordinatesDetection** – Used with **Off-curve extreme coordinates: Local detection** in Options: Validation. Default is on.
* **MaximumRedundantOffCurvePointsDistance** – Used with **Diagonal redundant points detection: Maximum off-curve distance** spinner in Options: Validation. Default is 0.20.
* **MaximumRedundantOnCurvePointsDistance** – Used with **Diagonal redundant points detection: Maximum on-curve distance** spinner in Options: Validation. Default is 0.80.
* **ShowIntersection** – Used with **Show Intersecting** in the Validation toolbar. Default is on. If the glyph exceeds the maximum number of composite glyph members, contours or points during real-time validation (i.e. it is too complex), the button will appear dimmed.
* **ShowWarningPoints** – Used with **Show Warning Points** in the Validation toolbar. Default is on. If the glyph exceeds the maximum number of composite glyph members, contours or points during real-time validation (i.e. it is too complex), the button will appear dimmed.
* **TestContoursWithIncorrectDirection** – Used with **Validation Tests: Contours with incorrect direction** in the Validation Wizard. Default is on.
* **TestContoursWithOneOrTwoPoints** – Used with **Validation Tests: Contours with one or two points** in the Validation Wizard. Default is on.
* **TestDuplicateComponents** – Used with **Validation Tests: Duplicate components** in the Validation Wizard. Default is on.
* **TestDuplicateContours** – Used with **Validation Tests: Duplicate contours** in the Validation Wizard. Default is on.
* **TestDuplicateKnots** – Used with **Validation Tests: Duplicate knots** in the Validation Wizard. Default is on.
* **TestEmptyComponents** – Used with **Validation Tests: Empty components** in the Validation Wizard. Default is on.
* **TestFixDetectedProblems** (version 4.1 & above) – Used with **Fix detected problems** in the Validation Wizard. Default is off.
* **TestIntersectingComponents** – Used with **Validation Tests: Intersecting components** in the Validation Wizard. Default is on.
* **TestIntersectingCoordinates** – Used with **Validation Tests: Intersecting coordinates** in the Validation Wizard. Default is on.
* **TestOffCurveExtremeCoordinates** – Used with **Validation Tests: Off-curve extreme coordinates** in the Validation Wizard. Default is on.
* **TestOverlappingComponents** – Used with **Validation Tests: Overlapping components** in the Validation Wizard. Default is on.
* **TestRedundantPoints** – Used with **Validation Tests: Redundant points** in the Validation Wizard. Default is on.
* **TestSuspiciousPoints** (version 11.0.0.2365 & above) – Used with **Validation Tests: Suspicious points** in the Validation Wizard. Default is on.
* **ValidationMaxNumberOfCompositeGlyphMembers** – Used with **Real-time glyph validation: Disable when number of members exceeds** in Options: Validation. Default is 1000.
* **ValidationMaxNumberOfContours** – Used with **Real-time glyph validation: Disable when number of contours exceeds** in Options: Validation. Default is 100.
* **ValidationMaxNumberOfPoints** – Used with **Real-time glyph validation: Disable when number of points exceeds** in Options: Validation. Default is 25.

### Warn (used in Options: Advanced)
* **WarnBeforeActivatingFixFeature** (version 4.0 until 6.5) – Used with **Warn before activating the fix feature in the Font Validation Wizard**. Default is on.
* **WarnBeforeActivatingRemoveFeature** (version 4.0 until 6.5) – Used with **Warn before activating a remove feature from the Options → Font page**. Default is on.
* **WarnBeforeAddCharacters** (version 5.0 until 6.5) – Used with **Warn before adding characters**. Default is on.
* **WarnBeforeAnchorDelete** and **WarnBeforeAnchorDelete2** – Used with **Warn when deleting an anchor used by OpenType features**. Default is on.
* **WarnBeforeCloseOpenTypeDesigner** – Used with **Warn about losing changes when cancelling or closing OpenType Designer dialog**. Default is on.
* **WarnBeforeExecutingGlyphTransformProgram** (version 4.5 & above) – Used with **Warn before executing a glyph transformer script**. Default is on.
* **WarnBeforeSortingGlyphs** (version 5.0 until 6.5) – Used with **Warn before sorting glyphs**. Default is on.
* **WarnImportSmallImage** – Used with **Warn when importing small image**. Default is on.
* **WarnWhenOpening10OrMoreFonts** – Used with **Warn when opening 10 or more fonts**. Default is off.
* **WarnWhenProcessingVOLTTable** (version 9.0 until 11.0) – Used with **Warn when opening a font file which contains a VOLT table**. Default is on.

## Cursors in the executable file
**Note:** All resources start with HL.
* **HLADDCONTOUR** – Used when adding contours.
* **HLDUPLICATE** – Used when duplicating contours.
* **HLFREEHAND** – Used by **Freehand**
* **HLGUIDELINED** – Used by **Guideline**
* **HLKNIFE** – Used by **Knife**. This resource uses German language. The cursor was changed in FontCreator 10.0 & above.
* **HLMEASURE** – Used by **Measure**
* **HLMOVECONTOUR** – Used when moving contours. This resource uses German language.
* **HLMOVEPOINT** – Used when moving points. This resource uses German language.
* **HLNEWELLIPSE** – Used by **Ellipse**
* **HLNEWRECTANGLE** – Used by **Rectangle**
* **HLROTATE** – Used by **Rotate**. This resource uses German language.
* **HLSELECT** – Used when selecting anything. This resource uses German language.
* **HLSELECTCONTOUR** – Used when selecting contours. This resource uses German language.
* **HLSELECTPOINT** – Used when selecting points. This resource uses German language.
* **HLZOOMIN** – Used by **Zoom In**. This resource uses German language.
* **HLZOOMOUT** – Used by **Zoom Out**
* **RV_JUMP_CURSOR** – Inverted jump cursor
* **VT_HEADERSPLIT** – No meaning
* **VT_MOVEALL** – Used when moving contours in simple glyphs.
* **VT_MOVEE** – Used when moving contours in simple glyphs.
* **VT_MOVEEW** – Used when moving contours in simple glyphs.
* **VT_MOVEN** – Used when moving contours in simple glyphs.
* **VT_MOVENE** – Used when moving contours in simple glyphs.
* **VT_MOVENS** – Used when moving contours in simple glyphs.
* **VT_MOVENW** – Used when moving contours in simple glyphs.
* **VT_MOVES** – Used when moving contours in simple glyphs.
* **VT_MOVESE** – Used when moving contours in simple glyphs.
* **VT_MOVESW** – Used when moving contours in simple glyphs.
* **VT_MOVEW** – Used when moving contours in simple glyphs.

## Bitmaps in the executable file (Delphi resources omitted)
* **HLCSPINDOWN** – Used in the spinner control.
* **HLCSPINUP** – Used in the spinner control.
* **RZCMBOBX_DEVICE** – Used for device fonts in the font dropdown list.
* **RZCMBOBX_FIXEDPITCH** – Used for fixed pitch fonts in the font dropdown list.
* **RZCMBOBX_PRINTER** – Used for printer fonts in the font dropdown list.
* **RZCMBOBX_TRUETYPE** – Used for TrueType fonts in the font dropdown list.
* **RZCMBOBX_TRUETYPEFIXED** – Used for TrueType fixed pitch fonts in the font dropdown list.
* **SPTBXGLYPHS** – Used by glyphs in the Glyph Overview.
* **SYNEDITINTERNALIMAGES** – Numbers in gray background
* **SYNEDITWORDWRAPPED** – Word wrap icon
* **TB2SYSMENUGLYPHS** – Used by the toolbars.
* **TBXGLYPHS** – Used by glyphs in the Glyph Overview.
* **TBXSYSMENUIMAGES** – Used by the toolbars.
* **TCOLORSELECTOR** – Used in the color selection dialog.
* **VT_CHECK_DARK** – Used for radio buttons, checkboxes and dropdown lists.
* **VT_CHECK_LIGHT** – Used for radio buttons, checkboxes and dropdown lists.
* **VT_FLAT** – Used for radio buttons, checkboxes and dropdown lists.
* **VT_MOVEALL** – Cursor used for scrolling.
* **VT_MOVEEW** – Cursor used for scrolling.
* **VT_MOVENS** – Cursor used for scrolling.
* **VT_TICK_DARK** – Used for radio buttons, checkboxes and dropdown lists.
* **VT_TICK_LIGHT** – Used for radio buttons, checkboxes and dropdown lists.
* **VT_UTILITIES** – Additional arrows.
* **VT_XP** – Used for radio buttons, checkboxes and dropdown lists.
* **VT_XPBUTTONMINUS** – No meaning
* **VT_XPBUTTONPLUS** – No meaning

## RC Data in the executable file
* **CHARTABLE** (version 10.0 until 10.1.0.2272) – Contains a list of characters.
* **CLOUDS** (unused) – It's a picture of multi-colored clouds.
* **DESCRIPTION**, **ELDATA** and **PLATFORMTARGETS** (unused) – These are binary resources.
* **DVCLAL** (unused) – Shows two paragraphs saying the license key is valid and is running C++ Builder Professional.
* **PACKAGEINFO** (unused) – Shows all functions and the Pascal log used to compile the program.
* **TABOUTDIALOG** and **TABSTRACTABOUTDIALOG** (**TABOUTFORM** and **THLCREGISTERABOUTBOXDLG** in old versions) – Displays copyright, program and Windows version number, physical memory, registration information and MPL Licensed Open Source Software (version 6.0 & above) (**Help: About...**).
* **TABSTRACTWELCOMEDIALOG** (**TWELCOMEFORM** in old versions) – Used by newcomers if `OnStartupShowWelcome` is enabled.
* **TADDCHARACTERSFORM** (version 5.0 & above) – Adds characters as empty glyphs to the font. This requires the Unicode information to be present (if corrupted, it will show a range check error). In version 4.0 the feature is hidden and it adds glyph data from another font/only adds one character. In version 5.0 & above it adds up to 65,535 characters. The Arial Unicode MS font was used in the form showcasing the Currency Symbols through Letterlike Symbols blocks in the font with the Italian lira (₤) selected in the manual. The characters that the selected font lacks are shaded gray.
* **TADDCHARACTERTOGLYPHINDEXMAPPINGFORM** – Shown when pressing **Select** in `TCHARACTERTOGLYPHINDEXMAPPINGFORM` (old versions) or the Unicode button in the glyph properties (new versions) to assign Unicode character values for each glyph.
* **TADDCUSTOMNAMINGFORM** – Used by **Font Properties: Custom: Add...** to add custom naming fields for multiple languages. The Dutch (Standard) - Netherlands language was selected and used in the form as shown in the manual.
* **TADDFPCVLTSFORM** – Adds labels, tooltips or samples to character variants in the OpenType layout tables.
* **TADDFPSIZENAMEFORM** – Adds subfamily names to the font.
* **TADDFPSTYLISTICSETNAMEFORM** – Adds or writes stylistic set names or descriptions in the OpenType layout tables.
* **TADDGASPFORM** – Adds gasp ranges to the font (**Add** in **Smoothing: Preferred rasterization techniques** in the font settings window).
* **TADDLOCALLANGUAGEDATAFORM** (version 2.0 until 6.5) – Shows a dialog to add naming fields for multiple languages to the font.
* **TADDPLATFORMFORM** (version 2.0 until 6.5) – Adds a platform to the font by pressing the **Add** button in the Platform Manager.
* **TADDUVSFORM** – Used by fonts for East Asian languages to add Unicode variation sequences.
* **TADDVARIATIONCONDITIONFORM** – Used by fonts for East Asian languages to add Unicode variation conditions.
* **TADDVARIATIONSUBSTITUTIONFORM** – Used by fonts for East Asian languages to add Unicode variation substitutions.
* **TADVANCEDEDITFORM** – Edit a naming field in the font.
* **TANCHORMANAGERFRAME** and **TANCHORMANAGERFRM** (version 8.0 & above) – Manages anchors in the font based on the `GPOS` table.
* **TAUTOKERNEXFORM** (**TAUTOKERNINGFORM** in version 3.0.1 until 6.5) – Automatically add kerning pairs to the OpenType layout tables (version 7.0 & above) or legacy kerning tables (version 1.0 until 6.5) if you don't want to manually add kerning pairs to the font via the OpenType Designer. The Garava and Times New Roman (previously) fonts were used in the form as shown in the manual.
* **TAUTOMETRICSFORM** (version 3.0.1 & above) – Automatically generate metrics for glyphs for use with proportional fonts. Don't use this for monospaced, pixel or barcode fonts! The optical metrics adjustment user interface is used by *Scanahand* (font generator). The Calibri and Times New Roman (previously) fonts were used in the form's second page (selecting glyphs) as shown in the manual.
* **TAUTONAMEFORM** (version 3.1.2 until 6.5) – Automatically change the naming fields of a font. The MegaWaves font was used in the form as shown in the manual.
* **TAXISVALUEMULTIFORM** – Edits axis value combinations in the font.
* **TBASICEDITFORM** (**TADVANCEDNAMINGFORM** in version 3.0 until 6.5) – Edit a naming field or include additional naming fields in the font (replaced with Properties in version 7.0 & above). The MegaWaves font was used in the form as shown in the manual.
* **TCHANGETAGFORM** (version 7.0 & above) – Changes tags in the OpenType layout tables.
* **TCHARACTERTOGLYPHINDEXMAPPINGFORM** (version 2.0 until 6.0, **Tools: TODO! AutoCmap...** in version 3.0 until 5.6 as a hidden menu item) – Maps characters to glyph indexes based on the `cmap` table in the font. The Arial font was used in the form as shown in the manual.
* **TCLASSMANAGERFORM** (version 7.0 & above) – Changes classes in the OpenType layout tables.
* **TCODEEDITORFORM** (version 7.0 & above) – Edits the OpenType feature source code in the font.
* **TCODEPAGERANGEFORM** – Includes or excludes code pages to support in the font. This corresponds to the `ulCodePageRange` fields to make the font work in some programs (e.g. Sublime Text). If the fields are not set (e.g. Hindsight Unicode), then Windows will show the script dropdown menu in the font selection dialog as **Other**.
* **TCOLORFORM** (old versions) – This resource is not the standard Windows color selection dialog available in `comdlg32.dll`.
* **TCOMPOSITEGLYPHPROPERTIESFORM** – Views or modifies properties for composite glyph members. The Calibri font was used in the form as shown in the manual (using the lowercase e acute).
* **TCONFIRMREPLACEDIALOG** (version 10.0 until 10.1.0.2272) – This confirmation dialog will ask you what to do when replacing.
* **TCONVERTBITMAPTOCONTOURSFORM** – Converts bitmap images to contours or imports raster images to any glyph in the font.
* **TDELETEFEATURELOOKUPFORM** (version 7.0 & above) – Removes features or lookups from the OpenType layout tables in the font.
* **TDELETEKERNGROUPFORM** (version 7.0 & above) – Removes kerning groups or classes from the OpenType layout tables in the font.
* **TDISABLEDFORM** (version 5.0 & above) and **TABSTRACTDISABLEDIALOG** (version 12.0.0.2565 & above) – Used in unregistered copies during (recent versions) or after a grace period of 30 days (old or recent versions). If these forms are deleted, it will either show a non-existing form message (old versions) or a text only message (recent versions).
* **TDM** and **TDMFMX** (version 4.0 & above) – Contains icons with no regard to `Glyph.Data` in old versions. Version 5.5 (2006-05-30) until 11.0.0.2365 (2017-05-10) uses icons in e.g. Microsoft Office 2003 up to 2010. The icons were changed in version 12.0 & above.
* **TDMGLOBAL** – This resource is used by the taskbar progress.
* **TDMGLOBALNON** – Contains codepages, vendors, hinting, Adobe Glyph List and bidirectional mirroring data.
* **TDMMEDIA** – Contains logos and banners.
* **TEDITANCHORFORM** (version 7.0 & above) – Edits anchors in the font if any glyph has positioning data.
* **TEXPORTGLYPHDATAFORM** (version 4.0 until 6.5) – Exports glyph data to fgd files (**Tools: Export Glyph Data...**). Recent versions are limited to only one glyph.
* **TEXPORTSETTINGSFORM** and **TEXPORTSETTINGSFRAME** – Changes font export settings such as the outline format (TrueType or CFF/PostScript) and output folder.
* **TEXTERNALSFORM** – Edit the three custom external tools (**Tools: Launch Externals: Configure Externals...**).
* **TEXTRACTFROMTTCFORM** (version 4.0 & above) – Extract TrueType or OpenType font collections to multiple font files (**Tools: Extract from OTC...**). The SimSun font was used in the form as shown in the manual. For unregistered copies running after a grace period of 30 days, **TDISABLEDFORM** (old versions) or the **Evaluation Period Expired** message (recent versions) is shown instead. This corresponds to the `MiToolsExtractFromTTCClick` function used by `CheckLicenseNotGood`.
* **TFEATURESETTINGSFORM** (version 12.0) and **TFEATURESFRAME** – Generates or updates feature code in the OpenType Designer.
* **TFINDFORM** – Searches parts of a font.
* **TFONTEMBEDDINGLICENSINGRIGHTSFORM** (version 2.0 until 6.5) – Shows a list of embedding or licensing rights to use in the font (replaced with **Legal: Embedding Licensing Rights** in `TFONTSETTINGSFORM` in version 7.0 & above).
* **TFONTHEADERFLAGSFORM** – Enables or disables header flags in the font.
* **TFONTINSTALLWIZARDFORM** – Installs the font to the computer (version 6.0 & below requires saving the font). **Fun fact:** The file path in the first step is dummy. The second step (font already installed) names the installed font as Arial (`c:\win98\fonts\arial.ttf` - **win98** stands for Windows 98). The MegaWaves font was used in the form as shown in the manual. For unregistered copies running after a grace period of 30 days, **TDISABLEDFORM** (old versions) or the **Evaluation Period Expired** message (recent versions) is shown instead. This corresponds to the `InstallFont` and `miFontInstallClick` functions used by `CheckLicenseNotGood`.
* **TFONTLOGFORM** – Displays the font log (**Developer Tools: Font Log**).
* **TFONTOVERVIEWFORM** – Shows all the glyphs included in the font. The Calibri and Courier New (previously) fonts were used in the form as shown in the manual. The Cambria font was used in the form as shown in the Font Inspection tutorial. The Fredoka (variable font regular style), Kabala (extra-bold style), Pali (previously) and Verajja (showing the Latin-1 Supplement Unicode block sorted by Mac codepoint) fonts were used in the form as shown in the program's official screenshots. The Lato font (used in the company's website) was used in the form as shown in the Running FontCreator on a Mac tutorial.
* **TFONTPROPERTIESFORM** and **TFONTPROPERTIESFRAME** – Contains properties and unsupported tables (version 7.0 & above) in the font. If the non-Unicode language is Chinese, Japanese or Korean, the hexadecimal data text box in the **Unsupported Tables** tab substitutes Latin-1 accented letters by ASCII forms, e.g. Wästman by Wastman and some Latin-1 symbols by fullwidth forms or other symbols, e.g. £ by ￡ and « by ≪. The MegaWaves font was used in the form's identification and legal tabs as shown in the manual.
* **TFONTSETTINGSFORM** – Contains basic naming fields or metrics settings, Unicode and code page ranges, gasp ranges and more.
* **TFONTTABLESFORM** (version 2.0 until 6.5) – Shows a list of supported and unsupported tables in the font. Unsupported tables is a separate tab in the font properties window in version 7.0 & above.
* **TFONTTESTFORM** – Test desktop fonts (not web fonts). The default text in `mmFontTest` and `Memo1` (version 7.0 & above) in version 4.0 until 5.6 is the program name, letters and numbers with DOS/Windows Latin-1 and USA characters (version 6.0 & above removes the characters at the end and adds High-Logic FontCreator at the beginning). Version 1.1.1c until 5.0 allows the user to change the encoding (it was removed in version 5.5 & above). The Verajja font (24 points) was used in the form with the pangrams sample text as shown in the manual. For unregistered copies running after a grace period of 30 days, **TDISABLEDFORM** (old versions) or the **Evaluation Period Expired** message (recent versions) is shown instead. This corresponds to the `TestFontTTFOTF` (`miFontTestTTFOTFClick`) and `TestFontWOFF` (`btnFontTestWoffClick`) functions used by `CheckLicenseNotGood`.
* **TFORMADDANCHOR** (version 7.0 & above) – Adds anchors to the `GPOS` table.
* **TFORMEDITANCHOR** (version 7.0 & above) – Edits anchors in the `GPOS` table.
* **TFORMINSERTGLYPHS** (**TINSERTGLYPHFORM**) – Inserts glyphs in the font, using either names or numbers.
* **TFORMOPENTYPEDESIGNERSETTINGS** (version 7.0 & above) – Changes the OpenType Designer options.
* **TFORMULAFORM** (version 12.0) – Writes formulas to construct anchor based composite glyphs.
* **TFRAMECATEGORY** (version 7.0 & above) – Contains categories in the font overview (left side).
* **TFRAMEFONT** – Used by the font overview (left side).
* **TFRAMEGLYPH** – Used by glyphs in the font overview (left side).
* **TFRAMEGLYPHMEMBERS** (version 7.5 & above) – Used when editing colored glyphs to display glyph members (automatically shown when switching glyphs to color mode).
* **TFRAMEMASTERS** – Used by masters in the font overview (left side).
* **TFRAMEPALETTE** (version 7.5 & above) – Shows the color palette when editing multicolored fonts (automatically shown when switching glyphs to color mode).
* **TFRAMEVALIDATION** – Used when validating fonts.
* **TGASPFORM** (version 2.0 until 6.5) – Manages the `gasp` table in the font (replaced with the Smoothing tab in `TFONTSETTINGSFORM` in version 7.0 & above).
* **TGENERATECONTOURSCANCELFORM** – Used when generating contours.
* **TGENERATEPROBLEMREPORTFORM** (version 3.0 until 11.5) – Used when pressing **Next** in the Validation Wizard.
* **TGLYPHALREADYMAPPEDFORM** (version 2.0 until 6.5) – A character to glyph index mapping can only exist once, so if you try to add a mapping that already exists this window will ask you what to do. The Arial font was used in the form with the OE ligature as shown in the manual.
* **TGLYPHEDITFORM** – Used when opening any glyph from the font overview. The Calibri and Courier New (previously) fonts were used in the form as shown in the manual.
* **TGLYPHNAMEFORM** (version 7.0 & above) – Changes the PostScript names in the font (**Tools: Glyph Names**).
* **TGLYPHPROPERTIESFORM** (version 2.0 until 6.5) and **TGLYPHPROPERTIESFRAME** (version 7.0 & above) – Contains postscript name, glyph metrics/bearings and character mappings.
* **TGRIDFORM** – Configures grid options.
* **TGUIDELINEMODIFYFORM** – Modifies the selected guideline.
* **TGUIDELINESFORM** – Configures guideline options. The label in the **Show Guidelines** checkbox says **&Show &Guidelines**.
* **THLBASEFORM** – It's used by the splash screen.
* **THLBASEFRAME** – It's used by the splash screen.
* **TIMPORTGLYPHDATAFORM** (version 4.0 until 6.5) – Imports glyph data in the font to fgd files (**Tools: Import Glyph Data...**). Recent versions are limited to only one glyph.
* **TINSTALLEDFONTSFORM** – Shows a list of installed fonts in the computer which can be opened. The preview (version 5.0 & above) was shown by its font name and could not be edited (it shows "The quick brown fox jumps..."). The Arial Rounded MT Bold (previously) and Segoe Script fonts were used in the form as shown in the manual. Version 10.1.0.2272 (2016-12-20) & below has a delay.
* **TKERNFEATUREFRAME** – Used by `TKERNINGFORM`.
* **TKERNGROUPMANAGERFORM** (version 7.0 & above) – Manages kerning groups or classes in the font.
* **TKERNINGFORM** (version 3.0 until 8.0) – Edits the legacy `KERN` table (not the `GPOS` kerning tables) in the font (replaced with OpenType Designer in version 7.0 & above). The Calibri (previously) font was used in the form as shown in the program's official screenshots. The Elephant font (previously) was used in the form with the AV pair selected as shown in the manual from FontCreator 5.6.
* **TKERNINGNEWPAIRFORM** (version 3.0 until 8.0) – Adds a kerning pair to the old `KERN` table or `GPOS` kerning tables.
* **TKERNINGNEWSINGLEFORM** (version 7.0 & above) – Adds a single kerning adjustment to the `GPOS` kerning tables.
* **TLOCALIZEDEDITFORM** – Edits localized name values.
* **TMADEXCEPT**, **TMECONTACTFORM**, **TMEDETAILSFORM**, **TMESCRSHOTFORM** – Contains exceptions, contact info, crash report details and screenshot configuration.
* **TMAINFORMFONTCREATOR** (**TMAINFORMFCP3** in version 3.0 and **TMAINFORMFCP4** in version 4.0 until 5.0) – Contains many things like the main window, glyph properties, user notes (version 7.0 & above), preview window (version 3.0.1 & above), anchors, background image, glyph validation report and more. The Fredoka font is used in the program's official screenshot.
* **TMETRICSFORM** – Shows an interface for viewing and setting metrics options.
* **TNAMINGFORM** (version 3.0 until 6.5) – Contains basic naming fields in the font excluding fields with unknown numbers (replaced with Properties in version 7.0 & above). The MegaWaves font was used in the form as shown in the manual. For naming fields not included in the font, if the check box is not checked, the words “not included.” are added to the input field in versions before 5.0.
* **TNEWSUBSINGLEFORM** (version 10.0 until 10.1.0.2272) – Adds a single substitution to the OpenType layout tables.
* **TNEWTRUETYPEFONTFORM** – Creates a new font.
* **TOPENTYPEDESIGNERFORM** (version 7.0 & above) – Shows an interface for viewing, editing or creating the OpenType layout tables. This corresponds to the `GDEF`, `GPOS` and `GSUB` tables. The Calibri and Verajja fonts were used in the form as shown in the program's official screenshots. The Calibri font was used in the form (with the kerning table selected) as shown in the manual.
* **TOPENTYPEDESIGNERPROOFINGFORM** (version 12.0.0.2560 & above) – Used for interactive feature proofing of OpenType layout tables. Before version 13 the form was blank. The Amiri and Arabic Typesetting (Microsoft VOLT version) fonts were used in the Font Proofing - OpenType Layout Features Unleashed tutorial with the form in the right side. The Amiri font was used in the form with Arabic text as shown in the manual.
* **TOPENTYPEDESIGNERSEARCHFORM** – Search the OpenType layout tables in the font.
* **TOPENTYPEITEMADDFRM** (version 7.0 & above) – Adds items to the OpenType layout tables.
* **TOPTIONSFORM** – Shows an interface for viewing and setting a wide variety of options.
* **TOTLFRENAMEFORM** (version 7.0 & above) – Rename lookup tables in the OpenType layout tables.
* **TPASTESPECIALFORM** – Paste data into glyphs stored in the clipboard. In the Items list (version 5.5 until 6.5), **Glyph Outline Data** and **Glyph Metrics** (i.e. the first two items) are checked by default. **Glyph Outline Data** is dimmed in the third major version. In recent versions, the registry keys are stored in the `Edit` key.
* **TPCLTFORM** (version 3.0.1 until 6.5) – Modifies the `PCLT` table for use with PCL5 printers. The Arial font (previously) was used in the form as shown in the manual.
* **TPERFORMTRANSFORMATIONFORM** (version 4.5 & above) – Used after transforming each glyph.
* **TPLATFORMMANAGERFORM** (version 2.0 until 6.5) – Choose which platform to support in the font (see **Tools: Convert Font** in version 7.0 & above).
* **TPOSTSCRIPTNAMESFORM** (version 2.0 until 6.5, **Tools: TODO! AutoPost...** in version 3.0 until 5.6 as hidden menu item) – Changes the PostScript names in the font (replaced with **Tools: Glyph Names** in version 7.0 & above). The Elephant font (previously) was used in the form as shown in the manual.
* **TPRINTABORTFORM** – Used when printing the font.
* **TPRINTFONTFORM** – Used when printing anything in the font.
* **TPRINTGLYPHFORM** – Used when printing glyphs in the font.
* **TPROGRESSDIALOG** (**TPROGRESSFORM** in old versions) – Progress dialog. The cursor for this form is **Busy**.
* **TREGISTERFORMEX** and **TREGISTERFORMFC** (version 1.0.6 & above, **TREGISTERFORM** in old versions) – Registers the program (**Help** or **Buy: Register...**). This removes `TSPLASHFORM` on startup, hides the **Buy** menu and shows the **Developer Tools** menu (if enabled in version 12.0 & above). **Fun fact:** `TREGISTERFORMEX` has its own user agent. Registering recent versions will connect to the High-Logic website to activate the user's license.
* **TRESOURCEEDITORDLG** (unused, version 3.0) – It is a large resource.
* **TRESOURCEMODULE** – Contains styles in `rvStyleGlobal` and icons with no regard to `Glyph.Data` in old versions.
* **TRICHVIEWDIALOG** – This resource is not the Windows rich view or rich text editor components (`riched20.dll`). Used during or after a grace period of 30 days for unregistered copies or when selecting the **Help: Upgrade** menu item. Styles are located in `RVStyle1`.
* **TRULEMGR** (version 7.0 & above) – Manages rules in the OpenType layout tables.
* **TSAMPLETEXTFORM** (version 6.5 & above) – Edit the list of sample texts in the test font window. Included samples are **Default**, **Lorem Ipsum**, **Pangrams**, **From Any to Zanily**, **Greek**, **Geometric Shapes** and **Latin Extended-A** (in old versions). The list cannot be edited prior to version 6.5.
* **TSELECTCOMPOSITEGLYPHMEMBERFORM** – Adds glyph members to composite glyphs. The Calibri and Times New Roman (previously) fonts were used in the form as shown in the manual with the word "circumflex" entered in the filter/search text box.
* **TSELECTLOOKUPTABLEFORM** – Selects a lookup table in the OpenType layout tables.
* **TSHAREWAREFORM** (version 3.0 until 5.0) – For unregistered copies running after a grace period of 30 days, shows a shareware description when pressing **Start** in `TSPLASHFORM`.
* **TSORTGLYPHSFORM** (version 5.6 until 6.5) – Changes the glyph order within a font (replaced with **Tools: Sort Glyphs** in version 7.0 & above). Before version 5.6, the glyphs are sorted in any font with the standard macOS ordering.
* **TSPLASHFORM** – Shows by unregistered copies. The three buttons at the bottom (**Use Evaluation Version**, **Enter Registration Code** and **Buy Now**) changes the order. **Fun fact:** The copyright in version 7.0 & above starts at 2007 and end at 2010.
* **TSPTBXCOLORPICKERFORM** – Selects colors when editing colored glyphs.
* **TSUBLOOKUPMGR** (version 7.0 & above) – Manages subtables in the OpenType layout tables.
* **TSUBSETSFORM** – Manages subsets in the font.
* **TTAGSFORM** (version 14.0 & above) – Configures tags shown in the font window on the left side and the context menu to select tags.
* **TTEXTREPLACEDIALOG** – Replaces text in the OpenType Layout Feature Editor.
* **TTEXTSEARCHDIALOG** – Searches for text in the OpenType Layout Feature Editor.
* **TTIPOFTHEDAYFORM** (version 1.0 until 6.5) – Shows tips and tricks (**Help: Tip of the Day**). The **Register** button is shown if the program is detected to be running an unregistered copy.
* **TTRANSFORMFORM** (version 4.5 & above) – Transforms the font to other weights (e.g. medium, bold or black) or add character ranges (e.g. some characters in the Letterlike Symbols range of Unicode like double struck letters). The Eastern European transformation script was used in the form as shown in the program's official screenshots.
* **TTRIALNOTICEWINDOW** (version 7.0 until 10.1.0.2272) – If the program is detected to be running an unregistered copy, testing, installing or exporting fonts displays this message. The message has a checkbox to turn it off. The message text includes a link to the registration page in the High-Logic website.
* **TTRIMFORM** – Used when trimming kerning pairs.
* **TUNICODERANGEFORM** – Includes or excludes Unicode blocks or ranges to support in the font (the list in the form belongs to OpenType 1.3). This corresponds to the `ulUnicodeRange` fields.
* **TUPDATEFORM** and **TUPDATEFORMFC** (version 6.1 & above, **TUPDATEREMINDERFORM** in version 5.5 until 6.0) – Checks for updates (**Help: Check for Updates**) as if `OnStartupShowUpdateReminder` or `UpdateCheckInterval` is enabled. The program will terminate silently if the first form is removed or `mRestart` in the first form is not three lines. It connects to the High-Logic website to download the installer.
* **TUSEDBYFORM** – Displays an overview of all glyphs that use the selected glyph.
* **TUVSFORM** – Manage Unicode variation sequences used by fonts for East Asian languages.
* **TVALIDATIONWIZARDFORM** (version 4.0 & above, **Font: TODO! Problem Report...** in version 3.0 as a hidden menu item) – Validates the font for errors or problems.
* **TWIDEMESSAGEFORM** – Used for messages.
* **TWIDEWARNINGFORM** (**TEXTENDEDWARNINGFORM** and **TWARNINGFORM** in old versions) – Used for warnings.
* **WIN10STYLE** – Windows 10 style.
* **WIN11STYLE** – Windows 11 style.
* **WIN7STYLE** – Windows 7 style.
* **WIN8STYLE** – Windows 8 style.

## Unused Content
The program includes hidden options for debugging, development and testing purpose.

### Main Window
**Menu Items**
* **Edit: Knife** – Use the Knife option in the **Glyph** toolbar.
* **View: Toolbars: Tab Bar** – Toggles the tab bar if version 6.1–11.5 is used. The feature summons no action when selected in version 12 and 13.
* **Tools: Export Glyph Outlines...** (version 4.0 until 5.6) – Does not work. See **miTestItem4 Save** in the glyph edit window for glyphs edited in contour mode.
* **Tools: Import Glyph Data...** (version 4.0 until 5.6) – Imports glyph data from the font. Replaced with **miTestItem3 Load** in the glyph edit window for glyphs edited in contour mode. This feature is undocumented in the manual.
* **Tools: Export Glyph Data...** (version 4.0 until 5.6) – Exports glyph data in the font to fgd files. Replaced with **miTestItem4 Save** in the glyph edit window for glyphs edited in contour mode. This feature is undocumented in the manual.
* **Tools: TODO! Customize...** – If some icons are removed in the toolbars without using `Visible = False`, the first message shown in the status bar is replaced with access violation when e.g. opening fonts.
* **Window: Minimize All** – Minimizes all other windows (restore each minimized window with the restore button).
* **Help: Upgrade** (version 13.0) – Shows a message with licensing information for the Standard version.

**Hidden Shortcuts**
* **Restore Overview Splitter** – Hide or show the overview splitter.
* **Close** – Closes the active window with the same command in the **File** menu.
* **Cut**, **Copy** and **Paste** – Uses the same commands in the **Edit** menu.
* **Show Font Properties** – Uses the same command in the **Font** menu.
* **Redo** – Uses the same command in the **Edit** menu.
* Tags from **tags.txt** and **Tagged** folder (font overview; automatically shown) – The menu items summons no action when selected.

**Developer Tools** – Contains debugging functions and developer commands (the menu is hidden for unregistered copies of FontCreator 12–15).
* **Screenshot macro 1** and **Screenshot macro 2 (website)** – Create the folder `help\screenshots\` from the Program Files directory (Program Files (x86) if the 32-bit version is installed on 64-bit) and register the program to use these features. In FontCreator 7.0 until 11.5, anti-aliased smoothing should be used.
* **Hide Developer Menu** – Hides this menu.
* **AutohintMacro** – Uses the **Close All** command in the **File** menu.
* **Video mode** – Restores the window to its original size and registers the program without a key.
* **A/B Testing** – Contains two options to set the variant.
* **Font Log** – Shows the font log (hidden for unregistered copies of FontCreator 12–14).
* **Disable garbage collector** – This option disables the garbage collector.
* **Increase Font Size** – Shows information about the font and size with two numerical strings.
* **Enable All Toolbar Icons** – Enables all icons in all toolbars.
* **Font Tester Action** – Intended to change the action in `TFONTTESTFORM`.
* **Boink!** – Exit the program silently. In version 10.0 (2016-06-22) until 11.5.0.2430 (2018-12-05), the feature summons no action when selected and is in the **Debug** menu. It may display a critical error which contains an "OK" button.

**Toolbar Buttons** – The last four buttons are enabled when editing simple or composite glyphs.
* Second **Open** and **Print** options in the **Standard** toolbar – Only the second **Print** option uses the same command in the **File** menu or the first **Print** option. The second **Open** option icon is blank.
* **Next Glyph** in the **Validation** toolbar – Use the option in the **Drawing** toolbar instead.
* **Tools: Generate Glyph Names** – Save friendly glyph names to `C:\Users\EDenissen\AppData\Roaming\FontCreator14\generatednames.txt` (`FontCreator12` or `FontCreator13` in version 12 and 13). Create the user `EDenissen` to use this feature. The button is hidden for unregistered copies of FontCreator 12 and 13.
* **Glyph: Smooth Curves** – Smooths all curves. The icon is shown as S.
* **Glyph: Smooth and Align Curves** – Smooths and aligns curves. The icon is shown as SA.
* **Glyph: Harmonize** – Harmonizes all contours. The icon is shown as H.
* **Glyph: Round XY Coordinates** – Round XY coordinates values. The icon is shown as R.

### Glyph Edit Window Contour Mode Context Menu
* **Order** (version 3.0 until 5.0) – The features were implemented as **Align or Distribute** in version 5.5 & above.
* **Debug Single Stroke Twice** (**miTestItem** in version 10.0 until 10.1.0.2272) – Does not work.
* **miTestItem2** – Jumps to the next contour based on the number of selected contours.
* **miTestItem3 Save** and **miTestItem4 Load** – Save or load glyph data from `C:\hltemp\glyph.data` (see **Tools: Import/Export Glyph Data** in the menu for old versions above). Create the folder `hltemp` to use these features.

### Font Overview
Version 4.5 added bookmarking glyphs (the menu is hidden after being discontinued in version 7.0).

### Import Image Dialog Checkboxes (version 3.0)
The checkboxes summon no action when they're checked. Edit the glyphs using point mode instead. These checkboxes were dropped after version 4.0.
* **Include Diagonals**
* **Remove Knees**

### Glyph Properties
Version 4.0 until 5.0 includes a text box intended to show the number of contours (see the status bar at the bottom of the main window).

### Composite Glyph Properties (`TCOMPOSITEGLYPHPROPERTIESFORM`)
* Text box with glyph indexes (version 3.0 until 6.5) – It is located at the top right corner.
* Button: **Delete** (version 3.0 until 6.5) – It summons no action when pressed. Delete the member(s) of a composite glyph using the glyph edit window instead.
* Checkbox: **ARGS_ARE_XY_VALUES** (version 3.0 until 6.5) – The checkbox was dropped after version 7.0.

### Export Settings (`TEXPORTSETTINGSFRAME`)
In this dialog is a label saying that OpenType features are not supported (shows only to Microsoft Symbol encoded fonts). There are checkboxes to remove PostScript names, create hinting and include the digital signature table. There are dropdown lists to generate OpenType features or create kerning pairs from the legacy KERN table or OpenType glyph positioning data or both.

### Automatic Metrics Wizard (`TAUTOMETRICSFORM`)
If the program detects it is running the Home Edition, it shows the Professional Edition note (hidden in the Professional Edition). Version 10.0 includes three unused features which were dropped in version 11.0 & above: The third panel changes the advance width with check boxes to center the glyph or set the left side bearing to x=0 and a radio button to use monospaced metrics (only active when selecting the Fixed option).

### OpenType Designer: GPOS Kerning Editor Buttons
The buttons start with a capital D in square brackets.
* **Clear Values** – Sets all kerning pairs values to zero. Used for monospaced fonts with kerning tables (e.g. **Monospaced Typewriter**: Designed by Manfred Klein, based on Monospace 821 BT).
* **Harmonize** – Harmonizes all kerning pairs in subtables.
* **Clean Up** – Removes all kerning pairs with a zero value. In version 3.0 until 6.5, all pairs from the legacy `KERN` table with unencoded glyphs are removed.

### OpenType Layout Feature Code Editor
* Checkbox: **Debug: VOLT.UseGlyphIds** – Used for fonts with Microsoft VOLT projects.

### Font Test Window
The `mmFontTest` context menu has two paste options (pmSamplePaste and pmSamplePaste2) and a multiline text field at the bottom (`Memo1`) with the same text in Arial Bold (13 points). Double-click the memo to change the font and size.

### Options Window
The **General** tab has a group to associate fonts with this program (version 3.0 only; dropped after version 4.0). The **Preview** tab has buttons to move the selected text string up and down or to reset the list.

### About Dialog
These are located in the corners of the program name, version number, copyright notice and link to the company's website and can be shown by pressing the C key. (**Note:** uses HTTP via the HTML linking tag).
* **Clr** (Clear) (version 4.5 & above, top left corner) – Removes registration information (see the `Reg` section in **Registry Keys** above). Before version 6.0 the text is white and is located in the left side of the registration information.
* **Crash** (top right corner) – When clicked, displays a critical error saying "We hope you enjoyed clicking this crash button."
* **Trial** (bottom right corner, version 12.0 & above) – Resets or extends the trial period for unregistered copies running after a grace period of 30 days.

### Unused Content in French
Put the following lines in alphabetical order to the `lang.fr` file.
* Forms.AboutDialog.sbClear = "Effacer"
* Forms.AboutDialog.sbCrash = "Tomber en panne"
* Forms.AboutDialog.sbTrial = "Essai"
* Forms.CodeEditorForm.cbVOLTUseGlyphIDs = "Dépuration : VOLT.UseGlyphIds"
* Forms.FrameGlyph.miTestItem = "Dépuration barre sole un fois"
* Forms.FrameGlyph.miTestItem3 = "miTestItem3 Sauvegarde"
* Forms.FrameGlyph.miTestItem4 = "miTestItem4 Charger"
* Forms.MainFormFontCreator.miDevTools = "Outils de développeur"
* Forms.MainFormFontCreator.miDevToolsABTesting = "Contrôle A/B"
* Forms.MainFormFontCreator.miDevToolsABTestingA = "Configurer le variante A"
* Forms.MainFormFontCreator.miDevToolsABTestingB = "Configurer le variante B"
* Forms.MainFormFontCreator.miDevToolsBoink = "Boink !"
* Forms.MainFormFontCreator.miDevToolsDisableGarbageCollector = "Desactiver le récupérateur de mémoire"
* Forms.MainFormFontCreator.miDevToolsEnableAllToolbarIcons = "Activer tous les icons de barres d'outils"
* Forms.MainFormFontCreator.miDevToolsFontLog = "Historique du police"
* Forms.MainFormFontCreator.miDevToolsFontTesterAction = "Opération de tester la police"
* Forms.MainFormFontCreator.miDevToolsHideDeveloperMenu = "Cacher le ménu de développeur"
* Forms.MainFormFontCreator.miDevToolsIncreaseFontSize = "Augmenter le taille de la police"
* Forms.MainFormFontCreator.miDevToolsScreenshotMacro1 = "Macro de capture d'écran 1"
* Forms.MainFormFontCreator.miDevToolsScreenshotMacro2 = "Macro de capture d'écran 2 (site web)"
* Forms.MainFormFontCreator.miDevToolsVideoMode = "Modalité vidéo"
* Forms.MainFormFontCreator.miHS = "Raccourcis cachés"
* Forms.MainFormFontCreator.miHS.Hint = "Ces éléments sont là pour que les raccourcis fonctionnent"
* Forms.MainFormFontCreator.miHSEditCutShortcut = "C&ouper"
* Forms.MainFormFontCreator.miHSEditPasteShortcut = "&Coller"
* Forms.MainFormFontCreator.miHSEditRedoShortcut = "&Rétablir"
* Forms.MainFormFontCreator.miHSRestoreOverviewSplitter = "Restaurer le séparateur de vue d'ensemble"
* Forms.MainFormFontCreator.miHSWindowsClose = "&Fermer Ctrl+F4"
* Forms.MainFormFontCreator.miHSWindowsClose2 = "&Fermer CTRL+W"
* Forms.MainFormFontCreator.miToolsCustomize = "POUR FACER ! &Personnaliser..."
