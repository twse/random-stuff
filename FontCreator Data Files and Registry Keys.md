## Notes
* The cursor will remain **Busy** if the user does other stuff when saving fonts in the background.
* All versions can save all unaltered opened fonts from the menu (**File: Save All**). Windows 2000 & above shows a critical error that reads **List index out of bounds** if done repeatedly.
* Exiting the program when saving fonts may create invalid font(s) and play the Critical Stop sound from the PC speakers.
* The program shows a critical error that reads **access violation** when exiting while during some operations – the font(s) may be invalid.
* Glyphs in the clipboard (version 1.0 until 6.0) will either say **Glyph Contours** (contours) or **Glyph Data** (glyphs). Version 7.0 & above stores just the PostScript glyph name(s) as text (glyphs) or **Font Data** (contours).
* **Edit: Delete** is not dimmed on startup or when closing other dialogs in old versions.
* **Complete Composites** (when generated from `CompositeData.xml` but not auto or anchor based) slows down the first time when used in simple and composite glyphs.
* **Complete Composites** is dimmed when editing empty glyphs in version 5.0 until 6.5.
* The program shows a critical error when using **Complete Composites** in some glyphs in the Private Use Area (old versions only). After that, these glyphs cannot be recovered.
* Version 1.0 (1998-04-11) until 7.0 (2013-04-25) only adds glyphs with Unicode BMP mapping to the preview toolbar.
* Version 5.6 (2007-07-19) has a non-standard resource layout which prevented [UPX](https://upx.github.io/) from packing the executable file (NotPackedException: not packed by UPX) except for compressing with or without parameters. Recent versions do not use this.
* In new fonts (version 5.0 until 6.5), the international currency sign (¤) is mapped to the Macintosh Roman platform but not the euro (€) mapping to the same codepoint (219).
* Version 1.0 (1998-04-11) until 6.5 (2011-11-18) used ISO Latin-1 as the output encoding for the program and exported kerning pairs while version 7.0 (2013-04-25) & above uses Unicode.
* The PostScript names modified when opening fonts in Font Creator Program 3.0 are as follows: the full stop at **.notdef** is removed, **nonmarkingreturn** changes to **CR** and **exclamdown** changes to **exclamationdown**.

## Unregistered version limitations
If registration is not performed during or within the grace period, the following restrictions will be imposed on the major/minor version number:
* All versions – `TSPLASHFORM` is shown on startup. `TMAINFORMFONTCREATOR` will add a word to the title bar (version 5.0 & above) and the registration info in `TABOUTDIALOG` or `TABSTRACTABOUTDIALOG` states that the program is unregistered. After a grace period of 30 days, the message shown in `TSPLASHFORM` is replaced with a message stating that the grace period is exceeded and encourages the user to uninstall or buy the program.
* 3.0β1 (2000-07-30) until 3.1.3 (2002-12-09) – After a grace period of 30 days, `TSHAREWAREFORM` is shown when pressing **Start** in `TSPLASHFORM`. However, the program otherwise functions normally.
* 4.0 (2003-05-16) until 4.5 (2004-08-17) – After a grace period of 30 days, the program cannot be used at all until the registration process is started.
* 5.0 (2005-01-12) until 5.6 (2007-07-19) – After a grace period of 30 days and opening the program 5 times, the program will enter a reduced functionality mode, where fonts cannot be saved, tested or installed and TrueType collections cannot be extracted.
* 6.0 (2009-06-17) until 6.5 (2011-11-18) and 8.0 (2014-06-05) until 12.0.0.2539 (2019-06-04) – The program will enter a reduced functionality mode. The reduced functionality varies based on whether the program is in the grace period or not. In this case, fonts cannot be installed or exported, OpenType collections cannot be extracted from the **Tools** menu and tested fonts won't be automatically hinted.
* 7.0 (2013-04-25) until 11.5.0.2430 (2018-12-05) – The program will create subsetted versions when testing, installing or exporting fonts. After a grace period of 30 days, the program will enter a reduced functionality mode, where fonts cannot be tested, installed or exported and OpenType collections cannot be extracted from the **Tools** menu.
* 12.0.0.2543 (2019-07-10) until 12.0.0.2550 (2020-01-14) – The program will add watermarks when generating fonts. After a grace period of 30 days, the program will enter a reduced functionality mode, where fonts cannot be tested, installed or exported.

Under the **Help** menu is an item labeled **Register...** (the same item in version 12.0 is in **Help: Buy** along with **Buy Now** and `TTIPOFTHEDAYFORM` in version 3.0 until 6.5) when this executed a screen will pop up giving the registration code.

## Windows version compatibility
* Windows Vista and later – 12.0.0.2554
* Windows XP – 10.0
* Windows 2000 – 7.0
* Windows 95, 98, ME and NT 4.0 – 6.0.1

## User Data (Glyph Transformer scripts omitted)
To quote the user manual: FontCreator uses several data files for advanced settings and customizations. Normally most files are stored in a system folder where they cannot be changed. If you want to edit most files directly they either must have administrator permissions or change the owner (this can be done with `takeown /f filename` or **Security: Advanced: Owner: Edit** in Windows XP, Vista and 7 and **Security: Advanced: Owner: Change** in Windows 8 and 10 in file properties).

* **bookmarks.txt** (version 5.0 until 6.5) – Includes bookmarks used in `TFONTOVERVIEWFORM`. Created automatically when the user exits the program.
* **CompositeData.xml** – Located in the `Composite` folder as used by **Complete Composites**. The feature will do nothing if there are syntax errors or this file is removed. [Bhikkhu Pesala](http://www.softerviews.org/Fonts.html) had assigned code points in the Private Use Area for different glyphs in this file and his fonts (he removed them), notably for use with OpenType features like small capitals or old style numbers.
* **CurrentTransformProgram.xml** – Transform Program used by `TTRANSFORMFORM`. The window will appear empty if removed.
* **default.otlfd** (version 7.0 until 11.5) – Default OpenType layout feature definitions, used to add common OpenType layout features. Replaced with `TFEATURESETTINGSFORM` in version 12.
* **FC#####.ttf** – Temporary font used by `TFONTTESTFORM` (the last five characters in the filename are numeric). Version 3.0 until 6.5 names the font as **FC Test Font ######** (the last six characters are numeric).
* **fc12.cfg** (version 12.0) – Configuration file located in the user's directory.
* **FCOutDrw.dll** – Dynamic link library located in the system root directory used for advanced outlines (version 10 & above).
* **fcp5.cfg** (version 5.0 until 5.6) – Configuration file located in the system root directory.
* **fcppreview.txt** (version 3.0 until 4.5) – Text used in `TFONTTESTFORM`. The text is restored to factory defaults if removed.
* **fntXX.tmp** or **fntXXX.tmp** – Temporary font used when saving (the last two or three characters in the filename is a letter and/or number combo).
* **FontCreatorSetup.exe** – Install the Win32 version of this program.
* **FontCreatorSetup-x64.exe** (version 11.5 & above) – Install the Win64 version of this program.
* **FontCreator.tip** (version 2.0 until 6.5) – Contains paragraphs in `TTIPOFTHEDAYFORM` to store tips and tricks. The window will appear empty if removed.
* **FontCreator YYYYMMDD HHMMSS ###.dat/prd** – Contains crash info (located in `ProgramData\High-Logic\Errors` – YYYYMMDD HHMMSS ### is the timestamp and random numbers).
* **FontInstaller.dll** (version 2.0 until 6.5) and **FontInstaller2.dll** (version 7.0 & above) – These dynamic link libraries are used by `TFONTINSTALLFORM`.
* **glyphlist.dat** – Contains the Adobe glyph list. Old versions have the same list but **xi** is duplicated as U+0000.
* **glyphnamesnew.dat** (version 7.0 & above) – Contains the default glyph names when opening existing fonts and when generating glyph names on `TGLYPHPROPERTIESFORM`. Prior to FontCreator 12 another file (`glyphnames.dat`) was used, but that one is now obsolete.
* **guidelines.dat** – Contains the guidelines used for `TGLYPHEDITFORM` and `TGUIDELINESFORM`. Created automatically when the user exits the program.
* **kern_font.txt** – For old versions of FontCreator, stores the old `KERN` table data in each font whereas `font` is the font name.
* **previewtext.dat** (version 5.0 & above) – Contains text used in `TFONTTESTFORM`. The text is restored to factory defaults if removed.
* **preview.txt** (version 4.5 & above) – Contains text strings used by the Preview toolbar in `TMAINFORMFONTCREATOR`. The dropdown list will appear empty if removed.
* **SubFamily.dat** or **SubFamily2.dat** – Contains naming fields for multiple languages.
* **TableOffsetOrderCFF.txt**, **TableOffsetOrder.dat** (old versions) or **TableOffsetOrder.txt** – Contains the supported tables in any font. All tables are moved to **Unsupported Tables** (`TFONTPROPERTIESFORM` in version 7.0 & above) or **Unsupported** (`TFONTTABLESFORM` in version 3.0 until 6.5) if these files are removed, making the font either invalid, unable to install or not work.
* **tags.txt** (version 7.0 & above) – Controls the names of the five tags that can be assigned to each glyph. Defaults are named Important, Incomplete, Completed, Review and Workspace.

In **Options: Advanced: Data Files** are two buttons labeled **Copy Data Files to User Data Folder** and **Open User Data Folder** when pressed the program will either copy most files in the above list to the user data folder or open it.

## Registry Keys
The registry keys are located in `HKCU\Software\High-Logic\FontCreator\version` whereas `version` is the version number.

### AddCharacters (used in `TADDCHARACTERSFORM`)
* **SelectedCharacter** – Select character. Default is 0 (null).
* **SelectedFont** – Select font to display characters. Default is **Arial Unicode MS** (shipped with Microsoft Office up to 2013 and discontinued with 2016).

### Background (used in Background Image on `TMAINFORMFONTCREATOR`)
* **BackgroundInitColor** – Set the background color. Default is white.
* **BackgroundInitScale** – Set the background scale factor.

### Columns (used in `TINSTALLEDFONTSFORM`)
* **Open Installed Fonts** – This numerical option changes the width.

### Edit (used in `TPASTESPECIALFORM`)
* **PasteSpecialAnchors** – This option will paste anchors. Default is on.
* **PasteSpecialCodepoints** – This option will paste codepoints. Default is on.
* **PasteSpecialCodepointsOption** – This option will paste codepoints. Default is 0 (Keep same code-points).
* **PasteSpecialGlyphNames** – This option will paste glyph names. Default is off.
* **PasteSpecialMetrics** – This option will paste metrics. Default is on.
* **PasteSpecialMetricsOption** – This option will paste metrics. Default is 0 (Side bearings).
* **PasteSpecialOutlineData** – This option will paste outline data. Default is on.

### Externals (used in Tools: Launch Externals)
There are three built-in external programs: **MainType** (it hides if the program is not installed), **Fonts Folder** and **Character Map** (you can get rid of it in Windows 95 up to Windows XP via **Control Panel: Add or Remove Programs: Add/Remove Windows Features: Components: Accessories and Utilities: Accessories: Character Map** or in Windows Vista & above by taking ownership of `charmap.exe` and `charmap.exe.mui` and deleting it).
* **Location#** – The last character contains three values. Default is empty.
* **Title#** – The last character contains three values. Default is **External #** whereas the last character is a number.

### Find (version 3.0 until 6.5, used in `TFINDFORM`)
* **FindLanguageID** – Select language identifier.
* **PlatformID** – Select **Platform** identifier in the Mapping tab.
* **PlatformSpecificEncodingID** – Select **Platform** specific encoding identifier in the Mapping tab.
* **TabIndex** – Changes tab in this form. Default is 0.

### FontOverview (used in `TFONTOVERVIEWFORM`)
* **CategoryWidth** – Select the category splitter width.

### Fonts (used in the Font tab in `TOPTIONSFORM` – default is on for all options)
* **ExportDecomposeScaled** (version 12.0.0.2521 & above) – Used with **Export Font: Decompose composite glyphs with scaled components**.
* **ExportExcludeLegacy** – Used with **Export Font: Exclude legacy data**.
* **FontEnableOpenContours** (version 11.5.0.2421 & above) – Used with **Special Features: Enable open contours**.
* **OpenFriendlyGlyphNames** – Used with **Open Font: Generate friendly glyph names**.

### FreeDraw (version 6.5 & above)
* **BrushWidth** – Changes the **Brush width**. Default is 64.

### Glyph Edit Window
* **FilledOutline** – Used with **Fill Outline** in the Grid toolbar. Default is on. See `GlyphFillAlpha` in **Interface Settings** below in newer versions.
* **ShowConnectionsBetweenPoints** – Show connection lines between points (**Show Connection** in the Grid toolbar). Default is on.
* **ShowFirstAndLastPointIndicators** – Show first and last point indicators (**Show First and Last** in the Grid toolbar). Default is on.
* **ShowToolbarWindowBackground** – Show or hide the Background Image toolbar. Default is off.
* **ShowToolbarWindowKerning** – Show or hide the preview window. Default is off.
* **ShowToolbarWindowMembers** – Show or hide members for colored fonts. Default is off.
* **ShowToolbarWindowPalette** – Show or hide the palette for colored fonts. Default is off.
* **ShowToolbarWindowTransformation** – Show or hide the transformation toolbar. Default is on.
* **ShowToolbarWindowValidation** – Show or hide the validation report (**Show Report** in the Glyph toolbar). Default is off.

### Grid
* **FixedGridColor** – Set the fixed grid color in `TGRIDFORM`. Default is white.
* **FixedGridLineStyle** – Set the fixed grid line style in `TGRIDFORM`. Default is solid.
* **GridColor** – Set the grid color in `TGRIDFORM`. Default is sky blue.
* **GridDistance** – Used with **Minimum distance between grid points in units** in `TGRIDFORM`.
* **GridDistancePixels** – Used with **Mininum distance between grid points in pixels** in `TGRIDFORM`.
* **GridLineStyle** – Set the line style in `TGRIDFORM`. Default is solid.
* **IncludeBaseline** – Used with **Baseline** in `TMETRICSFORM`. Default is on.
* **IncludeLeftSideBearing** – Used with **Left side bearing** in `TMETRICSFORM`. Default is on.
* **IncludeRightSideBearing** – Used with **Right side bearing** in `TMETRICSFORM`. Default is on.
* **IncludeTypoAscender** – Used with **TypoAscender** in `TMETRICSFORM`. Default is off.
* **IncludeTypoDescender** – Used with **TypoDescender** in `TMETRICSFORM`. Default is off.
* **IncludeWinAscent** – Used with **Win Ascent** in `TMETRICSFORM`. Default is on.
* **IncludeWinDescent** – Used with **Win Descent** in `TMETRICSFORM`. Default is on.
* **IncludexHeight** – Used with **x-Height** in `TMETRICSFORM`. Default is on.
* **IncludeYAxis** – Used with **Y-Axis** in `TMETRICSFORM`. Default is on.
* **LockUserDefinedGuidelines** (version 4.5 & above) – Used witj **Lock Guidelines** in the Grid toolbar. Default is off.
* **ShowBearings** (version 5.6 & above) – Used when with **Show Metrics** in the Grid toolbar. Default is on.
* **ShowFixedGridLines** (version 5.6 & above) – Used with **Show reference lines at x = 0, y = 0** in `TGRIDFORM`.
* **ShowGrid** – Used with **Show Grid** in Grid Options or in the Grid toolbar. Default is on.
* **ShowUserDefinedGuidelines** – Used with **Show Guidelines** in Guidelines Options or in the Grid toolbar. Default is on.
* **SnapToGrid** (version 4.0 & above) – Used with **Snap to Grid** in the Grid toolbar. Default is off.
* **SnapToUserDefinedGuidelines** (version 4.0 & above) – Used with **Snap to Guidelines** in the Grid toolbar. Default is off.

### GUI
* **UpdateCheckInterval** – Set this value in **Startup: Check for updates** in the General tab in `TOPTIONSFORM` to 000 (never), 001 (every day), 007 (once a week), 030 (once a month), 182 (twice a year) or 365 (once a year). Default is 007 (once a week).

### GuideLines (version 3.0 until 6.5, used in `TGUIDELINESFORM`)
* **Color** – Set the color. Default is black.
* **LineStyle** – Set the line style. Default is solid.

### ImportImage (used in `TCONVERTBITMAPTOCONTOURSFORM`)
* **BitmapPositionOrigin** – Used with radio buttons of all corners in **Glyph: Position**. Default is center.
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
* **InstallFontsInFontsFolder** – Disable this option if you don't want to **Install the font in Windows Fonts folder**. Default is on. In Windows Vista & above, the button adds the UAC shield before the label.

### InstalledFonts (used in `TINSTALLEDFONTSFORM`)
* **PreviewHeight** – Set the height in the font preview area (version 5.5 & above) at the bottom. Default is 124.

### Interface (used in the toolbar context menu or View: Toolbars in `TMAINFORMFONTCREATOR`)
* **LockToolbars** (version 11.0 & above) – Used with **Lock Docked Toolbars**. Default is off.
* **ShowUserNotes** – Used with **Show User Notes**. Default is off.

### Interface Settings
* **ChildWindowState** – Contains the child window state.
* **CompleteCompositesAction** – Set to either 1 (auto), 2 (anchor based), 3 (anchor based reposition) or 4 (composite data) to **Complete Composites**. Default is 1 (auto).
* **CustomNamingShowOutputContent** – Used by **Custom: Additional Naming Fields: Show Output Content** in `TFONTPROPERTIESFORM`. Default is on.
* **ExportSettingsPage** – Select page in `TEXPORTSETTINGSFORM` and `TEXPORTSETTINGSFRAME`. Default is 0 (Desktop Font (ttf/otf)).
* **GlyphCaptionAuto** – Used with **Glyph Caption: Automatic** (Glyph Index) in the context menu in `TFONTOVERVIEWFORM`.
* **GlyphCaptionType2** – Used with the Captions options in the context menu in `TFONTOVERVIEWFORM`. Default is Auto.
* **GlyphDrawMode** – Set to 2 (auto), 0 (monochrome) or 1 (color). Default is 2 (auto).
* **GlyphFillAlpha** (version 11.0.0.2365 & above) – Used with **View: Fill Outline**. Default is solid.
* **GlyphNamesHistoryReplace** (version 11.0.0.2365 & above) – Contains the history of replaced postscript names in `TGLYPHNAMEFORM`.
* **GlyphNamesHistorySearch** (version 11.0.0.2365 & above) – Contains the history of found postscript names in `TGLYPHNAMEFORM`.
* **GlyphNamesOptionsCS** – Used with **Options: Case sensitive** in `TGLYPHNAMEFORM`. Default is on.
* **GlyphNamesOptionsRE** – Used with **Options: Regular expressions** in `TGLYPHNAMEFORM`. Default is off.
* **GlyphOutlineFillMode** – Used with **Glyph outline fill mode** in Options: General. Default is 0 (Winding).
* **GlyphPropsExpanded** – Expands glyph properties by pressing **More** at the bottom left corner. Default is on.
* **GroupManagerSorted** – Sorts the group manager.
* **InsertGlyphsCB1** and **InsertGlyphsCB2** (version 12.0) – Set this value in `TINSERTGLYPHFORM` to insert glyphs at the top (0), after the last glyph (1), before (2) or after selected glyphs (3). Default is 3 (after selected glyphs).
* **InsertGlyphsPage** – Changes tab in `TINSERTGLYPHFORM`.
* **KerningFolderExport** – Select the directory to export the old `KERN` table.
* **KerningFolderImport** – Select the directory to import the old `KERN` table.
* **NewFontIncludeOutlines** (version 5.6 & above) – Used with **Predefined outlines: Include outlines** in `TNEWTRUETYPEFONTFORM` (the predefined outlines are from Garava). Default is on.
* **OpenDialogInitialDir2** – Contains the directory in the Open dialog from `TMAINFORMFONTCREATOR`. Default is user's font folder.
* **OpenDialogInitialDirAutoKerning** (version 2.0 until 6.5) – Contains the directory in the Open dialog from `TAUTOKERNEXFORM`.
* **OpenDialogInitialDirImportImage2** – Contains the directory in the Open dialog from `TCONVERTBITMAPTOCONTOURSFORM`.
* **OpenDialogInitialDirNamingField2** – Contains the directory in the Open dialog from `TADDCUSTOMNAMINGFORM`. Default is desktop.
* **OpenDialogInitialDirTransform3** – Contains the directory in the Open dialog from `TPERFORMTRANSFORMATIONFORM`. Default is program's transform folder.
* **OptionsPage** – Changes tab in `TOPTIONSFORM`. Default is 0 (General).
* **OTLFDesignerCollapsedFeatures** – Contains features collapsed in `TOPENTYPEDESIGNERFORM`.
* **OTLFDesignerCollapsedLookups** – Contains lookups collapsed in `TOPENTYPEDESIGNERFORM`.
* **OTLFDesignerCollapsedScripts** – Contains scripts collapsed in `TOPENTYPEDESIGNERFORM`.
* **OTLFDesignerPairFilterFirst** – Contains the preceding character to filter kerning pairs.
* **OTLFDesignerPairFilterSecond** – Contains the succeeding character to filter kerning pairs.
* **OTLFDesignerPairKindFirst** – Filters the first kind of kerning pair.
* **OTLFDesignerPairKindSecond** – Filters the last kind of kerning pair.
* **OTLFDesignerPreviewLanguage** – Select language for `TOPENTYPEDESIGNERFORM` preview text. Default is **Auto**.
* **OTLFDesignerPreviewSampleText** – Contains preview sample text for `TOPENTYPEDESIGNERFORM`. Default is **The five boxing wizards jump quickly**.
* **OTLFDesignerPreviewScript** – Select script for `TOPENTYPEDESIGNERFORM` preview text. Default is **Auto**.
* **OTLFDesignerSingleFilter** – Used for single filter in `TOPENTYPEDESIGNERFORM`.
* **OTLFDesignerSingleKind** – Used for single kind in `TOPENTYPEDESIGNERFORM`.
* **OTLFEditor** – Contains settings used by `TCODEEDITORFORM` such as font setting, displaying line numbers or word wrapping.
* **OverviewColCat** – Contains the column categories used in `TFONTOVERVIEWFORM`.
* **OverviewFontZoom** – Zoom the glyphs in `TFONTOVERVIEWFORM`. Default is 35.
* **OverviewGridZoom** – Zoom the grid in `TFONTOVERVIEWFORM`.
* **OverviewSampleFont** (version 4.0 & above) – Used with **Font Overview: Font used in cells** in the View tab in `TOPTIONSFORM`. Default is **Arial**. If this string is empty, the characters are shown in **MS Sans Serif**.
* **OverviewShowCaption** (version 3.0 until 6.5) – Used with **Font overview: Show caption** in the Overview tab in `TOPTIONSFORM`. Default is on.
* **OverviewShowSample** – Used with **Font Overview: Show sample in empty glyphs** in the Overview tab in `TOPTIONSFORM`. Default is on.
* **OverviewSingleHeight** (version 3.0 until 6.5) – Used with **Font overview: Glyph height** in the Overview tab in `TOPTIONSFORM`. Default is 48.
* **OverviewSingleWidth** (version 3.0 until 6.5) – Used with **Font overview: Glyph width** in the Overview tab in `TOPTIONSFORM`. Default is 70.
* **OverviewSmoothGlyphs** – Used with **Font overview: Smooth glyphs** in the Overview tab in `TOPTIONSFORM`. Default is off.
* **OverviewUndoLimitMaxCount** – Used with **Undo limits: Max. count** in the Edit tab in `TOPTIONSFORM`. Default is 1.
* **OverviewUndoLimitMaxSize** – Used with **Undo limits: Max. size [KB]** in the Edit tab in `TOPTIONSFORM`. Default is 1.
* **OverviewUseColor** – Used with **Font overview: Use type color in glyph caption** in the Font tab in `TOPTIONSFORM`. Default is on.
* **SampleFileName** – Used with **Samples Toolbar Font: Filename** in Options: General. Default is empty (many sample glyphs are derived from the regular styles of Garava and Times New Roman).
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
* **File_#** – Include fonts from last time or fonts and/or projects in the **File: Reopen** menu whereas the last character (#) is a number. Old versions stores up to 7 files while recent versions stores up to 20 fonts and/or projects. The **File: Reopen** menu will appear empty (recent versions) or dimmed (old versions) if the above keys are removed or if **Clear file list** is selected from the menu. When `OnStartupOpenFonts` is enabled, nothing is opened if removed.

### Metrics (used in `TAUTOMETRICSFORM`)
* **AutoMetricsExcludeEmptyGlyphs** – Used with **Additional Options: Exclude empty glyphs (recommended)**.
* **AutoMetricsFixedAW** – Used with **Fixed Width: Advance Width**. Default is 2048.
* **AutoMetricsFixedChangeAW** – Used with **Fixed: Change Advance Width**.
* **AutoMetricsFixedChangeLSB** – Used with **Fixed: Change Left Side Bearing**.
* **AutoMetricsFixedLSB** – Used with **Fixed: Change Left Side Bearing** spinner.
* **AutoMetricsOpticalFactor** – Used with **Glyph spacing factor (usually between 20 and 30)** in Optical Metrics. Default is 27.
* **AutoMetricsOpticalFigures** – Select the option in **Set character width for digits as** to 0 (Tabular figures), 1 (Proportional figures) or 2 (No change). Default is 0 (Tabular figures).
* **AutoMetricsOpticalPreview** – Used with **Preview Text** in Optical Metrics. Default is **Preview Text**.
* **AutoMetricsOptionIndex2** – Set to 0 (Optical Metrics), 1 (Fixed Bearings), 2 (Fixed Width) or 3 (Fixed Height). Default is 0 (Optical Metrics).
* **AutoMetricsWhiteSpaceAfter** – Used with **Fixed Bearings: Space after**. Default is 100.
* **AutoMetricsWhiteSpaceBefore** – Used with **Fixed Bearings: Space before**. Default is 100.

### MetricsAndKerning (used in the Comparison toolbar in `TMAINFORMFONTCREATOR`)
* **MetricsAndKerningKerningEnabled** – Enable or disable the old `KERN` table (version 3.0 until 6.5) or OpenType features (version 7.0 & above). Default is off.
* **MetricsAndKerningTextEnabled** – Used with **Show text before and after glyph**. Default is off.
* **MetricsAndKerningTextLeft** – Contains the preceding character in the **Before** text box. Default is empty.
* **MetricsAndKerningTextRight** – Contains the succeeding character in the **After** text box. Default is empty.

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

### OpenType Generator (version 12.0, used in `TFEATURESETTINGSFORM`)
All keys beginning with Include are enabled by default.
* **CPSPKind** – Used with the dropdown box at **Spacing and Positioning: Capital Spacing (cpsp)**. Default is 0 (Percentage of advance width).
* **CPSPPerc** – Contains the percentage in the **Spacing and Positioning: Capital Spacing (cpsp)** spinner. Default is 5.00%.
* **IncludeAalt** – Used with **Other Forms and Variants: Access All Alternates (aalt)**.
* **IncludeAltFractions** – Used with **Numerals: Alternative Fractions (e.g. stacked) (afrc)**.
* **IncludeAnchorBased** – Used with **Spacing and Positioning: Anchor Based Positioning (ccmp, mark, mkmk)**. In order to include this feature, each letter should have anchors.
* **IncludeCapitalSpacing** – Used with **Spacing and Positioning: Capital Spacing (cpsp)**. This feature excludes fullwidth Latin characters. Including it in monospace or bitmap fonts may cause metrics issues.
* **IncludeCase** – Used with **Other Forms and Variants: Case-Sensitive Forms (case)**.
* **IncludeCharacterVariants** – Used with **Other Forms and Variants: Character Variants (cv01-cv99)**. [Bhikkhu Pesala](http://www.softerviews.org/Fonts.html) uses this feature in his fonts for ! * + @ © × † ‡ • ○ ● ☀.
* **IncludeCursive** – Used with **Spacing and Positioning: Cursive Positioning (cursive script only) (curs)**.
* **IncludeDlig** – Used with **Other Forms and Variants: Discretionary Ligatures (dlig)**.
* **IncludeFina** – Used with **Terminal Forms (fina, fin2, fin3)**.
* **IncludeFractions** – Used with **Numerals: Fractions (diagonal) (frac, dnom, numr)**.
* **IncludeFractionsAdv** – Used with **Numerals: Fractions (diagonal) (frac, dnom, numr): Extended (smart math format)**.
* **IncludeHlig** – Used with **Other Forms and Variants: Historical Ligatures and Historical Forms (hlig, hist)**. The `hist` feature uses the last character from the *Latin Extended-A* range of Unicode.
* **IncludeInit** – Used with **Initial Forms (init)**. This feature uses several initial characters from the *Arabic* and *Arabic Supplement* ranges of Unicode.
* **IncludeIsol** – Used with **Isolated Forms (isol)**. This feature uses several isolated characters from the *Arabic* and *Arabic Supplement* ranges of Unicode.
* **IncludeLiga** – Used with **Other Forms and Variants: Standard Ligatures (liga)**. This feature uses the first five Latin characters from the *Alphabetic Presentation Forms* range of Unicode. Including it for letters in monospace fonts may cause bugs (e.g. Noto Sans Mono).
* **IncludeLnum** – Used with **Numerals: Lining Figures (lnum)**.
* **IncludeLoclCommon** – Used with **Localized Forms (locl): Common Localized Forms (CAT, NLD, TRK, ROM)**.
* **IncludeLoclCustom** – Used with **Localized Forms (locl): Custom Localized Forms (loclLANG)**.
* **IncludeMedi** – Used with **Medial Forms (medi, med2)**. This feature uses several medial characters from the *Arabic* and *Arabic Supplement* ranges of Unicode.
* **IncludeNalt** – Used with **Other Forms and Variants: Alternate Annotation Forms (nalt)**. This feature uses the circled numbers and Latin alphabet from the **Enclosed Alphanumerics** block of Unicode and initial, isolated, medial or terminal forms of Arabic letters if they exist.
* **IncludeOnum** – Used with **Numerals: Oldstyle Figures (onum)**. In order to generate this feature, the PostScript name for each glyph should have `.onum` at the end.
* **IncludeOrdinals** – Used with **Other Forms and Variants: Ordinals (ordn)**.
* **IncludeOrdinalsExt** – Used with **Other Forms and Variants: Ordinals (ordn): Extended (use .ordn or .sups for all letters)**.
* **IncludeOrnaments** – Used with **Other Forms and Variants: Ornaments (ornm)**. [Bhikkhu Pesala](http://www.softerviews.org/Fonts.html) uses this feature in his fonts to replace two letters with chess pieces.
* **IncludePetiteCapitals** – Used with **Other Forms and Variants: Petite Capitals (pcap, c2pc)**. [Bhikkhu Pesala](http://www.softerviews.org/Fonts.html) uses a subset for this feature in his fonts, including only common punctuation and the Latin/Greek alphabets with diacritics for Classical Sanskrit (without Vedic Sanskrit).
* **IncludePnum** – Used with **Numerals: Proportional Figures (pnum)**.
* **IncludeSalt** – Used with **Other Forms and Variants: Stylistic Alternates (uses ss01) (salt)**. [Bhikkhu Pesala](http://www.softerviews.org/Fonts.html) uses this feature in his fonts to replace Classical Sanskrit text using the Velthuis system.
* **IncludeSinf** – Used with **Numerals: Scientific Inferiors (sinf)**.
* **IncludeSmallCapitals** – Used with **Other Forms and Variants: Small Capitals (scap, c2sc)**. [Bhikkhu Pesala](http://www.softerviews.org/Fonts.html) uses a subset for this feature in his fonts, including only common punctuation and the Latin/Greek alphabets with diacritics for Classical Sanskrit. The [TITUS Cyberbit Basic font](http://titus.uni-frankfurt.de/unicode/unitest2.htm) includes only glyphs for the Latin alphabet, numbers and þġṅṙṡṫḅḍg̣ḷṃṇṛṣṭ (without the OpenType feature).
* **IncludeStylisticSets** – Used with **Other Forms and Variants: Stylistic Sets (ss01-ss20)**. [Bhikkhu Pesala](http://www.softerviews.org/Fonts.html) uses this for decorative drop capitals in Cankama, Odana, Pali, and Talapanna (colored) as a contextual substitution.
* **IncludeSubs** – Used with **Other Forms and Variants: Subscript (subs)**. The [TITUS Cyberbit Basic font](http://titus.uni-frankfurt.de/unicode/unitest2.htm) uses a subset including only numbers, some letters in the Latin alphabet and punctuation and ä ī ù ú (without the OpenType feature).
* **IncludeSups** – Used with **Other Forms and Variants: Superscript (sups)**. [Bhikkhu Pesala](http://www.softerviews.org/Fonts.html) uses a subset in his fonts, including either only common punctuation and the Latin alphabet, with Latin-1 and Classical Sanskrit diacritics (Garava) or the Latin alphabet, è (French) and ú (Irish) (other fonts). The [TITUS Cyberbit Basic font](http://titus.uni-frankfurt.de/unicode/unitest2.htm) uses a subset including only numbers, some letters in the Latin alphabet and punctuation and ä i̯ ı u̯ ü (without the OpenType feature).
* **IncludeSwsh** – Used with **Other Forms and Variants: Swash (swsh)**. [Bhikkhu Pesala](http://www.softerviews.org/Fonts.html) included this feature in the upright styles of his fonts.
* **IncludeTitl** – Used with **Other Forms and Variants: Titling (titl)**.
* **IncludeTnum** – Used with **Numerals: Tabular Figures (tnum)**.
* **IncludeZero** – Used with **Numerals: Slashed Zero (zero)**.

### Options
* **AlwaysCreateBackupCopy** – Used with **Create backup copy (bck) on saving a font project** in the Advanced tab in `TOPTIONSFORM`. Default is off.
* **AutoFitGlyphInWindow** – Used with **Glyph Edit Window: Auto fit glyph in Window** in the Glyph tab in `TOPTIONSFORM`. Default is on.
* **AutoNamingUseFontRevision** (version 5.5 until 6.5) – Used with **Automatic Naming Wizard: Version String: use Font revision version from Font Settings → Header page** in the Naming tab in `TOPTIONSFORM`. Default is on.
* **CompressHmtxTable** (version 5.5 until 6.5) – Used with **When Saving Font Files: Compress hmtx table** in the Font tab in `TOPTIONSFORM`. Default is on.
* **CompressNameTable** (version 5.5 until 6.5) – Used with **When Saving Font Files: Optimize name table** in the Font tab in `TOPTIONSFORM`. Default is on.
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
* **DefaultPersFontEmbeddingItemID** – Used with **Default Settings for New Fonts: Embedding Lic. Rights** in the Personalize tab in `TOPTIONSFORM`. Default is 0 (Installable (no embedding restrictions)).
* **DefaultPersVendorIDText** – Used with **Default Settings for New Fonts: Vendor ID** in the Personalize tab in `TOPTIONSFORM`. Default is **HL**.
* **DefaultPersVendorText** – Used with **Default Settings for New Fonts: Vendor** in the Personalize tab in `TOPTIONSFORM`. Default is **High-Logic / Made with FontCreator**.
* **DefaultPersVendorURLText** – Used with **Default Settings for New Fonts: Vendor URL** in the Personalize tab in `TOPTIONSFORM`. Default is empty.
* **DefaultVendorIDIncluded** – Used with **Default Settings for New Fonts: Vendor ID** in the Personalize tab in `TOPTIONSFORM`. Default is on.
* **DefaultVendorIncluded** – Used with **Default Settings for New Fonts: Vendor** in the Personalize tab in `TOPTIONSFORM`. Default is off.
* **DefaultVendorURLIncluded** – Used with **Default Settings for New Fonts: Vendor URL** in the Personalize tab in `TOPTIONSFORM`. Default is off.
* **DefaultZoomFactor** – Used with **Glyph Edit Window: Open with default zoom factor** in the View tab in `TOPTIONSFORM`.
* **ExcludeMonospacedFonts** – Used with **When Saving Font Files: Exclude monospaced fonts** in the Font tab in `TOPTIONSFORM`. Default is off.
* **IgnoreHintingData** – Used with **When Opening Font Files: Remove hinting data** in the Font tab in `TOPTIONSFORM`. Default is off.
* **IgnoreUnsupportedTables** – Used with **When Opening Font Files: Remove unsupported tables** in the Font tab in `TOPTIONSFORM`. Default is off.
* **LastUpdateReminderDate** (`LastUpdateCheck` in `HKCU\Updates` in newer versions) is the date used to check the last update when **Startup: Show update reminder** in the General tab in `TOPTIONSFORM` is enabled.
* **LeftSideBearingExcludeLargeFonts** (version 5.5 until 6.5) – Used with **When Saving Font Files: Set left side bearing point at x=0: Exclude large (1500+) fonts** in the Font tab in `TOPTIONSFORM`. Default is on.
* **LongAlignedLocalOffsets** – Used with **When Saving Font Files: Long-aligned local offsets** in the Font tab in `TOPTIONSFORM`. Default is on.
* **OnStartupOpenFonts** (version 5.6 & above) – Used with **Startup: On start open fonts from last time** in the General tab in `TOPTIONSFORM` to open fonts from the `Last Time` registry key. Default is on.
* **OnStartupShowUpdateReminder** (`UpdateCheckInterval` in `GUI` in recent versions) – Set this value used with **Startup: Show update reminder** in the General tab in `TOPTIONSFORM` to 0 (Never), 1 (Once a year), 2 (Twice a year) or 3 (Once a month). Default is 1 (Once a year).
* **OnStartupShowWelcome** – Used with **Startup: On start show Welcome dialog** in the General tab in `TOPTIONSFORM`. Default is on.
* **PanoseValueHexadecimal** – Used with **PANOSE: Value: Show hexadecimal** in the Characteristics tab in `TFONTSETTINGSFORM`. Default is off.
* **RecalcAverageCharWidth** – Used with **When Saving Font Files: Recalc average char width** in the Font tab in `TOPTIONSFORM`. Default is on.
* **RecalcGlyphBoundingBoxes** – Used with **When Saving Font Files: Recalc glyph bounding boxes** in the Font tab in `TOPTIONSFORM`. Default is off.
* **RemoveDSIGTable** (version 3.0 until 6.5) – Used with **When Opening Font Files: Remove DSIG table** in the Font tab in `TOPTIONSFORM`. Default is off. **Fun fact:** FontForge ignores this table when opening fonts. In order to install OpenType flavored PostScript fonts (otf) in macOS, this table is required to be present.
* **RemoveHdmxTable** (version 3.0 until 6.5) – Used with **When Opening Font Files: Remove hdmx table** in the Font tab in `TOPTIONSFORM`. Default is on. **Fun fact:** FontForge ignores this table when opening fonts.
* **RemoveLTSHTable** (version 3.0 until 6.5) – Used with **When Opening Font Files: Remove LTSH table** in the Font tab in `TOPTIONSFORM`. Default is on. **Fun fact:** FontForge ignores this table when opening fonts.
* **RemoveVDMXTable** (version 3.0 until 6.5) – Used with **When Opening Font Files: Remove VDMX table** in the Font tab in `TOPTIONSFORM`. Default is on. **Fun fact:** FontForge ignores this table when opening fonts.
* **SetLeftSideBearingPointAtX0** (version 4.5 & above) – Used with **When Saving Font Files: Set left side bearing point at x=0** in the Font tab in `TOPTIONSFORM`. Default is on.
* **UnicodeEnabledGUI** (version 5.5 until 6.5) – Used with **Unicode Support: Enable Unicode support for text display and user input** in the General tab in `TOPTIONSFORM`. Default is on. In Windows 9x/ME or in compatibility mode, the option will appear dimmed.
* **UpdateModifiedDateTimeField** (version 3.0 until 6.5) – Used with **Identification: Automatically update modified timestamp when exporting font** in the Identification tab in `TFONTSETTINGSFORM`. Default is on (since version 7.0 & above it is enabled for any opened font).
* **ValueHexadecimal** – Used with **Values: Hexadecimal** in the View: Display Format menu of `TMAINFORMFONTCREATOR`. Default is on. **Fun fact:** Hexadecimal values in Delphi are usually given with a dollar sign ($).
* **VectorImageEPSForceRepositioning** (version 6.0 & above) – Used with **Vector Based Images (EPS, AI, PDF, SVG): Move imported outlines to origin (0,0)** in the Import tab in `TOPTIONSFORM`. Default is off.
* **VectorImageEPSOriginX** (version 6.0 & above) – Used with **Vector Based Images (EPS, AI, PDF, SVG): Origin X** in the Import tab in `TOPTIONSFORM`. Default is 100.00.
* **VectorImageEPSOriginY** (version 6.0 & above) – Used with **Vector Based Images (EPS, AI, PDF, SVG): Origin Y** in the Import tab in `TOPTIONSFORM`. Default is 600.00.
* **VectorImageEPSPixelsPerEm** (version 6.0 & above) – Used with **Vector Based Images (EPS, AI, PDF, SVG): Pixels per em** in the Import tab in `TOPTIONSFORM`. Default is 512.00.

### Preview
* **FeaturesWidth** (version 7.0 & above) – Changes width in the OpenType feature splitter.
* **FeatureTags** (version 7.0 & above) – Contains the tags used to enable or disable OpenType features. Default is empty.
* **PreviewFeatures** (version 7.0 & above) – Enables or disables OpenType features in the preview text.
* **PreviewFontSize** – Select the size in `TFONTTESTFORM`.
* **PreviewSampleFontSize** – Scale the font in the Preview window. Default is 24.
* **PreviewSampleText** – Contains sample text in the Preview window. Default is **High-Logic ©** (old versions) or **&lt;enter preview text here&gt;**.
* **PreviewSampleUseKerning** (version 3.0 until 6.5) – Set this value to on to kern text in the Preview window. Replaced with `PreviewFeatures` in version 7.0 & above.
* **ShowToolbarWindowPreview** – Show or hide the Preview window. Default is on.
* **StrikeThrough** – Strikes out text in `TFONTTESTFORM`. Default is off.
* **Underline** – Underlines text in `TFONTTESTFORM`. Default is off.

### Reg
The program is unregistered after the installation process is completed successfully. Many people and companies provided registration keys for different versions to crack the program.
* **V5D#** – The # at the end is a numerical string. If the program detects that it is registered, a message is shown thanking the user for registering, add the user name to the title bar (version 6.0 & above) and removes the **Register** button in `TTIPOFTHEDAYFORM` (version 1.0 until 6.5), **Buy** menu and the **Register** item on the Help menu.

### Themes (version 3.0 until 6.5)
* **ActiveTheme** – Contains the active theme.

### Tip of the Day (version 3.0 until 6.5, used in `TTIPOFTHEDAYFORM`)
* **CurrentTip** – Line number in `FontCreator.tip`. This number increases by one line when closed. Default is first line.
* **ShowTipOnStartup** – Used with **Show this screen next time when you start FontCreator**. Default is on (always show on startup).

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
* **TestFixDetectedProblems** – Used with **Fix detected problems** in `TVALIDATIONWIZARDFORM`. Default is off.
* **TestIntersectingComponents** – Used with **Validation Tests: Intersecting components** in `TVALIDATIONWIZARDFORM`. Default is on.
* **TestIntersectingCoordinates** – Used with **Validation Tests: Intersecting coordinates** in `TVALIDATIONWIZARDFORM`. Default is on.
* **TestOffCurveExtremeCoordinates** – Used with **Validation Tests: Off-curve extreme coordinates** in `TVALIDATIONWIZARDFORM`. Default is on.
* **TestOverlappingComponents** – Used with **Validation Tests: Overlapping components** in `TVALIDATIONWIZARDFORM`. Default is on.
* **TestRedundantPoints** – Used with **Validation Tests: Redundant points** in `TVALIDATIONWIZARDFORM`. Default is on.
* **TestSuspiciousPoints** (version 11.0.0.2365 & above) – Used with **Validation Tests: Suspicious points** in `TVALIDATIONWIZARDFORM`. Default is on.
* **ValidationMaxNumberOfCompositeGlyphMembers** – Used with **Real-time glyph validation: Disable when number of members exceeds** in the Validation tab in `TOPTIONSFORM`. Default is 1000.
* **ValidationMaxNumberOfContours** – Used with **Real-time glyph validation: Disable when number of contours exceeds** in the Validation tab in `TOPTIONSFORM`. Default is 100.
* **ValidationMaxNumberOfPoints** – Used with **Real-time glyph validation: Disable when number of points exceeds** in the Validation tab in `TOPTIONSFORM`. Default is 25.

### Warn (used in Options: Advanced – default is on for all options)
* **WarnBeforeActivatingFixFeature** (version 5.0 until 6.5) – Used with **Warn before activating the fix feature in the Font Validation Wizard**.
* **WarnBeforeActivatingRemoveFeature** (version 5.0 until 6.5) – Used with **Warn before activating a remove feature from the Options → Font page**.
* **WarnBeforeAddCharacters** (version 5.0 until 6.5) – Used with **Warn before adding characters**.
* **WarnBeforeAnchorDelete** – Used with **Warn when deleting anchor**.
* **WarnBeforeCloseOpenTypeDesigner** – Used with **Warn about losing changes when cancelling or closing OpenType Designer dialog**.
* **WarnBeforeExecutingGlyphTransformProgram** – Used with **Warn before executing a glyph transformer script**.
* **WarnBeforeSortingGlyphs** (version 5.0 until 6.5) – Used with **Warn before sorting glyphs**.
* **WarnImportSmallImage** – Used with **Warn when importing small image**.
* **WarnWhenOpening10OrMoreFonts** – Used with **Warn when opening 10 or more fonts**.
* **WarnWhenProcessingVOLTTable** (version 9.0 & above) – Used with **Warn when opening a font file which contains a VOLT table**.

## Cursors in the executable file
All resources are named HL at the beginning.
* **HLADDCONTOUR** – Used when adding contours.
* **HLDUPLICATE** – Used when duplicating contours.
* **HLFREEDRAW** and **HLFREEDRAWBUSY** – Used by **Free Draw** (version 6.5 & above).
* **HLFREEHAND** – Used by **Freehand** (version 4.1 & above).
* **HLGUIDELINED** – Used by **Guideline**.
* **HLKNIFE** – Used by **Knife**.
* **HLMEASURE** – Used by **Measure** (version 4.1 & above).
* **HLMOVECONTOUR** – Used when moving contours.
* **HLMOVEPOINT** – Used when moving points.
* **HLNEWELLIPSE** – Used when adding ellipses.
* **HLNEWRECTANGLE** – Used when adding rectangles.
* **HLPAINTBUCKET** – Used by **Paint** for colored fonts (version .
* **HLROTATE** – Used by rotating contours (**Rotate**).
* **HLSEGMENT** – Used by **Paint** for colored fonts.
* **HLSELECT** – Used when selecting anything in the glyph.
* **HLSELECTCONTOUR** – Used when selecting contours.
* **HLSELECTPOINT** – Used when selecting points.
* **HLZOOMIN** – Used by **Zoom In**.
* **HLZOOMOUT** – Used by **Zoom Out**.

## RC Data in the executable file
* **CHARTABLE** (version 10.0 until 10.1.0.2272) – Shows a list of characters.
* **CLOUDS** (unused) – Image of clouds with different colors.
* **DESCRIPTION** and **ELDATA** (unused) – These are binary resources.
* **DVCLAL** (unused) – Shows two paragraphs (the license is valid and is running C++ Builder Professional).
* **PACKAGEINFO** (unused) – Shows the Pascal log used to compile the program.
* **PLATFORMTARGETS** (unused) – This binary resource only exists in version 11.5.
* **TABOUTDIALOG** and **TABSTRACTABOUTDIALOG** (**TABOUTFORM** and **THLCREGISTERABOUTBOXDLG** in old versions) – Displays copyright, program/operating system version number, physical memory, registration info and MPL Licensed Open Source Software (**Help: About...**).
* **TABSTRACTWELCOMEDIALOG** (**TWELCOMEFORM** in old versions) – Used by newcomers if `OnStartupShowWelcome` is enabled.
* **TADDCHARACTERSFORM** (version 5.0 & above) – Used when adding characters to the font. In **Go to Unicode Block**, **Sorted** is checked by default.
* **TADDCHARACTERTOGLYPHINDEXMAPPINGFORM** – Shown when pressing **Select** in `TCHARACTERTOGLYPHINDEXMAPPINGFORM` (old versions) or the Unicode button in the glyph properties (new versions) to assign Unicode values of characters for each glyph.
* **TADDCUSTOMNAMINGFORM** – Used by **Font Properties: Custom: Add...** to add custom naming fields for multiple languages.
* **TADDFPCVLTSFORM** – Adds labels, tooltips or samples to character variants in the font.
* **TADDFPSIZENAMEFORM** – Adds subfamily names to the font.
* **TADDFPSTYLISTICSETNAMEFORM** – Adds or writes stylistic set names or descriptions in the font.
* **TADDGASPFORM** – Adds gasp ranges to the font, shown when pressing **Add** in **Smoothing: Preferred rasterization techniques** in `TFONTSETTINGSFORM`.
* **TADDLOCALLANGUAGEDATAFORM** (version 2.0 until 6.5) – Shows a dialog to add naming fields for multiple languages to the font.
* **TADDPLATFORMFORM** (version 2.0 until 6.5) – Shows a dialog to add a platform to the font (**Add** in `TPLATFORMMANAGERFORM`).
* **TADDUVSFORM** – Used by East Asian fonts to add Unicode variation sequences.
* **TADVANCEDEDITFORM** – Edits one naming field in the font.
* **TANCHORMANAGERFRAME** and **TANCHORMANAGERFRM** (version 7.0 & above) – Used to manage anchors in the font if positioning data exists.
* **TAUTOKERNEXFORM** (**TAUTOKERNINGFORM** in version 3.0.1 until 6.5) – Shows a dialog to automatically add kerning pairs to the OpenType layout tables (version 7.0 & above) or legacy kerning tables (version 1.0 until 6.5).
* **TAUTOMETRICSFORM** (version 3.0.1 & above) – Shows a wizard to automatically generate metrics for glyphs. **Fun fact:** The optical metrics adjustment user interface is same as in Scanahand.
* **TAUTONAMEFORM** (version 5.0 until 6.5) – Shows a wizard to automatically change the naming fields of a font.
* **TBASICEDITFORM** (**TADVANCEDNAMINGFORM** in version 3.0 until 6.5) – Used when editing a naming field or including additional naming fields in the font (replaced with `TFONTPROPERTIESFORM` in version 7.0 & above).
* **TCHANGETAGFORM** (version 7.0 & above) – Shows a dialog to change tags in the font.
* **TCHARACTERTOGLYPHINDEXMAPPINGFORM** (version 2.0 until 6.5) – Shows a dialog to map characters to glyph indexes.
* **TCODEEDITORFORM** – Starts a utility to view or edit the OpenType feature code (**Code Editor** in `TOPENTYPEDESIGNERFORM`).
* **TCODEPAGERANGEFORM** – Includes or excludes code pages to support in the font. If no ranges are set in the font (e.g. Noto Sans), then Windows will show the script selection as **Other**.
* **TCOLORFORM** (old versions) – This dialog is not the Windows color selector.
* **TCOMPOSITEGLYPHPROPERTIESFORM** – Shows a dialog to view or modify the composite glyph properties.
* **TCONFIRMREPLACEDIALOG** (version 10.0 until 10.1.0.2272) – Confirmation dialog used when replacing.
* **TCONVERTBITMAPTOCONTOURSFORM** – Converts bitmap images to contours or import raster images for use with empty glyphs.
* **TDELETEFEATURELOOKUPFORM** (version 7.0 & above) – Shows a dialog to delete features or lookups in the font.
* **TDELETEKERNGROUPFORM** (version 7.0 & above) – Shows a dialog to delete kerning groups or classes in the font.
* **TDISABLEDFORM** – As of version 5.0 or 6.0 until 6.5 and 8.0 until 12.0.0.2550, if the program detects that it is not registered and is running after a grace period of 30 days, the program will disable saving (version 5.0 until 6.5), exporting, testing, installing fonts and extracting TrueType or OpenType collections (version 5.0 & above).
* **TDM** (version 4.0 & above) – Contains icons in the program. Version 5.0 (2005-01-12) up to 11.0.0.2365 (2017-05-10) uses icons from the Windows XP era.
* **TDMGLOBAL** – Contains codepages, vendors, hinting and bidirectional mirroring data in the program.
* **TEDITANCHORFORM** (version 7.0 & above) – Shows a dialog to edit anchors in the font.
* **TEXPORTGLYPHDATAFORM** – Shows a dialog to export glyph data in the font.
* **TEXPORTSETTINGSFORM** and **TEXPORTSETTINGSFRAME** – Configure settings to export the font as desktop or web format or both.
* **TEXTERNALSFORM** – Edits the external tools menu (**Tools: Launch Externals: Configure Externals...**).
* **TEXTRACTFROMTTCFORM** – Shows a wizard to extract OpenType font collections into separate font files (**Tools: Extract from OTC...**).
* **TFEATURESETTINGSFORM** (version 12.0) – Used when generating or updating OpenType features in `TOPENTYPEDESIGNERFORM`.
* **TFINDFORM** – Used when searching parts of a font.
* **TFONTEMBEDDINGLICENSINGRIGHTSFORM** (version 2.0 until 6.5) – Shows a list of embedding or licensing rights to use in the font (replaced with **Legal: Embedding Licensing Rights** in `TFONTSETTINGSFORM` in version 7.0 & above).
* **TFONTHEADERFLAGSFORM** – Shows a dialog to change header flags in the font.
* **TFONTINSTALLWIZARDFORM** – Installs the font and use it in other applications. **Fun fact:** The second step (font already installed) includes the Windows 98 directory (win98) preceding the fonts folder and the Arial font filename for regular style.
* **TFONTLOGFORM** – Displays the log for any font (**Developer Tools: Font Log**).
* **TFONTOVERVIEWFORM** – Shows all the glyphs in any font.
* **TFONTPROPERTIESFORM** – Contains properties and unsupported tables in the font. If East Asian language is used as non-Unicode language (e.g. Korean), in the **Unsupported Tables** tab it substitutes Latin-1 accented letters by ASCII versions, e.g. Wästman by Wastman and some Latin-1 symbols by fullwidth versions, e.g. ¬ by ￢ and £ by ￡ or other symbols, e.g. « by ≪.
* **TFONTSETTINGSFORM** – Contains tabs for basic or legal naming fields, basic metric settings, Unicode range and character encoding settings and more.
* **TFONTTABLESFORM** (version 2.0 until 6.5) – Shows a list of supported and unsupported tables in the font (unsupported tables is a separate tab in `TFONTPROPERTIESFORM` in version 7.0 & above).
* **TFONTTESTFORM** – Shows a dialog to test desktop fonts (not web fonts; the files are located in the WOFFTest folder). The text in `mmFontTest` and `Memo1` is the program name, uppercase (the last six letters continue on a new line), lowercase and numbers. Version 3.0 until 4.0 has a drop down list to change the encoding (the drop down list was removed with version 5.0 & above).
* **TFORMADDANCHOR** (version 7.0 & above) – Adds anchors to any glyph in the font if positioning data exists.
* **TFORMOPENTYPEDESIGNERSETTINGS** (version 7.0 & above) – Shows an interface for viewing and setting options in `TOPENTYPEDESIGNERFORM`.
* **TFORMULAFORM** (version 12.0) – Shows a dialog to write formulas to construct anchor based composite glyphs.
* **TFRAMECATEGORY** – Contains categories in the font overview (left side).
* **TFRAMEGLYPHMEMBER** – Used by `TGLYPHEDITFORM` when editing colored glyphs to display glyph members. Shown automatically when switching to color mode.
* **TFRAMEPALETTE** – Shows the color palette for use with multicolored fonts. Shown automatically when switching to color mode.
* **TGASPFORM** (version 2.0 until 6.5) – Manages gasps in the font (replaced with the Smoothing tab in `TFONTSETTINGSFORM` in version 7.0 & above).
* **TGENERATECONTOURSCANCELFORM** – Used when generating contours.
* **TGENERATEPROBLEMREPORTFORM** (version 3.0 until 11.5) – Used when pressing **Next** in `TVALIDATIONWIZARDFORM`.
* **TGLYPHALREADYMAPPEDFORM** (version 2.0 until 6.5) – For each platform a character to glyph index mapping can only exist once, so if you try to add a mapping that already exists this window will ask you what to do.
* **TGLYPHEDITFORM** – Used when opening any glyph from `TFONTOVERVIEWFORM`.
* **TGLYPHNAMEFORM** (version 7.0 & above) – Changes glyph names in the font (**Tools: Glyph Names**).
* **TGLYPHPROPERTIESFORM** (version 2.0 until 6.5) and **TGLYPHPROPERTIESFRAME** (version 7.0 & above) – Shows a dialog to view or edit properties for the selected glyph.
* **TGRIDFORM** – Shows an interface for viewing and setting grid options.
* **TGUIDELINEMODIFYFORM** – Shows a dialog to modify guidelines.
* **TGUIDELINESFORM** – Shows an interface for viewing and setting guidelines options.
* **TIMPORTGLYPHDATAFORM** – Shows a dialog to import glyph data.
* **TINSERTGLYPHFORM** – Shows a dialog to insert glyphs to the font.
* **TINSTALLEDFONTSFORM** – Shows a list of installed fonts on a dialog. Version 10.1.0.2272 (2016-12-20) & below had a waiting delay.
* **TKERNFEATUREFRAME** – Used by `TKERNINGFORM`.
* **TKERNGROUPMANAGERFORM** (version 7.0 & above) – Shows a dialog to manage kerning groups or classes in the font.
* **TKERNINGFORM** (version 3.0 until 8.0) – Views or edits the old `KERN` table (not the GPOS kerning tables) in the font (replaced with `TOPENTYPEDESIGNERFORM` in version 7.0 & above).
* **TKERNINGNEWPAIRFORM** (version 3.0 until 8.0) – Adds a kerning pair to the old `KERN` table (not the GPOS kerning tables).
* **TKERNINGNEWSINGLEFORM** (version 7.0 & above) – Adds a single adjustment to the font.
* **TMAINFORMFONTCREATOR** (**TMAINFORMFCP3** in version 3.0) – Contains a lot of things like the app main window, glyph transformation (simple glyphs only), glyph properties, user notes, font preview, glyph validation report and more.
* **TMETRICSFORM** – Shows an interface for viewing and setting metrics options.
* **TNAMINGFORM** (version 3.0 until 6.5) – Contains basic naming fields to view or edit in the font (replaced with `TFONTPROPERTIESFORM` in version 7.0 & above).
* **TNEWSUBSINGLEFORM** (version 10.0 until 10.1.0.2272) – Adds a single substitution to the OpenType layout tables.
* **TNEWTRUETYPEFONTFORM** – Used when creating a new font.
* **TOPENTYPEDESIGNERFORM** (version 7.0 & above) – Shows a dialog to view, edit or create OpenType layout tables.
* **TOPENTYPEITEMADDFRM** (version 7.0 & above) – Adds items to the OpenType layout tables.
* **TOPTIONSFORM** – Shows an interface for viewing and setting a wide variety of options which uses registry keys (manual edits varies based on whether the program is running or not).
* **TOTLFRENAMEFORM** (version 7.0 & above) – Used when renaming tables in the OpenType layout tables.
* **TPASTESPECIALFORM** – Paste any data for glyphs stored in the clipboard. In the Items list (version 5.5 until 6.5), **Glyph Outline Data** and **Glyph Metrics** (i.e. the first two items) are checked by default. **Glyph Outline Data** is dimmed in the third major version. In recent versions, the registry keys are stored in the `Edit` key.
* **TPCLTFORM** (version 3.0.1 until 6.5) – Shows a dialog to view, edit or modify the PCL5 data for use with old printers.
* **TPERFORMTRANSFORMATIONFORM** (version 5.6 & above) – Used after transforming each glyph.
* **TPLATFORMMANAGERFORM** (version 2.0 until 6.5) – Shows a dialog to choose which platform to support in the font (replaced with **Tools: Convert Font** in version 7.0 & above in `TMAINFORMFONTCREATOR`).
* **TPOSTSCRIPTNAMESFORM** (version 2.0 until 6.5) – Displays or modifies PostScript glyph names in the font.
* **TPRINTABORTFORM** – Used after the font printing process is started.
* **TPRINTFONTFORM** – Used when printing anything in the font.
* **TPRINTGLYPHFORM** – Used when printing glyphs.
* **TPROGRESSDIALOG** (**TPROGRESSFORM** in old versions) – Progress window. The cursor for this form is **Busy**.
* **TREGISTERFORMEX** and **TREGISTERFORMFC** (**TREGISTERFORM** in old versions) – Shows a dialog to enter the registration code (**Help** or **Buy: Register...**). This removes `TSPLASHFORM` on startup and hides the **Buy** menu and the **Register...** item on the **Help** menu. The user agent in `TREGISTERFORMEX` has its own user agent.
* **TRESOURCEMODULE** – Contains styles located in `rvStyleGlobal` and icons.
* **TRICHVIEWDIALOG** (unused) – Used by the rich text module; styles are located in `RVStyle1`.
* **TRULEMGR** (version 7.0 & above) – Manages rules in the OpenType layout tables.
* **TSAMPLETEXTFORM** (version 7.0 & above) – Adds custom sample text strings to `TFONTTESTFORM`.
* **TSELECTCOMPOSITEGLYPHMEMBERFORM** – Adds glyph members to any composite glyph.
* **TSELECTLOOKUPTABLEFORM** – Shows a dialog to select a lookup table in the OpenType layout tables.
* **TSHAREWAREFORM** (version 3.0 until 4.5) – If the program detects that it is not registered and is running after a grace period of 30 days, the program will show shareware distribution policies when pressing **Start** in `TSPLASHFORM`.
* **TSORTGLYPHSFORM** (version 1.0 until 6.5) – Shows a dialog to change the glyph order within a font (replaced with **Tools: Sort Glyphs** in version 7.0 & above).
* **TSPLASHFORM** – Used in unregistered copies. The three buttons at the bottom (**Use Evaluation Version**, **Enter Registration Code** and **Buy Now**) are displayed randomly.
* **TSPTBXCOLORPICKERFORM** – Selects colors for use with colored fonts.
* **TSUBLOOKUPMGR** (version 7.0 & above) – Manages subtables in the OpenType layout tables.
* **TTEXTREPLACEDIALOG** – Used when replacing text in `TCODEEDITORFORM`.
* **TTEXTSEARCHDIALOG** – Used when searching text in `TCODEEDITORFORM`.
* **TTIPOFTHEDAYFORM** (version 1.0 until 6.5) – Used for newcomers and **Help: Tip of the Day** (`FontCreator.tip` is used to display tips). The **Register** button is shown only for unregistered copies. See **Tip of the Day** in **FontCreator: Tutorials and Solutions** in the High-Logic forum for recent tips.
* **TTRANSFORMFORM** – Shows a dialog to transform a font into other weights like black or bold or add character ranges.
* **TTRIALNOTICEWINDOW** (version 7.0 until 10.1.0.2272) – If the program detects that it is not registered, testing, installing or exporting fonts displays a message which tells the program will create subsetted fonts. The message has a checkbox to turn it off.
* **TTRIMFORM** – Used when trimming glyphs.
* **TUNICODERANGEFORM** – Includes or excludes Unicode blocks or ranges to support in the font.
* **TUPDATEFORM** and **TUPDATEFORMFC** (**TUPDATEREMINDERFORM** in old versions) – Used in version 6.0 & above to check for updates (**Help: Check for Updates**) as if `OnStartupShowUpdateReminder` is enabled. The Firefox 53 on Windows 10 user agent is used in `TUPDATEFORM`. The `mRestart` memo in `TUPDATEFORM` should have three lines to prevent silent termination. The program will terminate silently if `TUPDATEFORM` is removed.
* **TUSEDBYFORM** – Displays an overview of all glyphs that use the selected glyph.
* **TUVSFORM** – Used by East Asian fonts to manage Unicode variation sequences.
* **TVALIDATIONWIZARDFORM** (version 4.0 & above) – Shows a wizard to validate the font for errors or problems.
* **TWIDEMESSAGEFORM** – Used for messages.
* **TWIDEWARNINGFORM** (**TWARNINGFORM** in old versions) – Used for warnings.

## Unused Content
The company hid debugging functions, developer commands and more in several RC Data resources with `Visible = False`.

### Main Form (`TMAINFORMFONTCREATOR`)
**Menu Items**
* **Edit: Knife** – Use the same option in the **Glyph** toolbar (this menu item does nothing when selected).
* **View: Toolbars: Tab Bar** – This will hide the tabs if version 6.1 up to 11.5 is used.
* **Font: TODO! Problem Report...** – This item is in version 3.0 and is implemented as `TVALIDATIONWIZARDFORM` in version 4.0 & above.
* **Tools: TODO! AutoCmap...** – This item is in version 3.0 only and was dropped after version 4.0.
* **Tools: TODO! AutoPost...** – This item is in version 3.0 only and is implemented as `TGLYPHNAMEFORM` in version 7.0 & above.
* **Tools: TODO! Customize...** – Use Resource Hacker or other programs to modify the menus or toolbars (this menu item does nothing when clicked). If the program detects that the menus or toolbars are modified, the first message shown in the status bar is replaced with access violation when opening fonts or doing other things.
* **Window: Minimize All** – Minimizes all but the current window (restore each minimized window via the restore button).

**Hidden Shortcuts** – Menu's description from the form: These items are here so the shortcuts work.
* **Restore Overview Splitter** – Hide or show the overview splitter.
* **Close** – Close active window with the same command in the **File** menu.
* **Cut**, **Copy** and **Paste** – Uses the same commands in the **Edit** menu.
* **Show Font Properties** – Uses the same command in the **Font** menu.
* **Redo** – Uses the same command in the **Edit** menu.
* Tags from **tags.txt** and **Tagged** folder (`TFONTOVERVIEWFORM`) – The menu items do nothing when clicked in `TFONTOVERVIEWFORM` except when using the same items from the `TFONTOVERVIEWFORM` glyph context menu or editing glyphs in `TGLYPHEDITFORM`.

**Developer Tools** – Contains debugging functions and developer commands.
* **Screenshot macro 1** or **Screenshot macro 2 (website)** – Create screenshots from the help file in `C:\Program Files\help\screenshots\` or `C:\Program Files (x86)\help\screenshots\` (if the folder exists). Use anti aliased smoothing (old versions) and register FontCreator for these features to work.
* **Hide Developer Menu** – Hides the menu (i.e. adds `Visible = False` to the menu much like the original program).
* **AutohintMacro** – Closes all fonts with the same command in the **File** menu.
* **Video mode** – Restores window to original size and registers program without a key.
* **A/B Testing** – Contains two options to set the variant.
* **Font Log** – Shows the font log (this item is hidden if the program is not registered).
* **Disable garbage collector**
* **Increase Font Size** – Shows information about the current system font with three numerical strings.
* **Enable All Toolbar Icons** – Enables all icons in toolbars. Do other things to disable most icons in toolbars.
* **Font Tester Action** – This menu item is intended to change the action used by `TFONTTESTFORM`.
* **Boink!** – Exit the program silently. Located in the **Debug** menu in 10.0 (2016-06-22) until 11.5.0.2430 (2018-12-05), this feature does nothing when selected. It may display a critical error which varies whether it can be closed or not, which contains an "OK" button.

**Toolbar Buttons** – The last four buttons are enabled if simple glyphs are edited.
* Second **Open** and **Print** options in the **Standard** toolbar – Only the second **Print** option uses the same command in the **File** menu or the first **Print** option.
* **Generate Glyph Names** (First letters of last two words in the **Tools** toolbar) – Save glyph names to `C:\Users\EDenissen\AppData\Roaming\FontCreator12\generatednames.txt`. Create the user `EDenissen` for this feature to work. **EDenissen** stands for Erwin Denissen (original author/sole developer of this program, president and founder of High-Logic B.V.). The button is hidden if FontCreator 12 is detected to be running an unregistered copy.
* **Smooth Curves** (First letter in the **Glyph** toolbar) – Smooths all curves.
* **Smooth and Align Curves** (First letter of first and third words in the **Glyph** toolbar) – Smooths and aligns curves.
* **Harmonize** (First letter in the **Glyph** toolbar) – Harmonizes all contours.
* **Round XY Coordinates** (First letter in the **Glyph** toolbar) – Round XY coordinates values.

### Resource Editor (`TRESOURCEEDITORDLG`)
This dialog is in version 3.0 only and is used to edit resources.

### Glyph Edit Form Menu (`TGLYPHEDITFORM`)
* **Order** – This menu is included in version 3.0 (the features are implemented in version 4.0 & above).
* **Debug Single Stroke Twice** (**miTestItem** in version 10.0 until 10.1.0.2272) – This menu item is dummy.
* **miTestItem2** – This menu item is dummy.
* **miTestItem3 Save** and **miTestItem4 Load** – Save or load glyph data from `C:\hltemp\glyph.data` (if it exists). Create the folder `hltemp` for these features to work.

### Font Overview (`TFONTOVERVIEWFORM`)
Version 4.5 until 6.5 includes menu entries related to bookmarks for each glyph (the menu is hidden since version 7.0 & above).

### Import Image (`TCONVERTBITMAPTOCONTOURSFORM`)
* Checkbox: **Include Diagonals** – This item is in version 3.0 only and was dropped after version 4.0.
* Checkbox: **Remove Knees** – This item is in version 3.0 only and was dropped after version 4.0.

### Composite Glyph Properties (`TCOMPOSITEGLYPHPROPERTIESFORM`)
This dialog includes a text box with glyph indexes at the top right corner (it is shown in old versions only).

### Automatic Metrics Wizard (`TAUTOMETRICSFORM`)
This dialog includes a note requiring the Professional Edition to use this feature (it is shown if the program is detected to be running the Home Edition). Version 10.0 includes three unused features (the features were dropped in version 11.0 & above).

### OpenType Designer (`TOPENTYPEDESIGNERFORM`)
These buttons are shown if the GPOS kerning tables are edited. The values at the beginning has a capital D in square brackets.
* **Clear Values** – Use zero values for all kerning pairs.
* **Harmonize** – Harmonize all kerning pairs in subtables.
* **Clean Up** – Delete all kerning pairs with zero value. This feature is documented in old versions.

### OpenType Layout Feature Code Editor (`TCODEEDITORFORM`)
* Debugger dropdown list – Selecting OTLFD (OpenType Layout Feature Designer), VOLT or FAE will discard changes to the code or load the original code.
* Checkbox: **Debug: VOLT.UseGlyphIds** – For use with fonts with VOLT projects only.

### Font Test Window (`TFONTTESTFORM`)
The context menu has two paste options and another multiline text field.

### Options Window (`TOPTIONSFORM`)
The **General** tab has a group to associate fonts with the program itself (it is in version 3.0 only and was dropped after version 4.0).

The **Preview** tab includes three unused buttons to move strings up or down or to reset the list.

### About Dialog (`TABOUTDIALOG` and `TABSTRACTABOUTDIALOG`)
Included in version 6.0 & above only. These are located in the corners of the version number, copyright info and the company's website.
* **Clr** (Clear) (top left corner) – Remove registration info to make the program unregistered much like the factory settings or when installing the program.
* **Crash** (top right corner) – Displays a critical error which reads "We hope you enjoyed clicking this crash button".
* **Trial** (bottom right corner, version 12.0) – Restarts the trial period for unregistered copies after a grace period of 30 days.