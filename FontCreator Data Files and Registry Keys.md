## Notes
* The cursor will remain **Busy** if the user does other stuff when saving fonts in the background.
* All versions can save all unaltered opened fonts from the menu (**File: Save All**). Windows 2000 & above shows a critical error that reads **List index out of bounds** with a zero code if done repeatedly.
* Exiting the program when saving fonts may create invalid font(s) and play the Critical Stop sound from the PC speakers.
* The program shows a critical error that reads **access violation** when exiting while during some operations – the font(s) may be invalid.
* Glyphs stored in the clipboard (version 1.0 until 6.0) will have either the words **Glyph Contours** for contours or **Glyph Data** for the entire glyph. Version 7.0 & above currently stores the words **Font Data**.
* **Edit: Delete** is not dimmed on startup or when closing other dialogs in old versions.
* **Complete Composites** (when generated from `CompositeData.xml` but not auto or anchor based) slows down the first time when used in simple and composite glyphs.
* **Complete Composites** is dimmed when editing empty glyphs in version 5.0 until 6.5.
* The program shows a critical error when using **Complete Composites** in some glyphs in the Private Use Area (old versions only). After that, these glyphs cannot be recovered.
* Version 1.0 (1998-04-11) until 7.0 (2013-04-25) only adds glyphs with Unicode BMP mapping to the preview toolbar.
* Despite FontCreator 5.6 having unused content and using non-standard resource layout, [UPX](https://upx.github.io/) can't test the executable file (NotPackedException: not packed by UPX) but the executable file compresses successfully with or without parameters.
* In new fonts, the international currency sign (¤) is mapped in the Macintosh Roman glyph mapping list but not the euro (€) which is mapped by the same codepoint (219).
* Version 1.0 (1998-04-11) until 6.5 (2011-11-18) used ISO Latin-1 as the output encoding while version 7.0 (2013-04-25) & above uses Unicode. Setting the non-Unicode language to East Asian languages (e.g. Korean) substitutes accented letters by ASCII counterparts (except in Simplified Chinese) and when exporting kerning pairs, instead of e.g. using &lt;&lt; (much less than) for certain symbols like opening guillemot use a backslash (\\) and the hexadecimal code of any character as escape code, e.g. \\00AB.

## Unregistered version limitations
As FontCreator is pay shareware, the unregistered version has a grace period of 30 days. If registration is not performed during the grace period, the following restrictions will be imposed on the version number:
* All versions – `TSPLASHFORM` is shown on startup. The window title bar will display **(UNREGISTERED)**. After a grace period of 30 days, the paragraph changes in `TSPLASHFORM`.
* 3.0β1 (2000-07-30) until 3.1.3 (2002-12-09) – After a grace period of 30 days, a nag screen is shown when pressing **Start** in `TSPLASHFORM`. However, the program otherwise functions normally.
* 4.0 (2003-05-16) until 4.5 (2004-08-17) – After a grace period of 30 days, the program cannot be used at all until the registration process is started.
* 5.0 (2005-01-12) until 5.6 (2007-07-19) – After a grace period of 30 days and opening the program 5 times, the program will enter a reduced functionality mode, where fonts cannot be saved, tested or installed and TrueType collections cannot be extracted.
* 6.0 (2009-06-17) until 6.5 (2011-11-18) and 8.0 (2014-06-05) until 12.0.0.2539 (2019-06-04) – The program will enter a reduced functionality mode. The reduced functionality varies based on whether the program is in the grace period or not. In this case, fonts cannot be installed or exported, OpenType collections cannot be extracted and tested fonts won't be automatically hinted.
* 7.0 (2013-04-25) and 7.5 (2013-08-02) – The program will create subsetted versions when testing, installing or exporting fonts. After a grace period of 30 days, the program will enter a reduced functionality mode, where fonts cannot be tested, installed or exported and OpenType collections cannot be extracted.
* 12.0.0.2543 (2019-07-10) until 12.0.0.2547 (2019-09-12) – The program will add watermarks when generating fonts. After a grace period of 30 days, the program will enter a reduced functionality mode, where fonts cannot be tested, installed or exported and OpenType collections cannot be extracted.

Under the **Help** menu is an item labeled **Register...** (in version 12.0 the same item is in the **Buy** menu along with **Buy Now**) when this executed a screen will pop up giving the registration code.

## Windows version compatibility
* Windows Vista and later – 12.0.0.2547
* Windows XP – 10.0
* Windows 2000 – 7.0
* Windows 95, 98, ME and NT 4.0 – 6.0.1

## User Data (Glyph Transformer scripts omitted)
FontCreator uses several data files for advanced settings and customizations. Normally most files are stored in a system folder where they cannot be changed. If you want to edit most files directly they either must have administrator privileges or change the owner (this can be done with `takeown /f filename` or **Security: Advanced: Owner: Edit** in Windows Vista and 7 and **Security: Advanced: Owner: Change** in Windows 8 and 10 in the file properties).

* **bookmarks.txt** (version 5.0 until 6.5) – Created automatically after exit. Includes bookmarks used in the glyph overview.
* **CompositeData.xml** – Located in the `Composite` folder as used by **Complete Composites**. This feature will do nothing if there are syntax errors or this file is removed. [Bhikkhu Pesala](http://www.softerviews.org/Fonts.html) had assigned code points in the Private Use Area for different glyphs in this file and his fonts, notably petite/small capitals and old style numbers.
* **CurrentTransformProgram.xml** – Used when opening Transform Programs in `TPERFORMTRANSFORMATIONFORM`. The window will appear empty if removed.
* **FC#####.ttf** – Temporary font used by `TFONTTESTFORM` (the last five characters in the filename are numeric). The font name in version 3.0 until 6.5 is **FC Test Font ######** (the last six characters are numeric).
* **fc12.cfg** – Configuration file for version 12.0 & above.
* **fcp5.cfg** – Configuration file for version 5.0 and 5.6 in the system root directory.
* **fcppreview.txt** (version 3.0 until 4.5) – Text used in `TFONTTESTFORM`. The text is restored to factory defaults if removed.
* **fntXX.tmp** or **fntXXX.tmp** – Temporary font used by the save features (the last two or three characters in the filename are letter and number combos).
* **FontCreatorSetup.exe** – Install the Win32 version of this program.
* **FontCreatorSetup-x64.exe** – Install the Win64 version of this program.
* **FontCreator.tip** (version 2.0 until 6.5) – Contains tips in `TTIPOFTHEDAYFORM`. The window will appear empty if removed.
* **FontCreator YYYYMMDD HHMMSS ###.dat/prd** – Error info located in `All Users\High-Logic\Errors` (YYYYMMDD HHMMSS is the timestamp and the last three characters are numeric).
* **FontInstaller.dll** (version 2.0 until 6.5) – This is not a data file but is rather a dynamic link library used by `TFONTINSTALLFORM`.
* **glyphlist.dat** – Contains the Adobe glyph list. Old versions have the same list but **xi** is duplicated as U+0000.
* **glyphnamesnew.dat** (version 7.0 & above) – Contains the default glyph names when opening existing fonts and when generating glyph names on `TGLYPHPROPERTIESFORM`. Prior to FontCreator 12 another file (`glyphnames.dat`) was used, but that one is now obsolete.
* **guidelines.dat** – Created automatically after exit. Contains the guidelines used for `TGLYPHEDITFORM` and `TGUIDELINESFORM`.
* **kern_font.txt** – For old versions of FontCreator, stores the old KERN table data in each font whereas `font` is the font name.
* **previewtext.dat** (version 5.0 & above) – Contains the text used in `TFONTTESTFORM`. The text is restored to factory defaults if removed.
* **preview.txt** – Contains the texts for the Preview toolbar. The dropdown list will appear empty if removed.
* **SubFamily.dat** or **SubFamily2.dat** – Contains naming fields for multiple languages.
* **TableOffsetOrderCFF.txt**, **TableOffsetOrder.dat** (old versions) and **TableOffsetOrder.txt** – Contains the supported tables in any font. All tables are moved to **Font Information: Unsupported Tables** (version 7.0 & above) or **Tables: Unsupported** (version 3.0 until 6.5) if these files are removed, making the font either invalid, fail to install or not work.
* **tags.txt** (version 7.0 & above) – Controls the names of the five tags that can be assigned to each glyph. Defaults are named Important, Incomplete, Completed, Review and Workspace.

In **Options: Advanced: Data Files** are two buttons labeled **Copy Data Files to User Data Folder** and **Open User Data Folder** when pressed the program will either copy most files in the above list to the user data folder or open it.

## Registry Keys
The registry keys are located in `HKCU\Software\High-Logic\FontCreator\version` whereas `version` is the version number.

### AddCharacters (used in `TADDCHARACTERSFORM`)
* **SelectedCharacter** – Select character. Default is 0 (null).
* **SelectedFont** – Select font to display characters. Default is **Arial Unicode MS** (shipped with Microsoft Office up to 2013 and discontinued with 2016).

### Background (used in Background Image on `TMAINFORMFONTCREATOR`)
* **BackgroundInitColor** – Set the background color. Default is white.
* **BackgroundInitScale** – Select the background scaling factor.

### Columns (used in `TINSTALLEDFONTSFORM`)
* **Open Installed Fonts** – This numerical option changes the width in this form.

### Edit (used in `TPASTESPECIALFORM`)
* **PasteSpecialAnchors** – This option will paste anchors. Default is on.
* **PasteSpecialCodepoints** – This option will paste codepoints. Default is on.
* **PasteSpecialCodepointsOption** – This option will paste codepoints. Default is 0 (Keep same code-points).
* **PasteSpecialGlyphNames** – This option will paste glyph names. Default is off.
* **PasteSpecialMetrics** – This option will paste metrics. Default is on.
* **PasteSpecialMetricsOption** – This option will paste metrics. Default is 0 (Side bearings).
* **PasteSpecialOutlineData** – This option will paste outline data. Default is on.

### Externals (used in Tools: Launch Externals)
There are three built-in external programs: **MainType** (shows if installed and hides if not installed), **Fonts Folder** and **Character Map** (you can get rid of it in Windows 95 up to Windows XP via **Control Panel: Add or Remove Programs: Add/Remove Windows Features: Components: Accessories and Utilities: Accessories: Character Map**).
* **Location#** – The last character can be up to digit three. Default is empty.
* **Title#** – The last character can be up to digit three. Default is **External #** whereas the last character is a number.

### Find (version 3.0 until 6.5, used in `TFINDFORM`)
* **FindLanguageID** – Select language identifier.
* **PlatformID** – Select **Platform** identifier in the Mapping tab.
* **PlatformSpecificEncodingID** – Select a specific **Platform** encoding identifier in the Mapping tab.
* **TabIndex** – Changes tab in this form. Default is 0.

### FontOverview (used in `TFONTOVERVIEWFORM`)
* **CategoryWidth** – Select the width used for categories.

### Fonts (used in Options: Font – default is on for all options)
* **ExportDecomposeScaled** (version 12.0.0.2521 & above) – Used with **Export Font: Decompose composite glyphs with scaled components**.
* **ExportExcludeLegacy** – Used with **Export Font: Exclude legacy data**.
* **FontEnableOpenContours** (version 11.5.0.2421 & above) – Used with **Special Features: Enable open contours**.
* **OpenFriendlyGlyphNames** – Used with **Open Font: Generate friendly glyph names**.

### FreeDraw (version 6.5 & above, used in Free Draw on `TMAINFORMFONTCREATOR`)
* **BrushWidth** – Changes the **Brush width**. Default is 64.

### Glyph Edit Window
* **FilledOutline** (version 1.0 until 10.0) – Used with **Fill Outline** in the Grid toolbar. Default is on. See `GlyphFillAlpha` in **Interface Settings** below in newer versions.
* **ShowConnectionBetweenPoints** – Used with **Show Connection** in the Grid toolbar. Default is on.
* **ShowFirstAndLastPointIndicators** – Used with **Show First and Last** in the Grid toolbar. Default is on.
* **ShowToolbarWindowBackground** – Show or hide the Background Image toolbar. Default is off.
* **ShowToolbarWindowKerning** – Show or hide the kerning window. Default is off.
* **ShowToolbarWindowMembers** – Show or hide the members window for use with colored fonts. Default is off.
* **ShowToolbarWindowPalette** – Show or hide the palette for use with colored fonts. Default is off.
* **ShowToolbarWindowTransformation** – Show or hide the transformation toolbar. Default is on.
* **ShowToolbarWindowValidation** – Used with **Show Report** in the Glyph toolbar. Default is off.

### Grid
* **FixedGridColor** – Set the fixed grid color in Grid Options. Default is white.
* **FixedGridLineStyle** – Set the fixed grid line style in Grid Options. Default is solid.
* **GridColor** – Set the grid color in Grid Options. Default is sky blue.
* **GridDistance** – Used with **Minimum distance between grid points in units** in Grid Options.
* **GridDistancePixels** – Used with **Mininum distance between grid points in pixels** in Grid Options.
* **GridLineStyle** – Set the line style in Grid Options. Default is solid.
* **IncludeBaseline** – Used with **Baseline** in Metrics Options. Default is on.
* **IncludeLeftSideBearing** – Used with **Left side bearing** in Metrics Options. Default is on.
* **IncludeRightSideBearing** – Used with **Right side bearing** in Metrics Options. Default is on.
* **IncludeTypoAscender** – Used with **TypoAscender** in Metrics Options. Default is off.
* **IncludeTypoDescender** – Used with **TypoDescender** in Metrics Options. Default is off.
* **IncludeWinAscent** – Used with **Win Ascent** in Metrics Options. Default is on.
* **IncludeWinDescent** – Used with **Win Descent** in Metrics Options. Default is on.
* **IncludexHeight** – Used with **x-Height** in Metrics Options. Default is on.
* **IncludeYAxis** – Used with **Y-Axis** in Metrics Options. Default is on.
* **LockUserDefinedGuidelines** (version 4.5 & above) – Used when pressing **Lock Guidelines** in the Grid toolbar. Default is off.
* **ShowBearings** (version 5.6 & above) – Used when pressing **Show Metrics** in the Grid toolbar. Default is on.
* **ShowFixedGridLines** (version 5.6 & above) – Used with **Show reference lines at x = 0, y = 0** in Grid Options.
* **ShowGrid** – Used when pressing **Show Grid** in Grid Options or in the Grid toolbar. Default is on.
* **ShowUserDefinedGuidelines** – Used when pressing **Show Guidelines** in Guidelines Options or in the Grid toolbar. Default is on.
* **SnapToGrid** (version 4.5 & above) – Used when pressing **Snap to Grid** in the Grid toolbar. Default is off.
* **SnapToUserDefinedGuidelines** (version 4.0 & above) – Used when pressing **Snap to Guidelines** in the Grid toolbar. Default is off.

### GUI
* **UpdateCheckInterval** – Used by **Startup: Check for updates** in Options: General. Values are 000 (never), 001 (every day), 007 (once a week), 030 (once a month), 182 (twice a year) or 365 (once a year). Default is 007 (once a week).

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
* **InstallFontsInFontsFolder** – Disable this option if you don't want to **Install the font in Windows Fonts folder**. Default is on. If the program is ran under Windows Vista & above, the UAC shield is added before the label.

### InstalledFonts (used in `TINSTALLEDFONTSFORM`)
* **PreviewHeight** – Set the height in the font preview area (version 5.5 & above) at the bottom. Default is 124.

### Interface (used in the toolbar context menu or View: Toolbars)
* **LockToolbars** – Used with **Lock Docked Toolbars**. Default is off.
* **ShowUserNotes** – Used with **Show User Notes**. Default is off.

### Interface Settings
* **ChildWindowState** – Contains the child window state.
* **CompleteCompositesAction** – Set to either 1 (auto), 2 (anchor based), 3 (anchor based reposition) or 4 (composite data) as used with **Complete Composites**. Default is 1 (auto).
* **CustomNamingShowOutputContent** – Used by **Custom: Additional Naming Fields: Show Output Content** in the Font Properties window. Default is on.
* **ExportSettingsPage** – Select the page in `TEXPORTSETTINGSFORM` and `TEXPORTSETTINGSFRAME`. Default is 0 (Desktop Font (ttf/otf)).
* **GlyphCaptionAuto** – Used with **Glyph Caption: Automatic** (Glyph Index) in the font overview context menu.
* **GlyphCaptionType2** – Used with the Captions options in the font overview context menu.
* **GlyphDrawMode** – Set to 2 (auto), 0 (monochrome) or 1 (color). Default is 2 (auto).
* **GlyphFillAlpha** (version 11.0.0.2365 & above) – Used with **Fill Outline** in the View menu.
* **GlyphNamesHistoryReplace** (version 11.0.0.2365 & above) – Contains the history of replaced postscript names in `TGLYPHNAMEFORM`.
* **GlyphNamesHistorySearch** (version 11.0.0.2365 & above) – Contains the history of found postscript names in `TGLYPHNAMEFORM`.
* **GlyphNamesOptionsCS** – Used with **Options: Case sensitive** in `TGLYPHNAMEFORM`. Default is on.
* **GlyphNamesOptionsRE** – Used with **Options: Regular expressions** in `TGLYPHNAMEFORM`. Default is off.
* **GlyphOutlineFillMode** – Used with **Glyph outline fill mode** in the Options: General tab. Default is 0 (Winding).
* **GlyphPropsExpanded** – Expand the glyph properties by pressing the **More** button at the bottom left corner. Default is on.
* **GroupManagerSorted** – Sorts the group manager.
* **InsertGlyphsCB1** and **InsertGlyphsCB2** – Set this value in `TINSERTGLYPHFORM` to either insert glyphs at the top (0), after the last glyph (1), before selected glyphs (2) or after selected glyphs (3). Default is 3 (after selected glyphs).
* **InsertGlyphsPage** – Changes tab in `TINSERTGLYPHFORM`.
* **KerningFolderExport** – Select the directory to export the old KERN table.
* **KerningFolderImport** – Select the directory to import the old KERN table.
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
* **OTLFDesignerPreviewLanguage** – Select the preview text language in `TOPENTYPEDESIGNERFORM`. Default is **Auto**.
* **OTLFDesignerPreviewSampleText** – Contains sample text for `TOPENTYPEDESIGNERFORM` preview. Default is **The five boxing wizards jump quickly**.
* **OTLFDesignerPreviewScript** – Select script for `TOPENTYPEDESIGNERFORM` preview. Default is **Auto**.
* **OTLFDesignerSingleFilter** – Used for single filter in `TOPENTYPEDESIGNERFORM`.
* **OTLFDesignerSingleKind** – Used for single kind in `TOPENTYPEDESIGNERFORM`.
* **OTLFEditor** – Contains settings used by `TCODEEDITORFORM` such as the font setting, line number display or word wrapping.
* **OverviewColCat** – Contains the column categories used in `TFONTOVERVIEWFORM`.
* **OverviewFontZoom** – Contains the zoom factor used in `TFONTOVERVIEWFORM`. Default is 35.
* **OverviewGridZoom** – Contains the zoom factor for the grid used in `TFONTOVERVIEWFORM`.
* **OverviewSampleFont** (version 4.0 & above) – Used with **Font Overview: Font used in cells** in Options: View. Default is **Arial**. If this string is empty, the characters are shown in **MS Sans Serif**. (Available in the Options window)
* **OverviewShowCaption** (version 3.0 until 6.5) – Used with **Font overview: Show caption** in Options: Overview. Default is on.
* **OverviewShowSample** – Used with **Font Overview: Show sample in empty glyphs** in Options: Overview. Default is on.
* **OverviewSingleHeight** (version 3.0 until 6.5) – Used with **Font overview: Glyph height** in Options: Overview. Default is 48.
* **OverviewSingleWidth** (version 3.0 until 6.5) – Used with **Font overview: Glyph width** in Options: Overview. Default is 70.
* **OverviewSmoothGlyphs** – Used with **Font overview: Smooth glyphs** in Options: Overview.
* **OverviewUndoLimitMaxCount** – Used with **Undo limits: Max. count** in Options: Edit. Default is 1.
* **OverviewUndoLimitMaxSize** – Used with **Undo limits: Max. size [KB]** in Options: Edit. Default is same as the maximum count.
* **OverviewUseColor** – Used with **Font overview: Use type color in glyph caption** in Options: Font. Default is on.
* **SampleFileName** – Used with **Samples Toolbar Font: Filename** in Options: General. Default is blank (the sample glyphs are from Garava Regular).
* **SampleSingleHeight** (version 3.0 until 6.5) – Used with **Samples Toolbar: Glyph height** in the Options: Sample. Default is 55.
* **SampleSingleWidth** (version 3.0 until 6.5) – Used with **Samples Toolbar: Glyph width** in the Options: Sample. Default is 62.
* **SaveDialogInitialDirNew2** – Select the directory in the save dialog.
* **SelectCompositeCaptionType** – Changes caption used in `TCOMPOSITEGLYPHPROPERTIESFORM`. Default is 0 (glyph name).
* **SelectCompositeFontZoom** – Zoom the font in `TCOMPOSITEGLYPHPROPERTIESFORM`.
* **SelectCompositeGridZoom** – Zoom the grid in `TCOMPOSITEGLYPHPROPERTIESFORM`.
* **SettingsPage** – Changes tab in `TOPTIONSFORM`. Default is 0 (Identification).

### Kerning
* **AutoKerningAllowForPositiveKerningValues** – Used with **Additional Options: Allow for positive kerning values** in `TAUTOKERNFORM`.
* **AutoKerningExcludeLowerLower** (version 11.0 & above) – Used with **Exclude lowercase-lowercase pairs** in `TAUTOKERNFORM`.
* **AutoKerningExcludeLowerUpper** – Used with **Exclude lowercase-uppercase pairs** in `TAUTOKERNFORM`.
* **AutoKerningImportFilename** – Contains the file to import kerning pairs.
* **AutoKerningMinAbsKernValue** – This corresponds to numerical strings for the **Additional Options: Minimum absolute kerning value** in `TAUTOKERNFORM`.
* **AutoKerningReplaceKerning** – Used with **Additional Options: Replace existing kerning when** dropdown box in `TAUTOKERNFORM`.
* **AutoKerningReplacePercentage** – Used with **Additional Options: Replace existing kerning when** slider in `TAUTOKERNFORM`.
* **AutoKerningUseBaseMetrics** – Used with **Composite glyphs follow base glyphs (use this glyph's metrics)** in the OpenType Designer Kern Wizard. Default is on.
* **AutoKerningWhiteSpace** – Used with **Additional Options: White space between characters** in `TAUTOKERNFORM`.
* **KerningColorBackground** – Set the background color. Default is white.
* **KerningColorBaseline** – Set the baseline color. Default is red.
* **KerningColorFirst** – Set the preceding glyph color. Default is dark blue.
* **KerningColorGridLines** – Set the grid lines color. Default is gray.
* **KerningColorSecond** – Set the succeeding glyph color. Default is dark green.
* **KerningShowBaseLine** – Displays baseline. Default is on.
* **KerningShowBearingLines** – Displays bearing lines. Default is same as the options to display the baseline or grid lines.
* **KerningShowGridLines** – Displays grid lines. Default is same as the options to display the baseline or bearling lines.

### Last Time, Most Recently Used Files, Most Recently Used Projects
* **File_#** – Include fonts used in the last time or fonts and/or projects in the **File: Reopen** menu whereas the last character (#) is a number. The **File: Reopen** menu will appear empty (recent versions) or dimmed (old versions) if the above keys are removed or if **Clear file list** is selected from the menu. When `OnStartupOpenFonts` is enabled, nothing is opened if removed.

### Metrics (used in `TAUTOMETRICSFORM`)
* **AutoMetricsExcludeEmptyGlyphs** – Used with **Additional Options: Exclude empty glyphs (recommended)**.
* **AutoMetricsFixedAW** – Used with **Fixed Width: Advance Width**. Default is 2048.
* **AutoMetricsFixedChangeAW** – Used with **Fixed: Change Advance Width**.
* **AutoMetricsFixedChangeLSB** – Used with **Fixed: Change Left Side Bearing**.
* **AutoMetricsFixedLSB** – Used with **Fixed: Change Left Side Bearing** spinner.
* **AutoMetricsOpticalFactor** – Used with **Glyph spacing factor (usually between 20 and 30)** in Optical Metrics. Default is 27.
* **AutoMetricsOpticalFigures** – Used by **Set character width for digits as** to change the metrics for digits. Set to 0 (Tabular figures), 1 (Proportional figures) or 2 (No change). Default is 0 (Tabular figures).
* **AutoMetricsOpticalPreview** – Used with **Preview Text** in Optical Metrics. Default is **Preview Text**.
* **AutoMetricsOptionIndex2** – Set to 0 (Optical Metrics), 1 (Fixed Bearings), 2 (Fixed Width) or 3 (Fixed Height). Default is 0 (Optical Metrics).
* **AutoMetricsWhiteSpaceAfter** – Used with **Fixed Bearings: Space after**. Default is 100.
* **AutoMetricsWhiteSpaceBefore** – Used with **Fixed Bearings: Space before**. Default is same as **Fixed Bearings: Space after**.

### MetricsAndKerning (used in the Comparison toolbar)
* **MetricsAndKerningKerningEnabled** – Enable or disable **OpenType Layout Features**. Default is off.
* **MetricsAndKerningTextEnabled** – Used with **Show text before and after glyph**. Default is off.
* **MetricsAndKerningTextLeft** – Contains the preceding character in the **Before** text box. Default is empty.
* **MetricsAndKerningTextRight** – Contains the succeeding character in the **After** text box. Default is same as the **After** text box.

### OpenType Designer (version 7.0 & above, used in `TOPENTYPEDESIGNERFORM`)
* **FillGlyphOutlines** – Used with **Colors: Fill glyph outlines** in the Settings window. Default is on.
* **GlyphFillColor** – Used with **Colors: Glyph fill color** in the Settings window. Default is off.
* **LayoutMode** – Select the layout mode. Default is 0.
* **MarkWidth** – Select the mark width. Default is 240.
* **PairWidth** – Select the pair width. Default is 145.
* **PreviewHeight** – Select the preview text height. Default is 120.
* **PreviewSampleFontSize** – Scale the preview sample. Default is 32.
* **SimpleWidth** – Set the simple width. Default is same as the pair width.
* **SingleWidth** – Set the single width. Default is same as the simple width.
* **TreeWidth** – Select the tree width. Default is 320.
* **ZoomFactor** – Select the zoom factor. Default is 12.

### OpenType Generator (version 12.0, used in `TFEATURESETTINGSFORM`)
* **CPSPKind** – Used with the dropdown box at **Spacing and Positioning: Capital Spacing (cpsp)**. Default is 0 (Percentage of advance width).
* **CPSPPerc** – Used with **Spacing and Positioning: Capital Spacing (cpsp)** spinner. Default is 5.00%.
* **IncludeAalt** – Used with **Other Forms and Variants: Access All Alternates (aalt)**. Default is on.
* **IncludeAltFractions** – Used with **Numerals: Alternative Fractions (e.g. stacked) (afrc)**. Default is on.
* **IncludeAnchorBased** – Used with **Spacing and Positioning: Anchor Based Positioning (ccmp, mark, mkmk)**. Default is on.
* **IncludeCapitalSpacing** – Used with **Spacing and Positioning: Capital Spacing (cpsp)**. Default is on.
* **IncludeCase** – Used with **Other Forms and Variants: Case-Sensitive Forms (case)**. Default is on.
* **IncludeCharacterVariants** – Used with **Other Forms and Variants: Character Variants (cv01-cv99)**. Default is on.
* **IncludeCursive** – Used with **Spacing and Positioning: Cursive Positioning (cursive script only) (curs)**. Default is on.
* **IncludeDlig** – Used with **Other Forms and Variants: Discretionary Ligatures (dlig)**. Default is on.
* **IncludeFina** – Used with **Terminal Forms (fina, fin2, fin3)**. Default is on.
* **IncludeFractions** – Used with **Numerals: Fractions (diagonal) (frac, dnom, numr)**. Default is on.
* **IncludeFractionsAdv** – Used with **Numerals: Fractions (diagonal) (frac, dnom, numr): Extended (smart math format)**. Default is on.
* **IncludeHlig** – Used with **Other Forms and Variants: Historical Ligatures and Historical Forms (hlig, hist)**. Default is on.
* **IncludeInit** – Used with **Initial Forms (init)**. Default is on.
* **IncludeIsol** – Used with **Isolated Forms (isol)**. Default is on.
* **IncludeLiga** – Used with **Other Forms and Variants: Standard Ligatures (liga)**. Default is on.
* **IncludeLnum** – Used with **Numerals: Lining Figures (lnum)**. Default is on.
* **IncludeLoclCommon** – Used with **Localized Forms (locl): Common Localized Forms (CAT, NLD, TRK, ROM)**. Default is on.
* **IncludeLoclCustom** – Used with **Localized Forms (locl): Custom Localized Forms (loclLANG)**. Default is on.
* **IncludeMedi** – Used with **Medial Forms (medi, med2)**. Default is on.
* **IncludeNalt** – Used with **Other Forms and Variants: Alternate Annotation Forms (nalt)**. Default is on.
* **IncludeOnum** – Used with **Numerals: Oldstyle Figures (onum)**. Default is on.
* **IncludeOrdinals** – Used with **Other Forms and Variants: Ordinals (ordn)**. Default is on.
* **IncludeOrdinalsExt** – Used with **Other Forms and Variants: Ordinals (ordn): Extended (use .ordn or .sups for all letters)**. Default is on.
* **IncludeOrnaments** – Used with **Other Forms and Variants: Ornaments (ornm)**. Default is on.
* **IncludePetiteCapitals** – Used with **Other Forms and Variants: Petite Capitals (pcap, c2pc)**. Default is on.
* **IncludePnum** – Used with **Numerals: Proportional Figures (pnum)**. Default is on.
* **IncludeSalt** – Used with **Other Forms and Variants: Stylistic Alternates (uses ss01) (salt)**. Default is on.
* **IncludeSinf** – Used with **Numerals: Scientific Inferiors (sinf)**. Default is on.
* **IncludeSmallCapitals** – Used with **Other Forms and Variants: Small Capitals (scap, c2sc)**. Default is on.
* **IncludeStylisticSets** – Used with **Other Forms and Variants: Stylistic Sets (ss01-ss20)**. Default is on.
* **IncludeSubs** – Used with **Other Forms and Variants: Subscript (subs)**. Default is on.
* **IncludeSups** – Used with **Other Forms and Variants: Superscript (sups)**. Default is on.
* **IncludeSwsh** – Used with **Other Forms and Variants: Swash (swsh)**. Default is on.
* **IncludeTitl** – Used with **Other Forms and Variants: Titling (titl)**. Default is on.
* **IncludeTnum** – Used with **Numerals: Tabular Figures (tnum)**. Default is on.
* **IncludeZero** – Used with **Numerals: Slashed Zero (zero)**. Default is on.

### Options
* **AlwaysCreateBackupCopy** – Used with **Create backup copy (bck) on saving a font project** in Advanced: Settings. Default is off.
* **AutoFitGlyphInWindow** – Used with **Glyph Edit Window: Auto fit glyph in Window** in Options: Glyph. Default is on.
* **AutoNamingUseFontRevision** (version 5.5 until 6.5) – Used with **Automatic Naming Wizard: Version String: use Font revision version from Font Settings → Header page** in Options: Naming. Default is on.
* **CompressHmtxTable** – Used with **When Saving Font Files: Compress hmtx table** in Options: Font. Default is on.
* **CompressNameTable** – Used with **When Saving Font Files: Optimize name table** in Options: Font. Default is on.
* **DefaultNamingCopyrightIncluded** – Used with **Default Settings for New Fonts: Copyright** in Options: Personalize. Default is on.
* **DefaultNamingCopyrightText** – Used with **Default Settings for New Fonts: Copyright** in Options: Naming. Default is **Typeface © (your company). &lt;year&gt;. All Rights Reserved.**
* **DefaultNamingFontDesignerIncluded** – Used with **Default Settings for New Fonts: Designer** in Options: Personalize.
* **DefaultNamingFontDesignerLinkIncluded** – Used with **Default Settings for New Fonts: Designer URL** in Options: Personalize.
* **DefaultNamingFontDesignerLinkText** – Used with **Default Settings for New Fonts: Designer URL** in Options: Personalize. Default value is file from a non-existing domain.
* **DefaultNamingFontDesignerText** – Used with **Default Settings for New Fonts: Designer** in Options: Personalize. Default is empty.
* **DefaultNamingLicenseAgreementIncluded** – Used with **Default Settings for New Fonts: License Agreement** in Options: Personalize.
* **DefaultNamingLicenseAgreementLinkIncluded** – Used with **Default Settings for New Fonts: License URL** in Options: Personalize.
* **DefaultNamingLicenseAgreementLinkText** – Used with **Default Settings for New Fonts: License URL** in Options: Personalize. Default value is file from a non-existing domain.
* **DefaultNamingLicenseAgreementText** – Used with **Default Settings for New Fonts: License Agreement** in Options: Personalize. Default is empty.
* **DefaultNamingTrademarkIncluded** – Used with **Default Settings for New Fonts: Trademark** in Options: Personalize.
* **DefaultNamingTrademarkText** – Used with **Default Settings for New Fonts: Trademark** in Options: Personalize. Default is **&lt;font family&gt;® Trademark of (your company)**.
* **DefaultPersFontEmbeddingItemID** – Used with **Default Settings for New Fonts: Embedding Lic. Rights** in Options: Personalize.
* **DefaultPersVendorIDText** – Used with **Default Settings for New Fonts: Vendor ID** in Options: Personalize. Default is **HL**.
* **DefaultPersVendorText** – Used with **Default Settings for New Fonts: Vendor** in Options: Personalize. Default is **High-Logic / Made with FontCreator**.
* **DefaultPersVendorURLText** – Used with **Default Settings for New Fonts: Vendor URL** in Options: Personalize.
* **DefaultVendorIDIncluded** – Used with **Default Settings for New Fonts: Vendor ID** in Options: Personalize. Default is on.
* **DefaultVendorIncluded** – Used with **Default Settings for New Fonts: Vendor** in Options: Personalize. Default is off.
* **DefaultVendorURLIncluded** – Used with **Default Settings for New Fonts: Vendor URL** in Options: Personalize. Default is off.
* **DefaultZoomFactor** – Used with **Glyph Edit Window: Open with default zoom factor** in Options: View.
* **ExcludeMonospacedFonts** – Used with **When Saving Font Files: Exclude monospaced fonts** in Options: Font. Default is off.
* **IgnoreHintingData** – Used with **When Opening Font Files: Remove hinting data** in Options: Font. Default is off.
* **IgnoreUnsupportedTables** – Used with **When Opening Font Files: Remove unsupported tables** in Options: Font. Default is off.
* **LastUpdateReminderDate** (`LastUpdateCheck` in `HKCU\Updates` in newer versions) – Includes the date used by the last update check when **Startup: Show update reminder** in Options: General is enabled.
* **LeftSideBearingExcludeLargeFonts** (version 5.5 until 6.5) – Used with **When Saving Font Files: Set left side bearing point at x=0: Exclude large (1500+) fonts** in Options: Font. Default is on.
* **LongAlignedLocalOffsets** – Used with **When Saving Font Files: Long-aligned local offsets** in Options: Font. Default is on.
* **OnStartupOpenFonts** (version 5.6 & above) – Used with **Startup: On start open fonts from last time** in Options: General. Default is on.
* **OnStartupShowUpdateReminder** (`UpdateCheckInterval` in `GUI` in recent versions) – Set this value in **Startup: Show update reminder** in Options: General to 0 (Never), 1 (Once a year), 2 (Twice a year) or 3 (Once a month). Default is 1 (Once a year).
* **OnStartupShowWelcome** – Used with **Startup: On start show Welcome dialog** in Options: General. Default is on.
* **PanoseValueHexadecimal** – Used with **PANOSE: Value: Show hexadecimal** in Font Properties: Characteristics. Default is off.
* **RecalcAverageCharWidth** – Used with **When Saving Font Files: Recalc average char width** in Options: Font. Default is on.
* **RecalcGlyphBoundingBoxes** – Used with **When Saving Font Files: Recalc glyph bounding boxes** in Options: Font. Default is off.
* **RemoveDSIGTable** (version 3.0 until 6.5) – Used with **When Opening Font Files: Remove DSIG table** in Options: Font. Default is off. **Fun fact:** FontForge ignores this table when opening fonts. OpenType flavored PostScript format (otf) requires this table when installing on macOS.
* **RemoveHdmxTable** (version 3.0 until 6.5) – Used with **When Opening Font Files: Remove hdmx table** in Options: Font. Default is on. **Fun fact:** FontForge ignores this table when opening fonts.
* **RemoveLTSHTable** (version 3.0 until 6.5) – Used with **When Opening Font Files: Remove LTSH table** in Options: Font. Default is on. **Fun fact:** FontForge ignores this table when opening fonts.
* **RemoveVDMXTable** (version 3.0 until 6.5) – Used with **When Opening Font Files: Remove VDMX table** in Options: Font. Default is on. **Fun fact:** FontForge ignores this table when opening fonts.
* **SetLeftSideBearingPointAtX0** (version 4.5 & above) – Used with **When Saving Font Files: Set left side bearing point at x=0** in Options: Font. Default is on.
* **UnicodeEnabledGUI** (version 5.5 until 6.5) – Used with **Unicode Support: Enable Unicode support for text display and user input** in Options: General. Default is on. If these versions of this program are ran under Windows 9x/ME or compatibility mode, the option will appear dimmed.
* **UpdateModifiedDateTimeField** (version 3.0 until 6.5) – Used with **Identification: Automatically update modified timestamp when exporting font** in Font Properties: Identification. Default is on (since version 7.0 & above it is enabled for any opened font).
* **ValueHexadecimal** – Used with **Values: Hexadecimal** in the View: Display Format menu. Default is on. **Fun fact:** Hexadecimal values in Delphi are usually given with a dollar sign ($).
* **VectorImageEPSForceRepositioning** (version 6.0 & above) – Used with **Vector Based Images (EPS, AI, PDF, SVG): Move imported outlines to origin (0,0)** in Options: Import. Default is off.
* **VectorImageEPSOriginX** (version 6.0 & above) – Used with **Vector Based Images (EPS, AI, PDF, SVG): Origin X** in Options: Import. Default is 100.00.
* **VectorImageEPSOriginY** (version 6.0 & above) – Used with **Vector Based Images (EPS, AI, PDF, SVG): Origin Y** in Options: Import. Default is 600.00.
* **VectorImageEPSPixelsPerEm** (version 6.0 & above) – Used with **Vector Based Images (EPS, AI, PDF, SVG): Pixels per em** in Options: Import. Default is 512.00.

### Preview
* **FeaturesWidth** – Contains the width used for enabling or disabling OpenType features.
* **FeatureTags** – Contains the tags used to enable or disable OpenType features. Default is empty.
* **PreviewFeatures** – Enable or disable any OpenType feature in the preview text.
* **PreviewFontSize** – Select the size in `TFONTTESTFORM`.
* **PreviewSampleFontSize** – Scale the font in the Preview window. Default is 24.
* **PreviewSampleText** – Contains sample text in the Preview window. Default is **High-Logic ©** (old versions) or **&lt;enter preview text here&gt;**.
* **PreviewSampleUseKerning** – Set this value to on to kern text in the Preview window.
* **ShowToolbarWindowPreview** – Show or hide the Preview window. Default is on.
* **StrikeThrough** – Strikes out text in `TFONTTESTFORM`. Default is off.
* **Underline** – Underlines text in `TFONTTESTFORM`. Default is same as the `StrikeThrough` value.

### Reg
The program is unregistered after the installation process is completed successfully. Many people and companies provided registration keys for different versions.
* **V5D#** – The # at the end is a numerical string. If registration completes successfully, the program will thank the user for registering, add the user's name to the title bar (version 6.0 & above) and removes the **Register** button in `TTIPOFTHEDAYFORM` (version 1.0 until 6.5), **Buy** menu and the **Register** item on the Help menu.

### Themes (version 3.0 until 6.5)
* **ActiveTheme** – Contains the active theme.

### Tip of the Day (version 3.0 until 6.5, used in `TTIPOFTHEDAYFORM`)
* **CurrentTip** – Line number in `FontCreator.tip`. This number increases by one line when closed. Default is first line.
* **ShowTipOnStartup** – This corresponds to **Show this screen next time when you start FontCreator**. Default is on (always show on startup).

### Validation
* **DiagonalRedundantOffCurvePointsDetection** – Used with **Diagonal redundant points detection: Maximum off-curve distance** in Settings: Validation. Default is off.
* **DiagonalRedundantOnCurvePointsDetection** – Used with **Diagonal redundant points detection: Maximum on-curve distance** in Settings: Validation. Default is off.
* **EnableGlyphProblemDetection** – Used with **Enable Real-Time** in the Validation toolbar. Default is on.
* **LocalExtremeCoordinatesDetection** – Used with **Off-curve extreme coordinates: Local detection** in Settings: Validation. Default is on.
* **MaximumRedundantOffCurvePointsDistance** – Used with **Diagonal redundant points detection: Maximum off-curve distance** spinner in Settings: Validation. Default is 0.20.
* **MaximumRedundantOnCurvePointsDistance** – Used with **Diagonal redundant points detection: Maximum on-curve distance** spinner in Settings: Validation. Default is 0.80.
* **ShowIntersection** – Used with **Show Intersecting** in the Validation toolbar. Default is on. If the glyph is too complex, the button will appear dimmed.
* **ShowWarningPoints** – Used with **Show Warning Points** in the Validation toolbar. Default is on. If the glyph is too complex, the button will appear dimmed.
* **TestContoursWithIncorrectDirection** – Used with **Validation Tests: Contours with incorrect direction** in the Font Validation Wizard. Default is on.
* **TestContoursWithOneOrTwoPoints** – Used with **Validation Tests: Contours with one or two points** in the Font Validation Wizard. Default is on.
* **TestDuplicateComponents** – Used with **Validation Tests: Duplicate components** in the Font Validation Wizard. Default is on.
* **TestDuplicateContours** – Used with **Validation Tests: Duplicate contours** in the Font Validation Wizard. Default is on.
* **TestDuplicateKnots** – Used with **Validation Tests: Duplicate knots** in the Font Validation Wizard. Default is on.
* **TestEmptyComponents** – Used with **Validation Tests: Empty components** in the Font Validation Wizard. Default is on.
* **TestFixDetectedProblems** – Used with **Fix detected problems** in the Font Validation Wizard. Default is off.
* **TestIntersectingComponents** – Used with **Validation Tests: Intersecting components** in the Font Validation Wizard. Default is on.
* **TestIntersectingCoordinates** – Used with **Validation Tests: Intersecting coordinates** in the Font Validation Wizard. Default is on.
* **TestOffCurveExtremeCoordinates** – Used with **Validation Tests: Off-curve extreme coordinates** in the Font Validation Wizard. Default is on.
* **TestOverlappingComponents** – Used with **Validation Tests: Overlapping components** in the Font Validation Wizard. Default is on.
* **TestRedundantPoints** – Used with **Validation Tests: Redundant points** in the Font Validation Wizard. Default is on.
* **TestSuspiciousPoints** (version 11.0.0.2365 & above) – Used with **Validation Tests: Suspicious points** in the Font Validation Wizard. Default is on.
* **ValidationMaxNumberOfCompositeGlyphMembers** – Used with **Real-time glyph validation: Disable when number of members exceeds** in Settings: Validation. Default is 1000.
* **ValidationMaxNumberOfContours** – Used with **Real-time glyph validation: Disable when number of contours exceeds** in Settings: Validation. Default is 100.
* **ValidationMaxNumberOfPoints** – Used with **Real-time glyph validation: Disable when number of points exceeds** in Settings: Validation. Default is 25.

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
* **HLFREEDRAW** and **HLFREEDRAWBUSY** – Used by **Free Draw**.
* **HLFREEHAND** – Used by **Freehand**.
* **HLGUIDELINED** – Used by **Guideline**.
* **HLKNIFE** – Used by **Knife**.
* **HLMEASURE** – Used by **Measure**.
* **HLMOVECONTOUR** – Used when moving contours.
* **HLMOVEPOINT** – Used when moving points.
* **HLNEWELLIPSE** – Used when adding ellipses.
* **HLNEWRECTANGLE** – Used when adding rectangles.
* **HLPAINTBUCKET** – Used by **Paint** for colored fonts.
* **HLROTATE** – Used by rotating contours (**Rotate**).
* **HLSEGMENT** – Used by **Paint** for colored fonts.
* **HLSELECT** – Used when selecting anything in the glyph.
* **HLSELECTCONTOUR** – Used when selecting contours.
* **HLSELECTPOINT** – Used when selecting points.
* **HLZOOMIN** – Used when zooming in (**Zoom In**).
* **HLZOOMOUT** – Used when zooming out (**Zoom Out**).

## RC Data in the executable file
* **CLOUDS** (unused) – Shows an image of clouds.
* **DESCRIPTION** and **ELDATA** (unused) – These are binary resources.
* **DVCLAL** (unused) – Shows two paragraphs (the license is valid and is running C++ Builder Professional).
* **PACKAGEINFO** (unused) – Shows the Pascal log used to compile the program.
* **PLATFORMTARGETS** (unused) – This resource is binary and only exists in version 11.5.
* **TABOUTDIALOG** and **TABSTRACTABOUTDIALOG** (**TABOUTFORM** and **THLCREGISTERABOUTBOXDLG** in old versions) – Displays copyright, program/operating system version number, physical memory, registration info and the list of MPL Licensed Open Source Software (**Help: About...**).
* **TABSTRACTWELCOMEDIALOG** (**TWELCOMEFORM** in old versions) – Used by newcomers if `OnStartupShowWelcome` is enabled.
* **TADDCHARACTERSFORM** – Used when adding characters to the font. In **Go to Unicode Block**, **Sorted** is checked by default.
* **TADDCHARACTERTOGLYPHINDEXMAPPINGFORM** – Shows when pressing **Select** in `TCHARACTERTOGLYPHINDEXMAPPINGFORM` to assign Unicode values of any character for each glyph.
* **TADDCUSTOMNAMINGFORM** – Used by **Font Properties: Custom: Add...** to add custom naming fields for multiple languages.
* **TADDFPCVLTSFORM** – Shows a dialog to add labels, tooltips or samples.
* **TADDFPSIZENAMEFORM** – Shows a dialog to add subfamily names to the font.
* **TADDFPSTYLISTICSETNAMEFORM** – Shows a dialog to add or write stylistic set names or descriptions in the font.
* **TADDGASPFORM** – Shows a dialog to add gasp ranges to the font.
* **TADDLOCALLANGUAGEDATAFORM** (version 2.0 until 6.5) – Shows a dialog to add naming fields for multiple languages to the font.
* **TADDPLATFORMFORM** (version 2.0 until 6.5) – Shows a dialog to add a platform to the font (**Add** in `TPLATFORMMANAGERFORM`).
* **TADDUVSFORM** – Used by East Asian fonts to add Unicode variation sequences.
* **TADVANCEDEDITFORM** – Shows a dialog to edit a naming field in the font.
* **TANCHORMANAGERFRAME** and **TANCHORMANAGERFRM** (version 7.0 & above) – Shows a dialog to manage anchors in the font.
* **TAUTOKERNEXFORM** (**TAUTOKERNINGFORM** in old versions) – Shows a dialog to automatically add kerning pairs to the OpenType layout tables (version 7.0 & above) or legacy kerning tables (version 1.0 until 6.5).
* **TAUTOMETRICSFORM** – Shows a dialog to automatically generate metrics for glyphs.
* **TAUTONAMEFORM** (version 5.0 until 6.5) – Shows a dialog to automatically change the naming fields of a font.
* **TBASICEDITFORM** (**TADVANCEDNAMINGFORM** in version 3.0 until 6.5) – Used when including additional naming fields for a font (replaced with `TFONTPROPERTIESFORM` in version 7.0 & above).
* **TCHANGETAGFORM** (version 7.0 & above) – Shows a dialog to change tags in the font.
* **TCHARACTERTOGLYPHINDEXMAPPINGFORM** (version 2.0 until 6.5) – Shows a dialog to map characters to glyph indexes.
* **TCODEEDITORFORM** – Shows a dialog to view or edit the code for the OpenType layout table (**Code Editor** in `TOPENTYPEDESIGNERFORM`).
* **TCODEPAGERANGEFORM** – Shows a dialog to enable or disable code pages to support in the font.
* **TCOLORFORM** (old versions) – This dialog is not the Windows color selector.
* **TCOMPOSITEGLYPHPROPERTIESFORM** – Shows a dialog to view or modify the properties of each member of any composite glyph.
* **TCONVERTBITMAPTOCONTOURSFORM** – Shows a dialog to convert bitmaps to contours or import raster images.
* **TDELETEFEATURELOOKUPFORM** (version 7.0 & above) – Shows a dialog to delete features or lookups in the font.
* **TDELETEKERNGROUPFORM** (version 7.0 & above) – Shows a dialog to delete kerning groups or classes in the font.
* **TDISABLEDFORM** – This dialog is only shown for users who have not registered the program (version 5.0 & above after a grace period of 30 days or version 6.0 until 6.5 and 8.0 until 12.0.0.2539 during or after a grace period of 30 days).
* **TDM** – Contains icons used by the program. **Fun fact:** Windows XP style icons were used in version 5.0 (2005-01-12) up to 11.0.0.2365 (2017-05-10).
* **TDMGLOBAL** – Contains codepages, vendors, hinting and bidirectional mirroring data used by the program.
* **TEDITANCHORFORM** (version 7.0 & above) – Shows a dialog to edit anchors in the font.
* **TEXPORTGLYPHDATAFORM** – Shows a dialog to export glyph data in the font.
* **TEXPORTSETTINGSFORM** and **TEXPORTSETTINGSFRAME** – Shows a dialog to export the font as desktop or web format or both.
* **TEXTERNALSFORM** – Shows a dialog to edit the external tools menu (**Tools: Launch Externals: Configure Externals...**).
* **TEXTRACTFROMTTCFORM** – Shows a dialog to extract OpenType font collections (**Tools: Extract from OTC...**).
* **TFEATURESETTINGSFORM** (version 12.0) – Used when generating or updating OpenType features in `TOPENTYPEDESIGNERFORM`.
* **TFINDFORM** – Used when searching parts of a font.
* **TFONTEMBEDDINGLICENSINGRIGHTSFORM** – Shows a dialog to change embedding or licensing rights in the font.
* **TFONTHEADERFLAGSFORM** – Shows a dialog to change header flags in the font.
* **TFONTINSTALLWIZARDFORM** – Shows a dialog to install the font for use in other applications.
* **TFONTLOGFORM** – Displays the log for any font (**Developer Tools: Font Log**).
* **TFONTOVERVIEWFORM** – Shows the glyphs available in any opened font.
* **TFONTPROPERTIESFORM** – Shows a dialog for properties or unsupported tables for the font.
* **TFONTSETTINGSFORM** – Shows a dialog to change various settings for the font.
* **TFONTTABLESFORM** (version 2.0 until 6.5) – Shows a list of supported and unsupported tables in the font (replaced with a separate tab for unsupported tables in `TFONTPROPERTIESFORM` in version 7.0 & above).
* **TFONTTESTFORM** – Shows a dialog to test desktop fonts (not web fonts). Default text in `mmFontTest` and `Memo1` is the program name, uppercase (the last six letters continue on a new line), lowercase and numbers.
* **TFORMADDANCHOR** (version 7.0 & above) – Used when adding anchors in the font.
* **TFORMOPENTYPEDESIGNERSETTINGS** (version 7.0 & above) – Used when configuring settings in `TOPENTYPEDESIGNERFORM`.
* **TFORMULAFORM** (version 12.0) – Shows a dialog to write formulas to construct composite glyphs (anchor based).
* **TFRAMECATEGORY** – Contains categories in the font overview (left side).
* **TFRAMEGLYPHMEMBER** – Used by the font overview to display glyph members.
* **TFRAMEPALETTE** – Shows a palette of colors for use with multicolored fonts.
* **TGASPFORM** (version 2.0 until 6.5) – Used when managing gasps in the font (replaced with the Smoothing tab in `TFONTSETTINGSFORM` in version 7.0 & above).
* **TGENERATECONTOURSCANCELFORM** – Used when generating contours.
* **TGENERATEPROBLEMREPORTFORM** (version 3.0 until 11.5) – Used when pressing **Next** in `TVALIDATIONWIZARDFORM`.
* **TGLYPHALREADYMAPPEDFORM** (version 2.0 until 6.5) – For each platform a character to glyph index mapping can only exist once, so if you try to add a mapping that already exists this window will ask you what to do.
* **TGLYPHEDITFORM** – Used when opening any glyph from the overview.
* **TGLYPHNAMEFORM** – Shows a dialog to change glyph names.
* **TGLYPHPROPERTIESFORM** (version 2.0 until 6.5) and **TGLYPHPROPERTIESFRAME** (version 7.0 & above) – Shows a dialog to view or edit properties for the selected glyph.
* **TGRIDFORM** – Shows a dialog to view or modify grid settings.
* **TGUIDELINEMODIFYFORM** – Shows a dialog to modify guidelines.
* **TGUIDELINESFORM** – Shows a dialog to view or modify guideline settings.
* **TIMPORTGLYPHDATAFORM** – Shows a dialog to import glyph data.
* **TINSERTGLYPHFORM** – Shows a dialog to insert glyphs to the font.
* **TINSTALLEDFONTSFORM** – Shows a list of installed fonts on a dialog. Version 10.1.0.2272 (2016-12-20) & below had a waiting delay.
* **TKERNFEATUREFRAME** – Used by the kerning window.
* **TKERNGROUPMANAGERFORM** (version 7.0 & above) – Shows a dialog to manage kerning groups or classes in the font.
* **TKERNINGFORM** (version 3.0 until 8.0) – Views or edits the old KERN table (not the GPOS kerning tables) in the font (replaced with `TOPENTYPEDESIGNERFORM` in version 7.0 & above).
* **TKERNINGNEWPAIRFORM** (version 3.0 until 8.0) – Adds a kerning pair to the old KERN table (not the GPOS kerning tables).
* **TKERNINGNEWSINGLEFORM** (version 7.0 & above) – Adds a single adjustment to the font.
* **TMAINFORMFONTCREATOR** (**TMAINFORMFCP3** in version 3.0) – Contains a lot of things like the FontCreator main window, glyph transformation (simple glyphs only), glyph properties, user notes, font preview, glyph validation report and more.
* **TMETRICSFORM** – Shows a dialog to view or modify metrics options.
* **TNAMINGFORM** (version 3.0 until 6.5) – Shows a dialog to view or edit the font naming fields (replaced with `TFONTPROPERTIESFORM` in version 7.0 & above).
* **TNEWTRUETYPEFONTFORM** – Used when creating a new font.
* **TOPENTYPEDESIGNERFORM** (version 7.0 & above) – Shows a dialog to view, edit or create OpenType layout tables.
* **TOPENTYPEITEMADDFRM** (version 7.0 & above) – Shows a dialog to add items to the OpenType layout tables.
* **TOPTIONSFORM** – Shows an interface for viewing and setting a wide variety of options, many of which uses registry keys in the program itself (editing varies based on whether the program is running or not).
* **TOTLFRENAMEFORM** (version 7.0 & above) – Used when renaming layout features in the OpenType layout tables.
* **TPASTESPECIALFORM** – Shows a dialog to paste glyphs stored in the clipboard. In the Items list (version 5.5 until 6.5), **Glyph Outline Data** and **Glyph Metrics** (i.e. the first two items) are checked by default. In recent versions, the registry keys are stored in the `Edit` key.
* **TPCLTFORM** (version 3.0 until 6.5) – Shows a dialog to view, edit or modify the PCL5 data for use with old printers.
* **TPERFORMTRANSFORMATIONFORM** (version 5.6 & above) – Displays the Glyph Transformer.
* **TPLATFORMMANAGERFORM** (version 2.0 until 6.5) – Shows a dialog to choose which platform to support in the font (replaced with **Tools: Convert Font** in version 7.0 & above in `TMAINFORMFONTCREATOR`).
* **TPOSTSCRIPTNAMESFORM** (version 2.0 until 6.5) – Shows a dialog to view or modify the PostScript glyph names in the font.
* **TPRINTABORTFORM** – Used after the font printing process is started.
* **TPRINTFONTFORM** – Used when printing anything in the font.
* **TPRINTGLYPHFORM** – Used when printing a glyph.
* **TPROGRESSDIALOG** (**TPROGRESSFORM** in old versions) – Progress window. The cursor for this form is **Busy**.
* **TREGISTERFORMEX** and **TREGISTERFORMFC** (**TREGISTERFORM** in old versions) – Shows a dialog to enter the registration code (**Help** or **Buy: Register...**). This removes `TSPLASHFORM` on startup and hides the **Buy** menu and the **Register...** item on the **Help** menu. The user agent in `TREGISTERFORMEX` has its own user agent.
* **TRESOURCEMODULE** – Contains styles located in `rvStyleGlobal` and its icons.
* **TRICHVIEWDIALOG** (unused) – Used for the rich text module. Contains styles located in `RVStyle1`.
* **TRULEMANAGER** (version 7.0 & above) – Shows a dialog to manage rules in the OpenType layout tables.
* **TSAMPLETEXTFORM** (version 7.0 & above) – Shows a dialog to add custom sample text strings to `TFONTTESTFORM`.
* **TSELECTCOMPOSITEGLYPHMEMBERFORM** – Shows a dialog to add glyph members to a composite glyph.
* **TSELECTLOOKUPTABLEFORM** – Shows a dialog to select a lookup table in the OpenType layout tables.
* **TSHAREWAREFORM** (version 3.0 until 4.5) – This dialog is only shown for users who have not registered the program and when pressing **Start** on `TSPLASHFORM` after a grace period of 30 days.
* **TSORTGLYPHSFORM** (version 1.0 until 6.5) – Shows a dialog to change the glyph order within a font. See **Tools: Sort Glyphs** in `TMAINFORMFONTCREATOR` in recent versions.
* **TSPLASHFORM** – For unregistered copies. The three buttons at the bottom (**Use Evaluation Version**, **Enter Registration Code** and **Buy Now**) are displayed randomly.
* **TSPTBXCOLORPICKERFORM** – For colored fonts only, selects colors in this form.
* **TSUBLOOKUPMGR** (version 7.0 & above) – Shows a dialog to manage subtables in the OpenType layout tables.
* **TTEXTREPLACEDIALOG** – Used when replacing text in `TCODEEDITORFORM`.
* **TTEXTSEARCHDIALOG** – Used when searching text in `TCODEEDITORFORM`.
* **TTIPOFTHEDAYFORM** (version 1.0 until 6.5) – Used for newcomers and **Help: Tip of the Day** (`FontCreator.tip` is used to display tips). The **Register** button is only shown for users who have not registered the program. See **Tip of the Day** in **FontCreator: Tutorials and Solutions** in the High-Logic forum for recent tips.
* **TTRANSFORMFORM** – Used when transforming simple glyphs.
* **TTRIMFORM** – Used when trimming glyphs.
* **TUNICODERANGEFORM** – Shows a dialog to enable or disable Unicode blocks or ranges to support in the font.
* **TUPDATEFORM** and **TUPDATEFORMFC** (**TUPDATEREMINDERFORM** in old versions) – Used when the program checks for updates as if `OnStartupShowUpdateReminder` is enabled. The user agent in `TUPDATEFORM` is an old version of Firefox. `mRestart` should have three lines to prevent the program from closing itself on startup.
* **TUSEDBYFORM** – Displays an overview of all glyphs that use the selected glyph.
* **TUVSFORM** – Used by East Asian fonts to manage Unicode variation sequences.
* **TVALIDATIONWIZARDFORM** – Shows a dialog to validate the font for errors or problems.
* **TWIDEMESSAGEFORM** – Used for messages.
* **TWIDEWARNINGFORM** (**TWARNINGFORM** in old versions) – Used for warnings.

## Unused Content
Remove `Visible = False` in the RC Data resources above to show them.

### Menu
* **Edit: Knife** – Use the **Knife** button in the **Glyph** toolbar as this command does nothing when selected.
* **View: Toolbars: Tab Bar** – This menu item is intended to hide the tabs if version 6.1 is used.
* **Tools: TODO! Customize...** – This menu item is included in all versions and is intended to modify the toolbar.
* **Window: Minimize All** – This menu item will minimize all windows (use the restore button on each minimized window to restore them).

### Hidden Shortcuts Menu (`TMAINFORMFONTCREATOR`)
* **Restore Overview Splitter** – Hide or show the overview splitter.
* **Close** – Close active window with the same command in the **File** menu.
* **Cut**, **Copy** and **Paste** – Uses the same commands in the **Edit** menu.
* **Show Font Properties** – Uses the same command in the **Font** menu.
* **Redo** – Uses the same command in the **Edit** menu.
* Tags from **tags.txt** and **Tagged** folder from `TFONTOVERVIEWFORM` – The menu items do nothing when clicked in `TFONTOVERVIEWFORM` except when using the same items from `TFONTOVERVIEWFORM` context menu by right clicking any glyph or editing glyphs in `TGLYPHEDITFORM`.

### Developer Tools Menu (`TMAINFORMFONTCREATOR`)
This menu is only shown for users who have registered the program. Contains developer related commands.
* **Screenshot macro 1** or **Screenshot macro 2 (website)** – Creates screenshot macros.
* **Hide Developer Menu** – Removes the menu itself by adding `Visible = False`.
* **AutohintMacro** – Closes all fonts with the same command in the **File** menu.
* **Video mode** – Displays settings about the used theme.
* **A/B Testing** – Contains two options to set the variant.
* **Font Log** – Displays the log for any font.
* **Disable garbage collector**
* **Increase Font Size** – Displays information about the current font in the system with the size.
* **Enable All Toolbar Icons** – Enables all icons in toolbars.
* **Font Tester Action** – Changes action used by `TFONTTESTFORM`.
* **Boink!** – Exit the program immediately. This menu item is located in FontCreator 11.5 in the **Debug** menu. It may display a dialogue box that cannot be closed, which contains an "OK" button.

### Resource Editor (`TRESOURCEEDITORDLG`)
This dialog is for use with Font Creator Program 3.0 only and is used to edit resources.

### Contours Menu (`TGLYPHEDITFORM`)
* **Debug Single Stroke Twice** – This menu item is dummy.
* **miTestItem2** – This menu item is dummy.
* **miTestItem3 Save** – Saves glyph data to `C:\hltemp\glyph.data`.
* **miTestItem4 Load** – Loads glyph data from `C:\hltemp\glyph.data`.

### Toolbar Buttons
* Secondary **Open** and **Print** options in the **Standard** toolbar – Only the secondary **Print** option does the same command in the **File** menu or the primary **Print** option.
* **Generate Glyph Names** (GN in the **Tools** toolbar) – Generates glyph names to `C:\Users\EDenissen\AppData\Roaming\FontCreator12\generatednames.txt`. **EDenissen** stands for Erwin Denissen (sole developer of this program, president and founder of High-Logic B.V.).
* **Smooth Points** (S in the **Glyph** toolbar) – Smooths all points. Only works in `TGLYPHEDITFORM`.
* **Smooth and Align Points** (SA in the **Glyph** toolbar) – Smooths and aligns points. Only works in `TGLYPHEDITFORM`.
* **Harmonize** (H in the **Glyph** toolbar) – Harmonizes all contours. Only works in `TGLYPHEDITFORM`.
* **Round Corners** (R in the **Glyph** toolbar) – Force rounded points. Only works in `TGLYPHEDITFORM`.

### Font Overview
Version 5.0 until 6.5 includes bookmark menu entries for each glyph (the menu is hidden since version 7.0 & above).

### Composite Glyph Properties
This dialog includes a text box with glyph indexes at the top right corner (it is shown in old versions only).

### Automatic Metrics Wizard
This dialog includes a text box prompting the user to use the Professional Edition (the `Visible = False` value is removed in the Home Edition).

### OpenType Designer
These buttons only affects kerning tables. All buttons are named capital d in square brackets at the beginning.
* **Clear Value** – Set values for all kerning pairs to zero.
* **Harmonize** – Harmonizes all kerning pairs in subtables.
* **Clean Up** – Delete all kerning pairs that have a zero value.

### Code Editor
* Debugger selection dropdown list – Selecting options will discard changes to the code.
* Checkbox: **Debug: VOLT.UseGlyphIds** – For use with fonts with VOLT projects only.

### Font Test Window
The context menu has two paste options.

### Options Window
The **Preview** tab includes three unused buttons to move strings up or down or to reset the list.

### About Dialog
These buttons are only in version 6.0 & above and are located in the corners of the version number, copyright info and the company's website.
* **Clr** (Clear) (top left corner) – Remove registration info to make the program unregistered.
* **Crash** (top right corner) – Displays a critical error which reads "We hope you enjoyed clicking this crash button".
* **Trial** (bottom right corner) – Reset trial period for unregistered copies after a grace period of 30 days.
