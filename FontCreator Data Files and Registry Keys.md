## Notes
* The cursor remains "Busy" when saving fonts and doing other stuff in the background.
* All versions allows saving all unaltered opened fonts from the menu (**File: Save All**) but not in the Standard toolbar. In double-byte versions of Windows, the system displays a critical error saying "List index out of bounds (0)".
* Exiting the program may create invalid font(s) and play the Critical Stop sound from the PC speakers.
* The program displays the "Access violation" when closing after doing some operations – the font(s) may be invalid.
* Any glyph stored in the clipboard in version 1.0 until 6.0 will have the words **Glyph Contours** for contours or **Glyph Data** for the entire glyph.
* Any glyph stored in the clipboard in version 7.0 will have **Font Data**.
* The **Delete** item in the **Edit** menu is not dimmed on startup or when closing other dialogs.
* **Complete Composites** (when generated from `CompositeData.xml` but not auto or anchor based) slows down the first time using in simple and composite glyphs.
* **Complete Composites** is dimmed when editing empty glyphs in version 5.0 until 6.0.
* The program displays a critical error if you use Complete Composites in some glyphs in the Private Use Area. After that, these glyphs cannot be recovered. [Bhikkhu Pesala](http://www.softerviews.org/Fonts.html), UK, the guy behind the sample glyphs and his fonts created by the same program, has assigned code points in the Private Use Area for different glyphs in his fonts, notably low profile diacritics and small capitals. Rebecca G. Bettencourt / [Kreative Korp](http://www.kreativekorp.com/), the girl behind Bits'n'Picas and her fonts has assigned code points in the Private Use Area for different glyphs in her fonts, notably extended block elements.
* Version 1.0 (1998-04-11) until 7.0 (2013-04-25) only generates postscript names or adds any glyph to the preview toolbar that have a Unicode BMP mapping.
* Version 5.0 (2005-01-12) until 10.1.02272 (2016-12-20) uses Windows XP style icons whereas version 11.0.0.2365 (2017-05-10) & above uses a different icon set.
* If you want to change resources in versions containing a non-standard resource layout (tested with version 5.6), you would have to use [Resource Tuner](http://www.heaventools.com/resource-tuner.htm) (tested with version 2.20) or [UPX](https://upx.github.io/) (tested with version 2.01 released in 2006 and distributed with FreeDOS) to unpack the executable file which isn't possible as UPX says it's not packed.
* In new fonts, the Euro (€) doesn't have a Macintosh Roman mapping but the international currency sign (¤) does have it.
* The euro (€) and international currency sign (¤) has the same mapping in the Macintosh Roman glyph mapping list.
* Version 1.0 (1998-04-11) until 5.6 (2007-07-19) used ISO Latin-1 as the output encoding while current versions use Unicode. Setting the non-Unicode language to East Asian languages (e.g. Korean) substitutes accented letters by ASCII counterparts, e.g. é by e and when exporting kerning pairs, instead of having &lt;&lt; (much less than) for « you have to use \\00AB as escape code.

## Unregistered version limitations
The unregistered version has a grace period of 30 days with the following limitations based on the version number.
* 3.0β1 (2000-07-30) until 3.1.3 (2002-12-09) – After a grace period of 30 days, the program will show a nag screen when pressing **Start**. However, the program otherwise functions normally.
* 4.0 (2003-05-16) until 4.5 (2004-08-17) – After a grace period of 30 days, the program cannot be used at all until the registration process is started.
* 5.0 (2005-01-12) until 5.6 (2007-07-19) – After a grace period of 30 days and opening the program 5 times, the program will enter a reduced functionality mode, where fonts cannot be saved, tested or installed and OpenType collections cannot be extracted.
* 6.0 (2009-06-17) until 6.5 (2011-11-18) and 8.0 (2014-06-05) until 12.0.0.2539 (2019-06-04) – The program runs a reduced functionality mode, where e.g. tested fonts won't be automatically hinted.
* 7.0 (2013-04-25) and 7.5 (2013-08-02) – Before a grace period of 30 days, the program will create subsetted versions when saving, testing, exporting or installing fonts. After a grace period of 30 days, the program will enter a reduced functionality mode, where fonts cannot be saved, tested, installed or exported and OpenType collections cannot be extracted.
* 12.0.0.2543 (2019-07-10) until 12.0.0.2547 (2019-09-12) – Before a grace period of 30 days, the program will add watermarks when generating fonts. After a grace period of 30 days, the program will enter a reduced functionality mode, where fonts cannot be saved, tested, installed or exported and OpenType collections cannot be extracted.
* All versions – The window title bar will display **(UNREGISTERED)**.

Under the **Help** menu is an item labeled **Register...** (the same item is in the **Buy** menu along with **Buy Now**) when this executed a screen will pop up giving the registration code.

## Windows version compatibility
* Windows Vista and later – 12.0.0.2547
* Windows XP – 10.0
* Windows 2000 – 7.0
* Windows 95, 98, ME and NT 4.0 – 6.0.1

## User Data (Glyph Transformer scripts and Unicode data files omitted)
FontCreator uses several data files for advanced settings and customizations. Normally most files are stored in a system folder where they cannot be changed. If you want to edit most files directly they either must have administrative privileges or change the owner to users (this can be done with `takeown /F` or **Security: Advanced: Owner: Edit** in Windows Vista and 7 and **Security: Advanced: Owner: Change** in Windows 8 and 10 in the file properties).

* **bookmarks.txt** – Created automatically after exit. Includes bookmarks used in the glyph overview.
* **CompositeData.xml** – Located in the Composite folder as used by **Complete Composites**.
* **CurrentTransformProgram.xml** – Created when opening a Transform Program in the Glyph Transformer. If removed, this window appears blank.
* **FC#####.ttf** – Temporary font used by `TFONTTESTFORM` (##### is five numbers). The font name in version 3.0 through 6.5 is FC Test Font ###### (###### is six numbers).
* **fc12.cfg** – Configuration file used by FontCreator.
* **fcppreview.txt** (version 3.0 until 4.5) – Controls the text used in `TFONTTESTFORM`. The text is restored to factory defaults if removed.
* **fntXX.tmp** or **fntXXX.tmp** – Temporary font used for saving (XX or XXX are letter and number combos).
* **FontCreatorSetup.exe** – Install wizard for x86 platform.
* **FontCreatorSetup-x64.exe** – Install wizard for x64 platform.
* **FontCreator.tip** – Contains the tips in the Tip of the Day Window. If removed, this window appears blank.
* **glyphlist.dat** – Contains the Adobe glyph list. Old versions have the same list but duplicates **xi** to U+0000.
* **glyphnamesnew.dat** (version 7.0 & above) – Contains the default glyph names when opening existing fonts and when generating glyph names on the Glyph Properties dialog. Prior to FontCreator 12 another file (`glyphnames.dat`) was used, but that one is now obsolete.
* **guidelines.dat** – Created automatically after exit. Includes guidelines used in the Glyph Edit window and Guideline Options.
* **kern_filename.txt** – For old versions of FontCreator, stores the legacy kerning pair data for each font whereas `filename` is the font name.
* **previewtext.dat** (version 5.0 & above) – Controls the text used in `TFONTTESTFORM`. The text is restored to factory defaults if removed.
* **preview.txt** (version 6.5 & above) – Contains the standard preview texts for the Preview toolbar. The dropdown list is shown as blank if removed.
* **SubFamily.dat** or **SubFamily2.dat** – Includes naming fields for multiple languages.
* **TableOffsetOrder.dat** – Contains the tables supported by any font. All tables are moved to Unsupported if removed. Newer versions names it `TableOffsetOrder.txt` with another file (`TableOffsetOrderCFF.txt`).
* **tags.txt** (version 7.0 & above) – Controls the names of the five tags that can be assigned to each glyph.

In **Options: Advanced: Data Files** are two buttons labeled **Copy Data Files to User Data Folder** and **Open User Data Folder** when pressed the program will either copy most files to the user data folder or open it.

## Registry Keys

### AddCharacters (used in `TADDCHARACTERSFORM`)
* **SelectedCharacter** – Select the character used in this dialog. Default is beginning of Basic Latin Unicode block.
* **SelectedFont** – Select the font used in this dialog. Default is **Arial Unicode MS**.

### Background
* **BackgroundInitColor** – Select the background color. Default is white.
* **BackgroundInitScale** – Select the background scaling factor.

### Columns
* **Open Installed Fonts** – Binary value used by `TINSTALLEDFONTSFORM`.

### Edit (used in `TPASTESPECIALFORM`)
* **PasteSpecialAnchors** – Used to paste anchors. Default is on.
* **PasteSpecialCodepoints** – Used to paste codepoints. Default is on.
* **PasteSpecialCodepointsOption** – Used to select the option to paste codepoints. Default is 0 (Keep same code-points).
* **PasteSpecialGlyphNames** – Used to paste glyph names. Default is off.
* **PasteSpecialMetrics** – Used to paste metrics. Default is on.
* **PasteSpecialMetricsOption** – Used to select the option to paste metrics. Default is 0 (Side bearings).
* **PasteSpecialOutlineData** – Used to paste outline data. Default is on.

### Externals (used by Tools: Launch Externals)
There are three built-in external programs: **MainType** (if installed), **Fonts Folder** and **Character Map**.
* **Location#** – The last character can be up to digit three. Default is empty.
* **Title#** – The last character can be up to digit three. Default is **External #** whereas # is a number.

### Find (used in `TFINDFORM`)
* **FindLanguageID** – Select the language identifier.
* **PlatformID** – Select the **Platform** identifier in the Mapping tab.
* **PlatformSpecificEncodingID** – Used to change the specific encoding for **Platform** in the Mapping tab.
* **TabIndex** – Used to change the tab.

### FontOverview
* **CategoryWidth** – Select the width used for categories in the font overview.

### Fonts (used in Options: Font)
* **ExportDecomposeScaled** (version 12.0.0.2521 & above) – Used with **Export Font: Decompose composite glyphs with scaled components**. Default is on.
* **ExportExcludeLegacy** – Used with **Export Font: Exclude legacy data**. Default is on.
* **FontEnableOpenContours** (version 11.5.0.2421 & above) – Used with **Special Features: Enable open contours**. Default is on.
* **OpenFriendlyGlyphNames** – Used with **Open Font: Generate friendly glyph names**. Default is on.

### FreeDraw (version 6.5 & above, used in Free Draw)
* **BrushWidth** – Used to change the **Brush width**.

### Glyph Edit Window
* **FilledOutline** – Used with **Fill Outline** in the Grid toolbar.
* **ShowConnectionBetweenPoints** – Used with **Show Connection** in the Grid toolbar. Default is on.
* **ShowFirstAndLastPointIndicators** – Used with **Show First and Last** in the Grid toolbar. Default is on.
* **ShowToolbarWindowBackground** – Enables or disables the Background Image toolbar. Default is off.
* **ShowToolbarWindowKerning** – Enables or disables the kerning window. Default is off.
* **ShowToolbarWindowMembers** – Enables or disables the members window for use with colored fonts. Default is off.
* **ShowToolbarWindowPalette** – Enables or disables the palette for use with colored fonts. Default is off.
* **ShowToolbarWindowTransformation** – Used with **Transformation** in the toolbar right click context menu. Default is on.
* **ShowToolbarWindowValidation** – Used with **Show Report** in the Glyph toolbar. Default is off.

### Grid
* **FixedGridColor** – Select the fixed grid color in Grid Options. Default is white.
* **FixedGridLineStyle** – Select the fixed grid line style in Grid Options. Default is solid.
* **GridColor** – Select the grid color in Grid Options. Default is sky blue.
* **GridDistance** – Used with **Mininum distance between grid points in units** in Grid Options.
* **GridDistancePixels** – Used with **Mininum distance between grid points in pixels** in Grid Options.
* **GridLineStyle** – Select the line style in Grid Options. Default is solid.
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
* **UpdateCheckInterval** – Used by **Startup: Check for updates** in the Options: General tab. Values are 000 (never), 001 (every day), 007 (once a week), 030 (once a month), 182 (twice a year) or 365 (once a year). Default is 007 (once a week).

### GuideLines (used in `TGUIDELINESFORM`)
* **Color** – Select the guideline color. Default is black.
* **LineStyle** – Select the guideline line style. Default is solid.

### ImportImage (used in `TCONVERTBITMAPTOCONTOURSFORM`)
* **BitmapPositionOrigin** – Used with radio buttons in the **Glyph: Position** option.
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

### Install (used in `TFONTINSTALLWIZARDFORM`)
* **InstallFontsInFontsFolder** – In old versions only; used with **Install the font in Windows Fonts folder**. Default is on. Windows Vista and above adds a shield before the label.

### InstalledFonts (used in `TINSTALLEDFONTSFORM`)
* **PreviewHeight** – Select the height used for the preview area.

### Interface (used in the toolbar context menu or View: Toolbars)
* **LockToolbars** – Used with **Lock Docked Toolbars**. Default is off.
* **ShowUserNotes** – Used with **Show User Notes**. Default is off.

### Interface Settings
* **ChildWindowState** – Contains the child window state.
* **CompleteCompositesAction** – Used with **Complete Composites** button in the toolbar to set the value to either 1 (auto), 2 (anchor based), 3 (anchor based reposition) or 4 (composite data). Default is 1 (auto).
* **CustomNamingShowOutputContent** – Used by **Custom: Additional Naming Fields: Show Output Content** in the Font Properties window.
* **ExportSettingsPage** – Select the page used for the export settings.
* **GlyphCaptionAuto** – Used with **Glyph Caption: Automatic** in the right-click context menu of font overview.
* **GlyphCaptionType2** – Used with the Captions options in the right-click context menu of font overview.
* **GlyphDrawMode** – Set the value to 2 for automatic display, 0 for monochrome or 1 for color display. Default is 2 (auto).
* **GlyphFillAlpha** (version 11.0.0.2365 & above) – Used with **Fill Outline** in the View menu.
* **GlyphNamesHistoryReplace** (version 11.0.0.2365 & above) – Contains the history of postscript names to replace as used by the glyph names dialog.
* **GlyphNamesHistorySearch** (version 11.0.0.2365 & above) – Contains the history of postscript names to find as used by the glyph names dialog.
* **GlyphNamesOptionsCS** – Contains the context substitutions used by the glyph names dialog.
* **GlyphNamesOptionsRE** – Contains the regular expressions used by the glyph names dialog.
* **GlyphOutlineFillMode** – Used with **Glyph outline fill mode** in the Options: General tab.
* **GlyphPropsExpanded** – Used to expand the glyph properties.
* **GroupManagerSorted** – Used to sort the group manager.
* **InsertGlyphsCB1** and **InsertGlyphsCB2** – Used by the insert glyphs window to select either 0 (at top), 1 (after last glyph), 2 (before each selected glyph) or 3 (after each selected glyph). Default is 3 (after each selected glyph).
* **InsertGlyphsPage** – Select the page used in the Insert Glyphs dialog.
* **KerningFolderExport** – Directory for exporting the legacy kerning tables.
* **KerningFolderImport** – Directory for importing the legacy kerning tables.
* **NewFontIncludeOutlines** – Used with **Predefined outlines: Include outlines** in the new font dialog. Default is on.
* **OpenDialogInitialDir2** – Directory used in the Open dialog.
* **OpenDialogInitialDirAutoKerning** – Directory used in the AutoKern Open dialog.
* **OpenDialogInitialDirImportImage** – Directory used in the Import Image Open dialog.
* **OpenDialogInitialDirNamingField** – Directory used in the Edit Naming Field Open dialog.
* **OpenDialogInitialDirTransform** – Directory used in the Glyph Transformer Open dialog.
* **OptionsPage** – Select the tab used in the Options dialog.
* **OTLFDesignerCollapsedFeatures** – Select the features to collapse in the OpenType Designer.
* **OTLFDesignerCollapsedLookups** – Select the lookups to collapse in the OpenType Designer.
* **OTLFDesignerCollapsedScripts** – Select the scripts to collapse in the OpenType Designer.
* **OTLFDesignerPreviewLanguage** – Contains the language used for the preview text in the OpenType Designer.
* **OTLFDesignerPreviewSampleText** – Contains the sample text used for the preview text in the OpenType Designer.
* **OTLFDesignerPreviewScript** – Contains the script used for the preview text in the OpenType Designer.
* **OTLFEditor** – Stores the settings used in the OpenType script editor.
* **OverviewColCat** – Contains the column categories used in the glyph overview.
* **OverviewFontZoom** – Contains the zoom factor used in the glyph overview. Default is 35.
* **OverviewGridZoom** – Contains the grid zoom factor used in the glyph overview.
* **OverviewSampleFont** (version 4.0 & above) – Used with **Font Overview: Font used in cells** in the View tab. Default is **Arial**. If this string is empty, the previews are displayed with **MS Sans Serif** moving the glyphs to different positions. (Available in the Options window)
* **OverviewShowCaption** – Used with **Font overview: Show caption** in the Overview tab. Default is on. (Available in the Options window)
* **OverviewShowSample** – Used with **Font Overview: Show sample in empty glyphs** in the Overview tab. Default is on. (Available in the Options window)
* **OverviewSingleHeight** – Used with **Font overview: Glyph height** in the Overview tab. Default is 48. (Available in the Options window)
* **OverviewSingleWidth** – Used with **Font overview: Glyph width** in the Overview tab. Default is 70. (Available in the Options window)
* **OverviewSmoothGlyphs** – Used with **Font overview: Smooth glyphs** in the Overview tab. (Available in the Options window)
* **OverviewUndoLimitMaxCount** – Used with **Undo limits: Max. count** in the Edit tab. Default is 1. (Available in the Options window)
* **OverviewUndoLimitMaxSize** – Used with **Undo limits: Max. size [KB]** in the Edit tab. Default is 1. (Available in the Options window)
* **OverviewUseColor** – Used with **Font overview: Use type color in glyph caption** in the Font tab. Default is on. (Available in the Options window)
* **SampleFileName** – Used with **Samples Toolbar Font: Filename** in the General tab. Default is blank.
* **SampleSingleHeight** – Used with **Samples Toolbar: Glyph height** in the Sample tab. Default is 55. (Available in the Options window)
* **SampleSingleWidth** – Used with **Samples Toolbar: Glyph width** in the Sample tab. Default is 62. (Available in the Options window)
* **SaveDialogInitialDirNew2** – Contains the initial directory used in the save dialog.
* **SelectCompositeCaptionType** – Contains the caption used in the select composite glyph window.
* **SelectCompositeFontZoom** – Contains the zoom factor used in the select composite glyph window.
* **SelectCompositeGridZoom** – Contains the grid zoom factor used in the select composite glyph window.
* **SettingsPage** – Select the tab used in the Settings dialog.

### Kerning
* **AutoKerningAllowForPositiveKerningValues** – Used with **Additional Options: Allow for positive kerning values** in the AutoKern window.
* **AutoKerningExcludeLowerLower** (version 11.0 & above) – Used with **Exclude lowercase-lowercase pairs** in the AutoKern window.
* **AutoKerningExcludeLowerUpper** – Used with **Exclude lowercase-uppercase pairs** in the AutoKern window.
* **AutoKerningImportFilename** – Used with filename string in the disabled text box.
* **AutoKerningMinAbsKernValue** – This corresponds to numerical strings for the **Additional Options: Minimum absolute kerning value** in the AutoKern window.
* **AutoKerningReplaceKerning** – Used with **Additional Options: Replace existing kerning when** dropdown box in the AutoKern window.
* **AutoKerningReplacePercentage** – Used with **Additional Options: Replace existing kerning when** slider in the AutoKern window.
* **AutoKerningUseBaseMetrics** – Used with **Composite glyphs follow base glyphs (use this glyph's metrics)** in the OpenType Designer Kern Wizard. Default is on.
* **AutoKerningWhiteSpace** – Used with **Additional Options: White space between characters** in the AutoKern window.
* **KerningColorBackground** – Select the color used for the background. Default is white.
* **KerningColorBaseline** – Select the color used for the baseline. Default is red.
* **KerningColorFirst** – Select the color used for the left glyph. Default is dark blue.
* **KerningColorGridLines** – Select the color used for the Grid Lines. Default is gray.
* **KerningColorSecond** – Select the color used for the right glyph. Default is dark green.
* **KerningShowBaseLine** – Display baseline in Kerning window. Default is on.
* **KerningShowBearingLines** – Display bearing lines in Kerning window. Default is on.
* **KerningShowGridLines** – Display grid lines in Kerning window. Default is on.

### Last Time
* **File_#** – Include fonts used the last time whereas # is a number. When `OnStartupOpenFonts` is enabled, nothing will be opened if removed.

### Metrics (used in `TAUTOMETRICSFORM`)
* **AutoMetricsExcludeEmptyGlyphs** – Used with **Additional Options: Exclude empty glyphs (recommended)**.
* **AutoMetricsFixedAW** – Used with **Fixed: Change Advance Width**.
* **AutoMetricsFixedChangeAW** – Used with **Fixed: Change Advance Width**.
* **AutoMetricsFixedChangeLSB** – Used with **Fixed: Change Left Side Bearing**.
* **AutoMetricsFixedLSB** – Used with **Fixed: Change Left Side Bearing** spinner.
* **AutoMetricsOpticalFactor** – Used with **Glyph spacing factor**. Default is 27.
* **AutoMetricsOpticalPreview** – Used with **Preview Text**. Default is same as the label.
* **AutoMetricsOptionIndex** – Used by radio buttons.
* **AutoMetricsWhiteSpaceAfter** – Used with **Calculated: White space after characters**.
* **AutoMetricsWhiteSpaceBefore** – Used with **Calculated: White space before characters**.

### MetricsAndKerning
* **MetricsAndKerningKerningEnabled** – Used by **OpenType Layout Features** in the Comparison toolbar. Default is off.
* **MetricsAndKerningTextEnabled** – Used by **Show text before and after glyph** in the Comparison toolbar. Default is off.
* **MetricsAndKerningTextLeft** – Used by **Before** text box in the Comparison toolbar. Default is empty.
* **MetricsAndKerningTextRight** – Used by **After** text box in the Comparison toolbar. Default is empty.

### Most Recently Used Files, Most Recently Used Projects
* **File_#** – Lists the font and project file names in the **File: Reopen** menu (# is a number). The menu will appear dimmed if deleted or cleared via the menu itself.

### OpenType Designer (version 7.0 & above)
* **FillGlyphOutlines** – Used with **Colors: Fill glyph outlines** in the OpenType Designer Settings window.
* **GlyphFillColor** – Used with **Colors: Glyph fill color** in the OpenType Designer Settings window.
* **LayoutMode** – Select the layout mode used in the OpenType Designer.
* **MarkWidth** – Select the mark width used in the OpenType Designer.
* **PairWidth** – Select the pair width used in the OpenType Designer.
* **PreviewHeight** – Select the preview text height in the OpenType Designer.
* **PreviewSampleFontSize** – Select the preview sample font size in the OpenType Designer.
* **SimpleWidth** – Set the width used in the OpenType Designer.
* **SingleWidth** – Set the width used in the OpenType Designer.
* **TreeWidth** – Select the tree width used in the OpenType Designer.
* **ZoomFactor** – Select the zoom factor used in the OpenType Designer.

### Options
* **AlwaysCreateBackupCopy** – Used with **Create backup copy (bck) on saving a font project** in the Advanced: Settings tab. Default is off.
* **AutoFitGlyphInWindow** – Used with **Glyph Edit Window: Auto fit glyph in Window** in Options: Glyph. Default is on.
* **AutoNamingUseFontRevision** – Used with **Automatic Naming Wizard: Version String: use Font revision version from Font Settings → Header page** in Options: Naming. Default is on.
* **CompressHmtxTable** – Used with **When Saving Font Files: Compress hmtx table** in Options: Font. Default is on.
* **CompressNameTable** – Used with **When Saving Font Files: Optimize name table** in Options: Font. Default is on.
* **DefaultNamingCopyrightIncluded** – Used with **Default Settings for New Fonts: Copyright** in Options: Personalize. Default is on.
* **DefaultNamingCopyrightText** – Used with **Default Settings for New Fonts: Copyright** in Options: Naming. Default is **Typeface © (your company). &lt;year&gt;. All Rights Reserved.**
* **DefaultNamingFontDesignerIncluded** – Used with **Default Settings for New Fonts: Designer** in Options: Personalize.
* **DefaultNamingFontDesignerLinkIncluded** – Used with **Default Settings for New Fonts: Designer URL** in Options: Personalize.
* **DefaultNamingFontDesignerLinkText** – Used with **Default Settings for New Fonts: Designer URL** in Options: Personalize. Default value leads to a non-existing domain.
* **DefaultNamingFontDesignerText** – Used with **Default Settings for New Fonts: Designer** in Options: Personalize. Default is empty.
* **DefaultNamingLicenseAgreementIncluded** – Used with **Default Settings for New Fonts: License Agreement** in Options: Personalize.
* **DefaultNamingLicenseAgreementLinkIncluded** – Used with **Default Settings for New Fonts: License URL** in Options: Personalize.
* **DefaultNamingLicenseAgreementLinkText** – Used with **Default Settings for New Fonts: License URL** in Options: Personalize. Default value leads to a non-existing domain.
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
* **LastUpdateReminderDate** (**LastUpdateCheck** in the Updates key in HKCU in newer versions) – Includes the date used by the last update check when **Startup: Show update reminder** in Options: General is enabled.
* **LeftSideBearingExcludeLargeFonts** – Used with **When Saving Font Files: Set left side bearing point at x=0: Exclude large (1500+) fonts** in Options: Font. Default is on.
* **LongAlignedLocalOffsets** – Used with **When Saving Font Files: Long-aligned local offsets** in Options: Font. Default is on.
* **OnStartupOpenFonts** (version 5.6 & above) – Used with **Startup: On start open fonts from last time** in Options: General. Default is on.
* **OnStartupShowUpdateReminder** – Set this value in the **Startup: Show update reminder** in Options: General to 0 (Never), 1 (Once a year), 2 (Twice a year) or 3 (Once a month). Default is 1 (Once a year). See also `UpdateCheckInterval` in the GUI key in recent versions.
* **OnStartupShowWelcome** – Used with **Startup: On start show Welcome dialog** in Options: General. Default is on.
* **PanoseValueHexadecimal** – Used with **PANOSE: Value: Show hexadecimal** in Font Properties: Characteristics. Default is off.
* **RecalcAverageCharWidth** – Used with **When Saving Font Files: Recalc average char width** in Options: Font. Default is on.
* **RecalcGlyphBoundingBoxes** – Used with **When Saving Font Files: Recalc glyph bounding boxes** in Options: Font. Default is off.
* **RemoveDSIGTable** – Used with **When Opening Font Files: Remove DSIG table** in Options: Font. Default is off.
* **RemoveHdmxTable** – Used with **When Opening Font Files: Remove hdmx table** in Options: Font. Default is on.
* **RemoveLTSHTable** – Used with **When Opening Font Files: Remove LTSH table** in Options: Font. Default is on.
* **RemoveVDMXTable** – Used with **When Opening Font Files: Remove VDMX table** in Options: Font. Default is on.
* **SetLeftSideBearingPointAtX0** (version 4.5 & above) – Used with **When Saving Font Files: Set left side bearing point at x=0** in Options: Font. Default is on.
* **UnicodeEnabledGUI** (version 5.5 until 6.5) – Used with **Unicode Support: Enable Unicode support for text display and user input** in Options: General. Default is on. If the program is ran under Windows 9x/ME or compatibility mode, the option will appear dimmed.
* **UpdateModifiedDateTimeField** – Used with **Identification: Automatically update modified timestamp when exporting font** in Font Properties: Identification. Default is on.
* **ValueHexadecimal** – Used with **Values: Hexadecimal** in the View: Display Format menu. Default is on. Hexadecimal values in Delphi are usually given with a dollar sign ($).
* **VectorImageEPSForceRepositioning** – Used with **Vector Based Images (EPS, AI, PDF, SVG): Move imported outlines to origin (0,0)** in Options: Import.
* **VectorImageEPSOriginX** – Used with **Vector Based Images (EPS, AI, PDF, SVG): Origin X** in Options: Import.
* **VectorImageEPSOriginY** – Used with **Vector Based Images (EPS, AI, PDF, SVG): Origin Y** in Options: Import.
* **VectorImageEPSPixelsPerEm** – Used with **Vector Based Images (EPS, AI, PDF, SVG): Pixels per em** in Options: Import.

### Preview
* **FeaturesWidth** – Contains the width used for OpenType features.
* **FeatureTags** – Contains the tags used for OpenType features.
* **PreviewFeatures** – Select the features used in the preview text.
* **PreviewFontSize** – Select the size in the Test Font window. Default is 24.
* **PreviewSampleFontSize** – Select the size in the Preview window.
* **PreviewSampleText** – Used with the dropdown box in the Preview window. Default is **High-Logic ©** (old versions) or **&lt;enter preview text here&gt;**.
* **PreviewSampleUseKerning** – Used for **Kerning** in the Preview window.
* **ShowToolbarWindowPreview** – Show or hide the Preview window. Default is on.
* **StrikeThrough** – Set to on if you want to strikeout text in the Test Font window. Default is off.
* **Underline** – Set to on if you want to underline text in the Test Font window. Default is off.

### Reg
The program is started in unregistered mode either after the installation process is finished or if all keys are blank.
* **V5D#** – Created after registration whereas # is a numerical string. It displays a message and removes the **Buy** menu and the **Register** item on the Help menu. Version 6.0 and newer places your name on the title bar.

### Themes
* **ActiveTheme** – Contains the active theme.

### Tip of the Day (version 3.0 until 6.5)
* **CurrentTip** – Current line number in `FontCreator.tip`, used when opening the **Tip of the Day** window.
* **ShowTipOnStartup** – Used when selecting **Show this screen next time when you start FontCreator** in the **Tip of the Day** window.

### Validation
* **DiagonalRedundantOffCurvePointsDetection** – Used with **Diagonal redundant points detection: Max. off-curve dist.** in Settings: Validation.
* **DiagonalRedundantOnCurvePointsDetection** – Used with **Diagonal redundant points detection: Max. on-curve dist.** in Settings: Validation.
* **EnableGlyphProblemDetection** – Used with **Enable Real-Time** in the Validation toolbar.
* **LocalExtremeCoordinatesDetection** – Used with **Off-curve extreme coordinates: Local detection** in Settings: Validation.
* **MaximumRedundantOffCurvePointsDistance** – Used with **Diagonal redundant points detection: Max. off-curve dist.** spinner in Settings: Validation.
* **MaximumRedundantOnCurvePointsDistance** – Used with **Diagonal redundant points detection: Max. on-curve dist.** spinner in Settings: Validation.
* **ShowIntersection** – Used with **Show Intersecting** in the Validation toolbar. If enabled, intersecting contours are shown for each glyph. If disabled, no intersecting contours are shown for each glyph. If the glyph is too complex, the button will appear dimmed.
* **ShowWarningPoints** – Used with **Show Warning Points** in the Validation toolbar. If enabled, warning points are shown for each glyph. If disabled, no warning points are shown for each glyph. If the glyph is too complex, the button will appear dimmed.
* **TestContoursWithIncorrectDirection** – Used with **Validation Tests: Contours with incorrect direction** in the Font Validation Wizard and **Correct Contour Directions** in the Validation toolbar.
* **TestContoursWithOneOrTwoPoints** – Used with **Validation Tests: Contours with one or two points** in the Font Validation Wizard and **Remove Components** in the Validation toolbar.
* **TestDuplicateComponents** – Used with **Validation Tests: Duplicate components** in the Font Validation Wizard and **Remove Components** in the Validation toolbar.
* **TestDuplicateContours** – Used with **Validation Tests: Duplicate contours** in the Font Validation Wizard and **Remove Duplicate Contours** in the Validation toolbar.
* **TestDuplicateKnots** – Used with **Validation Tests: Duplicate knots** in the Font Validation Wizard and **Remove Duplicate Knots** in the Validation toolbar.
* **TestEmptyComponents** – Used with **Validation Tests: Empty components** in the Font Validation Wizard and **Remove Components** in the Validation toolbar.
* **TestFixDetectedProblems** – Used with **Fix detected problems** in the Font Validation Wizard.
* **TestIntersectingComponents** – Used with **Validation Tests: Intersecting components** in the Font Validation Wizard.
* **TestIntersectingCoordinates** – Used with **Validation Tests: Intersecting coordinates** in the Font Validation Wizard.
* **TestOffCurveExtremeCoordinates** – Used with **Validation Tests: Off-curve extreme coordinates** in the Font Validation Wizard and **Add Off-Curve Extremes** in the Validation toolbar.
* **TestOverlappingComponents** – Used with Validation Tests: Overlapping components** in the Font Validation Wizard.
* **TestRedundantPoints** – Used with **Validation Tests: Redundant points** in the Font Validation Wizard and **Remove Redundant Points** in the Validation toolbar.
* **TestSuspiciousPoints** – Used with **Validation Tests: Suspicious points** in the Font Validation Wizard.
* **ValidationMaxNumberOfCompositeGlyphMembers** – Used with **Real-time glyph validation: Disable when number of members exceeds** in Settings: Validation.
* **ValidationMaxNumberOfContours** – Used with **Real-time glyph validation: Disable when number of contours exceeds** in Settings: Validation.
* **ValidationMaxNumberOfPoints** – Used with **Real-time glyph validation: Disable when number of points exceeds** in Settings: Validation.

### Warn (used in Options: Advanced – default is on for all options)
* **WarnBeforeActivatingFixFeature** – Used with **Warn before activating the fix feature in the Font Validation Wizard**.
* **WarnBeforeActivatingRemoveFeature** – Used with **Warn before activating a remove feature from the Options → Font page**.
* **WarnBeforeAddCharacters** – Used with **Warn before adding characters**.
* **WarnBeforeAnchorDelete** – Used with **Warn when deleting anchor**.
* **WarnBeforeCloseOpenTypeDesigner** – Used with **Warn about losing changes when cancelling or closing OpenType Designer dialog**.
* **WarnBeforeExecutingGlyphTransformProgram** – Used with **Warn before executing Glyph Transformer script**.
* **WarnBeforeSortingGlyphs** – Used with **Warn before sorting glyphs**.
* **WarnImportSmallImage** – Used with **Warn when importing small image**.
* **WarnWhenOpening10OrMoreFonts** – Used with **Warn when opening 10 or more fonts**.
* **WarnWhenProcessingVOLTTable** (version 9.0 & above) – Used with **Warn when opening a font file which contains a VOLT table**.

## Cursors in the executable file (Delphi resources omitted)
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
* **HLROTATE** – Used by **Rotate**.
* **HLSEGMENT** – Used by colored fonts.
* **HLSELECT** – Used when selecting anything.
* **HLSELECTCONTOUR** – Used when selecting contours.
* **HLSELECTPOINT** – Used when selecting points.
* **HLZOOMIN** – Used when zooming in.
* **HLZOOMOUT** – Used when zooming out.
* **RV_JUMP_CURSOR** – Hand cursor.
* **VEASYHEADERSPLIT** – Used when changing size of split resources.
* **VT_HEADERSPLIT** – Used when changing size of split resources.
* **VT_MOVEALL** – Used when scrolling.
* **VT_MOVEE** – Used when scrolling.
* **VT_MOVEEW** – Used when scrolling.
* **VT_MOVEN** – Used when scrolling.
* **VT_MOVENE** – Used when scrolling.
* **VT_MOVENS** – Used when scrolling.
* **VT_MOVENW** – Used when scrolling.
* **VT_MOVES** – Used when scrolling.
* **VT_MOVESE** – Used when scrolling.
* **VT_MOVESW** – Used when scrolling.
* **VT_MOVEW** – Used when scrolling.
* **VT_VERTSPLIT** – Used when changing size of split resources.

## Bitmaps in the executable file (Delphi resources omitted)
* **DEFAULTCOLLAPSED** – Used for pulldown menus.
* **DEFAULTEXPANDED** – Used for pulldown menus.
* **DIVIDERGLYPHS** – Arrows
* **SBDOWN** – Arrows
* **SBDOWNDIS** – Arrows
* **SBDOWNDN** – Arrows
* **SBLEFT** – Arrows
* **SBLEFTDIS** – Arrows
* **SFLEFTDN** – Arrows
* **SBRIGHT** – Arrows
* **SBRIGHTDIS** – Arrows
* **SBRIGHTDN** – Arrows
* **SBUP** – Arrows
* **SBUPDIS** – Arrows
* **SBUPDN** – Arrows
* **SORTARROWDOWN** – Arrows
* **SORTARROWUP** – Arrows
* **SPTBXGLYPHS** – Used by glyphs in the Glyph Overview.
* **SPTBXOPENTYPE** – Used for OpenType fonts
* **SPTBXTRUETYPE** – Used for TrueType fonts
* **SYNEDITINTERNALIMAGES** – Numbers in gray background
* **SYNEDITWORDWRAPPED** – Word wrap icon
* **TB2SYSMENUGLYPHS** – Used by the toolbars.
* **TB2SYSMENUIMAGES** and **TBXSYSMENUIMAGES** – Window commands
* **TBXGLYPHS** – Used by glyphs in the Glyph Overview.
* **TCOLORSELECTOR** – Used in the color selection dialog.
* **VT_MOVEALL** – Cursor used for scrolling.
* **VT_MOVEEW** – Cursor used for scrolling.
* **VT_MOVENS** – Cursor used for scrolling.
* **VT_UTILITIES** – Arrows
* **VT_XPBUTTONMINUS** – Used for pulldown menus.
* **VT_XPBUTTONPLUS** – Used for pulldown menus.

## RC Data in the executable file
* **DESCRIPTION** – This data is binary.
* **DVCLAL** – Shows two paragraphs saying the license is valid and is running C++ Builder Professional.
* **PACKAGEINFO** – Shows the Pascal log for compiling the program.
* **TABOUTDIALOG** and **TABSTRACTABOUTDIALOG** (**TABOUTFORM** and **THLCREGISTERABOUTBOXDLG** in old versions) – Displays copyright, version number, physical memory, registration info and third party libraries credits (**Help: About...**).
* **TABSTRACTWELCOMEDIALOG** (**TWELCOMEFORM** in old versions) – Used for newcomers as if **OnStartupShowWelcome** is enabled.
* **TADDCHARACTERSFORM** – Used when adding characters to the font. **Sorted** is checked by default according to **Go to Unicode Block**.
* **TADDCHARACTERTOGLYPHINDEXMAPPINGFORM** – Displays a dialog when you press **Select** in **TCHARACTERTOGLYPHINDEXMAPPINGFORM**. It allows you to select Unicode values for each glyph.
* **TADDCUSTOMNAMINGFORM** – Used by **Font Properties: Custom: Add...** to add custom naming fields for a specific language.
* **TADDFPCVLTSFORM** – Used when adding a label, tooltip or sample.
* **TADDFPSIZENAMEFORM** – Used when adding a subfamily name.
* **TADDFPSTYLISTICSETNAMEFORM** – Used when adding or writing stylistic set names or descriptions.
* **TADDGASPFORM** – Used when adding a gasp range to the font.
* **TADDLOCALLANGUAGEDATAFORM** – Used when adding naming field data of multiple languages to the font.
* **TADDPLATFORMFORM** (version 2.0 until 7.0) – Used when adding a platform to the font (**Add** button in `TPLATFORMMANAGERFORM`).
* **TADDUVSFORM** – Used when adding Unicode variation sequences to the font.
* **TADVANCEDEDITFORM** – Used when editing a naming field in the font.
* **TANCHORMANAGERFRAME** and **TANCHORMANAGERFRM** (version 7.0 & above) – Used when managing anchors in the font.
* **TAUTOKERNEXFORM** (**TAUTOKERNINGFORM** in old versions) – Used when automatically adding kerning pairs to the legacy kerning tables.
* **TAUTOMETRICSFORM** – Used when automatically generating metrics for glyphs.
* **TAUTONAMEFORM** – Used when automatically changing the naming fields of a font.
* **TBASICEDITFORM** (**TADVANCEDNAMINGFORM** in version 3.0 until 6.5) – Used when including additional naming fields for a font. See `TFONTPROPERTIESFORM` in recent versions.
* **TCHANGETAGFORM** – Used when changing tags in a font.
* **TCHARACTERTOGLYPHINDEXMAPPINGFORM** (version 2.0 until 6.5) – Used when mapping a character to glyph index.
* **TCODEEDITORFORM** – Displays a dialog where you can edit the OpenType layout table code (**Code Editor** in OpenType Designer).
* **TCODEPAGERANGEFORM** – Displays a dialog where you can enable or disable which encoding to support in the font.
* **TCOLORFORM** (old versions) – It's not the standard Windows color selection dialog.
* **TCOMPOSITEGLYPHPROPERTIESFORM** – Used when modifying the properties of each composite glyph member.
* **TCONVERTBITMAPTOCONTOURSFORM** – Used when converting bitmaps to contours or importing raster images.
* **TDELETEFEATURELOOKUPFORM** (version 7.0 & above) – Used when deleting features or lookups in the font.
* **TDELETEKERNGROUPFORM** (version 7.0 & above) – Used when deleting kerning groups or classes in the form.
* **TDISABLEDFORM** – Used by reduced functionality mode or when pressing **Use Evaluation Version** in the splash screen (version 5.0 until 6.5 or 8.0 & above) after a grace period of 30 days.
* **TDM** – Contains icons used by the program.
* **TDMGLOBAL** – Contains codepages, vendors, hinting and bidirectional mirroring data used by the program.
* **TEDITANCHORFORM** (version 7.0 & above) - Used when editing anchors in the font.
* **TEXPORTGLYPHDATAFORM** – Used when exporting glyph data.
* **TEXPORTSETTINGSFORM** and **TEXPORTSETTINGSFRAME** – Used when exporting the font.
* **TEXTERNALSFORM** – Used when changing external tools.
* **TEXTRACTFROMTTCFORM** – Used by **Tools: Extract from OTC...** to extract OpenType font collections.
* **TFEATURESETTINGSFORM** (version 7.0 & above) – Used when generating or updating OpenType features.
* **TFINDFORM** – Used when searching parts of a font.
* **TFONTEMBEDDINGLICENSINGRIGHTSFORM** – Used when changing embedding and licensing rights in the font.
* **TFONTHEADERFLAGSFORM** – Used when changing header flags in the font.
* **TFONTINSTALLWIZARDFORM** – Used when installing the font for use with other applications.
* **TFONTLOGFORM** – Used when viewing the font log (**Developer Tools: Font Log**).
* **TFONTOVERVIEWFORM** – Shows the glyphs available in any opened font.
* **TFONTPROPERTIESFORM** – Used to modify or view the font properties (e.g. to disable the features of automatic generation of naming fields).
* **TFONTSETTINGSFORM** – Displays a dialog where you can change various settings for the font.
* **TFONTTABLESFORM** – Shows a list of tables in the font.
* **TFONTTESTFORM** – Used when testing desktop fonts (not web fonts). Default text in `mmFontTest` is the program name, uppercase, lowercase and numbers.
* **TFORMADDANCHOR** – Used when adding anchors in the font.
* **TFORMOPENTYPEDESIGNERSETTINGS** – Displays a dialog where you can configure settings for the OpenType Designer.
* **TFORMULAFORM** – Formula for Constructing Composite Glyph (anchor based).
* **TFRAMECATEGORY** – Used by the font overview to display categories.
* **TFRAMEGLYPHMEMBER** – Used by the font overview to display glyph members.
* **TFRAMEPALETTE** – Used by multicolored fonts to show a palette.
* **TGASPFORM** – Used when managing gasps in the font.
* **TGENERATECONTOURSCANCELFORM** – Used when generating contours.
* **TGENERATEPROBLEMREPORTFORM** – Used when pressing **Next** in the Glyph Validation Wizard (the window is titled **Report**).
* **TGLYPHALREADYMAPPEDFORM** – For each platform a character to glyph index mapping can only exist once, so if you try to add a mapping that already exists this window will ask you what to do.
* **TGLYPHEDITFORM** – Used when opening any glyph from the overview.
* **TGLYPHNAMEFORM** – Used when changing glyph names.
* **TGLYPHPROPERTIESFORM** (version 2.0 until 6.5) and **TGLYPHPROPERTIESFRAME** – Used where you can change various properties for the selected glyph.
* **TGRIDFORM** – Used when changing grid settings.
* **TGUIDELINEMODIFYFORM** – Used when modifying guidelines.
* **TGUIDELINESFORM** – Used when changing guideline settings.
* **TIMPORTGLYPHDATAFORM** – Used when importing glyph data.
* **TINSERTGLYPHFORM** – Used when inserting glyphs.
* **TINSTALLEDFONTSFORM** – Displays a dialog with all installed fonts in the computer to either view or open them. Version 10.1.0.2272 (2016-12-20) is the last version to have a waiting delay.
* **TKERNFEATUREFRAME** – Used by the kerning window.
* **TKERNGROUPMANAGERFORM** – Used when managing kerning groups or classes in the font.
* **TKERNINGFORM** (version 3.0 until 6.5) – Displays a dialog where you can view or edit the legacy kerning tables (not the GPOS kerning tables) in the font. See `TOPENTYPEDESIGNERFORM` in recent versions.
* **TKERNINGNEWPAIRFORM** (version 3.0 until 6.5) – Used when adding a kerning pair to the legacy kerning tables (not the GPOS kerning tables).
* **TKERNINGNEWSINGLEFORM** – Used when adding a single adjustment to the font.
* **TMAINFORMFONTCREATOR** (**TMAINFORMFCP3** in version 3.0) – Main window for FontCreator, toolbars and more. The menu in the main window has two hidden menus (Hidden Shortcuts and Developer Tools) which can be shown by removing `Visible = False`.
* **TMETRICSFORM** – Used when configuring metrics options.
* **TNAMINGFORM** (version 3.0 until 6.5) – Displays a dialog where you can manually change the naming fields of a font. See `TFONTPROPERTIESFORM` in recent versions.
* **TNEWTRUETYPEFONTFORM** – Used when creating a new font.
* **TOPENTYPEDESIGNERFORM** (version 7.0 & above) – Displays a dialog where you can create or edit the OpenType layout tables.
* **TOPENTYPEITEMADDFRM** (version 7.0 & above) – Used when adding an item to the OpenType layout tables.
* **TOPTIONSFORM** – Displays a dialog where you can set a plethora of FontCreator options in the above registry key headings.
* **TOTLFRENAMEFORM** (version 7.0 & above) – Used when renaming layout features in the OpenType layout tables.
* **TPASTESPECIALFORM** – Used when pasting data for glyphs in the clipboard. In the Items list (version 5.5 until 6.5), **Glyph Outline Data** and **Glyph Metrics** (i.e. the first two items) are checked by default. In recent versions, the registry keys are stored in the `Edit` key.
* **TPCLTFORM** (version 3.0 until 7.0) – Displays a dialog where you can add, view or edit the PCL5 data for use with old printers.
* **TPERFORMTRANSFORMATIONFORM** (version 5.6 & above) – Displays the Glyph Transformer.
* **TPLATFORMMANAGERFORM** (version 2.0 until 7.0) – Displays a dialog where you can choose which platform to support in the font.
* **TPOSTSCRIPTNAMESFORM** (version 2.0 until 7.0) – Displays a dialog where you can view or edit the PostScript glyph names in the font.
* **TPRINTABORTFORM** – Used after the font printing process is started.
* **TPRINTFONTFORM** – Used when printing anything in the font.
* **TPRINTGLYPHFORM** – Used when printing a glyph.
* **TPROGRESSDIALOG** (**TPROGRESSFORM** in old versions) – Progress window. The cursor for this form is **Busy**.
* **TREGISTERFORMEX** and **TREGISTERFORMFC** (**TREGISTERFORM** in old versions) – For unregistered copies of FontCreator, displays a dialog where you can enter the registration code (**Help** or **Buy: Register...**). This removes the splash screen on startup and the **Buy** menu.
* **TRESOURCEEDITORDLG** – In old versions only, used when editing resources.
* **TRESOURCEMODULE** – Used for resource module.
* **TRICHVIEWDIALOG** – Used for the rich text module.
* **TRULEMANAGER** (version 7.0 & above) – Used when managing rules in the OpenType layout tables.
* **TSAMPLETEXTFORM** – Used when managing sample texts in the test font window.
* **TSELECTCOMPOSITEGLYPHMEMBERFORM** – Used when adding glyph members to a composite glyph.
* **TSELECTLOOKUPTABLEFORM** – Used when seelcting a lookup table in the OpenType layout tables.
* **TSHAREWAREFORM** – For old versions and unregistered copies of FontCreator, displays this notice when pressing **Start** on the splash screen after a grace period of 30 days.
* **TSORTGLYPHSFORM** – Used when changing the glyph order within a font.
* **TSPLASHFORM** – For unregistered copies of FontCreator. The three buttons at the bottom are displayed in random order.
* **TSPTBXCOLORPICKERFORM** – Used by multicolored fonts to select colors.
* **TSUBLOOKUPMGR** (version 7.0 & above) – Used when managing subtables in the OpenType layout tables.
* **TTEXTREPLACEDIALOG** – Used by the OpenType Designer to replace text.
* **TTEXTSEARCHDIALOG** – Used by the OpenType Designer to search text.
* **TTIPOFTHEDAYFORM** (version 1.0 until 6.0) – Used for newcomers and **Help: Tip of the Day** (`FontCreator.tip` is used to display tips). On unregistered copies is a button labeled **Register** (removing it will display the access violation). See **FontCreator: Tips and Tricks** in the High-Logic font forum for more details.
* **TTRANSFORMFORM** – For simple glyphs only.
* **TTRIMFORM** – Used when trimming glyphs.
* **TUNICODERANGEFORM** – Used when specifying the Unicode blocks or ranges encompassed by the font file in the mappings for double-byte platforms.
* **TUPDATEFORM** and **TUPDATEFORMFC** (**TUPDATEREMINDERFORM** in old versions) – Used when the program checks for updates as if `OnStartupShowUpdateReminder` is enabled.
* **TUSEDBYFORM** – Displays an overview of all glyphs that use the selected glyph.
* **TUVSFORM** – Used when managing Unicode variation sequences in the font.
* **TVALIDATIONWIZARDFORM** – Displays a dialog where you can validate the font for errors.
* **TWIDEMESSAGEFORM** – Used for messages.
* **TWIDEWARNINGFORM** (**TWARNINGFORM** in old versions) – Used for warnings.
