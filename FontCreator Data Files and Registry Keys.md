## Notes
* The cursor remains "Busy" when saving fonts and doing other stuff in the background.
* All versions can save all unaltered opened fonts from the menu (**File: Save All**). In double-byte versions of Windows, the system displays a critical error saying "List index out of bounds (0)" if done repeatedly.
* Exiting the program may create invalid font(s) and play the Critical Stop sound from the PC speakers.
* The program displays the "Access violation" when closing after doing some operations – the font(s) may be invalid.
* Any glyph stored in the clipboard in version 1.0 until 6.0 will have either the words **Glyph Contours** for contours or **Glyph Data** for the entire glyph.
* Any glyph stored in the clipboard in version 7.0 will have **Font Data**.
* The **Delete** item in the **Edit** menu is not dimmed on startup or when closing other dialogs.
* **Complete Composites** (when generated from `CompositeData.xml` but not auto or anchor based) slows down the first time using in simple and composite glyphs.
* **Complete Composites** is dimmed when editing empty glyphs in version 5.0 until 6.5.
* The program displays a critical error when using **Complete Composites** in some glyphs in the Private Use Area. After that, these glyphs cannot be recovered. [Bhikkhu Pesala](http://www.softerviews.org/Fonts.html), UK, the guy behind the sample glyphs and his fonts created by the same program, has assigned code points in the Private Use Area for different glyphs in his fonts, notably low profile diacritics and small capitals. Rebecca G. Bettencourt / [Kreative Korp](http://www.kreativekorp.com/), the girl behind Bits'n'Picas and her fonts created by the same program, has assigned code points in the Private Use Area for different glyphs in her fonts, notably extended block elements.
* Version 1.0 (1998-04-11) until 7.0 (2013-04-25) only adds glyphs with Unicode BMP mapping to the preview toolbar.
* Version 5.0 (2005-01-12) until 10.1.02272 (2016-12-20) uses Windows XP style icons whereas version 11.0.0.2365 (2017-05-10) & above uses a different icon set.
* In order to edit FontCreator 5.6 resources, you would have to use [Resource Tuner](http://www.heaventools.com/resource-tuner.htm) (tested with version 2.20) or [UPX](https://upx.github.io/) (tested with version 2.01 released in 2006 and distributed with FreeDOS) to unpack the executable file which isn't possible as UPX says it's not packed.
* In new fonts, the Euro (€) doesn't have a Macintosh Roman mapping but the international currency sign (¤) does have it.
* The euro (€) and international currency sign (¤) use the same mapping in the Macintosh Roman glyph mapping list.
* Version 1.0 until 5.6 uses ISO 8859-1 as the output encoding. East Asian users (e.g. Korean) will appreciate in `previewtext.dat` substitutes accented letters by ASCII counterparts, e.g. é by e and if kerning pairs are exported, instead of having &lt;&lt; for « you have to use \\00AB as escape code.

## Unregistered version limitations
As FontCreator is released as pay shareware, the unregistered version works for 30 days with the following limitations based on the version number.
* 3.0β1 (2000-07-30) until 3.1.3 (2002-12-09) - After a grace period of 30 days, a nag screen is shown when pressing **Start**. However, the program otherwise functions normally.
* 4.0 (2003-05-16) until 4.5 (2004-08-17) - After a grace period of 30 days, the program cannot be used at all until the registration process is started.
* 5.0 (2005-01-12) until 5.6 (2007-07-19) - After a grace period of 30 days and opening the program 5 times, the program will enter a reduced functionality mode, where e.g. fonts cannot be saved or tested.
* 6.0 (2009-06-17) and 8.0 (2014-06-05) until 12.0.0.2539 (2019-06-04) - The program will enter a reduced functionality mode, where e.g. tested fonts won't be automatically hinted.
* 7.0 (2013-04-25) - The program will create subsetted versions when saving, testing, exporting or installing fonts.
* 12.0.0.2543 (2019-07-10) - The program will add watermarks when generating fonts.

Under the Help menu is an item labeled **Register**. When executed, a screen will pop up giving the registration code.

## Windows version compatibility
* Windows Vista and later – 12.0.0.2543
* Windows XP – 10.0
* Windows 2000 – 7.0
* Windows NT 4.0 – (unknown version)
* Windows 95, 98 and ME – 6.0.1

## User Data (Glyph Transformer scripts and Unicode data files omitted)
FontCreator uses several data files for advanced settings and customizations. Normally most files are owned by administrators where they cannot be changed. If you want to edit most files directly they either must run Notepad with administrative privileges or change the owner to users (this can be done by using `takeown` or changing the owner with the advanced dialog of security tab in file properties).

* **bookmarks.txt** (version 5.0 until 6.5) – Created automatically after exit. Includes bookmarks used in the glyph overview.
* **CompositeData.xml** – Located in the `Composite` folder as used by **Complete Composites**.
* **CurrentTransformProgram.xml** – Created when opening Transform Programs in `TPERFORMTRANSFORMATIONFORM`. The window will appear empty if removed.
* **FC#####.ttf** – Temporary font used by `TFONTTESTFORM` (##### is five numbers). The font name in version 3.0 until 6.5 is FC Test Font ###### (###### is six numbers).
* **fc12.cfg** – Configuration file used by FontCreator.
* **fcp5.cfg** – Configuration file used by FontCreator 5.0 and 5.6 in the system root directory.
* **fcppreview.txt** (version 3.0 until 4.5) – Text used in `TFONTTESTFORM`. The text is restored to factory defaults if removed.
* **fnt[XX/XXX].tmp** – Temporary font used for saving (XX or XXX are letter and number combos).
* **FontCreatorSetup.exe** – Install the program for use with x86 platform (32 bit).
* **FontCreatorSetup-x64.exe** – Install the program for use with x64 platform (64 bit).
* **FontCreator.tip** – Contains the tips in `TTIPOFTHEDAYFORM`. If removed, this window appears blank.
* **glyphlist.dat** – Contains the Adobe glyph list. Old versions have the same list but duplicates **xi** to U+0000.
* **glyphnamesnew.dat** (version 7.0 & above) – Contains the default glyph names when opening existing fonts and when generating glyph names on the Glyph Properties dialog. Prior to FontCreator 12 another file (`glyphnames.dat`) was used, but that one is now obsolete.
* **guidelines.dat** – Created automatically after exit. Includes guidelines used in the Glyph Edit window and Guideline Options.
* **kern_filename.txt** – For old versions of FontCreator, stores the legacy kerning pair data for each font whereas `filename` is the font name.
* **previewtext.dat** (version 5.0 & above) – Controls the text used in `TFONTTESTFORM`. The text is restored to factory defaults if removed.
* **preview.txt** (version 6.5 & above) – Contains the standard preview texts for the Preview toolbar. The dropdown list is shown as blank if removed.
* **SubFamily.dat** or **SubFamily2.dat** – Includes naming fields for multiple languages.
* **TableOffsetOrderCFF.txt** and **TableOffsetOrder.txt** (.dat in old versions) – Contains the supported tables in any font. All tables are moved to Unsupported if removed, making the font unable to work or install.

In **Options: Advanced: Data Files** are two buttons labeled **Copy Data Files to User Data Folder** and **Open User Data Folder** when pressed the program will either copy most files to the user data folder or open it.

## Default font export settings
* **WOFF Version** – Default is **version 1 and 2**.
* **Outline Format** – Default is **TrueType**.
* **Components** – Default is **Decompose scaled (recommended)**.
* **Glyph Names** – Default is **Regenerate for release**.
* **Color** – Default is No.
* **Hinting** – Default is **Auto hinting** for or **Keep original**.
* **Output Folder** – Default is the **Fonts** folder from the user's documents folder.
* **Existing Files** – Default is **Rename existing files**.

## Index of registry keys
Before FontCreator 15, the registry keys are located in `HKCU\Software\High-Logic\FontCreator\version` or `HKCU\Software\High-Logic\Font Creator Program\version` where `version` is the version number (the settings are stored as `settings.json` since FontCreator 15). Holding down **Ctrl** in version 7.0 & above during startup will restore the program to factory settings.

### AddCharacters (used in `TADDCHARACTERSFORM`)
* **SelectedCharacter** – Select the character in this form. Default is 0 (null).
* **SelectedFont** – Select the font in this form. Default is **Arial Unicode MS**.

### Background
* **BackgroundInitColor**
* **BackgroundInitScale**

### Columns
* **Open Installed Fonts** – This is a binary value.

### Externals
There are three built-in external programs: Fonts Folder, Character Map and MainType (if installed).
* **Location#** – The name can be up to digit three. Default is empty.
* **Title#** – The name can be up to digit three. Default is **External #** whereas # is a number.

### Find
* **FindLanguageID** – This corresponds to any language.
* **PlatformID** – See **Platform** in the Find dialog's Mapping tab.
* **PlatformSpecificEncodingID** – See **Platform** in the Find dialog's Mapping tab.
* **TabIndex** – This corresponds to any tab in the Find dialog.

### FontOverview (used in `TFONTOVERVIEWFORM`)
* **CategoryWidth** – Select the width used for categories in the font overview.

### Fonts
* **ExportDecomposeScaled** – Used with **Export Font: Decompose composite glyphs with scaled components** checkbox in Options: Font. Default is on.
* **ExportExcludeLegacy** – Used with **Export Font: Exclude legacy data** checkbox in Options: Font. Default is on.
* **FontEnableOpenContours** – Used with **Special Features: Enable open contours** checkbox in Options: Font. Default is on.
* **OpenFriendlyGlyphNames** – Used with **Open Font: Generate friendly glyph names** checkbox in Options: Font. Default is on.

### FreeDraw
* **BrushWidth** – Used with **Brush width** option in the Free Draw window.

### Glyph Edit Window
* **FilledOutline** – Used with **Fill Outline** in the Grid toolbar.
* **ShowConnectionBetweenPoints** – Used with **Show Connection** in the Grid toolbar. Default is on.
* **ShowFirstAndLastPointIndicators** – Used with **Show First and Last** in the Grid toolbar. Default is on.
* **ShowToolbarWindowBackground** – Enables or disables the Background Image toolbar. Default is off.
* **ShowToolbarWindowKerning** – Enables or disables the kerning window. Default is off.
* **ShowToolbarWindowPalette** – Used with **Palette** in the toolbar right click context menu.
* **ShowToolbarWindowTransformation** – Used with **Transformation** in the toolbar right click context menu.
* **ShowToolbarWindowValidation** – Used with **Show Report** in the Glyph toolbar. Default is off.

### Grid
* **FixedGridColor** – Select the fixed grid color in Grid Options. Default is white.
* **FixedGridLineStyle** – Select the fixed grid line style in Grid Options. Default is solid.
* **GridColor** – Select the grid color in Grid Options. Default is sky blue.
* **GridDistance** – Used with **Minimum distance between grid points in units** in Grid Options.
* **GridDistancePixels** – Used with **Mininum distance between grid points in pixels** in Grid Options.
* **GridLineStyle** – Used with **Line style** in Grid Options. Default is solid.
* **IncludeBaseline** – Used with **Baseline** in the Metrics Options window.
* **IncludeLeftSideBearing** – Used with **Left side bearing** in the Metrics Options window. Default is on.
* **IncludeRightSideBearing** – Used with **Right side bearing** in the Metrics Options window. Default is on.
* **IncludeTypoAscender** – Used with **TypoAscender** in the Metrics Options window.
* **IncludeTypoDescender** – Used with **TypoDescender** in the Metrics Options window.
* **IncludeWinAscent** – Used with **Win Ascent** in the Metrics Options window.
* **IncludeWinDescent** – Used with **Win Descent** in the Metrics Options window.
* **IncludexHeight** – Used with **x-Height** in the Metrics Options window.
* **IncludeYAxis** – Used with **Y-Axis** in the Metrics Options window.
* **LockUserDefinedGuidelines** (version 4.5 & above) – Used when pressing **Lock Guidelines** in the Grid toolbar.
* **ShowBearings** (version 5.6 & above) – Used when pressing **Show Metrics** in the Grid toolbar.
* **ShowFixedGridLines** (version 5.6 & above) – Used with **Show reference lines at x = 0, y = 0** option in Grid Options.
* **ShowGrid** – Used when pressing **Show Grid** in Grid Options or in the Grid toolbar.
* **ShowUserDefinedGuidelines** – Used when pressing **Show Guidelines** in Guidelines Options or in the Grid toolbar. If Microsoft Narrator is running, the checkbox in the Guidelines Options window will read the ampersand.
* **SnapToGrid** (version 4.5 & above) – Used when pressing **Snap to Grid** in the Grid toolbar.
* **SnapToUserDefinedGuidelines** (version 4.0 & above) – Used when pressing **Snap to Guidelines** in the Grid toolbar.

### GUI
* **UpdateCheckInterval** – Used when **OnStartupShowUpdateReminder** is enabled.

### GuideLines (version 3.0 until 6.5, used in `TGUIDELINESFORM`)
* **Color** – Select the guideline color. Default is black.
* **LineStyle** – Select the guideline line style. Default is solid.

### ImportImage
* **BitmapPositionOrigin** – Used with radio buttons in the Glyph: Position option. (Available in Import Image)
* **BitmapPositionType** – Set the Bitmap Position Type.
* **Erode** – Used with **Erode – Dilate** option in the Image tab. Default is No filter. (Available in Import Image)
* **GlyphPositionX** – Used with **Position: X position** option in the Glyph tab. (Available in Import Image)
* **GlyphPositionY** – Used with **Position: Y position** option in the Glyph tab. (Available in Import Image)
* **ImportMode** – Used with **Import Mode** option in the Glyph tab. Default is Trace. (Available in Import Image)
* **InvertBitmap** – Used with **Negative** option in the Image tab. Default is off. (Available in Import Image)
* **MinimumPointsInContour** – Set the number of Minimum Points in the contour.
* **Multiplier** – Used with **Size: Multiplier** option in the Image tab. (Available in Import Image)
* **SmoothFilter** – Used with **Smooth Filter** option in the Image tab. Default is Smooth. (Available in Import Image)
* **Threshold** – Used with **Threshold** option in the Image tab. Default is 150. (Available in Import Image)

### Install (used in `TFONTINSTALLWIZARDFORM`)
* **InstallFontsInFontsFolder** (version 3.0 until 6.5) – Used with **Install the font in Windows Fonts folder**. Default is on. If the program is ran under Windows Vista & above, the UAC shield is added before the label.

### InstalledFonts (used in `TINSTALLEDFONTSFORM`)
* **PreviewHeight** – Set the font preview text height (version 5.5 & above). Default is 124.

### Interface
* **LockToolbars** – Used with **Lock Docked Toolbars** option in the toolbar context menu or in View: Toolbars. Default is off.
* **ShowUserNotes** – Used with **Show User Notes** option in the toolbar context menu or in View: Toolbars. Default is off.

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
* **SampleFileName** – Used with **Samples Toolbar Font: Filename** in Options: General. Default is empty. The sample glyphs are derived from Garava (Designed by Bhikkhu Pesala in 2003) and Times New Roman (Designed by Stanley Morison for Monotype Imaging Inc.).
* **SampleSingleHeight** (version 3.0 until 6.5) – Used with **Samples Toolbar: Glyph height** in Options: Sample. Default is 55.
* **SampleSingleWidth** (version 3.0 until 6.5) – Used with **Samples Toolbar: Glyph width** in Options: Sample. Default is 62.
* **SaveDialogInitialDirNew2** – Select the directory in the save dialog.
* **SelectCompositeCaptionType** – Changes caption used in the select composite glyph member window. Default is 0 (glyph name).
* **SelectCompositeFontZoom** – Scale the glyphs in the select composite glyph member window.
* **SelectCompositeGridZoom** – Scale the grid in the select composite glyph member window.
* **SettingsPage** – Changes tab in the Options window. Default is 0 (Identification).

### Kerning
* **AutoKerningAllowForPositiveKerningValues** – Used with **Additional Options: Allow for positive kerning values** option in the AutoKern window.
* **AutoKerningExcludeLowerLower** – Used with **Exclude lowercase-lowercase pairs** option in the AutoKern window.
* **AutoKerningExcludeLowerUpper** – Used with **Exclude lowercase-uppercase pairs** option in the AutoKern window.
* **AutoKerningUseBaseMetrics** – Used with **Composite glyphs follow base glyphs (use this glyph's metrics)** option in the Kern Wizard in OpenType Designer. Default is on.
* **AutoKerningImportFilename** – Used with disabled text box with the filename string.
* **AutoKerningMinAbsKernValue** – This corresponds to numerical strings for the **Additional Options: Minimum absolute kerning value** option in the AutoKern window.
* **AutoKerningReplaceKerning** – Used with **Additional Options: Replace existing kerning when** dropdown box in the AutoKern window.
* **AutoKerningReplacePercentage** – Used with **Additional Options: Replace existing kerning when** slider in the AutoKern window.
* **AutoKerningWhiteSpace** – Used with **Additional Options: White space between characters** option in the AutoKern window.
* **KerningColorBackground** – Select the color used for the background. Default is white.
* **KerningColorBaseline** – Select the color used for the baseline. Default is red.
* **KerningColorFirst** – Select the color used for the left glyph. Default is dark blue.
* **KerningColorGridLines** – Select the color used for the Grid Lines. Default is gray.
* **KerningColorSecond** – Select the color used for the right glyph. Default is dark green.
* **KerningShowBaseLine** – Display baseline in Kerning window. Default is on.
* **KerningShowBearingLines** – Display bearing lines in Kerning window. Default is on.
* **KerningShowGridLines** – Display grid lines in Kerning window. Default is on.

### Last Time
* **File_#** – Include fonts used in the last time whereas # is a number. When `OnStartupOpenFonts` is enabled, nothing will be opened if removed.

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
* **AutoMetricsWhiteSpaceBefore** – Used with **Fixed Bearings: Space before**. Default is 100.

### MetricsAndKerning
* **MetricsAndKerningKerningEnabled** – Enable or disable **OpenType Layout Features** in the Comparison toolbar. Default is off.
* **MetricsAndKerningTextEnabled** – Used by **Show text before and after glyph** in the Comparison toolbar. Default is off.
* **MetricsAndKerningTextLeft** – Used by **Before** text box in the Comparison toolbar. Default is empty.
* **MetricsAndKerningTextRight** – Used by **After** text box in the Comparison toolbar. Default is empty.

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
* **CPSPPerc** – Contains the percentage of advance width used by **Spacing and Positioning: Capital Spacing (cpsp)** spinner. Default is 5%.
* **IncludeAalt** – Used with **Other Forms and Variants: Access All Alternates (aalt)**. It generates lookups for glyphs used by other OpenType features (e.g. Unicase - unic).
* **IncludeAltFractions** – Used with **Numerals: Alternative Fractions (e.g. stacked) (afrc)**. It generates lookups for pre-composed fractions in the *Latin-1 Supplement* and *Number Forms* blocks of Unicode and fractions not available in Unicode.
* **IncludeAnchorBased** – Used with **Spacing and Positioning: Anchor Based Positioning (ccmp, mark, mkmk)**. To generate this feature, each letter should have anchors. Examples of fonts including all three features are e.g. Arial (Windows Vista & above), [Roboto](https://github.com/googlefonts/roboto-3-classic) (missing anchors for e.g. capital open O, capital M hook, etc. etc. etc.) and more. The `mark` and `mkmk` features are used by e.g. many African languages (Yoruba, Lingala, Ewe, Wolof, Dagaare, Tammari, etc. etc. etc.) and Native American languages (Navajo, Kwakiutl, Choctaw, Dakota, Lakota, Heiltsuk, Kwakwala, Liqwala, etc. etc. etc.), phonetic transcription (IPA and UPA) and zalgo text.
* **IncludeCapitalSpacing** – Used with **Spacing and Positioning: Capital Spacing (cpsp)**. Fullwidth Latin characters are not included. Don't include this feature in monospaced or pixel fonts!
* **IncludeCase** – Used with **Other Forms and Variants: Case-Sensitive Forms (case)**. This feature moves the position of some punctuation marks, e.g. inverted exclamation point or question mark and brackets to the CapHeight position. Example font without the feature: System VIO from OS/2 (with the characters at the CapHeight position).
* **IncludeCharacterVariants** – Used with **Other Forms and Variants: Character Variants (cv01-cv99)**. [Bhikkhu Pesala](http://www.softerviews.org/Fonts.html) uses this feature in his fonts for ! * + @ © × † ‡ • ○ ● ☀.
* **IncludeCursive** – Used with **Spacing and Positioning: Cursive Positioning (curs)**. Use this feature only for connecting script fonts (e.g. Brush Script MT, Script MT Bold, Bickham Script Pro, Lucida Handwriting, etc. etc. etc.).
* **IncludeDlig** – Used with **Other Forms and Variants: Discretionary Ligatures (dlig)**.
* **IncludeFina** – Used with **Terminal Forms (fina, fin2, fin3)**. This feature uses terminal characters from the *Arabic* ranges of Unicode if the glyphs exist. The last two features are used only for Syriac. [Bhikkhu Pesala](http://www.softerviews.org/Fonts.html) uses the feature in his fonts to replace Greek sigma (σ) with the final sigma (ς) at the end of Greek words, not stigma (Ϛϛ).
* **IncludeFractions** – Used with **Numerals: Fractions (diagonal) (frac, dnom, numr)**. The `frac` feature uses precomposed vulgar fractions from the *Latin-1 Supplement* and *Number Forms* ranges of Unicode as well as unencoded vulgar fractions if the glyphs exist. The Garava font was used for the feature in the preview as shown in the manual.
* **IncludeFractionsAdv** – Used with **Numerals: Fractions (diagonal) (frac, dnom, numr): Extended (smart math format)**.
* **IncludeHlig** – Used with **Other Forms and Variants: Historical Ligatures and Historical Forms (hlig, hist)**. The `hist` feature uses the last character from the *Latin Extended-A* range of Unicode. The `hlig` feature uses ſt from the *Alphabetic Presentation Forms* range of Unicode and ligatures that are made up of glyphs beginning with ſ if the PostScript names in each glyph have `longs` followed by the underscore. [Bhikkhu Pesala](http://www.softerviews.org/Fonts.html) uses this feature in his fonts to substitute Roman numerals.
* **IncludeInit** – Used with **Initial Forms (init)**. This feature uses initial characters from the *Arabic* ranges of Unicode if the glyphs exist.
* **IncludeIsol** – Used with **Isolated Forms (isol)**. This feature uses isolated characters from the *Arabic* ranges of Unicode if the glyphs exist.
* **IncludeLiga** – Used with **Other Forms and Variants: Standard Ligatures (liga)**. This feature uses the first five Latin characters from the *Alphabetic Presentation Forms* range of Unicode. The Mandala font was used for the feature as shown in the Enrich Your Fonts With OpenType Features tutorial. Don't include this feature in monospaced fonts without programming ligatures (e.g. Helvetica Monospaced, Nimbus Sans Mono, Harmonia Sans Mono, Prima Sans Mono, SST Typewriter, etc. etc. etc.) or with programming ligatures (e.g. Cascadia Code, Fira Code, etc. etc. etc.)! Example font without this feature: Agency FB from Microsoft products (the ff, ffi and ffl ligatures are unmapped)
* **IncludeLnum** – Used with **Numerals: Lining Figures (lnum)**. Glyphs with `.lnum` at the end of PostScript names should be present to generate this feature.
* **IncludeLoclCommon** – Used with **Localized Forms (locl): Common Localized Forms (CAT, NLD, TRK, ROM)**. This feature is used for Catalan (`CAT`) to replace l· with the character from *Latin Extended-A*, Dutch and Flemish (`NLD` and `FLE`) to replace ij and íj́ with its own ligatures, Turkish (`TRK`) and other Turkic languages to replace i for case sensitivity and Romanian or Moldavian (`ROM` or `MOL`) to replace ş and ţ (cedilla) with ș and ț (comma). [Bhikkhu Pesala](http://www.softerviews.org/Fonts.html) originally used this feature in his fonts to substitute Roman numerals. He used the `hlig`/`hist` feature instead in his fonts.
* **IncludeLoclCustom** – Used with **Localized Forms (locl): Custom Localized Forms (loclLANG)**. This feature supports only languages with Arabic, Greek, Hebrew or Latin scripts. It may be used for some languages, e.g. to change the acute in áéíóú (őű) for Hungarian (`HUN`) or ćńóśź for Polish (`POL`), change letter designs in Bulgarian (`BGR`), Macedonian (`MKD`) or Serbian (`SRB`) or to use tighter thin space metrics in French (`FRA`). The Munson Roman font was used in the OpenType Designer using s acute for Polish localized forms, both uppercase and small caps as shown in the manual. [Bhikkhu Pesala](http://www.softerviews.org/Fonts.html) originally used this feature in his fonts to substitute Roman numerals.
* **IncludeMedi** – Used with **Medial Forms (medi, med2)**. This feature uses medial characters from the *Arabic* ranges of Unicode if the glyphs exist. The second feature is used only for Syriac if the glyphs exist.
* **IncludeNalt** – Used with **Other Forms and Variants: Alternate Annotation Forms (nalt)**. This feature uses either glyphs with a `.nalt` suffix or circled characters from the *Enclosed Alphanumerics* block and initial, isolated, medial or terminal characters from the *Arabic* ranges of Unicode if the glyphs exist. The Verajja font was used in the OpenType Designer using the number six as shown in the manual.
* **IncludeOnum** – Used with **Numerals: Oldstyle Figures (onum)**. Glyphs with `.onum` at the end of PostScript names should be present to generate this feature. The Mandala font was used for the feature as shown in the Enrich Your Fonts With OpenType Features tutorial.
* **IncludeOrdinals** – Used with **Other Forms and Variants: Ordinals (ordn)**. It creates a numero substitution (capital N and small o with or without full stop) if the glyph exists in the *Letterlike Symbols* block of Unicode and substitutions for letters and numbers.
* **IncludeOrdinalsExt** – Used with **Other Forms and Variants: Ordinals (ordn): Extended (use .ordn or .sups for all letters)**. If no glyphs that end with `.ordn` or `.sups` are found, it creates substitutions for a to ª and o to º if these glyphs exist.
* **IncludeOrnaments** – Used with **Other Forms and Variants: Ornaments (ornm)**. The first method uses the bullet. [Bhikkhu Pesala](http://www.softerviews.org/Fonts.html) uses this feature in his fonts to replace bb, bp, bq, wk and wr by chess pieces.
* **IncludePetiteCapitals** – Used with **Other Forms and Variants: Petite Capitals (pcap, c2pc)**. [Bhikkhu Pesala](http://www.softerviews.org/Fonts.html) uses a subset for this feature in his fonts, including only common punctuation and the Latin, Greek and Cyrillic alphabets with diacritics for Classical Sanskrit (not Vedic Sanskrit with additional diacritics like ā́ī́ḷ́l̃m̐ṝ́ū́).
* **IncludePnum** – Used with **Numerals: Proportional Figures (pnum)**. Glyphs with `.pnum` at the end of PostScript names should be present to generate this feature.
* **IncludeSalt** – Used with **Other Forms and Variants: Stylistic Alternates (uses ss01) (salt)**. [Bhikkhu Pesala](http://www.softerviews.org/Fonts.html) uses this feature as a contextual substitution to substitute only the first capital letter of a word in Cankama, Garava, Jivita, Lekhana, Mandala, Odana, Pali, Sukhumala, Talapanna, and Verajja for decorative drop capitals. Example font without the feature using unencoded glyphs: Agency FB from Microsoft products.
* **IncludeSinf** – Used with **Numerals: Scientific Inferiors (sinf)**.
* **IncludeSmallCapitals** – Used with **Other Forms and Variants: Small Capitals (scap, c2sc)**. [Bhikkhu Pesala](http://www.softerviews.org/Fonts.html) uses a subset for this feature in his fonts, including only the Latin, Greek and Cyrillic alphabets and punctuation with diacritics for Classical Sanskrit (not Vedic Sanskrit with additional diacritics like ā́ī́ḷ́l̃m̐ṝ́ū́). The [TITUS Cyberbit Basic font](http://titus.uni-frankfurt.de/unicode/unitest2.htm) includes only glyphs for the Latin alphabet, numbers and þḃḋḟġḣk̇l̇ṁṅṗṙṡṫḅḍg̣ḷṃṇṛṣṭ (without this feature). Most fonts use their own glyphs (e.g. Letter Gothic Std, Lithos Pro, Trajan Pro, etc. etc. etc. from Adobe products).
* **IncludeStylisticSets** – Used with **Other Forms and Variants: Stylistic Sets (ss01-ss20)**. [Bhikkhu Pesala](http://www.softerviews.org/Fonts.html) uses a contextual substitution for decorative drop capitals in Cankama, Garava, Jivita, Lekhana, Mandala, Odana, Pali, Sukhumala, Talapanna and Verajja (colored). The IBM Plex Sans font was used for the feature as shown in the Enrich Your Fonts With OpenType Features tutorial.
* **IncludeSubs** – Used with **Other Forms and Variants: Subscript (subs)**. The [TITUS Cyberbit Basic font](http://titus.uni-frankfurt.de/unicode/unitest2.htm) includes only numbers, some letters in the Latin alphabet, punctuation and äīùú (without the OpenType feature).
* **IncludeSups** – Used with **Other Forms and Variants: Superscript (sups)**. [Bhikkhu Pesala](http://www.softerviews.org/Fonts.html) uses a subset in his fonts as either (1) the Latin alphabet, numbers, common punctuation/mathematical symbols and spacing accents, with Latin-1 and Classical Sanskrit (not Vedic Sanskrit with additional diacritics like ā́ī́ḷ́l̃m̐ṝ́ū́) diacritics (Garava) or (2) the Latin alphabet, numbers, è and ú (other fonts). The [TITUS Cyberbit Basic font](http://titus.uni-frankfurt.de/unicode/unitest2.htm) includes only numbers, some Latin letters and punctuation and äi̯ıu̯ü (without the OpenType feature).
* **IncludeSwsh** – Used with **Other Forms and Variants: Swash (swsh)**. [Bhikkhu Pesala](http://www.softerviews.org/Fonts.html) colorized the glyphs in his fonts. Most fonts include glyphs only for capital letters in italics (e.g. Times New Roman from Windows 8 through 11 or Minion Pro from Adobe products).
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
* **AlwaysCreateBackupCopy** – Used with **Create backup copy (bck) on saving a font project** in the Advanced: Settings tab. Default is off.
* **AutoFitGlyphInWindow** – Used with **Glyph Edit Window: Auto fit glyph in Window** in Options: Glyph. Default is on.
* **AutoNamingUseFontRevision** – Used with **Automatic Naming Wizard: Version String: use Font revision version from Font Settings → Header page** in Options: Naming. Default is on.
* **CompressHmtxTable** – Used with **When Saving Font Files: Compress hmtx table** in the Font tab. Default is on. (Available in the Options window)
* **CompressNameTable** – Used with **When Saving Font Files: Optimize name table** in the Font tab. Default is on. (Available in the Options window)
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
* **DefaultPersVendorURLText** – Used with **Default Settings for New Fonts: Vendor URL** in Options: Personalize. No default value.
* **DefaultVendorIDIncluded** – Used with **Default Settings for New Fonts: Vendor ID** in Options: Personalize. Default is on.
* **DefaultVendorIncluded** – Used with **Default Settings for New Fonts: Vendor** in Options: Personalize. Default is off.
* **DefaultVendorURLIncluded** – Used with **Default Settings for New Fonts: Vendor URL** in Options: Personalize. Default is off.
* **DefaultZoomFactor** – Used with **Glyph Edit Window: Open with default zoom factor** in Options: View.
* **ExcludeMonospacedFonts** – Used with **When Saving Font Files: Exclude monospaced fonts** in Options: Font. Default is off.
* **IgnoreHintingData** – Used with **When Opening Font Files: Remove hinting data** in Options: Font. Default is off. Recent versions use [ttfautohint](https://freetype.org/ttfautohint/) for automatic hinting (enabled by default when exporting font projects).
* **IgnoreUnsupportedTables** – Used with **When Opening Font Files: Remove unsupported tables** in Options: Font. Default is off.
* **LastUpdateReminderDate** (`LastUpdateCheck` in `HKCU\Updates` in newer versions) – Includes the date used by the last update check when **Startup: Show update reminder** in Options: General is enabled.
* **LeftSideBearingExcludeLargeFonts** – Used with **When Saving Font Files: Set left side bearing point at x=0: Exclude large (1500+) fonts** in Options: Font. Default is on.
* **LongAlignedLocalOffsets** – Used with **When Saving Font Files: Long-aligned local offsets** in Options: Font. Default is on.
* **OnStartupOpenFonts** (version 5.6 & above) – Used with **Startup: On start open fonts from last time** in Options: General. Default is on.
* **OnStartupShowUpdateReminder** – Set this value in the **Startup: Show update reminder** in Options: General to 0 (Never), 1 (Once a year), 2 (Twice a year) or 3 (Once a month). Default is 1 (Once a year). See also `UpdateCheckInterval` in the GUI key in recent versions.
* **OnStartupShowWelcome** – Used with **Startup: On start show Welcome dialog** in Options: General. Default is on.
* **PanoseValueHexadecimal** – Used with **PANOSE: Value: Show hexadecimal** in Font Properties: Characteristics. Default is off.
* **RecalcAverageCharWidth** – Used with **When Saving Font Files: Recalc average char width** in Options: Font. Default is on.
* **RecalcGlyphBoundingBoxes** – Used with **When Saving Font Files: Recalc glyph bounding boxes** in Options: Font. Default is off.
* **RemoveDSIGTable** (version 3.0 until 6.5) – Used with **When Opening Font Files: Remove DSIG table** in Options: Font. Default is off.
* **RemoveHdmxTable** (version 3.0 until 6.5) – Used with **When Opening Font Files: Remove hdmx table** in Options: Font. Default is on.
* **RemoveLTSHTable** (version 3.0 until 6.5) – Used with **When Opening Font Files: Remove LTSH table** in Options: Font. Default is on.
* **RemoveVDMXTable** (version 3.0 until 6.5) – Used with **When Opening Font Files: Remove VDMX table** in Options: Font. Default is on.
* **SetLeftSideBearingPointAtX0** (version 4.5 & above) – Used with **When Saving Font Files: Set left side bearing point at x=0** in Options: Font. Default is on.
* **UnicodeEnabledGUI** (version 5.5 until 6.5) – Used with **Unicode Support: Enable Unicode support for text display and user input** in Options: General. Default is on. If the program is ran under Windows 9x/ME or compatibility mode, the option will appear dimmed.
* **UpdateModifiedDateTimeField** – Used with **Identification: Automatically update modified timestamp when exporting font** in Font Properties: Identification. Default is on.
* **ValueHexadecimal** – Used with **Values: Hexadecimal** in the View: Display Format menu. Default is on. Hexadecimal values in Delphi are usually given with a dollar sign ($).
* **VectorImageEPSForceRepositioning** – Used with **Vector Based Images (EPS, AI, PDF, SVG): Move imported outlines to origin (0,0)** in Options: Import. Default is off.
* **VectorImageEPSOriginX** – Used with **Vector Based Images (EPS, AI, PDF, SVG): Origin X** in Options: Import. Default is 100.00.
* **VectorImageEPSOriginY** – Used with **Vector Based Images (EPS, AI, PDF, SVG): Origin Y** in Options: Import. Default is 600.00.
* **VectorImageEPSPixelsPerEm** – Used with **Vector Based Images (EPS, AI, PDF, SVG): Pixels per em** in Options: Import. Default is 512.00.

### Preview
* **FeaturesWidth** – OpenType features width.
* **FeatureTags** – OpenType features tags.
* **PreviewFeatures** – Enable or disable any OpenType feature for the preview text.
* **PreviewFontSize** – Select the size in the Test Font window. Default is 24.
* **PreviewSampleFontSize** – Select the size in the Preview window.
* **PreviewSampleText** – Used with the dropdown box in the Preview window. Default is **High-Logic ©** (old versions) or **&lt;enter preview text here&gt;**.
* **PreviewSampleUseKerning** – Set this value to on to kern text in the Preview window.
* **ShowToolbarWindowPreview** – Show or hide the Preview window. Default is on.
* **StrikeThrough** – Used for **Strikeout** in the Test Font window. Default is off.
* **Underline** – Used for **Underline** in the Test Font window. Default is off.

### Reg
The program is started in unregistered mode either after the installation process is finished or if all keys are empty. Many people provided registration keys for different versions.
* **V5D#** – Created after registration whereas # is a numerical string. It displays a message and removes the **Buy** menu and the **Register** item on the Help menu. Version 6.0 & above places your name on the title bar.

### Themes (version 3.0 until 6.5)
* **ActiveTheme** – Contains the active theme.

### Tip of the Day (version 3.0 until 6.5, used in `TTIPOFTHEDAYFORM`)
* **CurrentTip** – Current line number in `FontCreator.tip`, used after opening.
* **ShowTipOnStartup** – Used when selecting **Show this screen next time when you start FontCreator**. Default is on.

### Validation
* **DiagonalRedundantOffCurvePointsDetection** – Used with **Diagonal redundant points detection: Maximum off-curve distance** in Settings: Validation.
* **DiagonalRedundantOnCurvePointsDetection** – Used with **Diagonal redundant points detection: Maximum on-curve distance** in Settings: Validation.
* **EnableGlyphProblemDetection** – Used with **Enable Real-Time** in the Validation toolbar.
* **LocalExtremeCoordinatesDetection** – Used with **Off-curve extreme coordinates: Local detection** in Settings: Validation. Default is on.
* **MaximumRedundantOffCurvePointsDistance** – Used with **Diagonal redundant points detection: Maximum off-curve distance** spinner in Settings: Validation. Default is 0.20.
* **MaximumRedundantOnCurvePointsDistance** – Used with **Diagonal redundant points detection: Maximum on-curve distance** spinner in Settings: Validation. Default is 0.80.
* **ShowIntersection** – Used with **Show Intersecting** in the Validation toolbar. If enabled, intersecting contours are shown for each glyph. If disabled, no intersecting contours are shown for each glyph. If the glyph is too complex, the button will appear dimmed.
* **ShowWarningPoints** – Used with **Show Warning Points** in the Validation toolbar. If enabled, warning points are shown for each glyph. If disabled, no warning points are shown for each glyph. If the glyph is too complex, the button will appear dimmed.
* **TestContoursWithIncorrectDirection** – Used with **Validation Tests: Contours with incorrect direction** in the Font Validation Wizard and **Correct Contour Directions** in the Validation toolbar. Default is on.
* **TestContoursWithOneOrTwoPoints** – Used with **Validation Tests: Contours with one or two points** in the Font Validation Wizard and **Remove Components** in the Validation toolbar. Default is on.
* **TestDuplicateComponents** – Used with **Validation Tests: Duplicate components** in the Font Validation Wizard and **Remove Components** in the Validation toolbar. Default is on.
* **TestDuplicateContours** – Used with **Validation Tests: Duplicate contours** in the Font Validation Wizard and **Remove Duplicate Contours** in the Validation toolbar. Default is on.
* **TestDuplicateKnots** – Used with **Validation Tests: Duplicate knots** in the Font Validation Wizard and **Remove Duplicate Knots** in the Validation toolbar. Default is on.
* **TestEmptyComponents** – Used with **Validation Tests: Empty components** in the Font Validation Wizard and **Remove Components** in the Validation toolbar. Default is on.
* **TestFixDetectedProblems** – Used with **Fix detected problems** in the Font Validation Wizard. Default is off.
* **TestIntersectingComponents** – Used with **Validation Tests: Intersecting components** in the Font Validation Wizard. Default is on.
* **TestIntersectingCoordinates** – Used with **Validation Tests: Intersecting coordinates** in the Font Validation Wizard. Default is on.
* **TestOffCurveExtremeCoordinates** – Used with **Validation Tests: Off-curve extreme coordinates** in the Font Validation Wizard and **Add Off-Curve Extremes** in the Validation toolbar. Default is on.
* **TestOverlappingComponents** – Used with Validation Tests: Overlapping components** in the Font Validation Wizard. Default is on.
* **TestRedundantPoints** – Used with **Validation Tests: Redundant points** in the Font Validation Wizard and **Remove Redundant Points** in the Validation toolbar. Default is on.
* **TestSuspiciousPoints** (version 11.0.0.2365 & above) – Used with **Validation Tests: Suspicious points** in the Font Validation Wizard. Default is on.
* **ValidationMaxNumberOfCompositeGlyphMembers** – Used with **Real-time glyph validation: Disable when number of members exceeds** in Settings: Validation. Default is 1000.
* **ValidationMaxNumberOfContours** – Used with **Real-time glyph validation: Disable when number of contours exceeds** in Settings: Validation. Default is 100.
* **ValidationMaxNumberOfPoints** – Used with **Real-time glyph validation: Disable when number of points exceeds** in Settings: Validation. Default is 25.

### Warn (used in Options: Advanced)
* **WarnBeforeActivatingFixFeature** (version 4.0 until 6.5) – Used with **Warn before activating the fix feature in the Font Validation Wizard**. Default is on.
* **WarnBeforeActivatingRemoveFeature** (version 4.0 until 6.5) – Used with **Warn before activating a remove feature from the Options → Font page**. Default is on.
* **WarnBeforeAddCharacters** (version 5.0 until 6.5) – Used with **Warn before adding characters**. Default is on.
* **WarnBeforeAnchorDelete** and **WarnBeforeAnchorDelete2** – Used with **Warn when deleting an anchor used by OpenType features**. Default is on.
* **WarnBeforeCloseOpenTypeDesigner** – Used with **Warn about losing changes when cancelling or closing OpenType Designer dialog**. Default is on.
* **WarnBeforeExecutingGlyphTransformProgram** (version 4.5 & above) – Used with **Warn before executing a glyph transformer script**. Default is on.
* **WarnBeforeSortingGlyphs** (version 5.0 until 6.5) – Used with **Warn before sorting glyphs**. Default is on.
* **WarnImportSmallImage** – Used with **Warn when importing small image**. Default is on.
* **WarnWhenOpening10OrMoreFonts** – Used with **Warn when opening 10 or more fonts**. Default is on.
* **WarnWhenProcessingVOLTTable** (version 9.0 until 11.0; in recent versions, it is hidden and moved all the way down) – Used with **Warn when opening a font file which contains a VOLT table**. Default is on.

## Cursors in the executable file (Delphi resources omitted)
* **CZCANCEL** – Used when canceling actions. This resource uses Argentinian Spanish language.
* **CZMOVE** – Used by the **Hand** feature. This resource uses Argentinian Spanish language.
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
* **RZCMBOBX_DEVICE** – Used in the font dropdown list.
* **RZCMBOBX_FIXEDPITCH** – Used in the font dropdown list.
* **RZCMBOBX_PRINTER** – Used in the font dropdown list.
* **RZCMBOBX_TRUETYPE** – Used in the font dropdown list.
* **RZCMBOBX_TRUETYPEFIXED** – Used in the font dropdown list.
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
* **CLOUDS** (unused) – It's not a bitmap but is a picture of multi-colored clouds.
* **DESCRIPTION**, **ELDATA** and **PLATFORMTARGETS** (unused) – These are binary resources.
* **DVCLAL** (unused) – Shows two paragraphs saying the license key is valid and is running C++ Builder Professional.
* **PACKAGEINFO** (unused) – Shows all functions and the Pascal log used to compile the program.
* **TABOUTDIALOG** and **TABSTRACTABOUTDIALOG** (**TABOUTFORM** and **THLCREGISTERABOUTBOXDLG** in old versions) – Displays copyright, program/operating system version number, physical memory, registration information and MPL Licensed Open Source Software (version 6.0 & above) (**Help: About...**).
* **TABSTRACTWELCOMEDIALOG** (**TWELCOMEFORM** in old versions) – Used by newcomers if `OnStartupShowWelcome` is enabled.
* **TADDCHARACTERSFORM** (version 5.0 & above) – Adds characters as empty glyphs to the font. This requires the Unicode information to be present. If the Unicode information is corrupted, it will show a range check error. In version 4.0 the feature is hidden and it adds glyph data from another font/only adds one character. In version 5.0 & above it adds up to 65,535 characters. The Arial Unicode MS font was used in the form showcasing the Currency Symbols through Letterlike Symbols blocks in the font with the lira character selected in the manual. The characters that the selected font lacks are shaded gray.
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
* **TANCHORMANAGERFRAME** and **TANCHORMANAGERFRM** (version 8.0 & above) – Manages anchors in the font if positioning data exists in the OpenType layout tables.
* **TAUTOKERNEXFORM** (**TAUTOKERNINGFORM** in version 3.0.1 until 6.5) – Automatically add kerning pairs to the OpenType layout tables (version 7.0 & above) or legacy kerning tables (version 1.0 until 6.5) if you don't want to manually add kerning pairs to the font via the OpenType Designer. The Garava and Times New Roman (previously) fonts were used in the form as shown in the manual.
* **TAUTOMETRICSFORM** (version 3.0.1 & above) – Automatically generate metrics for glyphs for use with proportional fonts. Don't use this feature for monospaced, pixel or barcode fonts! The optical metrics adjustment user interface is used by *Scanahand* (font generator). The Calibri and Times New Roman (previously) fonts were used in the form's second page (selecting glyphs) as shown in the manual.
* **TAUTONAMEFORM** (version 3.1.2 until 6.5) – Automatically change the naming fields of a font. The MegaWaves font was used in the form as shown in the manual.
* **TAXISVALUEMULTIFORM** – Edits axis value combinations in the font.
* **TBASICEDITFORM** (**TADVANCEDNAMINGFORM** in version 3.0 until 6.5) – Edit a naming field or include additional naming fields in the font (replaced with Properties in version 7.0 & above). The MegaWaves font was used in the form as shown in the manual.
* **TCHANGETAGFORM** (version 7.0 & above) – Changes tags in the OpenType layout tables.
* **TCHARACTERTOGLYPHINDEXMAPPINGFORM** (version 2.0 until 6.0, **Tools: TODO! AutoCmap...** in version 3.0 until 5.6 as hidden menu item) – Maps characters to glyph indexes. The Arial font was used in the form as shown in the manual. This corresponds to the `cmap` table.
* **TCLASSMANAGERFORM** (version 7.0 & above) – Changes classes in the OpenType layout tables.
* **TCODEEDITORFORM** (version 7.0 & above) – OpenType Layout Feature Editor; used to view, edit and compile the OpenType feature source code.
* **TCODEPAGERANGEFORM** – Includes or excludes code pages to support in the font. This corresponds to the `ulCodePageRange` fields to make the font work in some programs (e.g. Sublime Text). If the fields are not set (e.g. Hindsight Unicode), then Windows will show the script dropdown menu in the font selection dialog as **Other**.
* **TCOLORFORM** (old versions) – This resource is not the standard Windows color selection dialog available in `comdlg32.dll`.
* **TCOMPOSITEGLYPHPROPERTIESFORM** – Views or modifies properties for composite glyph members. The Calibri font was used in the form as shown in the manual (using the lowercase e acute).
* **TCONFIRMREPLACEDIALOG** (version 10.0 until 10.1.0.2272) – This confirmation dialog will ask you what to do when replacing.
* **TCONVERTBITMAPTOCONTOURSFORM** – Converts bitmap images to contours or imports raster images to any glyph in the font.
* **TDELETEFEATURELOOKUPFORM** (version 7.0 & above) – Removes features or lookups from the OpenType layout tables in the font.
* **TDELETEKERNGROUPFORM** (version 7.0 & above) – Removes kerning groups or classes from the OpenType layout tables in the font.
* **TDISABLEDFORM** (version 5.0 & above) and **TABSTRACTDISABLEDIALOG** (version 12.0.0.2565 & above) – Used in unregistered copies during (recent versions) or after a grace period of 30 days (old or recent versions). If this form is deleted, it will either show a non-existing form message (old versions) or a text only message (recent versions).
* **TDM** (version 4.0 & above) – Contains icons with no regard to `Glyph.Data` in old versions. Version 5.5 (2006-05-30) until 11.0.0.2365 (2017-05-10) uses icons in e.g. Microsoft Office 2003 up to 2010. The icons were changed in version 12.0 & above.
* **TDMGLOBAL** – Contains codepages, vendors, hinting and bidirectional mirroring data.
* **TEDITANCHORFORM** (version 7.0 & above) – Edits anchors in the font if any glyph has positioning data.
* **TEXPORTGLYPHDATAFORM** (version 4.0 until 6.5) – Exports glyph data to fgd files (**Tools: Export Glyph Data...**). Recent versions are limited to only one glyph.
* **TEXPORTSETTINGSFORM** and **TEXPORTSETTINGSFRAME** – Configure font export settings.
* **TEXTERNALSFORM** – Edit the three custom external tools (**Tools: Launch Externals: Configure Externals...**).
* **TEXTRACTFROMTTCFORM** (version 4.0 & above) – Extract TrueType or OpenType font collections to multiple font files (**Tools: Extract from OTC...**). The SimSun font was used in the form as shown in the manual. If the unregistered copy detects it is running after a grace period of 30 days, **TDISABLEDFORM** (old versions) or the **Evaluation Period Expired** message (recent versions) is shown instead. This corresponds to the `MiToolsExtractFromTTCClick` function used by `CheckLicenseNotGood`.
* **TFEATURESETTINGSFORM** (version 12.0) and **TFEATURESFRAME** – Generates or updates feature code in the OpenType Designer.
* **TFINDFORM** – Searches parts of a font.
* **TFONTEMBEDDINGLICENSINGRIGHTSFORM** (version 2.0 until 6.5) – Shows a list of embedding or licensing rights to use in the font (replaced with **Legal: Embedding Licensing Rights** in `TFONTSETTINGSFORM` in version 7.0 & above).
* **TFONTHEADERFLAGSFORM** – Enables or disables header flags in the font.
* **TFONTINSTALLWIZARDFORM** – Installs the font to the computer (version 6.0 & below requires saving the font). **Fun fact:** The file path in the first step is dummy. The second step (font already installed) names the installed font as Arial (`c:\win98\fonts\arial.ttf` - **win98** stands for Windows 98). The MegaWaves font was used in the form as shown in the manual. If the unregistered copy detects it is running after a grace period of 30 days, **TDISABLEDFORM** (old versions) or the **Evaluation Period Expired** message (recent versions) is shown instead. This corresponds to the `InstallFont` and `miFontInstallClick` functions used by `CheckLicenseNotGood`.
* **TFONTLOGFORM** – Displays the font log (**Developer Tools: Font Log**).
* **TFONTOVERVIEWFORM** – Shows all the glyphs included in the font. The Calibri and Courier New (previously) fonts were used in the form as shown in the manual. The Cambria font was used in the form as shown in the Font Inspection tutorial. The Fredoka (variable font regular style), Kabala (extra-bold style), Pali (previously) and Verajja (showing the Latin-1 Supplement Unicode block sorted by Mac codepoint) fonts were used in the form as shown in the program's official screenshots. The Lato font (used in the company's website) was used in the form as shown in the Running FontCreator on a Mac tutorial.
* **TFONTPROPERTIESFORM** and **TFONTPROPERTIESFRAME** – Contains properties and unsupported tables (version 7.0 & above) in the font. If the non-Unicode language is Chinese, Japanese or Korean, the hexadecimal data text box in the **Unsupported Tables** tab substitutes Latin-1 accented letters by ASCII forms, e.g. Wästman by Wastman and some Latin-1 symbols by fullwidth forms or other symbols, e.g. £ by ￡ and « by ≪. The MegaWaves font was used in the form's identification and legal tabs as shown in the manual.
* **TFONTSETTINGSFORM** – Contains basic naming fields or metrics settings, Unicode and code page ranges, gasp ranges and more.
* **TFONTTABLESFORM** (version 2.0 until 6.5) – Shows a list of supported and unsupported tables in the font. Unsupported tables is a separate tab in the font properties window in version 7.0 & above.
* **TFONTTESTFORM** – Test desktop fonts (not web fonts). The default text in `mmFontTest` and `Memo1` (version 7.0 & above) in version 4.0 until 5.6 is the program name, letters and numbers with DOS/Windows Latin-1 and USA characters (version 6.0 & above removes the characters at the end and adds High-Logic FontCreator at the beginning). Version 1.1.1c until 5.0 allows the user to change the encoding (it was removed in version 5.5 & above). The Verajja font was used in the form in a size of 24 points with the pangrams sample text selected as shown in the manual. If the unregistered copy detects it is running after a grace period of 30 days, **TDISABLEDFORM** (old versions) or the **Evaluation Period Expired** message (recent versions) is shown instead. This corresponds to the `TestFontTTFOTF` (`miFontTestTTFOTFClick`) and `TestFontWOFF` (`btnFontTestWoffClick`) functions used by `CheckLicenseNotGood`.
* **TFORMADDANCHOR** (version 7.0 & above) – Adds anchors to any glyph in the font if OpenType positioning data exists.
* **TFORMEDITANCHOR** (version 7.0 & above) – Edits anchors in any glyph in the font if OpenType positioning data exists.
* **TFORMINSERTGLYPHS** (**TINSERTGLYPHFORM**) – Inserts glyphs in the font.
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
* **TGENERATEPROBLEMREPORTFORM** – Used when pressing **Next** in the Glyph Validation Wizard (the window is titled **Report**).
* **TGLYPHALREADYMAPPEDFORM** (version 3.0 until 6.5) – For each platform a character to glyph index mapping can only exist once, so if you try to add a mapping that already exists this window will ask you what to do.
* **TGLYPHEDITFORM** – Used when opening any glyph from the overview.
* **TGLYPHNAMEFORM** – Used when changing glyph names.
* **TGLYPHPROPERTIESFORM** (version 2.0 until 6.5) and **TGLYPHPROPERTIESFRAME** – Used where you can change various properties for the selected glyph.
* **TGRIDFORM** – Used when changing grid settings.
* **TGUIDELINEMODIFYFORM** – Used when modifying guidelines.
* **TGUIDELINESFORM** – Used when changing guideline settings.
* **TIMPORTGLYPHDATAFORM** – Used when importing glyph data.
* **TINSERTGLYPHFORM** – Used when inserting glyphs.
* **TINSTALLEDFONTSFORM** – Displays a dialog with all installed fonts in the computer to either view or open them. Version 10.1.0.2272 (2016-12-20) & below had a waiting delay.
* **TKERNFEATUREFRAME** – Used by the kerning window.
* **TKERNGROUPMANAGERFORM** – Used when managing kerning groups or classes in the font.
* **TKERNINGFORM** (version 3.0 until 6.5) – Displays a dialog where you can view or edit the legacy kerning tables (not the GPOS kerning tables) in the font. See `TOPENTYPEDESIGNERFORM` in recent versions.
* **TKERNINGNEWPAIRFORM** (version 3.0 until 6.5) – Used when adding a kerning pair to the legacy kerning tables (not the GPOS kerning tables).
* **TKERNINGNEWSINGLEFORM** – Used when adding a single adjustment to the font.
* **TMAINFORMFONTCREATOR** (**TMAINFORMFCP3** in version 3.0) – Main window for FontCreator, toolbars and more. The main window has two hidden menus (Hidden Shortcuts and Developer Tools) which can be shown by removing `Visible = False`. In the Tools menu is an option labeled **TODO! Customize...** which can be shown by removing the same value in the two hidden menus.
* **TMETRICSFORM** – Used when configuring metrics options.
* **TNAMINGFORM** (version 3.0 until 6.5) – Displays a dialog where you can manually change the naming fields of a font. See `TFONTPROPERTIESFORM` in recent versions.
* **TNEWTRUETYPEFONTFORM** – Used when creating a new font.
* **TOPENTYPEDESIGNERFORM** (version 7.0 & above) – Displays a dialog where you can create or edit the OpenType layout tables.
* **TOPENTYPEITEMADDFRM** (version 7.0 & above) – Used when adding an item to the OpenType layout tables.
* **TOPTIONSFORM** – Displays a dialog where you can set a plethora of FontCreator options in the above registry key headings.
* **TOTLFRENAMEFORM** (version 7.0 & above) – Used when renaming layout features in the OpenType layout tables.
* **TPASTESPECIALFORM** – Used when pasting data for glyphs in the clipboard. In the Items list (version 5.5 until 6.5), **Glyph Outline Data** and **Glyph Metrics** (i.e. the first two items) are checked by default. In recent versions, the registry keys are stored in the `Edit` key.
* **TPCLTFORM** (version 3.0 until 6.0) – Displays a dialog where you can add, view or edit the PCL5 data for use with old printers.
* **TPERFORMTRANSFORMATIONFORM** (version 5.6 & above) – Displays the Glyph Transformer.
* **TPLATFORMMANAGERFORM** (version 2.0 until 6.0) – Displays a dialog where you can choose which platform to support in the font.
* **TPOSTSCRIPTNAMESFORM** (version 2.0 until 6.0) – Displays a dialog where you can view or edit the PostScript glyph names in the font. Version 1.0 (1998-04-11) until 7.0 (2013-04-25) can only generate PostScript names for glyphs with Unicode BMP mapping.
* **TPRINTABORTFORM** – Used after the font printing process is started.
* **TPRINTFONTFORM** – Used when printing anything in the font.
* **TPRINTGLYPHFORM** – Used when printing a glyph.
* **TPROGRESSFORM** – Progress window. The cursor for this form is **Busy**. The default push button is **Cancel**.
* **TREGISTERFORM** – For unregistered copies of FontCreator, displays a dialog where you can enter the registration code (**Help: Register**). This removes the splash screen on startup and enables most features disabled in versions 6.0 and 8.0 until 12.0.2539 for unregistered users.
* **TRESOURCEEDITORDLG** – In old versions only, used when editing resources.
* **TSELECTCOMPOSITEGLYPHMEMBERFORM** – Used when adding glyph members to a composite glyph. The default push button is **OK**.
* **TSHAREWAREFORM** – For old versions and unregistered copies of FontCreator, displays this notice when pressing **Start** on the splash screen after the trial period is exceeded. (Only in old versions)
* **TSORTGLYPHSFORM** – Used when changing the glyph order within a font. The default push button is **OK**.
* **TSPLASHFORM** – Displays this form on startup when the Reg key is not found. The three buttons at the bottom are displayed in random order. If the trial period is exceeded, when starting the program five times it displays a random paragraph.
* **TTIPOFTHEDAYFORM** – Used in version 1.0 until 6.0 and also for newcomers and also in **Help: Tip of the Day**. FontCreator.tip will be used to display tips. On unregistered copies is a button labeled **Register**. If removed when not registered, it displays the "Access Violation". See FontCreator: Tips and Tricks in the High-Logic font forum for more details.
* **TTRANSFORMFORM** – For simple glyphs only. The default push button is **Apply**.
* **TUNICODERANGEFORM** – Used when specifying the Unicode blocks or ranges encompassed by the font file in the mappings for double-byte platforms. The default push button is **OK**.
* **TUPDATEREMINDERFORM** – Used when the program checks for updates as if **OnStartupShowUpdateReminder** is enabled. The default push button is **OK**.
* **TUSEDBYFORM** – Displays an overview of all glyphs that use the selected glyph. The default push button is **OK**.
* **TVALIDATIONWIZARDFORM** – Displays a dialog where you can validate the font for errors. The default push button is **Next**.
* **TWARNINGFORM** – Used for warnings. (See also TWIDEWARNINGFORM in new versions)
* **TWELCOMEFORM** – Used for newcomers as if **OnStartupShowWelcome** is enabled. The default push button is **OK**.
* **TWIDEMESSAGEFORM** – Used for messages.
* **TWIDEWARNINGFORM** – Used for warnings, replaces TWARNINGFORM in old versions.
